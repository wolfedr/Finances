<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baseform
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GoToBankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportBankDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BusinessesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewTransactionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.menuViewBankTest = New System.Windows.Forms.ToolStripMenuItem
        Me.NonProfitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IncomeExpenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BalanceSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StraightJournalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MonthlyBalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RentalTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UtilitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UtilitiesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddEditActivityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddBusinessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditJournalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitCashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitDepositToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddChecksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShareDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblRevision = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblModule = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ImportToolStripMenuItem, Me.PostToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.UtilitiesToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MaximumSize = New System.Drawing.Size(300, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(300, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(43, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ExitToolStripMenuItem.Text = "exit"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToBankToolStripMenuItem, Me.ImportBankDataToolStripMenuItem})
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(62, 22)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'GoToBankToolStripMenuItem
        '
        Me.GoToBankToolStripMenuItem.Name = "GoToBankToolStripMenuItem"
        Me.GoToBankToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.GoToBankToolStripMenuItem.Text = "Get Bank Data"
        '
        'ImportBankDataToolStripMenuItem
        '
        Me.ImportBankDataToolStripMenuItem.Name = "ImportBankDataToolStripMenuItem"
        Me.ImportBankDataToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ImportBankDataToolStripMenuItem.Text = "Import Bank Data"
        '
        'PostToolStripMenuItem
        '
        Me.PostToolStripMenuItem.Name = "PostToolStripMenuItem"
        Me.PostToolStripMenuItem.Size = New System.Drawing.Size(47, 22)
        Me.PostToolStripMenuItem.Text = "Post"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicToolStripMenuItem, Me.BusinessesToolStripMenuItem, Me.ViewTransactionsToolStripMenuItem1, Me.menuViewBankTest, Me.NonProfitsToolStripMenuItem, Me.IncomeExpenseToolStripMenuItem, Me.BalanceSheetToolStripMenuItem, Me.StraightJournalToolStripMenuItem, Me.MonthlyBalanceToolStripMenuItem, Me.RentalTransactionsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'BasicToolStripMenuItem
        '
        Me.BasicToolStripMenuItem.Name = "BasicToolStripMenuItem"
        Me.BasicToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.BasicToolStripMenuItem.Text = "Account Expenses"
        '
        'BusinessesToolStripMenuItem
        '
        Me.BusinessesToolStripMenuItem.Name = "BusinessesToolStripMenuItem"
        Me.BusinessesToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.BusinessesToolStripMenuItem.Text = "Businesses Expenses"
        '
        'ViewTransactionsToolStripMenuItem1
        '
        Me.ViewTransactionsToolStripMenuItem1.Name = "ViewTransactionsToolStripMenuItem1"
        Me.ViewTransactionsToolStripMenuItem1.Size = New System.Drawing.Size(238, 22)
        Me.ViewTransactionsToolStripMenuItem1.Text = "View Journal  Transactions"
        '
        'menuViewBankTest
        '
        Me.menuViewBankTest.Name = "menuViewBankTest"
        Me.menuViewBankTest.Size = New System.Drawing.Size(238, 22)
        Me.menuViewBankTest.Text = "ViewBankTransactions"
        '
        'NonProfitsToolStripMenuItem
        '
        Me.NonProfitsToolStripMenuItem.Name = "NonProfitsToolStripMenuItem"
        Me.NonProfitsToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.NonProfitsToolStripMenuItem.Text = "Non Profits"
        '
        'IncomeExpenseToolStripMenuItem
        '
        Me.IncomeExpenseToolStripMenuItem.Name = "IncomeExpenseToolStripMenuItem"
        Me.IncomeExpenseToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.IncomeExpenseToolStripMenuItem.Text = "Income & Expense"
        '
        'BalanceSheetToolStripMenuItem
        '
        Me.BalanceSheetToolStripMenuItem.Name = "BalanceSheetToolStripMenuItem"
        Me.BalanceSheetToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.BalanceSheetToolStripMenuItem.Text = "Balance Sheet"
        '
        'StraightJournalToolStripMenuItem
        '
        Me.StraightJournalToolStripMenuItem.Name = "StraightJournalToolStripMenuItem"
        Me.StraightJournalToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.StraightJournalToolStripMenuItem.Text = "Straight Journal"
        '
        'MonthlyBalanceToolStripMenuItem
        '
        Me.MonthlyBalanceToolStripMenuItem.Name = "MonthlyBalanceToolStripMenuItem"
        Me.MonthlyBalanceToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.MonthlyBalanceToolStripMenuItem.Text = "Monthly Balance"
        '
        'RentalTransactionsToolStripMenuItem
        '
        Me.RentalTransactionsToolStripMenuItem.Name = "RentalTransactionsToolStripMenuItem"
        Me.RentalTransactionsToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.RentalTransactionsToolStripMenuItem.Text = "Rental Transactions"
        '
        'UtilitiesToolStripMenuItem
        '
        Me.UtilitiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UtilitiesToolStripMenuItem1, Me.TransactionsToolStripMenuItem, Me.ShareDataToolStripMenuItem})
        Me.UtilitiesToolStripMenuItem.Name = "UtilitiesToolStripMenuItem"
        Me.UtilitiesToolStripMenuItem.Size = New System.Drawing.Size(52, 22)
        Me.UtilitiesToolStripMenuItem.Text = "Tools"
        '
        'UtilitiesToolStripMenuItem1
        '
        Me.UtilitiesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageAccountToolStripMenuItem, Me.AddEditActivityToolStripMenuItem, Me.AddBusinessToolStripMenuItem, Me.EditJournalToolStripMenuItem, Me.SplitCashToolStripMenuItem, Me.SplitDepositToolStripMenuItem, Me.AddChecksToolStripMenuItem})
        Me.UtilitiesToolStripMenuItem1.Name = "UtilitiesToolStripMenuItem1"
        Me.UtilitiesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.UtilitiesToolStripMenuItem1.Text = "Utilities"
        '
        'ManageAccountToolStripMenuItem
        '
        Me.ManageAccountToolStripMenuItem.Name = "ManageAccountToolStripMenuItem"
        Me.ManageAccountToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ManageAccountToolStripMenuItem.Text = "Add/Edit Accounts"
        '
        'AddEditActivityToolStripMenuItem
        '
        Me.AddEditActivityToolStripMenuItem.Name = "AddEditActivityToolStripMenuItem"
        Me.AddEditActivityToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AddEditActivityToolStripMenuItem.Text = "Add/Edit Activities"
        '
        'AddBusinessToolStripMenuItem
        '
        Me.AddBusinessToolStripMenuItem.Name = "AddBusinessToolStripMenuItem"
        Me.AddBusinessToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AddBusinessToolStripMenuItem.Text = "Add/Edit  Businesses"
        '
        'EditJournalToolStripMenuItem
        '
        Me.EditJournalToolStripMenuItem.Name = "EditJournalToolStripMenuItem"
        Me.EditJournalToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.EditJournalToolStripMenuItem.Text = "Add/Edit Journal"
        '
        'SplitCashToolStripMenuItem
        '
        Me.SplitCashToolStripMenuItem.Name = "SplitCashToolStripMenuItem"
        Me.SplitCashToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SplitCashToolStripMenuItem.Text = "Split ATM"
        '
        'SplitDepositToolStripMenuItem
        '
        Me.SplitDepositToolStripMenuItem.Name = "SplitDepositToolStripMenuItem"
        Me.SplitDepositToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SplitDepositToolStripMenuItem.Text = "Split Deposit"
        '
        'AddChecksToolStripMenuItem
        '
        Me.AddChecksToolStripMenuItem.Name = "AddChecksToolStripMenuItem"
        Me.AddChecksToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AddChecksToolStripMenuItem.Text = "Add Checks"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'ShareDataToolStripMenuItem
        '
        Me.ShareDataToolStripMenuItem.Name = "ShareDataToolStripMenuItem"
        Me.ShareDataToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShareDataToolStripMenuItem.Text = "ShareData"
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(313, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblRevision
        '
        Me.lblRevision.AutoSize = True
        Me.lblRevision.Location = New System.Drawing.Point(1074, 8)
        Me.lblRevision.Name = "lblRevision"
        Me.lblRevision.Size = New System.Drawing.Size(22, 13)
        Me.lblRevision.TabIndex = 27
        Me.lblRevision.Text = "rev"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblTitle.Location = New System.Drawing.Point(456, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(85, 37)
        Me.lblTitle.TabIndex = 27
        Me.lblTitle.Text = "Title"
        '
        'lblModule
        '
        Me.lblModule.AutoSize = True
        Me.lblModule.Location = New System.Drawing.Point(819, 8)
        Me.lblModule.Name = "lblModule"
        Me.lblModule.Size = New System.Drawing.Size(0, 13)
        Me.lblModule.TabIndex = 28
        '
        'baseform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1118, 698)
        Me.Controls.Add(Me.lblModule)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblRevision)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "baseform"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process Morris"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilitiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilitiesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBusinessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToBankToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportBankDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BusinessesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents EditJournalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTransactionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitCashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblRevision As System.Windows.Forms.Label
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEditActivityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NonProfitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuViewBankTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncomeExpenseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BalanceSheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents StraightJournalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlyBalanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitDepositToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RentalTransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddChecksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShareDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblModule As System.Windows.Forms.Label
    'Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
