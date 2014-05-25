<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddChecks
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
        Me.lblName = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dteCheck = New System.Windows.Forms.DateTimePicker
        Me.txtNote = New System.Windows.Forms.RichTextBox
        Me.cmbBankAccount = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnChange = New System.Windows.Forms.Button
        Me.cmbBusiness = New System.Windows.Forms.ComboBox
        Me.txtChkNum = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.ddlActivity = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dgvAccounts = New System.Windows.Forms.DataGridView
        Me.actDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtAcntNum = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtActName = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.hdnMasterAccount = New System.Windows.Forms.Label
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(85, 254)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 19)
        Me.lblName.TabIndex = 28
        Me.lblName.Text = "Name"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(157, 289)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(119, 26)
        Me.txtAmount.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 19)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Note:"
        '
        'dteCheck
        '
        Me.dteCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteCheck.Location = New System.Drawing.Point(157, 337)
        Me.dteCheck.Name = "dteCheck"
        Me.dteCheck.Size = New System.Drawing.Size(200, 24)
        Me.dteCheck.TabIndex = 35
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(157, 388)
        Me.txtNote.MaxLength = 200
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(515, 82)
        Me.txtNote.TabIndex = 36
        Me.txtNote.Text = ""
        '
        'cmbBankAccount
        '
        Me.cmbBankAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBankAccount.FormattingEnabled = True
        Me.cmbBankAccount.Location = New System.Drawing.Point(157, 192)
        Me.cmbBankAccount.Name = "cmbBankAccount"
        Me.cmbBankAccount.Size = New System.Drawing.Size(121, 26)
        Me.cmbBankAccount.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Bank Account"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(282, 518)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(361, 235)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(60, 32)
        Me.btnChange.TabIndex = 41
        Me.btnChange.Text = "New"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'cmbBusiness
        '
        Me.cmbBusiness.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBusiness.FormattingEnabled = True
        Me.cmbBusiness.Location = New System.Drawing.Point(157, 242)
        Me.cmbBusiness.Name = "cmbBusiness"
        Me.cmbBusiness.Size = New System.Drawing.Size(180, 26)
        Me.cmbBusiness.TabIndex = 40
        '
        'txtChkNum
        '
        Me.txtChkNum.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChkNum.Location = New System.Drawing.Point(157, 137)
        Me.txtChkNum.Name = "txtChkNum"
        Me.txtChkNum.Size = New System.Drawing.Size(119, 26)
        Me.txtChkNum.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 19)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Check #"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(396, 518)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 31)
        Me.btnClose.TabIndex = 44
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ddlActivity
        '
        Me.ddlActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlActivity.FormattingEnabled = True
        Me.ddlActivity.Location = New System.Drawing.Point(439, 142)
        Me.ddlActivity.Name = "ddlActivity"
        Me.ddlActivity.Size = New System.Drawing.Size(180, 26)
        Me.ddlActivity.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(372, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 19)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Activity"
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.actDescription, Me.actNum, Me.actName})
        Me.dgvAccounts.Location = New System.Drawing.Point(744, 123)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.Size = New System.Drawing.Size(341, 438)
        Me.dgvAccounts.TabIndex = 47
        '
        'actDescription
        '
        Me.actDescription.HeaderText = "Description"
        Me.actDescription.Name = "actDescription"
        Me.actDescription.Width = 300
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
        'txtAcntNum
        '
        Me.txtAcntNum.Enabled = False
        Me.txtAcntNum.Location = New System.Drawing.Point(427, 290)
        Me.txtAcntNum.Name = "txtAcntNum"
        Me.txtAcntNum.Size = New System.Drawing.Size(61, 20)
        Me.txtAcntNum.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(334, 291)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Account Number"
        '
        'txtActName
        '
        Me.txtActName.Enabled = False
        Me.txtActName.Location = New System.Drawing.Point(427, 316)
        Me.txtActName.Name = "txtActName"
        Me.txtActName.Size = New System.Drawing.Size(208, 20)
        Me.txtActName.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(334, 316)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Account Name"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(863, 75)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(144, 20)
        Me.txtSearch.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(731, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 19)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Search Account"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1013, 74)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(38, 23)
        Me.btnSearch.TabIndex = 55
        Me.btnSearch.Text = "Go"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'hdnMasterAccount
        '
        Me.hdnMasterAccount.AutoSize = True
        Me.hdnMasterAccount.Location = New System.Drawing.Point(470, 235)
        Me.hdnMasterAccount.Name = "hdnMasterAccount"
        Me.hdnMasterAccount.Size = New System.Drawing.Size(119, 13)
        Me.hdnMasterAccount.TabIndex = 56
        Me.hdnMasterAccount.Text = "Hidden Master Account"
        Me.hdnMasterAccount.Visible = False
        '
        'AddChecks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1186, 698)
        Me.Controls.Add(Me.hdnMasterAccount)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtAcntNum)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtActName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ddlActivity)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtChkNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.cmbBusiness)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbBankAccount)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.dteCheck)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblName)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "AddChecks"
        Me.Controls.SetChildIndex(Me.lblName, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtAmount, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.dteCheck, 0)
        Me.Controls.SetChildIndex(Me.txtNote, 0)
        Me.Controls.SetChildIndex(Me.cmbBankAccount, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.cmbBusiness, 0)
        Me.Controls.SetChildIndex(Me.btnChange, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtChkNum, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.ddlActivity, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.dgvAccounts, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txtActName, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.txtAcntNum, 0)
        Me.Controls.SetChildIndex(Me.txtSearch, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.btnSearch, 0)
        Me.Controls.SetChildIndex(Me.hdnMasterAccount, 0)
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dteCheck As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNote As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbBankAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents cmbBusiness As System.Windows.Forms.ComboBox
    Friend WithEvents txtChkNum As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ddlActivity As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents actDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtAcntNum As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtActName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents hdnMasterAccount As System.Windows.Forms.Label

End Class
