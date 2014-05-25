<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsg
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
        Me.txtArea = New System.Windows.Forms.RichTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DsBasicFinancial1 = New Finances.dsBasicFinancial
        CType(Me.DsBasicFinancial1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtArea
        '
        Me.txtArea.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtArea.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(12, 4)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtArea.ShortcutsEnabled = False
        Me.txtArea.Size = New System.Drawing.Size(294, 96)
        Me.txtArea.TabIndex = 1
        Me.txtArea.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(123, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DsBasicFinancial1
        '
        Me.DsBasicFinancial1.DataSetName = "dsBasicFinancial"
        Me.DsBasicFinancial1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmMsg
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 141)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsg"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Message"
        CType(Me.DsBasicFinancial1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DsBasicFinancial1 As Finances.dsBasicFinancial
    Friend WithEvents txtArea As System.Windows.Forms.RichTextBox
End Class
