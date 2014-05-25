<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptJournal
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvTransactions = New System.Windows.Forms.DataGridView
        Me.cmbYear2 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.columnDTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JnlID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnID = New System.Windows.Forms.DataGridViewLinkColumn
        Me.ColumnAct = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnTpe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnBus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnDsc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnMem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnNme = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnAds = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.activity = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnDTE, Me.JnlID, Me.ColumnID, Me.ColumnAct, Me.ColumnTpe, Me.ColumnAmt, Me.ColumnBus, Me.ColumnDsc, Me.ColumnMem, Me.ColumnNme, Me.ColumnAds, Me.activity})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransactions.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTransactions.Location = New System.Drawing.Point(0, 24)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTransactions.RowHeadersVisible = False
        Me.dgvTransactions.RowHeadersWidth = 50
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTransactions.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvTransactions.Size = New System.Drawing.Size(1515, 679)
        Me.dgvTransactions.TabIndex = 1
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
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(585, 884)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
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
        'columnDTE
        '
        Me.columnDTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDTE.DataPropertyName = "jnlTranDate"
        Me.columnDTE.HeaderText = "Date"
        Me.columnDTE.Name = "columnDTE"
        Me.columnDTE.Width = 55
        '
        'JnlID
        '
        Me.JnlID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.JnlID.DataPropertyName = "jnlID"
        Me.JnlID.HeaderText = "JID"
        Me.JnlID.Name = "JnlID"
        Me.JnlID.Width = 46
        '
        'ColumnID
        '
        Me.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.ColumnID.DataPropertyName = "ID"
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.LinkColor = System.Drawing.Color.MediumBlue
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.Visible = False
        Me.ColumnID.VisitedLinkColor = System.Drawing.Color.Teal
        Me.ColumnID.Width = 5
        '
        'ColumnAct
        '
        Me.ColumnAct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColumnAct.DataPropertyName = "Account"
        Me.ColumnAct.HeaderText = "Account"
        Me.ColumnAct.Name = "ColumnAct"
        Me.ColumnAct.Width = 70
        '
        'ColumnTpe
        '
        Me.ColumnTpe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColumnTpe.DataPropertyName = "jnlTranType"
        Me.ColumnTpe.HeaderText = "Type"
        Me.ColumnTpe.Name = "ColumnTpe"
        Me.ColumnTpe.Width = 54
        '
        'ColumnAmt
        '
        Me.ColumnAmt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColumnAmt.DataPropertyName = "jnlTranAmount"
        Me.ColumnAmt.HeaderText = "Amount"
        Me.ColumnAmt.Name = "ColumnAmt"
        Me.ColumnAmt.Width = 69
        '
        'ColumnBus
        '
        Me.ColumnBus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColumnBus.DataPropertyName = "busName"
        Me.ColumnBus.HeaderText = "Business"
        Me.ColumnBus.Name = "ColumnBus"
        Me.ColumnBus.Width = 74
        '
        'ColumnDsc
        '
        Me.ColumnDsc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColumnDsc.DataPropertyName = "jnlTranDesc"
        Me.ColumnDsc.HeaderText = "Description"
        Me.ColumnDsc.Name = "ColumnDsc"
        Me.ColumnDsc.Width = 86
        '
        'ColumnMem
        '
        Me.ColumnMem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColumnMem.DataPropertyName = "jnlTranMemo"
        Me.ColumnMem.HeaderText = "Memo"
        Me.ColumnMem.Name = "ColumnMem"
        Me.ColumnMem.Width = 62
        '
        'ColumnNme
        '
        Me.ColumnNme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColumnNme.DataPropertyName = "actName"
        Me.ColumnNme.HeaderText = "Acct. Name"
        Me.ColumnNme.Name = "ColumnNme"
        Me.ColumnNme.Width = 85
        '
        'ColumnAds
        '
        Me.ColumnAds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColumnAds.DataPropertyName = "actDescription"
        Me.ColumnAds.HeaderText = "Account Description"
        Me.ColumnAds.Name = "ColumnAds"
        Me.ColumnAds.Width = 115
        '
        'activity
        '
        Me.activity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.activity.DataPropertyName = "ActivityDescription"
        Me.activity.HeaderText = "Activity"
        Me.activity.Name = "activity"
        Me.activity.Width = 66
        '
        'rptJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1516, 742)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.btnClose)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "rptJournal"
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.dgvTransactions, 0)
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents cmbYear2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents columnDTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JnlID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnID As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents ColumnAct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTpe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnBus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDsc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnMem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnNme As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnAds As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents activity As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
