<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Distribute
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
        Me.lblSourceID = New System.Windows.Forms.Label
        Me.txtLink = New System.Windows.Forms.TextBox
        Me.dgDistribute = New System.Windows.Forms.DataGridView
        Me.Link = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Entity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Memo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Activity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Account = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.txtMemo = New System.Windows.Forms.TextBox
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbActivity = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbCommonAccounts = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.dgDistribute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSourceID
        '
        Me.lblSourceID.AutoSize = True
        Me.lblSourceID.Location = New System.Drawing.Point(65, 213)
        Me.lblSourceID.Name = "lblSourceID"
        Me.lblSourceID.Size = New System.Drawing.Size(28, 13)
        Me.lblSourceID.TabIndex = 0
        Me.lblSourceID.Text = "lblID"
        Me.lblSourceID.Visible = False
        '
        'txtLink
        '
        Me.txtLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLink.Location = New System.Drawing.Point(571, 110)
        Me.txtLink.Name = "txtLink"
        Me.txtLink.ReadOnly = True
        Me.txtLink.Size = New System.Drawing.Size(88, 24)
        Me.txtLink.TabIndex = 0
        '
        'dgDistribute
        '
        Me.dgDistribute.AllowUserToAddRows = False
        Me.dgDistribute.AllowUserToDeleteRows = False
        Me.dgDistribute.AllowUserToResizeColumns = False
        Me.dgDistribute.AllowUserToResizeRows = False
        Me.dgDistribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDistribute.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Link, Me.Entity, Me.Amount, Me.Description, Me.Memo, Me.Activity, Me.Account})
        Me.dgDistribute.Location = New System.Drawing.Point(39, 248)
        Me.dgDistribute.Name = "dgDistribute"
        Me.dgDistribute.Size = New System.Drawing.Size(1097, 265)
        Me.dgDistribute.TabIndex = 10
        '
        'Link
        '
        Me.Link.DataPropertyName = "Link"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Link.DefaultCellStyle = DataGridViewCellStyle1
        Me.Link.HeaderText = "Link"
        Me.Link.Name = "Link"
        Me.Link.Width = 60
        '
        'Entity
        '
        Me.Entity.DataPropertyName = "Entity"
        Me.Entity.HeaderText = "Entity"
        Me.Entity.Name = "Entity"
        Me.Entity.Width = 150
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 70
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Width = 150
        '
        'Memo
        '
        Me.Memo.DataPropertyName = "Memo"
        Me.Memo.HeaderText = "Memo"
        Me.Memo.Name = "Memo"
        Me.Memo.Width = 250
        '
        'Activity
        '
        Me.Activity.DataPropertyName = "Activity"
        Me.Activity.HeaderText = "Activity"
        Me.Activity.Name = "Activity"
        '
        'Account
        '
        Me.Account.DataPropertyName = "Account"
        Me.Account.HeaderText = "Account"
        Me.Account.Name = "Account"
        Me.Account.Width = 270
        '
        'txtAmount
        '
        Me.txtAmount.AcceptsTab = True
        Me.txtAmount.Location = New System.Drawing.Point(68, 154)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(90, 20)
        Me.txtAmount.TabIndex = 1
        '
        'txtMemo
        '
        Me.txtMemo.Location = New System.Drawing.Point(317, 154)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(242, 20)
        Me.txtMemo.TabIndex = 3
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(164, 154)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(147, 20)
        Me.txtDesc.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(547, 182)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Enter"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Link ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "New Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "New Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(394, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "New Memo"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(430, 182)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close Window"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = "istribution"
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(500, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Distribution"
        '
        'cmbActivity
        '
        Me.cmbActivity.DropDownHeight = 300
        Me.cmbActivity.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbActivity.FormattingEnabled = True
        Me.cmbActivity.IntegralHeight = False
        Me.cmbActivity.Location = New System.Drawing.Point(565, 154)
        Me.cmbActivity.Name = "cmbActivity"
        Me.cmbActivity.Size = New System.Drawing.Size(183, 22)
        Me.cmbActivity.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(663, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "New Activity"
        '
        'cmbCommonAccounts
        '
        Me.cmbCommonAccounts.DropDownHeight = 300
        Me.cmbCommonAccounts.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCommonAccounts.FormattingEnabled = True
        Me.cmbCommonAccounts.IntegralHeight = False
        Me.cmbCommonAccounts.Location = New System.Drawing.Point(754, 154)
        Me.cmbCommonAccounts.Name = "cmbCommonAccounts"
        Me.cmbCommonAccounts.Size = New System.Drawing.Size(289, 22)
        Me.cmbCommonAccounts.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(246, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Always enter positive numbers for amount!"
        '
        'Distribute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(1113, 538)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbCommonAccounts)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbActivity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtMemo)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.dgDistribute)
        Me.Controls.Add(Me.txtLink)
        Me.Controls.Add(Me.lblSourceID)
        Me.Name = "Distribute"
        Me.Text = "Distribute"
        CType(Me.dgDistribute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSourceID As System.Windows.Forms.Label
    Friend WithEvents txtLink As System.Windows.Forms.TextBox
    Friend WithEvents dgDistribute As System.Windows.Forms.DataGridView
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtMemo As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbActivity As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbCommonAccounts As System.Windows.Forms.ComboBox
    Friend WithEvents Link As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Memo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Activity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
