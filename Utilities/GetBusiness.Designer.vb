<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetBusiness
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
        Me.ddlBusiness = New System.Windows.Forms.ComboBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.lblHdnAct = New System.Windows.Forms.Label
        Me.txtTemp = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'ddlBusiness
        '
        Me.ddlBusiness.FormattingEnabled = True
        Me.ddlBusiness.Location = New System.Drawing.Point(121, 92)
        Me.ddlBusiness.Name = "ddlBusiness"
        Me.ddlBusiness.Size = New System.Drawing.Size(218, 21)
        Me.ddlBusiness.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(182, 196)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(106, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close and Insert"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(182, 148)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add New Business"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblHdnAct
        '
        Me.lblHdnAct.AutoSize = True
        Me.lblHdnAct.Location = New System.Drawing.Point(418, 250)
        Me.lblHdnAct.Name = "lblHdnAct"
        Me.lblHdnAct.Size = New System.Drawing.Size(39, 13)
        Me.lblHdnAct.TabIndex = 3
        Me.lblHdnAct.Text = "Label1"
        Me.lblHdnAct.Visible = False
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(61, 242)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(100, 20)
        Me.txtTemp.TabIndex = 4
        Me.txtTemp.Text = "NoName"
        '
        'GetBusiness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 294)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.lblHdnAct)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ddlBusiness)
        Me.Name = "GetBusiness"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GetBusiness"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ddlBusiness As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblHdnAct As System.Windows.Forms.Label
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
End Class
