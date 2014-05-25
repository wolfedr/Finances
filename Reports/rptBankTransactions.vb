Imports System.Data.SqlClient
Imports System.Configuration
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Globalization

Public Class rptBankTransactions
    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim blnComplete As Boolean = False
    Dim AllorPost As Integer
    Public intPreCheckedID As Int32
    Dim aryAll As ArrayList = New ArrayList

    Private Sub rptTransactions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillDropdown()
        DisplayData()
        rbAll.Checked = True
        If intPreCheckedID > 0 Then
            Dim myInt As Int32 = intPreCheckedID
            setPreselectedID(intPreCheckedID)
        End If
        'DisplaySummary()
        'On load set the combo box  defaults
        cmbMonth.SelectedIndex = 0
        cmbYear2.SelectedIndex = 0
        'cmbEntity.SelectedIndex = 0
    End Sub
    Private Sub GetEntries()
        Dim strSql As String = "select * from tblDRTransactions"
        If rbAll.Checked Then
            strSql += " where bnkPostedToJournal = '0' "
        End If
        strSql += " Order by bnkTranPostDate Desc"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader()




    End Sub

    Private Sub setPreselectedID(ByVal intPreset As Int32)
        ' Clear previous selection(s).
        dgvTransactions.ClearSelection()
        Dim colID As Integer = 1
        Dim rowcount As Int32 = dgvTransactions.Rows.Count
        'Look up and select product number in the DataGridview.
        Dim row As DataGridViewRow = New DataGridViewRow
        For i As Int32 = 0 To rowcount - 1
            row = dgvTransactions.Rows(i)
            If row.Cells(colID).Value = intPreset Then
                dgvTransactions.FirstDisplayedScrollingRowIndex = i
                row.Selected = True
                Exit For
            End If
        Next i
    End Sub
    Public Sub DisplayData()
        dgvTransactions.Visible = True
        txtTotalRevenue.Text = "0"
        dgvTransactions.Refresh()
        Dim myTotalRv As Single
        Dim myTotalEx As Single
        Dim myTran As JnlTran
        myTran = New JnlTran
        Dim YR As Int16 = 0
        Dim MO As Int16 = 0
        Dim ACTN As Int16 = 0
        Dim ACTS As Int16 = 0
        Dim BKA As String = ""
        Dim ENT As String = ""
        'Dim strr As String() = cmbAccount.SelectedValue.ToString.Split("-")
        If cmbYear2.SelectedIndex <> 0 Then YR = Convert.ToInt16(cmbYear2.Text)
        If cmbMonth.SelectedIndex <> 0 Then MO = cmbMonth.SelectedIndex
        'If cmbAccount.SelectedIndex <> 0 Then
        'ACTN = Convert.ToInt16(strr(0))
        'ACTS = Convert.ToInt16(strr(1))
        'End If
        'If cmbEntity.SelectedIndex <> 0 Then
        'ENT = BuildEntityList(cmbEntity.Text)
        'End If
        'ENT = cmbEntity.SelectedValue ' aryAll(cmbEntity.SelectedIndex + 1)
        If cmbBankAcct.SelectedIndex <> 0 Then BKA = cmbBankAcct.Text
        Dim MyTable As DataTable = myTran.DisplayData(YR, MO, ACTN, ACTS, BKA, ENT)
        If MyTable.Rows.Count > 0 Then
            dgvTransactions.DataSource = MyTable
            If Not IsDBNull(MyTable.Compute("SUM(jnlTranAmount)", "N > = 3 and N < 6 ")) Then
                myTotalEx = MyTable.Compute("SUM(jnlTranAmount)", "N > 3 and N < 6 ")
            End If
            txtTotalRevenue.Text = myTotalEx.ToString(Microsoft.VisualBasic.Format("c"))

            If Not IsDBNull(MyTable.Compute("SUM(jnlTranAmount)", "N > = 6 and N < 9 ")) Then
                myTotalRv = MyTable.Compute("SUM(jnlTranAmount)", "N > = 6 and N < 9 ")
            End If
            txtTotalExpense.Text = myTotalRv.ToString(Microsoft.VisualBasic.Format("c"))

        Else
            dgvTransactions.Visible = False
            MsgBox("No Data available for display. Change your selections.", MsgBoxStyle.Information, "No Data")

        End If

        'DisplaySummary(strSql2, strSql3)

    End Sub
    Function BuildEntityList(ByVal strSeedEntry As String) As String
        Dim strSql As String = "select busID from tblBusiness where busName = '" & strSeedEntry & "'"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader()
        Dim strCombinedEntry As String = ""
        If dr.HasRows Then
            While dr.Read
                strCombinedEntry += (dr(0)).ToString.Trim & ","
            End While
            Dim n As Integer = strCombinedEntry.Length
            strCombinedEntry = Microsoft.VisualBasic.Left(strCombinedEntry, n - 1)
        End If
        cn.Close()
        Return strCombinedEntry
    End Function
    'Sub DisplaySummary(ByVal strSqlA As String, ByVal strSqlB As String)

    'Dim strSql As String
    'cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
    'If rbMajor.Checked = True Then
    'This query will return all accounts but not sub accounts.
    'strSql = strSqlB
    'Else
    ''This sql will return all accounts and sub accounts. 
    'strSql = strSqlA
    'End If
    'da = New SqlDataAdapter(strSql, cn)
    'ds = New DataSet
    'cn.Open()
    'dgvSummary.Refresh()
    'da.Fill(ds)
    'If ds.Tables(0).Rows.Count > 0 Then
    '    dgvSummary.DataSource = ds.Tables(0)
    'End If
    'End Sub

    Private Sub FillDropdown()
        'Fill combobox for businesses.
        Dim strSql As String = "select busID, busName from tblBusiness order by busName"
        Dim aryBusiness As ArrayList = New ArrayList
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader
        Dim strFound, storName, storID As String
        Dim lngIndex As Long = 0
        strFound = " " 'Set initial found to space
        storName = ""
        storID = ""
        dr.Read()
        Dim recordBus As New busRecord2
        storName += "All"
        storID += "0"
        recordBus.StorIndex = lngIndex
        recordBus.StorID = storID
        recordBus.StorName = storName
        aryBusiness.Add(recordBus)
        aryAll.Add(0)
        recordBus = New busRecord2
        lngIndex += 1
        recordBus.StorIndex = lngIndex
        recordBus.StorName = dr(1).ToString
        recordBus.StorID = dr(0).ToString
        aryAll.Add(storID)
        aryBusiness.Add(recordBus) 'place in array for viewing
        recordBus = New busRecord2
        While dr.Read()
            Dim testa As String = dr(1)
            Dim testb As String = dr(0)
            If dr(1).ToString.Trim = storName Then  'This mean the entry name matched the previous one.
                storID += ", " & dr(0)  ' Conactenate the ID values. Loop and get another record
            Else  'This means it did not, so save the stored one and replace stored values with new ones.
                lngIndex += 1
                recordBus.StorIndex = lngIndex
                recordBus.StorName = dr(1).ToString
                recordBus.StorID = dr(0).ToString
                aryAll.Add(storID)
                aryBusiness.Add(recordBus) 'place in array for viewing
                storName = dr(1).ToString.Trim
                storID = dr(0).ToString
            End If
            recordBus = New busRecord2
        End While
        cn.Close()
        'cmbEntity.DataSource = aryBusiness
        'cmbEntity.DisplayMember = "Storname"
        'cmbEntity.ValueMember = "StorID"

        'Combobox for Bank Accounts
        strSql = "Select actNum, actName from tblBankAcct order by actName"
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(strSql, cn)
        Dim ds As DataSet = New DataSet
        da.Fill(ds)
        Dim myRow As DataRow
        myRow = ds.Tables(0).NewRow
        myRow(0) = 0
        myRow(1) = "All"
        ds.Tables(0).Rows.InsertAt(myRow, 0)
        cmbBankAcct.DataBindings.Add("DataSource", ds, ds.Tables(0).TableName)
        cmbBankAcct.DisplayMember = "actName"
        cmbBankAcct.ValueMember = "actNum"
        cn.Close()
        da.Dispose()
        da = Nothing
        ds.Dispose()
        ds = Nothing

        'Fill Combobox for Accounts
        strSql = "Select (ltrim(actNum) + '-' + ltrim(actNumSeq)) as Account, actDescription from tblDRCOA where actUse > 0 "
        strSql += "and actNum + '-' + actNumSeq in (select distinct jnlActNum + '-' +  jnlActSeq from tblDRJournal )  order by actNum, actNumSeq"
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim da2 As SqlDataAdapter
        da2 = New SqlDataAdapter(strSql, cn)
        Dim ds2 As DataSet = New DataSet
        da2.Fill(ds2)
        ' Dim myRow As DataRow
        Dim myRow2 As DataRow
        myRow2 = ds2.Tables(0).NewRow
        myRow2(0) = 0
        myRow2(1) = "All"
        ds2.Tables(0).Rows.InsertAt(myRow2, 0)
        'cmbAccount.DataBindings.Add("DataSource", ds2, ds2.Tables(0).TableName)
        'cmbAccount.DisplayMember = "actDescription"
        'cmbAccount.ValueMember = "Account"
        cn.Close()
        da2.Dispose()
        ds2.Dispose()
        da2 = Nothing
        ds2 = Nothing


        'Fill Combobox for Years
        Dim intRow As Integer = 0
        Dim intYR As Integer = Now.Year
        'Get years of data actually in storage
        strSql = "Select  distinct year(jnlTranDate) as myDate, str(ltrim(year(jnlTranDate))) as myDate2 from tblDRJournal order by year(jnlTranDate)"
        oCommand = New SqlCommand(strSql, cn)
        Dim da3 As SqlDataAdapter
        da3 = New SqlDataAdapter(strSql, cn)
        Dim ds3 As DataSet = New DataSet
        da3.Fill(ds3)
        ' Dim myRow As DataRow
        Dim myRow3 As DataRow
        myRow3 = ds3.Tables(0).NewRow
        myRow3(0) = 0
        myRow3(1) = "All"
        ds3.Tables(0).Rows.InsertAt(myRow3, 0)
        cmbYear2.DataBindings.Add("DataSource", ds3, ds3.Tables(0).TableName)
        cmbYear2.DisplayMember = "myDate2"
        cmbYear2.ValueMember = "myDate"
        cn.Close()
        da3.Dispose()
        ds3.Dispose()
        da3 = Nothing
        ds3 = Nothing
        cmbMonth.Enabled = False

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

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        DisplayData()
        'DisplaySummary()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'cmbAccount.SelectedIndex = 0
        'cmbBankAcct.SelectedIndex = 0
        'cmbEntity.SelectedIndex = 0
        cmbMonth.SelectedIndex = 0
        cmbYear2.SelectedIndex = 0
        DisplayData()
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


    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
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

    'Private Sub dgvSummary_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    '    'This is account column
    '    Dim columnAct As DataGridViewColumn = dgvSummary.Columns(0)
    '    columnAct.HeaderText = "Account"
    '    columnAct.Width = 150
    '    columnAct.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    '    Dim columnAmt As DataGridViewColumn = dgvSummary.Columns(1)
    '    columnAmt.HeaderText = "Amount"
    '    columnAmt.Width = 80
    '    columnAmt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '    columnAmt.DefaultCellStyle.Format = "c"
    'End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbYear2.SelectedIndexChanged
        If cmbYear2.Text = "All" Then
            cmbMonth.Enabled = False
        Else
            cmbMonth.Enabled = True
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseWindow.Click
        Me.Close()
        Main.Show()
    End Sub


    Private Sub rbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

Public Class busRecord2
    Private stor0 As String
    Private stor1 As String
    Private stor2 As String

    Public Sub busRecord2(ByVal StorName As String, ByVal StorID As String, ByVal StorIndex As Long)
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
