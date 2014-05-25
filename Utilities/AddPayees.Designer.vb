<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPayees
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
        Me.dgvAccounts = New System.Windows.Forms.DataGridView
        Me.actDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acntID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hdnActID = New System.Windows.Forms.Label
        Me.txtAccountname = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCPhone = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLPhone = New System.Windows.Forms.TextBox
        Me.txtAccountNum = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMaxID = New System.Windows.Forms.TextBox
        Me.txtHasSibling = New System.Windows.Forms.TextBox
        Me.ddlBusiness = New System.Windows.Forms.ComboBox
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblActivity = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtDisplayName = New System.Windows.Forms.TextBox
        Me.txtBusiness = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.lblHdnSource = New System.Windows.Forms.Label
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.actDescription, Me.actName, Me.actNum, Me.acntID})
        Me.dgvAccounts.Location = New System.Drawing.Point(419, 35)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.Size = New System.Drawing.Size(345, 438)
        Me.dgvAccounts.TabIndex = 16
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
        Me.hdnActID.Location = New System.Drawing.Point(319, 368)
        Me.hdnActID.Name = "hdnActID"
        Me.hdnActID.Size = New System.Drawing.Size(13, 13)
        Me.hdnActID.TabIndex = 40
        Me.hdnActID.Text = "0"
        Me.hdnActID.Visible = False
        '
        'txtAccountname
        '
        Me.txtAccountname.Location = New System.Drawing.Point(197, 387)
        Me.txtAccountname.Name = "txtAccountname"
        Me.txtAccountname.Size = New System.Drawing.Size(211, 20)
        Me.txtAccountname.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(60, 387)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Tagged Account Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(120, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Tag = ""
        Me.Label9.Text = "Cell Phone"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCPhone
        '
        Me.txtCPhone.Location = New System.Drawing.Point(197, 335)
        Me.txtCPhone.MaxLength = 12
        Me.txtCPhone.Name = "txtCPhone"
        Me.txtCPhone.Size = New System.Drawing.Size(98, 20)
        Me.txtCPhone.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Land Phone"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLPhone
        '
        Me.txtLPhone.Location = New System.Drawing.Point(197, 309)
        Me.txtLPhone.MaxLength = 12
        Me.txtLPhone.Name = "txtLPhone"
        Me.txtLPhone.Size = New System.Drawing.Size(98, 20)
        Me.txtLPhone.TabIndex = 34
        '
        'txtAccountNum
        '
        Me.txtAccountNum.Location = New System.Drawing.Point(197, 361)
        Me.txtAccountNum.Name = "txtAccountNum"
        Me.txtAccountNum.Size = New System.Drawing.Size(51, 20)
        Me.txtAccountNum.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 364)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Tagged Account Number"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMaxID
        '
        Me.txtMaxID.Location = New System.Drawing.Point(322, 135)
        Me.txtMaxID.MaxLength = 2
        Me.txtMaxID.Name = "txtMaxID"
        Me.txtMaxID.Size = New System.Drawing.Size(30, 20)
        Me.txtMaxID.TabIndex = 48
        '
        'txtHasSibling
        '
        Me.txtHasSibling.Location = New System.Drawing.Point(197, 135)
        Me.txtHasSibling.MaxLength = 2
        Me.txtHasSibling.Name = "txtHasSibling"
        Me.txtHasSibling.Size = New System.Drawing.Size(30, 20)
        Me.txtHasSibling.TabIndex = 47
        '
        'ddlBusiness
        '
        Me.ddlBusiness.FormattingEnabled = True
        Me.ddlBusiness.Location = New System.Drawing.Point(196, 80)
        Me.ddlBusiness.Name = "ddlBusiness"
        Me.ddlBusiness.Size = New System.Drawing.Size(168, 21)
        Me.ddlBusiness.TabIndex = 46
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(197, 161)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(168, 20)
        Me.txtAddress1.TabIndex = 41
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(197, 265)
        Me.txtZip.MaxLength = 12
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(98, 20)
        Me.txtZip.TabIndex = 45
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(197, 239)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(30, 20)
        Me.txtState.TabIndex = 44
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(197, 213)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(168, 20)
        Me.txtCity.TabIndex = 43
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(197, 187)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(168, 20)
        Me.txtAddress2.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(110, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Has Sibling?"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(59, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Business Display Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Business/Individual Listed Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(143, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Zip"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Address Line 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "State"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "City"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Address Line 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivity.Location = New System.Drawing.Point(50, 22)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(220, 19)
        Me.lblActivity.TabIndex = 58
        Me.lblActivity.Text = "You are now Editing this entry!"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(285, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(315, 26)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Add or Edit a Business or Individual"
        '
        'txtDisplayName
        '
        Me.txtDisplayName.Location = New System.Drawing.Point(196, 111)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(168, 20)
        Me.txtDisplayName.TabIndex = 60
        '
        'txtBusiness
        '
        Me.txtBusiness.Location = New System.Drawing.Point(196, 80)
        Me.txtBusiness.MaxLength = 20
        Me.txtBusiness.Name = "txtBusiness"
        Me.txtBusiness.Size = New System.Drawing.Size(168, 20)
        Me.txtBusiness.TabIndex = 61
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(299, 427)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 64
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(184, 427)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 63
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(54, 427)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 62
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblHdnSource
        '
        Me.lblHdnSource.AutoSize = True
        Me.lblHdnSource.Location = New System.Drawing.Point(18, 54)
        Me.lblHdnSource.Name = "lblHdnSource"
        Me.lblHdnSource.Size = New System.Drawing.Size(73, 13)
        Me.lblHdnSource.TabIndex = 65
        Me.lblHdnSource.Text = "hiddenSource"
        Me.lblHdnSource.Visible = False
        '
        'AddPayees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 570)
        Me.Controls.Add(Me.lblHdnSource)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtBusiness)
        Me.Controls.Add(Me.txtDisplayName)
        Me.Controls.Add(Me.lblActivity)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaxID)
        Me.Controls.Add(Me.txtHasSibling)
        Me.Controls.Add(Me.ddlBusiness)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.hdnActID)
        Me.Controls.Add(Me.txtAccountname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCPhone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLPhone)
        Me.Controls.Add(Me.txtAccountNum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Name = "AddPayees"
        Me.Text = "AddPayees"
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents actDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acntID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hdnActID As System.Windows.Forms.Label
    Friend WithEvents txtAccountname As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtAccountNum As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMaxID As System.Windows.Forms.TextBox
    Friend WithEvents txtHasSibling As System.Windows.Forms.TextBox
    Friend WithEvents ddlBusiness As System.Windows.Forms.ComboBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblActivity As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDisplayName As System.Windows.Forms.TextBox
    Friend WithEvents txtBusiness As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblHdnSource As System.Windows.Forms.Label
End Class
