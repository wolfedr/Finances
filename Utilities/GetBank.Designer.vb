<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetBank
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
        Me.grpBanks = New System.Windows.Forms.GroupBox
        Me.rbWachovia = New System.Windows.Forms.RadioButton
        Me.rbWellsFargo = New System.Windows.Forms.RadioButton
        Me.btnGo = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.grpBanks.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBanks
        '
        Me.grpBanks.Controls.Add(Me.rbWellsFargo)
        Me.grpBanks.Controls.Add(Me.rbWachovia)
        Me.grpBanks.Location = New System.Drawing.Point(60, 33)
        Me.grpBanks.Name = "grpBanks"
        Me.grpBanks.Size = New System.Drawing.Size(332, 85)
        Me.grpBanks.TabIndex = 0
        Me.grpBanks.TabStop = False
        Me.grpBanks.Text = "Bank Website Selection"
        '
        'rbWachovia
        '
        Me.rbWachovia.AutoSize = True
        Me.rbWachovia.Checked = True
        Me.rbWachovia.Location = New System.Drawing.Point(107, 30)
        Me.rbWachovia.Name = "rbWachovia"
        Me.rbWachovia.Size = New System.Drawing.Size(74, 17)
        Me.rbWachovia.TabIndex = 0
        Me.rbWachovia.TabStop = True
        Me.rbWachovia.Text = "Wachovia"
        Me.rbWachovia.UseVisualStyleBackColor = True
        '
        'rbWellsFargo
        '
        Me.rbWellsFargo.AutoSize = True
        Me.rbWellsFargo.Location = New System.Drawing.Point(107, 53)
        Me.rbWellsFargo.Name = "rbWellsFargo"
        Me.rbWellsFargo.Size = New System.Drawing.Size(81, 17)
        Me.rbWellsFargo.TabIndex = 1
        Me.rbWellsFargo.TabStop = True
        Me.rbWellsFargo.Text = "Wells Fargo"
        Me.rbWellsFargo.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(125, 124)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(218, 124)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GetBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 175)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.grpBanks)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GetBank"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GetBank"
        Me.grpBanks.ResumeLayout(False)
        Me.grpBanks.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBanks As System.Windows.Forms.GroupBox
    Friend WithEvents rbWellsFargo As System.Windows.Forms.RadioButton
    Friend WithEvents rbWachovia As System.Windows.Forms.RadioButton
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
