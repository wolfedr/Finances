<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptNonProfit
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvAccounts = New System.Windows.Forms.DataGridView
        Me.actName = New System.Windows.Forms.DataGridViewLinkColumn
        Me.account = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total1 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.lblNP = New System.Windows.Forms.Label
        Me.GrpType = New System.Windows.Forms.GroupBox
        Me.btnSelectActivity = New System.Windows.Forms.Button
        Me.lblBalance = New System.Windows.Forms.Label
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
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvAccounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvAccounts.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.actName, Me.account, Me.Total, Me.Total1})
        Me.dgvAccounts.Location = New System.Drawing.Point(299, 96)
        Me.dgvAccounts.Name = "dgvAccounts"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvAccounts.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAccounts.Size = New System.Drawing.Size(650, 443)
        Me.dgvAccounts.TabIndex = 1
        '
        'actName
        '
        Me.actName.HeaderText = "Account name"
        Me.actName.LinkColor = System.Drawing.Color.Black
        Me.actName.Name = "actName"
        Me.actName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.actName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.actName.Width = 340
        '
        'account
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.account.DefaultCellStyle = DataGridViewCellStyle3
        Me.account.HeaderText = "Account"
        Me.account.Name = "account"
        Me.account.Width = 50
        '
        'Total
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Total.DefaultCellStyle = DataGridViewCellStyle4
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'Total1
        '
        Me.Total1.HeaderText = "Total"
        Me.Total1.Name = "Total1"
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
        Me.btnClose.Location = New System.Drawing.Point(851, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close Window"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dtPick1
        '
        Me.dtPick1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPick1.Location = New System.Drawing.Point(1013, 70)
        Me.dtPick1.Name = "dtPick1"
        Me.dtPick1.Size = New System.Drawing.Size(98, 20)
        Me.dtPick1.TabIndex = 3
        '
        'dtPick2
        '
        Me.dtPick2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPick2.Location = New System.Drawing.Point(1013, 96)
        Me.dtPick2.Name = "dtPick2"
        Me.dtPick2.Size = New System.Drawing.Size(98, 20)
        Me.dtPick2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(978, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(978, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Stop"
        '
        'lblYTD
        '
        Me.lblYTD.AutoSize = True
        Me.lblYTD.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYTD.Location = New System.Drawing.Point(977, 157)
        Me.lblYTD.Name = "lblYTD"
        Me.lblYTD.Size = New System.Drawing.Size(106, 19)
        Me.lblYTD.TabIndex = 7
        Me.lblYTD.Text = "YEAR TO DATE"
        '
        'lblPrevYr
        '
        Me.lblPrevYr.AutoSize = True
        Me.lblPrevYr.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevYr.Location = New System.Drawing.Point(977, 187)
        Me.lblPrevYr.Name = "lblPrevYr"
        Me.lblPrevYr.Size = New System.Drawing.Size(116, 19)
        Me.lblPrevYr.TabIndex = 8
        Me.lblPrevYr.Text = "PREVIOUS YEAR"
        '
        'lblAll
        '
        Me.lblAll.AutoSize = True
        Me.lblAll.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAll.Location = New System.Drawing.Point(977, 413)
        Me.lblAll.Name = "lblAll"
        Me.lblAll.Size = New System.Drawing.Size(73, 19)
        Me.lblAll.TabIndex = 9
        Me.lblAll.Text = "ALL DATA"
        '
        'lblMTD
        '
        Me.lblMTD.AutoSize = True
        Me.lblMTD.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMTD.Location = New System.Drawing.Point(977, 219)
        Me.lblMTD.Name = "lblMTD"
        Me.lblMTD.Size = New System.Drawing.Size(125, 19)
        Me.lblMTD.TabIndex = 10
        Me.lblMTD.Text = "MONTH TO DATE"
        '
        'lblPrevM
        '
        Me.lblPrevM.AutoSize = True
        Me.lblPrevM.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevM.Location = New System.Drawing.Point(977, 250)
        Me.lblPrevM.Name = "lblPrevM"
        Me.lblPrevM.Size = New System.Drawing.Size(135, 19)
        Me.lblPrevM.TabIndex = 11
        Me.lblPrevM.Text = "PREVIOUS MONTH"
        '
        'lblLast12
        '
        Me.lblLast12.AutoSize = True
        Me.lblLast12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast12.Location = New System.Drawing.Point(977, 278)
        Me.lblLast12.Name = "lblLast12"
        Me.lblLast12.Size = New System.Drawing.Size(128, 19)
        Me.lblLast12.TabIndex = 12
        Me.lblLast12.Text = "LAST 12 MONTHS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1117, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "(Defaults to last 30 days!)"
        '
        'lblLast30
        '
        Me.lblLast30.AutoSize = True
        Me.lblLast30.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast30.Location = New System.Drawing.Point(977, 128)
        Me.lblLast30.Name = "lblLast30"
        Me.lblLast30.Size = New System.Drawing.Size(101, 19)
        Me.lblLast30.TabIndex = 14
        Me.lblLast30.Text = "LAST 30 DAYS"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(981, 453)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Data to Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgvExcel
        '
        Me.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcel.Location = New System.Drawing.Point(981, 525)
        Me.dgvExcel.Name = "dgvExcel"
        Me.dgvExcel.Size = New System.Drawing.Size(240, 150)
        Me.dgvExcel.TabIndex = 17
        Me.dgvExcel.Visible = False
        '
        'lblNP
        '
        Me.lblNP.AutoSize = True
        Me.lblNP.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNP.Location = New System.Drawing.Point(359, 29)
        Me.lblNP.Name = "lblNP"
        Me.lblNP.Size = New System.Drawing.Size(186, 26)
        Me.lblNP.TabIndex = 28
        Me.lblNP.Text = "Non Profit Expenses"
        '
        'GrpType
        '
        Me.GrpType.Location = New System.Drawing.Point(50, 102)
        Me.GrpType.Name = "GrpType"
        Me.GrpType.Size = New System.Drawing.Size(200, 524)
        Me.GrpType.TabIndex = 29
        Me.GrpType.TabStop = False
        Me.GrpType.Text = "Activity"
        '
        'btnSelectActivity
        '
        Me.btnSelectActivity.Location = New System.Drawing.Point(101, 56)
        Me.btnSelectActivity.Name = "btnSelectActivity"
        Me.btnSelectActivity.Size = New System.Drawing.Size(94, 23)
        Me.btnSelectActivity.TabIndex = 30
        Me.btnSelectActivity.Text = "Activity to View"
        Me.btnSelectActivity.UseVisualStyleBackColor = True
        '
        'lblBalance
        '
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(309, 542)
        Me.lblBalance.MaximumSize = New System.Drawing.Size(640, 30)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(640, 30)
        Me.lblBalance.TabIndex = 31
        '
        'rptNonProfit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1359, 746)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.btnSelectActivity)
        Me.Controls.Add(Me.GrpType)
        Me.Controls.Add(Me.lblNP)
        Me.Controls.Add(Me.dgvExcel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblLast30)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLast12)
        Me.Controls.Add(Me.lblPrevM)
        Me.Controls.Add(Me.lblMTD)
        Me.Controls.Add(Me.lblAll)
        Me.Controls.Add(Me.lblPrevYr)
        Me.Controls.Add(Me.lblYTD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtPick2)
        Me.Controls.Add(Me.dtPick1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "rptNonProfit"
        Me.Text = "Non Profit Expense Report"
        Me.Controls.SetChildIndex(Me.dgvAccounts, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.dtPick1, 0)
        Me.Controls.SetChildIndex(Me.dtPick2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblYTD, 0)
        Me.Controls.SetChildIndex(Me.lblPrevYr, 0)
        Me.Controls.SetChildIndex(Me.lblAll, 0)
        Me.Controls.SetChildIndex(Me.lblMTD, 0)
        Me.Controls.SetChildIndex(Me.lblPrevM, 0)
        Me.Controls.SetChildIndex(Me.lblLast12, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblLast30, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Controls.SetChildIndex(Me.dgvExcel, 0)
        Me.Controls.SetChildIndex(Me.lblNP, 0)
        Me.Controls.SetChildIndex(Me.GrpType, 0)
        Me.Controls.SetChildIndex(Me.btnSelectActivity, 0)
        Me.Controls.SetChildIndex(Me.lblBalance, 0)
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
    Friend WithEvents lblNP As System.Windows.Forms.Label
    Friend WithEvents GrpType As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelectActivity As System.Windows.Forms.Button
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents actName As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total1 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
