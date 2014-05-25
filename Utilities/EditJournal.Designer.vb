<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditJournal
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpJournal = New System.Windows.Forms.DateTimePicker
        Me.dgvEntries = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtJnlActNum = New System.Windows.Forms.TextBox
        Me.txtJnlID = New System.Windows.Forms.TextBox
        Me.txtJnlSequence = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtjnlTranDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtJnlTranAmount = New System.Windows.Forms.TextBox
        Me.txtJnlTranType = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtJnlDescription = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtJnlBusID = New System.Windows.Forms.TextBox
        Me.txtJnlMemo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtBankAct = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtBankTranID = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbBusiness = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmbBankAccount = New System.Windows.Forms.ComboBox
        Me.cmbMajorAcct = New System.Windows.Forms.ComboBox
        Me.cmbSubAcct = New System.Windows.Forms.ComboBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnExtraDays = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbExternalSource = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbReceipt = New System.Windows.Forms.CheckBox
        Me.ddlActivity = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        CType(Me.dgvEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(520, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Date For Transactions to Edit!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(482, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(330, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Journal Transaction Editor"
        Me.Label2.Visible = False
        '
        'dtpJournal
        '
        Me.dtpJournal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpJournal.Location = New System.Drawing.Point(498, 69)
        Me.dtpJournal.Name = "dtpJournal"
        Me.dtpJournal.Size = New System.Drawing.Size(260, 26)
        Me.dtpJournal.TabIndex = 5
        '
        'dgvEntries
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvEntries.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEntries.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntries.Location = New System.Drawing.Point(12, 48)
        Me.dgvEntries.Name = "dgvEntries"
        Me.dgvEntries.RowHeadersWidth = 20
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvEntries.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEntries.Size = New System.Drawing.Size(462, 513)
        Me.dgvEntries.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(759, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Journal Details"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(480, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Major Account"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(505, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Journal ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtJnlActNum
        '
        Me.txtJnlActNum.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJnlActNum.Location = New System.Drawing.Point(597, 258)
        Me.txtJnlActNum.Name = "txtJnlActNum"
        Me.txtJnlActNum.Size = New System.Drawing.Size(78, 26)
        Me.txtJnlActNum.TabIndex = 11
        Me.txtJnlActNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtJnlID
        '
        Me.txtJnlID.Enabled = False
        Me.txtJnlID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJnlID.Location = New System.Drawing.Point(597, 177)
        Me.txtJnlID.Name = "txtJnlID"
        Me.txtJnlID.ReadOnly = True
        Me.txtJnlID.Size = New System.Drawing.Size(71, 26)
        Me.txtJnlID.TabIndex = 9
        Me.txtJnlID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtJnlSequence
        '
        Me.txtJnlSequence.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJnlSequence.Location = New System.Drawing.Point(597, 297)
        Me.txtJnlSequence.Name = "txtJnlSequence"
        Me.txtJnlSequence.Size = New System.Drawing.Size(38, 26)
        Me.txtJnlSequence.TabIndex = 13
        Me.txtJnlSequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(501, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Sub Account"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtjnlTranDate
        '
        Me.txtjnlTranDate.Enabled = False
        Me.txtjnlTranDate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjnlTranDate.Location = New System.Drawing.Point(812, 179)
        Me.txtjnlTranDate.Name = "txtjnlTranDate"
        Me.txtjnlTranDate.ReadOnly = True
        Me.txtjnlTranDate.Size = New System.Drawing.Size(135, 26)
        Me.txtjnlTranDate.TabIndex = 15
        Me.txtjnlTranDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(959, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Amount"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtJnlTranAmount
        '
        Me.txtJnlTranAmount.Enabled = False
        Me.txtJnlTranAmount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJnlTranAmount.Location = New System.Drawing.Point(1030, 179)
        Me.txtJnlTranAmount.Name = "txtJnlTranAmount"
        Me.txtJnlTranAmount.ReadOnly = True
        Me.txtJnlTranAmount.Size = New System.Drawing.Size(78, 26)
        Me.txtJnlTranAmount.TabIndex = 19
        Me.txtJnlTranAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtJnlTranType
        '
        Me.txtJnlTranType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtJnlTranType.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJnlTranType.Location = New System.Drawing.Point(1084, 258)
        Me.txtJnlTranType.Name = "txtJnlTranType"
        Me.txtJnlTranType.Size = New System.Drawing.Size(135, 26)
        Me.txtJnlTranType.TabIndex = 17
        Me.txtJnlTranType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(954, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Transaction Type"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(683, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 19)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Transaction Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtJnlDescription
        '
        Me.txtJnlDescription.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJnlDescription.Location = New System.Drawing.Point(597, 374)
        Me.txtJnlDescription.Multiline = True
        Me.txtJnlDescription.Name = "txtJnlDescription"
        Me.txtJnlDescription.Size = New System.Drawing.Size(610, 66)
        Me.txtJnlDescription.TabIndex = 21
        Me.txtJnlDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(511, 336)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 19)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Business ID"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtJnlBusID
        '
        Me.txtJnlBusID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJnlBusID.Location = New System.Drawing.Point(597, 334)
        Me.txtJnlBusID.Name = "txtJnlBusID"
        Me.txtJnlBusID.ReadOnly = True
        Me.txtJnlBusID.Size = New System.Drawing.Size(51, 26)
        Me.txtJnlBusID.TabIndex = 25
        Me.txtJnlBusID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtJnlMemo
        '
        Me.txtJnlMemo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJnlMemo.Location = New System.Drawing.Point(597, 446)
        Me.txtJnlMemo.Multiline = True
        Me.txtJnlMemo.Name = "txtJnlMemo"
        Me.txtJnlMemo.Size = New System.Drawing.Size(610, 59)
        Me.txtJnlMemo.TabIndex = 23
        Me.txtJnlMemo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(532, 448)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 19)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Memo"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(504, 390)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 19)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Description"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBankAct
        '
        Me.txtBankAct.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankAct.Location = New System.Drawing.Point(597, 218)
        Me.txtBankAct.Name = "txtBankAct"
        Me.txtBankAct.ReadOnly = True
        Me.txtBankAct.Size = New System.Drawing.Size(78, 26)
        Me.txtBankAct.TabIndex = 27
        Me.txtBankAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(480, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 19)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Bank Account"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBankTranID
        '
        Me.txtBankTranID.Enabled = False
        Me.txtBankTranID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankTranID.Location = New System.Drawing.Point(1119, 223)
        Me.txtBankTranID.Name = "txtBankTranID"
        Me.txtBankTranID.ReadOnly = True
        Me.txtBankTranID.Size = New System.Drawing.Size(71, 26)
        Me.txtBankTranID.TabIndex = 29
        Me.txtBankTranID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(954, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 19)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Bank Transaction ID"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(605, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(539, 19)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "If you cannot enter a value in a box, this means that box can not be changed!"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbBusiness
        '
        Me.cmbBusiness.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBusiness.FormattingEnabled = True
        Me.cmbBusiness.Location = New System.Drawing.Point(869, 336)
        Me.cmbBusiness.Name = "cmbBusiness"
        Me.cmbBusiness.Size = New System.Drawing.Size(244, 23)
        Me.cmbBusiness.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(669, 336)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(182, 19)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Business Partial Name(ID)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbBankAccount
        '
        Me.cmbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBankAccount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBankAccount.FormattingEnabled = True
        Me.cmbBankAccount.Location = New System.Drawing.Point(717, 225)
        Me.cmbBankAccount.Name = "cmbBankAccount"
        Me.cmbBankAccount.Size = New System.Drawing.Size(180, 23)
        Me.cmbBankAccount.TabIndex = 33
        '
        'cmbMajorAcct
        '
        Me.cmbMajorAcct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMajorAcct.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMajorAcct.FormattingEnabled = True
        Me.cmbMajorAcct.Location = New System.Drawing.Point(696, 265)
        Me.cmbMajorAcct.Name = "cmbMajorAcct"
        Me.cmbMajorAcct.Size = New System.Drawing.Size(240, 23)
        Me.cmbMajorAcct.TabIndex = 34
        '
        'cmbSubAcct
        '
        Me.cmbSubAcct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubAcct.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubAcct.FormattingEnabled = True
        Me.cmbSubAcct.Location = New System.Drawing.Point(641, 297)
        Me.cmbSubAcct.Name = "cmbSubAcct"
        Me.cmbSubAcct.Size = New System.Drawing.Size(353, 23)
        Me.cmbSubAcct.TabIndex = 35
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(793, 511)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(156, 23)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "Save Updated Record"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(825, 540)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 23)
        Me.btnClose.TabIndex = 37
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnExtraDays
        '
        Me.btnExtraDays.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtraDays.Location = New System.Drawing.Point(866, 66)
        Me.btnExtraDays.Name = "btnExtraDays"
        Me.btnExtraDays.Size = New System.Drawing.Size(85, 33)
        Me.btnExtraDays.TabIndex = 38
        Me.btnExtraDays.Text = "Show Days"
        Me.btnExtraDays.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(764, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 33)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Show Day"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbExternalSource
        '
        Me.cmbExternalSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExternalSource.FormattingEnabled = True
        Me.cmbExternalSource.Location = New System.Drawing.Point(7, 14)
        Me.cmbExternalSource.MaxDropDownItems = 10
        Me.cmbExternalSource.Name = "cmbExternalSource"
        Me.cmbExternalSource.Size = New System.Drawing.Size(153, 22)
        Me.cmbExternalSource.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbExternalSource)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GroupBox1.Location = New System.Drawing.Point(1054, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 42)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Externals"
        Me.GroupBox1.Visible = False
        '
        'cbReceipt
        '
        Me.cbReceipt.AutoSize = True
        Me.cbReceipt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReceipt.Location = New System.Drawing.Point(1132, 338)
        Me.cbReceipt.Name = "cbReceipt"
        Me.cbReceipt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbReceipt.Size = New System.Drawing.Size(74, 22)
        Me.cbReceipt.TabIndex = 42
        Me.cbReceipt.Text = "Receipt"
        Me.cbReceipt.UseVisualStyleBackColor = True
        '
        'ddlActivity
        '
        Me.ddlActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlActivity.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlActivity.FormattingEnabled = True
        Me.ddlActivity.Location = New System.Drawing.Point(1061, 295)
        Me.ddlActivity.Name = "ddlActivity"
        Me.ddlActivity.Size = New System.Drawing.Size(158, 23)
        Me.ddlActivity.TabIndex = 43
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1000, 299)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 19)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Activity"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditJournal
        '
        Me.AccessibleDescription = "S"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1246, 621)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ddlActivity)
        Me.Controls.Add(Me.cbReceipt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExtraDays)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbSubAcct)
        Me.Controls.Add(Me.cmbMajorAcct)
        Me.Controls.Add(Me.cmbBankAccount)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmbBusiness)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtBankTranID)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtBankAct)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtJnlDescription)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtJnlBusID)
        Me.Controls.Add(Me.txtJnlMemo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtjnlTranDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtJnlTranAmount)
        Me.Controls.Add(Me.txtJnlTranType)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtJnlID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtJnlSequence)
        Me.Controls.Add(Me.txtJnlActNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvEntries)
        Me.Controls.Add(Me.dtpJournal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "EditJournal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.dtpJournal, 0)
        Me.Controls.SetChildIndex(Me.dgvEntries, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtJnlActNum, 0)
        Me.Controls.SetChildIndex(Me.txtJnlSequence, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtJnlID, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txtJnlTranType, 0)
        Me.Controls.SetChildIndex(Me.txtJnlTranAmount, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtjnlTranDate, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.txtJnlMemo, 0)
        Me.Controls.SetChildIndex(Me.txtJnlBusID, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txtJnlDescription, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txtBankAct, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.txtBankTranID, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.cmbBusiness, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.cmbBankAccount, 0)
        Me.Controls.SetChildIndex(Me.cmbMajorAcct, 0)
        Me.Controls.SetChildIndex(Me.cmbSubAcct, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.btnExtraDays, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.cbReceipt, 0)
        Me.Controls.SetChildIndex(Me.ddlActivity, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        CType(Me.dgvEntries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpJournal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvEntries As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtJnlActNum As System.Windows.Forms.TextBox
    Friend WithEvents txtJnlID As System.Windows.Forms.TextBox
    Friend WithEvents txtJnlSequence As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtjnlTranDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtJnlTranAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtJnlTranType As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtJnlDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtJnlBusID As System.Windows.Forms.TextBox
    Friend WithEvents txtJnlMemo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBankAct As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBankTranID As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbBusiness As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbBankAccount As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMajorAcct As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubAcct As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnExtraDays As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbExternalSource As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbReceipt As System.Windows.Forms.CheckBox
    Friend WithEvents ddlActivity As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
