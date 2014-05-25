<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Divide
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
        Me.cmbTransact = New System.Windows.Forms.ComboBox
        Me.rbDeposit = New System.Windows.Forms.RadioButton
        Me.rbWithdraw = New System.Windows.Forms.RadioButton
        Me.btnProcess = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbTransact
        '
        Me.cmbTransact.FormattingEnabled = True
        Me.cmbTransact.Location = New System.Drawing.Point(26, 191)
        Me.cmbTransact.Name = "cmbTransact"
        Me.cmbTransact.Size = New System.Drawing.Size(685, 21)
        Me.cmbTransact.TabIndex = 0
        '
        'rbDeposit
        '
        Me.rbDeposit.AutoSize = True
        Me.rbDeposit.Checked = True
        Me.rbDeposit.Location = New System.Drawing.Point(334, 122)
        Me.rbDeposit.Name = "rbDeposit"
        Me.rbDeposit.Size = New System.Drawing.Size(66, 17)
        Me.rbDeposit.TabIndex = 1
        Me.rbDeposit.TabStop = True
        Me.rbDeposit.Text = "Deposits"
        Me.rbDeposit.UseVisualStyleBackColor = True
        '
        'rbWithdraw
        '
        Me.rbWithdraw.AutoSize = True
        Me.rbWithdraw.Location = New System.Drawing.Point(334, 151)
        Me.rbWithdraw.Name = "rbWithdraw"
        Me.rbWithdraw.Size = New System.Drawing.Size(77, 17)
        Me.rbWithdraw.TabIndex = 2
        Me.rbWithdraw.Text = "Withdrawls"
        Me.rbWithdraw.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(334, 253)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 3
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'Divide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 508)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.rbWithdraw)
        Me.Controls.Add(Me.rbDeposit)
        Me.Controls.Add(Me.cmbTransact)
        Me.Name = "Divide"
        Me.Text = "Divide"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTransact As System.Windows.Forms.ComboBox
    Friend WithEvents rbDeposit As System.Windows.Forms.RadioButton
    Friend WithEvents rbWithdraw As System.Windows.Forms.RadioButton
    Friend WithEvents btnProcess As System.Windows.Forms.Button
End Class
