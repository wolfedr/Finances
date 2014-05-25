<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shortEdit
    Inherits baseform

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
        Me.txtEditItem = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtEditItem
        '
        Me.txtEditItem.Location = New System.Drawing.Point(371, 312)
        Me.txtEditItem.Name = "txtEditItem"
        Me.txtEditItem.Size = New System.Drawing.Size(169, 20)
        Me.txtEditItem.TabIndex = 28
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(403, 360)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'shortEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1118, 710)
        Me.Controls.Add(Me.txtEditItem)
        Me.Controls.Add(Me.btnSave)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "shortEdit"
        Me.Text = " "
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.txtEditItem, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEditItem As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
