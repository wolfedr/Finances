Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.VisualBasic
Public Class Allocate
    Dim oCommand As SqlCommand
    Dim reader As SqlDataReader
    Dim cn As SqlConnection
    Dim dr As SqlDataReader
    Dim LoadComplete As Boolean = False
    Private Sub Allocate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rbATM.Checked = True
        rbExpense.Checked = True
        DisplayGrid()
        LoadList()
    End Sub
    Sub LoadList()
        Dim strSql As String
        Dim n As Integer = 0
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        If rbATM.Checked = True Then

            strSql = "Select jnlID,jnlTranType, Convert(varchar, jnlTranDate, 101), Convert(varchar(10), Convert(money, jnlTranAmount)) from "
            strSql += "tblDRJournal where jnlActNum = 8590 and jnlActSeq = 7  Order by jnlTranDate"
            oCommand = New SqlCommand(strSql, cn)
            cn.Open()
            dgvTransactions.RowCount = 1
            Dim dr As SqlDataReader = oCommand.ExecuteReader()
            dgvAccounts.Refresh()
            If dr.HasRows Then
                While dr.Read

                    dgvTransactions.Rows.Item(n).Cells(0).Value = dr(0).ToString()
                    dgvTransactions.Rows.Item(n).Cells(1).Value = dr(1).ToString()
                    dgvTransactions.Rows.Item(n).Cells(2).Value = dr(2).ToString()
                    dgvTransactions.Rows.Item(n).Cells(3).Value = dr(3).ToString()
                    n = dgvTransactions.Rows.Add()
                End While



            End If





        End If



    End Sub



    Sub DisplayGrid()
        Dim strActType As String
        If rbExpense.Checked = True Then
            strActType = "expense"
        Else
            strActType = "income"
        End If
        Dim strSql As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        dgvAccounts.RowCount = 1 'This clears any data out of the gird
        strSql = "select acntID, (str(actNum) + '-' + LTrim(str(actNumSeq))) as actNumJoin, actName, actDescription "
        strSql += "from tblDRCOA where actUse = 20" & " And actTypeName = '" & strActType & "' "
        'lblCaption.Text = selectedAccount
        'Select Case selectedAccount
        '    Case "Assets"
        'strSql += " and actNum > 999 and actNum < 2000 "
        '    Case "Debts"
        'strSql += " and actNum > 1999 and actNum < 3000 "
        '   Case "Income"
        'strSql += " and actNum > 3999 and actNum < 7000 "
        '    Case "Expense"
        'strSql += " and actNum > 6999 and actNum < 10000 "
        '    Case Else
        'strSql = ""
        'End Select
        strSql += "order by actNum, actDescription "
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim dr As SqlDataReader = oCommand.ExecuteReader()
        Dim dt As New DataTable
        Dim count As Integer = dr.FieldCount - 1
        'add rows TO GRID
        Dim n As Integer = 0
        dgvAccounts.Refresh()
        Dim aRecord As String = ""
        Dim bRecord As String = ""

        Do While dr.Read()
            aRecord = Trim(dr(2).ToString())
            If aRecord <> bRecord Then
                bRecord = aRecord
                dgvAccounts.Rows.Item(n).Cells(0).Value = dr(2).ToString()
                dgvAccounts.Rows.Item(n).Cells(1).Value = 0
                dgvAccounts.Rows.Item(n).Cells(2).Value = 0
                Me.dgvAccounts.Rows(n).Cells(0).Style.BackColor = Color.Cyan
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.dgvAccounts.Rows(n).Cells(0).Style.Font = New Font("calibri", 14, FontStyle.Bold)
                n = dgvAccounts.Rows.Add()
                'GoTo JUMP
                dgvAccounts.Rows.Item(n).Cells(0).Value = Trim(dr.GetString(3))
                dgvAccounts.Rows.Item(n).Cells(1).Value = Trim(dr.GetString(1))
                dgvAccounts.Rows.Item(n).Cells(3).Value = Convert.ToInt32(dr(0))
                n = dgvAccounts.Rows.Add()
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            Else
                dgvAccounts.Rows.Item(n).Cells(0).Value = Trim(dr.GetString(3))
                dgvAccounts.Rows.Item(n).Cells(1).Value = Trim(dr.GetString(1))
                dgvAccounts.Rows.Item(n).Cells(3).Value = Convert.ToInt32(dr(0))
                n = dgvAccounts.Rows.Add()
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            End If
            'Exit Sub
JUMP:   Loop
        LoadComplete = True

        cn.Close()
    End Sub
    Private Sub dgvAccounts_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.RowEnter
        Dim i As Integer = e.RowIndex
        Dim cell1 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(1), DataGridViewCell)
        Dim cell2 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(0), DataGridViewCell)
        Dim cell3 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(3), DataGridViewCell)
        If LoadComplete = True Then
            If cell1.Value <> Nothing Then
                txtAccountNum.Text = cell1.Value.ToString().Trim
                txtAccountname.Text = cell2.Value.ToString().Trim
                hdnActID.Text = cell3.Value.ToString().Trim
            End If
        End If
    End Sub


    Private Sub dgvTransactions_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTransactions.RowEnter
        Dim i As Integer = e.RowIndex
        Dim cell1 As DataGridViewCell = CType(dgvTransactions.Rows(e.RowIndex).Cells(0), DataGridViewCell) 'ID
        Dim cell2 As DataGridViewCell = CType(dgvTransactions.Rows(e.RowIndex).Cells(1), DataGridViewCell)  'Type
        Dim cell3 As DataGridViewCell = CType(dgvTransactions.Rows(e.RowIndex).Cells(2), DataGridViewCell) 'Date
        Dim cell4 As DataGridViewCell = CType(dgvTransactions.Rows(e.RowIndex).Cells(3), DataGridViewCell)  'aMOUNT

        If LoadComplete = True Then
            If cell1.Value <> Nothing Then
                txtSplitAmount.Text = cell4.Value.ToString().Trim 'ATM Aount
                lbtlTranDate.Text = cell3.Value.ToString().Trim    'Transaction date
                lblTranType.Text = "CASH"   'Transaction type
                hdnATMID.Text = cell1.Value.ToString().Trim
            End If
        End If
    End Sub


    Private Sub rbExpense_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExpense.CheckedChanged
        DisplayGrid()
    End Sub
End Class