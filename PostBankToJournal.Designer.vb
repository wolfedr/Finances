<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostBankToJournal
    Inherits baseform

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PostBankToJournal))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnDeposit = New System.Windows.Forms.Button
        Me.ddlActivity = New System.Windows.Forms.ComboBox
        Me.lblActivity = New System.Windows.Forms.Label
        Me.btnChange = New System.Windows.Forms.Button
        Me.txtMasterAct = New System.Windows.Forms.TextBox
        Me.cmbBusiness = New System.Windows.Forms.ComboBox
        Me.txtBankAct = New System.Windows.Forms.TextBox
        Me.lblBank = New System.Windows.Forms.Label
        Me.btnSkip = New System.Windows.Forms.Button
        Me.lblHdnBusID = New System.Windows.Forms.Label
        Me.btnBusiness = New System.Windows.Forms.Button
        Me.btnGet = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnPost = New System.Windows.Forms.Button
        Me.txtAcntNum = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtActName = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtMemo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtChkNum = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPostDate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtType = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvAccounts = New System.Windows.Forms.DataGridView
        Me.actDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.actName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblCaption = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnAddAcct = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.ddlActTyp = New System.Windows.Forms.ComboBox
        Me.lblHdnTagID = New System.Windows.Forms.Label
        Me.btnSplit = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.btnDeposit)
        Me.Panel1.Controls.Add(Me.ddlActivity)
        Me.Panel1.Controls.Add(Me.lblActivity)
        Me.Panel1.Controls.Add(Me.btnChange)
        Me.Panel1.Controls.Add(Me.txtMasterAct)
        Me.Panel1.Controls.Add(Me.cmbBusiness)
        Me.Panel1.Controls.Add(Me.txtBankAct)
        Me.Panel1.Controls.Add(Me.lblBank)
        Me.Panel1.Controls.Add(Me.btnSkip)
        Me.Panel1.Controls.Add(Me.lblHdnBusID)
        Me.Panel1.Controls.Add(Me.btnBusiness)
        Me.Panel1.Controls.Add(Me.btnGet)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnPost)
        Me.Panel1.Controls.Add(Me.txtAcntNum)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtActName)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtMemo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtDesc)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtChkNum)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtPostDate)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtType)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(63, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 639)
        Me.Panel1.TabIndex = 1
        '
        'btnDeposit
        '
        Me.btnDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.Location = New System.Drawing.Point(161, 466)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(126, 23)
        Me.btnDeposit.TabIndex = 33
        Me.btnDeposit.Text = "Break up Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        Me.btnDeposit.Visible = False
        '
        'ddlActivity
        '
        Me.ddlActivity.FormattingEnabled = True
        Me.ddlActivity.Location = New System.Drawing.Point(140, 197)
        Me.ddlActivity.Name = "ddlActivity"
        Me.ddlActivity.Size = New System.Drawing.Size(180, 21)
        Me.ddlActivity.TabIndex = 32
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.Location = New System.Drawing.Point(57, 197)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(41, 13)
        Me.lblActivity.TabIndex = 31
        Me.lblActivity.Text = "Activity"
        '
        'btnChange
        '
        Me.btnChange.Enabled = False
        Me.btnChange.Location = New System.Drawing.Point(342, 170)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(40, 23)
        Me.btnChange.TabIndex = 30
        Me.btnChange.Text = "New"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'txtMasterAct
        '
        Me.txtMasterAct.Enabled = False
        Me.txtMasterAct.Location = New System.Drawing.Point(199, 358)
        Me.txtMasterAct.Name = "txtMasterAct"
        Me.txtMasterAct.Size = New System.Drawing.Size(149, 20)
        Me.txtMasterAct.TabIndex = 30
        '
        'cmbBusiness
        '
        Me.cmbBusiness.FormattingEnabled = True
        Me.cmbBusiness.Location = New System.Drawing.Point(140, 170)
        Me.cmbBusiness.Name = "cmbBusiness"
        Me.cmbBusiness.Size = New System.Drawing.Size(180, 21)
        Me.cmbBusiness.TabIndex = 29
        '
        'txtBankAct
        '
        Me.txtBankAct.Enabled = False
        Me.txtBankAct.Location = New System.Drawing.Point(140, 411)
        Me.txtBankAct.Name = "txtBankAct"
        Me.txtBankAct.Size = New System.Drawing.Size(208, 20)
        Me.txtBankAct.TabIndex = 29
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.Location = New System.Drawing.Point(49, 412)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(85, 13)
        Me.lblBank.TabIndex = 28
        Me.lblBank.Text = "Bank Account #"
        '
        'btnSkip
        '
        Me.btnSkip.Location = New System.Drawing.Point(185, 524)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(75, 23)
        Me.btnSkip.TabIndex = 26
        Me.btnSkip.Text = "Disregard"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'lblHdnBusID
        '
        Me.lblHdnBusID.AutoSize = True
        Me.lblHdnBusID.Location = New System.Drawing.Point(298, 553)
        Me.lblHdnBusID.Name = "lblHdnBusID"
        Me.lblHdnBusID.Size = New System.Drawing.Size(0, 13)
        Me.lblHdnBusID.TabIndex = 24
        Me.lblHdnBusID.Visible = False
        '
        'btnBusiness
        '
        Me.btnBusiness.Image = CType(resources.GetObject("btnBusiness.Image"), System.Drawing.Image)
        Me.btnBusiness.Location = New System.Drawing.Point(359, 118)
        Me.btnBusiness.Name = "btnBusiness"
        Me.btnBusiness.Size = New System.Drawing.Size(23, 23)
        Me.btnBusiness.TabIndex = 5
        Me.btnBusiness.UseVisualStyleBackColor = True
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(185, 437)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(75, 23)
        Me.btnGet.TabIndex = 23
        Me.btnGet.Text = "Get Next"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(185, 553)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPost
        '
        Me.btnPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.Location = New System.Drawing.Point(185, 495)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(75, 23)
        Me.btnPost.TabIndex = 21
        Me.btnPost.Text = "Post"
        Me.btnPost.UseVisualStyleBackColor = True
        '
        'txtAcntNum
        '
        Me.txtAcntNum.Enabled = False
        Me.txtAcntNum.Location = New System.Drawing.Point(140, 358)
        Me.txtAcntNum.Name = "txtAcntNum"
        Me.txtAcntNum.Size = New System.Drawing.Size(61, 20)
        Me.txtAcntNum.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(49, 359)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Account Number"
        '
        'txtActName
        '
        Me.txtActName.Enabled = False
        Me.txtActName.Location = New System.Drawing.Point(140, 385)
        Me.txtActName.Name = "txtActName"
        Me.txtActName.Size = New System.Drawing.Size(208, 20)
        Me.txtActName.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 386)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Account Name"
        '
        'txtMemo
        '
        Me.txtMemo.Enabled = False
        Me.txtMemo.Location = New System.Drawing.Point(140, 289)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(208, 63)
        Me.txtMemo.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Memo"
        '
        'txtDesc
        '
        Me.txtDesc.Enabled = False
        Me.txtDesc.Location = New System.Drawing.Point(140, 231)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(208, 52)
        Me.txtDesc.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Business"
        '
        'txtChkNum
        '
        Me.txtChkNum.Enabled = False
        Me.txtChkNum.Location = New System.Drawing.Point(140, 144)
        Me.txtChkNum.Name = "txtChkNum"
        Me.txtChkNum.Size = New System.Drawing.Size(208, 20)
        Me.txtChkNum.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Check Number"
        '
        'txtAmount
        '
        Me.txtAmount.Enabled = False
        Me.txtAmount.Location = New System.Drawing.Point(140, 118)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(208, 20)
        Me.txtAmount.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Amount"
        '
        'txtPostDate
        '
        Me.txtPostDate.Enabled = False
        Me.txtPostDate.Location = New System.Drawing.Point(140, 92)
        Me.txtPostDate.Name = "txtPostDate"
        Me.txtPostDate.Size = New System.Drawing.Size(208, 20)
        Me.txtPostDate.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Post Date"
        '
        'txtType
        '
        Me.txtType.Enabled = False
        Me.txtType.Location = New System.Drawing.Point(140, 66)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(208, 20)
        Me.txtType.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Morris Bank Transaction Reconcile and Import"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(140, 40)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(208, 20)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction ID"
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.actDescription, Me.actNum, Me.actName})
        Me.dgvAccounts.Location = New System.Drawing.Point(702, 84)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.Size = New System.Drawing.Size(394, 438)
        Me.dgvAccounts.TabIndex = 2
        '
        'actDescription
        '
        Me.actDescription.HeaderText = "Description"
        Me.actDescription.Name = "actDescription"
        Me.actDescription.Width = 300
        '
        'actNum
        '
        Me.actNum.HeaderText = "actNum"
        Me.actNum.Name = "actNum"
        Me.actNum.Visible = False
        '
        'actName
        '
        Me.actName.HeaderText = "actName"
        Me.actName.Name = "actName"
        Me.actName.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(501, 533)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(851, 71)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(69, 19)
        Me.lblCaption.TabIndex = 4
        Me.lblCaption.Text = "  Caption"
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(850, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 26)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Account"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAddAcct
        '
        Me.btnAddAcct.Location = New System.Drawing.Point(489, 144)
        Me.btnAddAcct.Name = "btnAddAcct"
        Me.btnAddAcct.Size = New System.Drawing.Size(109, 23)
        Me.btnAddAcct.TabIndex = 6
        Me.btnAddAcct.Text = "Add Account"
        Me.btnAddAcct.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(858, 558)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ddlActTyp
        '
        Me.ddlActTyp.Location = New System.Drawing.Point(531, 375)
        Me.ddlActTyp.Name = "ddlActTyp"
        Me.ddlActTyp.Size = New System.Drawing.Size(121, 21)
        Me.ddlActTyp.TabIndex = 1
        Me.ddlActTyp.Visible = False
        '
        'lblHdnTagID
        '
        Me.lblHdnTagID.AutoSize = True
        Me.lblHdnTagID.Location = New System.Drawing.Point(639, 23)
        Me.lblHdnTagID.Name = "lblHdnTagID"
        Me.lblHdnTagID.Size = New System.Drawing.Size(45, 13)
        Me.lblHdnTagID.TabIndex = 28
        Me.lblHdnTagID.Text = "Label13"
        Me.lblHdnTagID.Visible = False
        '
        'btnSplit
        '
        Me.btnSplit.Location = New System.Drawing.Point(489, 278)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.Size = New System.Drawing.Size(109, 23)
        Me.btnSplit.TabIndex = 29
        Me.btnSplit.Text = "Split"
        Me.btnSplit.UseVisualStyleBackColor = True
        Me.btnSplit.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(819, 529)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(759, 535)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Search"
        '
        'PostBankToJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1166, 688)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSplit)
        Me.Controls.Add(Me.lblHdnTagID)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAddAcct)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.ddlActTyp)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "PostBankToJournal"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.dgvAccounts, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.ddlActTyp, 0)
        Me.Controls.SetChildIndex(Me.lblCaption, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.btnAddAcct, 0)
        Me.Controls.SetChildIndex(Me.btnRefresh, 0)
        Me.Controls.SetChildIndex(Me.lblHdnTagID, 0)
        Me.Controls.SetChildIndex(Me.btnSplit, 0)
        Me.Controls.SetChildIndex(Me.txtSearch, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnPost As System.Windows.Forms.Button
    Friend WithEvents txtAcntNum As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtActName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMemo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtChkNum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPostDate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents btnGet As System.Windows.Forms.Button
    Friend WithEvents btnBusiness As System.Windows.Forms.Button
    Friend WithEvents lblHdnBusID As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents actDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddAcct As System.Windows.Forms.Button
    Friend WithEvents btnSkip As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtBankAct As System.Windows.Forms.TextBox
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents txtMasterAct As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents cmbBusiness As System.Windows.Forms.ComboBox
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents ddlActTyp As System.Windows.Forms.ComboBox
    Friend WithEvents ddlActivity As System.Windows.Forms.ComboBox
    Friend WithEvents lblActivity As System.Windows.Forms.Label
    Friend WithEvents lblHdnTagID As System.Windows.Forms.Label
    Friend WithEvents btnSplit As System.Windows.Forms.Button
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label


End Class
