<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownLoadInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DownLoadInstructions))
        Me.pnlInstructions = New System.Windows.Forms.Panel
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.lblInstructions = New System.Windows.Forms.Label
        Me.pnlInstructions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlInstructions
        '
        Me.pnlInstructions.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInstructions.Controls.Add(Me.RichTextBox1)
        Me.pnlInstructions.Controls.Add(Me.lblInstructions)
        Me.pnlInstructions.Location = New System.Drawing.Point(11, -5)
        Me.pnlInstructions.Name = "pnlInstructions"
        Me.pnlInstructions.Size = New System.Drawing.Size(271, 277)
        Me.pnlInstructions.TabIndex = 29
        Me.pnlInstructions.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 31)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(263, 222)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(27, 15)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(184, 13)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Account Download Instructions"
        '
        'DownLoadInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 287)
        Me.Controls.Add(Me.pnlInstructions)
        Me.Name = "DownLoadInstructions"
        Me.Text = "DownLoadInstructions"
        Me.pnlInstructions.ResumeLayout(False)
        Me.pnlInstructions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlInstructions As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
End Class
