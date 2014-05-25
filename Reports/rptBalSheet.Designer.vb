<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptBalSheet
    Inherits Finances.baseform

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvAccounts = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.account = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.spacer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ds = New System.Data.DataSet
        Me.dt = New System.Data.DataTable
        Me.btnClose = New System.Windows.Forms.Button
        Me.dtPick1 = New System.Windows.Forms.DateTimePicker
        Me.dtPick2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblYTD = New System.Windows.Forms.Label
        Me.lblPrevYr = New System.Windows.Forms.Label
        Me.lblAll = New System.Windows.Forms.Label
        Me.lblMTD = New System.Windows.Forms.Label
        Me.lblPrevM = New System.Windows.Forms.Label
        Me.lblLast12 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblLast30 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.dgvExcel = New System.Windows.Forms.DataGridView
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.lblAmt = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lblEffectiveDte = New System.Windows.Forms.Label
        Me.txtEffectiveDte = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ddlActivity = New System.Windows.Forms.ComboBox
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.actName, Me.actDescription, Me.account, Me.Total, Me.spacer})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAccounts.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAccounts.Location = New System.Drawing.Point(160, 61)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.Size = New System.Drawing.Size(715, 360)
        Me.dgvAccounts.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = " Category"
        Me.Column1.MinimumWidth = 80
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 80
        '
        'actName
        '
        Me.actName.HeaderText = "Account name"
        Me.actName.MinimumWidth = 180
        Me.actName.Name = "actName"
        Me.actName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.actName.Width = 180
        '
        'actDescription
        '
        Me.actDescription.HeaderText = "Description"
        Me.actDescription.MinimumWidth = 260
        Me.actDescription.Name = "actDescription"
        Me.actDescription.Width = 260
        '
        'account
        '
        Me.account.HeaderText = "Account"
        Me.account.MinimumWidth = 50
        Me.account.Name = "account"
        Me.account.Width = 50
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 70
        Me.Total.Name = "Total"
        Me.Total.Width = 70
        '
        'spacer
        '
        Me.spacer.HeaderText = " "
        Me.spacer.Name = "spacer"
        '
        'ds
        '
        Me.ds.DataSetName = "NewDataSet"
        Me.ds.Tables.AddRange(New System.Data.DataTable() {Me.dt})
        '
        'dt
        '
        Me.dt.TableName = "dt"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(435, 33)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close Window"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dtPick1
        '
        Me.dtPick1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPick1.Location = New System.Drawing.Point(956, 61)
        Me.dtPick1.Name = "dtPick1"
        Me.dtPick1.Size = New System.Drawing.Size(98, 20)
        Me.dtPick1.TabIndex = 3
        '
        'dtPick2
        '
        Me.dtPick2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPick2.Location = New System.Drawing.Point(956, 87)
        Me.dtPick2.Name = "dtPick2"
        Me.dtPick2.Size = New System.Drawing.Size(98, 20)
        Me.dtPick2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(952, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(952, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Stop"
        '
        'lblYTD
        '
        Me.lblYTD.AutoSize = True
        Me.lblYTD.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYTD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblYTD.Location = New System.Drawing.Point(951, 146)
        Me.lblYTD.Name = "lblYTD"
        Me.lblYTD.Size = New System.Drawing.Size(106, 19)
        Me.lblYTD.TabIndex = 7
        Me.lblYTD.Text = "YEAR TO DATE"
        '
        'lblPrevYr
        '
        Me.lblPrevYr.AutoSize = True
        Me.lblPrevYr.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevYr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrevYr.Location = New System.Drawing.Point(951, 176)
        Me.lblPrevYr.Name = "lblPrevYr"
        Me.lblPrevYr.Size = New System.Drawing.Size(116, 19)
        Me.lblPrevYr.TabIndex = 8
        Me.lblPrevYr.Text = "PREVIOUS YEAR"
        '
        'lblAll
        '
        Me.lblAll.AutoSize = True
        Me.lblAll.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAll.Location = New System.Drawing.Point(951, 402)
        Me.lblAll.Name = "lblAll"
        Me.lblAll.Size = New System.Drawing.Size(73, 19)
        Me.lblAll.TabIndex = 9
        Me.lblAll.Text = "ALL DATA"
        '
        'lblMTD
        '
        Me.lblMTD.AutoSize = True
        Me.lblMTD.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMTD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMTD.Location = New System.Drawing.Point(951, 208)
        Me.lblMTD.Name = "lblMTD"
        Me.lblMTD.Size = New System.Drawing.Size(125, 19)
        Me.lblMTD.TabIndex = 10
        Me.lblMTD.Text = "MONTH TO DATE"
        '
        'lblPrevM
        '
        Me.lblPrevM.AutoSize = True
        Me.lblPrevM.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrevM.Location = New System.Drawing.Point(951, 239)
        Me.lblPrevM.Name = "lblPrevM"
        Me.lblPrevM.Size = New System.Drawing.Size(135, 19)
        Me.lblPrevM.TabIndex = 11
        Me.lblPrevM.Text = "PREVIOUS MONTH"
        '
        'lblLast12
        '
        Me.lblLast12.AutoSize = True
        Me.lblLast12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLast12.Location = New System.Drawing.Point(951, 267)
        Me.lblLast12.Name = "lblLast12"
        Me.lblLast12.Size = New System.Drawing.Size(128, 19)
        Me.lblLast12.TabIndex = 12
        Me.lblLast12.Text = "LAST 12 MONTHS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(953, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "(Defaults to last 30 days!)"
        '
        'lblLast30
        '
        Me.lblLast30.AutoSize = True
        Me.lblLast30.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLast30.Location = New System.Drawing.Point(951, 117)
        Me.lblLast30.Name = "lblLast30"
        Me.lblLast30.Size = New System.Drawing.Size(101, 19)
        Me.lblLast30.TabIndex = 14
        Me.lblLast30.Text = "LAST 30 DAYS"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(43, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Data to Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgvExcel
        '
        Me.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcel.Location = New System.Drawing.Point(913, 424)
        Me.dgvExcel.Name = "dgvExcel"
        Me.dgvExcel.Size = New System.Drawing.Size(240, 150)
        Me.dgvExcel.TabIndex = 17
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(398, 437)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 28
        '
        'lblAmt
        '
        Me.lblAmt.AutoSize = True
        Me.lblAmt.Location = New System.Drawing.Point(339, 440)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(43, 13)
        Me.lblAmt.TabIndex = 29
        Me.lblAmt.Text = "Amount"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(157, 440)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 31
        Me.lblDescription.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(222, 433)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 30
        '
        'lblEffectiveDte
        '
        Me.lblEffectiveDte.AutoSize = True
        Me.lblEffectiveDte.Location = New System.Drawing.Point(516, 444)
        Me.lblEffectiveDte.Name = "lblEffectiveDte"
        Me.lblEffectiveDte.Size = New System.Drawing.Size(81, 13)
        Me.lblEffectiveDte.TabIndex = 33
        Me.lblEffectiveDte.Text = "Effeective Date"
        '
        'txtEffectiveDte
        '
        Me.txtEffectiveDte.Location = New System.Drawing.Point(629, 441)
        Me.txtEffectiveDte.Name = "txtEffectiveDte"
        Me.txtEffectiveDte.Size = New System.Drawing.Size(100, 20)
        Me.txtEffectiveDte.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(452, 495)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Related Activity"
        '
        'ddlActivity
        '
        Me.ddlActivity.FormattingEnabled = True
        Me.ddlActivity.Location = New System.Drawing.Point(549, 487)
        Me.ddlActivity.Name = "ddlActivity"
        Me.ddlActivity.Size = New System.Drawing.Size(180, 21)
        Me.ddlActivity.TabIndex = 36
        '
        'rptBalSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1162, 586)
        Me.Controls.Add(Me.ddlActivity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblEffectiveDte)
        Me.Controls.Add(Me.txtEffectiveDte)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblAmt)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblLast30)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLast12)
        Me.Controls.Add(Me.dgvExcel)
        Me.Controls.Add(Me.lblPrevM)
        Me.Controls.Add(Me.lblMTD)
        Me.Controls.Add(Me.lblAll)
        Me.Controls.Add(Me.lblPrevYr)
        Me.Controls.Add(Me.lblYTD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtPick2)
        Me.Controls.Add(Me.dtPick1)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.btnClose)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "rptBalSheet"
        Me.Text = "Basic Report"
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.dgvAccounts, 0)
        Me.Controls.SetChildIndex(Me.dtPick1, 0)
        Me.Controls.SetChildIndex(Me.dtPick2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblYTD, 0)
        Me.Controls.SetChildIndex(Me.lblPrevYr, 0)
        Me.Controls.SetChildIndex(Me.lblAll, 0)
        Me.Controls.SetChildIndex(Me.lblMTD, 0)
        Me.Controls.SetChildIndex(Me.lblPrevM, 0)
        Me.Controls.SetChildIndex(Me.dgvExcel, 0)
        Me.Controls.SetChildIndex(Me.lblLast12, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblLast30, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Controls.SetChildIndex(Me.txtAmount, 0)
        Me.Controls.SetChildIndex(Me.lblAmt, 0)
        Me.Controls.SetChildIndex(Me.txtDescription, 0)
        Me.Controls.SetChildIndex(Me.lblDescription, 0)
        Me.Controls.SetChildIndex(Me.txtEffectiveDte, 0)
        Me.Controls.SetChildIndex(Me.lblEffectiveDte, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.ddlActivity, 0)
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents ds As System.Data.DataSet
    Friend WithEvents dt As System.Data.DataTable
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dtPick1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPick2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblYTD As System.Windows.Forms.Label
    Friend WithEvents lblPrevYr As System.Windows.Forms.Label
    Friend WithEvents lblAll As System.Windows.Forms.Label
    Friend WithEvents lblMTD As System.Windows.Forms.Label
    Friend WithEvents lblPrevM As System.Windows.Forms.Label
    Friend WithEvents lblLast12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLast30 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgvExcel As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents spacer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblAmt As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblEffectiveDte As System.Windows.Forms.Label
    Friend WithEvents txtEffectiveDte As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ddlActivity As System.Windows.Forms.ComboBox

End Class
