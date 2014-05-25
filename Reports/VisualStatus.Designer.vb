<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisualStatus
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mccTracking = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.fraChart = New System.Windows.Forms.GroupBox
        Me.lblPeriod = New System.Windows.Forms.Label
        Me.lblDetailTotal = New System.Windows.Forms.Label
        Me.lblDGAmount = New System.Windows.Forms.Label
        Me.lblDgAccount = New System.Windows.Forms.Label
        Me.dgvDetails = New System.Windows.Forms.DataGridView
        Me.xname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Month = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblAccount = New System.Windows.Forms.Label
        Me.lblLast30 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblLast12 = New System.Windows.Forms.Label
        Me.lblPrevM = New System.Windows.Forms.Label
        Me.lblMTD = New System.Windows.Forms.Label
        Me.lblPrevYr = New System.Windows.Forms.Label
        Me.lblYTD = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtPick2 = New System.Windows.Forms.DateTimePicker
        Me.dtPick1 = New System.Windows.Forms.DateTimePicker
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbAccount = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbSubAcct = New System.Windows.Forms.ComboBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        CType(Me.mccTracking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraChart.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mccTracking
        '
        Me.mccTracking.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mccTracking.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mccTracking.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.mccTracking.BorderlineWidth = 2
        Me.mccTracking.BorderSkin.BackColor = System.Drawing.Color.Black
        Me.mccTracking.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mccTracking.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.mccTracking.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss
        ChartArea1.Area3DStyle.IsClustered = True
        ChartArea1.Area3DStyle.PointDepth = 25
        ChartArea1.Area3DStyle.PointGapDepth = 25
        ChartArea1.Area3DStyle.WallWidth = 10
        ChartArea1.AxisX.Title = "Month"
        ChartArea1.AxisY.ScaleView.Zoomable = False
        ChartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea1.AxisY.Title = "Amounts"
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea1.BackSecondaryColor = System.Drawing.Color.Thistle
        ChartArea1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.BorderWidth = 2
        ChartArea1.CursorX.IsUserEnabled = True
        ChartArea1.CursorX.IsUserSelectionEnabled = True
        ChartArea1.CursorY.IsUserEnabled = True
        ChartArea1.CursorY.IsUserSelectionEnabled = True
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowOffset = 3
        Me.mccTracking.ChartAreas.Add(ChartArea1)
        Me.mccTracking.Location = New System.Drawing.Point(286, 32)
        Me.mccTracking.Name = "mccTracking"
        Me.mccTracking.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter
        Series1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.BorderColor = System.Drawing.Color.Purple
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Series1.IsValueShownAsLabel = True
        Series1.IsXValueIndexed = True
        Series1.LabelAngle = 90
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.ShadowOffset = 5
        Me.mccTracking.Series.Add(Series1)
        Me.mccTracking.Size = New System.Drawing.Size(753, 452)
        Me.mccTracking.TabIndex = 37
        Me.mccTracking.Text = "Chart1"
        '
        'fraChart
        '
        Me.fraChart.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.fraChart.Controls.Add(Me.lblPeriod)
        Me.fraChart.Controls.Add(Me.lblDetailTotal)
        Me.fraChart.Controls.Add(Me.lblDGAmount)
        Me.fraChart.Controls.Add(Me.lblDgAccount)
        Me.fraChart.Controls.Add(Me.dgvDetails)
        Me.fraChart.Controls.Add(Me.lblAccount)
        Me.fraChart.Controls.Add(Me.mccTracking)
        Me.fraChart.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.fraChart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraChart.Location = New System.Drawing.Point(10, 90)
        Me.fraChart.Margin = New System.Windows.Forms.Padding(1)
        Me.fraChart.Name = "fraChart"
        Me.fraChart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraChart.Size = New System.Drawing.Size(1045, 484)
        Me.fraChart.TabIndex = 42
        Me.fraChart.TabStop = False
        Me.fraChart.Text = "Chart"
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPeriod.Location = New System.Drawing.Point(109, 18)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(62, 23)
        Me.lblPeriod.TabIndex = 61
        Me.lblPeriod.Text = "Period"
        '
        'lblDetailTotal
        '
        Me.lblDetailTotal.AutoSize = True
        Me.lblDetailTotal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDetailTotal.Location = New System.Drawing.Point(110, 461)
        Me.lblDetailTotal.Name = "lblDetailTotal"
        Me.lblDetailTotal.Size = New System.Drawing.Size(38, 18)
        Me.lblDetailTotal.TabIndex = 48
        Me.lblDetailTotal.Text = "Total"
        '
        'lblDGAmount
        '
        Me.lblDGAmount.AutoSize = True
        Me.lblDGAmount.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDGAmount.Location = New System.Drawing.Point(180, 48)
        Me.lblDGAmount.Name = "lblDGAmount"
        Me.lblDGAmount.Size = New System.Drawing.Size(46, 14)
        Me.lblDGAmount.TabIndex = 46
        Me.lblDGAmount.Text = "Amount"
        '
        'lblDgAccount
        '
        Me.lblDgAccount.AutoSize = True
        Me.lblDgAccount.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDgAccount.Location = New System.Drawing.Point(53, 48)
        Me.lblDgAccount.Name = "lblDgAccount"
        Me.lblDgAccount.Size = New System.Drawing.Size(46, 14)
        Me.lblDgAccount.TabIndex = 45
        Me.lblDgAccount.Text = "Account"
        '
        'dgvDetails
        '
        Me.dgvDetails.AllowUserToAddRows = False
        Me.dgvDetails.AllowUserToDeleteRows = False
        Me.dgvDetails.AllowUserToResizeColumns = False
        Me.dgvDetails.AllowUserToResizeRows = False
        Me.dgvDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.ColumnHeadersVisible = False
        Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.xname, Me.Amount, Me.Column1, Me.Month})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetails.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDetails.Location = New System.Drawing.Point(18, 65)
        Me.dgvDetails.MultiSelect = False
        Me.dgvDetails.Name = "dgvDetails"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDetails.RowHeadersVisible = False
        Me.dgvDetails.Size = New System.Drawing.Size(251, 393)
        Me.dgvDetails.TabIndex = 44
        '
        'xname
        '
        Me.xname.DataPropertyName = "cname"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xname.DefaultCellStyle = DataGridViewCellStyle2
        Me.xname.HeaderText = ""
        Me.xname.Name = "xname"
        Me.xname.Width = 160
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "tot"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle3
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 70
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "actNum"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column1.HeaderText = "Account"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        Me.Column1.Width = 20
        '
        'Month
        '
        Me.Month.DataPropertyName = "myMonth"
        Me.Month.HeaderText = "Month"
        Me.Month.Name = "Month"
        Me.Month.Visible = False
        Me.Month.Width = 10
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(437, 18)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(69, 26)
        Me.lblAccount.TabIndex = 43
        Me.lblAccount.Text = "Label1"
        '
        'lblLast30
        '
        Me.lblLast30.AutoSize = True
        Me.lblLast30.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLast30.Location = New System.Drawing.Point(1077, 249)
        Me.lblLast30.Name = "lblLast30"
        Me.lblLast30.Size = New System.Drawing.Size(101, 19)
        Me.lblLast30.TabIndex = 53
        Me.lblLast30.Text = "LAST 30 DAYS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1078, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 15)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "(Defaults to last 30 days!)"
        '
        'lblLast12
        '
        Me.lblLast12.AutoSize = True
        Me.lblLast12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLast12.Location = New System.Drawing.Point(1077, 390)
        Me.lblLast12.Name = "lblLast12"
        Me.lblLast12.Size = New System.Drawing.Size(128, 19)
        Me.lblLast12.TabIndex = 51
        Me.lblLast12.Text = "LAST 12 MONTHS"
        '
        'lblPrevM
        '
        Me.lblPrevM.AutoSize = True
        Me.lblPrevM.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPrevM.Location = New System.Drawing.Point(1077, 364)
        Me.lblPrevM.Name = "lblPrevM"
        Me.lblPrevM.Size = New System.Drawing.Size(135, 19)
        Me.lblPrevM.TabIndex = 50
        Me.lblPrevM.Text = "PREVIOUS MONTH"
        '
        'lblMTD
        '
        Me.lblMTD.AutoSize = True
        Me.lblMTD.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMTD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMTD.Location = New System.Drawing.Point(1077, 335)
        Me.lblMTD.Name = "lblMTD"
        Me.lblMTD.Size = New System.Drawing.Size(125, 19)
        Me.lblMTD.TabIndex = 49
        Me.lblMTD.Text = "MONTH TO DATE"
        '
        'lblPrevYr
        '
        Me.lblPrevYr.AutoSize = True
        Me.lblPrevYr.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevYr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPrevYr.Location = New System.Drawing.Point(1077, 305)
        Me.lblPrevYr.Name = "lblPrevYr"
        Me.lblPrevYr.Size = New System.Drawing.Size(116, 19)
        Me.lblPrevYr.TabIndex = 48
        Me.lblPrevYr.Text = "PREVIOUS YEAR"
        '
        'lblYTD
        '
        Me.lblYTD.AutoSize = True
        Me.lblYTD.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYTD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblYTD.Location = New System.Drawing.Point(1077, 277)
        Me.lblYTD.Name = "lblYTD"
        Me.lblYTD.Size = New System.Drawing.Size(106, 19)
        Me.lblYTD.TabIndex = 47
        Me.lblYTD.Text = "YEAR TO DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1078, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Stop"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1078, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Start"
        '
        'dtPick2
        '
        Me.dtPick2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPick2.Location = New System.Drawing.Point(1113, 219)
        Me.dtPick2.Name = "dtPick2"
        Me.dtPick2.Size = New System.Drawing.Size(98, 23)
        Me.dtPick2.TabIndex = 44
        '
        'dtPick1
        '
        Me.dtPick1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPick1.Location = New System.Drawing.Point(1113, 195)
        Me.dtPick1.Name = "dtPick1"
        Me.dtPick1.Size = New System.Drawing.Size(98, 23)
        Me.dtPick1.TabIndex = 43
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(488, 575)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(48, 23)
        Me.lblTotal.TabIndex = 54
        Me.lblTotal.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 575)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(813, 581)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Account"
        '
        'cmbAccount
        '
        Me.cmbAccount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccount.FormattingEnabled = True
        Me.cmbAccount.Location = New System.Drawing.Point(890, 578)
        Me.cmbAccount.Margin = New System.Windows.Forms.Padding(8)
        Me.cmbAccount.Name = "cmbAccount"
        Me.cmbAccount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbAccount.Size = New System.Drawing.Size(301, 23)
        Me.cmbAccount.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(783, 618)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 19)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Sub Account"
        '
        'cmbSubAcct
        '
        Me.cmbSubAcct.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubAcct.FormattingEnabled = True
        Me.cmbSubAcct.Location = New System.Drawing.Point(890, 614)
        Me.cmbSubAcct.Margin = New System.Windows.Forms.Padding(8)
        Me.cmbSubAcct.Name = "cmbSubAcct"
        Me.cmbSubAcct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSubAcct.Size = New System.Drawing.Size(301, 23)
        Me.cmbSubAcct.TabIndex = 58
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(635, 597)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 22)
        Me.btnRefresh.TabIndex = 60
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnClose.Location = New System.Drawing.Point(635, 647)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 22)
        Me.btnClose.TabIndex = 61
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmVisualStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1272, 681)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbSubAcct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.cmbAccount)
        Me.Controls.Add(Me.lblLast30)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLast12)
        Me.Controls.Add(Me.lblPrevM)
        Me.Controls.Add(Me.lblMTD)
        Me.Controls.Add(Me.lblPrevYr)
        Me.Controls.Add(Me.lblYTD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtPick2)
        Me.Controls.Add(Me.dtPick1)
        Me.Controls.Add(Me.fraChart)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVisualStatus"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Text = "Monthly Expenses"
        Me.Controls.SetChildIndex(Me.fraChart, 0)
        Me.Controls.SetChildIndex(Me.dtPick1, 0)
        Me.Controls.SetChildIndex(Me.dtPick2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblYTD, 0)
        Me.Controls.SetChildIndex(Me.lblPrevYr, 0)
        Me.Controls.SetChildIndex(Me.lblMTD, 0)
        Me.Controls.SetChildIndex(Me.lblPrevM, 0)
        Me.Controls.SetChildIndex(Me.lblLast12, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblLast30, 0)
        Me.Controls.SetChildIndex(Me.cmbAccount, 0)
        Me.Controls.SetChildIndex(Me.lblTotal, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.cmbSubAcct, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.btnRefresh, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        CType(Me.mccTracking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraChart.ResumeLayout(False)
        Me.fraChart.PerformLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mccTracking As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents fraChart As System.Windows.Forms.GroupBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents lblLast30 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLast12 As System.Windows.Forms.Label
    Friend WithEvents lblPrevM As System.Windows.Forms.Label
    Friend WithEvents lblMTD As System.Windows.Forms.Label
    Friend WithEvents lblPrevYr As System.Windows.Forms.Label
    Friend WithEvents lblYTD As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtPick2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPick1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbSubAcct As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvDetails As System.Windows.Forms.DataGridView
    Friend WithEvents lblDgAccount As System.Windows.Forms.Label
    Friend WithEvents lblDGAmount As System.Windows.Forms.Label
    Friend WithEvents lblDetailTotal As System.Windows.Forms.Label
    Friend WithEvents lblPeriod As System.Windows.Forms.Label
    Friend WithEvents cname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Month As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
