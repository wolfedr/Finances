Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.VisualBasic

Public Class SiblingCheck
    Dim oCommand As SqlCommand
    Dim reader As SqlDataReader
    Dim cn As SqlConnection
    Dim dr As SqlDataReader
    Dim LoadComplete As Boolean = False
    Public gblSibID As Integer
    Public gblBusID As Integer
    Public gblNewBusID As Integer
    Public gblActID As Integer
    Private intSiblingID As Integer
    Private intAccountID As Integer
    Dim aryAccount As ArrayList = New ArrayList
    Protected lst As New List(Of String)
    Protected lstAll As New List(Of String)
    Dim mySource As New AutoCompleteStringCollection()

    Private Structure struBase
        Public busID As Integer
        Public busName As String
        Public busSibling As Integer
    End Structure

    Private Sub SiblingCheck_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strName As String = AddBusiness.gblBusName
        'Dim aryBus As New ArrayList()
        txtNewListedName.Text = strName
        'Clear off or hide old data.
        lblGridInstructions.Visible = False
        lblGrid.Visible = False
        gvBusiness.Visible = False
        txtCommonBusName.Text = ""
        FillBusDD()
        ddlBusiness.DroppedDown = False
        If Me.ddlBusiness.CanFocus Then  'can() 't receive focus
            ddlBusiness.Focus()
        End If
        ' txtCommonBusName.Text = ""
        txtSiblingID.Text = ""
        'txtNewListedName.Text = ""
        txtNewListedName.Focus()
        LoadComplete = True
    End Sub
    Private Sub FillBusDD()
        Dim strSql As String = "select distinct busID, busName, taggedAccount from tblBusiness where busSiblingID = 1 order by busname"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        reader = oCommand.ExecuteReader()
        Dim aryBusiness As ArrayList = New ArrayList
        aryBusiness.Add(New AddValue("Start Typing Name!", 0))
        While reader.Read()
            lst.Add(reader.GetString(1))
            Dim y As String = reader.GetInt64(0)
            lstAll.Add(reader.GetString(1) & "|" & reader.GetInt64(0).ToString & "|" & reader.GetInt64(2).ToString)
            Dim x As String = reader.GetString(1)
            ' Dim y As String = reader.GetInt64(0)
            Dim z As String = reader.GetInt64(2)
            aryAccount.Add(z)
            aryBusiness.Add(New AddValue(reader.GetString(1), Convert.ToInt64(reader.GetInt64(0))))
        End While
        reader.Close()
        cn.Close()
        mySource.AddRange(lst.ToArray)
        ddlBusiness.AutoCompleteCustomSource = mySource
        ddlBusiness.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddlBusiness.AutoCompleteSource = AutoCompleteSource.CustomSource
        ddlBusiness.DisplayMember = "Display"
        ddlBusiness.ValueMember = "Value"
        ddlBusiness.DataSource = aryBusiness
    End Sub

    Private Sub gvBusiness_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvBusiness.RowEnter
        If LoadComplete = True Then
            Dim i As Integer = e.RowIndex
            Dim cell0 As DataGridViewCell = CType(gvBusiness.Rows(e.RowIndex).Cells(0), DataGridViewCell)  'busName
            Dim cell1 As DataGridViewCell = CType(gvBusiness.Rows(e.RowIndex).Cells(1), DataGridViewCell)  'busLeftName 
            Dim cell2 As DataGridViewCell = CType(gvBusiness.Rows(e.RowIndex).Cells(2), DataGridViewCell)  'taggedAccount busID  busSublingID'
            Dim cell3 As DataGridViewCell = CType(gvBusiness.Rows(e.RowIndex).Cells(3), DataGridViewCell)  'busSublingID
            'Dim cell4 As DataGridViewCell = CType(gvBusiness.Rows(e.RowIndex).Cells(4), DataGridViewCell)  'taggedAccount
            intAccountID = cell2.Value
            If LoadComplete = True Then
                If cell1.Value <> Nothing Then
                    If intSiblingID = 0 Then
                        txtSiblingID.Text = "None"
                    Else
                        txtSiblingID.Text = (intSiblingID).ToString()
                    End If
                    gblSibID = intSiblingID
                    txtSiblingID.Text = (cell3.Value + 1).ToString().Trim
                    txtCommonBusName.Text = cell0.Value.ToString().Trim.ToUpper
                    intAccountID = cell2.Value
                    gblActID = intAccountID
                    'gblBusID = cell2.Value
                End If
            End If
        End If
    End Sub

    Private Sub btnAcceptMatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceptMatch.Click
        Dim tempInt As Integer = 1
        Dim intNewRecord As Integer
        Dim strSql As String
        Try
            If txtSiblingID.Text.ToUpper = "NONE" Then
                tempInt = 2  'This happens when starting a grouping. The inital entry will become 1, and the first addition will be 2
                'Update the original sibling ID to a 0 .
                strSql = "Update tblBusiness set busSiblingID = 1 where busID = " & gblBusID
                oCommand = New SqlCommand(strSql, cn)
                cn.Open()
                oCommand.ExecuteNonQuery()  'This gets the identity it was inserted as. Not used at present.
            Else
                strSql = "Select Max(busSiblingID) from tblBusiness where busName = '" & txtCommonBusName.Text.ToUpper & "'"
                If cn.State = ConnectionState.Closed Then cn.Open()
                oCommand = New SqlCommand(strSql, cn)
                tempInt = oCommand.ExecuteScalar()
                tempInt += 1
            End If
            If txtCommonBusName.Text.ToUpper = ddlBusiness.Text.ToUpper.Trim Then
                'Insert the new buiness with the alias into the database.
                strSql = "insert into tblBusiness (busName, busLeftName, busSiblingID, taggedAccount) values ('" & txtCommonBusName.Text.ToUpper & "', '"
                strSql += Microsoft.VisualBasic.Left(txtNewListedName.Text, 20) & "', " & tempInt & ", " & intAccountID & ") SET @ID = SCOPE_IDENTITY()"
                If cn.State = ConnectionState.Closed Then cn.Open()
                oCommand = New SqlCommand(strSql, cn)
                Dim IDParam As SqlParameter = New SqlParameter("@ID", SqlDbType.Int)
                IDParam.Direction = ParameterDirection.Output
                oCommand.Parameters.Add(IDParam)
                oCommand.ExecuteNonQuery()
                intNewRecord = IDParam.Value
                cn.Close()
                gblNewBusID = intNewRecord
                gblSibID = tempInt
                AddBusiness.gblBusName = txtNewListedName.Text
                AddBusiness.gblActID = intAccountID
                AddBusiness.txtDisplayName.Text = txtCommonBusName.Text.ToUpper
                Me.Close()
            Else
                MessageBox.Show("The Business to Match must be the same as the Common name. " & vbCrLf & "Select another from the list below.", "Alert", MessageBoxButtons.OK)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR! " & vbCrLf & ex.Message, "SIbling Error", MessageBoxButtons.OK)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()

        End Try

        Me.ClearForm()
        Me.Close()
    End Sub

    Private Sub btnNoMatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoMatch.Click
        gblNewBusID = 0
        gblSibID = 1
        If Len(txtCommonBusName.Text) > 0 Then
            AddBusiness.gblBusName = txtCommonBusName.Text.ToUpper
            AddBusiness.txtDisplayName.Text = txtCommonBusName.Text.ToUpper
            AddBusiness.txtBusiness.Text = txtNewListedName.Text
        End If

        Me.Close()
    End Sub

    Private Sub Skip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddBusiness.Close()
        Me.Close()
    End Sub

    Private Sub ddlBusiness_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlBusiness.SelectedIndexChanged
        If LoadComplete = True Then


        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gvBusiness.Visible = False
        ddlBusiness.SelectedIndex = 0
        txtCommonBusName.Text = ""
        txtSiblingID.Text = ""

    End Sub


    Private Sub btnAcceptChoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceptChoice.Click
        If ddlBusiness.SelectedIndex <> 0 Then
            lblGrid.Visible = True
            lblGridInstructions.Visible = True
            gvBusiness.Visible = True
            Dim strName As String = ddlBusiness.Text
            Dim aryBus As New ArrayList()
            Dim ds As DataSet
            Dim da As SqlDataAdapter
            ds = New DataSet
            Dim strSql As String = "select distinct  busName as [Name],  busLeftName as [Raw Name], taggedAccount as Account, max(busSiblingID) as Entries, b.actDescription from tblBusiness , tblDRCOA b "
            strSql += "where taggedAccount = b.acntID and ltrim(busName) = '" & strName & "' group by busName, busLeftName, TaggedAccount, b.actDescription "
            cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
            da = New SqlDataAdapter(strSql, cn)
            cn.Open()
            da.Fill(ds)
            gvBusiness.DataSource = ds.Tables(0)
            Dim maxRows As Int16 = ds.Tables(0).Rows.Count
            'Dim maxNUm As Int16 = ds.Tables(0).Rows(maxRows - 1).Item(3)
            cn.Close()
            If ds.Tables(0).Rows.Count = 0 Then
                txtSiblingID.Text = "1"
            Else
                txtSiblingID.Text = maxRows + 1
                'lblStatus.Text = "A similar business name has been found to the one you are adding."
            End If
            'gvBusiness.Visible = False
            lblGrid.Visible = False
            'txtCommonBusName.Text = txtNewListedName.Text.ToUpper
            ' btnAcceptDefault.Visible = False
            gvBusiness.Visible = True
        Else
            txtSiblingID.Text = 1
        End If
        txtCommonBusName.Enabled = True
        txtSiblingID.Enabled = True


    End Sub
    Sub ClearForm()
        txtCommonBusName.Text = ""
        grpEnter.Visible = False
    End Sub

    
End Class

