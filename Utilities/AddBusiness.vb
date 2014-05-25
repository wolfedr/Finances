Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.VisualBasic
Public Class AddBusiness
    Dim oCommand As SqlCommand
    Dim reader As SqlDataReader
    Dim cn As SqlConnection
    Dim dr As SqlDataReader
    Dim LoadComplete As Boolean = False
    Public gblBusID As Long
    Public gblBusName As String
    Public gblActID As Integer
    Public gblActNum As Integer
    Public gblActSeq As Integer

    Private intBusIDNew As Integer

    Private Sub AddBusiness_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Next line gets all businesses and filters out duplicates that are from groupings
        Dim strID As String = Me.frmCalling
        lblHdnSource.Text = strID
        Dim strSql As String = "select busID, busName, busLeftName, busSiblingID, taggedAccount from tblBusiness where busSiblingID = 0 order by busname"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        reader = oCommand.ExecuteReader()
        Dim aryBusiness As ArrayList = New ArrayList
        While reader.Read()
            Dim x As String = reader.GetString(2)
            Dim y As String = reader.GetInt64(0)
            gblBusID = reader.GetInt64(0)
            aryBusiness.Add(New AddValue(reader.GetString(2), Convert.ToInt64(reader.GetInt64(0))))
        End While
        reader.Close()
        cn.Close()
        ddlBusiness.DisplayMember = "Display"
        ddlBusiness.ValueMember = "Value"
        ddlBusiness.DataSource = aryBusiness
        ddlBusiness.Visible = False
        ClearForm()

        txtBusiness.Visible = True
        'If there as a global name provided then it is a new name being added. The form does not get populated
        If Len(gblBusName) > 0 Then
            txtBusiness.Text = gblBusName
            intBusIDNew = GroupBusiness(gblBusName)  'This can come from PostBankToJournal and SiblingCheck
            'If a value is returned from sibling ID then a sibling record was inserted and now we need to uupdate it as if an edit.
            'Add missing fields and then click save. The   Ed it button is highlited and the textbox contains the common name. 
            'The record will be update based on newBusID returned from siblingcheck
            'The source of the update info is what we enter for the new location or business linked to the old.
            gblBusID = SiblingCheck.gblBusID

            If intBusIDNew > 0 Then  'This means an existing buisiness withthe common name was found and the new one was added. Needs update now
                'txtDisplayName.Text = SiblingCheck.txtCommonBusName.Text
                txtBusiness.Text = SiblingCheck.txtNewListedName.Text
                btnAdd.Text = "Add New"
                gblActID = SiblingCheck.gblActID
                lblActivity.Text = "You are editing this entry!"

            Else
                lblActivity.Text = "You are adding this new entry!"
                txtDisplayName.Text = SiblingCheck.txtCommonBusName.Text
                txtBusiness.Text = SiblingCheck.txtNewListedName.Text
                btnAdd.Text = "Edit"
            End If

            'ClearForm()

        Else  'This means there is no name sent in with an entry that needs one. Return to Post form to add from there.
            'Me.Close()
            'GetBusiness.ddlBusiness.SelectedIndex = 0
            'GetBusiness.Close()
            'PostBankToJournal.Show()
            'lblActivity.Text = "You are adding this new entry!"
            'ddlBusiness.Visible = False
            'txtBusiness.Visible = True
            'dgvAccounts.Visible = True
            'ClearForm()
            'btnAdd.Text = "Edit"
        End If

        'dgvAccounts.Visible = False
        rbExpense.Checked = True
        DisplayGrid()
        LoadComplete = True
    End Sub
    Function GroupBusiness(ByVal busName As String) As Integer
        SiblingCheck.ShowDialog()  'Pop up sibling check form for deciding if this entry is in a group or is a new one.
        Dim intSibResponse As Integer = SiblingCheck.gblSibID
        Dim intNewbusID As Integer = SiblingCheck.gblNewBusID
        Select Case intSibResponse
            Case Is > 1
                txtHasSibling.Text = "Yes"

            Case 1
                txtHasSibling.Text = "No"

                Return intNewbusID

            Case Else
        End Select
        If intSibResponse > 0 Then

        Else

        End If
        txtMaxID.Text = intSibResponse.ToString()
        'Dim intNewbusID As Integer = SiblingCheck.gblNewBusID
        Dim busID As Integer = SiblingCheck.gblBusID
        gblBusID = busID
        Dim intActID As Integer = SiblingCheck.gblActID
        'Get the account from the account ID passed in
        hdnActID.Text = intActID.ToString()
        gblActID = intActID
        Dim strSql As String = "Select (ltrim(str(actNum)) + '-' + ltrim(str(actNumSeq))) as Account, actDescription from tblDRCOA where acntID = " & intActID
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            txtAccountNum.Text = dr(0)
            txtAccountname.Text = dr(1)
        End If
        dr.Close()
        cn.Close()
        Return intNewbusID
    End Function

    Sub PopulateForm(ByVal strFrom As String)
        Dim SelectedBusID As Integer
        'If strFrom = "GR" Then
        'SelectedBusID = SiblingCheck.gblBusID
        'Else
        Dim x As Object = ddlBusiness.SelectedValue
        SelectedBusID = ddlBusiness.SelectedValue
        'End If
        Dim strSql As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        strSql = "select a.*, b.actNum, b.actDescription, b.actName from tblbusiness a left outer join tblDRCOA b on a.taggedaccount = b.acntID where a.busID = " & SelectedBusID
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            gblBusID = dr.GetInt64(0)
            If Not IsDBNull(dr(1)) Then txtDisplayName.Text = dr(1)
            If Not IsDBNull(dr(5)) Then txtAddress1.Text = dr(5)
            If Not IsDBNull(dr(6)) Then txtAddress2.Text = dr(6)
            If Not IsDBNull(dr(7)) Then txtCity.Text = dr(7)
            If Not IsDBNull(dr(8)) Then txtState.Text = dr(8)
            If Not IsDBNull(dr(9)) Then txtZip.Text = dr(9)
            If Not IsDBNull(dr(10)) Then txtLPhone.Text = dr(10)
            If Not IsDBNull(dr(11)) Then txtCPhone.Text = dr(11)
            If Not IsDBNull(dr(12)) Then hdnActID.Text = dr(12)
            If Not IsDBNull(dr(13)) Then txtAccountNum.Text = dr(13).ToString()
            If Not IsDBNull(dr(14)) Then txtAccountname.Text = dr(14) & ":" & dr(13).ToString()
            dr.Close()
        Else
            MessageBox.Show("No Data Available for this choice", "Alert", MessageBoxButtons.OK)

        End If
        cn.Close()

    End Sub
    Sub DisplayGrid()
        On Error GoTo Error_Handler
        Dim strActType As String
        If rbExpense.Checked = True Then
            strActType = "expense"
        Else
            strActType = "income"
        End If
        Dim strSql As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        dgvAccounts.RowCount = 1 'This clears any data out of the gird
        strSql = "select acntID, (str(actNum) + '-' + LTrim(str(actNumSeq))) as actNumJoin, actName, actDescription "
        strSql += "from tblDRCOA where actUse = 20" & " And actTypeName = '" & strActType & "' "
        'lblCaption.Text = selectedAccount
        'Select Case selectedAccount
        '    Case "Assets"
        'strSql += " and actNum > 999 and actNum < 2000 "
        '    Case "Debts"
        'strSql += " and actNum > 1999 and actNum < 3000 "
        '   Case "Income"
        'strSql += " and actNum > 3999 and actNum < 7000 "
        '    Case "Expense"
        'strSql += " and actNum > 6999 and actNum < 10000 "
        '    Case Else
        'strSql = ""
        'End Select
        strSql += "order by actNum, actDescription "
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim dr As SqlDataReader = oCommand.ExecuteReader()
        Dim dt As New DataTable
        Dim count As Integer = dr.FieldCount - 1
        'add rows TO GRID
        Dim n As Integer = 0
        dgvAccounts.Refresh()
        Dim aRecord As String = ""
        Dim bRecord As String = ""

        Do While dr.Read()
            'If n <> 0 Then
            ''Dim s As String = dr(0).ToString()
            'Dim i As Int32 = Convert.ToInt32(dr(0))
            aRecord = Trim(dr(2).ToString())
            'End If
            If aRecord <> bRecord Then

                bRecord = aRecord
                dgvAccounts.Rows.Item(n).Cells(0).Value = dr(2).ToString()
                dgvAccounts.Rows.Item(n).Cells(1).Value = 0
                dgvAccounts.Rows.Item(n).Cells(2).Value = 0
                Me.dgvAccounts.Rows(n).Cells(0).Style.BackColor = Color.Cyan
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.dgvAccounts.Rows(n).Cells(0).Style.Font = New Font("calibri", 14, FontStyle.Bold)
                n = dgvAccounts.Rows.Add()
                'GoTo JUMP
                dgvAccounts.Rows.Item(n).Cells(0).Value = Trim(dr.GetString(3))
                dgvAccounts.Rows.Item(n).Cells(1).Value = Trim(dr.GetString(1))
                dgvAccounts.Rows.Item(n).Cells(3).Value = Convert.ToInt32(dr(0))
                n = dgvAccounts.Rows.Add()
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            Else
                dgvAccounts.Rows.Item(n).Cells(0).Value = Trim(dr.GetString(3))
                dgvAccounts.Rows.Item(n).Cells(1).Value = Trim(dr.GetString(1))
                dgvAccounts.Rows.Item(n).Cells(3).Value = Convert.ToInt32(dr(0))
                n = dgvAccounts.Rows.Add()
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            End If
            'Exit Sub
JUMP:   Loop
        cn.Close()
Normal_Exit:
        Exit Sub
Error_Handler:
        On Error GoTo 0
        Debug.WriteLine("An error occured: " & Err.Description)
        'Resume Normal_Exit

        If lblHdnSource.Text = "baseAddBusiness" Then
            MsgBox("Undefined Error: Contact developer to determine why Add Business is not showing!", MsgBoxStyle.OkOnly, "Error Handler")

            Me.Close()
            Main.Show()
        Else
            Me.Close()
            'GetBusiness.Close()
            PostBankToJournal.Show()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add New" Then
            lblActivity.Text = "You are adding this new entry!"
            ddlBusiness.Visible = False
            txtBusiness.Visible = True
            dgvAccounts.Visible = True
            ClearForm()
            btnAdd.Text = "Edit"
        Else
            lblActivity.Text = "You are now Editing this entry!"
            ddlBusiness.Visible = True
            txtBusiness.Visible = False
            dgvAccounts.Visible = True
            ClearForm()
            btnAdd.Text = "Add New"
        End If
    End Sub

    Private Sub dgvAccounts_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.RowEnter
        Dim i As Integer = e.RowIndex
        Dim cell1 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(1), DataGridViewCell)
        Dim cell2 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(0), DataGridViewCell)
        Dim cell3 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(3), DataGridViewCell)
        If LoadComplete = True Then
            If cell1.Value <> Nothing Then
                txtAccountNum.Text = cell1.Value.ToString().Trim
                txtAccountname.Text = cell2.Value.ToString().Trim
                hdnActID.Text = cell3.Value.ToString().Trim
            End If
        End If
    End Sub

    Private Sub ddlBusiness_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlBusiness.SelectedIndexChanged
        If LoadComplete = True Then
            ClearForm()
            PopulateForm("X")
            gblBusID = ddlBusiness.SelectedValue
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strSql As String
        Dim strMessage As String
        txtBusiness.Text = txtBusiness.Text.Replace("'", "")
        txtAddress1.Text = txtAddress1.Text.Replace("'", "")
        txtAddress2.Text = txtAddress2.Text.Replace("'", "")
        txtCity.Text = txtCity.Text.Replace("'", "")
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)

        cn.Open()
        If btnAdd.Text = "Add New" Then
            strMessage = "Successfully updated business record!"
            'update
            strSql = "Update tblBusiness set "
            strSql += "busAddress1 = '" & txtAddress1.Text & "', "
            strSql += "busAddress2 = '" & txtAddress2.Text & "', "
            strSql += "busCity = '" & txtCity.Text & "', "
            strSql += "busState = '" & txtState.Text & "', "
            strSql += "busZip = '" & txtZip.Text & "', "
            strSql += "busPhone = '" & txtLPhone.Text & "', "
            strSql += "busCell = '" & txtCPhone.Text & "', "

            If intBusIDNew > 0 Then
                strSql += "taggedAccount = " & hdnActID.Text
                strSql += " Where busID = " & intBusIDNew  'The next 3 line pass parameters back to calling form when new account created.
                gblBusName = SiblingCheck.txtNewListedName.Text
                gblBusID = intBusIDNew
                gblActID = hdnActID.Text
            Else
                strSql += "busLeftName = '" & Microsoft.VisualBasic.Left(ddlBusiness.Text, 20) & "', "
                strSql += "busName = '" & txtDisplayName.Text & "', "
                strSql += "taggedAccount = " & hdnActID.Text
                strSql += " Where busID = " & ddlBusiness.SelectedValue
                gblBusName = ddlBusiness.Text
            End If
            Dim res As Integer
            Try
                oCommand = New SqlCommand(strSql, cn)
                res = oCommand.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("An error occurred retrieving your data." & ex.Message, "Error", MessageBoxButtons.OK)
                cn.Close()
            End Try

        Else
            strMessage = "Successfully insesrted new business record!"
            'Insert
            strSql = "Insert into tblBusiness (busLeftName, busName, busAddress1, busAddress2, busCity, busState,busZip, busPhone, busCell, taggedAccount) Values ("
            strSql += "'" & txtBusiness.Text & "', "
            strSql += "'" & txtDisplayName.Text & "', "
            strSql += "'" & txtAddress1.Text & "', "
            strSql += "'" & txtAddress2.Text & "', "
            strSql += "'" & txtCity.Text & "', "
            strSql += "'" & txtState.Text & "', "
            strSql += "'" & txtZip.Text & "', "
            strSql += "'" & txtLPhone.Text & "', "
            strSql += "'" & txtCPhone.Text & "', "
            strSql += hdnActID.Text & ") SET @ID = SCOPE_IDENTITY()"  'Retrieve ID number
            Dim IDParam As SqlParameter = New SqlParameter("@ID", SqlDbType.Int)
            IDParam.Direction = ParameterDirection.Output
            oCommand = New SqlCommand(strSql, cn)
            oCommand.Parameters.Add(IDParam)
            oCommand.ExecuteNonQuery()
            Dim intNewRecord As Int32 = IDParam.Value
            gblBusID = intNewRecord
            gblActID = hdnActID.Text
            gblBusName = txtBusiness.Text
        End If
        gblActID = hdnActID.Text
        cn.Close()
        MessageBox.Show(strMessage, "Notice", MessageBoxButtons.OK)
        If cn.State = ConnectionState.Open Then cn.Close()
        ClearForm()
        Me.Close()
    End Sub

    Private Sub rbExpense_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbExpense.CheckedChanged
        DisplayGrid()
    End Sub

    Sub ClearForm()
        txtAccountname.Text = ""
        txtAccountNum.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        txtCPhone.Text = ""
        txtLPhone.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If lblHdnSource.Text = "baseAddBusiness" Then
            Me.Close()
        Else
            Me.Close()
            'GetBusiness.Close()
            PostBankToJournal.Show()
        End If
    End Sub
End Class