<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WBGetMorris
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblBrowse = New System.Windows.Forms.Label
        Me.txtReturnedInfo = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(843, 532)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.AllowNavigation = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        'Me.WebBrowser1.Url = New System.Uri("https://www.morrisstate.com/home/home", UriKind.Absolute)
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.BorderSize = 3
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(683, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(139, 50)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblBrowse
        '
        Me.lblBrowse.AutoSize = True
        Me.lblBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrowse.Location = New System.Drawing.Point(290, 13)
        Me.lblBrowse.Name = "lblBrowse"
        Me.lblBrowse.Size = New System.Drawing.Size(140, 20)
        Me.lblBrowse.TabIndex = 2
        Me.lblBrowse.Text = "Last Entry Date:"
        '
        'txtReturnedInfo
        '
        Me.txtReturnedInfo.Location = New System.Drawing.Point(272, 42)
        Me.txtReturnedInfo.Name = "txtReturnedInfo"
        Me.txtReturnedInfo.Size = New System.Drawing.Size(171, 20)
        Me.txtReturnedInfo.TabIndex = 3
        '
        'GetMorris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtReturnedInfo)
        Me.Controls.Add(Me.lblBrowse)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.WebBrowser1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GetMorris"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GetBank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblBrowse As System.Windows.Forms.Label
    Friend WithEvents txtReturnedInfo As System.Windows.Forms.TextBox
End Class
