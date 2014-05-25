<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptDetail
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvActDetail = New System.Windows.Forms.DataGridView
        Me.lblAccountName = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.jnlID = New System.Windows.Forms.DataGridViewLinkColumn
        Me.Account = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.anount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.busName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tranDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvActDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvActDetail
        '
        Me.dgvActDetail.AllowUserToAddRows = False
        Me.dgvActDetail.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvActDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jnlID, Me.Account, Me.actName, Me.anount, Me.busName, Me.tranDate})
        Me.dgvActDetail.Location = New System.Drawing.Point(35, 98)
        Me.dgvActDetail.Name = "dgvActDetail"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvActDetail.Size = New System.Drawing.Size(794, 612)
        Me.dgvActDetail.TabIndex = 0
        '
        'lblAccountName
        '
        Me.lblAccountName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountName.Location = New System.Drawing.Point(182, 24)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(486, 20)
        Me.lblAccountName.TabIndex = 1
        Me.lblAccountName.Text = "xx"
        Me.lblAccountName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(376, 59)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close Window"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'jnlID
        '
        Me.jnlID.DataPropertyName = "jnlID"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText
        Me.jnlID.DefaultCellStyle = DataGridViewCellStyle2
        Me.jnlID.HeaderText = "View"
        Me.jnlID.Name = "jnlID"
        Me.jnlID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.jnlID.Text = "View"
        Me.jnlID.Width = 50
        '
        'Account
        '
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText
        Me.Account.DefaultCellStyle = DataGridViewCellStyle3
        Me.Account.HeaderText = "Account "
        Me.Account.Name = "Account"
        Me.Account.Width = 70
        '
        'actName
        '
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GrayText
        Me.actName.DefaultCellStyle = DataGridViewCellStyle4
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
        'rptDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 698)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.dgvActDetail)
        Me.Name = "rptDetail"
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
