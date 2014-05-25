<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterJournalTransaction
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
        Me.txtActnum = New System.Windows.Forms.TextBox
        Me.lblActNum = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.grpDisplay = New System.Windows.Forms.GroupBox
        Me.rbAsset = New System.Windows.Forms.RadioButton
        Me.rbLiability = New System.Windows.Forms.RadioButton
        Me.rbRevenue = New System.Windows.Forms.RadioButton
        Me.rbExpense = New System.Windows.Forms.RadioButton
        Me.dgvAccounts = New System.Windows.Forms.DataGridView
        Me.actDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acntID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblActName = New System.Windows.Forms.Label
        Me.txtActSeq = New System.Windows.Forms.TextBox
        Me.lblTranDate = New System.Windows.Forms.Label
        Me.lblTranType = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lblMemo = New System.Windows.Forms.Label
        Me.txtMemo = New System.Windows.Forms.TextBox
        Me.lblBusiness = New System.Windows.Forms.Label
        Me.cmbBusiness = New System.Windows.Forms.ComboBox
        Me.dteJnlTranDate = New System.Windows.Forms.DateTimePicker
        Me.cmbBankAct = New System.Windows.Forms.ComboBox
        Me.lblBankAct = New System.Windows.Forms.Label
        Me.txtActName = New System.Windows.Forms.TextBox
        Me.cmbTranType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbActivity = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.pnlEdit = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbTransaction = New System.Windows.Forms.ComboBox
        Me.btnEdit = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblJnlID = New System.Windows.Forms.Label
        Me.btnDistribute = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.chkHaveReceipt = New System.Windows.Forms.CheckBox
        Me.chkRepeat = New System.Windows.Forms.CheckBox
        Me.grpDisplay.SuspendLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtActnum
        '
        Me.txtActnum.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActnum.Location = New System.Drawing.Point(220, 290)
        Me.txtActnum.Name = "txtActnum"
        Me.txtActnum.ReadOnly = True
        Me.txtActnum.Size = New System.Drawing.Size(33, 22)
        Me.txtActnum.TabIndex = 27
        '
        'lblActNum
        '
        Me.lblActNum.AutoSize = True
        Me.lblActNum.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActNum.Location = New System.Drawing.Point(152, 289)
        Me.lblActNum.Name = "lblActNum"
        Me.lblActNum.Size = New System.Drawing.Size(51, 14)
        Me.lblActNum.TabIndex = 28
        Me.lblActNum.Text = "Act Num"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(282, 609)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grpDisplay
        '
        Me.grpDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpDisplay.Controls.Add(Me.rbAsset)
        Me.grpDisplay.Controls.Add(Me.rbLiability)
        Me.grpDisplay.Controls.Add(Me.rbRevenue)
        Me.grpDisplay.Controls.Add(Me.rbExpense)
        Me.grpDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpDisplay.Location = New System.Drawing.Point(691, 559)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(317, 33)
        Me.grpDisplay.TabIndex = 36
        Me.grpDisplay.TabStop = False
        '
        'rbAsset
        '
        Me.rbAsset.AutoSize = True
        Me.rbAsset.Location = New System.Drawing.Point(153, 8)
        Me.rbAsset.Name = "rbAsset"
        Me.rbAsset.Size = New System.Drawing.Size(51, 17)
        Me.rbAsset.TabIndex = 35
        Me.rbAsset.TabStop = True
        Me.rbAsset.Text = "Asset"
        Me.rbAsset.UseVisualStyleBackColor = True
        '
        'rbLiability
        '
        Me.rbLiability.AutoSize = True
        Me.rbLiability.Location = New System.Drawing.Point(226, 9)
        Me.rbLiability.Name = "rbLiability"
        Me.rbLiability.Size = New System.Drawing.Size(59, 17)
        Me.rbLiability.TabIndex = 34
        Me.rbLiability.TabStop = True
        Me.rbLiability.Text = "Liability"
        Me.rbLiability.UseVisualStyleBackColor = True
        '
        'rbRevenue
        '
        Me.rbRevenue.AutoSize = True
        Me.rbRevenue.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRevenue.Location = New System.Drawing.Point(6, 9)
        Me.rbRevenue.Name = "rbRevenue"
        Me.rbRevenue.Size = New System.Drawing.Size(72, 18)
        Me.rbRevenue.TabIndex = 33
        Me.rbRevenue.Text = "Revenue"
        Me.rbRevenue.UseVisualStyleBackColor = True
        '
        'rbExpense
        '
        Me.rbExpense.AutoSize = True
        Me.rbExpense.Checked = True
        Me.rbExpense.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExpense.Location = New System.Drawing.Point(77, 8)
        Me.rbExpense.Name = "rbExpense"
        Me.rbExpense.Size = New System.Drawing.Size(70, 18)
        Me.rbExpense.TabIndex = 32
        Me.rbExpense.TabStop = True
        Me.rbExpense.Text = "Expense"
        Me.rbExpense.UseVisualStyleBackColor = True
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.AllowUserToResizeColumns = False
        Me.dgvAccounts.AllowUserToResizeRows = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.actDescription, Me.actName, Me.actNum, Me.acntID})
        Me.dgvAccounts.Location = New System.Drawing.Point(691, 104)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.RowHeadersVisible = False
        Me.dgvAccounts.Size = New System.Drawing.Size(317, 459)
        Me.dgvAccounts.TabIndex = 35
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
        'lblActName
        '
        Me.lblActName.AutoSize = True
        Me.lblActName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActName.Location = New System.Drawing.Point(119, 319)
        Me.lblActName.Name = "lblActName"
        Me.lblActName.Size = New System.Drawing.Size(84, 14)
        Me.lblActName.TabIndex = 38
        Me.lblActName.Text = "Account Name"
        '
        'txtActSeq
        '
        Me.txtActSeq.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActSeq.Location = New System.Drawing.Point(259, 289)
        Me.txtActSeq.Name = "txtActSeq"
        Me.txtActSeq.ReadOnly = True
        Me.txtActSeq.Size = New System.Drawing.Size(23, 22)
        Me.txtActSeq.TabIndex = 37
        '
        'lblTranDate
        '
        Me.lblTranDate.AutoSize = True
        Me.lblTranDate.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranDate.Location = New System.Drawing.Point(100, 347)
        Me.lblTranDate.Name = "lblTranDate"
        Me.lblTranDate.Size = New System.Drawing.Size(98, 14)
        Me.lblTranDate.TabIndex = 40
        Me.lblTranDate.Text = "Transaction Date"
        '
        'lblTranType
        '
        Me.lblTranType.AutoSize = True
        Me.lblTranType.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranType.Location = New System.Drawing.Point(102, 377)
        Me.lblTranType.Name = "lblTranType"
        Me.lblTranType.Size = New System.Drawing.Size(96, 14)
        Me.lblTranType.TabIndex = 42
        Me.lblTranType.Text = "Transaction Type"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(149, 408)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(49, 14)
        Me.lblAmount.TabIndex = 44
        Me.lblAmount.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(220, 402)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(118, 22)
        Me.txtAmount.TabIndex = 43
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(129, 476)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(69, 14)
        Me.lblDescription.TabIndex = 46
        Me.lblDescription.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(220, 458)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(328, 45)
        Me.txtDescription.TabIndex = 45
        '
        'lblMemo
        '
        Me.lblMemo.AutoSize = True
        Me.lblMemo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemo.Location = New System.Drawing.Point(157, 530)
        Me.lblMemo.Name = "lblMemo"
        Me.lblMemo.Size = New System.Drawing.Size(41, 14)
        Me.lblMemo.TabIndex = 48
        Me.lblMemo.Text = "Memo"
        '
        'txtMemo
        '
        Me.txtMemo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemo.Location = New System.Drawing.Point(220, 509)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(328, 49)
        Me.txtMemo.TabIndex = 47
        '
        'lblBusiness
        '
        Me.lblBusiness.AutoSize = True
        Me.lblBusiness.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusiness.Location = New System.Drawing.Point(146, 233)
        Me.lblBusiness.Name = "lblBusiness"
        Me.lblBusiness.Size = New System.Drawing.Size(57, 14)
        Me.lblBusiness.TabIndex = 50
        Me.lblBusiness.Text = "Business"
        '
        'cmbBusiness
        '
        Me.cmbBusiness.DropDownHeight = 300
        Me.cmbBusiness.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBusiness.FormattingEnabled = True
        Me.cmbBusiness.IntegralHeight = False
        Me.cmbBusiness.Location = New System.Drawing.Point(220, 232)
        Me.cmbBusiness.Name = "cmbBusiness"
        Me.cmbBusiness.Size = New System.Drawing.Size(203, 22)
        Me.cmbBusiness.TabIndex = 51
        '
        'dteJnlTranDate
        '
        Me.dteJnlTranDate.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteJnlTranDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteJnlTranDate.Location = New System.Drawing.Point(220, 346)
        Me.dteJnlTranDate.Name = "dteJnlTranDate"
        Me.dteJnlTranDate.Size = New System.Drawing.Size(106, 22)
        Me.dteJnlTranDate.TabIndex = 52
        '
        'cmbBankAct
        '
        Me.cmbBankAct.DropDownHeight = 212
        Me.cmbBankAct.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBankAct.FormattingEnabled = True
        Me.cmbBankAct.IntegralHeight = False
        Me.cmbBankAct.Location = New System.Drawing.Point(220, 430)
        Me.cmbBankAct.Name = "cmbBankAct"
        Me.cmbBankAct.Size = New System.Drawing.Size(191, 22)
        Me.cmbBankAct.TabIndex = 54
        '
        'lblBankAct
        '
        Me.lblBankAct.AutoSize = True
        Me.lblBankAct.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBankAct.Location = New System.Drawing.Point(119, 433)
        Me.lblBankAct.Name = "lblBankAct"
        Me.lblBankAct.Size = New System.Drawing.Size(79, 14)
        Me.lblBankAct.TabIndex = 53
        Me.lblBankAct.Text = "Bank Account"
        '
        'txtActName
        '
        Me.txtActName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActName.Location = New System.Drawing.Point(220, 318)
        Me.txtActName.Name = "txtActName"
        Me.txtActName.ReadOnly = True
        Me.txtActName.Size = New System.Drawing.Size(328, 22)
        Me.txtActName.TabIndex = 55
        '
        'cmbTranType
        '
        Me.cmbTranType.DropDownHeight = 280
        Me.cmbTranType.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTranType.FormattingEnabled = True
        Me.cmbTranType.IntegralHeight = False
        Me.cmbTranType.Location = New System.Drawing.Point(220, 374)
        Me.cmbTranType.MaxDropDownItems = 19
        Me.cmbTranType.Name = "cmbTranType"
        Me.cmbTranType.Size = New System.Drawing.Size(275, 22)
        Me.cmbTranType.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(372, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Select an Account Number!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(785, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 18)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Account Numbers!"
        '
        'cmbActivity
        '
        Me.cmbActivity.DropDownHeight = 300
        Me.cmbActivity.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbActivity.FormattingEnabled = True
        Me.cmbActivity.IntegralHeight = False
        Me.cmbActivity.Location = New System.Drawing.Point(220, 260)
        Me.cmbActivity.Name = "cmbActivity"
        Me.cmbActivity.Size = New System.Drawing.Size(203, 22)
        Me.cmbActivity.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 14)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Activity"
        '
        'pnlEdit
        '
        Me.pnlEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEdit.Controls.Add(Me.Label4)
        Me.pnlEdit.Controls.Add(Me.cmbTransaction)
        Me.pnlEdit.Enabled = False
        Me.pnlEdit.Location = New System.Drawing.Point(223, 122)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(428, 82)
        Me.pnlEdit.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Select Transaction"
        '
        'cmbTransaction
        '
        Me.cmbTransaction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTransaction.FormattingEnabled = True
        Me.cmbTransaction.Location = New System.Drawing.Point(57, 34)
        Me.cmbTransaction.Name = "cmbTransaction"
        Me.cmbTransaction.Size = New System.Drawing.Size(318, 21)
        Me.cmbTransaction.TabIndex = 0
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(362, 93)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(148, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Click to Edit Transaction"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Only if Transaction is not Cash"
        '
        'lblJnlID
        '
        Me.lblJnlID.AutoSize = True
        Me.lblJnlID.Location = New System.Drawing.Point(88, 87)
        Me.lblJnlID.Name = "lblJnlID"
        Me.lblJnlID.Size = New System.Drawing.Size(47, 13)
        Me.lblJnlID.TabIndex = 63
        Me.lblJnlID.Text = "hdnJnlId"
        Me.lblJnlID.Visible = False
        '
        'btnDistribute
        '
        Me.btnDistribute.Enabled = False
        Me.btnDistribute.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDistribute.Location = New System.Drawing.Point(348, 402)
        Me.btnDistribute.Name = "btnDistribute"
        Me.btnDistribute.Size = New System.Drawing.Size(75, 23)
        Me.btnDistribute.TabIndex = 64
        Me.btnDistribute.Text = "Distribute"
        Me.btnDistribute.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(359, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Only Blue can be distributed."
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(495, 609)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 66
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkHaveReceipt
        '
        Me.chkHaveReceipt.AutoSize = True
        Me.chkHaveReceipt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHaveReceipt.Location = New System.Drawing.Point(132, 575)
        Me.chkHaveReceipt.Name = "chkHaveReceipt"
        Me.chkHaveReceipt.Size = New System.Drawing.Size(87, 17)
        Me.chkHaveReceipt.TabIndex = 68
        Me.chkHaveReceipt.Text = "Have receipt"
        Me.chkHaveReceipt.UseVisualStyleBackColor = True
        '
        'chkRepeat
        '
        Me.chkRepeat.AutoSize = True
        Me.chkRepeat.Location = New System.Drawing.Point(389, 614)
        Me.chkRepeat.Name = "chkRepeat"
        Me.chkRepeat.Size = New System.Drawing.Size(67, 17)
        Me.chkRepeat.TabIndex = 69
        Me.chkRepeat.Text = "Repeat?"
        Me.chkRepeat.UseVisualStyleBackColor = True
        '
        'EnterJournalTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1118, 698)
        Me.Controls.Add(Me.chkRepeat)
        Me.Controls.Add(Me.chkHaveReceipt)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDistribute)
        Me.Controls.Add(Me.lblJnlID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.cmbActivity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTranType)
        Me.Controls.Add(Me.txtActName)
        Me.Controls.Add(Me.cmbBankAct)
        Me.Controls.Add(Me.lblBankAct)
        Me.Controls.Add(Me.dteJnlTranDate)
        Me.Controls.Add(Me.cmbBusiness)
        Me.Controls.Add(Me.lblBusiness)
        Me.Controls.Add(Me.lblMemo)
        Me.Controls.Add(Me.txtMemo)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblTranType)
        Me.Controls.Add(Me.lblTranDate)
        Me.Controls.Add(Me.lblActName)
        Me.Controls.Add(Me.txtActSeq)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblActNum)
        Me.Controls.Add(Me.txtActnum)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "EnterJournalTransaction"
        Me.Controls.SetChildIndex(Me.txtActnum, 0)
        Me.Controls.SetChildIndex(Me.lblActNum, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.dgvAccounts, 0)
        Me.Controls.SetChildIndex(Me.grpDisplay, 0)
        Me.Controls.SetChildIndex(Me.txtActSeq, 0)
        Me.Controls.SetChildIndex(Me.lblActName, 0)
        Me.Controls.SetChildIndex(Me.lblTranDate, 0)
        Me.Controls.SetChildIndex(Me.lblTranType, 0)
        Me.Controls.SetChildIndex(Me.txtAmount, 0)
        Me.Controls.SetChildIndex(Me.lblAmount, 0)
        Me.Controls.SetChildIndex(Me.txtDescription, 0)
        Me.Controls.SetChildIndex(Me.lblDescription, 0)
        Me.Controls.SetChildIndex(Me.txtMemo, 0)
        Me.Controls.SetChildIndex(Me.lblMemo, 0)
        Me.Controls.SetChildIndex(Me.lblBusiness, 0)
        Me.Controls.SetChildIndex(Me.cmbBusiness, 0)
        Me.Controls.SetChildIndex(Me.dteJnlTranDate, 0)
        Me.Controls.SetChildIndex(Me.lblBankAct, 0)
        Me.Controls.SetChildIndex(Me.cmbBankAct, 0)
        Me.Controls.SetChildIndex(Me.txtActName, 0)
        Me.Controls.SetChildIndex(Me.cmbTranType, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.cmbActivity, 0)
        Me.Controls.SetChildIndex(Me.btnEdit, 0)
        Me.Controls.SetChildIndex(Me.pnlEdit, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.lblJnlID, 0)
        Me.Controls.SetChildIndex(Me.btnDistribute, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.chkHaveReceipt, 0)
        Me.Controls.SetChildIndex(Me.chkRepeat, 0)
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtActnum As System.Windows.Forms.TextBox
    Friend WithEvents lblActNum As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grpDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents rbRevenue As System.Windows.Forms.RadioButton
    Friend WithEvents rbExpense As System.Windows.Forms.RadioButton
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents actDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acntID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblActName As System.Windows.Forms.Label
    Friend WithEvents txtActSeq As System.Windows.Forms.TextBox
    Friend WithEvents lblTranDate As System.Windows.Forms.Label
    Friend WithEvents lblTranType As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblMemo As System.Windows.Forms.Label
    Friend WithEvents txtMemo As System.Windows.Forms.TextBox
    Friend WithEvents lblBusiness As System.Windows.Forms.Label
    Friend WithEvents cmbBusiness As System.Windows.Forms.ComboBox
    Friend WithEvents dteJnlTranDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbBankAct As System.Windows.Forms.ComboBox
    Friend WithEvents lblBankAct As System.Windows.Forms.Label
    Friend WithEvents txtActName As System.Windows.Forms.TextBox
    Friend WithEvents cmbTranType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbAsset As System.Windows.Forms.RadioButton
    Friend WithEvents rbLiability As System.Windows.Forms.RadioButton
    Friend WithEvents cmbActivity As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlEdit As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents cmbTransaction As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblJnlID As System.Windows.Forms.Label
    Friend WithEvents btnDistribute As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chkHaveReceipt As System.Windows.Forms.CheckBox
    Friend WithEvents chkRepeat As System.Windows.Forms.CheckBox

End Class
