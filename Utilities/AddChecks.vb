Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.VisualBasic
Public Class AddChecks
    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim myDataset As New DataSet
    Dim bs As BindingSource
    Dim rowCnt, rowCnt2 As Integer
    Dim aryGets As New ArrayList()
    Dim LoadComplete As Boolean = False
    Dim newBus As Boolean = False
    Dim jnlDeposit As Int32
    Public gblBusName As String
    Public Event SelectedIndexChanged As EventHandler
    Public jnlActive As Integer

    Private Sub AddChecks_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'This sets the flag value for a charge account to zero. Must add to save.
        hdnMasterAccount.Text = "0"
        DisplayAccounts()
        DisplayActivites()
        DisplayBusinesses()
        DisplayGrid()
    End Sub

    'Private Sub FillDropdowns()
    'End Sub
  
    Private Sub DisplayActivites()
        ' populates  dropdown of available Activites
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "select  ActivityDescription,ActivityID from tblActivity order by ActivitySort "
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        DA1.Fill(DS1, "tblActivity")
        Dim myRow As Integer = DS1.Tables(0).Rows.Count
        Dim dt As DataTable = DS1.Tables(0)
        dt.Rows.Add()
        ddlActivity.DataSource = DS1.Tables("tblActivity")
        ddlActivity.DisplayMember = "ActivityDescription"
        ddlActivity.ValueMember = "ActivityID"
        cn.Close()
    End Sub

    Private Sub DisplayAccounts()
        ' populates  dropdown of available Bank Accounts
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "select  actNum, actName from tblBankAcct where actType = 'C' and actBank = 'Morris'"
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        DA1.Fill(DS1, "tblBankAcct")
        Dim myRow As Integer = DS1.Tables(0).Rows.Count
        Dim dt As DataTable = DS1.Tables(0)
        dt.Rows.Add()
        cn.Close()
        Dim drw As DataRow = dt.NewRow()
        drw.Item(0) = "0"
        drw.Item(1) = "Select Account"
        Dim selvalue As Integer
        dt.Rows.InsertAt(drw, selvalue)
        dt.AcceptChanges()
        cmbBankAccount.DataSource = DS1.Tables("tblBankAcct")
        cmbBankAccount.DisplayMember = "actName"
        cmbBankAccount.ValueMember = "actNum"

    End Sub


    Private Sub DisplayBusinesses()
        ' populates  dropdown of available businesses
        'Also assigns a business name  by extracting from the memo a reference to an existing name.
        Dim reader As SqlDataReader
        Dim lst As New List(Of String)
        Dim strSql As String = "select busID, busName, taggedAccount from tblBusiness where busSiblingID in (1,0) order by busname"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        reader = oCommand.ExecuteReader()
        While reader.Read()
            lst.Add(reader.GetString(1))
        End While
        reader.Close()
        'cn.Close()
        Dim mySource As AutoCompleteStringCollection = New AutoCompleteStringCollection
        mySource.AddRange(lst.ToArray)
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        strSql = "select busID, busName, taggedAccount from tblBusiness where busSiblingID in (1,0) order by busname"
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        DA1.Fill(DS1, "tblBusiness")
        Dim myRow As Integer = DS1.Tables(0).Rows.Count
        Dim dt As DataTable = DS1.Tables(0)
        dt.Rows.Add()
        cn.Close()
        Dim drw As DataRow = dt.NewRow()
        drw.Item(0) = "0"
        drw.Item(1) = "Select Business"
        Dim selvalue As Integer
        dt.Rows.InsertAt(drw, selvalue)
        dt.AcceptChanges()
        cmbBusiness.AutoCompleteCustomSource = mySource
        cmbBusiness.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbBusiness.AutoCompleteSource = AutoCompleteSource.CustomSource
        cmbBusiness.DataSource = DS1.Tables("tblBusiness")
        cmbBusiness.DisplayMember = "busName"
        cmbBusiness.ValueMember = "busID"
        LoadComplete = True
    End Sub

    Sub DisplayGrid()   'Display grid with focus around an entry (selID) unless 0. then locate at top.
        Dim selectedAccountType As String = "Expenses"  'ctype(ddlActTyp.Text, String)
        Dim strSql As String
        Dim intLocDisplay As Integer = 0
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        '****Build grid of accounts along the right side of form
        dgvAccounts.RowCount = 1 'This clears any data out of the gird
        strSql = "select acntID, (str(actNum) + '-' + LTrim(str(actNumSeq))) as actNumJoin, actName, actDescription "
        strSql += "from tblDRCOA where actUse = 20 "
        'lblCaption.Text = selectedAccountType
        Select Case selectedAccountType
            Case "Assets"
                strSql += " and actNum > 999 and actNum < 2000 "
                jnlActive = 1
            Case "Debts"
                strSql += " and actNum > 1999 and actNum < 3000 "
                jnlActive = 1
            Case ("Income")
                strSql += " and actNum > 3999 and actNum < 7000 "
                jnlActive = 1
            Case "Expenses"
                strSql += " and actNum > 6999 and actNum < 10000 "
                jnlActive = 1
            Case "No Effect"
                strSql += " and actNum > 1999 and actNum < 4000 "
                jnlActive = 0
            Case Else
                Exit Sub
        End Select
        'strSql += " and actDescription LIKE '%RENT%'  or actName LIKE '%rent%' "
        strSql += " and actDescription LIKE '%" & txtSearch.Text.Trim & "%'  or actName LIKE '%" & txtSearch.Text.Trim & "%' " 'AND actTypeName = 'income'
        strSql += " order by actName"
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
            'Display Account headings and account ID's as appropriate for entry position
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
                dgvAccounts.Rows.Item(n).Cells(0).Value = Trim(dr(3).ToString())
                dgvAccounts.Rows.Item(n).Cells(1).Value = dr(1)
                dgvAccounts.Rows.Item(n).Cells(2).Value = dr(0)
                n = dgvAccounts.Rows.Add()
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                'If dr(0) = selID Then
                '    intLocDisplay = n
                'End If
            Else
                dgvAccounts.Rows.Item(n).Cells(0).Value = Trim(dr(3).ToString())
                dgvAccounts.Rows.Item(n).Cells(1).Value = dr(1)
                dgvAccounts.Rows.Item(n).Cells(2).Value = dr(0)
                n = dgvAccounts.Rows.Add()
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                'If dr(0) = selID Then
                '    intLocDisplay = n
                'End If

            End If

            'Exit Sub
JUMP:   Loop
        cn.Close()
        '**********Shift dislplay around selected account
        'Dim showloc As Integer = 0
        'Select Case intLocDisplay
        '    Case 0 To 5
        '        showloc = 0
        '    Case n - 5 To n
        '        showloc = n

        '    Case Else
        '        showloc = intLocDisplay - 5
        'End Select

        'dgvAccounts.FirstDisplayedScrollingRowIndex = showloc
        ''dgvAccounts.Refresh()
        'If intLocDisplay = 0 Then intLocDisplay = 1
        'dgvAccounts.Rows(intLocDisplay - 1).Selected = True
    End Sub

    Private Sub dgvAccounts_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.RowEnter
        Dim i As Integer = e.RowIndex
        Dim cell1 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(1), DataGridViewCell)
        Dim cell2 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(0), DataGridViewCell)
        Dim cell3 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(2), DataGridViewCell)
        If cell1.Value <> Nothing Then
            txtAcntNum.Text = cell1.Value.ToString.Trim
            txtActName.Text = cell2.Value.ToString.Trim
            hdnMasterAccount.Text = cell3.Value.ToString.Trim
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim errMessage As String = ""
        If CheckSave(errMessage) Then
            cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
            Dim inDate As Date = dteCheck.Text
            Dim strSql As String = "Set IDENTITY_INSERT tblChecks OFF  Insert into tblChecks (chkNumber,chkToID, chkAmount, chkDate, chkNote, chkBankAccount, chkMasterAccount) values "
            strSql += "(" & txtChkNum.Text & ", " & cmbBusiness.SelectedValue & ", " & txtAmount.Text & ", '" & inDate & "', '" & txtNote.Text & "', " & cmbBankAccount.SelectedValue & ", " & hdnMasterAccount.Text & ")"
            oCommand = New SqlCommand(strSql, cn)
            cn.Open()
            oCommand.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Check number " & txtChkNum.Text.Trim & " was saved", "SAve Result", MessageBoxButtons.OK)
            Clear()
        Else
            MessageBox.Show("Could not save this check!" & vbCrLf & errMessage, "Save Error", MessageBoxButtons.OK)
            Exit Sub
        End If
    End Sub

    Private Function CheckSave(ByRef msg As String) As Boolean
        'Check for supplied account number
        If cmbBankAccount.SelectedValue = 0 Then
            msg = "You are required to select a Bank Account number"
            Return False
        End If

        If Not IsNumeric(txtAmount.Text) Then
            msg = "This Check amount is not a valid entry!"
            Return False
        End If
        If ddlActivity.SelectedValue = 0 Then
            msg = "An activity must be selected!"
            Return False
        End If
        If cmbBankAccount.SelectedValue = 0 Then
            msg = "A Bank Account  must be selected!"
            Return False
        End If
        If cmbBusiness.SelectedValue = 0 Then
            msg = "A valid Name must be selected or added!"
            Return False
        End If

        If hdnMasterAccount.Text = "0" Then
            msg = "An account to charge the expense to must be selected."
            Return False
        End If


        'Check for duplicate duplicate check
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "SELECT chkNumber from tblChecks where chkNumber = " & txtChkNum.Text.Trim & " and chkBankAccount = " & cmbBankAccount.SelectedValue
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim myResult As String = oCommand.ExecuteScalar()
        If Not IsNothing(myResult) Then
            If myResult.Length > 0 Then
                msg = "This check number already exists in " & cmbBankAccount.Text & " account!"
                Return False
            End If
        End If
     
        CheckSave = True
    End Function



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        baseform.Show()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "SELECT DISTINCT actNum, actNumSeq, actDescription, actName FROM tblDRCOA "
        strSql += "WHERE (actDescription LIKE '%" & txtSearch.Text.Trim & "%'  or actName LIKE '%" & txtSearch.Text.Trim & "%' )" 'AND actTypeName = 'income'"
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        oCommand.ExecuteNonQuery()
        DisplayGrid()
    End Sub
    Private Sub Clear()
        txtAcntNum.Text = ""
        txtActName.Text = ""
        txtAmount.Text = ""
        txtChkNum.Text = ""
        txtNote.Text = ""
        txtSearch.Text = ""
        cmbBankAccount.SelectedValue = 0
        cmbBusiness.SelectedValue = 0
        ddlActivity.SelectedValue = 0
    End Sub



    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        If cmbBusiness.Text <> "Select Business" Then
            Dim txtStore As String = cmbBusiness.Text
            AddPayees.txtDisplayName.Text = cmbBusiness.Text.ToUpper
            AddPayees.txtBusiness.Text = Microsoft.VisualBasic.Left(cmbBusiness.Text.ToUpper, 20)
            AddPayees.ShowDialog()
            'Me.Hide()
            cmbBusiness.Text = AddPayees.gblBusName
            'txtDesc.Text = AddPayees.gblBusName
            'GetBus(cmbBusiness.Text, "Expenses", 0, "", "")
            AddPayees.Close()
            DisplayBusinesses()
            cmbBusiness.SelectedText = txtStore
        Else

            MsgBox("You must enter a name for a business before proceeding", MsgBoxStyle.OkOnly)

        End If
    End Sub

    Private Sub cmbBankAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBankAccount.SelectedIndexChanged
        'Determine the highest number check in the account and use it for check number
        If LoadComplete = True Then
            Dim myString As String = cmbBankAccount.SelectedValue.ToString()
            cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
            Dim strSql As String = "SELECT TOP 1 SUBSTRING(jnlTranType,7,(LEN(RTRIM(jnlTranType))-6)) FROM tblDRJournal "
            strSql += "WHERE left(lTRIM(jnlTranType),5) = 'CHECK' AND jnlBankAct = '" & cmbBankAccount.SelectedValue & "' "
            strSql += "GROUP BY jnlTranType order BY RIGHT(RTRIM(jnlTranType),4) desc"
            oCommand = New SqlCommand(strSql, cn)
            cn.Open()

            Dim strHiCheck As String = oCommand.ExecuteScalar()

            If IsNumeric(strHiCheck) Then
                txtChkNum.Text = CType((CType(strHiCheck, Int32) + 1), String)
            Else
                txtChkNum.Text = "Enter"
            End If
            'If cmbBankAccount.SelectedValue = 56855 Then
            'ElseIf cmbBankAccount.SelectedValue = 67121 Then
            'ElseIf cmbBankAccount.SelectedValue = 56855 Then

            'End If
        End If


    End Sub
End Class
