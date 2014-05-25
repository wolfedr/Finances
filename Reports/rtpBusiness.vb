Imports System.Data.SqlClient
Imports System.Configuration
Public Class rptBusiness
    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim dr As SqlDataReader
    Dim bs As BindingSource
    Public gblBusID As Int32
    Dim LoadComplete As Boolean = False
    Private Sub rptBasic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtPick1.Text = Date.Now.ToShortDateString
        dtPick1.Text = DateAdd(DateInterval.Day, -30, Now())
        ComputeDates("30")
        'SelectBusiness()
        DisplayGrid()
        LoadComplete = True
    End Sub
    '    Sub SelectBusiness()
    'Next line gets all businesses and filters out duplicates that are from groupings
    'Dim strSql As String = "select distinct a.jnlTranBusinessID, sum(a.jnlTranAmount), b.busname from tblDRJournal a, tblBusiness b "
    'strSql += "where(a.jnlTranBUsinessID = b.busID) group by a.jnlTranBusinessID, b.busName"

    'strSql = " and a.jnlTranDate >= '" & dtPick1.Text & "' and a.jnlTranDate < '" & dtPick2.Text & "' order by b.busName"
    'cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
    'cn.Open()
    'oCommand = New SqlCommand(strSql, cn)
    'Dim ds As DataSet = New DataSet()
    'Dim dt As DataTable = New DataTable("table1")
    'ds.Tables.Add(dt)
    'ds.Load(dr, LoadOption.PreserveChanges, ds.Tables(0))


    'Dim sa As SqlDataAdapter = New SqlDataAdapter(strSql, cn)
    'dr = oCommand.ExecuteReader()
    'Dim aryBusiness As ArrayList = New ArrayList
    'While dr.Read()
    'Dim x As String = dr.GetString(1)
    'Dim y As String = dr.GetInt64(0)
    'gblBusID = dr.GetInt64(0)
    'aryBusiness.Add(New AddValue(dr.GetString(1), Convert.ToInt64(dr.GetInt64(0))))
    'End While
    'dr.Close()
    'cn.Close()
    'ddlBusiness.DisplayMember = "Display"
    'ddlBusiness.ValueMember = "Value"
    'ddlBusiness.DataSource = aryBusiness
    'ddlBusiness.Visible = False
    'ClearForm()
    'End Sub
    Sub DisplayGrid()
        'Dim strSql As String = "select distinct busName, sum(Total) as Total from vwBusinesses "
        ''strSql += " where 
        'strSql += "group by busName order by busName"
        Dim strSql As String = "SELECT DISTINCT  SUM(a.jnlTranAmount) AS Total, b.busName "
        strSql += "FROM dbo.tblDRJournal AS a INNER JOIN dbo.tblBusiness AS b ON a.jnlTranBusinessID = b.busID "
        strSql += "where a.jnlTranDate >= '" & dtPick1.Text & "' and  a.jnlTranDate <= '" & dtPick2.Text & "' "
        strSql += " GROUP BY  b.busName ORDER BY b.busName"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        cn.Open()
        Dim sa As SqlDataAdapter = New SqlDataAdapter(strSql, cn)
        Dim ds As DataSet = New DataSet()
        sa.Fill(ds)
        dgvBusinesses.DataSource = ds.Tables(0)
        cn.Close()
        dgvBusinesses.Columns("Total").DefaultCellStyle.Format = "c"
    End Sub

    Private Sub dgvBusinesses_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBusinesses.CellContentClick
        If e.RowIndex < 0 Or e.RowIndex >= dgvBusinesses.Rows.Count Or e.ColumnIndex < 0 Or e.ColumnIndex >= dgvBusinesses.Columns.Count Then
            Exit Sub
        Else
            Dim cell2 As DataGridViewCell = CType(dgvBusinesses.Rows(e.RowIndex).Cells(1), DataGridViewCell)
            Dim strIDField As String = cell2.Value
            rptBusDetail.gblbusName = strIDField
            rptBusDetail.strDetailStart = dtPick1.Text
            rptBusDetail.strDetailEnd = dtPick2.Text
            rptBusDetail.ShowDialog()

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
End Class