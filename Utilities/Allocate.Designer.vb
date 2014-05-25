<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Allocate
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblCaption = New System.Windows.Forms.Label
        Me.gpbType = New System.Windows.Forms.GroupBox
        Me.rbOther = New System.Windows.Forms.RadioButton
        Me.rbATM = New System.Windows.Forms.RadioButton
        Me.grpDisplay = New System.Windows.Forms.GroupBox
        Me.rbIncome = New System.Windows.Forms.RadioButton
        Me.rbExpense = New System.Windows.Forms.RadioButton
        Me.dgvAccounts = New System.Windows.Forms.DataGridView
        Me.actDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acntID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hdnActID = New System.Windows.Forms.Label
        Me.txtAccountname = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAccountNum = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgvTransactions = New System.Windows.Forms.DataGridView
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSplitAmount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbtlTranDate = New System.Windows.Forms.Label
        Me.lblTranType = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.lblAmtAllocate = New System.Windows.Forms.Label
        Me.grpBase = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.hdnATMID = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.gpbType.SuspendLayout()
        Me.grpDisplay.SuspendLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBase.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(370, 9)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(238, 23)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "Allocate Existing Transaction"
        '
        'gpbType
        '
        Me.gpbType.Controls.Add(Me.rbOther)
        Me.gpbType.Controls.Add(Me.rbATM)
        Me.gpbType.Location = New System.Drawing.Point(352, 36)
        Me.gpbType.Name = "gpbType"
        Me.gpbType.Size = New System.Drawing.Size(153, 76)
        Me.gpbType.TabIndex = 1
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
        Me.rbATM.Size = New System.Drawing.Size(49, 19)
        Me.rbATM.TabIndex = 0
        Me.rbATM.TabStop = True
        Me.rbATM.Text = "ATM"
        Me.rbATM.UseVisualStyleBackColor = True
        '
        'grpDisplay
        '
        Me.grpDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpDisplay.Controls.Add(Me.rbIncome)
        Me.grpDisplay.Controls.Add(Me.rbExpense)
        Me.grpDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpDisplay.Location = New System.Drawing.Point(719, 444)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(345, 33)
        Me.grpDisplay.TabIndex = 36
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
        Me.dgvAccounts.Location = New System.Drawing.Point(719, 39)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.Size = New System.Drawing.Size(345, 409)
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
        'txtAccountNum
        '
        Me.txtAccountNum.Location = New System.Drawing.Point(157, 95)
        Me.txtAccountNum.Name = "txtAccountNum"
        Me.txtAccountNum.Size = New System.Drawing.Size(51, 20)
        Me.txtAccountNum.TabIndex = 38
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
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTransactions.ColumnHeadersHeight = 24
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3, Me.Col4})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransactions.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvTransactions.Location = New System.Drawing.Point(12, 36)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.Size = New System.Drawing.Size(274, 401)
        Me.dgvTransactions.TabIndex = 42
        '
        'Col1
        '
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col1.DefaultCellStyle = DataGridViewCellStyle8
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(157, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 20)
        Me.TextBox1.TabIndex = 46
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
        'txtSplitAmount
        '
        Me.txtSplitAmount.Location = New System.Drawing.Point(152, 17)
        Me.txtSplitAmount.Name = "txtSplitAmount"
        Me.txtSplitAmount.Size = New System.Drawing.Size(53, 20)
        Me.txtSplitAmount.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "ATM Amount to Split"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(157, 147)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(211, 20)
        Me.TextBox2.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Payment Made to:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'lbtlTranDate
        '
        Me.lbtlTranDate.AutoSize = True
        Me.lbtlTranDate.Location = New System.Drawing.Point(154, 49)
        Me.lbtlTranDate.Name = "lbtlTranDate"
        Me.lbtlTranDate.Size = New System.Drawing.Size(36, 13)
        Me.lbtlTranDate.TabIndex = 50
        Me.lbtlTranDate.Text = " None"
        Me.lbtlTranDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(157, 33)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(51, 20)
        Me.TextBox3.TabIndex = 54
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
        'grpBase
        '
        Me.grpBase.Controls.Add(Me.hdnATMID)
        Me.grpBase.Controls.Add(Me.lbtlTranDate)
        Me.grpBase.Controls.Add(Me.Label4)
        Me.grpBase.Controls.Add(Me.txtSplitAmount)
        Me.grpBase.Controls.Add(Me.Label2)
        Me.grpBase.Location = New System.Drawing.Point(308, 132)
        Me.grpBase.Name = "grpBase"
        Me.grpBase.Size = New System.Drawing.Size(387, 86)
        Me.grpBase.TabIndex = 55
        Me.grpBase.TabStop = False
        Me.grpBase.Text = "Split Amount Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblTranType)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblAmtAllocate)
        Me.GroupBox1.Controls.Add(Me.hdnActID)
        Me.GroupBox1.Controls.Add(Me.txtAccountname)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAccountNum)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(308, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 194)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Allocate Amount Details"
        '
        'hdnATMID
        '
        Me.hdnATMID.AutoSize = True
        Me.hdnATMID.Location = New System.Drawing.Point(245, 49)
        Me.hdnATMID.Name = "hdnATMID"
        Me.hdnATMID.Size = New System.Drawing.Size(13, 13)
        Me.hdnATMID.TabIndex = 51
        Me.hdnATMID.Text = "0"
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
        'Allocate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 489)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpBase)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.gpbType)
        Me.Controls.Add(Me.lblCaption)
        Me.Name = "Allocate"
        Me.Text = "Allocate"
        Me.gpbType.ResumeLayout(False)
        Me.gpbType.PerformLayout()
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBase.ResumeLayout(False)
        Me.grpBase.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents gpbType As System.Windows.Forms.GroupBox
    Friend WithEvents rbOther As System.Windows.Forms.RadioButton
    Friend WithEvents rbATM As System.Windows.Forms.RadioButton
    Friend WithEvents grpDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents rbIncome As System.Windows.Forms.RadioButton
    Friend WithEvents rbExpense As System.Windows.Forms.RadioButton
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents actDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acntID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hdnActID As System.Windows.Forms.Label
    Friend WithEvents txtAccountname As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAccountNum As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSplitAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbtlTranDate As System.Windows.Forms.Label
    Friend WithEvents lblTranType As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblAmtAllocate As System.Windows.Forms.Label
    Friend WithEvents grpBase As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents hdnATMID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
