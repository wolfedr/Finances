Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Partial Class frmVisualStatus
    Inherits Finances.baseform
    Dim cn As SqlConnection
    Dim strFlag As String
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    'Dim dt As DataTable
    Dim blnMonthComplete As Boolean = False
    Dim blnReadCkB As Boolean = False
    Dim aryAll As ArrayList = New ArrayList
    Dim decActTot As Decimal
    Dim intViewedMonth As Int16
    Dim strViewedPeriod As String = "M"
    Dim strActTot As String

    Private Sub VisualStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("WellsFargoConnStr").ConnectionString.ToString)
        dtPick2.Text = Date.Now.ToShortDateString
        dtPick1.Text = DateAdd(DateInterval.Day, -30, Now())
        'ComputeDates("YTD")
        ComputeDates("30")
        'CreateDataExportGrid()
        'LoadComplete = True
        FillDropdowns()
        'DisplayData()
        DisplayMonthData()
        blnMonthComplete = True
    End Sub

    Private Sub DisplayData()
        Dim strSql As String
        Dim viewID As Int16
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("WellsFargoConnStr").ConnectionString.ToString)
        strSql = "Select distinct year(a.jnlTranDate) as myYear, Month(a.jnlTranDate) as myMonth, sum(a.jnlTranAmount)*-1 as tot "
        If cmbAccount.SelectedIndex <> 0 Then
            strSql += ", a.jnlActNum , b.actname "
        End If
        strSql += "from tblJournal a"
        If cmbAccount.SelectedIndex <> 0 Then
            strSql += ", tblCOA b  "
        End If
        strSql += " Where year(a.jnlTranDate) <= " & Convert.ToDateTime(dtPick1.Text).Year
        strSql += " and year(a.jnlTranDate) >= " & Convert.ToDateTime(dtPick2.Text).Year
        If cmbAccount.SelectedIndex <> 0 Then
            strSql += " and a.jnlActNum = b.actNum "
            strSql += " and a.jnlActSeq = b.actNumSeq "
            strSql += " and a.jnlActNum = " & cmbAccount.SelectedValue
        End If
        strSql += " and left(ltrim(a.jnlActNum),1) in (8,9) "
        strSql += " group by year(a.jnlTranDate), Month(a.jnlTranDate)"
        If cmbAccount.SelectedIndex <> 0 Then
            strSql += ", a.jnlActNum, b.actName  "
        End If
        strSql += "order by year(a.jnlTranDate), Month(a.jnlTranDate)"
        Dim custDA As New SqlDataAdapter
        ' Create a database command on the connection using query	
        Dim myCommand As New SqlCommand(strSql, cn)
        custDA.SelectCommand = myCommand
        Dim dt As New DataTable
        ' Open the connection	
        cn.Open()
        custDA.Fill(dt)
        If dt.Rows.Count > 0 Then
            intViewedMonth = dt.Compute("Max(myMonth)", "")
        End If
        cn.Close()
        SetGraph(dt)
        DisplayDetail(viewID)
    End Sub

    Private Sub SetGraph(ByVal dtMasterSales As DataTable)
        mccTracking.DataBind()
        Dim lstDates As New List(Of String)
        Dim lstValues As New List(Of Decimal)
        Dim decTotalAmount As Decimal = 0
        Dim ZZ As String
        Dim i As Int16

        If dtMasterSales.Rows.Count > 0 Then
            For i = 0 To dtMasterSales.Rows.Count - 1
                ZZ = FindMonthName(dtMasterSales.Rows(i).Item(1))
                lstDates.Add(ZZ)

                lstValues.Add(dtMasterSales.Rows(i).Item(2))
                decTotalAmount += dtMasterSales.Rows(i).Item(2)
            Next
        Else
            MsgBox("No Records Fond for this selection!", MsgBoxStyle.OkOnly, "No Data")
            Exit Sub
        End If
        If cmbAccount.SelectedIndex = 0 Then
            lblAccount.Text = "ALL ACCOUNTS"
        Else
            lblAccount.Text = dtMasterSales.Rows(i - 1).Item(4)
        End If
        mccTracking.Series(0).Points.DataBindXY(lstDates.ToArray, lstValues.ToArray)
        lblTotal.Text = Format(decTotalAmount, "$###,###.#0")

    End Sub

    Private Sub DisplayDetail(Optional ByVal viewID As Int16 = 0)
        Dim strSql As String
        Dim strActFilter As String
        If viewID <= 0 Then
            viewID = intViewedMonth
        End If

        If cmbAccount.SelectedIndex <> 0 Then
            strActFilter = "actDescription"
        Else
            strActFilter = "actName"
        End If
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("WellsFargoConnStr").ConnectionString.ToString)
        strSql = "Select b." & strActFilter & " as cname, sum(a.jnlTranAmount)*-1 as tot,  b.actNum,  Month( a.jnlTranDate) as myMonth  "
        strSql += " from tblJournal a "
        strSql += ", tblCOA b  "
        strSql += "Where year(a.jnlTranDate) <= " & Convert.ToDateTime(dtPick1.Text).Year
        strSql += " and year(a.jnlTranDate) >= " & Convert.ToDateTime(dtPick2.Text).Year
        strSql += " and a.jnlActNum = b.actNum "
        strSql += " and a.jnlActSeq = b.actNumSeq "
        strSql += " and Month(a.jnlTranDate) = " & viewID
        If cmbAccount.SelectedIndex <> 0 Then
            strSql += " and a.jnlActNum = " & cmbAccount.SelectedValue
        End If
        strSql += " and left(ltrim(a.jnlActNum),1) in (8,9) "
        strSql += " group by year(a.jnlTranDate), Month(a.jnlTranDate), b.actNum "
        strSql += ", a.jnlActNum, b." & strActFilter
        strSql += " order by year(a.jnlTranDate), Month(a.jnlTranDate)"
        Dim custDA As New SqlDataAdapter
        ' Create a database command on the connection using query	
        Dim myCommand As New SqlCommand(strSql, cn)
        custDA.SelectCommand = myCommand
        Dim dt As New DataTable
        cn.Open()
        custDA.Fill(dt)
        If dt.Rows.Count > 0 Then
            lblDetailTotal.Text = Format(dt.Compute("Sum(tot)", ""), "$###,###.#0")
        End If
        dgvDetails.DataSource = dt
        'dgvDetails.Columns(2).Visible = False
        'dgvDetails.Columns(3).Visible = False
        ' Open the connection	
        cn.Close()
    End Sub

    Private Sub DisplayMonthData()
        Dim strSql As String
        Dim viewID As Int16
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("WellsFargoConnStr").ConnectionString.ToString)
        strSql = "Select  datepart(week,jnlTranDate) AS myWeek, sum(a.jnlTranAmount)*-1 as tot "
        If cmbAccount.SelectedIndex <> 0 Then
            strSql += ", a.jnlActNum , b.actname "
        End If
        strSql += "from tblJournal a "
        If cmbAccount.SelectedIndex <> 0 Then
            strSql += ", tblCOA b  "
        End If
        strSql += "Where a.jnlTranDate <= '" & Convert.ToDateTime(dtPick2.Text) & "' and a.jnlTranDate  >= '" & Convert.ToDateTime(dtPick1.Text) & "' "
        If cmbAccount.SelectedIndex <> 0 Then
            strSql += "and a.jnlActNum = b.actNum  "
            strSql += "and a.jnlActSeq = b.actNumSeq  "
            strSql += " and a.jnlActNum = " & cmbAccount.SelectedValue
        End If
        strSql += " and left(ltrim(a.jnlActNum),1) in (8,9) "
        strSql += "group by datepart(week,jnlTranDate)"
        If cmbAccount.SelectedIndex <> 0 Then
            strSql += ", a.jnlActNum, b.actName  "
        End If
        strSql += "order by datepart(week,jnlTranDate) "
        Dim custDA As New SqlDataAdapter
        ' Create a database command on the connection using query	
        Dim myCommand As New SqlCommand(strSql, cn)
        custDA.SelectCommand = myCommand
        Dim dt As New DataTable
        Dim blnGo As Boolean = False
        Try
            cn.Open()
            custDA.Fill(dt)
            viewID = dt.Compute("Max(myWeek)", "")
            blnGo = True
        Catch
            Exit Sub    ' Open the connection	
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
        SetMGraph(dt)
        DisplayMonthDetail(viewID)
    End Sub
    Private Sub SetMGraph(ByVal dtMasterSales As DataTable)
        mccTracking.DataBind()
        Dim lstDates As New List(Of String)
        Dim lstValues As New List(Of Decimal)
        Dim decTotalAmount As Decimal = 0
        Dim i As Int16
        If dtMasterSales.Rows.Count > 0 Then
            For i = 0 To dtMasterSales.Rows.Count - 1
                lstDates.Add(dtMasterSales.Rows(i).Item(0))
                lstValues.Add(dtMasterSales.Rows(i).Item(1))
                decTotalAmount += dtMasterSales.Rows(i).Item(1)
            Next
        Else
            MsgBox("No Records Fond for this selection!", MsgBoxStyle.OkOnly, "No Data")
            Exit Sub
        End If
        If cmbAccount.SelectedIndex <> 0 Then
            lblAccount.Text = dtMasterSales.Rows(i - 1).Item(3)
        Else
            lblAccount.Text = "All ACCOUNTS"
        End If
        lblTotal.Text = Format(decTotalAmount, "$###,###.#0")
        mccTracking.Series(0).Points.DataBindXY(lstDates.ToArray, lstValues.ToArray)
        'lblRetailValue.Text = Format(intTotalUnitsSold * prdCurrent.RetailPrice, "0.00")
    End Sub

    Private Sub DisplayMonthDetail(Optional ByVal viewID As Int16 = 0)
        Dim strSql As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("WellsFargoConnStr").ConnectionString.ToString)
        strSql = "Select  b.actname as cname, sum(a.jnlTranAmount)*-1 as tot,  b.actNum, datepart(week,jnlTranDate)  as myMonth "
        strSql += "from tblJournal a "
        strSql += ", tblCOA b  "
        strSql += "Where year(a.jnlTranDate) <= " & Convert.ToDateTime(dtPick1.Text).Year
        strSql += " and year(a.jnlTranDate) >= " & Convert.ToDateTime(dtPick2.Text).Year
        strSql += " and a.jnlActNum = b.actNum "
        strSql += " and a.jnlActSeq = b.actNumSeq "
        If cmbAccount.SelectedIndex <> 0 Then
            strSql += " and a.jnlActNum = " & cmbAccount.SelectedValue
        End If
        If strViewedPeriod = "M" Then
            strSql += "and datepart(week,jnlTranDate) = " & viewID
        End If
        strSql += " and left(ltrim(a.jnlActNum),1) in (8,9) "
        strSql += " group by year(a.jnlTranDate), datepart(week,jnlTranDate), Month(a.jnlTranDate) "
        strSql += ", b.actNum, b.actName  "
        strSql += "order by year(a.jnlTranDate), Month(a.jnlTranDate)"
        Dim custDA As New SqlDataAdapter
        ' Create a database command on the connection using query	
        Dim myCommand As New SqlCommand(strSql, cn)
        custDA.SelectCommand = myCommand
        Dim dt As New DataTable
        cn.Open()
        custDA.Fill(dt)
        lblDetailTotal.Text = Format(dt.Compute("Sum(tot)", ""), "$###,###.#0")
        'dgvDetails.Columns.Clear()
        dgvDetails.DataSource = dt
        ' Open the connection	
        mccTracking.ChartAreas(0).AxisX.Title = "Week"
        'dgvDetails.Columns(0).Visible = False
        'dgvDetails.Columns(1).Visible = False
        ' dgvDetails.Columns(2).Visible = False
        'dgvDetails.Columns(3).Visible = False
        cn.Close()
    End Sub

    Sub FillDropdowns()
        Dim strSql As String
        'Fill Combobox for Master Accounts
        strSql = "Select distinct (ltrim(actNum)) as Account, actName "
        strSql += "from tblCOA "
        strSql += "where actUse > 0 and actNum in (select distinct jnlActNum  from tblJournal )  "
        strSql += "order by actName"
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim ds2 As DataSet = New DataSet
        Dim da2 As SqlDataAdapter
        da2 = New SqlDataAdapter(strSql, cn)
        da2.Fill(ds2)
        Dim myRow2 As DataRow
        If ds2.Tables(0).Rows.Count > 0 Then
            myRow2 = ds2.Tables(0).NewRow
            myRow2(0) = 0
            myRow2(1) = "All"
            ds2.Tables(0).Rows.InsertAt(myRow2, 0)
            cmbAccount.DataBindings.Add("DataSource", ds2, ds2.Tables(0).TableName)
            cmbAccount.DisplayMember = "actName"
            cmbAccount.ValueMember = "Account"
        End If
        cn.Close()
        da2.Dispose()
        ds2.Dispose()
        da2 = Nothing
        ds2 = Nothing
        FillSubAccount(0)
    End Sub

    Sub FillSubAccount(ByVal intMaster As Int16)
        Dim strSql As String
        'Fill Combobox for Sub Accounts
        strSql = "Select (ltrim(actNum) + '-' + ltrim(actNumSeq)) as Account, actDescription from tblCOA where actUse > 0 "
        If intMaster <> 0 Then
            strSql += "and actNum = " & cmbAccount.SelectedValue
        End If
        strSql += " and actNum + '-' + actNumSeq in (select distinct jnlActNum + '-' +  jnlActSeq from tblJournal )  order by actDescription"
        oCommand = New SqlCommand(strSql, cn)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        Dim ds3 As DataSet
        Dim da3 As SqlDataAdapter
        da3 = New SqlDataAdapter(strSql, cn)
        ds3 = New DataSet
        da3.Fill(ds3)
        Dim myRow2 As DataRow
        myRow2 = ds3.Tables(0).NewRow
        myRow2(0) = 0
        myRow2(1) = "All ACCOUNTS"
        ds3.Tables(0).Rows.InsertAt(myRow2, 0)
        cmbSubAcct.DataBindings.Clear()
        cmbSubAcct.DataBindings.Add("DataSource", ds3, ds3.Tables(0).TableName)
        cmbSubAcct.DisplayMember = "actDescription"
        cmbSubAcct.ValueMember = "Account"
        cn.Close()
        da3.Dispose()
        ds3.Dispose()
        da3 = Nothing
        ds3 = Nothing

    End Sub

    Function FindMonthName(ByVal key As Integer) As String
        Dim mm As String = ""
        Select Case key
            Case 1
                mm = "January"
            Case 2
                mm = "February"
            Case 3
                mm = "March"
            Case 4
                mm = "April"
            Case 5
                mm = "May"
            Case 6
                mm = "June"
            Case 7
                mm = "July"
            Case 8
                mm = "August"
            Case 9
                mm = "Septemeber"
            Case 10
                mm = "October"
            Case 11
                mm = "November"
            Case 12
                mm = "December"
        End Select
        Return mm
    End Function
    Function FindMonthNumber(ByVal key As String) As Int16
        Dim mm As Int16
        Select Case key
            Case "January"
                mm = 1
            Case "February"
                mm = 2
            Case "March"
                mm = 3
            Case "April"
                mm = 4
            Case "May"
                mm = 5
            Case "June"
                mm = 6
            Case "July"
                mm = 7
            Case "August"
                mm = 8
            Case "Septemeber"
                mm = 9
            Case "October"
                mm = 10
            Case "November"
                mm = 11
            Case "December"
                mm = 12
        End Select
        Return mm
    End Function

    Sub ComputeDates(ByVal strXFlag As String)
        strFlag = strXFlag
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

    Private Sub lblYTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblYTD.Click
        'If LoadComplete = True Then
        ComputeDates("YTD")
        strViewedPeriod = "Y"
        DisplayData()
        'End If
    End Sub

    Private Sub lblLast30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLast30.Click
        ComputeDates("30")
        strViewedPeriod = "M"
        DisplayMonthData()
    End Sub

    Private Sub lblPrevYr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPrevYr.Click
        ComputeDates("PYR")
        strViewedPeriod = "Y"
        DisplayData()
    End Sub

    Private Sub lblMTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMTD.Click
        ComputeDates("MTD")
        strViewedPeriod = "M"
        DisplayMonthData()
    End Sub

    Private Sub lblPrevM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPrevM.Click
        ComputeDates("PMO")
        strViewedPeriod = "M"
        DisplayMonthData()
    End Sub

    Private Sub lblLast12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLast12.Click
        ComputeDates("L12")
        strViewedPeriod = "Y"
        DisplayData()
    End Sub

    Private Sub cmbAccount_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAccount.SelectedIndexChanged
        If blnMonthComplete = True Then
            'Dim s As DataRowView = cmbAccount.SelectedValue
            Dim x As Int16 = Convert.ToInt16(cmbAccount.SelectedValue)
            FillSubAccount(x)
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Select Case strFlag
            Case "L12", "PYR", "YTD"
                strViewedPeriod = "Y"
                DisplayData()
            Case "PM0", "MTD", "30"
                strViewedPeriod = "V"
                DisplayMonthData()
            Case Else
                DisplayData()
        End Select
    End Sub

    Private Sub dgvDetails_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetails.CellContentClick
        ' This sub set variable in the modal popup that will show the details of the account for the period designated.
        Dim myView As SubView
        myView = New SubView
        myView.stDate = Convert.ToDateTime(dtPick1.Text)
        myView.enDate = Convert.ToDateTime(dtPick2.Text)
        Dim cellAccount As DataGridViewCell = CType(dgvDetails.Rows(e.RowIndex).Cells(2), DataGridViewCell)
        myView.intAct = Convert.ToInt16(cellAccount.Value)
        Dim cellMonth As DataGridViewCell = CType(dgvDetails.Rows(e.RowIndex).Cells(3), DataGridViewCell)
        myView.intMon = Convert.ToInt16(cellMonth.Value)
        myView.strFlag = strViewedPeriod
        myView.ShowDialog()




    End Sub

    Private Sub dgvDetails_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvDetails.CellFormatting
        Dim cellAmount As DataGridViewCell = CType(dgvDetails.Rows(e.RowIndex).Cells(1), DataGridViewCell)
        Dim cellAmount2 As DataGridViewCell = CType(dgvDetails.Rows(e.RowIndex).Cells(2), DataGridViewCell)
        Dim strTemp As String = cellAmount.Value
        Dim strTemp2 As String = cellAmount2.Value
        If cellAmount.Value <> Nothing Then
            decActTot += Convert.ToDecimal(cellAmount2.Value)
        End If
    End Sub



    Private Sub mccTracking_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mccTracking.MouseDown
        Dim result As HitTestResult = mccTracking.HitTest(e.X, e.Y)
        Dim point As DataPoint
        If result.ChartElementType = ChartElementType.DataPoint Then
            ' Set Attribute
            point = mccTracking.Series(0).Points(result.PointIndex)
            lblPeriod.Text = point.AxisLabel

            If strViewedPeriod = "Y" Then
                Dim intLoad As Int16 = FindMonthNumber(point.AxisLabel)
                DisplayDetail(intLoad)
            ElseIf strViewedPeriod = "M" Then
                Dim intLoad As Int16 = Convert.ToInt16(point.AxisLabel)
                DisplayMonthDetail(intLoad)
            End If

        End If
    End Sub 'Chart1_MouseDown

    Private Sub mccTracking_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mccTracking.MouseMove
        ' Call Hit Test Method
        Dim result As HitTestResult = mccTracking.HitTest(e.X, e.Y)
        ' Reset Data Point Attributes
        Dim point As DataPoint
        For Each point In mccTracking.Series(0).Points
            'point.BackSecondaryColor = Color.Black
            point.BackHatchStyle = ChartHatchStyle.None
            point.BorderWidth = 1
        Next point
        ' If a Data Point or a Legend item is selected.
        If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.LegendItem Then
            ' Set cursor type 
            Me.Cursor = Cursors.Hand
            ' Find selected data point
            point = mccTracking.Series(0).Points(result.PointIndex)
            ' Set End Gradient Color to White
            point.BackSecondaryColor = Color.White
            ' Set selected hatch style
            point.BackHatchStyle = ChartHatchStyle.Percent25
            ' Increase border width
            point.BorderWidth = 2
        Else
            ' Set default cursor
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
