Imports System.Data.SqlClient
Imports System.Configuration
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Globalization

Public Class rptJournal
    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim blnComplete As Boolean = False
    Public intPreCheckedID As Int32
    Dim aryAll As ArrayList = New ArrayList

    Private Sub rptTransactions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DisplayData()
        If intPreCheckedID > 0 Then
            Dim myInt As Int32 = intPreCheckedID
        End If
        'DisplaySummary()
        'On load set the combo box  defaults
     
    End Sub
  
    Public Sub DisplayData()
        dgvTransactions.Visible = True
        dgvTransactions.Refresh()
        Dim myTotalRv As Single = 0
        Dim myTotalEx As Single = 0
        Dim myTran As JnlTran
        myTran = New JnlTran
        Dim YR As Int16 = 0
        Dim MO As Int16 = 0
        Dim ACTN As Int16 = 0
        Dim ACTS As Int16 = 0
        Dim BKA As String = ""
        Dim ENT As String = ""

        Dim strSql As String

        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        'Basic query to retrieve journal records for analysis
        strSql = "SELECT  a.jnlID, a.jnlTranDate,  d.actName,(ltrim(a.jnlActNum) + '-' + ltrim(a.jnlActSeq)) as Account, a.jnlTranType, a.jnlTranAmount, b.busName, "
        strSql += "a.jnlTranDesc, a.jnlTranMemo, c.actDescription, e.ActivityDescription  "
        strSql += "FROM tblDRJournal a, tblBusiness b, tblDRCOA c, tblBankAcct d, tblActivity e "
        strSql += "WHERE a.jnlTranBusinessID = b.busID And a.jnlActNum = c.actNum And a.jnlActSeq = c.actNumSeq and a.jnlBankAct = d.actNum AND a.jnlActivityID = e.ActivityID  "
        strSql += " order by jnlID desc"




        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, cn)
        Dim dt As DataTable = New DataTable
        cn.Open()
        da.Fill(dt)
        cn.Close()
        cn.Close()
        da.Dispose()
        da = Nothing


        Dim MyTable As DataTable = dt
        If MyTable.Rows.Count > 0 Then
            dgvTransactions.DataSource = MyTable
            '    If Not IsDBNull(MyTable.Compute("SUM(jnlTranAmount)", "N > = 3 and N < 6 ")) Then
            '        myTotalEx = MyTable.Compute("SUM(jnlTranAmount)", "N > 3 and N < 6 ")
            '    End If

            '    If Not IsDBNull(MyTable.Compute("SUM(jnlTranAmount)", "N > = 6 and N < 9 ")) Then
            '        myTotalRv = MyTable.Compute("SUM(jnlTranAmount)", "N > = 6 and N < 9 ")
            '    End If
        Else
            dgvTransactions.Visible = False
            MsgBox("No Data available for display. Change your selections.", MsgBoxStyle.Information, "No Data")

        End If

        'DisplaySummary(strSql2, strSql3)

    End Sub

    Private Sub dgvTransactions_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvTransactions.CellFormatting
        Dim dteTD As Date
        Dim intMonth As Integer
        If dgvTransactions.Columns(e.ColumnIndex).Name = "jnlTranDate" Then
            dteTD = e.Value
            intMonth = dteTD.Month
            ' If the value of the cell is a given month
            Select Case intMonth
                Case 1, 3, 5, 7, 9, 11
                    e.CellStyle.BackColor = Color.AntiqueWhite
                Case 2, 4, 6, 8, 10, 12
                    e.CellStyle.BackColor = Color.LightBlue
                Case Else
            End Select
        End If
        ''Dim x As String = dgvTransactions.Rows(e.RowIndex).Cells(2).Value
        'If dgvTransactions.Columns(e.ColumnIndex).Name = "Account" Then
        '    Dim xTest As String = e.Value.ToString.Substring(0, 1)
        'End If        
        'Dim strAcct As String = dgvTransactions.Columns(e.ColumnIndex).Name =
    End Sub

    Function strCurrencyToDecimalByVal(ByVal Value As String) As Decimal
        If Value.Length = 0 Then
            Return 0
        Else
            Return Decimal.Parse(Value.Replace("(", "-"), Globalization.NumberStyles.Any And Globalization.NumberStyles.AllowCurrencySymbol And Globalization.NumberStyles.AllowThousands And Globalization.NumberStyles.AllowDecimalPoint)
        End If
    End Function

    Private Sub dgvTransactions_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTransactions.RowEnter
        Dim i As Integer = e.RowIndex
        'Dim strAct As String = dgvTransactions.Rows(e.RowIndex).Cells(2).Value.ToString
        'Dim decAmount As Decimal = Convert.ToDecimal(dgvTransactions.Rows(e.RowIndex).Cells(4).Value.ToString)
        Exit Sub
        'Dim lp As Char = "("
        'Dim rp As Char = ")"
        'Dim ds As Char = "$"
        'Dim dc As Char = "-"
        'dgvTransactions.Rows(e.RowIndex).HeaderCell.Value = ">>"
        'Dim columnDte As DataGridViewColumn = dgvTransactions.Columns(1)
        'columnDte.HeaderText = "Date"
        'columnDte.Width = 75
        'columnDte.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Dim columnBac As DataGridViewColumn = dgvTransactions.Columns(2)
        'columnBac.HeaderText = "Bank Account"
        'columnBac.Width = 100
        'columnBac.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        'Dim columnAct As DataGridViewColumn = dgvTransactions.Columns(3)
        'columnAct.HeaderText = "Account"
        'columnAct.Width = 55
        'columnAct.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Dim columnTpe As DataGridViewColumn = dgvTransactions.Columns(4)
        'columnTpe.HeaderText = "Type"
        'columnTpe.Width = 30
        'columnTpe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Dim columnAmt As DataGridViewColumn = dgvTransactions.Columns(5)
        'columnAmt.HeaderText = "Amount"
        'columnAmt.Width = 75
        'columnAmt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'columnAmt.DefaultCellStyle.Format = "c"

        'Dim columnBus As DataGridViewColumn = dgvTransactions.Columns(6)
        'columnBus.HeaderText = "Business"
        'columnBus.Width = 125
        'columnBus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Dim columnDsc As DataGridViewColumn = dgvTransactions.Columns(7)
        'columnDsc.HeaderText = "Description"
        'columnDsc.Width = 200
        'columnDsc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Dim columnMem As DataGridViewColumn = dgvTransactions.Columns(8)
        'columnMem.HeaderText = "Memo"
        'columnMem.Width = 150
        'columnMem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Dim columnNme As DataGridViewColumn = dgvTransactions.Columns(9)
        'columnNme.HeaderText = "Account Name"
        'columnNme.Width = 150
        'columnNme.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Dim columnAds As DataGridViewColumn = dgvTransactions.Columns(10)
        'columnAds.HeaderText = "Account Description"
        'columnAds.Width = 150
        'columnAds.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Dim columnXX As DataGridViewColumn = dgvTransactions.Columns(11)
        'columnXX.Visible = False

        'Dim columnExMk As DataGridViewColumn = dgvTransactions.Columns(12)
        'columnExMk.HeaderText = "NP"
        'columnExMk.Width = 80
        'columnExMk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Dim columnRec As DataGridViewColumn = dgvTransactions.Columns(13)
        'columnRec.HeaderText = "Rec."
        'columnRec.Width = 30
        'columnRec.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


    End Sub


    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DisplayData()
        'DisplaySummary()
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        Dim strDir As String = ConfigurationManager.AppSettings("DIR")
        Dim strFile As String = Date.Now.ToOADate.ToString() & "Data.xls"

        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        For i = 0 To dgvTransactions.RowCount - 2
            For j = 4 To dgvTransactions.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) = _
                   dgvTransactions(j, i).Value.ToString()
            Next
        Next

        xlWorkSheet.SaveAs(strDir & "\" & strFile)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("You can find the file " & strDir & "\" & strFile)

    End Sub


  

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim dgvRow As DataGridViewRow = dgvTransactions.SelectedRows.Item(0)

        Debug.Print(dgvRow.Cells(0).Value) ' Shows value form first column of each selected row
        Debug.Print(dgvRow.Cells(1).Value)
        Debug.Print(dgvRow.Cells(2).Value)
        Debug.Print(dgvRow.Cells(3).Value)
        Debug.Print(dgvRow.Cells(4).Value)
        Debug.Print(dgvRow.Cells(5).Value)
    End Sub


    Private Sub dgvTransactions_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTransactions.CellContentClick
        Dim x As Integer = e.ColumnIndex
        If x = 1 Then
            Dim myID As Int32 = Convert.ToInt32(dgvTransactions.Item(e.ColumnIndex, e.RowIndex).Value)
            JournalDetail.strID = myID
            EditJournal.strStart = myID
            EditJournal.StrSource = "rptTransactions"
            Me.Close()
            EditJournal.ShowDialog()

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Main.Show()
    End Sub



End Class

Public Class busRecord1
    Private stor0 As String
    Private stor1 As String
    Private stor2 As String

    Public Sub busRecord1(ByVal StorName As String, ByVal StorID As String, ByVal StorIndex As Long)
        stor0 = StorIndex
        stor1 = StorName
        stor2 = StorID
    End Sub

    Property StorIndex() As String
        Get
            Return stor0
        End Get
        Set(ByVal Value As String)
            stor0 = Value
        End Set
    End Property

    Property StorName() As String
        Get
            Return stor1
        End Get
        Set(ByVal Value As String)
            stor1 = Value
        End Set
    End Property

    Property StorID() As String
        Get
            Return stor2
        End Get
        Set(ByVal Value As String)
            stor2 = Value
        End Set
    End Property

End Class
