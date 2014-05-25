﻿Imports System.Data.SqlClient
Imports System.Configuration
Imports Excel = Microsoft.Office.Interop.Excel
Public Class rptBalSheet

    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim bs As BindingSource
    Dim LoadComplete As Boolean = False
    Private Sub rptBalSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtPick2.Text = Date.Now.ToShortDateString
        dtPick1.Text = DateAdd(DateInterval.Day, -30, Now())
        ComputeDates("YTD")
        DisplayGrid()
        'CreateDataExportGrid()
        LoadComplete = True
    End Sub

    Sub ExportGridToExcel(ByVal TheGrid As DataGridView, ByVal FileName As String)
        Try
            Dim fs As New IO.StreamWriter(FileName, False)
            fs.WriteLine("<?xml version=""1.0""?>")
            fs.WriteLine("<?mso-application progid=""Excel.Sheet""?>")
            fs.WriteLine("<ss:Workbook xmlns:ss=""urn:schemas-microsoft-com:office:spreadsheet"">")
            fs.WriteLine("    <ss:Styles>")
            fs.WriteLine("        <ss:Style ss:ID=""1"">")
            fs.WriteLine("           <ss:Font ss:Bold=""1""/>")
            fs.WriteLine("        </ss:Style>")
            fs.WriteLine("    </ss:Styles>")
            fs.WriteLine("    <ss:Worksheet ss:Name=""Sheet1"">")
            fs.WriteLine("        <ss:Table>")
            For x As Integer = 0 To TheGrid.Columns.Count - 1
                fs.WriteLine("            <ss:Column ss:Width=""{0}""/>", TheGrid.Columns.Item(x).Width)
            Next
            fs.WriteLine("            <ss:Row ss:StyleID=""1"">")
            For i As Integer = 0 To TheGrid.Columns.Count - 1
                fs.WriteLine("                <ss:Cell>")
                fs.WriteLine(String.Format("                   <ss:Data ss:Type=""String"">{0}</ss:Data>", TheGrid.Columns.Item(i).HeaderText))
                fs.WriteLine("                </ss:Cell>")
            Next
            fs.WriteLine("            </ss:Row>")
            For intRow As Integer = 0 To TheGrid.RowCount - 3
                fs.WriteLine(String.Format("            <ss:Row ss:Height =""{0}"">", TheGrid.Rows(intRow).Height))
                For intCol As Integer = 0 To TheGrid.Columns.Count - 1
                    fs.WriteLine("                <ss:Cell>")
                    fs.WriteLine(String.Format("                   <ss:Data ss:Type=""String"">{0}</ss:Data>", TheGrid.Item(intCol, intRow).Value.ToString))
                    fs.WriteLine("                </ss:Cell>")
                Next
                fs.WriteLine("            </ss:Row>")
            Next
            fs.WriteLine("        </ss:Table>")
            fs.WriteLine("    </ss:Worksheet>")
            fs.WriteLine("</ss:Workbook>")
            fs.Close()
        Catch ex As Exception
            '  For demoing I am simply telling you we had a problem, in a real application
            '  we at least remove the MsgBox and uncomment the next line. What should also
            '  be considered is not using --> Throw new exception... because now the exception
            '  points to the line with that statement rather then the original problem.
            '
            '
            MsgBox(ex.Message)
            'Throw 
        End Try

        OpenExcelFile(FileName)
        Application.DoEvents()
    End Sub

    Sub DisplayGrid()
        Dim strSql As String
        Dim n As Integer = 0
        Dim aRecord As String = ""
        Dim bRecord As String = ""
        Dim dRecord As String = ""
        Dim eRecord As String = ""
        Dim blnAB As Boolean = False
        Dim blnDE As Boolean = False
        Dim aryCount As Int32 = 0
        Dim cumCount As Single
        Dim totIncomeCum As Single = 0
        Dim totNameCum As Single = 0
        Dim totExpenseCum As Single = 0
        Dim actChk As String = "0"
        Dim strPrevItem As String = ""
        Dim intUpcount As Integer = 0
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        dgvAccounts.RowCount = 1 'This clears any data out of the gird

        strSql = "select b.actTypeName,  b.actName, b.actDescription,(ltrim(str(a.jnlActNum)) + '-' + ltrim(str(a.jnlActSeq))) as Account, "
        strSql &= "sum(a.jnlTranAmount) as Total from tblDRJournal a, tblDRCOA b where"
        strSql &= " (b.actNum = a.jnlActNum And b.actNumSeq = a.jnlActSeq) and a.jnlTranDate >= '" & dtPick1.Text & "' and a.jnlTranDate < '" & dtPick2.Text & "' "
        strSql &= " and a.jnlActNum > 999 and a.jnlActNum < 3000 group by a.jnlActNum, a.jnlActSeq, b.actName, b.actTypeName, actDescription"
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim dr As SqlDataReader = oCommand.ExecuteReader()
        'add rows TO GRID
        dgvAccounts.Refresh()

        Do While dr.Read()
            aRecord = Trim(dr(0).ToString())  'Account type name Income Expense
            dRecord = Trim(dr(1).ToString())  'Account name  
            If aRecord <> bRecord Then 'Startin a new account type
                bRecord = aRecord
                If n > 0 Then 'If its not the first row then it starts a new account type
                    blnAB = True
                    dgvAccounts.Rows.Item(n).Cells(2).Value = "INCOME: " & String.Format("{0:C}", totIncomeCum)
                    n = dgvAccounts.Rows.Add()
                    totNameCum = 0 'Clear this for next level
                End If
                strPrevItem = "" 'Reset previous item when crossing the  type barrier
                dgvAccounts.Rows.Item(n).Cells(0).Value = dr.GetString(0).ToUpper  ' Account type name
                Me.dgvAccounts.Rows(n).Cells(0).Style.Font = New Font("calibri", 13, FontStyle.Bold)
            End If
            If dRecord <> eRecord Then
                eRecord = dRecord

                If strPrevItem.Length > 0 Then 'If not first time through
                    If intUpcount > 1 Then ' There are at least 2 entriesa
                        dgvAccounts.Rows(n).Cells(2).Value = strPrevItem & " total: " & String.Format("{0:C}", totNameCum)
                        n = dgvAccounts.Rows.Add()
                        intUpcount = 0
                    End If
                End If
                Me.dgvAccounts.Rows(n).Cells(1).Style.Font = New Font("calibri", 9, FontStyle.Bold)
                dgvAccounts.Rows.Item(n).Cells(1).Value = dr.GetString(1)  ' Account name
                totNameCum = 0
            End If
            'description
            dgvAccounts.Rows.Item(n).Cells(2).Value = dr(2)
            Me.dgvAccounts.Rows(n).Cells(2).Style.Font = New Font("calibri", 8, FontStyle.Regular)
            'Account Number
            dgvAccounts.Rows.Item(n).Cells(3).Value = dr.GetString(3) '.Substring(0, 4) 'Account number
            actChk = Trim(dr.GetString(3)).Substring(0, 1)
            'Amount
            Dim sx As Single = dr.GetSqlMoney(4)
            dgvAccounts.Rows(n).Cells(4).Style.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvAccounts.Rows.Item(n).Cells(4).Value = String.Format("{0:C}", sx)
            'dgvAccounts.Rows.Item(n).Cells(2).Value = "" 'ITEM TOTAL
            'dgvAccounts.Rows.Item(n).Cells(3).Value = "" 'GRAND TOTAL
            'Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            'n = dgvAccounts.Rows.Add() 'Add Header row and increment n.
            'If n > 2 Then
            '    dgvAccounts.Rows.Item(n - 2).Cells(3).Style.Alignment = DataGridViewContentAlignment.MiddleRight
            '    dgvAccounts.Rows.Item(n - 2).Cells(3).Value = String.Format("{0:C}", cumCount)
            '    'Me.dgvAccounts.Rows(n - 2).Cells(3).Style.Font = New Font("calibri", 13, FontStyle.Bold)
            '    'totIncomeCum = cumCount
            '    cumCount = 0
            'End If

            'Exit Sub
            ''GoTo JUMP
            'dgvAccounts.Rows.Item(n).Cells(0).Value = dr(1)
            'dgvAccounts.Rows.Item(n).Cells(1).Value = dr(2)

            'Check for income or expense and add to totals
            dgvAccounts.Rows.Item(n).Cells(4).Value = String.Format("{0:C}", sx)
            actChk = Trim(dr.GetString(3)).Substring(0, 1)
            Select Case actChk
                Case "5", "4"
                    totIncomeCum += sx
                Case Else
                    totExpenseCum += sx
            End Select
            totNameCum += sx
            cumCount += sx
            'dgvAccounts.Rows.Item(n).Cells(2).Style.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvAccounts.Rows.Item(n).Cells(4).Value = " "
            n = dgvAccounts.Rows.Add()
            'If blnAB = True Then 'Startin a new account type
            '    dgvAccounts.Rows.Item(n).Cells(2).Value = "Expense: " & String.Format("{0:C}", totExpenseCum)
            '    n = dgvAccounts.Rows.Add()
            '    blnAB = False
            'End If
            strPrevItem = dr(1).ToString() 'Set to check for the name of the previous account for the subtotal row.
            intUpcount += 1 'Increment counter to do subtotal. Must be at least 2 entries              
JUMP:   Loop
        If n > 2 Then
            dgvAccounts.Rows.Item(n).Cells(2).Value = "EXPENSE: " & String.Format("{0:C}", totExpenseCum)
            n = dgvAccounts.Rows.Add()
            ''dgvAccounts.Rows.Item(n - 1).Cells(3).Style.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvAccounts.Rows.Item(n - 1).Cells(4).Value = String.Format("{0:C}", cumCount)
            ''Me.dgvAccounts.Rows(n - 1).Cells(3).Style.Font = New Font("calibri", 13, FontStyle.Bold)
            'cumCount = 0
        End If
        dr.Close()
        cn.Close()
        'dgvAccounts.Rows(n).Cells(1).Style.BackColor = Color.Beige
        'dgvAccounts.Rows(n).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgvAccounts.Rows(n).Cells(1).Style.Font = New Font("calibri", 12, FontStyle.Bold)
        'dgvAccounts.Rows.Item(n).Cells(1).Value = "Income:"
        'dgvAccounts.Rows(n).Cells(2).Style.Font = New Font("calibri", 12, FontStyle.Bold)
        'dgvAccounts.Rows(n).Cells(2).Style.BackColor = Color.Beige
        'dgvAccounts.Rows(n).Cells(2).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvAccounts.Rows.Item(n).Cells(2).Value = String.Format("{0:C}", totIncomeCum)
        'dgvAccounts.Rows(n).Cells(3).Style.Font = New Font("calibri", 12, FontStyle.Bold)
        'dgvAccounts.Rows(n).Cells(3).Style.BackColor = Color.Beige
        'dgvAccounts.Rows(n).Cells(3).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgvAccounts.Rows.Item(n).Cells(3).Value = "Expense: " & String.Format("{0:C}", totExpenseCum)

        n = dgvAccounts.Rows.Add()


    End Sub
    Private Sub DisplayActivites()
        ' populates  dropdown of available Activites

        'Fill Actity Dropdown
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "select  ActivityDescription,ActivityID from tblActivity order by ActivitySort "
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        DA1.Fill(DS1, "tblActivity")
        Dim myRow As Integer = DS1.Tables(0).Rows.Count
        Dim dt As DataTable = DS1.Tables(0)
        dt.Rows.Add()
        ddlActivity.DataSource = DS1.Tables("tblActivity")
        ddlActivity.DisplayMember = "ActivityDescription"
        ddlActivity.ValueMember = "ActivityID"

        'ddlActivity.SelectedIndex = 0
        cn.Close()

    End Sub

    Private Sub dgvAccounts_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.CellContentClick
        If e.RowIndex < 0 Or e.RowIndex >= dgvAccounts.Rows.Count Or e.ColumnIndex < 0 Or e.ColumnIndex >= dgvAccounts.Columns.Count Then
            Exit Sub
        Else
            If e.ColumnIndex() = 0 Then
                Dim linkCell As DataGridViewLinkCell = dgvAccounts.Rows(e.RowIndex).Cells(e.ColumnIndex) 'as DataGridViewLinkCell

                If linkCell.Value = Nothing Then Exit Sub
                'strSendAcccount = dgvAccounts.Rows(e.RowIndex).Cells(1).Value

                rptDetail.actID = Trim(dgvAccounts.Rows(e.RowIndex).Cells(1).Value)
                rptDetail.strDetailStart = dtPick1.Text
                rptDetail.strDetailEnd = dtPick2.Text
                rptDetail.ShowDialog()

                'Dim s As String = linkCell.Value
            End If
        End If

    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
        baseform.Show()
    End Sub

    Private Sub lblYTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblYTD.Click
        If LoadComplete = True Then
            ComputeDates("YTD")
            DisplayGrid()
        End If
    End Sub
    Sub ComputeDates(ByVal strFlag As String)
        Dim dtNow As Date = Now()
        Dim strTest As String = Now.Month & "/" & Now.Day & "/" & Now.Month
        Dim dtYr As Date = Date.Now
        Dim intNowYr As Int32 = dtYr.Year
        Dim intNowMo As Int32 = dtYr.Month
        Dim intNowDy As Int32 = dtYr.Day
        lblYTD.BackColor = System.Drawing.SystemColors.Control
        lblLast30.BackColor = System.Drawing.SystemColors.Control
        lblPrevYr.BackColor = System.Drawing.SystemColors.Control
        lblMTD.BackColor = System.Drawing.SystemColors.Control
        lblPrevM.BackColor = System.Drawing.SystemColors.Control
        lblLast12.BackColor = System.Drawing.SystemColors.Control


        Select Case strFlag
            Case "YTD"
                dtPick2.Text = Date.Now.ToShortDateString
                dtPick1.Text = "1/1/" & intNowYr.ToString
                lblYTD.BackColor = Color.AntiqueWhite
            Case "30"
                dtPick2.Text = Date.Now.ToShortDateString
                dtPick1.Text = DateAdd(DateInterval.Day, -30, Now())
                lblLast30.BackColor = Color.AntiqueWhite
            Case "PYR"
                dtPick2.Text = "12/31/" & (intNowYr - 1).ToString
                dtPick1.Text = "1/1/" & (intNowYr - 1).ToString
                lblPrevYr.BackColor = Color.AntiqueWhite
            Case "MTD"
                dtPick2.Text = Date.Now.ToShortDateString
                dtPick1.Text = intNowMo.ToString & "/1/" & intNowYr.ToString
                lblMTD.BackColor = Color.AntiqueWhite
            Case "PMO"
                Dim thisMonth As New Date(Date.Today.Year, Date.Today.Month, 1)
                dtPick1.Text = thisMonth.AddMonths(-1)
                dtPick2.Text = thisMonth.AddDays(-1)
                'dtPick2.Text = Date.Now.ToShortDateString
                'dtPick1.Text = (intNowMo - 1).ToString & "/1/" & intNowYr.ToString
                lblPrevM.BackColor = Color.AntiqueWhite
            Case "L12"
                dtPick2.Text = Date.Now.ToShortDateString
                dtPick1.Text = DateAdd(DateInterval.Year, -1, Date.Now)
                lblLast12.BackColor = Color.AntiqueWhite
            Case Else
                dtPick2.Text = Date.Now.ToShortDateString
                dtPick1.Text = DateAdd(DateInterval.Day, -30, Now())
        End Select




    End Sub


    Private Sub lblLast30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLast30.Click
        ComputeDates("30")
        DisplayGrid()
    End Sub

    Private Sub lblPrevYr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPrevYr.Click
        ComputeDates("PYR")
        DisplayGrid()
    End Sub


    Private Sub lblMTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMTD.Click
        ComputeDates("MTD")
        DisplayGrid()
    End Sub

    Private Sub lblPrevM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPrevM.Click
        ComputeDates("PMO")
        DisplayGrid()
    End Sub

    Private Sub lblLast12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLast12.Click
        ComputeDates("L12")
        DisplayGrid()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As Object = dgvAccounts.DataSource
        ExportGridToExcel(dgvAccounts, "C:\Development\DRAccounting\MyExcel.xls")
    End Sub
    Sub CreateDataExportGrid()
        Dim strSql As String
        'Dim SubAccounts() As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        dgvAccounts.RowCount = 1 'This clears any data out of the gird
        strSql = "select b.actName, b.actdescription,(ltrim(str(a.jnlActNum)) + '-' + ltrim(str(a.jnlActSeq))) as Account,  sum(a.jnlTranAmount) as Total"
        strSql += " from tblDRJournal a, tblDRCOA b where b.actNum = a.jnlActNum And b.actNumSeq = a.jnlActSeq "
        strSql += "and a.jnlTranDate >= '" & dtPick1.Text & "' and a.jnlTranDate < '" & dtPick2.Text & "' "
        strSql += "group by a.jnlActNum, a.jnlActSeq, b.actdescription, b.actName"
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(oCommand)
        da.Fill(ds)
        'Dim dr As SqlDataReader = oCommand.ExecuteReader()
        'Dim n As Integer = 0
        dgvExcel.DataSource = ds.Tables(0)

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles Button2.Click


        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        For i = 0 To dgvExcel.RowCount - 3
            For j = 0 To dgvAccounts.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) = _
                    dgvExcel(j, i).Value.ToString()
            Next
        Next

        xlWorkSheet.SaveAs("C:\Development\DRAccounting\vbexcel.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        OpenExcelFile("C:\Development\DRAccounting\vbexcel.xlsx")
        Application.DoEvents()
        MsgBox("You can find the file C:\Development\DRAccountingvbexcel.xlsx")
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
    Private Sub OpenExcelFile(ByVal FileName As String)
        If System.IO.File.Exists(FileName) Then
            Process.Start(FileName)
        End If
    End Sub

    
End Class