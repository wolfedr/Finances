<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubView
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.OK_Button = New System.Windows.Forms.Button
        Me.dgvSub = New System.Windows.Forms.DataGridView
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.lblDGAmount = New System.Windows.Forms.Label
        Me.lblDgAccount = New System.Windows.Forms.Label
        CType(Me.dgvSub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(121, 238)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "CLOSE"
        '
        'dgvSub
        '
        Me.dgvSub.AllowUserToAddRows = False
        Me.dgvSub.AllowUserToDeleteRows = False
        Me.dgvSub.AllowUserToResizeColumns = False
        Me.dgvSub.AllowUserToResizeRows = False
        Me.dgvSub.BackgroundColor = System.Drawing.Color.White
        Me.dgvSub.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSub.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSub.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSub.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSub.Location = New System.Drawing.Point(12, 28)
        Me.dgvSub.Name = "dgvSub"
        Me.dgvSub.RowHeadersVisible = False
        Me.dgvSub.Size = New System.Drawing.Size(305, 185)
        Me.dgvSub.TabIndex = 1
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(126, 216)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(43, 19)
        Me.lblSubTotal.TabIndex = 2
        Me.lblSubTotal.Text = "Total"
        '
        'lblDGAmount
        '
        Me.lblDGAmount.AutoSize = True
        Me.lblDGAmount.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDGAmount.Location = New System.Drawing.Point(227, 9)
        Me.lblDGAmount.Name = "lblDGAmount"
        Me.lblDGAmount.Size = New System.Drawing.Size(46, 14)
        Me.lblDGAmount.TabIndex = 48
        Me.lblDGAmount.Text = "Amount"
        '
        'lblDgAccount
        '
        Me.lblDgAccount.AutoSize = True
        Me.lblDgAccount.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDgAccount.Location = New System.Drawing.Point(56, 9)
        Me.lblDgAccount.Name = "lblDgAccount"
        Me.lblDgAccount.Size = New System.Drawing.Size(67, 14)
        Me.lblDgAccount.TabIndex = 47
        Me.lblDgAccount.Text = "Sub Account"
        '
        'SubView
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 264)
        Me.Controls.Add(Me.lblDGAmount)
        Me.Controls.Add(Me.lblDgAccount)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.dgvSub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SubView"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Account Details"
        CType(Me.dgvSub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents dgvSub As System.Windows.Forms.DataGridView
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblDGAmount As System.Windows.Forms.Label
    Friend WithEvents lblDgAccount As System.Windows.Forms.Label

End Class
