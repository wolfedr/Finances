<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAccount
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
        Me.components = New System.ComponentModel.Container
        Me.dgvAccounts = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblAcntName = New System.Windows.Forms.Label
        Me.ddlActTyp = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblCaption = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.ddlSubAcct = New System.Windows.Forms.ComboBox
        Me.ddlAcntNumber = New System.Windows.Forms.ComboBox
        Me.txtAcntName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblSaveInstructions = New System.Windows.Forms.Label
        Me.lblHdnSource = New System.Windows.Forms.Label
        Me.grpPriority = New System.Windows.Forms.GroupBox
        Me.RBHigh = New System.Windows.Forms.RadioButton
        Me.rbMedium = New System.Windows.Forms.RadioButton
        Me.rbAll = New System.Windows.Forms.RadioButton
        Me.grpMasterAccounts = New System.Windows.Forms.GroupBox
        Me.rbAssets = New System.Windows.Forms.RadioButton
        Me.rbDebts = New System.Windows.Forms.RadioButton
        Me.rbIncome = New System.Windows.Forms.RadioButton
        Me.rbExpense = New System.Windows.Forms.RadioButton
        Me.btnActivate = New System.Windows.Forms.Button
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.hdnActSelection = New System.Windows.Forms.Label
        Me.actDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actUse = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actNumSeq = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPriority.SuspendLayout()
        Me.grpMasterAccounts.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.actDescription, Me.actNum, Me.actName, Me.actUse, Me.actNumSeq})
        Me.dgvAccounts.Location = New System.Drawing.Point(654, 122)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.Size = New System.Drawing.Size(450, 505)
        Me.dgvAccounts.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Choose Master Account"
        '
        'lblAcntName
        '
        Me.lblAcntName.AutoSize = True
        Me.lblAcntName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcntName.Location = New System.Drawing.Point(66, 349)
        Me.lblAcntName.Name = "lblAcntName"
        Me.lblAcntName.Size = New System.Drawing.Size(169, 17)
        Me.lblAcntName.TabIndex = 7
        Me.lblAcntName.Text = "Enter New Account Name"
        Me.lblAcntName.Visible = False
        '
        'ddlActTyp
        '
        Me.ddlActTyp.BackColor = System.Drawing.SystemColors.Menu
        Me.ddlActTyp.Location = New System.Drawing.Point(0, 0)
        Me.ddlActTyp.Name = "ddlActTyp"
        Me.ddlActTyp.Size = New System.Drawing.Size(121, 21)
        Me.ddlActTyp.TabIndex = 1
        Me.ddlActTyp.Text = "CCC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Choose Account Number"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(241, 577)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(839, 66)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(83, 23)
        Me.lblCaption.TabIndex = 11
        Me.lblCaption.Text = "Accounts"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(241, 618)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Choose Sub-Account Name"
        '
        'ddlSubAcct
        '
        Me.ddlSubAcct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSubAcct.FormattingEnabled = True
        Me.ddlSubAcct.Location = New System.Drawing.Point(241, 266)
        Me.ddlSubAcct.Name = "ddlSubAcct"
        Me.ddlSubAcct.Size = New System.Drawing.Size(277, 21)
        Me.ddlSubAcct.TabIndex = 14
        '
        'ddlAcntNumber
        '
        Me.ddlAcntNumber.FormattingEnabled = True
        Me.ddlAcntNumber.Location = New System.Drawing.Point(242, 308)
        Me.ddlAcntNumber.Name = "ddlAcntNumber"
        Me.ddlAcntNumber.Size = New System.Drawing.Size(276, 21)
        Me.ddlAcntNumber.TabIndex = 16
        '
        'txtAcntName
        '
        Me.txtAcntName.Location = New System.Drawing.Point(242, 346)
        Me.txtAcntName.Name = "txtAcntName"
        Me.txtAcntName.Size = New System.Drawing.Size(276, 20)
        Me.txtAcntName.TabIndex = 17
        Me.txtAcntName.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Add or Edit New Accounts"
        '
        'lblSaveInstructions
        '
        Me.lblSaveInstructions.AutoSize = True
        Me.lblSaveInstructions.Location = New System.Drawing.Point(17, 376)
        Me.lblSaveInstructions.Name = "lblSaveInstructions"
        Me.lblSaveInstructions.Size = New System.Drawing.Size(39, 13)
        Me.lblSaveInstructions.TabIndex = 19
        Me.lblSaveInstructions.Text = "Label5"
        '
        'lblHdnSource
        '
        Me.lblHdnSource.AutoSize = True
        Me.lblHdnSource.Location = New System.Drawing.Point(12, 72)
        Me.lblHdnSource.Name = "lblHdnSource"
        Me.lblHdnSource.Size = New System.Drawing.Size(14, 13)
        Me.lblHdnSource.TabIndex = 27
        Me.lblHdnSource.Text = "X"
        Me.lblHdnSource.Visible = False
        '
        'grpPriority
        '
        Me.grpPriority.Controls.Add(Me.RBHigh)
        Me.grpPriority.Controls.Add(Me.rbMedium)
        Me.grpPriority.Controls.Add(Me.rbAll)
        Me.grpPriority.Location = New System.Drawing.Point(719, 84)
        Me.grpPriority.Name = "grpPriority"
        Me.grpPriority.Size = New System.Drawing.Size(345, 38)
        Me.grpPriority.TabIndex = 28
        Me.grpPriority.TabStop = False
        Me.grpPriority.Text = "Priority"
        '
        'RBHigh
        '
        Me.RBHigh.AutoSize = True
        Me.RBHigh.Checked = True
        Me.RBHigh.Location = New System.Drawing.Point(25, 15)
        Me.RBHigh.Name = "RBHigh"
        Me.RBHigh.Size = New System.Drawing.Size(47, 17)
        Me.RBHigh.TabIndex = 2
        Me.RBHigh.TabStop = True
        Me.RBHigh.Text = "High"
        Me.RBHigh.UseVisualStyleBackColor = True
        '
        'rbMedium
        '
        Me.rbMedium.AutoSize = True
        Me.rbMedium.Location = New System.Drawing.Point(141, 15)
        Me.rbMedium.Name = "rbMedium"
        Me.rbMedium.Size = New System.Drawing.Size(62, 17)
        Me.rbMedium.TabIndex = 1
        Me.rbMedium.Text = "Medium"
        Me.rbMedium.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Location = New System.Drawing.Point(275, 15)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(36, 17)
        Me.rbAll.TabIndex = 0
        Me.rbAll.Text = "All"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'grpMasterAccounts
        '
        Me.grpMasterAccounts.Controls.Add(Me.rbAssets)
        Me.grpMasterAccounts.Controls.Add(Me.rbDebts)
        Me.grpMasterAccounts.Controls.Add(Me.rbIncome)
        Me.grpMasterAccounts.Controls.Add(Me.rbExpense)
        Me.grpMasterAccounts.Location = New System.Drawing.Point(317, 105)
        Me.grpMasterAccounts.Name = "grpMasterAccounts"
        Me.grpMasterAccounts.Size = New System.Drawing.Size(119, 111)
        Me.grpMasterAccounts.TabIndex = 29
        Me.grpMasterAccounts.TabStop = False
        Me.grpMasterAccounts.Text = "Master Accounts"
        '
        'rbAssets
        '
        Me.rbAssets.AutoSize = True
        Me.rbAssets.Location = New System.Drawing.Point(21, 65)
        Me.rbAssets.Name = "rbAssets"
        Me.rbAssets.Size = New System.Drawing.Size(56, 17)
        Me.rbAssets.TabIndex = 3
        Me.rbAssets.TabStop = True
        Me.rbAssets.Text = "Assets"
        Me.rbAssets.UseVisualStyleBackColor = True
        '
        'rbDebts
        '
        Me.rbDebts.AutoSize = True
        Me.rbDebts.Location = New System.Drawing.Point(21, 88)
        Me.rbDebts.Name = "rbDebts"
        Me.rbDebts.Size = New System.Drawing.Size(53, 17)
        Me.rbDebts.TabIndex = 2
        Me.rbDebts.TabStop = True
        Me.rbDebts.Text = "Debts"
        Me.rbDebts.UseVisualStyleBackColor = True
        '
        'rbIncome
        '
        Me.rbIncome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbIncome.AutoSize = True
        Me.rbIncome.Location = New System.Drawing.Point(21, 42)
        Me.rbIncome.Name = "rbIncome"
        Me.rbIncome.Size = New System.Drawing.Size(60, 17)
        Me.rbIncome.TabIndex = 1
        Me.rbIncome.TabStop = True
        Me.rbIncome.Text = "Income"
        Me.rbIncome.UseVisualStyleBackColor = True
        '
        'rbExpense
        '
        Me.rbExpense.AutoSize = True
        Me.rbExpense.Location = New System.Drawing.Point(21, 19)
        Me.rbExpense.Name = "rbExpense"
        Me.rbExpense.Size = New System.Drawing.Size(66, 17)
        Me.rbExpense.TabIndex = 0
        Me.rbExpense.TabStop = True
        Me.rbExpense.Text = "Expense"
        Me.rbExpense.UseVisualStyleBackColor = True
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(573, 302)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(75, 23)
        Me.btnActivate.TabIndex = 30
        Me.btnActivate.Text = "Activate"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'hdnActSelection
        '
        Me.hdnActSelection.AutoSize = True
        Me.hdnActSelection.Location = New System.Drawing.Point(871, 120)
        Me.hdnActSelection.Name = "hdnActSelection"
        Me.hdnActSelection.Size = New System.Drawing.Size(14, 13)
        Me.hdnActSelection.TabIndex = 31
        Me.hdnActSelection.Text = "X"
        Me.hdnActSelection.Visible = False
        '
        'actDescription
        '
        Me.actDescription.HeaderText = "Description"
        Me.actDescription.Name = "actDescription"
        Me.actDescription.Width = 330
        '
        'actNum
        '
        Me.actNum.HeaderText = "actNum"
        Me.actNum.Name = "actNum"
        Me.actNum.Visible = False
        '
        'actName
        '
        Me.actName.HeaderText = "actName"
        Me.actName.Name = "actName"
        Me.actName.Visible = False
        '
        'actUse
        '
        Me.actUse.HeaderText = "Use"
        Me.actUse.Name = "actUse"
        Me.actUse.Width = 30
        '
        'actNumSeq
        '
        Me.actNumSeq.HeaderText = "Seq."
        Me.actNumSeq.Name = "actNumSeq"
        Me.actNumSeq.Width = 30
        '
        'ManageAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1118, 687)
        Me.Controls.Add(Me.hdnActSelection)
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.grpMasterAccounts)
        Me.Controls.Add(Me.grpPriority)
        Me.Controls.Add(Me.lblHdnSource)
        Me.Controls.Add(Me.lblSaveInstructions)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAcntName)
        Me.Controls.Add(Me.ddlAcntNumber)
        Me.Controls.Add(Me.ddlSubAcct)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAcntName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "ManageAccount"
        Me.Controls.SetChildIndex(Me.dgvAccounts, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.lblAcntName, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.lblCaption, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.ddlSubAcct, 0)
        Me.Controls.SetChildIndex(Me.ddlAcntNumber, 0)
        Me.Controls.SetChildIndex(Me.txtAcntName, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblSaveInstructions, 0)
        Me.Controls.SetChildIndex(Me.lblHdnSource, 0)
        Me.Controls.SetChildIndex(Me.grpPriority, 0)
        Me.Controls.SetChildIndex(Me.grpMasterAccounts, 0)
        Me.Controls.SetChildIndex(Me.btnActivate, 0)
        Me.Controls.SetChildIndex(Me.hdnActSelection, 0)
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPriority.ResumeLayout(False)
        Me.grpPriority.PerformLayout()
        Me.grpMasterAccounts.ResumeLayout(False)
        Me.grpMasterAccounts.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAcntName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents ddlActTyp As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ddlSubAcct As System.Windows.Forms.ComboBox
    Friend WithEvents ddlAcntNumber As System.Windows.Forms.ComboBox
    Friend WithEvents txtAcntName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSaveInstructions As System.Windows.Forms.Label
    Friend WithEvents lblHdnSource As System.Windows.Forms.Label
    Friend WithEvents grpPriority As System.Windows.Forms.GroupBox
    Friend WithEvents RBHigh As System.Windows.Forms.RadioButton
    Friend WithEvents rbMedium As System.Windows.Forms.RadioButton
    Friend WithEvents rbAll As System.Windows.Forms.RadioButton
    Friend WithEvents grpMasterAccounts As System.Windows.Forms.GroupBox
    Friend WithEvents rbAssets As System.Windows.Forms.RadioButton
    Friend WithEvents rbDebts As System.Windows.Forms.RadioButton
    Friend WithEvents rbIncome As System.Windows.Forms.RadioButton
    Friend WithEvents rbExpense As System.Windows.Forms.RadioButton
    Friend WithEvents btnActivate As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents hdnActSelection As System.Windows.Forms.Label
    Friend WithEvents actDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actUse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actNumSeq As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
