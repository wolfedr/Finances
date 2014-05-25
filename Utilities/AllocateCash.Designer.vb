<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllocateCash
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ddlBusiness = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTranType = New System.Windows.Forms.Label
        Me.txtAmtToAllocate = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblAmtAllocate = New System.Windows.Forms.Label
        Me.hdnActID = New System.Windows.Forms.Label
        Me.txtAccountname = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTranDesc = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAccountNum = New System.Windows.Forms.TextBox
        Me.grpBase = New System.Windows.Forms.GroupBox
        Me.hdnBankAct = New System.Windows.Forms.Label
        Me.hdnBnkTranID = New System.Windows.Forms.Label
        Me.lblTranDate = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAllocate = New System.Windows.Forms.Button
        Me.hdnATMID = New System.Windows.Forms.Label
        Me.txtSplitAmount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvTransactions = New System.Windows.Forms.DataGridView
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpDisplay = New System.Windows.Forms.GroupBox
        Me.rbIncome = New System.Windows.Forms.RadioButton
        Me.rbExpense = New System.Windows.Forms.RadioButton
        Me.dgvAccounts = New System.Windows.Forms.DataGridView
        Me.actDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acntID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpbType = New System.Windows.Forms.GroupBox
        Me.rbOther = New System.Windows.Forms.RadioButton
        Me.rbATM = New System.Windows.Forms.RadioButton
        Me.lblCaption = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblAmt3 = New System.Windows.Forms.Label
        Me.lblAmt2 = New System.Windows.Forms.Label
        Me.lblAmt1 = New System.Windows.Forms.Label
        Me.lblAmtOrig = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.dgvLOA = New System.Windows.Forms.DataGridView
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lnk2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actnum3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.date5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Type7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.amt8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.desc9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.memo10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.busid11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.banktranID12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bankAct13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtType = New System.Windows.Forms.TextBox
        Me.txtNewDate = New System.Windows.Forms.TextBox
        Me.txtLinker = New System.Windows.Forms.TextBox
        Me.hdnEntryCount = New System.Windows.Forms.Label
        Me.txtNewDescription = New System.Windows.Forms.TextBox
        Me.txtNewMemo = New System.Windows.Forms.TextBox
        Me.txtNewEntit = New System.Windows.Forms.TextBox
        Me.txtBankTranID = New System.Windows.Forms.TextBox
        Me.txtBankAcct = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.grpBase.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDisplay.SuspendLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbType.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvLOA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ddlBusiness)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblTranType)
        Me.GroupBox1.Controls.Add(Me.txtAmtToAllocate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblAmtAllocate)
        Me.GroupBox1.Controls.Add(Me.hdnActID)
        Me.GroupBox1.Controls.Add(Me.txtAccountname)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTranDesc)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(322, 492)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 194)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Allocate Amount Details"
        '
        'ddlBusiness
        '
        Me.ddlBusiness.FormattingEnabled = True
        Me.ddlBusiness.Location = New System.Drawing.Point(157, 152)
        Me.ddlBusiness.Name = "ddlBusiness"
        Me.ddlBusiness.Size = New System.Drawing.Size(168, 21)
        Me.ddlBusiness.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(321, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "NOTE: If account is not here, you must create it with Add Business"
        '
        'lblTranType
        '
        Me.lblTranType.AutoSize = True
        Me.lblTranType.Location = New System.Drawing.Point(154, 16)
        Me.lblTranType.Name = "lblTranType"
        Me.lblTranType.Size = New System.Drawing.Size(36, 13)
        Me.lblTranType.TabIndex = 52
        Me.lblTranType.Text = " None"
        Me.lblTranType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmtToAllocate
        '
        Me.txtAmtToAllocate.Location = New System.Drawing.Point(157, 33)
        Me.txtAmtToAllocate.Name = "txtAmtToAllocate"
        Me.txtAmtToAllocate.Size = New System.Drawing.Size(51, 20)
        Me.txtAmtToAllocate.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Transaction Type"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAmtAllocate
        '
        Me.lblAmtAllocate.AutoSize = True
        Me.lblAmtAllocate.Location = New System.Drawing.Point(12, 36)
        Me.lblAmtAllocate.Name = "lblAmtAllocate"
        Me.lblAmtAllocate.Size = New System.Drawing.Size(96, 13)
        Me.lblAmtAllocate.TabIndex = 53
        Me.lblAmtAllocate.Text = "Amount to Allocate"
        Me.lblAmtAllocate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'hdnActID
        '
        Me.hdnActID.AutoSize = True
        Me.hdnActID.Location = New System.Drawing.Point(276, 106)
        Me.hdnActID.Name = "hdnActID"
        Me.hdnActID.Size = New System.Drawing.Size(13, 13)
        Me.hdnActID.TabIndex = 41
        Me.hdnActID.Text = "0"
        '
        'txtAccountname
        '
        Me.txtAccountname.Location = New System.Drawing.Point(157, 121)
        Me.txtAccountname.Name = "txtAccountname"
        Me.txtAccountname.Size = New System.Drawing.Size(211, 20)
        Me.txtAccountname.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Allocate Too Account Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Business:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTranDesc
        '
        Me.txtTranDesc.Location = New System.Drawing.Point(157, 64)
        Me.txtTranDesc.Name = "txtTranDesc"
        Me.txtTranDesc.Size = New System.Drawing.Size(211, 20)
        Me.txtTranDesc.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Allocate too Account Number"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Description of Transaction"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAccountNum
        '
        Me.txtAccountNum.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNum.Location = New System.Drawing.Point(150, 151)
        Me.txtAccountNum.Name = "txtAccountNum"
        Me.txtAccountNum.Size = New System.Drawing.Size(61, 22)
        Me.txtAccountNum.TabIndex = 38
        '
        'grpBase
        '
        Me.grpBase.Controls.Add(Me.hdnBankAct)
        Me.grpBase.Controls.Add(Me.hdnBnkTranID)
        Me.grpBase.Controls.Add(Me.lblTranDate)
        Me.grpBase.Controls.Add(Me.Label4)
        Me.grpBase.Location = New System.Drawing.Point(322, 400)
        Me.grpBase.Name = "grpBase"
        Me.grpBase.Size = New System.Drawing.Size(387, 86)
        Me.grpBase.TabIndex = 62
        Me.grpBase.TabStop = False
        Me.grpBase.Text = "Split Amount Details"
        '
        'hdnBankAct
        '
        Me.hdnBankAct.AutoSize = True
        Me.hdnBankAct.Location = New System.Drawing.Point(134, 70)
        Me.hdnBankAct.Name = "hdnBankAct"
        Me.hdnBankAct.Size = New System.Drawing.Size(13, 13)
        Me.hdnBankAct.TabIndex = 68
        Me.hdnBankAct.Text = "0"
        '
        'hdnBnkTranID
        '
        Me.hdnBnkTranID.AutoSize = True
        Me.hdnBnkTranID.Location = New System.Drawing.Point(72, 70)
        Me.hdnBnkTranID.Name = "hdnBnkTranID"
        Me.hdnBnkTranID.Size = New System.Drawing.Size(13, 13)
        Me.hdnBnkTranID.TabIndex = 67
        Me.hdnBnkTranID.Text = "0"
        '
        'lblTranDate
        '
        Me.lblTranDate.AutoSize = True
        Me.lblTranDate.Location = New System.Drawing.Point(154, 49)
        Me.lblTranDate.Name = "lblTranDate"
        Me.lblTranDate.Size = New System.Drawing.Size(36, 13)
        Me.lblTranDate.TabIndex = 50
        Me.lblTranDate.Text = " None"
        Me.lblTranDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Transaction Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAllocate
        '
        Me.btnAllocate.Location = New System.Drawing.Point(15, 151)
        Me.btnAllocate.Name = "btnAllocate"
        Me.btnAllocate.Size = New System.Drawing.Size(75, 23)
        Me.btnAllocate.TabIndex = 66
        Me.btnAllocate.Text = "Allocate"
        Me.btnAllocate.UseVisualStyleBackColor = True
        '
        'hdnATMID
        '
        Me.hdnATMID.AutoSize = True
        Me.hdnATMID.Location = New System.Drawing.Point(90, 184)
        Me.hdnATMID.Name = "hdnATMID"
        Me.hdnATMID.Size = New System.Drawing.Size(13, 13)
        Me.hdnATMID.TabIndex = 51
        Me.hdnATMID.Text = "0"
        '
        'txtSplitAmount
        '
        Me.txtSplitAmount.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSplitAmount.Location = New System.Drawing.Point(359, 151)
        Me.txtSplitAmount.Name = "txtSplitAmount"
        Me.txtSplitAmount.Size = New System.Drawing.Size(84, 22)
        Me.txtSplitAmount.TabIndex = 44
        Me.txtSplitAmount.Text = "0"
        Me.txtSplitAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(456, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "ATM Amount to Split"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransactions.ColumnHeadersHeight = 24
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3, Me.Col4, Me.Col5, Me.Col6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransactions.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTransactions.Location = New System.Drawing.Point(26, 200)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.Size = New System.Drawing.Size(274, 441)
        Me.dgvTransactions.TabIndex = 61
        '
        'Col1
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Col1.HeaderText = "ID"
        Me.Col1.MinimumWidth = 10
        Me.Col1.Name = "Col1"
        Me.Col1.ReadOnly = True
        Me.Col1.Width = 40
        '
        'Col2
        '
        Me.Col2.HeaderText = "Type"
        Me.Col2.Name = "Col2"
        Me.Col2.ReadOnly = True
        Me.Col2.Width = 40
        '
        'Col3
        '
        Me.Col3.HeaderText = "Date"
        Me.Col3.Name = "Col3"
        Me.Col3.ReadOnly = True
        Me.Col3.Width = 80
        '
        'Col4
        '
        Me.Col4.HeaderText = "Amount"
        Me.Col4.Name = "Col4"
        Me.Col4.ReadOnly = True
        Me.Col4.Width = 70
        '
        'Col5
        '
        Me.Col5.HeaderText = "bnk TranID"
        Me.Col5.Name = "Col5"
        Me.Col5.ReadOnly = True
        Me.Col5.Visible = False
        '
        'Col6
        '
        Me.Col6.HeaderText = "bnkAccount"
        Me.Col6.Name = "Col6"
        Me.Col6.ReadOnly = True
        Me.Col6.Visible = False
        '
        'grpDisplay
        '
        Me.grpDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpDisplay.Controls.Add(Me.rbIncome)
        Me.grpDisplay.Controls.Add(Me.rbExpense)
        Me.grpDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpDisplay.Location = New System.Drawing.Point(733, 608)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(345, 33)
        Me.grpDisplay.TabIndex = 60
        Me.grpDisplay.TabStop = False
        '
        'rbIncome
        '
        Me.rbIncome.AutoSize = True
        Me.rbIncome.Location = New System.Drawing.Point(44, 10)
        Me.rbIncome.Name = "rbIncome"
        Me.rbIncome.Size = New System.Drawing.Size(60, 17)
        Me.rbIncome.TabIndex = 33
        Me.rbIncome.TabStop = True
        Me.rbIncome.Text = "Income"
        Me.rbIncome.UseVisualStyleBackColor = True
        '
        'rbExpense
        '
        Me.rbExpense.AutoSize = True
        Me.rbExpense.Location = New System.Drawing.Point(215, 10)
        Me.rbExpense.Name = "rbExpense"
        Me.rbExpense.Size = New System.Drawing.Size(66, 17)
        Me.rbExpense.TabIndex = 32
        Me.rbExpense.TabStop = True
        Me.rbExpense.Text = "Expense"
        Me.rbExpense.UseVisualStyleBackColor = True
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.actDescription, Me.actName, Me.actNum, Me.acntID})
        Me.dgvAccounts.Location = New System.Drawing.Point(733, 203)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.Size = New System.Drawing.Size(345, 409)
        Me.dgvAccounts.TabIndex = 59
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
        'gpbType
        '
        Me.gpbType.Controls.Add(Me.rbOther)
        Me.gpbType.Controls.Add(Me.rbATM)
        Me.gpbType.Location = New System.Drawing.Point(313, 249)
        Me.gpbType.Name = "gpbType"
        Me.gpbType.Size = New System.Drawing.Size(98, 76)
        Me.gpbType.TabIndex = 58
        Me.gpbType.TabStop = False
        Me.gpbType.Text = "Account Type"
        '
        'rbOther
        '
        Me.rbOther.AutoSize = True
        Me.rbOther.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOther.Location = New System.Drawing.Point(22, 45)
        Me.rbOther.Name = "rbOther"
        Me.rbOther.Size = New System.Drawing.Size(61, 19)
        Me.rbOther.TabIndex = 1
        Me.rbOther.TabStop = True
        Me.rbOther.Text = "OTHER"
        Me.rbOther.UseVisualStyleBackColor = True
        '
        'rbATM
        '
        Me.rbATM.AutoSize = True
        Me.rbATM.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbATM.Location = New System.Drawing.Point(22, 20)
        Me.rbATM.Name = "rbATM"
        Me.rbATM.Size = New System.Drawing.Size(48, 19)
        Me.rbATM.TabIndex = 0
        Me.rbATM.TabStop = True
        Me.rbATM.Text = "ATM"
        Me.rbATM.UseVisualStyleBackColor = True
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(373, 222)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(235, 23)
        Me.lblCaption.TabIndex = 57
        Me.lblCaption.Text = "Allocate Existing Transaction"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAmt3)
        Me.GroupBox2.Controls.Add(Me.lblAmt2)
        Me.GroupBox2.Controls.Add(Me.lblAmt1)
        Me.GroupBox2.Controls.Add(Me.lblAmtOrig)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(437, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 146)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Final Allocation"
        '
        'lblAmt3
        '
        Me.lblAmt3.AutoSize = True
        Me.lblAmt3.Location = New System.Drawing.Point(69, 86)
        Me.lblAmt3.Name = "lblAmt3"
        Me.lblAmt3.Size = New System.Drawing.Size(13, 13)
        Me.lblAmt3.TabIndex = 7
        Me.lblAmt3.Text = "0"
        '
        'lblAmt2
        '
        Me.lblAmt2.AutoSize = True
        Me.lblAmt2.Location = New System.Drawing.Point(69, 64)
        Me.lblAmt2.Name = "lblAmt2"
        Me.lblAmt2.Size = New System.Drawing.Size(13, 13)
        Me.lblAmt2.TabIndex = 6
        Me.lblAmt2.Text = "0"
        '
        'lblAmt1
        '
        Me.lblAmt1.AutoSize = True
        Me.lblAmt1.Location = New System.Drawing.Point(69, 42)
        Me.lblAmt1.Name = "lblAmt1"
        Me.lblAmt1.Size = New System.Drawing.Size(13, 13)
        Me.lblAmt1.TabIndex = 5
        Me.lblAmt1.Text = "0"
        '
        'lblAmtOrig
        '
        Me.lblAmtOrig.AutoSize = True
        Me.lblAmtOrig.Location = New System.Drawing.Point(69, 20)
        Me.lblAmtOrig.Name = "lblAmtOrig"
        Me.lblAmtOrig.Size = New System.Drawing.Size(13, 13)
        Me.lblAmtOrig.TabIndex = 4
        Me.lblAmtOrig.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Split 3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Split 2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Split 1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Original"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(324, 352)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 65
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dgvLOA
        '
        Me.dgvLOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLOA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.lnk2, Me.actnum3, Me.date5, Me.Type7, Me.amt8, Me.desc9, Me.memo10, Me.busid11, Me.banktranID12, Me.bankAct13})
        Me.dgvLOA.Location = New System.Drawing.Point(15, 47)
        Me.dgvLOA.Name = "dgvLOA"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvLOA.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvLOA.Size = New System.Drawing.Size(1076, 103)
        Me.dgvLOA.TabIndex = 66
        '
        'id
        '
        Me.id.DataPropertyName = "jnlID"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Width = 43
        '
        'lnk2
        '
        Me.lnk2.DataPropertyName = "jnlLink"
        Me.lnk2.HeaderText = "Linker"
        Me.lnk2.Name = "lnk2"
        Me.lnk2.Width = 50
        '
        'actnum3
        '
        Me.actnum3.DataPropertyName = "Account"
        Me.actnum3.HeaderText = "Account"
        Me.actnum3.Name = "actnum3"
        Me.actnum3.Width = 60
        '
        'date5
        '
        Me.date5.DataPropertyName = "jnlTranDate"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.date5.DefaultCellStyle = DataGridViewCellStyle4
        Me.date5.HeaderText = "Date"
        Me.date5.Name = "date5"
        Me.date5.Width = 85
        '
        'Type7
        '
        Me.Type7.DataPropertyName = "jnlTranType"
        Me.Type7.HeaderText = "Type"
        Me.Type7.Name = "Type7"
        Me.Type7.Width = 65
        '
        'amt8
        '
        Me.amt8.DataPropertyName = "jnlTranAmount"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.amt8.DefaultCellStyle = DataGridViewCellStyle5
        Me.amt8.HeaderText = "Amount"
        Me.amt8.Name = "amt8"
        Me.amt8.Width = 80
        '
        'desc9
        '
        Me.desc9.DataPropertyName = "jnlTranDesc"
        Me.desc9.HeaderText = "Description"
        Me.desc9.Name = "desc9"
        Me.desc9.Width = 150
        '
        'memo10
        '
        Me.memo10.DataPropertyName = "jnlTranMemo"
        Me.memo10.HeaderText = "Memo"
        Me.memo10.Name = "memo10"
        Me.memo10.Width = 200
        '
        'busid11
        '
        Me.busid11.DataPropertyName = "busName"
        Me.busid11.HeaderText = "Entity"
        Me.busid11.Name = "busid11"
        Me.busid11.Width = 150
        '
        'banktranID12
        '
        Me.banktranID12.DataPropertyName = "jnlBankTranID"
        Me.banktranID12.HeaderText = "X ID"
        Me.banktranID12.Name = "banktranID12"
        Me.banktranID12.Width = 70
        '
        'bankAct13
        '
        Me.bankAct13.DataPropertyName = "jnlBankAct"
        Me.bankAct13.HeaderText = "Bnk Act."
        Me.bankAct13.Name = "bankAct13"
        Me.bankAct13.Width = 70
        '
        'txtType
        '
        Me.txtType.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(296, 151)
        Me.txtType.Margin = New System.Windows.Forms.Padding(1)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(63, 22)
        Me.txtType.TabIndex = 67
        Me.txtType.Text = "Cash"
        Me.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNewDate
        '
        Me.txtNewDate.AcceptsTab = True
        Me.txtNewDate.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewDate.Location = New System.Drawing.Point(211, 151)
        Me.txtNewDate.Name = "txtNewDate"
        Me.txtNewDate.Size = New System.Drawing.Size(85, 22)
        Me.txtNewDate.TabIndex = 68
        '
        'txtLinker
        '
        Me.txtLinker.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLinker.Location = New System.Drawing.Point(93, 151)
        Me.txtLinker.Name = "txtLinker"
        Me.txtLinker.Size = New System.Drawing.Size(57, 22)
        Me.txtLinker.TabIndex = 69
        '
        'hdnEntryCount
        '
        Me.hdnEntryCount.AutoSize = True
        Me.hdnEntryCount.Location = New System.Drawing.Point(122, 184)
        Me.hdnEntryCount.Name = "hdnEntryCount"
        Me.hdnEntryCount.Size = New System.Drawing.Size(13, 13)
        Me.hdnEntryCount.TabIndex = 69
        Me.hdnEntryCount.Text = "0"
        '
        'txtNewDescription
        '
        Me.txtNewDescription.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewDescription.Location = New System.Drawing.Point(443, 151)
        Me.txtNewDescription.Name = "txtNewDescription"
        Me.txtNewDescription.Size = New System.Drawing.Size(148, 22)
        Me.txtNewDescription.TabIndex = 70
        '
        'txtNewMemo
        '
        Me.txtNewMemo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewMemo.Location = New System.Drawing.Point(591, 151)
        Me.txtNewMemo.Name = "txtNewMemo"
        Me.txtNewMemo.Size = New System.Drawing.Size(200, 22)
        Me.txtNewMemo.TabIndex = 71
        '
        'txtNewEntit
        '
        Me.txtNewEntit.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewEntit.Location = New System.Drawing.Point(791, 151)
        Me.txtNewEntit.Name = "txtNewEntit"
        Me.txtNewEntit.Size = New System.Drawing.Size(148, 22)
        Me.txtNewEntit.TabIndex = 71
        '
        'txtBankTranID
        '
        Me.txtBankTranID.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankTranID.Location = New System.Drawing.Point(939, 151)
        Me.txtBankTranID.Name = "txtBankTranID"
        Me.txtBankTranID.Size = New System.Drawing.Size(75, 22)
        Me.txtBankTranID.TabIndex = 72
        '
        'txtBankAcct
        '
        Me.txtBankAcct.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankAcct.Location = New System.Drawing.Point(1014, 151)
        Me.txtBankAcct.Name = "txtBankAcct"
        Me.txtBankAcct.Size = New System.Drawing.Size(75, 22)
        Me.txtBankAcct.TabIndex = 71
        '
        'AllocateCash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1118, 698)
        Me.Controls.Add(Me.txtBankTranID)
        Me.Controls.Add(Me.txtNewEntit)
        Me.Controls.Add(Me.btnAllocate)
        Me.Controls.Add(Me.txtNewMemo)
        Me.Controls.Add(Me.txtNewDescription)
        Me.Controls.Add(Me.hdnEntryCount)
        Me.Controls.Add(Me.txtLinker)
        Me.Controls.Add(Me.txtBankAcct)
        Me.Controls.Add(Me.txtNewDate)
        Me.Controls.Add(Me.hdnATMID)
        Me.Controls.Add(Me.dgvLOA)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpBase)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.txtAccountNum)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.txtSplitAmount)
        Me.Controls.Add(Me.gpbType)
        Me.Controls.Add(Me.lblCaption)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "AllocateCash"
        Me.Controls.SetChildIndex(Me.lblCaption, 0)
        Me.Controls.SetChildIndex(Me.gpbType, 0)
        Me.Controls.SetChildIndex(Me.txtSplitAmount, 0)
        Me.Controls.SetChildIndex(Me.dgvAccounts, 0)
        Me.Controls.SetChildIndex(Me.txtAccountNum, 0)
        Me.Controls.SetChildIndex(Me.grpDisplay, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.dgvTransactions, 0)
        Me.Controls.SetChildIndex(Me.grpBase, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.txtType, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        Me.Controls.SetChildIndex(Me.dgvLOA, 0)
        Me.Controls.SetChildIndex(Me.hdnATMID, 0)
        Me.Controls.SetChildIndex(Me.txtNewDate, 0)
        Me.Controls.SetChildIndex(Me.txtBankAcct, 0)
        Me.Controls.SetChildIndex(Me.txtLinker, 0)
        Me.Controls.SetChildIndex(Me.hdnEntryCount, 0)
        Me.Controls.SetChildIndex(Me.txtNewDescription, 0)
        Me.Controls.SetChildIndex(Me.txtNewMemo, 0)
        Me.Controls.SetChildIndex(Me.btnAllocate, 0)
        Me.Controls.SetChildIndex(Me.txtNewEntit, 0)
        Me.Controls.SetChildIndex(Me.txtBankTranID, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpBase.ResumeLayout(False)
        Me.grpBase.PerformLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbType.ResumeLayout(False)
        Me.gpbType.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvLOA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTranType As System.Windows.Forms.Label
    Friend WithEvents txtAmtToAllocate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAmtAllocate As System.Windows.Forms.Label
    Friend WithEvents hdnActID As System.Windows.Forms.Label
    Friend WithEvents txtAccountname As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAccountNum As System.Windows.Forms.TextBox
    Friend WithEvents txtTranDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpBase As System.Windows.Forms.GroupBox
    Friend WithEvents hdnATMID As System.Windows.Forms.Label
    Friend WithEvents lblTranDate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSplitAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents grpDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents rbIncome As System.Windows.Forms.RadioButton
    Friend WithEvents rbExpense As System.Windows.Forms.RadioButton
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents actDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acntID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpbType As System.Windows.Forms.GroupBox
    Friend WithEvents rbOther As System.Windows.Forms.RadioButton
    Friend WithEvents rbATM As System.Windows.Forms.RadioButton
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents ddlBusiness As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAmt1 As System.Windows.Forms.Label
    Friend WithEvents lblAmtOrig As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAmt3 As System.Windows.Forms.Label
    Friend WithEvents lblAmt2 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAllocate As System.Windows.Forms.Button
    Friend WithEvents hdnBankAct As System.Windows.Forms.Label
    Friend WithEvents hdnBnkTranID As System.Windows.Forms.Label
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvLOA As System.Windows.Forms.DataGridView
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtNewDate As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lnk2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actnum3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amt8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents memo10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents busid11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents banktranID12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bankAct13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtLinker As System.Windows.Forms.TextBox
    Friend WithEvents hdnEntryCount As System.Windows.Forms.Label
    Friend WithEvents txtNewDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtNewMemo As System.Windows.Forms.TextBox
    Friend WithEvents txtNewEntit As System.Windows.Forms.TextBox
    Friend WithEvents txtBankTranID As System.Windows.Forms.TextBox
    Friend WithEvents txtBankAcct As System.Windows.Forms.TextBox

End Class
