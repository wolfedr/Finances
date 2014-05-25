Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Threading
Imports Microsoft.VisualBasic

Public Class PostBankToJournal
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
    Structure BankTransaction
        Dim id As Long
        Dim Type As String
        Dim bankAccount As String
        Dim PostDate As String
        Dim Amount As Single
        Dim FITID As Long
        Dim CheckNum As Integer
        Dim Name As String
        Dim RefNum As String
        Dim Memo As String
    End Structure
    Structure OffsetTransaction
        Dim id As Long  'X
        Dim Type As String  'X
        Dim bankAccount As String
        Dim PostDate As String  'X
        Dim Amount As Single    'X
        Dim FITID As Long   'X
        Dim CheckNum As Integer
        Dim Name As String
        Dim RefNum As String
        Dim Memo As String
        Dim actNum As String
        Dim actNumSeq As String
        Dim sourceAct As String
        Dim busID As String
        Dim activityID As String
        Dim activityText As String
    End Structure
    Dim Offset As OffsetTransaction
    Dim myTransactions As New BankTransaction

    Private Sub PostBankToJournal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitializeComboBoxs()
        ClearOffsetStructure()
        btnClose.Focus()
        baseform.lblModule.Text = "PostBankTOJournal"
        'Set all entries in the journal to default active. Inactive entries preserve information but do not impact totals.
        jnlActive = 1
        'Fill the dropdown of businesses
        'lblGetRules.Text = "If you want to wait to process any item Click 'Get Next' and get" & vbCrLf & " the next one. Transactions only disappear once they are posted."
        'lblDisregard.Text = "Use Only when Account" & vbCrLf & "does not impact Income" & vbCrLf & "or  Expenses."
    End Sub

    Private Sub ddlActType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlActTyp.SelectedIndexChanged
        DisplayGrid(0)
    End Sub
    Private Sub DisplayActivites()
        ' populates  dropdown of available Activites
        'Fill Actity Dropdown
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

    Private Sub DisplayBusinesses()
        ' populates  dropdown of available businesses
        'Also assigns a business name  by extracting from the memo a reference to an existing name.
        'Dim aryAccount As ArrayList
        Dim reader As SqlDataReader
        Dim lst As New List(Of String)
        
        Dim strSql As String = "select busID, busName, taggedAccount from tblBusiness where busSiblingID in (1,0) order by busname"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        reader = oCommand.ExecuteReader()
        While reader.Read()
            lst.Add(reader.GetString(1))
            'Dim x As String = reader.GetString(1)
            '    Dim y As String = reader.GetInt64(0)
            '    Dim z As String = reader.GetInt64(2)
            '    'this array will tag an account to the list entry.
            '    aryAccount.Add(z)
            '    aryBusiness.Add(New AddValue(reader.GetString(1), Convert.ToInt64(reader.GetInt64(0))))
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
        ' For loopCount As Integer = 0 To DS1.Tables(0).Rows.Count - 1
        '    mySource.Add(DS1.Tables(0).Rows(loopCount)(0).ToString())
        'Next
        cmbBusiness.AutoCompleteCustomSource = mySource
        cmbBusiness.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbBusiness.AutoCompleteSource = AutoCompleteSource.CustomSource
        cmbBusiness.DataSource = DS1.Tables("tblBusiness")
        cmbBusiness.DisplayMember = "busName"
        cmbBusiness.ValueMember = "busID"
        LoadComplete = True
    End Sub

    Private Sub InitializeComboBoxs()
        'Account type
        Me.ddlActTyp = New System.Windows.Forms.ComboBox
        Dim Accounts() As String = New String() {"Expenses", "Income", "Assets", "Debts", "No Effect"}
        ddlActTyp.Items.AddRange(Accounts)
        Me.ddlActTyp.FormattingEnabled = True
        Me.ddlActTyp.Location = New System.Drawing.Point(490, 180)
        Me.ddlActTyp.Name = "ddlActType"
        Me.ddlActTyp.MaxDropDownItems = 6
        Me.ddlActTyp.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ddlActTyp.Size = New System.Drawing.Size(136, 81)
        Me.ddlActTyp.TabIndex = 0
        Me.ddlActTyp.SelectedIndex = 0
        Me.Controls.Add(Me.ddlActTyp)
    End Sub

    Sub DisplayGrid(ByVal selID As Integer)   'Display grid with focus around an entry (selID) unless 0. then locate at top.
        Dim selectedAccountType = CType(ddlActTyp.Text, String)
        Dim strSql As String
        Dim intLocDisplay As Integer = 0
        Dim srchText As String = txtSearch.Text
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        '****Build grid of accounts along the right side of form
        dgvAccounts.RowCount = 1 'This clears any data out of the gird
        strSql = "select acntID, (str(actNum) + '-' + LTrim(str(actNumSeq))) as actNumJoin, actName, actDescription "
        strSql += "from tblDRCOA where actUse = 20 "
        lblCaption.Text = selectedAccountType
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
        If Len(srchText) > 1 Then
            strSql += " and (UPPER(actName) like '%" & srchText.Trim.ToUpper & "%' or UPPER(actDescription) like '%" & srchText.Trim.ToUpper & "%') "
        End If
        strSql += "order by actName"
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
                If dr(0) = selID Then
                    intLocDisplay = n
                End If
            Else
                dgvAccounts.Rows.Item(n).Cells(0).Value = Trim(dr(3).ToString())
                dgvAccounts.Rows.Item(n).Cells(1).Value = dr(1)
                dgvAccounts.Rows.Item(n).Cells(2).Value = dr(0)
                n = dgvAccounts.Rows.Add()
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                If dr(0) = selID Then
                    intLocDisplay = n
                End If

            End If

            'Exit Sub
JUMP:   Loop
        cn.Close()
        '**********Shift dislplay around selected account
        Dim showloc As Integer = 0
        Select Case intLocDisplay
            Case 0 To 5
                showloc = 0
            Case n - 5 To n
                showloc = n

            Case Else
                showloc = intLocDisplay - 5
        End Select

        dgvAccounts.FirstDisplayedScrollingRowIndex = showloc
        'dgvAccounts.Refresh()
        If intLocDisplay = 0 Then intLocDisplay = 1
        dgvAccounts.Rows(intLocDisplay - 1).Selected = True
    End Sub

    Public Sub ParseTransactions(ByVal bnkStruct As BankTransaction)
        'Dim bnkOffset As BankTransaction
        'Bank account for Journal Asset 1010-2 (Checking Account)
        txtBankAct.Text = bnkStruct.bankAccount

        Select Case bnkStruct.Type.Trim
            Case "ATM"
                'ATM action will be confined to withdrawls from the account
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                txtAcntNum.Text = "8590-1"
                txtActName.Text = "ATM Cash Withdrawl"
                txtPostDate.Text = bnkStruct.PostDate
                txtDesc.Text = bnkStruct.Name
                txtMemo.Text = "ATM Debit for Cash Withrawl"
                'This is added for Split Module Only
                Offset.id = bnkStruct.id
                ddlActTyp.Text = "Expenses"

                Offset.PostDate = bnkStruct.PostDate
                Offset.Type = bnkStruct.Type
                Offset.Amount = bnkStruct.Amount
                Dim x As String = ddlActivity.SelectedValue.ToString()
                Dim x2 As String = getActivity(x) 'ddlActivity.Text
                Offset.activityID = x  'Add these 2 fields where an offsetting transaction is occurring.
                Offset.activityText = x2
                Offset.Name = bnkStruct.Name
                Offset.Memo = bnkStruct.Name
                Offset.PostDate = bnkStruct.PostDate
                Offset.busID = 527
                btnSplit.Visible = True
            Case "CHECK"
                'ALWAYS Withdrawls from the accout
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type & ":" & bnkStruct.CheckNum
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                txtChkNum.Text = bnkStruct.CheckNum
                txtPostDate.Text = bnkStruct.PostDate
                txtMemo.Text = bnkStruct.Memo
                txtDesc.Text = "Manually Enter Details from Check Book! Autoload  inactive check # " & txtChkNum.Text & "."
                If CType(txtChkNum.Text, Int32) < 5000 Then
                    CheckCheck(bnkStruct)
                End If
                ddlActTyp.Text = "Expenses"
            Case "CREDIT"
                'Cash in from another account normally
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                'txtAcntNum.Text = ""
                txtActName.Text = "Checking Account"
                txtPostDate.Text = bnkStruct.PostDate
                txtMemo.Text = "Credit"
                txtDesc.Text = bnkStruct.Name
                ddlActTyp.Text = "Income"
            Case "DEBIT"
                'Cash out to another account
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                'txtAcntNum.Text = "Debit"
                'txtActName.Text = "Checking Account"
                txtPostDate.Text = bnkStruct.PostDate
                txtMemo.Text = bnkStruct.Memo
                txtDesc.Text = bnkStruct.Name
                ddlActTyp.Text = "Expenses"
            Case "DIRECTDEBIT"
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                txtPostDate.Text = bnkStruct.PostDate
                txtMemo.Text = bnkStruct.Memo
                txtDesc.Text = bnkStruct.Name
                'Case "PAYMENT"
                '   txtID.Text = bnkStruct.id
                '  txtType.Text = bnkStruct.Type
                ' txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                'txtPostDate.Text = bnkStruct.PostDate
                ''txtMemo.Text = "Direct Debit from Checking account!"
                'txtDesc.Text = bnkStruct.Name
                ddlActTyp.Text = "Expenses"
            Case "DEPOSIT", "DEP"
                'Cash into the account from a counter deposit
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                cmbBusiness.Text = "MORRIS"
                ddlActivity.SelectedValue = 0
                'txtAcntNum.Text = ""
                txtActName.Text = "Miscellaneous revenue"
                txtPostDate.Text = bnkStruct.PostDate
                txtMemo.Text = "Account! Counter Deposit"
                txtDesc.Text = bnkStruct.Name
                'This is added for Split Module Only
                Offset.PostDate = bnkStruct.PostDate
                Offset.Type = bnkStruct.Type
                Offset.Amount = bnkStruct.Amount
                Dim x As String = ddlActivity.SelectedValue.ToString()
                Dim x2 As String = getActivity(x) 'ddlActivity.Text
                Offset.activityID = x  'Add these 2 fields where an offsetting transaction is occurring.
                Offset.activityText = x2
                Offset.Name = bnkStruct.Name
                Offset.Memo = bnkStruct.Name
                Offset.PostDate = bnkStruct.PostDate
                btnSplit.Visible = True
                Offset.busID = 527
                ddlActTyp.Text = "Income"
            Case "DIRECTDEP"
                'Cash into the account from a direct deposit electronically.
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                'txtAcntNum.Text = "Direct Deposit"
                'txtActName.Text = "Checking Account"
                txtPostDate.Text = bnkStruct.PostDate
                txtMemo.Text = bnkStruct.Memo
                txtDesc.Text = bnkStruct.Name
                'This is added for Split Module Only
                Offset.PostDate = bnkStruct.PostDate
                Offset.Type = bnkStruct.Type
                Offset.Amount = bnkStruct.Amount
                Dim x As String = ddlActivity.SelectedValue.ToString()
                Dim x2 As String = getActivity(x) 'ddlActivity.Text
                Offset.activityID = x  'Add these 2 fields where an offsetting transaction is occurring.
                Offset.activityText = x2
                Offset.Name = bnkStruct.Name
                Offset.Memo = bnkStruct.Name
                Offset.PostDate = bnkStruct.PostDate
                Offset.busID = 527
                ddlActTyp.Text = "Income"
            Case "FEE", "SRVCHG", "OVERDRAFT"
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                'txtAcntNum.Text = "Bank Fee"
                txtActName.Text = "Service Charge and Overdraft Fees"
                txtPostDate.Text = bnkStruct.PostDate
                txtAcntNum.Text = "7520-4"
                cmbBusiness.Text = "MORRIS"
                ddlActivity.SelectedValue = 1
                txtMemo.Text = "Charge for Account Services" & bnkStruct.Name
                txtDesc.Text = bnkStruct.Memo
                ddlActTyp.Text = "Expenses"
            Case "INT"
                'Cash into the account from an interest payment
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                txtAcntNum.Text = "5310-1"
                txtActName.Text = "Intrest form Checking Account"
                txtPostDate.Text = bnkStruct.PostDate
                txtMemo.Text = " Account. Receive Interest Payment"
                txtDesc.Text = bnkStruct.Name
                ddlActTyp.Text = "Income"
            Case "POS", "PAYMENT"
                'Cash out of the account from a debit card or credit card transaction
                txtID.Text = bnkStruct.id
                Me.txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                txtPostDate.Text = bnkStruct.PostDate
                Me.txtDesc.Text = bnkStruct.Name
                txtMemo.Text = bnkStruct.Memo
                ddlActTyp.Text = "Expenses"
            Case "ATM/POS RETURN"
                'Cash out of the account from a debit card or credit card transaction
                txtID.Text = bnkStruct.id
                Me.txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                txtPostDate.Text = bnkStruct.PostDate
                Me.txtDesc.Text = bnkStruct.Name
                txtMemo.Text = bnkStruct.Memo
            Case "XFER"
                'Cash in or out from one account to another via transfer activityh
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                If bnkStruct.Amount > 0 Then
                    txtID.Text = bnkStruct.id
                    txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                    'txtAcntNum.Text = "1010-2"
                    txtActName.Text = "Checking Account"
                    txtPostDate.Text = bnkStruct.PostDate
                    txtMemo.Text = bnkStruct.Memo
                    txtDesc.Text = bnkStruct.Name
                Else
                    'Cash out of the account from a debit card or credit card transaction
                    txtID.Text = bnkStruct.id
                    txtType.Text = bnkStruct.Type
                    txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                    'txtAcntNum.Text = "1010-2"
                    txtActName.Text = "Checking Account"
                    txtPostDate.Text = bnkStruct.PostDate
                    txtMemo.Text = bnkStruct.Memo
                    txtDesc.Text = bnkStruct.Name
                End If
            Case "DEPOSITED ITEM CHARGE BACK"
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                txtAcntNum.Text = "7520-11"
                txtActName.Text = "Bank Deposit Charge Backs"
                txtMasterAct.Text = "Accounting fees"
                txtPostDate.Text = bnkStruct.PostDate
                cmbBusiness.Text = "MORRIS"
                ddlActivity.SelectedValue = 1
                txtMemo.Text = "Charge Back for Deposit: " & bnkStruct.Memo
                txtDesc.Text = bnkStruct.Name

            Case "XFERDONATION"
                'Cash gooes from a donor account (DOUG PERSONAL IN THIS CASE) an a donation into an active account
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                If bnkStruct.Amount > 0 Then
                    'Cash out of the account from a debit card or credit card transaction
                    txtID.Text = bnkStruct.id
                    txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                    txtAcntNum.Text = "4010-3"
                    txtActName.Text = "Contributions from individuals and small businesses"
                    cmbBusiness.Text = "WOLFES"
                    ddlActivity.SelectedValue = 1
                    txtPostDate.Text = bnkStruct.PostDate
                    txtMasterAct.Text = "Individual/small business contribution"
                    txtMemo.Text = bnkStruct.Memo
                    txtDesc.Text = bnkStruct.Name
                    ddlActTyp.Text = "Income"
                Else
                    'Cash out of the account from a debit card or credit card transaction
                    txtID.Text = bnkStruct.id
                    txtType.Text = bnkStruct.Type
                    txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                    txtAcntNum.Text = "1010-2"
                    txtActName.Text = "Checking Account"
                    txtPostDate.Text = bnkStruct.PostDate
                    txtMemo.Text = bnkStruct.Memo
                    txtDesc.Text = bnkStruct.Name
                End If
                'Not doing equity accounts at this time.
                'Case "PRINCIPAL DISBURSEMENT"
                '    'Draws inititated on lines of credit
                '    txtID.Text = bnkStruct.id
                '    txtType.Text = bnkStruct.Type
                '    txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                '    txtAcntNum.Text = "2730-5"
                '    txtActName.Text = "Equity Account payable" 'THis is the actDescription
                '    txtPostDate.Text = bnkStruct.PostDate
                '    txtMemo.Text = bnkStruct.Memo
                '    txtDesc.Text = bnkStruct.Name

            Case "EQUITYTRANSFER"
                'Draws from equity trasfered into active accounts.
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                txtPostDate.Text = bnkStruct.PostDate
                lblHdnBusID.Text = "527"
                cmbBusiness.Text = "MORRIS"
                txtMasterAct.Text = "Mortgages payable"
                txtAcntNum.Text = "2730-5"
                txtActName.Text = "Property Equity"
                txtMemo.Text = bnkStruct.Memo
                If txtMemo.Text.Contains("4000547000") Then
                    ddlActivity.SelectedValue = 1  'General Administrative
                ElseIf txtMemo.Text.Contains("4000547200") Then
                    ddlActivity.SelectedValue = 3  '624 Restore
                End If
                txtDesc.Text = bnkStruct.Name

            Case "INTERNALTRANSFER"
                'Payments, principle(ie. inititated on lines of credit), transfer from account to account
                'This is tough because it can result in needing an offsetting transacion.
                'This will be stored in a Bank Transaction sturcture

                'Populate posting form as any normal action to remove funds.
                'bnkOffset = bnkStruct  'Clone a new structure for offsetting transaction in source account
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtPostDate.Text = bnkStruct.PostDate
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                'This assigns proper transfer account numbers
                If bnkStruct.Amount > 0 Then
                    txtAcntNum.Text = "4000-1"
                    txtActName.Text = "Internal Balanced Cash Credit"
                    txtMasterAct.Text = "Neutral Transactions"

                Else
                    txtAcntNum.Text = "7000-1"
                    txtActName.Text = "Internal Balanced Cash Debit"
                    txtMasterAct.Text = "Neutral Transactions"

                End If
                ddlActivity.SelectedIndex = 0 'Picks no transaction
                txtMemo.Text = bnkStruct.Memo
                txtDesc.Text = bnkStruct.Name
                cmbBusiness.Text = "MORRIS"
                ddlActivity.Text = "Internal"
                'Change the amount to be an offset
                'The offset account will not be displayed but will create a journal entry
                'Offset.id = bnkStruct.id
                'Offset.Type = bnkStruct.Type
                'Offset.PostDate = bnkStruct.PostDate
                'Offset.Memo = bnkStruct.Memo
                'Offset.Name = bnkStruct.Name
                'Offset.Amount = (bnkStruct.Amount * -1).ToString("$######.#0") 'offset amount
                ''bnkOffset.Amount = (bnkStruct.Amount * -1).ToString("$######.#0") 'offset amount
                ' ' find offset source account
                'If bnkStruct.Memo.Contains("766712") Then   'Dublin RISING
                '    Offset.sourceAct = "766712"
                'ElseIf bnkStruct.Memo.Contains("67121") Then   'Dublin RENTAL
                '    Offset.sourceAct = "67121"
                'End If
                'Offset.actNum = "1010"   'This is the general checking account 
                'Offset.actNumSeq = "2"
                'Offset.busID = "527"   'Morris Bank


            Case "LOAN PAYMENT"
                'Payments of interest and principle(ie. inititated on lines of credit)
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                txtAcntNum.Text = "2730-5"
                txtActName.Text = "Equity Loan Payment"
                cmbBusiness.Text = "MORRIS"
                txtPostDate.Text = bnkStruct.PostDate
                txtMemo.Text = bnkStruct.Memo
                txtDesc.Text = bnkStruct.Name
                ddlActTyp.Text = "Expenses"

            Case "UNKNOWN"
                txtID.Text = bnkStruct.id
                txtType.Text = bnkStruct.Type
                txtAmount.Text = bnkStruct.Amount.ToString("$######.#0")
                'txtAcntNum.Text = ""
                txtActName.Text = ""
                txtPostDate.Text = bnkStruct.PostDate
                txtMemo.Text = bnkStruct.Memo
                txtDesc.Text = bnkStruct.Name
                ddlActTyp.Text = "Expenses"
        End Select
    End Sub
    Private Sub CheckCheck(ByRef strctCheckData As BankTransaction)
        'If IsNumeric(bnkAcct) Then
        'Dim lngGBnk As Long = CType(bnkAcct, Long)
        Dim strSql As String = "Select c.*,d.actNum, d.actNumSeq, d.actDescription from tblChecks c, tblDRCOA d where c.chkNumber  = " & strctCheckData.CheckNum
        strSql += " and c.chkBankAccount = " & strctCheckData.bankAccount
        strSql += " and c.chkMasterAccount = d.AcntID "
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        'Get Check Data
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim dr As SqlDataReader = oCommand.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            cmbBusiness.SelectedValue = dr("chkTOID").ToString
            ddlActivity.SelectedValue = dr("chkActivityID").ToString
            txtMasterAct.Text = dr("chkMasterAccount").ToString
            strctCheckData.Name = dr("chkNote")
            txtAcntNum.Text = dr("actNum").ToString.Trim & "-" & dr("actNumSeq").ToString.Trim
            txtActName.Text = dr("actDescription")
            txtDesc.Text = dr("chkNote")
            txtMemo.Text = dr("chkNumber") & "-" & dr("chkDate")
            lblHdnBusID.Text = dr(2)
            'cmbBusiness.Text = dr(2)
            dr.Close()
        Else
            strctCheckData.Name = "No Pre-written Check Found. Enter manually."
        End If
        cn.Close()








    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        baseform.Show()
    End Sub

    Sub ModifyForm(ByVal modType As String)
        Me.Refresh()
        txtID.Text = ""
        txtType.Text = ""
        txtPostDate.Text = ""
        txtAmount.Text = ""
        txtChkNum.Text = ""
        cmbBusiness.Text = ""
        txtDesc.Text = ""
        txtMemo.Text = ""
        txtActName.Text = ""
        txtAcntNum.Text = ""



        txtID.Enabled = True
        txtType.Enabled = True
        txtPostDate.Enabled = True
        txtAmount.Enabled = True
        txtChkNum.Enabled = True
        cmbBusiness.Enabled = True
        txtDesc.Enabled = True
        txtMemo.Enabled = True
        txtActName.Enabled = True
        txtAcntNum.Enabled = True
        Me.Refresh()
        LoadComplete = False
    End Sub
    Function GetBus(ByVal strName As String, ByVal strType As String, ByVal Id As Int64, ByVal bnkAct As String, ByVal myMemo As String) As String
        'Were getting the correct bus tagg and activity.
        'Then find the business if it exisits.
        'Dim lngTagged As Long
        ''The business may deal with several account types and therefore, have to branch in several ways.
        'If lngTagged = 0 Then  'A zero means the businesss likely serves multiple accounts and further parsing is necessary to properly assign the correcct one or someone forgot to assign one.
        Dim lngTagged As Long
        'This is a unique type that always gets the dame account
        If strType = "EQUITYTRANSFER" Then
            lblHdnBusID.Text = "527"
            cmbBusiness.Text = "MORRIS"
            'lngTagged = 1027
            If myMemo.Contains("4000547000") Then
                txtMasterAct.Text = "Mortgages payable"
                ddlActivity.SelectedValue = 1  'General Administrative
                cmbBusiness.SelectedText = "MORRIS"
            ElseIf myMemo.Contains("4000547200") Then
                txtMasterAct.Text = "Mortgages payable"
                ddlActivity.SelectedValue = 3  '624 Restore
                cmbBusiness.SelectedText = "MORRIS"
            ElseIf myMemo.Contains("766712") Then
                txtMasterAct.Text = "Individual/small business contribution"
                ddlActivity.SelectedValue = 1  'Doug and Jean for now
                cmbBusiness.SelectedText = "WOLFES"
            ElseIf myMemo.Contains("67121") Then
                txtMasterAct.Text = "Neutral Transactions"
                ddlActivity.SelectedValue = 0  '
                cmbBusiness.SelectedText = "MORRIS"

            End If
            Return -2
        End If

        '*******************************************
        'Find the businesss based on the incoming name
        Dim strSql As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        'Get common bus name from busName. See if there is an exact match of names.
        strSql = "select busName from tblBusiness where busName = '" & strName & "'"
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim strTempName As String = ""
        strTempName = oCommand.ExecuteScalar()

        '****************************************
        'IF no EXACT MATCH, LETS LOOK AT THE LEFT 15
        If Len(strTempName) = 0 Then
            'Get common bus name from busLeftName. There may be more than one left names.
            If Len(strName) > 15 Then
                strName = strName.Substring(0, 15)
            End If
            strSql = "select busName from tblBusiness where left(busLeftName,15) = '" & strName & "'"
            oCommand = New SqlCommand(strSql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            strTempName = oCommand.ExecuteScalar()
        End If
        '***************************************************
        'if no  business found then go to  AddBusiness module
        AddPayees.gblBusID = 0
        AddPayees.gblBusName = ""
        strName = strTempName
        strSql = "Select * from tblBusiness where UPPER(busname) = '" & strName.ToUpper.Trim & "'"  ' and  busSiblingID = 1 order by busname"   'This gets the businesses that are the first entry if there are more than one or the single entry if only one.
        '    End If
        If cn.State = ConnectionState.Closed Then cn.Open()
        oCommand = New SqlCommand(strSql, cn)
        Dim dr As SqlDataReader = oCommand.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            lblHdnBusID.Text = dr(0)
            cmbBusiness.Text = dr(2)
            lngTagged = dr.GetSqlInt64(12)
            dr.Close()
        End If
        cn.Close()
        strSql = "Select  (str(actNum) + '-' + LTrim(str(actNumSeq))) as actNumJoin, actName, actDescription "
        strSql += "from tblDRCOA where acntID = " & lngTagged
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtAcntNum.Text = dr(0).ToString().Trim
            txtActName.Text = dr(2).ToString().Trim
            txtMasterAct.Text = dr(1).ToString().Trim
            dr.Close()
            strName = txtAcntNum.Text  'Return bus ID ,
        Else
            Return "0"
            'No account found
        End If
        '**************************************************************
        Dim strStart As String = txtAcntNum.Text.Trim.Substring(0, 1)
        'Set account types Account Types   {"Expenses", "Income", "Assets", "Debts"}
        'Then populate lables
        Select Case strStart
            Case "7", "8", "9"
                ddlActTyp.Text = "Expenses"

            Case "4", "5", "6"
                ddlActTyp.Text = "Income"
            Case "1", "3"
                ddlActTyp.Text = "Assets"
            Case "2"
                ddlActTyp.Text = "Debts"
            Case Else

        End Select
        cn.Close()
        'Return the ID of the business found.
Leave:  Return lblHdnBusID.Text
    End Function

    Sub GetEntry()
        ModifyForm("Start")
        DisplayBusinesses()  'Completes dropdown of available businesses
        DisplayActivites() 'Completes dropdown of available activities
        AddBusiness.gblBusName = ""
        '*************************Filter transactions *********************************************
        'THe next lines allow saving of transactions you want to skip temporarily
        Dim strList As String = ""
        Dim strAddFilter As String = ""

        'This gets the imported information stored in the module array aryGEts.
        Dim intTrys As Int32 = aryGets.Count
        If intTrys > 0 Then
            For i As Integer = 0 To intTrys - 1
                If i = 0 Then
                    strList += aryGets(i).ToString
                Else
                    strList += ", " & aryGets(i).ToString
                End If
            Next
            'strList = "388, 389"
            strAddFilter = " and bnkTranID not in (" & strList & ")"
        End If
        '****************** GET STORED TRANSACTION FROM BANK **************************
        Dim strSql As String = "select * from tblDRTransactions where bnkPostedToJournal = '0'" & strAddFilter & " order by bnktranPostDate asc"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        'cn2 = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        'cn2.Open()
        Dim dr As SqlDataReader = oCommand.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            myTransactions.id = dr(0) 'bnkTranUD
            aryGets.Add(dr(0))
            myTransactions.bankAccount = dr(1) 'bnkActID
            myTransactions.Type = dr(2) 'bnkTranType
            myTransactions.PostDate = dr(3) 'bnkTranPostDAte
            myTransactions.Amount = dr(4) 'bnkTranAmount
            myTransactions.FITID = dr(5) 'bnkTranFTID (unique truansactoin ID
            myTransactions.CheckNum = dr(6) 'bnkTranCheckNum
            myTransactions.Name = dr(7).ToString.TrimStart   'Busines name where  available bnkTranName
            myTransactions.RefNum = dr(8) 'bnkTranRefNum
            myTransactions.Memo = dr(9) 'bnkTranMemo
        Else
            MessageBox.Show("No unposted transactions are available", "Message", MessageBoxButtons.OK)
            Exit Sub
        End If
        cn.Close()
        'Fill in case transfer to split
        Offset.id = myTransactions.id
        Offset.bankAccount = myTransactions.bankAccount
        '****************** GET RELATED BUSINESS ******************************
        'IF the business if valid, we have the account and account type already set. A multi digit number will be returned
        Dim busID As String = "0"
        If myTransactions.Name.Length > 0 Then
            busID = GetBus(myTransactions.Name, myTransactions.Type, myTransactions.id, myTransactions.bankAccount, myTransactions.Memo)
            Dim busExisits As Boolean = False
            If busID > 2 Then
                busExisits = True
                getBusHistory(busID)
            ElseIf busID = -2 Then
                busExisits = True
            End If

        End If
        Offset.busID = busID
        ParseTransactions(myTransactions)

        If txtType.Text = "DEP" Then btnDeposit.Visible = True
    End Sub

    Sub getBusHistory(ByVal busID As Int32)
        Dim strSQl As String = "select top 1 jnlActivity from tblDRJournal where jnlTranBusinessID =" & busID & " order by jnltrandate desc"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSQl, cn)
        cn.Open()
        Dim myText As String = oCommand.ExecuteScalar()
        If Not myText = Nothing Then
            ddlActivity.Text = oCommand.ExecuteScalar().ToString()
        End If
        cn.Close()
    End Sub

    Sub NeutralTransaction(ByVal ID As Long)
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "Update tblDRTransactions set bnkPostedToJournal = '2' where bnkTranID = " & ID
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Try
            oCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("SQL Error" & vbCrLf & strSql, "Errors", MessageBoxButtons.OK)
            Exit Sub
        End Try
        cn.Close()
    End Sub

    Private Sub btnGet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGet.Click
        GetEntry()
    End Sub

    Private Sub dgvAccounts_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.RowEnter
        Dim i As Integer = e.RowIndex
        Dim cell1 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(1), DataGridViewCell)
        Dim cell2 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(0), DataGridViewCell)
        Dim cell3 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(2), DataGridViewCell)
        If cell1.Value <> Nothing Then
            txtAcntNum.Text = cell1.Value.ToString.Trim
            txtActName.Text = cell2.Value.ToString.Trim
            txtMasterAct.Text = cell3.Value.ToString.Trim
        End If
    End Sub

    Private Sub btnBusiness_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusiness.Click
        GetBusiness.busName = ""
        GetBusiness.ShowDialog()
        If GetBusiness.busName <> "" Then
            SetAccount(GetBusiness.actID)
            cmbBusiness.Text = GetBusiness.busName.Trim
            lblHdnBusID.Text = GetBusiness.busID
        End If

        GetBusiness.actID = 0
        GetBusiness.busID = 0
        GetBusiness.busName = ""
    End Sub

    Public Function SetAccount(ByVal id As Int32) As Boolean
        Dim strSql As String = "select (str(actNum) + '-' + LTrim(str(actNumSeq))) as actNumJoin, actName, actDescription "
        strSql += "from tblDRCOA where acntID = " & id
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        Me.lblCaption.Text = Me.ddlActTyp.Text

        If id > 0 Then
            cn.Open()
            Dim dr As SqlDataReader = oCommand.ExecuteReader()
            dr.Read()
            txtAcntNum.Text = dr(0).ToString().Trim
            txtMasterAct.Text = dr(1).ToString().Trim
            txtActName.Text = dr(2).ToString().Trim
            cn.Close()
        End If
        DisplayGrid(id)
        Return True
    End Function
    Sub reCycle()
        cmbBusiness.Refresh()
    End Sub

    Function validateSave(ByRef msg As String) As Boolean
        If Len(txtID.Text.Trim) = 0 Then
            msg = "You cannot post an incomplete transaction!"
            Return False
        End If
        If ddlActivity.Text.Trim = "Select One" Then
            msg = "You must select an activity!"
            Return False
        End If
        If Len(lblHdnBusID.Text) = 0 Then
            msg = "You must select a business for this transaction!"
            Return False
        End If
        txtAcntNum.Text = Trim(txtAcntNum.Text)
        If Len(txtAcntNum.Text) < 1 Then
            msg = "You must select an account for this transaction!"
            Return False
        Else
            txtAcntNum.Text = Trim(txtAcntNum.Text)
        End If
        If Microsoft.VisualBasic.Left(txtMemo.Text, 1) = "*" Then
            txtDesc.Text = "None"
        End If
        If Microsoft.VisualBasic.Left(txtMemo.Text, 1) = "*" Then
            txtMemo.Text = "None"
        End If
        If Len(txtID.Text.Trim) = 0 Then
            msg = "You cannot post an incomplete transaction!"
            Return False
        End If
        validateSave = True
    End Function

    Private Sub btnPost_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPost.Click
        Dim errMessage As String = SaveToJournal()
        If errMessage = "NONE" Then
            If txtType.Text = "DEP" Then
                Dim ans As Integer = MsgBox("Do you want to split this deposit transaction?", MsgBoxStyle.YesNo, "Split")
                If ans = 6 Then
                    AllocDep.journlID = jnlDeposit
                    AllocDep.ShowDialog()

                End If
            End If
            Dim myMessage As New frmMsg("Your entry was posted!")
            myMessage.ShowDialog()
        Else
            Dim myMessage As New frmMsg(errMessage)
            myMessage.ShowDialog() 'Do not clear out form on error
            Exit Sub
        End If
        ModifyForm("X")  'Clear out the old data frorm theform.
        ClearSibling()
        ClearOffsetStructure()
        GetEntry()

    End Sub
    Function SaveToJournal() As String
        Dim errMessage As String = "NONE"
        Dim strSql As String
        'The following 4 lines are to get a business name in the Desc column when a check is written.
        If txtDesc.Text.Contains("Enter Details from Check Book here") Then
            txtDesc.Text = "No Detail"
        End If
        txtDesc.Text = cmbBusiness.Text & ":" & txtDesc.Text
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        If validateSave(errMessage) Then
            Dim lNum As String = Microsoft.VisualBasic.Left(Trim(txtAcntNum.Text), 4)
            Dim sNum As Integer = (Trim(txtAcntNum.Text)).LastIndexOf("-") + 1
            Dim n As Integer = Len(Trim(txtAcntNum.Text))
            Dim rNum As String = Microsoft.VisualBasic.Right(Trim(txtAcntNum.Text), n - sNum)

            Dim x As String = ddlActivity.SelectedValue.ToString()
            Dim x2 As String = getActivity(x) 'ddlActivity.Text
            'Offset.activityID = x  'Add these 2 fields where an offsetting transaction is occurring.
            'Offset.activityText = x2
            strSql = "Insert into tblDRJournal "
            strSql += "(jnlActID,jnlActNum, jnlActSeq,jnlTranDate, jnlTranType, jnlTranAmount, jnlTranDesc, jnlTranMemo, jnlTranBusinessID, jnlBankTranId, timeStamp, jnlBankAct, jnlActivity, jnlActivityID, jnlActive)"
            strSql += "Values(0,"     'Set jnlActID = 0. Can not be null.
            strSql += lNum & ", "
            strSql += rNum & ","
            strSql += "'" & txtPostDate.Text & "',"
            strSql += "'" & txtType.Text & "',"
            strSql += txtAmount.Text & ","
            strSql += "'" & txtDesc.Text & "',"
            strSql += "'" & txtMemo.Text & "',"
            strSql += lblHdnBusID.Text & ","
            strSql += txtID.Text & ",'"
            strSql += Now() & "','"
            strSql += txtBankAct.Text & "', "
            strSql += "'" & x2 & "', "
            strSql += x & ", "
            strSql += jnlActive & ")SELECT CAST(scope_identity() AS int)"
            '-----------------------------
            'GoTo temptest
            cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
            oCommand = New SqlCommand(strSql, cn)
            cn.Open()
            Try
                jnlDeposit = oCommand.ExecuteScalar()
            Catch ex As Exception
                Return "SQL Error" & vbCrLf & strSql
                Exit Function
            End Try
            Offset.Amount = 0

            strSql = "Update tblDRTransactions set bnkPostedToJournal = '1' where bnkTranID = " & txtID.Text
            oCommand = New SqlCommand(strSql, cn)

            Try
                oCommand.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("SQL Error" & vbCrLf & strSql, "Errors", MessageBoxButtons.OK)
                Return "SQL Error" & vbCrLf & strSql
                Exit Function
            End Try
            cn.Close()
            '--------------------------
            'temptest:
            'MessageBox.Show("Your entry was posted!" & vbCrLf & errMessage, "Save Confirm", MessageBoxButtons.OK)
        Else
            'MessageBox.Show("Could not post to journal!" & vbCrLf & errMessage, "Save Error", MessageBoxButtons.OK)
            Return "Could not post to journal!" & vbCrLf & errMessage
            Exit Function
        End If

        Return "NONE"
    End Function
    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        'AllocDep.journlID = 1234
        'AllocDep.ShowDialog()
        Dim strMessage As String = SaveToJournal()
        If strMessage = "NONE" Then
            AllocDep.journlID = jnlDeposit
            AllocDep.ShowDialog()
            Dim myMessage As New frmMsg("Your entry was posted!")
            myMessage.ShowDialog()
        Else
            Dim myMessage As New frmMsg(strMessage)
            myMessage.ShowDialog() 'Do not clear out form on error
            Exit Sub
        End If
        ModifyForm("X")  'Clear out the old data frorm theform.
        ClearSibling()
        ClearOffsetStructure()
        GetEntry()
       
    End Sub
    Sub ClearSibling()
        SiblingCheck.txtCommonBusName.Text = ""
        SiblingCheck.txtSiblingID.Text = ""

    End Sub



    Private Sub btnAddAcct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAcct.Click
        ManageAccount.frmCalling = ""
        ManageAccount.ShowDialog()
        ' cmbBusiness.Text = GetBusiness.busName
        'lblHdnBusID.Text = GetBusiness.busID
    End Sub

    Private Sub btnSkip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkip.Click
        Dim id As Int64 = Convert.ToInt64(txtID.Text)
        MarkForReview(id)

    End Sub
    Sub MarkForReview(ByVal id As Int64)
        Dim strSql As String = "Update tblDRTransactions set bnkTranRefNum = 99999999999, bnkPostedToJournal = '2' where bnkTranID = " & id
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        oCommand.ExecuteNonQuery()
        cn.Close()
        ModifyForm("a")
        GetEntry()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
       
        DisplayGrid(0)


    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        If cmbBusiness.Text <> "Select Business" Then
            AddPayees.txtDisplayName.Text = cmbBusiness.Text.ToUpper
            AddPayees.txtBusiness.Text = Microsoft.VisualBasic.Left(cmbBusiness.Text.ToUpper, 20)
            AddPayees.ShowDialog()
            'Me.Hide()
            cmbBusiness.Text = AddPayees.gblBusName
            txtDesc.Text = AddPayees.gblBusName
            GetBus(cmbBusiness.Text, "Expenses", 0, "", "")
            AddPayees.Close()
        Else

            MsgBox("You must enter a name for a business before proceeding", MsgBoxStyle.OkOnly)

        End If

    End Sub

    Private Sub cmbBusiness_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBusiness.TextChanged
        If LoadComplete Then
            btnChange.Enabled = True ' AddPayees.ShowDialog()
        End If
    End Sub

    Private Sub cmbBusiness_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBusiness.SelectedIndexChanged
        Dim myID As Int32 = 0
        If LoadComplete Then
            If cmbBusiness.Text.Length > 0 Then
                'Get the acnt type id from the business table field tagged account.
                lblHdnBusID.Text = cmbBusiness.SelectedValue
                lblHdnTagID.Text = cmbBusiness.Text
                Dim strSql As String = "select top(1) taggedAccount from tblBusiness where busName = '" & lblHdnTagID.Text & "' order by busname"
                cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
                oCommand = New SqlCommand(strSql, cn)
                cn.Open()
                myID = oCommand.ExecuteScalar()
                cn.Close()
                If myID > 0 Then
                    SetAccount(myID)
                    btnPost.Focus()
                End If

            End If
        End If
    End Sub

    Function FindAccountFromMemo(ByVal memo As String) As String
        If memo.Contains("4000547000") Then
            Return "4000547000"

        ElseIf memo.Contains("4000547200") Then
            Return "4000547200"

        ElseIf memo.Contains("766712") Then
            Return "766712"

        ElseIf memo.Contains("67121") Then
            Return "67121"

        End If

        Return "Other"

    End Function

    Sub ClearOffsetStructure()
        Offset.id = 0
        Offset.Type = ""
        Offset.bankAccount = ""
        Offset.PostDate = ""
        Offset.Amount = 0
        Offset.FITID = 0
        Offset.CheckNum = 0
        Offset.Name = ""
        Offset.RefNum = ""
        Offset.Memo = ""
        Offset.actNum = ""
        Offset.actNumSeq = ""
        Offset.sourceAct = ""
        Offset.busID = "0"
        Offset.activityID = ""
        Offset.activityText = ""
    End Sub
    Private Function getActivity(ByVal inID As Long) As String
        Dim strSql As String = "Select activityDescription from tblActivity where activityID = " & inID
        On Error GoTo HandleME
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        Return oCommand.ExecuteScalar()
        cn.Close()
        Return "dd"
        Exit Function
HandleME:
        MsgBox("No Activity Found!. Contact Administrator!", MsgBoxStyle.OkOnly)
        Return ""
        Exit Function
    End Function

   

 
End Class

