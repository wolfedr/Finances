<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptMonthlyBase
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.MonthlyReport1 = New Finances.MonthlyReport
        Me.btnClose = New System.Windows.Forms.Button
        Me.grpViews = New System.Windows.Forms.GroupBox
        Me.rbSub = New System.Windows.Forms.RadioButton
        Me.rbMaster = New System.Windows.Forms.RadioButton
        Me.rbBusiness = New System.Windows.Forms.RadioButton
        Me.grpViews.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.EnableDrillDown = False
        Me.CrystalReportViewer1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrystalReportViewer1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(37, 44)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1396, 762)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(867, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpViews
        '
        Me.grpViews.Controls.Add(Me.rbSub)
        Me.grpViews.Controls.Add(Me.rbMaster)
        Me.grpViews.Controls.Add(Me.rbBusiness)
        Me.grpViews.Location = New System.Drawing.Point(461, 3)
        Me.grpViews.Name = "grpViews"
        Me.grpViews.Size = New System.Drawing.Size(305, 35)
        Me.grpViews.TabIndex = 3
        Me.grpViews.TabStop = False
        Me.grpViews.Text = "Business Views"
        '
        'rbSub
        '
        Me.rbSub.AutoSize = True
        Me.rbSub.Location = New System.Drawing.Point(210, 12)
        Me.rbSub.Name = "rbSub"
        Me.rbSub.Size = New System.Drawing.Size(87, 17)
        Me.rbSub.TabIndex = 4
        Me.rbSub.Text = "Sub Account"
        Me.rbSub.UseVisualStyleBackColor = True
        '
        'rbMaster
        '
        Me.rbMaster.AutoSize = True
        Me.rbMaster.Location = New System.Drawing.Point(90, 12)
        Me.rbMaster.Name = "rbMaster"
        Me.rbMaster.Size = New System.Drawing.Size(100, 17)
        Me.rbMaster.TabIndex = 1
        Me.rbMaster.Text = "Master Account"
        Me.rbMaster.UseVisualStyleBackColor = True
        '
        'rbBusiness
        '
        Me.rbBusiness.AutoSize = True
        Me.rbBusiness.Checked = True
        Me.rbBusiness.Location = New System.Drawing.Point(7, 12)
        Me.rbBusiness.Name = "rbBusiness"
        Me.rbBusiness.Size = New System.Drawing.Size(67, 17)
        Me.rbBusiness.TabIndex = 0
        Me.rbBusiness.TabStop = True
        Me.rbBusiness.Text = "Business"
        Me.rbBusiness.UseVisualStyleBackColor = True
        '
        'rptMonthlyBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1475, 806)
        Me.Controls.Add(Me.grpViews)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "rptMonthlyBase"
        Me.Text = "rptMonthly"
        Me.grpViews.ResumeLayout(False)
        Me.grpViews.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MonthlyReport1 As Finances.MonthlyReport
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grpViews As System.Windows.Forms.GroupBox
    Friend WithEvents rbSub As System.Windows.Forms.RadioButton
    Friend WithEvents rbMaster As System.Windows.Forms.RadioButton
    Friend WithEvents rbBusiness As System.Windows.Forms.RadioButton
End Class
