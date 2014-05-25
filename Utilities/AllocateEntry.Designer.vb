<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllocateEntry
    Inherits Finances.baseform

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Me.colMyEntryID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMyBankAccount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEntID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvEntries = New System.Windows.Forms.DataGridView
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnClear = New System.Windows.Forms.Button
        Me.hdnLinker = New System.Windows.Forms.Label
        Me.hdnCounter = New System.Windows.Forms.Label
        Me.dgvAccounts = New System.Windows.Forms.DataGridView
        Me.actDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acntID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtAmountToAllocate = New System.Windows.Forms.TextBox
        Me.lblInst1 = New System.Windows.Forms.Label
        Me.lblInst3B = New System.Windows.Forms.Label
        Me.lblInst4 = New System.Windows.Forms.Label
        Me.hdnAccount = New System.Windows.Forms.Label
        Me.btnAllocate = New System.Windows.Forms.Button
        Me.hdnATMOriginalAmount = New System.Windows.Forms.Label
        Me.hdnRowCount = New System.Windows.Forms.Label
        Me.hdnATMRemaining = New System.Windows.Forms.Label
        Me.btnStore = New System.Windows.Forms.Button
        Me.txtNewDesciption = New System.Windows.Forms.TextBox
        Me.txtNewMemo = New System.Windows.Forms.TextBox
        Me.ddlEntity = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.hdnBankTranID = New System.Windows.Forms.Label
        Me.hdnBankAccount = New System.Windows.Forms.Label
        Me.grpNewDat = New System.Windows.Forms.GroupBox
        Me.lblInst3A = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblAllocate = New System.Windows.Forms.Label
        Me.lblInst2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grpAccount = New System.Windows.Forms.GroupBox
        Me.grpATMTransaction = New System.Windows.Forms.GroupBox
        Me.hdnEntityID = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        CType(Me.dgvLOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNewDat.SuspendLayout()
        Me.grpAccount.SuspendLayout()
        Me.grpATMTransaction.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLOA
        '
        Me.dgvLOA.AllowUserToDeleteRows = False
        Me.dgvLOA.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvLOA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLOA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAlID, Me.colMyLinker, Me.colMyAccount, Me.colMyDate, Me.colMyType, Me.colMyAmount, Me.colMyDesc, Me.colMyMemo, Me.colMyEntity, Me.colMyEntryID, Me.colMyBankAccount, Me.colEntID})
        Me.dgvLOA.Location = New System.Drawing.Point(15, 70)
        Me.dgvLOA.Name = "dgvLOA"
        Me.dgvLOA.RowHeadersWidth = 4
        Me.dgvLOA.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvLOA.Size = New System.Drawing.Size(1057, 141)
        Me.dgvLOA.TabIndex = 4
        Me.dgvLOA.Visible = False
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
        Me.colMyLinker.Width = 60
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colMyDate.DefaultCellStyle = DataGridViewCellStyle7
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.colMyAmount.DefaultCellStyle = DataGridViewCellStyle8
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
        'colMyEntryID
        '
        Me.colMyEntryID.DataPropertyName = "BankID"
        Me.colMyEntryID.HeaderText = "Entry"
        Me.colMyEntryID.Name = "colMyEntryID"
        Me.colMyEntryID.Width = 35
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
        'dgvEntries
        '
        Me.dgvEntries.AllowUserToAddRows = False
        Me.dgvEntries.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEntries.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvEntries.ColumnHeadersHeight = 28
        Me.dgvEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEntries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colType, Me.colName, Me.colAmt, Me.colDate})
        Me.dgvEntries.Location = New System.Drawing.Point(0, 66)
        Me.dgvEntries.Name = "dgvEntries"
        Me.dgvEntries.RowHeadersWidth = 10
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEntries.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvEntries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvEntries.Size = New System.Drawing.Size(383, 381)
        Me.dgvEntries.TabIndex = 29
        '
        'colID
        '
        Me.colID.DataPropertyName = "jnlID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 34
        '
        'colType
        '
        Me.colType.DataPropertyName = "jnlTranType"
        Me.colType.HeaderText = "TYPE"
        Me.colType.Name = "colType"
        Me.colType.Width = 35
        '
        'colName
        '
        Me.colName.DataPropertyName = "busName"
        Me.colName.FillWeight = 120.0!
        Me.colName.HeaderText = "Entity"
        Me.colName.Name = "colName"
        Me.colName.Width = 130
        '
        'colAmt
        '
        Me.colAmt.DataPropertyName = "jnlTranAmount"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.colAmt.DefaultCellStyle = DataGridViewCellStyle10
        Me.colAmt.HeaderText = "Amount"
        Me.colAmt.Name = "colAmt"
        Me.colAmt.Width = 70
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "jnlTranDAte"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle11
        Me.colDate.HeaderText = "Trans. Date"
        Me.colDate.Name = "colDate"
        Me.colDate.Width = 80
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(99, 370)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'hdnLinker
        '
        Me.hdnLinker.AutoSize = True
        Me.hdnLinker.Location = New System.Drawing.Point(60, 198)
        Me.hdnLinker.Name = "hdnLinker"
        Me.hdnLinker.Size = New System.Drawing.Size(24, 13)
        Me.hdnLinker.TabIndex = 31
        Me.hdnLinker.Text = "    x"
        Me.hdnLinker.Visible = False
        '
        'hdnCounter
        '
        Me.hdnCounter.AutoSize = True
        Me.hdnCounter.Location = New System.Drawing.Point(100, 198)
        Me.hdnCounter.Name = "hdnCounter"
        Me.hdnCounter.Size = New System.Drawing.Size(24, 13)
        Me.hdnCounter.TabIndex = 32
        Me.hdnCounter.Text = "    x"
        Me.hdnCounter.Visible = False
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.actDescription, Me.actName, Me.actNum, Me.acntID})
        Me.dgvAccounts.Location = New System.Drawing.Point(0, 53)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.Size = New System.Drawing.Size(350, 402)
        Me.dgvAccounts.TabIndex = 33
        '
        'actDescription
        '
        Me.actDescription.HeaderText = "Description"
        Me.actDescription.Name = "actDescription"
        Me.actDescription.Width = 300
        '
        'actName
        '
        Me.actName.HeaderText = "actName"
        Me.actName.Name = "actName"
        Me.actName.Visible = False
        '
        'actNum
        '
        Me.actNum.HeaderText = "actNum"
        Me.actNum.Name = "actNum"
        Me.actNum.Visible = False
        '
        'acntID
        '
        Me.acntID.HeaderText = "Column1"
        Me.acntID.Name = "acntID"
        Me.acntID.Visible = False
        '
        'txtAmountToAllocate
        '
        Me.txtAmountToAllocate.Location = New System.Drawing.Point(76, 85)
        Me.txtAmountToAllocate.Name = "txtAmountToAllocate"
        Me.txtAmountToAllocate.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountToAllocate.TabIndex = 1
        '
        'lblInst1
        '
        Me.lblInst1.AutoSize = True
        Me.lblInst1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst1.Location = New System.Drawing.Point(61, 19)
        Me.lblInst1.Name = "lblInst1"
        Me.lblInst1.Size = New System.Drawing.Size(281, 26)
        Me.lblInst1.TabIndex = 36
        Me.lblInst1.Text = "(1) Select Transaction to Divide"
        '
        'lblInst3B
        '
        Me.lblInst3B.AutoSize = True
        Me.lblInst3B.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst3B.Location = New System.Drawing.Point(0, 16)
        Me.lblInst3B.Name = "lblInst3B"
        Me.lblInst3B.Size = New System.Drawing.Size(360, 26)
        Me.lblInst3B.TabIndex = 37
        Me.lblInst3B.Text = "(3B) Manually Select or Change Account"
        Me.lblInst3B.Visible = False
        '
        'lblInst4
        '
        Me.lblInst4.AutoSize = True
        Me.lblInst4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst4.Location = New System.Drawing.Point(429, 44)
        Me.lblInst4.Name = "lblInst4"
        Me.lblInst4.Size = New System.Drawing.Size(193, 26)
        Me.lblInst4.TabIndex = 39
        Me.lblInst4.Text = "(4) Review And Save"
        Me.lblInst4.Visible = False
        '
        'hdnAccount
        '
        Me.hdnAccount.AutoSize = True
        Me.hdnAccount.Location = New System.Drawing.Point(144, 198)
        Me.hdnAccount.Name = "hdnAccount"
        Me.hdnAccount.Size = New System.Drawing.Size(24, 13)
        Me.hdnAccount.TabIndex = 40
        Me.hdnAccount.Text = "    x"
        Me.hdnAccount.Visible = False
        '
        'btnAllocate
        '
        Me.btnAllocate.Location = New System.Drawing.Point(99, 293)
        Me.btnAllocate.Name = "btnAllocate"
        Me.btnAllocate.Size = New System.Drawing.Size(75, 23)
        Me.btnAllocate.TabIndex = 5
        Me.btnAllocate.Text = "Allocate"
        Me.btnAllocate.UseVisualStyleBackColor = True
        '
        'hdnATMOriginalAmount
        '
        Me.hdnATMOriginalAmount.AutoSize = True
        Me.hdnATMOriginalAmount.Location = New System.Drawing.Point(267, 198)
        Me.hdnATMOriginalAmount.Name = "hdnATMOriginalAmount"
        Me.hdnATMOriginalAmount.Size = New System.Drawing.Size(24, 13)
        Me.hdnATMOriginalAmount.TabIndex = 42
        Me.hdnATMOriginalAmount.Text = "    x"
        Me.hdnATMOriginalAmount.Visible = False
        '
        'hdnRowCount
        '
        Me.hdnRowCount.AutoSize = True
        Me.hdnRowCount.Location = New System.Drawing.Point(12, 198)
        Me.hdnRowCount.Name = "hdnRowCount"
        Me.hdnRowCount.Size = New System.Drawing.Size(24, 13)
        Me.hdnRowCount.TabIndex = 43
        Me.hdnRowCount.Text = "    x"
        Me.hdnRowCount.Visible = False
        '
        'hdnATMRemaining
        '
        Me.hdnATMRemaining.AutoSize = True
        Me.hdnATMRemaining.Location = New System.Drawing.Point(228, 225)
        Me.hdnATMRemaining.Name = "hdnATMRemaining"
        Me.hdnATMRemaining.Size = New System.Drawing.Size(24, 13)
        Me.hdnATMRemaining.TabIndex = 44
        Me.hdnATMRemaining.Text = "    x"
        Me.hdnATMRemaining.Visible = False
        '
        'btnStore
        '
        Me.btnStore.Location = New System.Drawing.Point(99, 331)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(75, 23)
        Me.btnStore.TabIndex = 6
        Me.btnStore.Text = "Store"
        Me.btnStore.UseVisualStyleBackColor = True
        '
        'txtNewDesciption
        '
        Me.txtNewDesciption.Location = New System.Drawing.Point(6, 128)
        Me.txtNewDesciption.Name = "txtNewDesciption"
        Me.txtNewDesciption.Size = New System.Drawing.Size(263, 20)
        Me.txtNewDesciption.TabIndex = 2
        Me.txtNewDesciption.Text = "  "
        '
        'txtNewMemo
        '
        Me.txtNewMemo.Location = New System.Drawing.Point(6, 175)
        Me.txtNewMemo.Name = "txtNewMemo"
        Me.txtNewMemo.Size = New System.Drawing.Size(263, 20)
        Me.txtNewMemo.TabIndex = 3
        Me.txtNewMemo.Text = "  "
        '
        'ddlEntity
        '
        Me.ddlEntity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ddlEntity.FormattingEnabled = True
        Me.ddlEntity.Location = New System.Drawing.Point(54, 263)
        Me.ddlEntity.Name = "ddlEntity"
        Me.ddlEntity.Size = New System.Drawing.Size(157, 21)
        Me.ddlEntity.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Memo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Payed Individual or Business"
        '
        'hdnBankTranID
        '
        Me.hdnBankTranID.AutoSize = True
        Me.hdnBankTranID.Location = New System.Drawing.Point(920, 151)
        Me.hdnBankTranID.Name = "hdnBankTranID"
        Me.hdnBankTranID.Size = New System.Drawing.Size(24, 13)
        Me.hdnBankTranID.TabIndex = 53
        Me.hdnBankTranID.Text = "    x"
        Me.hdnBankTranID.Visible = False
        '
        'hdnBankAccount
        '
        Me.hdnBankAccount.AutoSize = True
        Me.hdnBankAccount.Location = New System.Drawing.Point(990, 151)
        Me.hdnBankAccount.Name = "hdnBankAccount"
        Me.hdnBankAccount.Size = New System.Drawing.Size(24, 13)
        Me.hdnBankAccount.TabIndex = 54
        Me.hdnBankAccount.Text = "    x"
        Me.hdnBankAccount.Visible = False
        '
        'grpNewDat
        '
        Me.grpNewDat.Controls.Add(Me.lblInst3A)
        Me.grpNewDat.Controls.Add(Me.Label6)
        Me.grpNewDat.Controls.Add(Me.lblAllocate)
        Me.grpNewDat.Controls.Add(Me.ddlEntity)
        Me.grpNewDat.Controls.Add(Me.lblInst2)
        Me.grpNewDat.Controls.Add(Me.txtAmountToAllocate)
        Me.grpNewDat.Controls.Add(Me.Label3)
        Me.grpNewDat.Controls.Add(Me.Label2)
        Me.grpNewDat.Controls.Add(Me.Label4)
        Me.grpNewDat.Controls.Add(Me.Label1)
        Me.grpNewDat.Controls.Add(Me.btnAllocate)
        Me.grpNewDat.Controls.Add(Me.btnStore)
        Me.grpNewDat.Controls.Add(Me.txtNewMemo)
        Me.grpNewDat.Controls.Add(Me.txtNewDesciption)
        Me.grpNewDat.Controls.Add(Me.btnClear)
        Me.grpNewDat.Enabled = False
        Me.grpNewDat.Location = New System.Drawing.Point(431, 238)
        Me.grpNewDat.Name = "grpNewDat"
        Me.grpNewDat.Size = New System.Drawing.Size(278, 424)
        Me.grpNewDat.TabIndex = 55
        Me.grpNewDat.TabStop = False
        Me.grpNewDat.Text = "Manual Entries"
        '
        'lblInst3A
        '
        Me.lblInst3A.AutoSize = True
        Me.lblInst3A.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst3A.Location = New System.Drawing.Point(8, 212)
        Me.lblInst3A.Name = "lblInst3A"
        Me.lblInst3A.Size = New System.Drawing.Size(244, 26)
        Me.lblInst3A.TabIndex = 55
        Me.lblInst3A.Text = "(3A) Select if Found Below"
        Me.lblInst3A.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Add to Database"
        '
        'lblAllocate
        '
        Me.lblAllocate.AutoSize = True
        Me.lblAllocate.Location = New System.Drawing.Point(180, 298)
        Me.lblAllocate.Name = "lblAllocate"
        Me.lblAllocate.Size = New System.Drawing.Size(75, 13)
        Me.lblAllocate.TabIndex = 53
        Me.lblAllocate.Text = "Add to Display"
        '
        'lblInst2
        '
        Me.lblInst2.AutoSize = True
        Me.lblInst2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst2.Location = New System.Drawing.Point(14, 26)
        Me.lblInst2.Name = "lblInst2"
        Me.lblInst2.Size = New System.Drawing.Size(264, 26)
        Me.lblInst2.TabIndex = 38
        Me.lblInst2.Text = "(2) Enter Amount and Details"
        Me.lblInst2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Amount to Allocate:"
        '
        'grpAccount
        '
        Me.grpAccount.Controls.Add(Me.dgvAccounts)
        Me.grpAccount.Controls.Add(Me.lblInst3B)
        Me.grpAccount.Location = New System.Drawing.Point(765, 198)
        Me.grpAccount.Name = "grpAccount"
        Me.grpAccount.Size = New System.Drawing.Size(352, 470)
        Me.grpAccount.TabIndex = 56
        Me.grpAccount.TabStop = False
        Me.grpAccount.Text = "Account Entry"
        '
        'grpATMTransaction
        '
        Me.grpATMTransaction.Controls.Add(Me.lblInst1)
        Me.grpATMTransaction.Controls.Add(Me.dgvEntries)
        Me.grpATMTransaction.Location = New System.Drawing.Point(9, 198)
        Me.grpATMTransaction.Name = "grpATMTransaction"
        Me.grpATMTransaction.Size = New System.Drawing.Size(388, 453)
        Me.grpATMTransaction.TabIndex = 57
        Me.grpATMTransaction.TabStop = False
        Me.grpATMTransaction.Text = "ATM"
        '
        'hdnEntityID
        '
        Me.hdnEntityID.AutoSize = True
        Me.hdnEntityID.Location = New System.Drawing.Point(809, 151)
        Me.hdnEntityID.Name = "hdnEntityID"
        Me.hdnEntityID.Size = New System.Drawing.Size(24, 13)
        Me.hdnEntityID.TabIndex = 58
        Me.hdnEntityID.Text = "    x"
        Me.hdnEntityID.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(512, 198)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 34)
        Me.btnClose.TabIndex = 59
        Me.btnClose.Text = "Exit Split"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'AllocateEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1181, 746)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.hdnEntityID)
        Me.Controls.Add(Me.grpATMTransaction)
        Me.Controls.Add(Me.grpAccount)
        Me.Controls.Add(Me.grpNewDat)
        Me.Controls.Add(Me.hdnBankAccount)
        Me.Controls.Add(Me.hdnBankTranID)
        Me.Controls.Add(Me.hdnATMRemaining)
        Me.Controls.Add(Me.hdnRowCount)
        Me.Controls.Add(Me.hdnATMOriginalAmount)
        Me.Controls.Add(Me.hdnAccount)
        Me.Controls.Add(Me.lblInst4)
        Me.Controls.Add(Me.hdnCounter)
        Me.Controls.Add(Me.hdnLinker)
        Me.Controls.Add(Me.dgvLOA)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "AllocateEntry"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.dgvLOA, 0)
        Me.Controls.SetChildIndex(Me.hdnLinker, 0)
        Me.Controls.SetChildIndex(Me.hdnCounter, 0)
        Me.Controls.SetChildIndex(Me.lblInst4, 0)
        Me.Controls.SetChildIndex(Me.hdnAccount, 0)
        Me.Controls.SetChildIndex(Me.hdnATMOriginalAmount, 0)
        Me.Controls.SetChildIndex(Me.hdnRowCount, 0)
        Me.Controls.SetChildIndex(Me.hdnATMRemaining, 0)
        Me.Controls.SetChildIndex(Me.hdnBankTranID, 0)
        Me.Controls.SetChildIndex(Me.hdnBankAccount, 0)
        Me.Controls.SetChildIndex(Me.grpNewDat, 0)
        Me.Controls.SetChildIndex(Me.grpAccount, 0)
        Me.Controls.SetChildIndex(Me.grpATMTransaction, 0)
        Me.Controls.SetChildIndex(Me.hdnEntityID, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        CType(Me.dgvLOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEntries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNewDat.ResumeLayout(False)
        Me.grpNewDat.PerformLayout()
        Me.grpAccount.ResumeLayout(False)
        Me.grpAccount.PerformLayout()
        Me.grpATMTransaction.ResumeLayout(False)
        Me.grpATMTransaction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEntries As System.Windows.Forms.DataGridView
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvLOA As System.Windows.Forms.DataGridView
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents hdnLinker As System.Windows.Forms.Label
    Friend WithEvents hdnCounter As System.Windows.Forms.Label
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents actDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acntID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtAmountToAllocate As System.Windows.Forms.TextBox
    Friend WithEvents lblInst1 As System.Windows.Forms.Label
    Friend WithEvents lblInst3B As System.Windows.Forms.Label
    Friend WithEvents lblInst4 As System.Windows.Forms.Label
    Friend WithEvents hdnAccount As System.Windows.Forms.Label
    Friend WithEvents btnAllocate As System.Windows.Forms.Button
    Friend WithEvents hdnATMOriginalAmount As System.Windows.Forms.Label
    Friend WithEvents hdnRowCount As System.Windows.Forms.Label
    Friend WithEvents hdnATMRemaining As System.Windows.Forms.Label
    Friend WithEvents btnStore As System.Windows.Forms.Button
    Friend WithEvents txtNewDesciption As System.Windows.Forms.TextBox
    Friend WithEvents txtNewMemo As System.Windows.Forms.TextBox
    Friend WithEvents ddlEntity As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents hdnBankTranID As System.Windows.Forms.Label
    Friend WithEvents hdnBankAccount As System.Windows.Forms.Label
    Friend WithEvents grpNewDat As System.Windows.Forms.GroupBox
    Friend WithEvents lblInst2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpAccount As System.Windows.Forms.GroupBox
    Friend WithEvents grpATMTransaction As System.Windows.Forms.GroupBox
    Friend WithEvents hdnEntityID As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAllocate As System.Windows.Forms.Label
    Friend WithEvents colAlID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyLinker As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyMemo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyEntity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyEntryID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMyBankAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEntID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblInst3A As System.Windows.Forms.Label

End Class
