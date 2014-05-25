<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptBusDetail
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
        Me.dgvActDetail = New System.Windows.Forms.DataGridView
        Me.jnlID = New System.Windows.Forms.DataGridViewLinkColumn
        Me.Account = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.anount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.busName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tranDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblAccountName = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        CType(Me.dgvActDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvActDetail
        '
        Me.dgvActDetail.AllowUserToAddRows = False
        Me.dgvActDetail.AllowUserToDeleteRows = False
        Me.dgvActDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jnlID, Me.Account, Me.actName, Me.anount, Me.busName, Me.tranDate})
        Me.dgvActDetail.Location = New System.Drawing.Point(12, 69)
        Me.dgvActDetail.Name = "dgvActDetail"
        Me.dgvActDetail.Size = New System.Drawing.Size(811, 612)
        Me.dgvActDetail.TabIndex = 0
        '
        'jnlID
        '
        Me.jnlID.DataPropertyName = "jnlID"
        Me.jnlID.HeaderText = "View"
        Me.jnlID.Name = "jnlID"
        Me.jnlID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.jnlID.Text = "View"
        Me.jnlID.Width = 50
        '
        'Account
        '
        Me.Account.HeaderText = "Account "
        Me.Account.Name = "Account"
        Me.Account.Width = 70
        '
        'actName
        '
        Me.actName.HeaderText = "Name"
        Me.actName.Name = "actName"
        Me.actName.Width = 250
        '
        'anount
        '
        Me.anount.HeaderText = "Amount"
        Me.anount.Name = "anount"
        '
        'busName
        '
        Me.busName.HeaderText = "Business/Individual"
        Me.busName.Name = "busName"
        Me.busName.Width = 200
        '
        'tranDate
        '
        Me.tranDate.HeaderText = " Date"
        Me.tranDate.Name = "tranDate"
        '
        'lblAccountName
        '
        Me.lblAccountName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountName.Location = New System.Drawing.Point(182, 9)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(486, 47)
        Me.lblAccountName.TabIndex = 1
        Me.lblAccountName.Text = "xx"
        Me.lblAccountName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(376, 69)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close Window"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'rptBusDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 776)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.dgvActDetail)
        Me.Name = "rptBusDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rptDetail"
        CType(Me.dgvActDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvActDetail As System.Windows.Forms.DataGridView
    Friend WithEvents lblAccountName As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents jnlID As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents anount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents busName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tranDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
