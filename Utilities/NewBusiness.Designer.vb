<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBusiness
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
        Me.dgvAccounts = New System.Windows.Forms.DataGridView
        Me.actDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acntID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblHdnSource = New System.Windows.Forms.Label
        Me.lblActivity = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.grpDisplay = New System.Windows.Forms.GroupBox
        Me.rbIncome = New System.Windows.Forms.RadioButton
        Me.rbExpense = New System.Windows.Forms.RadioButton
        Me.txtMaxID = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtHasSibling = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDisplayName = New System.Windows.Forms.TextBox
        Me.hdnActID = New System.Windows.Forms.Label
        Me.txtAccountname = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtBusiness = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCPhone = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLPhone = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.ddlBusiness = New System.Windows.Forms.ComboBox
        Me.txtAccountNum = New System.Windows.Forms.TextBox
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtState = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.AllowUserToResizeColumns = False
        Me.dgvAccounts.AllowUserToResizeRows = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.actDescription, Me.actName, Me.actNum, Me.acntID})
        Me.dgvAccounts.Location = New System.Drawing.Point(682, 137)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.RowHeadersVisible = False
        Me.dgvAccounts.Size = New System.Drawing.Size(317, 459)
        Me.dgvAccounts.TabIndex = 78
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
        'lblHdnSource
        '
        Me.lblHdnSource.AutoSize = True
        Me.lblHdnSource.Location = New System.Drawing.Point(169, 69)
        Me.lblHdnSource.Name = "lblHdnSource"
        Me.lblHdnSource.Size = New System.Drawing.Size(73, 13)
        Me.lblHdnSource.TabIndex = 77
        Me.lblHdnSource.Text = "hiddenSource"
        Me.lblHdnSource.Visible = False
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivity.Location = New System.Drawing.Point(180, 126)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(220, 19)
        Me.lblActivity.TabIndex = 68
        Me.lblActivity.Text = "You are now Editing this entry!"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(345, 223)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "Max ID"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(212, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Has Sibling?"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpDisplay
        '
        Me.grpDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpDisplay.Controls.Add(Me.rbIncome)
        Me.grpDisplay.Controls.Add(Me.rbExpense)
        Me.grpDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpDisplay.Location = New System.Drawing.Point(563, 596)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(345, 33)
        Me.grpDisplay.TabIndex = 70
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
        'txtMaxID
        '
        Me.txtMaxID.Location = New System.Drawing.Point(413, 220)
        Me.txtMaxID.MaxLength = 2
        Me.txtMaxID.Name = "txtMaxID"
        Me.txtMaxID.Size = New System.Drawing.Size(30, 20)
        Me.txtMaxID.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(395, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(315, 26)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Add or Edit a Business or Individual"
        '
        'txtHasSibling
        '
        Me.txtHasSibling.Location = New System.Drawing.Point(288, 220)
        Me.txtHasSibling.MaxLength = 2
        Me.txtHasSibling.Name = "txtHasSibling"
        Me.txtHasSibling.Size = New System.Drawing.Size(30, 20)
        Me.txtHasSibling.TabIndex = 73
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(161, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 13)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Business Display Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDisplayName
        '
        Me.txtDisplayName.Location = New System.Drawing.Point(288, 194)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(168, 20)
        Me.txtDisplayName.TabIndex = 71
        '
        'hdnActID
        '
        Me.hdnActID.AutoSize = True
        Me.hdnActID.Location = New System.Drawing.Point(410, 435)
        Me.hdnActID.Name = "hdnActID"
        Me.hdnActID.Size = New System.Drawing.Size(13, 13)
        Me.hdnActID.TabIndex = 69
        Me.hdnActID.Text = "0"
        Me.hdnActID.Visible = False
        '
        'txtAccountname
        '
        Me.txtAccountname.Location = New System.Drawing.Point(288, 454)
        Me.txtAccountname.Name = "txtAccountname"
        Me.txtAccountname.Size = New System.Drawing.Size(211, 20)
        Me.txtAccountname.TabIndex = 67
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(151, 454)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 13)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Tagged Account Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBusiness
        '
        Me.txtBusiness.Location = New System.Drawing.Point(419, 137)
        Me.txtBusiness.MaxLength = 20
        Me.txtBusiness.Name = "txtBusiness"
        Me.txtBusiness.Size = New System.Drawing.Size(168, 20)
        Me.txtBusiness.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 402)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Tag = ""
        Me.Label9.Text = "Cell Phone"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCPhone
        '
        Me.txtCPhone.Location = New System.Drawing.Point(288, 402)
        Me.txtCPhone.MaxLength = 12
        Me.txtCPhone.Name = "txtCPhone"
        Me.txtCPhone.Size = New System.Drawing.Size(98, 20)
        Me.txtCPhone.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(202, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Land Phone"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLPhone
        '
        Me.txtLPhone.Location = New System.Drawing.Point(288, 376)
        Me.txtLPhone.MaxLength = 12
        Me.txtLPhone.Name = "txtLPhone"
        Me.txtLPhone.Size = New System.Drawing.Size(98, 20)
        Me.txtLPhone.TabIndex = 61
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(339, 562)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 60
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(339, 533)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 59
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(339, 504)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 58
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(120, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Business/Individual Listed Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ddlBusiness
        '
        Me.ddlBusiness.FormattingEnabled = True
        Me.ddlBusiness.Location = New System.Drawing.Point(287, 165)
        Me.ddlBusiness.Name = "ddlBusiness"
        Me.ddlBusiness.Size = New System.Drawing.Size(168, 21)
        Me.ddlBusiness.TabIndex = 56
        Me.ddlBusiness.Visible = False
        '
        'txtAccountNum
        '
        Me.txtAccountNum.Location = New System.Drawing.Point(288, 428)
        Me.txtAccountNum.Name = "txtAccountNum"
        Me.txtAccountNum.Size = New System.Drawing.Size(51, 20)
        Me.txtAccountNum.TabIndex = 55
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(288, 246)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(168, 20)
        Me.txtAddress1.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 431)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Tagged Account Number"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Zip"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(288, 350)
        Me.txtZip.MaxLength = 12
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(98, 20)
        Me.txtZip.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Address Line 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "State"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(288, 324)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(30, 20)
        Me.txtState.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "City"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(288, 298)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(168, 20)
        Me.txtCity.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Address Line 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(288, 272)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(168, 20)
        Me.txtAddress2.TabIndex = 46
        '
        'NewBusiness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1118, 698)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.lblHdnSource)
        Me.Controls.Add(Me.lblActivity)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.txtMaxID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtHasSibling)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDisplayName)
        Me.Controls.Add(Me.hdnActID)
        Me.Controls.Add(Me.txtAccountname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBusiness)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCPhone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLPhone)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ddlBusiness)
        Me.Controls.Add(Me.txtAccountNum)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddress2)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "NewBusiness"
        Me.Controls.SetChildIndex(Me.txtAddress2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtCity, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtState, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtZip, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtAddress1, 0)
        Me.Controls.SetChildIndex(Me.txtAccountNum, 0)
        Me.Controls.SetChildIndex(Me.ddlBusiness, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.txtLPhone, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtCPhone, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.txtBusiness, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.txtAccountname, 0)
        Me.Controls.SetChildIndex(Me.hdnActID, 0)
        Me.Controls.SetChildIndex(Me.txtDisplayName, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.txtHasSibling, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txtMaxID, 0)
        Me.Controls.SetChildIndex(Me.grpDisplay, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.lblActivity, 0)
        Me.Controls.SetChildIndex(Me.lblHdnSource, 0)
        Me.Controls.SetChildIndex(Me.dgvAccounts, 0)
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents actDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acntID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblHdnSource As System.Windows.Forms.Label
    Friend WithEvents lblActivity As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents grpDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents rbIncome As System.Windows.Forms.RadioButton
    Friend WithEvents rbExpense As System.Windows.Forms.RadioButton
    Friend WithEvents txtMaxID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtHasSibling As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDisplayName As System.Windows.Forms.TextBox
    Friend WithEvents hdnActID As System.Windows.Forms.Label
    Friend WithEvents txtAccountname As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBusiness As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ddlBusiness As System.Windows.Forms.ComboBox
    Friend WithEvents txtAccountNum As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox

End Class
