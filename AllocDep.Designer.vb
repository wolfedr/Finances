<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllocDep
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnStore = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.hdnEntityID = New System.Windows.Forms.Label
        Me.dgvAccounts = New System.Windows.Forms.DataGridView
        Me.IDCol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Account = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblInst3B = New System.Windows.Forms.Label
        Me.hdnBankAccount = New System.Windows.Forms.Label
        Me.hdnBankTranID = New System.Windows.Forms.Label
        Me.hdnATMRemaining = New System.Windows.Forms.Label
        Me.btnAllocate = New System.Windows.Forms.Button
        Me.grpNewDat = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtActName = New System.Windows.Forms.TextBox
        Me.txtActNum = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ddlActivity = New System.Windows.Forms.ComboBox
        Me.lblInst2 = New System.Windows.Forms.Label
        Me.txtAmountToAllocate = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNewDesciption = New System.Windows.Forms.TextBox
        Me.hdnRowCount = New System.Windows.Forms.Label
        Me.hdnATMOriginalAmount = New System.Windows.Forms.Label
        Me.hdnAccount = New System.Windows.Forms.Label
        Me.hdnCounter = New System.Windows.Forms.Label
        Me.hdnLinker = New System.Windows.Forms.Label
        Me.lblInst4 = New System.Windows.Forms.Label
        Me.ddlDeposits = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.hdnActivityID = New System.Windows.Forms.Label
        Me.dgvLOA = New System.Windows.Forms.DataGridView
        Me.colAlID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMyLinker = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMyAccount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMyDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMyType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMyAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMyDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMyMemo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMyEntity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BankID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMyBankAccount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEntID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ActivityID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Activity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNewDat.SuspendLayout()
        CType(Me.dgvLOA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStore)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(393, 285)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 120)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update Database"
        '
        'btnStore
        '
        Me.btnStore.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStore.Location = New System.Drawing.Point(6, 53)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(151, 23)
        Me.btnStore.TabIndex = 6
        Me.btnStore.Text = "Save All to Journal"
        Me.btnStore.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(6, 24)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(151, 23)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear All Form Data"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(6, 82)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(151, 24)
        Me.btnClose.TabIndex = 75
        Me.btnClose.Text = "Exit Split Deposit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'hdnEntityID
        '
        Me.hdnEntityID.AutoSize = True
        Me.hdnEntityID.Location = New System.Drawing.Point(817, 445)
        Me.hdnEntityID.Name = "hdnEntityID"
        Me.hdnEntityID.Size = New System.Drawing.Size(24, 13)
        Me.hdnEntityID.TabIndex = 74
        Me.hdnEntityID.Text = "    x"
        Me.hdnEntityID.Visible = False
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCol, Me.Account, Me.actDescription})
        Me.dgvAccounts.Location = New System.Drawing.Point(701, 47)
        Me.dgvAccounts.Name = "dgvAccounts"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAccounts.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAccounts.Size = New System.Drawing.Size(391, 394)
        Me.dgvAccounts.TabIndex = 33
        '
        'IDCol
        '
        Me.IDCol.DataPropertyName = "acntID"
        Me.IDCol.HeaderText = "ID"
        Me.IDCol.Name = "IDCol"
        Me.IDCol.Width = 35
        '
        'Account
        '
        Me.Account.DataPropertyName = "actNumJoin"
        Me.Account.HeaderText = "Account"
        Me.Account.Name = "Account"
        Me.Account.Width = 70
        '
        'actDescription
        '
        Me.actDescription.DataPropertyName = "actDescription"
        Me.actDescription.HeaderText = "Description"
        Me.actDescription.MinimumWidth = 50
        Me.actDescription.Name = "actDescription"
        Me.actDescription.Width = 250
        '
        'lblInst3B
        '
        Me.lblInst3B.AutoSize = True
        Me.lblInst3B.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst3B.Location = New System.Drawing.Point(718, 18)
        Me.lblInst3B.Name = "lblInst3B"
        Me.lblInst3B.Size = New System.Drawing.Size(318, 26)
        Me.lblInst3B.TabIndex = 37
        Me.lblInst3B.Text = "Manually Select or Change Account"
        Me.lblInst3B.Visible = False
        '
        'hdnBankAccount
        '
        Me.hdnBankAccount.AutoSize = True
        Me.hdnBankAccount.Location = New System.Drawing.Point(1035, 445)
        Me.hdnBankAccount.Name = "hdnBankAccount"
        Me.hdnBankAccount.Size = New System.Drawing.Size(24, 13)
        Me.hdnBankAccount.TabIndex = 70
        Me.hdnBankAccount.Text = "    x"
        Me.hdnBankAccount.Visible = False
        '
        'hdnBankTranID
        '
        Me.hdnBankTranID.AutoSize = True
        Me.hdnBankTranID.Location = New System.Drawing.Point(931, 445)
        Me.hdnBankTranID.Name = "hdnBankTranID"
        Me.hdnBankTranID.Size = New System.Drawing.Size(24, 13)
        Me.hdnBankTranID.TabIndex = 69
        Me.hdnBankTranID.Text = "    x"
        Me.hdnBankTranID.Visible = False
        '
        'hdnATMRemaining
        '
        Me.hdnATMRemaining.AutoSize = True
        Me.hdnATMRemaining.Location = New System.Drawing.Point(305, 428)
        Me.hdnATMRemaining.Name = "hdnATMRemaining"
        Me.hdnATMRemaining.Size = New System.Drawing.Size(24, 13)
        Me.hdnATMRemaining.TabIndex = 68
        Me.hdnATMRemaining.Text = "    x"
        Me.hdnATMRemaining.Visible = False
        '
        'btnAllocate
        '
        Me.btnAllocate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllocate.Location = New System.Drawing.Point(66, 205)
        Me.btnAllocate.Name = "btnAllocate"
        Me.btnAllocate.Size = New System.Drawing.Size(141, 23)
        Me.btnAllocate.TabIndex = 5
        Me.btnAllocate.Text = "Add to Split Display"
        Me.btnAllocate.UseVisualStyleBackColor = True
        '
        'grpNewDat
        '
        Me.grpNewDat.Controls.Add(Me.Label7)
        Me.grpNewDat.Controls.Add(Me.txtActName)
        Me.grpNewDat.Controls.Add(Me.txtActNum)
        Me.grpNewDat.Controls.Add(Me.Label6)
        Me.grpNewDat.Controls.Add(Me.btnAllocate)
        Me.grpNewDat.Controls.Add(Me.ddlActivity)
        Me.grpNewDat.Controls.Add(Me.lblInst2)
        Me.grpNewDat.Controls.Add(Me.txtAmountToAllocate)
        Me.grpNewDat.Controls.Add(Me.Label3)
        Me.grpNewDat.Controls.Add(Me.Label4)
        Me.grpNewDat.Controls.Add(Me.Label1)
        Me.grpNewDat.Controls.Add(Me.txtNewDesciption)
        Me.grpNewDat.Location = New System.Drawing.Point(38, 121)
        Me.grpNewDat.Name = "grpNewDat"
        Me.grpNewDat.Size = New System.Drawing.Size(278, 252)
        Me.grpNewDat.TabIndex = 71
        Me.grpNewDat.TabStop = False
        Me.grpNewDat.Text = "Manual Entries"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(73, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Journal Account"
        '
        'txtActName
        '
        Me.txtActName.Location = New System.Drawing.Point(93, 179)
        Me.txtActName.Name = "txtActName"
        Me.txtActName.Size = New System.Drawing.Size(179, 20)
        Me.txtActName.TabIndex = 83
        '
        'txtActNum
        '
        Me.txtActNum.Location = New System.Drawing.Point(6, 179)
        Me.txtActNum.Name = "txtActNum"
        Me.txtActNum.Size = New System.Drawing.Size(81, 20)
        Me.txtActNum.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(63, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 13)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Activitiy Being Split Off"
        '
        'ddlActivity
        '
        Me.ddlActivity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ddlActivity.FormattingEnabled = True
        Me.ddlActivity.Location = New System.Drawing.Point(50, 137)
        Me.ddlActivity.Name = "ddlActivity"
        Me.ddlActivity.Size = New System.Drawing.Size(157, 21)
        Me.ddlActivity.TabIndex = 4
        '
        'lblInst2
        '
        Me.lblInst2.AutoSize = True
        Me.lblInst2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst2.Location = New System.Drawing.Point(6, 11)
        Me.lblInst2.Name = "lblInst2"
        Me.lblInst2.Size = New System.Drawing.Size(239, 26)
        Me.lblInst2.TabIndex = 38
        Me.lblInst2.Text = " Enter Amount and Details"
        Me.lblInst2.Visible = False
        '
        'txtAmountToAllocate
        '
        Me.txtAmountToAllocate.Location = New System.Drawing.Point(76, 59)
        Me.txtAmountToAllocate.Name = "txtAmountToAllocate"
        Me.txtAmountToAllocate.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountToAllocate.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Activity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Amount of Deposit to Split Off:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Description"
        '
        'txtNewDesciption
        '
        Me.txtNewDesciption.Location = New System.Drawing.Point(6, 98)
        Me.txtNewDesciption.Name = "txtNewDesciption"
        Me.txtNewDesciption.Size = New System.Drawing.Size(263, 20)
        Me.txtNewDesciption.TabIndex = 2
        Me.txtNewDesciption.Text = "  "
        '
        'hdnRowCount
        '
        Me.hdnRowCount.AutoSize = True
        Me.hdnRowCount.Location = New System.Drawing.Point(46, 428)
        Me.hdnRowCount.Name = "hdnRowCount"
        Me.hdnRowCount.Size = New System.Drawing.Size(24, 13)
        Me.hdnRowCount.TabIndex = 67
        Me.hdnRowCount.Text = "    x"
        Me.hdnRowCount.Visible = False
        '
        'hdnATMOriginalAmount
        '
        Me.hdnATMOriginalAmount.AutoSize = True
        Me.hdnATMOriginalAmount.Location = New System.Drawing.Point(292, 428)
        Me.hdnATMOriginalAmount.Name = "hdnATMOriginalAmount"
        Me.hdnATMOriginalAmount.Size = New System.Drawing.Size(24, 13)
        Me.hdnATMOriginalAmount.TabIndex = 66
        Me.hdnATMOriginalAmount.Text = "    x"
        Me.hdnATMOriginalAmount.Visible = False
        '
        'hdnAccount
        '
        Me.hdnAccount.AutoSize = True
        Me.hdnAccount.Location = New System.Drawing.Point(138, 428)
        Me.hdnAccount.Name = "hdnAccount"
        Me.hdnAccount.Size = New System.Drawing.Size(24, 13)
        Me.hdnAccount.TabIndex = 65
        Me.hdnAccount.Text = "    x"
        Me.hdnAccount.Visible = False
        '
        'hdnCounter
        '
        Me.hdnCounter.AutoSize = True
        Me.hdnCounter.Location = New System.Drawing.Point(85, 428)
        Me.hdnCounter.Name = "hdnCounter"
        Me.hdnCounter.Size = New System.Drawing.Size(24, 13)
        Me.hdnCounter.TabIndex = 64
        Me.hdnCounter.Text = "    x"
        Me.hdnCounter.Visible = False
        '
        'hdnLinker
        '
        Me.hdnLinker.AutoSize = True
        Me.hdnLinker.Location = New System.Drawing.Point(67, 428)
        Me.hdnLinker.Name = "hdnLinker"
        Me.hdnLinker.Size = New System.Drawing.Size(24, 13)
        Me.hdnLinker.TabIndex = 63
        Me.hdnLinker.Text = "    x"
        Me.hdnLinker.Visible = False
        '
        'lblInst4
        '
        Me.lblInst4.AutoSize = True
        Me.lblInst4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst4.Location = New System.Drawing.Point(428, 9)
        Me.lblInst4.Name = "lblInst4"
        Me.lblInst4.Size = New System.Drawing.Size(166, 26)
        Me.lblInst4.TabIndex = 78
        Me.lblInst4.Text = "Review And Clear"
        Me.lblInst4.Visible = False
        '
        'ddlDeposits
        '
        Me.ddlDeposits.FormattingEnabled = True
        Me.ddlDeposits.Location = New System.Drawing.Point(336, 132)
        Me.ddlDeposits.Name = "ddlDeposits"
        Me.ddlDeposits.Size = New System.Drawing.Size(296, 21)
        Me.ddlDeposits.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(430, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Deposits to Split"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(405, 428)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Splits Display of Deposit"
        '
        'hdnActivityID
        '
        Me.hdnActivityID.AutoSize = True
        Me.hdnActivityID.Location = New System.Drawing.Point(1122, 445)
        Me.hdnActivityID.Name = "hdnActivityID"
        Me.hdnActivityID.Size = New System.Drawing.Size(24, 13)
        Me.hdnActivityID.TabIndex = 82
        Me.hdnActivityID.Text = "    x"
        Me.hdnActivityID.Visible = False
        '
        'dgvLOA
        '
        Me.dgvLOA.AllowUserToDeleteRows = False
        Me.dgvLOA.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvLOA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLOA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAlID, Me.colMyLinker, Me.colMyAccount, Me.colMyDate, Me.colMyType, Me.colMyAmount, Me.colMyDesc, Me.colMyMemo, Me.colMyEntity, Me.BankID, Me.colMyBankAccount, Me.colEntID, Me.ActivityID, Me.Activity})
        Me.dgvLOA.Location = New System.Drawing.Point(10, 461)
        Me.dgvLOA.Name = "dgvLOA"
        Me.dgvLOA.RowHeadersWidth = 4
        Me.dgvLOA.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvLOA.Size = New System.Drawing.Size(1197, 173)
        Me.dgvLOA.TabIndex = 62
        '
        'colAlID
        '
        Me.colAlID.DataPropertyName = "ID"
        Me.colAlID.HeaderText = "ID"
        Me.colAlID.Name = "colAlID"
        Me.colAlID.Width = 35
        '
        'colMyLinker
        '
        Me.colMyLinker.DataPropertyName = "Linker"
        Me.colMyLinker.HeaderText = "Linker"
        Me.colMyLinker.Name = "colMyLinker"
        Me.colMyLinker.Width = 70
        '
        'colMyAccount
        '
        Me.colMyAccount.DataPropertyName = "Account"
        Me.colMyAccount.HeaderText = "Account"
        Me.colMyAccount.Name = "colMyAccount"
        Me.colMyAccount.Width = 50
        '
        'colMyDate
        '
        Me.colMyDate.DataPropertyName = "Transaction Date"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colMyDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.colMyDate.HeaderText = "Date"
        Me.colMyDate.Name = "colMyDate"
        Me.colMyDate.Width = 60
        '
        'colMyType
        '
        Me.colMyType.DataPropertyName = "Type"
        Me.colMyType.HeaderText = "Type"
        Me.colMyType.Name = "colMyType"
        Me.colMyType.Width = 50
        '
        'colMyAmount
        '
        Me.colMyAmount.DataPropertyName = "Amount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colMyAmount.DefaultCellStyle = DataGridViewCellStyle3
        Me.colMyAmount.HeaderText = "Amount"
        Me.colMyAmount.Name = "colMyAmount"
        Me.colMyAmount.Width = 70
        '
        'colMyDesc
        '
        Me.colMyDesc.DataPropertyName = "Description"
        Me.colMyDesc.HeaderText = "Description"
        Me.colMyDesc.Name = "colMyDesc"
        Me.colMyDesc.Width = 220
        '
        'colMyMemo
        '
        Me.colMyMemo.DataPropertyName = "Memo"
        Me.colMyMemo.HeaderText = "Memo"
        Me.colMyMemo.Name = "colMyMemo"
        Me.colMyMemo.Width = 200
        '
        'colMyEntity
        '
        Me.colMyEntity.DataPropertyName = "Entity"
        Me.colMyEntity.HeaderText = "Entity"
        Me.colMyEntity.Name = "colMyEntity"
        Me.colMyEntity.Width = 140
        '
        'BankID
        '
        Me.BankID.DataPropertyName = "BankID"
        Me.BankID.HeaderText = "Bank ID"
        Me.BankID.Name = "BankID"
        '
        'colMyBankAccount
        '
        Me.colMyBankAccount.DataPropertyName = "Bank Account"
        Me.colMyBankAccount.HeaderText = "Bank Acct."
        Me.colMyBankAccount.Name = "colMyBankAccount"
        Me.colMyBankAccount.Width = 90
        '
        'colEntID
        '
        Me.colEntID.DataPropertyName = "EntityID"
        Me.colEntID.HeaderText = "EntityID"
        Me.colEntID.Name = "colEntID"
        Me.colEntID.Visible = False
        '
        'ActivityID
        '
        Me.ActivityID.DataPropertyName = "jnlActivityID"
        Me.ActivityID.HeaderText = "Activity ID"
        Me.ActivityID.Name = "ActivityID"
        Me.ActivityID.Visible = False
        '
        'Activity
        '
        Me.Activity.DataPropertyName = "jnlActivity"
        Me.Activity.HeaderText = "Activity"
        Me.Activity.Name = "Activity"
        '
        'AllocDep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 728)
        Me.Controls.Add(Me.hdnActivityID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ddlDeposits)
        Me.Controls.Add(Me.lblInst3B)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.lblInst4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.hdnEntityID)
        Me.Controls.Add(Me.hdnBankAccount)
        Me.Controls.Add(Me.hdnBankTranID)
        Me.Controls.Add(Me.hdnATMRemaining)
        Me.Controls.Add(Me.grpNewDat)
        Me.Controls.Add(Me.hdnRowCount)
        Me.Controls.Add(Me.hdnATMOriginalAmount)
        Me.Controls.Add(Me.hdnAccount)
        Me.Controls.Add(Me.hdnCounter)
        Me.Controls.Add(Me.hdnLinker)
        Me.Controls.Add(Me.dgvLOA)
        Me.Name = "AllocDep"
        Me.Text = "AllocDep"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNewDat.ResumeLayout(False)
        Me.grpNewDat.PerformLayout()
        CType(Me.dgvLOA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnStore As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents hdnEntityID As System.Windows.Forms.Label
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents IDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblInst3B As System.Windows.Forms.Label
    Friend WithEvents hdnBankAccount As System.Windows.Forms.Label
    Friend WithEvents hdnBankTranID As System.Windows.Forms.Label
    Friend WithEvents hdnATMRemaining As System.Windows.Forms.Label
    Friend WithEvents btnAllocate As System.Windows.Forms.Button
    Friend WithEvents grpNewDat As System.Windows.Forms.GroupBox
    Friend WithEvents ddlActivity As System.Windows.Forms.ComboBox
    Friend WithEvents lblInst2 As System.Windows.Forms.Label
    Friend WithEvents txtAmountToAllocate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNewDesciption As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents hdnRowCount As System.Windows.Forms.Label
    Friend WithEvents hdnATMOriginalAmount As System.Windows.Forms.Label
    Friend WithEvents hdnAccount As System.Windows.Forms.Label
    Friend WithEvents hdnCounter As System.Windows.Forms.Label
    Friend WithEvents hdnLinker As System.Windows.Forms.Label
    Friend WithEvents lblInst4 As System.Windows.Forms.Label
    Friend WithEvents ddlDeposits As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents hdnActivityID As System.Windows.Forms.Label
    Friend WithEvents dgvLOA As System.Windows.Forms.DataGridView
    Friend WithEvents colAlID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyLinker As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyMemo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyEntity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyBankAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEntID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivityID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Activity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtActName As System.Windows.Forms.TextBox
    Friend WithEvents txtActNum As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
