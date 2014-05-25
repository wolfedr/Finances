Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.VisualBasic
Public Class AddActivity
    Dim oCommand As SqlCommand
    Dim reader As SqlDataReader
    Dim cn As SqlConnection
    Dim dr As SqlDataReader
    Dim dsMain As DataSet
    Dim LoadComplete As Boolean = False
    Public gblBusID As Long
    Public gblBusName As String
    Public gblActID As Integer
    Public gblActNum As Integer
    Public gblActSeq As Integer
    Private intBusIDNew As Integer
    Private intRecordID As Integer = 0

    Private Sub AddActivity_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dsMain = RetrieveDDL()
        Dim mytable As DataTable = dsMain.Tables(0)
        ddlRecords.DataSource = mytable.DefaultView
        ddlRecords.DisplayMember = "ActID"
        ddlRecords.ValueMember = "ActivityID"
        FillDropdowns()
        lblID.Text = intRecordID
        rbDisplay.Checked = True
        SetView("Display Mode", intRecordID)
        LoadComplete = True
    End Sub

    Sub SetView(ByVal setType As String, ByVal intID As Integer)
        lblMode.Text = setType
        Select Case setType
            Case "Display Mode"
                Dim objData As SqlDataReader = RetrieveData(intID) 'GET DATAREADR FOR THIS ACTIVITY
                ShowData(objData)
                '--Read not change
                txtDescription.ReadOnly = False
                txtProject.ReadOnly = False
                txtType.ReadOnly = False
                txtNotes.ReadOnly = False
                '--Textboxes Visile
                txtDescription.Visible = True
                txtProject.Visible = True
                txtType.Visible = True
                txtNotes.Visible = True
                'Dropdowns not visible
                ddlActivity.Visible = False
                ddlProject.Visible = False
                ddlActivityType.Visible = False
            Case "Edit Mode"
                Dim myProj As String = txtProject.Text
                Dim myType As String = txtType.Text
                txtDescription.Visible = True
                txtProject.Visible = False
                txtType.Visible = False
                ddlProject.Visible = True
                ddlActivityType.Visible = True
                ddlActivityType.SelectedValue = myType
                ddlProject.SelectedValue = myProj

            Case "Add Mode"
                txtDescription.Enabled = True
                txtProject.Visible = False
                txtType.Visible = False
                ddlProject.Visible = True
                ddlActivityType.Visible = True
                lblMode.Text = setType
                txtNotes.Text = "Enter detail on this activity."
            Case Else

        End Select
    End Sub
    Function RetrieveDDL() As DataSet
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "select (ltrim(str(activityID)) + ' - '+ LTRIM(ActivItyDescription)) as actID, activityID, activityDescription from tblActivity order by ActivitySort "
        If cn.State = ConnectionState.Closed Then cn.Open()
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        DA1.Fill(DS1, "tblActivity")
        cn.Close()
        Return DS1
    End Function

    Function RetrieveDataSet() As DataSet
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "select * from tblActivity  where  ActivitySort > 1  order by ActivitySort "
        If cn.State = ConnectionState.Closed Then cn.Open()
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        DA1.Fill(DS1, "tblActivity")
        cn.Close()
        Return DS1
    End Function


    Function RetrieveData(ByVal intID As Int32) As SqlDataReader
        Dim strSql As String = "select * from tblActivity where activityID = " & intID
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader()
        If dr.HasRows Then
            Return dr
        Else
            MessageBox.Show("NO data was found for this request.", "Error", MessageBoxButtons.OK)
            cn.Close()
            Return dr
        End If
    End Function

    Sub ShowData(ByVal dr As SqlDataReader)
        dr.Read()
        If dr(0) < 1 Then
            ClearForm()
            lblID.Text = dr(0).ToString()
        Else
            txtProject.Text = dr(1).ToString()
            txtType.Text = dr(4).ToString()
            txtNotes.Text = dr(3).ToString()
            txtDescription.Text = dr(2).ToString()
            lblID.Text = dr(0).ToString()
        End If

    End Sub


    Sub FillDropdowns()
        'Fill Actity Dropdown
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "select ActivityID, ActivityDescription from tblActivity order by ActivitySort "
        If cn.State = ConnectionState.Closed Then cn.Open()
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        DA1.Fill(DS1, "tblActivity")
        'Dim myrow As DataRow = DS1.Tables("tblActivity").Rows(1)
        'intRecordID = myrow.Item(0)
        'lblID.Text = intRecordID
        ddlActivity.DataSource = DS1.Tables("tblActivity")
        ddlActivity.DisplayMember = "activityDescription"
        ddlActivity.ValueMember = "activityDescription"

        'Fill Project Dropdown
        strSql = "select projectID, projectName from tblProjects order by ProjectSort "
        If cn.State = ConnectionState.Closed Then cn.Open()
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        DA1.Fill(DS1, "tblProjects")
        ddlProject.DataSource = DS1.Tables("tblProjects")
        ddlProject.DisplayMember = "projectName"
        ddlProject.ValueMember = "projectName"


        'Fill Activity Type Dropdown
        strSql = "select activityTypeID, ActivityTypeName from tblActivityType order by ActivityTypeSort "
        If cn.State = ConnectionState.Closed Then cn.Open()
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        DA1.Fill(DS1, "tblActivityType")
        ddlActivityType.DataSource = DS1.Tables("tblActivityType")
        ddlActivityType.DisplayMember = "activityTypeName"
        ddlActivityType.ValueMember = "activityTypeName"

        'Fill Activity Sort Dropdown
        strSql = "SELECT (ActivityDescription + '-' + LTRIM(STR(activitySort))) AS activityX, activitySort FROM tblActivity ORDER BY activitySort"
        If cn.State = ConnectionState.Closed Then cn.Open()
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        DA1.Fill(DS1, "tblActivity")
        ddlSort.DataSource = DS1.Tables("tblActivity")
        ddlSort.DisplayMember = "activityX"
        ddlSort.ValueMember = "activitySort"
        cn.Close()
        txtSort.Text = ddlSort.SelectedValue

    End Sub




    Private Sub btnGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGO.Click
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = ""
        Dim strMessage As String = ""
        If rbAdd.Checked = True Then
            'Add New activity
            Dim mySort As Integer = AssignSortOrder(ddlActivityType.SelectedValue)
            Try
                strSql = "Insert into tblActivity(ActivityProject,ActivityDescription,ActivityType,ActivityNotes,ActivityActive) values ("
                strSql += "'" & ddlProject.SelectedValue & "', '" & txtDescription.Text & "', '" & ddlActivityType.SelectedValue & "','" & txtNotes.Text & "',1)"
                oCommand = New SqlCommand(strSql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()

                oCommand.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error! MAke sure all boxes were filled in. Contact administrator if problem persists", "Error", MessageBoxButtons.OK)
                Exit Sub
            Finally
                cn.Close()
            End Try

            MessageBox.Show("Your new activity was added!", "Notice", MessageBoxButtons.OK)

        End If
        'Edit Activity
        If rbEdit.Checked = True Then
            txtDescription.Text = txtDescription.Text.Replace("'", "")
            txtType.Text = txtType.Text.Replace("'", "")
            cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
            cn.Open()
            strSql = "Update tblActivity set "
            strSql += "activityType = '" & txtType.Text & "', "
            strSql += "activityDescription = '" & ddlActivity.Text & "', "
            strSql += "activityProject = '" & txtProject.Text & "', "
            strSql += "activityNotes = '" & txtNotes.Text & "'"
            strSql += " where activityID = " & CType(lblID.Text, Int32)
            Dim res As Integer
            Try
                oCommand = New SqlCommand(strSql, cn)
                res = oCommand.ExecuteNonQuery()
                strMessage = "Successfully updated Activity record!"
            Catch ex As Exception
                MessageBox.Show("An error occurred updating your data." & ex.Message, "Error", MessageBoxButtons.OK)
            Finally
                cn.Close()
            End Try
        End If
        Exit Sub
        'lblActivity.Text = "You are adding this new entry!"
        txtDescription.Visible = True
        ddlActivity.Visible = False
        ClearForm()
        btnGO.Enabled = False
    End Sub
    Function AssignSortOrder(ByVal TypeActivity As String) As Integer
        Dim strSql As String = "Select max(ActivitySort) from tblActivity where ActivityType = '" & TypeActivity & "'"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim nowSort As Integer = oCommand.ExecuteScalar()
        Return nowSort + 1
    End Function




    Private Sub ddlActivity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlActivity.SelectedIndexChanged
        If LoadComplete = True Then
            'ClearForm()
            'ShowData(CType(ddlActivity.SelectedValue, Int32))
        End If
    End Sub

    Private Sub Save()
        'Dim strSql As String
        'Dim strMessage As String
        'txtDescription.Text = txtDescription.Text.Replace("'", "")
        'txtType.Text = txtType.Text.Replace("'", "")
        'cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        'cn.Open()
        'strSql = "Update tblActivity set "
        'strSql += "activityType = '" & txtType.Text & "', "
        'strSql += "activityDescription = '" & ddlActivity.Text & "', "
        'strSql += "activityNumber = '" & txtProject.Text & "', "
        'strSql += "activityNotes = '" & txtNotes.Text & "'"
        'strSql += " where activityID = " & CType(lblID.Text, Int32)
        'Dim res As Integer
        'Try
        '    oCommand = New SqlCommand(strSql, cn)
        '    res = oCommand.ExecuteNonQuery()
        '    strMessage = "Successfully updated Activity record!"
        'Catch ex As Exception
        '    MessageBox.Show("An error occurred updating your data." & ex.Message, "Error", MessageBoxButtons.OK)
        'Finally
        '    cn.Close()
        'End Try


        'strMessage = "Successfully insesrted new business record!"
        'strSql = "Insert into tblActivity ("
        'strSql += "activityNumber, activityDescription, activityNotes, activityType) values("
        'strSql += "'" & txtProject.Text & "', "
        'strSql += "'" & txtDescription.Text & "', "
        'strSql += "'" & txtNotes.Text & "', "
        'strSql += "'" & txtType.Text & "')"
        'Dim IDParam As New SqlParameter
        'oCommand.Parameters.Add(IDParam)
        'IDParam.Direction = ParameterDirection.Output
        'oCommand = New SqlCommand(strSql, cn)
        'Try
        '    oCommand.ExecuteNonQuery()
        '    Dim intNewRecord As Int32 = IDParam.Value
        '    strMessage = "Successfully added new business record!"
        'Catch ex As Exception
        '    MessageBox.Show("An error occurred saving your data." & ex.Message, "Error", MessageBoxButtons.OK)
        '    cn.Close()
        'End Try




        'End If
        'cn.Close()
        'MessageBox.Show(strMessage, "Notice", MessageBoxButtons.OK)
        'If cn.State = ConnectionState.Open Then cn.Close()
        ''ClearForm()
        ''Me.Close()
    End Sub

    Sub ClearForm()

        txtType.Text = ""
        txtDescription.Text = ""
        txtProject.Text = ""
        txtNotes.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'If lblHdnSource.Text = "baseAddActivity" Then
        '    Me.Close()
        'Else
        Me.Close()
        'PostBankToJournal.Show()
        'End If
    End Sub


    Private Sub RadioButton_CheckedChanged(ByVal sender As System.Object, _
                                           ByVal e As System.EventArgs) Handles _
                                       rbDisplay.CheckedChanged, _
 _
                                       rbEdit.CheckedChanged, _
                                       rbAdd.CheckedChanged
        If LoadComplete = True Then
            If rbEdit.Checked Then
                SetView("Edit Mode", CType(lblID.Text, Integer))
                ddlRecords.Enabled = False
            ElseIf rbDisplay.Checked Then
                SetView("Display Mode", CType(lblID.Text, Integer))
                ddlRecords.Enabled = True
            Else
                SetView("Add Mode", CType(lblID.Text, Integer))
                ddlRecords.Enabled = False

            End If

        End If
    End Sub

    Private Sub ddlRecords_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlRecords.SelectedIndexChanged
        If LoadComplete Then
            intRecordID = ddlRecords.SelectedValue
            SetView("Display Mode", ddlRecords.SelectedValue)
        End If

    End Sub

    Private Sub ddlSort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlSort.SelectedIndexChanged
        If LoadComplete Then
            txtSort.Text = ddlSort.SelectedValue

        End If
    End Sub
End Class

