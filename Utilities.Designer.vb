<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Utilities
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
        Me.btnImportBusinesses = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnImportBusinesses
        '
        Me.btnImportBusinesses.Location = New System.Drawing.Point(246, 281)
        Me.btnImportBusinesses.Name = "btnImportBusinesses"
        Me.btnImportBusinesses.Size = New System.Drawing.Size(178, 23)
        Me.btnImportBusinesses.TabIndex = 1
        Me.btnImportBusinesses.Text = "Import New Businesses to Listing"
        Me.btnImportBusinesses.UseVisualStyleBackColor = True
        '
        'Utilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1118, 710)
        Me.Controls.Add(Me.btnImportBusinesses)
        Me.Name = "Utilities"
        Me.Text = " "
        Me.Controls.SetChildIndex(Me.btnImportBusinesses, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImportBusinesses As System.Windows.Forms.Button

End Class
