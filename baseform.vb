Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Xml
Imports System.Text

Public Class baseform
    Public frmTitle As String
    Public frmCalling As String = ""
    '**************************************************************************
    'This form establishes the action of the menu choices
    'Reports|Account Expenses=AccountExpensesToolStripMenuItem_Click
    'Tools|Utilities|Add/Edit business = ManageBusinessToolStripMenuItem_Click
    'Post = PostToolStripMenuItem_Click
    'Tools|Utilities|Add/Edit Accounts=ManageAccountToolStripMenuItem_Click
    'Tools|Transactions=TransactionsToolStripMenuItem_Click
    'Import|Import Bank Data = ImportBankDataToolStripMenuItem_Click
    'Import:Get Bank Data = GoToBankToolStripMenuItem_Click
    'Reports|Business Expenses= BusinessesDataToolStripMenuItem_Click
    '***************************************************************************
    Private Sub baseform_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'frmTitle = "Dublin RISING Accounts"
        lblTitle.Text = frmTitle
        'lblModule.Text = "baseform"
    End Sub
    'Private Sub AccountExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicToolStripMenuItem.Click
    '    '**************Account Expenses*************
    '    Dim myForm As rptAccountExpense
    '    myForm = New rptAccountExpense
    '    Me.Hide()
    '    myForm.Show()
    'End Sub

    Private Sub ManageBusinessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBusinessToolStripMenuItem.Click
        '*****************Add a Business ******************
        Dim myForm As AddBusiness
        myForm = New AddBusiness
        myForm.frmCalling = "baseAddBusiness"
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub PostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostToolStripMenuItem.Click
        '*************Post Transaction from input table to journal*****************
        Dim myForm As PostBankToJournal
        myForm = New PostBankToJournal
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub ManageAccountToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ManageAccountToolStripMenuItem.Click
        '************Manage Accounts
        Dim myForm As ManageAccount
        myForm = New ManageAccount
        frmCalling = "baseManageAccount"
        Me.Hide()
        myForm.Show()

    End Sub

    Private Sub ImportBankDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportBankDataToolStripMenuItem.Click
        '*********Import Morris Data*****************
        Dim myForm As ImportMorrisData
        myForm = New ImportMorrisData
        'Me.Hide()
        myForm.Show()

    End Sub

    Private Sub GoToBankToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoToBankToolStripMenuItem.Click
        '*********Connect to Bank*****************
        Dim p As System.Diagnostics.Process = New System.Diagnostics.Process()
        Dim DialogBox As New GetMorris
        DialogBox.Left = 500
        If DialogBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            p.StartInfo.FileName = "iexplore.exe"
            p.StartInfo.Arguments = "http://www.wellsfargo.com"
            p.Start()

        End If
    End Sub

    Private Sub BusinessesDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusinessesToolStripMenuItem.Click
        '************Business Expenses*************
        Dim myForm As rptBusiness
        myForm = New rptBusiness
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        '**********Exit Morris Bank **********************
        Application.Exit()
    End Sub

    Private Sub EditJournalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditJournalToolStripMenuItem.Click
        '*******Edit Journal**********
        Dim myForm As EditJournal
        myForm = New EditJournal
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub ViewTransactionsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTransactionsToolStripMenuItem1.Click
        '**********View Transactions**************
        Dim myForm As rptTransactions
        myForm = New rptTransactions
        Me.Hide()
        myForm.Show()
    End Sub

    'Private Sub GraphicsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraphicsToolStripMenuItem.Click
    '    Dim myForm As frmVisualStatus
    '    myForm = New frmVisualStatus
    '    'Me.Hide()
    '    myForm.Show()
    'End Sub

    'Private Sub MonthlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyToolStripMenuItem.Click
    '    '************ Monthly *****************
    '    Dim myForm As rptFinancialA
    '    myForm = New rptFinancialA
    '    Me.Hide()
    '    myForm.Show()
    'End Sub
    Private Sub SplitCashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplitCashToolStripMenuItem.Click

        'Split Transaction
        'Dim myForm As AllocateEntry
        'myForm = New AllocateEntry
        'Me.Hide()
        'myForm.Show()
        'Dim myForm As Distribute
        'myForm = New Distribute
        'Me.Hide()
        'myForm.Show()
        'Dim myForm As AllocateCash
        'myForm = New AllocateCash
        'Me.Hide()
        'myForm.Show()
        Dim myForm As AllocateCash
        myForm = New AllocateCash
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub AddEditActivityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditActivityToolStripMenuItem.Click
        '***********Add/Edit Activity
        Dim myForm As AddActivity
        myForm = New AddActivity
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub NonProfitsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NonProfitsToolStripMenuItem.Click
        Dim myForm As rptNonProfit
        myForm = New rptNonProfit
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub TransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionsToolStripMenuItem.Click
        'Enter Journal Transaction
        Dim myForm As EnterJournalTransaction
        myForm = New EnterJournalTransaction
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub menuViewBankTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'View Bank Transaction
        Dim myForm As rptBankTransactions
        myForm = New rptBankTransactions
        'Dim myForm As rptTransactions
        'myForm = New rptTransactions
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub menuViewBankTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuViewBankTest.Click
        'View Bank Test
        'Dim myForm As rptBankTransactions
        'myForm = New rptBankTransactions
        Dim myForm As Form1
        myForm = New Form1
        myForm.Show()
    End Sub

    Private Sub RentalStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'View Rental Status
        Dim myForm As rptRentalStatus
        myForm = New rptRentalStatus
        myForm.Show()
    End Sub

    Private Sub IncomeExpenseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncomeExpenseToolStripMenuItem.Click
        'View FIniancial Statmens Inc & Exp
        Dim myForm As rptIncExp
        myForm = New rptIncExp
        'Dim myForm As rptBasic
        'myForm = New rptBasic
        myForm.Show()
    End Sub

    Private Sub BalanceSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalanceSheetToolStripMenuItem.Click
        'View FIniancial Statmens balance Sheet
        Dim myForm As rptBalSheet
        myForm = New rptBalSheet
        myForm.Show()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub


    'Private Sub GRIDTESTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRIDTESTToolStripMenuItem.Click
    '    'View FIniancial Statmens balance Sheet
    '    Dim myForm As GRIDTEST
    '    myForm = New GRIDTEST
    '    myForm.Show()

    'End Sub

    Private Sub StraightJournalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StraightJournalToolStripMenuItem.Click
        'View Journal straight out
        Dim myForm As rptJournal
        myForm = New rptJournal
        myForm.Show()
    End Sub

    Private Sub MonthlyBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyBalanceToolStripMenuItem.Click
        'View Journal straight out
        Dim myForm As rptAcctBalTrans
        myForm = New rptAcctBalTrans
        myForm.Show()
    End Sub

    Private Sub SplitDepositToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplitDepositToolStripMenuItem.Click

        Dim myForm As AllocDep
        myForm = New AllocDep
        myForm.Show()
    End Sub

    Private Sub RentalTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentalTransactionsToolStripMenuItem.Click
        '**********View Rental Transactions**************
        Dim myForm As rptRentals
        myForm = New rptRentals
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub AddChecksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddChecksToolStripMenuItem.Click
        '**********View Rental Transactions**************
        Dim myForm As AddChecks
        myForm = New AddChecks
        Me.Hide()
        myForm.Show()


    End Sub

    Private Sub BasicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicToolStripMenuItem.Click
        Dim myForm As rptBasic
        myForm = New rptBasic
        Me.Hide()
        myForm.Show()

    End Sub

    Private Sub ShareDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShareDataToolStripMenuItem.Click
        ShareData.ShowDialog()
        
        'Dim myForm As ShareData
        'myForm = New ShareData
        'myForm.ShowDialog()

        'Me.Hide()
        'Me.Close()


    End Sub
End Class