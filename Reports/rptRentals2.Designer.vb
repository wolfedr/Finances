<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptRentals2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtPick2 = New System.Windows.Forms.DateTimePicker
        Me.dtPick1 = New System.Windows.Forms.DateTimePicker
        Me.lblBalance = New System.Windows.Forms.Label
        Me.dgvTransactions = New System.Windows.Forms.DataGridView
        Me.actName = New System.Windows.Forms.DataGridViewLinkColumn
        Me.account = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colExpense = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ddlActivity = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ddlFundraiser = New System.Windows.Forms.ComboBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.grpActivities = New System.Windows.Forms.GroupBox
        Me.rbFundraiser = New System.Windows.Forms.RadioButton
        Me.rbRental = New System.Windows.Forms.RadioButton
        Me.grpMonth = New System.Windows.Forms.GroupBox
        Me.btnYTD = New System.Windows.Forms.Button
        Me.btnDec = New System.Windows.Forms.Button
        Me.btnNov = New System.Windows.Forms.Button
        Me.btnOct = New System.Windows.Forms.Button
        Me.btnSep = New System.Windows.Forms.Button
        Me.btnAug = New System.Windows.Forms.Button
        Me.btnJul = New System.Windows.Forms.Button
        Me.btnJune = New System.Windows.Forms.Button
        Me.btnMay = New System.Windows.Forms.Button
        Me.btnApr = New System.Windows.Forms.Button
        Me.btnMar = New System.Windows.Forms.Button
        Me.btnFeb = New System.Windows.Forms.Button
        Me.btnJan = New System.Windows.Forms.Button
        Me.hdnFY = New System.Windows.Forms.Label
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpActivities.SuspendLayout()
        Me.grpMonth.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Stop"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Start"
        '
        'dtPick2
        '
        Me.dtPick2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPick2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPick2.Location = New System.Drawing.Point(78, 44)
        Me.dtPick2.Name = "dtPick2"
        Me.dtPick2.Size = New System.Drawing.Size(98, 26)
        Me.dtPick2.TabIndex = 15
        '
        'dtPick1
        '
        Me.dtPick1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPick1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPick1.Location = New System.Drawing.Point(77, 12)
        Me.dtPick1.Name = "dtPick1"
        Me.dtPick1.Size = New System.Drawing.Size(98, 26)
        Me.dtPick1.TabIndex = 14
        Me.dtPick1.Value = New Date(2013, 1, 1, 0, 0, 0, 0)
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(353, 657)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(72, 18)
        Me.lblBalance.TabIndex = 19
        Me.lblBalance.Text = "lblBalance"
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvTransactions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvTransactions.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.actName, Me.account, Me.Total1, Me.colExpense, Me.Total})
        Me.dgvTransactions.Location = New System.Drawing.Point(223, 74)
        Me.dgvTransactions.Name = "dgvTransactions"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvTransactions.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTransactions.Size = New System.Drawing.Size(898, 585)
        Me.dgvTransactions.TabIndex = 20
        '
        'actName
        '
        Me.actName.DataPropertyName = "Description"
        Me.actName.HeaderText = "Description"
        Me.actName.LinkColor = System.Drawing.Color.Black
        Me.actName.Name = "actName"
        Me.actName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.actName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.actName.Width = 300
        '
        'account
        '
        Me.account.DataPropertyName = "TranDate"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.account.DefaultCellStyle = DataGridViewCellStyle3
        Me.account.HeaderText = "Transaction Date"
        Me.account.Name = "account"
        Me.account.Width = 150
        '
        'Total1
        '
        Me.Total1.DataPropertyName = "Amount"
        Me.Total1.HeaderText = "Income"
        Me.Total1.Name = "Total1"
        Me.Total1.Width = 150
        '
        'colExpense
        '
        Me.colExpense.HeaderText = "Expenses"
        Me.colExpense.Name = "colExpense"
        '
        'Total
        '
        Me.Total.DataPropertyName = "Account"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Total.DefaultCellStyle = DataGridViewCellStyle4
        Me.Total.HeaderText = "Account"
        Me.Total.Name = "Total"
        Me.Total.Width = 150
        '
        'ddlActivity
        '
        Me.ddlActivity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ddlActivity.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlActivity.FormattingEnabled = True
        Me.ddlActivity.Location = New System.Drawing.Point(6, 27)
        Me.ddlActivity.Name = "ddlActivity"
        Me.ddlActivity.Size = New System.Drawing.Size(157, 26)
        Me.ddlActivity.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Rentals"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Fundraisers"
        '
        'ddlFundraiser
        '
        Me.ddlFundraiser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ddlFundraiser.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlFundraiser.FormattingEnabled = True
        Me.ddlFundraiser.Location = New System.Drawing.Point(6, 109)
        Me.ddlFundraiser.Name = "ddlFundraiser"
        Me.ddlFundraiser.Size = New System.Drawing.Size(157, 26)
        Me.ddlFundraiser.TabIndex = 23
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(53, 76)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(111, 23)
        Me.btnRefresh.TabIndex = 25
        Me.btnRefresh.Text = "Refresh Display"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'grpActivities
        '
        Me.grpActivities.Controls.Add(Me.rbFundraiser)
        Me.grpActivities.Controls.Add(Me.rbRental)
        Me.grpActivities.Controls.Add(Me.Label5)
        Me.grpActivities.Controls.Add(Me.ddlFundraiser)
        Me.grpActivities.Controls.Add(Me.Label4)
        Me.grpActivities.Controls.Add(Me.ddlActivity)
        Me.grpActivities.Location = New System.Drawing.Point(12, 105)
        Me.grpActivities.Name = "grpActivities"
        Me.grpActivities.Size = New System.Drawing.Size(205, 373)
        Me.grpActivities.TabIndex = 26
        Me.grpActivities.TabStop = False
        Me.grpActivities.Text = "Activities"
        '
        'rbFundraiser
        '
        Me.rbFundraiser.AutoSize = True
        Me.rbFundraiser.Location = New System.Drawing.Point(170, 115)
        Me.rbFundraiser.Name = "rbFundraiser"
        Me.rbFundraiser.Size = New System.Drawing.Size(14, 13)
        Me.rbFundraiser.TabIndex = 26
        Me.rbFundraiser.UseVisualStyleBackColor = True
        '
        'rbRental
        '
        Me.rbRental.AutoSize = True
        Me.rbRental.Checked = True
        Me.rbRental.Location = New System.Drawing.Point(170, 35)
        Me.rbRental.Name = "rbRental"
        Me.rbRental.Size = New System.Drawing.Size(14, 13)
        Me.rbRental.TabIndex = 25
        Me.rbRental.TabStop = True
        Me.rbRental.UseVisualStyleBackColor = True
        '
        'grpMonth
        '
        Me.grpMonth.Controls.Add(Me.btnYTD)
        Me.grpMonth.Controls.Add(Me.btnDec)
        Me.grpMonth.Controls.Add(Me.btnNov)
        Me.grpMonth.Controls.Add(Me.btnOct)
        Me.grpMonth.Controls.Add(Me.btnSep)
        Me.grpMonth.Controls.Add(Me.btnAug)
        Me.grpMonth.Controls.Add(Me.btnJul)
        Me.grpMonth.Controls.Add(Me.btnJune)
        Me.grpMonth.Controls.Add(Me.btnMay)
        Me.grpMonth.Controls.Add(Me.btnApr)
        Me.grpMonth.Controls.Add(Me.btnMar)
        Me.grpMonth.Controls.Add(Me.btnFeb)
        Me.grpMonth.Controls.Add(Me.btnJan)
        Me.grpMonth.Location = New System.Drawing.Point(223, 23)
        Me.grpMonth.Name = "grpMonth"
        Me.grpMonth.Size = New System.Drawing.Size(898, 45)
        Me.grpMonth.TabIndex = 27
        Me.grpMonth.TabStop = False
        Me.grpMonth.Text = "Click on Month to view!"
        '
        'btnYTD
        '
        Me.btnYTD.BackColor = System.Drawing.Color.Aqua
        Me.btnYTD.Location = New System.Drawing.Point(6, 16)
        Me.btnYTD.Name = "btnYTD"
        Me.btnYTD.Size = New System.Drawing.Size(41, 23)
        Me.btnYTD.TabIndex = 13
        Me.btnYTD.Text = "YTD"
        Me.btnYTD.UseVisualStyleBackColor = False
        '
        'btnDec
        '
        Me.btnDec.BackColor = System.Drawing.Color.Aqua
        Me.btnDec.Location = New System.Drawing.Point(784, 16)
        Me.btnDec.Name = "btnDec"
        Me.btnDec.Size = New System.Drawing.Size(71, 23)
        Me.btnDec.TabIndex = 12
        Me.btnDec.Text = "December"
        Me.btnDec.UseVisualStyleBackColor = False
        '
        'btnNov
        '
        Me.btnNov.BackColor = System.Drawing.Color.Aqua
        Me.btnNov.Location = New System.Drawing.Point(707, 16)
        Me.btnNov.Name = "btnNov"
        Me.btnNov.Size = New System.Drawing.Size(71, 23)
        Me.btnNov.TabIndex = 11
        Me.btnNov.Text = "November"
        Me.btnNov.UseVisualStyleBackColor = False
        '
        'btnOct
        '
        Me.btnOct.BackColor = System.Drawing.Color.Aqua
        Me.btnOct.Location = New System.Drawing.Point(634, 16)
        Me.btnOct.Name = "btnOct"
        Me.btnOct.Size = New System.Drawing.Size(67, 23)
        Me.btnOct.TabIndex = 10
        Me.btnOct.Text = "October"
        Me.btnOct.UseVisualStyleBackColor = False
        '
        'btnSep
        '
        Me.btnSep.BackColor = System.Drawing.Color.Aqua
        Me.btnSep.Location = New System.Drawing.Point(559, 16)
        Me.btnSep.Name = "btnSep"
        Me.btnSep.Size = New System.Drawing.Size(69, 23)
        Me.btnSep.TabIndex = 9
        Me.btnSep.Text = "September"
        Me.btnSep.UseVisualStyleBackColor = False
        '
        'btnAug
        '
        Me.btnAug.BackColor = System.Drawing.Color.Aqua
        Me.btnAug.Location = New System.Drawing.Point(493, 16)
        Me.btnAug.Name = "btnAug"
        Me.btnAug.Size = New System.Drawing.Size(60, 23)
        Me.btnAug.TabIndex = 8
        Me.btnAug.Text = "August"
        Me.btnAug.UseVisualStyleBackColor = False
        '
        'btnJul
        '
        Me.btnJul.BackColor = System.Drawing.Color.Aqua
        Me.btnJul.Location = New System.Drawing.Point(442, 16)
        Me.btnJul.Name = "btnJul"
        Me.btnJul.Size = New System.Drawing.Size(45, 23)
        Me.btnJul.TabIndex = 7
        Me.btnJul.Text = "July"
        Me.btnJul.UseVisualStyleBackColor = False
        '
        'btnJune
        '
        Me.btnJune.BackColor = System.Drawing.Color.Aqua
        Me.btnJune.Location = New System.Drawing.Point(385, 16)
        Me.btnJune.Name = "btnJune"
        Me.btnJune.Size = New System.Drawing.Size(51, 23)
        Me.btnJune.TabIndex = 6
        Me.btnJune.Text = "June"
        Me.btnJune.UseVisualStyleBackColor = False
        '
        'btnMay
        '
        Me.btnMay.BackColor = System.Drawing.Color.Aqua
        Me.btnMay.Location = New System.Drawing.Point(335, 16)
        Me.btnMay.Name = "btnMay"
        Me.btnMay.Size = New System.Drawing.Size(44, 23)
        Me.btnMay.TabIndex = 5
        Me.btnMay.Text = "May"
        Me.btnMay.UseVisualStyleBackColor = False
        '
        'btnApr
        '
        Me.btnApr.BackColor = System.Drawing.Color.Aqua
        Me.btnApr.Location = New System.Drawing.Point(282, 16)
        Me.btnApr.Name = "btnApr"
        Me.btnApr.Size = New System.Drawing.Size(47, 23)
        Me.btnApr.TabIndex = 4
        Me.btnApr.Text = "April"
        Me.btnApr.UseVisualStyleBackColor = False
        '
        'btnMar
        '
        Me.btnMar.BackColor = System.Drawing.Color.Aqua
        Me.btnMar.Location = New System.Drawing.Point(226, 16)
        Me.btnMar.Name = "btnMar"
        Me.btnMar.Size = New System.Drawing.Size(50, 23)
        Me.btnMar.TabIndex = 3
        Me.btnMar.Text = "March"
        Me.btnMar.UseVisualStyleBackColor = False
        '
        'btnFeb
        '
        Me.btnFeb.BackColor = System.Drawing.Color.Aqua
        Me.btnFeb.Location = New System.Drawing.Point(160, 16)
        Me.btnFeb.Name = "btnFeb"
        Me.btnFeb.Size = New System.Drawing.Size(60, 23)
        Me.btnFeb.TabIndex = 2
        Me.btnFeb.Text = "February"
        Me.btnFeb.UseVisualStyleBackColor = False
        '
        'btnJan
        '
        Me.btnJan.BackColor = System.Drawing.Color.Aqua
        Me.btnJan.Location = New System.Drawing.Point(96, 16)
        Me.btnJan.Name = "btnJan"
        Me.btnJan.Size = New System.Drawing.Size(58, 23)
        Me.btnJan.TabIndex = 1
        Me.btnJan.Text = "January"
        Me.btnJan.UseVisualStyleBackColor = False
        '
        'hdnFY
        '
        Me.hdnFY.AutoSize = True
        Me.hdnFY.Location = New System.Drawing.Point(522, 4)
        Me.hdnFY.Name = "hdnFY"
        Me.hdnFY.Size = New System.Drawing.Size(62, 13)
        Me.hdnFY.TabIndex = 28
        Me.hdnFY.Text = "hidden year"
        Me.hdnFY.Visible = False
        '
        'rptRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1399, 749)
        Me.Controls.Add(Me.hdnFY)
        Me.Controls.Add(Me.grpMonth)
        Me.Controls.Add(Me.grpActivities)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtPick2)
        Me.Controls.Add(Me.dtPick1)
        Me.Name = "rptRentals"
        Me.Text = "rptRrentals"
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpActivities.ResumeLayout(False)
        Me.grpActivities.PerformLayout()
        Me.grpMonth.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtPick2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPick1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents dgvTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents ddlActivity As System.Windows.Forms.ComboBox
    Friend WithEvents actName As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colExpense As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ddlFundraiser As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents grpActivities As System.Windows.Forms.GroupBox
    Friend WithEvents rbFundraiser As System.Windows.Forms.RadioButton
    Friend WithEvents rbRental As System.Windows.Forms.RadioButton
    Friend WithEvents grpMonth As System.Windows.Forms.GroupBox
    Friend WithEvents btnYTD As System.Windows.Forms.Button
    Friend WithEvents btnDec As System.Windows.Forms.Button
    Friend WithEvents btnNov As System.Windows.Forms.Button
    Friend WithEvents btnOct As System.Windows.Forms.Button
    Friend WithEvents btnSep As System.Windows.Forms.Button
    Friend WithEvents btnAug As System.Windows.Forms.Button
    Friend WithEvents btnJul As System.Windows.Forms.Button
    Friend WithEvents btnJune As System.Windows.Forms.Button
    Friend WithEvents btnMay As System.Windows.Forms.Button
    Friend WithEvents btnApr As System.Windows.Forms.Button
    Friend WithEvents btnMar As System.Windows.Forms.Button
    Friend WithEvents btnFeb As System.Windows.Forms.Button
    Friend WithEvents btnJan As System.Windows.Forms.Button
    Friend WithEvents hdnFY As System.Windows.Forms.Label
End Class
