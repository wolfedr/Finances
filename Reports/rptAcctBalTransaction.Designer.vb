<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptAcctBalTransaction
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
        Me.components = New System.ComponentModel.Container
        Me.dgvBalance = New System.Windows.Forms.DataGridView
        Me.colBank = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMemo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COlBus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColExpenses = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRevenue = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnJan = New System.Windows.Forms.Button
        Me.btnFeb = New System.Windows.Forms.Button
        Me.btnMar = New System.Windows.Forms.Button
        Me.btnApr = New System.Windows.Forms.Button
        Me.btnMay = New System.Windows.Forms.Button
        Me.btnJune = New System.Windows.Forms.Button
        Me.btnJul = New System.Windows.Forms.Button
        Me.btnAug = New System.Windows.Forms.Button
        Me.btnSep = New System.Windows.Forms.Button
        Me.btnOct = New System.Windows.Forms.Button
        Me.btnNov = New System.Windows.Forms.Button
        Me.btnDec = New System.Windows.Forms.Button
        Me.txtYr = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpMonth = New System.Windows.Forms.GroupBox
        Me.txtMonth = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblAccountView = New System.Windows.Forms.Label
        Me.lblSAccount = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblEAccount = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.lblAccountInc = New System.Windows.Forms.Label
        Me.lblAccountExp = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblAccountComp = New System.Windows.Forms.Label
        Me.lblEndingComp = New System.Windows.Forms.Label
        Me.gbAccount = New System.Windows.Forms.GroupBox
        Me.rbAll = New System.Windows.Forms.RadioButton
        Me.rbFR = New System.Windows.Forms.RadioButton
        Me.rbDRRent = New System.Windows.Forms.RadioButton
        Me.rbDR = New System.Windows.Forms.RadioButton
        Me.lblAccountErr = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblAccountCalc = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        CType(Me.dgvBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMonth.SuspendLayout()
        Me.gbAccount.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBalance
        '
        Me.dgvBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBalance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBank, Me.colDate, Me.colMemo, Me.colDesc, Me.COlBus, Me.ColExpenses, Me.colRevenue})
        Me.dgvBalance.Location = New System.Drawing.Point(145, 110)
        Me.dgvBalance.Name = "dgvBalance"
        Me.dgvBalance.RowHeadersVisible = False
        Me.dgvBalance.Size = New System.Drawing.Size(1065, 543)
        Me.dgvBalance.TabIndex = 0
        '
        'colBank
        '
        Me.colBank.DataPropertyName = "Account"
        Me.colBank.HeaderText = "Bank"
        Me.colBank.Name = "colBank"
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "tranDate"
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.Width = 80
        '
        'colMemo
        '
        Me.colMemo.DataPropertyName = "memo"
        Me.colMemo.HeaderText = "Memo"
        Me.colMemo.Name = "colMemo"
        Me.colMemo.Width = 300
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "Description"
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.Width = 300
        '
        'COlBus
        '
        Me.COlBus.DataPropertyName = "Business"
        Me.COlBus.HeaderText = "Business"
        Me.COlBus.Name = "COlBus"
        '
        'ColExpenses
        '
        Me.ColExpenses.DataPropertyName = "expenses"
        Me.ColExpenses.HeaderText = "Expenses"
        Me.ColExpenses.Name = "ColExpenses"
        Me.ColExpenses.Width = 90
        '
        'colRevenue
        '
        Me.colRevenue.DataPropertyName = "income"
        Me.colRevenue.HeaderText = "Revenue"
        Me.colRevenue.Name = "colRevenue"
        Me.colRevenue.Width = 90
        '
        'btnJan
        '
        Me.btnJan.BackColor = System.Drawing.Color.Aqua
        Me.btnJan.Location = New System.Drawing.Point(39, 19)
        Me.btnJan.Name = "btnJan"
        Me.btnJan.Size = New System.Drawing.Size(75, 23)
        Me.btnJan.TabIndex = 1
        Me.btnJan.Text = "January"
        Me.btnJan.UseVisualStyleBackColor = False
        '
        'btnFeb
        '
        Me.btnFeb.BackColor = System.Drawing.Color.Aqua
        Me.btnFeb.Location = New System.Drawing.Point(131, 19)
        Me.btnFeb.Name = "btnFeb"
        Me.btnFeb.Size = New System.Drawing.Size(75, 23)
        Me.btnFeb.TabIndex = 2
        Me.btnFeb.Text = "February"
        Me.btnFeb.UseVisualStyleBackColor = False
        '
        'btnMar
        '
        Me.btnMar.BackColor = System.Drawing.Color.Aqua
        Me.btnMar.Location = New System.Drawing.Point(221, 19)
        Me.btnMar.Name = "btnMar"
        Me.btnMar.Size = New System.Drawing.Size(75, 23)
        Me.btnMar.TabIndex = 3
        Me.btnMar.Text = "March"
        Me.btnMar.UseVisualStyleBackColor = False
        '
        'btnApr
        '
        Me.btnApr.BackColor = System.Drawing.Color.Aqua
        Me.btnApr.Location = New System.Drawing.Point(311, 19)
        Me.btnApr.Name = "btnApr"
        Me.btnApr.Size = New System.Drawing.Size(75, 23)
        Me.btnApr.TabIndex = 4
        Me.btnApr.Text = "April"
        Me.btnApr.UseVisualStyleBackColor = False
        '
        'btnMay
        '
        Me.btnMay.BackColor = System.Drawing.Color.Aqua
        Me.btnMay.Location = New System.Drawing.Point(401, 19)
        Me.btnMay.Name = "btnMay"
        Me.btnMay.Size = New System.Drawing.Size(75, 23)
        Me.btnMay.TabIndex = 5
        Me.btnMay.Text = "May"
        Me.btnMay.UseVisualStyleBackColor = False
        '
        'btnJune
        '
        Me.btnJune.BackColor = System.Drawing.Color.Aqua
        Me.btnJune.Location = New System.Drawing.Point(491, 19)
        Me.btnJune.Name = "btnJune"
        Me.btnJune.Size = New System.Drawing.Size(75, 23)
        Me.btnJune.TabIndex = 6
        Me.btnJune.Text = "June"
        Me.btnJune.UseVisualStyleBackColor = False
        '
        'btnJul
        '
        Me.btnJul.BackColor = System.Drawing.Color.Aqua
        Me.btnJul.Location = New System.Drawing.Point(581, 19)
        Me.btnJul.Name = "btnJul"
        Me.btnJul.Size = New System.Drawing.Size(75, 23)
        Me.btnJul.TabIndex = 7
        Me.btnJul.Text = "July"
        Me.btnJul.UseVisualStyleBackColor = False
        '
        'btnAug
        '
        Me.btnAug.BackColor = System.Drawing.Color.Aqua
        Me.btnAug.Location = New System.Drawing.Point(671, 19)
        Me.btnAug.Name = "btnAug"
        Me.btnAug.Size = New System.Drawing.Size(75, 23)
        Me.btnAug.TabIndex = 8
        Me.btnAug.Text = "August"
        Me.btnAug.UseVisualStyleBackColor = False
        '
        'btnSep
        '
        Me.btnSep.BackColor = System.Drawing.Color.Aqua
        Me.btnSep.Location = New System.Drawing.Point(761, 19)
        Me.btnSep.Name = "btnSep"
        Me.btnSep.Size = New System.Drawing.Size(75, 23)
        Me.btnSep.TabIndex = 9
        Me.btnSep.Text = "September"
        Me.btnSep.UseVisualStyleBackColor = False
        '
        'btnOct
        '
        Me.btnOct.BackColor = System.Drawing.Color.Aqua
        Me.btnOct.Location = New System.Drawing.Point(851, 19)
        Me.btnOct.Name = "btnOct"
        Me.btnOct.Size = New System.Drawing.Size(75, 23)
        Me.btnOct.TabIndex = 10
        Me.btnOct.Text = "October"
        Me.btnOct.UseVisualStyleBackColor = False
        '
        'btnNov
        '
        Me.btnNov.BackColor = System.Drawing.Color.Aqua
        Me.btnNov.Location = New System.Drawing.Point(941, 19)
        Me.btnNov.Name = "btnNov"
        Me.btnNov.Size = New System.Drawing.Size(75, 23)
        Me.btnNov.TabIndex = 11
        Me.btnNov.Text = "November"
        Me.btnNov.UseVisualStyleBackColor = False
        '
        'btnDec
        '
        Me.btnDec.BackColor = System.Drawing.Color.Aqua
        Me.btnDec.Location = New System.Drawing.Point(1031, 19)
        Me.btnDec.Name = "btnDec"
        Me.btnDec.Size = New System.Drawing.Size(75, 23)
        Me.btnDec.TabIndex = 12
        Me.btnDec.Text = "December"
        Me.btnDec.UseVisualStyleBackColor = False
        '
        'txtYr
        '
        Me.txtYr.BackColor = System.Drawing.SystemColors.Info
        Me.txtYr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYr.Location = New System.Drawing.Point(282, 10)
        Me.txtYr.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.txtYr.MaxLength = 4
        Me.txtYr.Name = "txtYr"
        Me.txtYr.Size = New System.Drawing.Size(62, 20)
        Me.txtYr.TabIndex = 13
        Me.txtYr.Text = "0000"
        Me.txtYr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Calendar Year being Viewed"
        '
        'grpMonth
        '
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
        Me.grpMonth.Location = New System.Drawing.Point(111, 59)
        Me.grpMonth.Name = "grpMonth"
        Me.grpMonth.Size = New System.Drawing.Size(1128, 45)
        Me.grpMonth.TabIndex = 15
        Me.grpMonth.TabStop = False
        Me.grpMonth.Text = "Click on Month to view!"
        '
        'txtMonth
        '
        Me.txtMonth.BackColor = System.Drawing.SystemColors.Info
        Me.txtMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonth.Location = New System.Drawing.Point(352, 11)
        Me.txtMonth.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.txtMonth.MaxLength = 4
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(45, 20)
        Me.txtMonth.TabIndex = 16
        Me.txtMonth.Text = "MON"
        Me.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(549, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Dublin RISING Inc. Monthly Cash Flow"
        '
        'lblAccountView
        '
        Me.lblAccountView.AutoSize = True
        Me.lblAccountView.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblAccountView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountView.Location = New System.Drawing.Point(6, 119)
        Me.lblAccountView.Name = "lblAccountView"
        Me.lblAccountView.Size = New System.Drawing.Size(100, 15)
        Me.lblAccountView.TabIndex = 18
        Me.lblAccountView.Text = "Dublin RISING"
        '
        'lblSAccount
        '
        Me.lblSAccount.AutoSize = True
        Me.lblSAccount.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblSAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSAccount.Location = New System.Drawing.Point(71, 142)
        Me.lblSAccount.Name = "lblSAccount"
        Me.lblSAccount.Size = New System.Drawing.Size(14, 13)
        Me.lblSAccount.TabIndex = 19
        Me.lblSAccount.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Income"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Ending"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(0, 142)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Starting"
        '
        'lblEAccount
        '
        Me.lblEAccount.AutoSize = True
        Me.lblEAccount.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblEAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEAccount.Location = New System.Drawing.Point(70, 181)
        Me.lblEAccount.Name = "lblEAccount"
        Me.lblEAccount.Size = New System.Drawing.Size(14, 13)
        Me.lblEAccount.TabIndex = 27
        Me.lblEAccount.Text = "0"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(975, 14)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(90, 13)
        Me.lbl3.TabIndex = 26
        Me.lbl3.Text = "Dublin RISING"
        '
        'lblAccountInc
        '
        Me.lblAccountInc.AutoSize = True
        Me.lblAccountInc.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblAccountInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountInc.Location = New System.Drawing.Point(71, 155)
        Me.lblAccountInc.Name = "lblAccountInc"
        Me.lblAccountInc.Size = New System.Drawing.Size(14, 13)
        Me.lblAccountInc.TabIndex = 34
        Me.lblAccountInc.Text = "0"
        '
        'lblAccountExp
        '
        Me.lblAccountExp.AutoSize = True
        Me.lblAccountExp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblAccountExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountExp.Location = New System.Drawing.Point(71, 168)
        Me.lblAccountExp.Name = "lblAccountExp"
        Me.lblAccountExp.Size = New System.Drawing.Size(14, 13)
        Me.lblAccountExp.TabIndex = 36
        Me.lblAccountExp.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Expense"
        '
        'lblAccountComp
        '
        Me.lblAccountComp.AutoSize = True
        Me.lblAccountComp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblAccountComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountComp.Location = New System.Drawing.Point(71, 207)
        Me.lblAccountComp.Name = "lblAccountComp"
        Me.lblAccountComp.Size = New System.Drawing.Size(14, 13)
        Me.lblAccountComp.TabIndex = 38
        Me.lblAccountComp.Text = "0"
        '
        'lblEndingComp
        '
        Me.lblEndingComp.AutoSize = True
        Me.lblEndingComp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblEndingComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndingComp.Location = New System.Drawing.Point(0, 207)
        Me.lblEndingComp.Name = "lblEndingComp"
        Me.lblEndingComp.Size = New System.Drawing.Size(54, 13)
        Me.lblEndingComp.TabIndex = 37
        Me.lblEndingComp.Text = "Register"
        '
        'gbAccount
        '
        Me.gbAccount.Controls.Add(Me.rbAll)
        Me.gbAccount.Controls.Add(Me.rbFR)
        Me.gbAccount.Controls.Add(Me.rbDRRent)
        Me.gbAccount.Controls.Add(Me.rbDR)
        Me.gbAccount.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAccount.Location = New System.Drawing.Point(332, 33)
        Me.gbAccount.Name = "gbAccount"
        Me.gbAccount.Size = New System.Drawing.Size(363, 32)
        Me.gbAccount.TabIndex = 49
        Me.gbAccount.TabStop = False
        Me.gbAccount.Text = "Account to View"
        '
        'rbAll
        '
        Me.rbAll.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAll.Location = New System.Drawing.Point(316, 10)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(86, 16)
        Me.rbAll.TabIndex = 51
        Me.rbAll.Text = "All"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'rbFR
        '
        Me.rbFR.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFR.Location = New System.Drawing.Point(215, 10)
        Me.rbFR.Name = "rbFR"
        Me.rbFR.Size = New System.Drawing.Size(86, 16)
        Me.rbFR.TabIndex = 52
        Me.rbFR.Text = "Fundraising"
        Me.rbFR.UseVisualStyleBackColor = True
        '
        'rbDRRent
        '
        Me.rbDRRent.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDRRent.Location = New System.Drawing.Point(115, 10)
        Me.rbDRRent.Name = "rbDRRent"
        Me.rbDRRent.Size = New System.Drawing.Size(86, 16)
        Me.rbDRRent.TabIndex = 51
        Me.rbDRRent.Text = "DR Rental"
        Me.rbDRRent.UseVisualStyleBackColor = True
        '
        'rbDR
        '
        Me.rbDR.Checked = True
        Me.rbDR.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDR.Location = New System.Drawing.Point(6, 10)
        Me.rbDR.Name = "rbDR"
        Me.rbDR.Size = New System.Drawing.Size(86, 16)
        Me.rbDR.TabIndex = 50
        Me.rbDR.TabStop = True
        Me.rbDR.Text = "Dublin Rising"
        Me.rbDR.UseVisualStyleBackColor = True
        '
        'lblAccountErr
        '
        Me.lblAccountErr.AutoSize = True
        Me.lblAccountErr.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblAccountErr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountErr.Location = New System.Drawing.Point(71, 220)
        Me.lblAccountErr.Name = "lblAccountErr"
        Me.lblAccountErr.Size = New System.Drawing.Size(14, 13)
        Me.lblAccountErr.TabIndex = 51
        Me.lblAccountErr.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Error"
        '
        'lblAccountCalc
        '
        Me.lblAccountCalc.AutoSize = True
        Me.lblAccountCalc.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblAccountCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountCalc.Location = New System.Drawing.Point(70, 194)
        Me.lblAccountCalc.Name = "lblAccountCalc"
        Me.lblAccountCalc.Size = New System.Drawing.Size(14, 13)
        Me.lblAccountCalc.TabIndex = 53
        Me.lblAccountCalc.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1, 194)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "Calculated"
        '
        'rptAcctBalTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1572, 736)
        Me.Controls.Add(Me.lblAccountCalc)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblAccountErr)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gbAccount)
        Me.Controls.Add(Me.lblAccountComp)
        Me.Controls.Add(Me.lblEndingComp)
        Me.Controls.Add(Me.lblAccountExp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblAccountInc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblEAccount)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lblSAccount)
        Me.Controls.Add(Me.lblAccountView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.grpMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYr)
        Me.Controls.Add(Me.dgvBalance)
        Me.Name = "rptAcctBalTransaction"
        Me.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Text = "AcctBalTransaction"
        CType(Me.dgvBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMonth.ResumeLayout(False)
        Me.gbAccount.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBalance As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btnJan As System.Windows.Forms.Button
    Friend WithEvents btnFeb As System.Windows.Forms.Button
    Friend WithEvents btnMar As System.Windows.Forms.Button
    Friend WithEvents btnApr As System.Windows.Forms.Button
    Friend WithEvents btnMay As System.Windows.Forms.Button
    Friend WithEvents btnJune As System.Windows.Forms.Button
    Friend WithEvents btnJul As System.Windows.Forms.Button
    Friend WithEvents btnAug As System.Windows.Forms.Button
    Friend WithEvents btnSep As System.Windows.Forms.Button
    Friend WithEvents btnOct As System.Windows.Forms.Button
    Friend WithEvents btnNov As System.Windows.Forms.Button
    Friend WithEvents btnDec As System.Windows.Forms.Button
    Friend WithEvents txtYr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpMonth As System.Windows.Forms.GroupBox
    Friend WithEvents colBank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMemo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COlBus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColExpenses As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRevenue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAccountView As System.Windows.Forms.Label
    Friend WithEvents lblSAccount As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblEAccount As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lblAccountInc As System.Windows.Forms.Label
    Friend WithEvents lblAccountExp As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAccountComp As System.Windows.Forms.Label
    Friend WithEvents lblEndingComp As System.Windows.Forms.Label
    Friend WithEvents gbAccount As System.Windows.Forms.GroupBox
    Friend WithEvents rbDR As System.Windows.Forms.RadioButton
    Friend WithEvents rbAll As System.Windows.Forms.RadioButton
    Friend WithEvents rbFR As System.Windows.Forms.RadioButton
    Friend WithEvents rbDRRent As System.Windows.Forms.RadioButton
    Friend WithEvents lblAccountErr As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblAccountCalc As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
