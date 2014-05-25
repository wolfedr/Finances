Imports System.Data.SqlClient
Imports System.Configuration

Public Class ManageAccount
    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim myDataset As New DataSet
    Dim bs As BindingSource
    Dim LoadComplete As Boolean = False
    Dim myCalling As String
    Private Sub ManageAccount_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblHdnSource.Text = baseform.frmCalling
        rbExpense.Checked = True
        RBHigh.Checked = True
        hdnActSelection.Text = "High"
        lblCaption.Text = "Expense(High)"
        DisplayGrid("", "")
        Instructions()
        LoadComplete = True
    End Sub
    Sub DisplayGrid(ByVal strChoice As String, ByVal strSub As String)
        Dim selectedAccount = strChoice
        Dim strSql As String
        On Error GoTo TrapError
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        dgvAccounts.RowCount = 1 'This clears any data out of the datagridview
        strSql = "select acntID, (str(actNum) + '-' + LTrim(str(actNumSeq))) as actNumJoin, actName, actDescription, actUse, actNumSeq from tblDRCOA where "
        Select Case True
            Case rbIncome.Checked
                strSql += " actNum > 3999 and actNum < 7000 "
                selectedAccount = "Income"
            Case rbExpense.Checked
                strSql += " actNum > 6999 and actNum < 10000 "
                selectedAccount = "Expense"
            Case rbAssets.Checked
                strSql += " actNum > 999 and actNum < 2000 "
                selectedAccount = "Assets"
            Case rbDebts.Checked
                strSql += " actNum > 1999 and actNum < 3000 "
                selectedAccount = "Debts"
        End Select

        strSql += " and actUse "

        Select Case hdnActSelection.Text
            Case "All"
                strSql += " >= 0 "
                selectedAccount += "(All)"
            Case "Medium"
                strSql += " > 0 "
                selectedAccount += "(Medium)"
            Case "High"
                strSql += "= 20 "
                selectedAccount += "(High)"
            Case Else
        End Select


        lblCaption.Text = selectedAccount

        strSql += "order by actName, actNum, actNumSeq  "
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
        Dim aryCount As Int32 = 0
        Dim arylSubAcnt As ArrayList = New ArrayList()
        Do While dr.Read()
            aRecord = Trim(dr(2).ToString())
            If aRecord <> bRecord Then
                bRecord = aRecord
                Dim x As String = dr.GetString(1)
                Dim y As String
                If Not DBNull.Value.Equals(dr(2)) Then
                    y = dr.GetString(2)
                Else
                    y = ""
                End If
                dgvAccounts.Rows.Item(n).Cells(0).Value = dr(2).ToString()
                arylSubAcnt.Add(New MyListItem(dr(2).ToString, dr(1).ToString))
                dgvAccounts.Rows.Item(n).Cells(1).Value = 0
                dgvAccounts.Rows.Item(n).Cells(2).Value = 0
                Me.dgvAccounts.Rows(n).Cells(0).Style.BackColor = Color.Cyan
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.dgvAccounts.Rows(n).Cells(0).Style.Font = New Font("calibri", 14, FontStyle.Bold)
                n = dgvAccounts.Rows.Add()
                dgvAccounts.Rows.Item(n).Cells(0).Value = Trim(dr(3).ToString())
                dgvAccounts.Rows.Item(n).Cells(1).Value = dr(1)
                dgvAccounts.Rows.Item(n).Cells(3).Value = dr(4)
                dgvAccounts.Rows.Item(n).Cells(4).Value = dr(5)
                n = dgvAccounts.Rows.Add()
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            Else
                dgvAccounts.Rows.Item(n).Cells(0).Value = Trim(dr(3).ToString())
                dgvAccounts.Rows.Item(n).Cells(1).Value = dr(1)
                dgvAccounts.Rows.Item(n).Cells(3).Value = dr(4)
                dgvAccounts.Rows.Item(n).Cells(4).Value = dr(5)
                n = dgvAccounts.Rows.Add()
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            End If
        Loop
        cn.Close()
        ddlSubAcct.ValueMember = "ValueItem"
        ddlSubAcct.DisplayMember = "DisplayItem"
        ddlSubAcct.DataSource = arylSubAcnt
        SetNewSubAcnt(0)
        Exit Sub
TrapError:
        MessageBox.Show("Error in Account listing: " & Err.Description, "Error Trap", MessageBoxButtons.OK)


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If lblHdnSource.Text = "baseManageAccount" Then
            Me.Close()
        Else
            Me.Hide()
            baseform.Show()
            PostBankToJournal.Refresh()
            PostBankToJournal.Show()
        End If
    End Sub
    Sub SetNewSubAcnt(ByVal seqID As Int16)
        On Error GoTo TrapMe
        Dim strSql As String
        Dim strActCategory As Object
        If ddlSubAcct.SelectedValue <> Nothing Then
            strActCategory = ddlSubAcct.SelectedValue.ToString.Trim
        Else
            Exit Sub   'Most not be any sub accounts
        End If
        'Dim strActCategory As String = ddlSubAcct.SelectedValue.ToString.Trim
        Dim strStoreAcntNum As String = strActCategory.Substring(0, 4)
        Dim arylAcnt As ArrayList = New ArrayList()
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        strSql = "Select Max(actNumSeq) from tblDRCOA where actNum = " & Convert.ToInt32(strStoreAcntNum)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim intCountItems As Int16 = oCommand.ExecuteScalar() 'Get the highest sequence number for this sub accout.
        intCountItems += 2  'Add two blank items at the end to allow adding items to a contiguous array. 
        For i As Int16 = 1 To intCountItems
            arylAcnt.Add(New MyListItem(strStoreAcntNum, ""))
        Next
        Dim dr As SqlDataReader

        strSql = "Select * from tblDRCOA where actNum = " & Convert.ToInt32(strStoreAcntNum) & " order by actName"
        oCommand = New SqlCommand(strSql, cn)
        Dim intFoundCount As Integer = 0
        dr = oCommand.ExecuteReader()
        While dr.Read()
            Dim x As Integer = dr.GetInt32(2)
            'Identify currently active items with asterick
            Dim Active As String
            Dim myString As String = dr(7).ToString()
            If dr(7).ToString() = "20" Then
                Active = "*"
            Else
                Active = ""
            End If
            If x >= 0 Then
                arylAcnt.Item(x) = New MyListItem(dr(1).ToString & "-" & dr(2).ToString + " " + dr(4).ToString & " " & Active, dr(1).ToString & "-" & dr(2).ToString)
            End If
        End While
        dr.Close()
        If cn.State = ConnectionState.Open Then cn.Close()
        ddlAcntNumber.DataSource = arylAcnt
        ddlAcntNumber.DisplayMember = "DisplayItem"
        ddlAcntNumber.ValueMember = "ValueItem"
        If seqID > 0 Then  'This is uesd to return to the selected item when activating or deactivating.
            ddlAcntNumber.SelectedIndex = (seqID - 1)
        End If
        ' DisplayGrid("", "")
        Exit Sub
TrapMe:
        MessageBox.Show(Err.Description, "Error Reporting", MessageBoxButtons.OK)

    End Sub

    Private Sub ddlSubAcct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlSubAcct.SelectedIndexChanged
        SetNewSubAcnt(0)
    End Sub

    Sub Instructions()
        lblSaveInstructions.Visible = True
        lblSaveInstructions.Text = ""
        lblSaveInstructions.Text += "To add a new account, Pick the correct sub account and select from the 'Choose Account Number' list one of the accounts " & vbCrLf
        lblSaveInstructions.Text += " with no descrption. Then enter an appropriate description in the  'New Account Name box' and  'Save'. " & vbCrLf & vbCrLf
        lblSaveInstructions.Text += "To delete an account name, select it from the 'Choose Account Number' list  then  leave the New Account Name box empty  'Save'!" & vbCrLf & vbCrLf
        lblSaveInstructions.Text += "The Activate button will toggle active or inactive the account number showing next to it." & vbCrLf
        lblSaveInstructions.Text += "Active items are indicated by an * at the end of the description and will show up on the Account list." & vbCrLf & vbCrLf
        lblSaveInstructions.Text += "NOTE! Items showing only an account number, are not useable acccounts and must first be given a desctription."
    End Sub

    Private Sub ddlAcntNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlAcntNumber.SelectedIndexChanged
        If LoadComplete = True Then
            Dim strData As String = ddlAcntNumber.Text
            If strData.Trim.EndsWith("*") Then
                btnActivate.Text = "DeActivate"
            Else
                btnActivate.Text = "Activate"
            End If
            txtAcntName.Visible = True
            lblAcntName.Visible = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim x As String = ddlAcntNumber.SelectedText
        Dim y As String = ddlAcntNumber.SelectedValue
        Dim z As String = ddlAcntNumber.Text
        Dim strSql As String
        If ddlAcntNumber.SelectedValue = "" Then
            strSql = "insert into tblDRCOA (actNum, actNumSeq, actName, actDescription,actTypeName, actUse) values("
            strSql += z.Substring(0, 4) & ", " & z.Substring(5, 1) & ", '" & ddlSubAcct.Text & "', '" & txtAcntName.Text & "', '" & ddlActTyp.Text & "', 20)"
        Else
            If Len(txtAcntName.Text) = 0 Then
                Dim result1 As DialogResult = MessageBox.Show("You are about to delete the account " & ddlAcntNumber.SelectedValue, "Warning", MessageBoxButtons.OKCancel)
                If result1 = DialogResult.Cancel Then Exit Sub
                strSql = "Delete from tblDRCOA where actNum = " & ddlAcntNumber.SelectedValue.ToString.Substring(0, 4)
                strSql += " and actNumSeq = " & ddlAcntNumber.SelectedValue.ToString.Substring(5, 1)
            Else
                strSql = "Update tblDRCOA set actDescription = '" & txtAcntName.Text & "' where actNum = " & ddlAcntNumber.SelectedValue.ToString.Substring(0, 4)
                strSql += " and actNumSeq = " & ddlAcntNumber.SelectedValue.ToString.Substring(5, 1)
                Dim result2 As DialogResult = MessageBox.Show("You are about to change the account Name for " & ddlAcntNumber.SelectedValue, "Warning", MessageBoxButtons.OKCancel)
                If result2 = DialogResult.Cancel Then Exit Sub
            End If
        End If
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim res As Object = oCommand.ExecuteNonQuery()
        cn.Close()
        DisplayGrid(ddlActTyp.Text, ddlSubAcct.Text)
        txtAcntName.Visible = False
        lblAcntName.Visible = False
        txtAcntName.Text = ""
        lblSaveInstructions.Visible = False
    End Sub

    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        Dim strSql As String
        Dim intSub As Int16
        Dim strAcntChoice As String = Trim(ddlAcntNumber.SelectedValue)
        Dim strFullString As String = Trim(ddlAcntNumber.Text)
        Dim intLen As Int16 = Len(strAcntChoice)
        Select Case intLen
            Case Is < 6 'No valid account number was returned
                MessageBox.Show("Invalid account number. Try another!", "Notice", MessageBoxButtons.OK)
                Exit Sub
            Case 6
                intSub = 1
            Case 7
                intSub = 2
            Case Else
                MessageBox.Show("Invalid account number. Too long! Contact support!", "Notice", MessageBoxButtons.OK)
                Exit Sub

        End Select

        Dim strActNum As String = strAcntChoice.Substring(0, 4)
        Dim strActNumSeg As String = strAcntChoice.Substring(5, intSub)

        If strFullString.Substring(Len(strFullString) - 1, 1) = "*" Then
            'Turn it off by making actuse a 0
            strSql = "update tblDRCOA set actUse = 0 where actNum = " & strActNum & " and actNumSeq = " & strActNumSeg
        Else
            'Turn it on be making actuse a 20
            strSql = "update tblDRCOA set actUse = 20 where actNum = " & strActNum & " and actNumSeq = " & strActNumSeg
        End If
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        oCommand.ExecuteNonQuery()
        cn.Close()
        SetNewSubAcnt(Convert.ToInt16(strActNumSeg))
        'DisplayGrid("", ddlSubAcct.Text)

    End Sub

    Private Sub RBHigh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBHigh.CheckedChanged
        If LoadComplete = True Then
            hdnActSelection.Text = "High"
            DisplayGrid("", "")
        End If

    End Sub

    Private Sub rbMedium_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMedium.CheckedChanged
        If LoadComplete = True Then
            hdnActSelection.Text = "Medium"
            DisplayGrid("", "")
        End If
    End Sub

    Private Sub rbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAll.CheckedChanged
        If LoadComplete = True Then
            hdnActSelection.Text = "All"
            DisplayGrid("", "")
        End If
    End Sub

    Private Sub rbExpense_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExpense.CheckedChanged
        If LoadComplete = True Then
            DisplayGrid("", "")

        End If
    End Sub

    Private Sub rbIncome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIncome.CheckedChanged
        If LoadComplete = True Then
            DisplayGrid("", "")

        End If
    End Sub

    Private Sub rbAssets_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAssets.CheckedChanged
        If LoadComplete = True Then
            DisplayGrid("", "")

        End If
    End Sub

    Private Sub rbDebts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDebts.CheckedChanged
        If LoadComplete = True Then
            DisplayGrid("", "")

        End If
    End Sub

    Private Sub dgvAccounts_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.CellContentClick

    End Sub
End Class
