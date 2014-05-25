<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptIncExp_BU
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
        Me.actName = New System.Windows.Forms.DataGridViewLinkColumn
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
        Me.btnExportToExcel = New System.Windows.Forms.Button
        Me.dgvExcel = New System.Windows.Forms.DataGridView
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.cmbMonth = New System.Windows.Forms.ComboBox
        Me.lblMonth = New System.Windows.Forms.Label
        Me.lblYr = New System.Windows.Forms.Label
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.gbSelMonth = New System.Windows.Forms.GroupBox
        Me.btnMonth = New System.Windows.Forms.Button
        Me.gbCustom = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblReportPeriod = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.docAccounting = New System.Drawing.Printing.PrintDocument
        Me.dlgPring = New System.Windows.Forms.PrintDialog
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSelMonth.SuspendLayout()
        Me.gbCustom.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.AllowUserToResizeRows = False
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
        Me.dgvAccounts.Location = New System.Drawing.Point(79, 70)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.RowHeadersVisible = False
        Me.dgvAccounts.Size = New System.Drawing.Size(748, 712)
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
        Me.actName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        Me.btnClose.Location = New System.Drawing.Point(962, 639)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close "
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dtPick1
        '
        Me.dtPick1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPick1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPick1.Location = New System.Drawing.Point(978, 223)
        Me.dtPick1.Name = "dtPick1"
        Me.dtPick1.Size = New System.Drawing.Size(144, 33)
        Me.dtPick1.TabIndex = 3
        '
        'dtPick2
        '
        Me.dtPick2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPick2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPick2.Location = New System.Drawing.Point(978, 264)
        Me.dtPick2.Name = "dtPick2"
        Me.dtPick2.Size = New System.Drawing.Size(144, 33)
        Me.dtPick2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(916, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(919, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Stop"
        '
        'lblYTD
        '
        Me.lblYTD.AutoSize = True
        Me.lblYTD.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYTD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblYTD.Location = New System.Drawing.Point(36, 52)
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
        Me.lblPrevYr.Location = New System.Drawing.Point(31, 82)
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
        Me.lblAll.Location = New System.Drawing.Point(917, 665)
        Me.lblAll.Name = "lblAll"
        Me.lblAll.Size = New System.Drawing.Size(73, 19)
        Me.lblAll.TabIndex = 9
        Me.lblAll.Text = "ALL DATA"
        Me.lblAll.Visible = False
        '
        'lblMTD
        '
        Me.lblMTD.AutoSize = True
        Me.lblMTD.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMTD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMTD.Location = New System.Drawing.Point(27, 114)
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
        Me.lblPrevM.Location = New System.Drawing.Point(22, 145)
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
        Me.lblLast12.Location = New System.Drawing.Point(25, 173)
        Me.lblLast12.Name = "lblLast12"
        Me.lblLast12.Size = New System.Drawing.Size(128, 19)
        Me.lblLast12.TabIndex = 12
        Me.lblLast12.Text = "LAST 12 MONTHS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(928, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "(Defaults to last 30 days!)"
        '
        'lblLast30
        '
        Me.lblLast30.AutoSize = True
        Me.lblLast30.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLast30.Location = New System.Drawing.Point(39, 23)
        Me.lblLast30.Name = "lblLast30"
        Me.lblLast30.Size = New System.Drawing.Size(101, 19)
        Me.lblLast30.TabIndex = 14
        Me.lblLast30.Text = "LAST 30 DAYS"
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.Location = New System.Drawing.Point(962, 610)
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Size = New System.Drawing.Size(94, 23)
        Me.btnExportToExcel.TabIndex = 16
        Me.btnExportToExcel.Text = "Data to Excel"
        Me.btnExportToExcel.UseVisualStyleBackColor = True
        '
        'dgvExcel
        '
        Me.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcel.Location = New System.Drawing.Point(898, 687)
        Me.dgvExcel.Name = "dgvExcel"
        Me.dgvExcel.Size = New System.Drawing.Size(198, 10)
        Me.dgvExcel.TabIndex = 17
        Me.dgvExcel.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(38, 195)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(109, 23)
        Me.btnRefresh.TabIndex = 28
        Me.btnRefresh.Text = "Activate Selection"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'cmbMonth
        '
        Me.cmbMonth.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(6, 53)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 27)
        Me.cmbMonth.TabIndex = 29
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(138, 56)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(56, 19)
        Me.lblMonth.TabIndex = 30
        Me.lblMonth.Text = "Month"
        '
        'lblYr
        '
        Me.lblYr.AutoSize = True
        Me.lblYr.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYr.Location = New System.Drawing.Point(138, 22)
        Me.lblYr.Name = "lblYr"
        Me.lblYr.Size = New System.Drawing.Size(38, 19)
        Me.lblYr.TabIndex = 32
        Me.lblYr.Text = "Year"
        '
        'cmbYear
        '
        Me.cmbYear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2014", "2013", "2012", "2011", "2010"})
        Me.cmbYear.Location = New System.Drawing.Point(6, 19)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 27)
        Me.cmbYear.TabIndex = 31
        '
        'gbSelMonth
        '
        Me.gbSelMonth.Controls.Add(Me.btnMonth)
        Me.gbSelMonth.Controls.Add(Me.cmbYear)
        Me.gbSelMonth.Controls.Add(Me.cmbMonth)
        Me.gbSelMonth.Controls.Add(Me.lblMonth)
        Me.gbSelMonth.Controls.Add(Me.lblYr)
        Me.gbSelMonth.Location = New System.Drawing.Point(932, 29)
        Me.gbSelMonth.Name = "gbSelMonth"
        Me.gbSelMonth.Size = New System.Drawing.Size(200, 120)
        Me.gbSelMonth.TabIndex = 33
        Me.gbSelMonth.TabStop = False
        Me.gbSelMonth.Text = "Select Month"
        '
        'btnMonth
        '
        Me.btnMonth.Location = New System.Drawing.Point(40, 86)
        Me.btnMonth.Name = "btnMonth"
        Me.btnMonth.Size = New System.Drawing.Size(117, 23)
        Me.btnMonth.TabIndex = 33
        Me.btnMonth.Text = "Activate Selection"
        Me.btnMonth.UseVisualStyleBackColor = True
        '
        'gbCustom
        '
        Me.gbCustom.Controls.Add(Me.lblMTD)
        Me.gbCustom.Controls.Add(Me.lblYTD)
        Me.gbCustom.Controls.Add(Me.btnRefresh)
        Me.gbCustom.Controls.Add(Me.lblPrevYr)
        Me.gbCustom.Controls.Add(Me.lblPrevM)
        Me.gbCustom.Controls.Add(Me.lblLast30)
        Me.gbCustom.Controls.Add(Me.lblLast12)
        Me.gbCustom.Location = New System.Drawing.Point(922, 328)
        Me.gbCustom.Name = "gbCustom"
        Me.gbCustom.Size = New System.Drawing.Size(200, 236)
        Me.gbCustom.TabIndex = 34
        Me.gbCustom.TabStop = False
        Me.gbCustom.Text = "Select Custom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(176, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 19)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Income and Expense Reports"
        '
        'lblReportPeriod
        '
        Me.lblReportPeriod.AutoSize = True
        Me.lblReportPeriod.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportPeriod.Location = New System.Drawing.Point(433, 48)
        Me.lblReportPeriod.Name = "lblReportPeriod"
        Me.lblReportPeriod.Size = New System.Drawing.Size(88, 19)
        Me.lblReportPeriod.TabIndex = 36
        Me.lblReportPeriod.Text = """unknown"""
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(965, 581)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 37
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'docAccounting
        '
        Me.docAccounting.DocumentName = "Income_Expense"
        '
        'dlgPring
        '
        Me.dlgPring.Document = Me.docAccounting
        Me.dlgPring.UseEXDialog = True
        '
        'rptIncExp
        '
        Me.AcceptButton = Me.btnRefresh
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1278, 794)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblReportPeriod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbCustom)
        Me.Controls.Add(Me.gbSelMonth)
        Me.Controls.Add(Me.btnExportToExcel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvExcel)
        Me.Controls.Add(Me.lblAll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtPick2)
        Me.Controls.Add(Me.dtPick1)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.btnClose)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "rptIncExp"
        Me.Text = "Basic Report"
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.dgvAccounts, 0)
        Me.Controls.SetChildIndex(Me.dtPick1, 0)
        Me.Controls.SetChildIndex(Me.dtPick2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblAll, 0)
        Me.Controls.SetChildIndex(Me.dgvExcel, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.btnExportToExcel, 0)
        Me.Controls.SetChildIndex(Me.gbSelMonth, 0)
        Me.Controls.SetChildIndex(Me.gbCustom, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.lblReportPeriod, 0)
        Me.Controls.SetChildIndex(Me.btnPrint, 0)
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSelMonth.ResumeLayout(False)
        Me.gbSelMonth.PerformLayout()
        Me.gbCustom.ResumeLayout(False)
        Me.gbCustom.PerformLayout()
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
    Friend WithEvents btnExportToExcel As System.Windows.Forms.Button
    Friend WithEvents dgvExcel As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actName As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents actDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents spacer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblYr As System.Windows.Forms.Label
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents gbSelMonth As System.Windows.Forms.GroupBox
    Friend WithEvents gbCustom As System.Windows.Forms.GroupBox
    Friend WithEvents btnMonth As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblReportPeriod As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents docAccounting As System.Drawing.Printing.PrintDocument
    Friend WithEvents dlgPring As System.Windows.Forms.PrintDialog

End Class
