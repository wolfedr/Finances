<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptBusiness
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
        Me.dgvBusinesses = New System.Windows.Forms.DataGridView
        Me.busName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.dgvBusinesses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBusinesses
        '
        Me.dgvBusinesses.AllowUserToAddRows = False
        Me.dgvBusinesses.AllowUserToDeleteRows = False
        Me.dgvBusinesses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBusinesses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBusinesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusinesses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.busName, Me.Total})
        Me.dgvBusinesses.Location = New System.Drawing.Point(234, 117)
        Me.dgvBusinesses.Name = "dgvBusinesses"
        Me.dgvBusinesses.Size = New System.Drawing.Size(444, 519)
        Me.dgvBusinesses.TabIndex = 1
        '
        'busName
        '
        Me.busName.DataPropertyName = "busName"
        Me.busName.HeaderText = "Business"
        Me.busName.Name = "busName"
        Me.busName.Width = 200
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.Width = 200
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
        Me.btnClose.Location = New System.Drawing.Point(405, 87)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 26)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close Window"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dtPick1
        '
        Me.dtPick1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPick1.Location = New System.Drawing.Point(891, 111)
        Me.dtPick1.Name = "dtPick1"
        Me.dtPick1.Size = New System.Drawing.Size(98, 20)
        Me.dtPick1.TabIndex = 3
        '
        'dtPick2
        '
        Me.dtPick2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPick2.Location = New System.Drawing.Point(891, 137)
        Me.dtPick2.Name = "dtPick2"
        Me.dtPick2.Size = New System.Drawing.Size(98, 20)
        Me.dtPick2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(856, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(856, 143)
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
        Me.lblYTD.Location = New System.Drawing.Point(855, 198)
        Me.lblYTD.Name = "lblYTD"
        Me.lblYTD.Size = New System.Drawing.Size(107, 19)
        Me.lblYTD.TabIndex = 7
        Me.lblYTD.Text = "YEAR TO DATE"
        '
        'lblPrevYr
        '
        Me.lblPrevYr.AutoSize = True
        Me.lblPrevYr.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevYr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrevYr.Location = New System.Drawing.Point(855, 228)
        Me.lblPrevYr.Name = "lblPrevYr"
        Me.lblPrevYr.Size = New System.Drawing.Size(116, 19)
        Me.lblPrevYr.TabIndex = 8
        Me.lblPrevYr.Text = "PREVIOUS YEAR"
        '
        'lblAll
        '
        Me.lblAll.AutoSize = True
        Me.lblAll.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAll.Location = New System.Drawing.Point(855, 454)
        Me.lblAll.Name = "lblAll"
        Me.lblAll.Size = New System.Drawing.Size(75, 19)
        Me.lblAll.TabIndex = 9
        Me.lblAll.Text = "ALL DATA"
        '
        'lblMTD
        '
        Me.lblMTD.AutoSize = True
        Me.lblMTD.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMTD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMTD.Location = New System.Drawing.Point(855, 260)
        Me.lblMTD.Name = "lblMTD"
        Me.lblMTD.Size = New System.Drawing.Size(126, 19)
        Me.lblMTD.TabIndex = 10
        Me.lblMTD.Text = "MONTH TO DATE"
        '
        'lblPrevM
        '
        Me.lblPrevM.AutoSize = True
        Me.lblPrevM.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrevM.Location = New System.Drawing.Point(855, 291)
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
        Me.lblLast12.Location = New System.Drawing.Point(855, 319)
        Me.lblLast12.Name = "lblLast12"
        Me.lblLast12.Size = New System.Drawing.Size(128, 19)
        Me.lblLast12.TabIndex = 12
        Me.lblLast12.Text = "LAST 12 MONTHS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(995, 127)
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
        Me.lblLast30.Location = New System.Drawing.Point(855, 169)
        Me.lblLast30.Name = "lblLast30"
        Me.lblLast30.Size = New System.Drawing.Size(102, 19)
        Me.lblLast30.TabIndex = 14
        Me.lblLast30.Text = "LAST 30 DAYS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(349, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Business Transactions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(240, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(438, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Businesses and their total transactions for the period selected."
        '
        'rptBusiness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1197, 746)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
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
        Me.Controls.Add(Me.dgvBusinesses)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "rptBusiness"
        Me.Text = "Business Report"
        Me.Controls.SetChildIndex(Me.dgvBusinesses, 0)
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
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        CType(Me.dgvBusinesses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBusinesses As System.Windows.Forms.DataGridView
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents busName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
