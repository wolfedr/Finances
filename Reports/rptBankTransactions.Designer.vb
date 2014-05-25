<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptBankTransactions
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvTransactions = New System.Windows.Forms.DataGridView
        Me.columnDTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnID = New System.Windows.Forms.DataGridViewLinkColumn
        Me.ColumnAct = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnTpe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnBus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnDsc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnMem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnNme = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnAds = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnBac = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbYear2 = New System.Windows.Forms.ComboBox
        Me.cmbMonth = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbBankAcct = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnReset = New System.Windows.Forms.Button
        Me.txtTotalRevenue = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTotalExpense = New System.Windows.Forms.TextBox
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnCloseWindow = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbNoPost = New System.Windows.Forms.RadioButton
        Me.rbAll = New System.Windows.Forms.RadioButton
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnDTE, Me.ColumnID, Me.ColumnAct, Me.ColumnTpe, Me.ColumnAmt, Me.ColumnBus, Me.ColumnDsc, Me.ColumnMem, Me.ColumnNme, Me.ColumnAds, Me.ColumnBac})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransactions.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTransactions.Location = New System.Drawing.Point(12, 151)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTransactions.RowHeadersVisible = False
        Me.dgvTransactions.RowHeadersWidth = 50
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTransactions.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvTransactions.Size = New System.Drawing.Size(1178, 446)
        Me.dgvTransactions.TabIndex = 1
        '
        'columnDTE
        '
        Me.columnDTE.DataPropertyName = "bnkTranPostDate"
        Me.columnDTE.HeaderText = "Date"
        Me.columnDTE.Name = "columnDTE"
        Me.columnDTE.Width = 75
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "bnkTranID"
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.LinkColor = System.Drawing.Color.MediumBlue
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.VisitedLinkColor = System.Drawing.Color.Teal
        Me.ColumnID.Width = 50
        '
        'ColumnAct
        '
        Me.ColumnAct.DataPropertyName = "bnkActID"
        Me.ColumnAct.HeaderText = "Account"
        Me.ColumnAct.Name = "ColumnAct"
        Me.ColumnAct.Width = 55
        '
        'ColumnTpe
        '
        Me.ColumnTpe.DataPropertyName = "bnkTranType"
        Me.ColumnTpe.HeaderText = "Type"
        Me.ColumnTpe.Name = "ColumnTpe"
        Me.ColumnTpe.Width = 30
        '
        'ColumnAmt
        '
        Me.ColumnAmt.DataPropertyName = "bnkTranAmount"
        Me.ColumnAmt.HeaderText = "Amount"
        Me.ColumnAmt.Name = "ColumnAmt"
        Me.ColumnAmt.Width = 75
        '
        'ColumnBus
        '
        Me.ColumnBus.DataPropertyName = "bnkTranFTID"
        Me.ColumnBus.HeaderText = "FTID"
        Me.ColumnBus.Name = "ColumnBus"
        Me.ColumnBus.Width = 125
        '
        'ColumnDsc
        '
        Me.ColumnDsc.DataPropertyName = "bnkTranName"
        Me.ColumnDsc.HeaderText = "Name"
        Me.ColumnDsc.Name = "ColumnDsc"
        Me.ColumnDsc.Width = 200
        '
        'ColumnMem
        '
        Me.ColumnMem.DataPropertyName = "bnkTranMemo"
        Me.ColumnMem.HeaderText = "Memo"
        Me.ColumnMem.Name = "ColumnMem"
        Me.ColumnMem.Width = 150
        '
        'ColumnNme
        '
        Me.ColumnNme.DataPropertyName = "bnkTranRefNum"
        Me.ColumnNme.HeaderText = "Reference"
        Me.ColumnNme.Name = "ColumnNme"
        Me.ColumnNme.Width = 150
        '
        'ColumnAds
        '
        Me.ColumnAds.DataPropertyName = "bnkPostedToJournal"
        Me.ColumnAds.HeaderText = "Posted"
        Me.ColumnAds.Name = "ColumnAds"
        Me.ColumnAds.Width = 150
        '
        'ColumnBac
        '
        Me.ColumnBac.DataPropertyName = "timestamp"
        Me.ColumnBac.HeaderText = "TimeStamp"
        Me.ColumnBac.Name = "ColumnBac"
        '
        'cmbYear2
        '
        Me.cmbYear2.BackColor = System.Drawing.Color.Yellow
        Me.cmbYear2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear2.FormattingEnabled = True
        Me.cmbYear2.Items.AddRange(New Object() {"2011", "2012", "2013"})
        Me.cmbYear2.Location = New System.Drawing.Point(136, 63)
        Me.cmbYear2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYear2.Name = "cmbYear2"
        Me.cmbYear2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbYear2.Size = New System.Drawing.Size(92, 23)
        Me.cmbYear2.TabIndex = 2
        Me.cmbYear2.Text = "0"
        '
        'cmbMonth
        '
        Me.cmbMonth.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.ItemHeight = 13
        Me.cmbMonth.Items.AddRange(New Object() {"All", "1(January)", "2(February)", "3(March)", "4(April)", "5(May)", "6(June)", "7(July)", "8(August)", "9(September)", "10(October)", "11(November)", "12(December)"})
        Me.cmbMonth.Location = New System.Drawing.Point(136, 87)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(109, 21)
        Me.cmbMonth.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(94, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(82, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Month"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnRefresh.Location = New System.Drawing.Point(449, 100)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(74, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Entity"
        '
        'cmbBankAcct
        '
        Me.cmbBankAcct.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBankAcct.FormattingEnabled = True
        Me.cmbBankAcct.ItemHeight = 13
        Me.cmbBankAcct.Location = New System.Drawing.Point(136, 43)
        Me.cmbBankAcct.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBankAcct.MaxDropDownItems = 4
        Me.cmbBankAcct.Name = "cmbBankAcct"
        Me.cmbBankAcct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbBankAcct.Size = New System.Drawing.Size(113, 21)
        Me.cmbBankAcct.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(41, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = " Bank Account"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(61, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Account"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(551, 151)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtTotalRevenue
        '
        Me.txtTotalRevenue.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRevenue.Location = New System.Drawing.Point(466, 37)
        Me.txtTotalRevenue.Name = "txtTotalRevenue"
        Me.txtTotalRevenue.Size = New System.Drawing.Size(144, 31)
        Me.txtTotalRevenue.TabIndex = 16
        Me.txtTotalRevenue.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(328, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Total Revenues"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(616, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Total Expenses"
        '
        'txtTotalExpense
        '
        Me.txtTotalExpense.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalExpense.Location = New System.Drawing.Point(757, 37)
        Me.txtTotalExpense.Name = "txtTotalExpense"
        Me.txtTotalExpense.Size = New System.Drawing.Size(129, 31)
        Me.txtTotalExpense.TabIndex = 18
        Me.txtTotalExpense.Text = "0"
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnExport.Location = New System.Drawing.Point(551, 100)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(97, 23)
        Me.btnExport.TabIndex = 20
        Me.btnExport.Text = "Export to Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(585, 884)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(482, 124)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(127, 23)
        Me.btnEdit.TabIndex = 29
        Me.btnEdit.Text = "Edit Selection"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCloseWindow
        '
        Me.btnCloseWindow.Location = New System.Drawing.Point(422, 148)
        Me.btnCloseWindow.Name = "btnCloseWindow"
        Me.btnCloseWindow.Size = New System.Drawing.Size(102, 23)
        Me.btnCloseWindow.TabIndex = 30
        Me.btnCloseWindow.Text = "Close Window"
        Me.btnCloseWindow.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 15
        Me.ComboBox1.Location = New System.Drawing.Point(123, 4)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.MaxDropDownItems = 4
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox1.Size = New System.Drawing.Size(113, 23)
        Me.ComboBox1.TabIndex = 31
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(136, 65)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 31
        Me.cmbYear.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbNoPost)
        Me.GroupBox1.Controls.Add(Me.rbAll)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(757, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(146, 59)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STATUS"
        '
        'rbNoPost
        '
        Me.rbNoPost.AutoSize = True
        Me.rbNoPost.Location = New System.Drawing.Point(16, 36)
        Me.rbNoPost.Name = "rbNoPost"
        Me.rbNoPost.Size = New System.Drawing.Size(123, 17)
        Me.rbNoPost.TabIndex = 1
        Me.rbNoPost.TabStop = True
        Me.rbNoPost.Text = "Show Not Posted"
        Me.rbNoPost.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Location = New System.Drawing.Point(39, 13)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(74, 17)
        Me.rbAll.TabIndex = 0
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "Show All"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'rptBankTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1217, 595)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbBankAcct)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.btnCloseWindow)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalExpense)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalRevenue)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "rptBankTransactions"
        Me.Controls.SetChildIndex(Me.dgvTransactions, 0)
        Me.Controls.SetChildIndex(Me.cmbMonth, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnRefresh, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.btnReset, 0)
        Me.Controls.SetChildIndex(Me.txtTotalRevenue, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtTotalExpense, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.btnExport, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.btnEdit, 0)
        Me.Controls.SetChildIndex(Me.btnCloseWindow, 0)
        Me.Controls.SetChildIndex(Me.cmbYear, 0)
        Me.Controls.SetChildIndex(Me.cmbBankAcct, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents cmbYear2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbBankAcct As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtTotalRevenue As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalExpense As System.Windows.Forms.TextBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnCloseWindow As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents columnDTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnID As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents ColumnAct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTpe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnBus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDsc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnMem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnNme As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnAds As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnBac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNoPost As System.Windows.Forms.RadioButton
    Friend WithEvents rbAll As System.Windows.Forms.RadioButton

End Class
