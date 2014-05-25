

Imports System.Data.SqlClient
Imports System.Configuration
Imports Excel = Microsoft.Office.Interop.Excel

Public Class rptRentals
    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim bs As BindingSource
    Dim LoadComplete As Boolean = False
    Dim chkdActivty As String = ""
    Dim strButtonToggle As String


    Private Sub rptRentals_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'rbFundraiser.Enabled = False
        rbRental.Enabled = True
        Dim strActivity As String = ""
        dtPick2.Text = Date.Now.ToShortDateString
        hdnFY.Text = Date.Now.Year.ToString()
        'ComputeDates("L12")
        DisplayGrid("2")
        DisplayActivites(2)
        LoadComplete = True
    End Sub

    Private Sub DisplayActivites(ByVal strActivity As String)
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        '************Rentals****************
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "select  ActivityDescription,ActivityID from tblActivity where ActivityType in ('RENTAL','RESTORE','NONE')order by ActivitySort "
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
        ddlActivity.SelectedValue = strActivity
        '************Fundraisers****************
        strSql = "select  ActivityDescription,ActivityID from tblActivity where ActivityType in ('FUNDRAISING', 'NONE')order by ActivitySort "
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        DA1.Fill(DS1, "tblActivity")
        myRow = DS1.Tables(0).Rows.Count
        dt = DS1.Tables(0)
        dt.Rows.Add()
        ddlFundraiser.DataSource = DS1.Tables("tblActivity")
        ddlFundraiser.DisplayMember = "ActivityDescription"
        ddlFundraiser.ValueMember = "ActivityID"
        cn.Close()

    End Sub


    Sub DisplayGrid(ByVal strActivity As String)
        chkdActivty = strActivity
        If strActivity.Length <= 0 Then Exit Sub
        Dim strSql As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        dgvTransactions.RowCount = 1 'This clears any data out of the gird
        strSql = "select ltrim(a.jnlTranDesc) AS Description, a.jnlActivity, CONVERT(VARCHAR(20),a.jnlTranDAte,101) AS TranDate,"
        strSql += " a.jnlTranAmount as Amount, (ltrim(str(a.jnlActNum)) + '-' + ltrim(str(a.jnlActSeq))) as Account from tblDRJournal a, "
        strSql += "tblDRCOA b, tblActivity c where b.actNum = a.jnlActNum And b.actNumSeq = a.jnlActSeq and c.Activityid = a.jnlActivityID  "
        strSql += " AND a.jnlTranDAte >="
        strSql += " CASE c.ActivityType WHEN 'FUNDRAISING' THEN '1/1/1900' ELSE '" & dtPick1.Text & "' END"
        strSql += " AND a.jnlTranDAte <="
        strSql += " CASE c.ActivityType WHEN 'FUNDRAISING' THEN '1/1/2200' ELSE '" & dtPick2.Text & "' END"
        strSql += " and jnlActivityID = " & strActivity & " ORDER by a.jnlActNum, jnlActSeq, jnlTranDate"
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim dr As SqlDataReader = oCommand.ExecuteReader()

        'add rows TO GRID
        Dim n As Integer = 0
        dgvTransactions.Refresh()
        Dim aRecord As String = ""
        Dim bRecord As String = ""
        Dim aryCount As Int32 = 0
        Dim cumCount As Single
        Dim totIncomeCum As Single = 0
        Dim totExpenseCum As Single = 0

        Do While dr.Read()
            aRecord = Trim(dr(0).ToString())
            'If aRecord <> bRecord Then
            bRecord = aRecord
            'dgvTransactions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            'Dim x As String = dr.GetString(1)
            'Dim y As String = dr.GetString(2)
            'Description
            dgvTransactions.Rows.Item(n).Cells(0).Value = dr.GetString(0)
            Me.dgvTransactions.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.dgvTransactions.Rows(n).Cells(0).Style.Font = New Font("calibri", 11, FontStyle.Regular)
            'Date
            dgvTransactions.Rows.Item(n).Cells(1).Value = dr.GetString(2)   '.Substring(0, 4)
            Me.dgvTransactions.Rows(n).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.dgvTransactions.Rows(n).Cells(1).Style.Font = New Font("calibri", 11, FontStyle.Bold)
            'Total
            Dim actChk As Int32 = CType(Trim(dr.GetString(4)).Substring(0, 1), Int32)
            Dim sx As Single = dr.GetSqlMoney(3)
            If actChk <= 5 Then
                totIncomeCum += sx
                dgvTransactions.Rows.Item(n).Cells(2).Value = dr.GetSqlMoney(3).ToString()
                Me.dgvTransactions.Rows(n).Cells(2).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.dgvTransactions.Rows(n).Cells(2).Style.Font = New Font("calibri", 11, FontStyle.Bold)
            Else
                totExpenseCum += sx
                dgvTransactions.Rows.Item(n).Cells(3).Value = dr.GetSqlMoney(3).ToString()
                Me.dgvTransactions.Rows(n).Cells(3).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                Me.dgvTransactions.Rows(n).Cells(3).Style.Font = New Font("calibri", 11, FontStyle.Bold)
            End If
            cumCount += sx
            'Account
            dgvTransactions.Rows.Item(n).Cells(4).Value = dr.GetString(4)
            Me.dgvTransactions.Rows(n).Cells(4).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            Me.dgvTransactions.Rows(n).Cells(4).Style.Font = New Font("calibri", 11, FontStyle.Bold)
            Dim myTest As String = dr.GetString(4)
            n = dgvTransactions.Rows.Add()
JUMP:   Loop
        dgvTransactions.Rows.Remove(dgvTransactions.Rows(n)) 'Removes extra blank row added for some reason.

        'dgvTransactions.Rows.Item(n).Cells(2).Value = String.Format("{0:C}", totIncomeCum)
        'Me.dgvTransactions.Rows(n).Cells(2).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        'Me.dgvTransactions.Rows(n).Cells(2).Style.Font = New Font("calibri", 11, FontStyle.Bold)
        'dgvTransactions.Rows.Item(n).Cells(3).Value = String.Format("{0:C}", totExpenseCum)
        'Me.dgvTransactions.Rows(n).Cells(3).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        'Me.dgvTransactions.Rows(n).Cells(3).Style.Font = New Font("calibri", 11, FontStyle.Bold)
        'n = dgvTransactions.Rows.Add()
        lblBalance.Text = "                         " & strActivity & ":          Income: " & String.Format("{0:C}", totIncomeCum) & "          Expenses: " & String.Format("{0:C}", totExpenseCum) & "            Net Profit(Loss):  " & String.Format("{0:C}", totIncomeCum + totExpenseCum)
        lblBalance.BackColor = Color.Beige
        

    End Sub
    Private Sub dgvTransactions_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTransactions.CellContentClick
        If e.RowIndex < 0 Or e.RowIndex >= dgvTransactions.Rows.Count Or e.ColumnIndex < 0 Or e.ColumnIndex >= dgvTransactions.Columns.Count Then
            Exit Sub
        Else
            If e.ColumnIndex() = 0 Then
                Dim linkCell As DataGridViewLinkCell = dgvTransactions.Rows(e.RowIndex).Cells(e.ColumnIndex) 'as DataGridViewLinkCell

                If linkCell.Value = Nothing Then Exit Sub
                'strSendAcccount = dgvTransactions.Rows(e.RowIndex).Cells(1).Value
                'rptNPDetail.strActivityID = chkdActivty
                rptNPDetail.actID = Trim(dgvTransactions.Rows(e.RowIndex).Cells(4).Value)
                rptNPDetail.strDetailStart = dtPick1.Text
                rptNPDetail.strDetailEnd = dtPick2.Text
                rptNPDetail.ShowDialog()

                'Dim s As String = linkCell.Value
            End If
        End If

    End Sub


    'Private Sub dtPick1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtPick1.ValueChanged, dtPick2.ValueChanged
    '    If LoadComplete = True Then

    '        DisplayGrid(ddlActivity.SelectedValue)

    '    End If

    'End Sub

    'Private Sub ddlActivity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlActivity.SelectedIndexChanged
    '    If LoadComplete = True Then
    '        DisplayGrid(ddlActivity.SelectedValue)
    '    End If
    'End Sub

    'Private Sub ddlFundraiser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlFundraiser.SelectedIndexChanged
    '    If LoadComplete = True Then
    '        DisplayGrid(ddlFundraiser.SelectedValue)
    '    End If
    'End Sub
    Function GetActivityType() As String

        If rbRental.Checked = True Then

            Return ddlActivity.SelectedValue
        Else
            Return ddlFundraiser.SelectedValue
        End If



    End Function

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If LoadComplete = True Then
            DisplayGrid(GetActivityType)
        End If
    End Sub

    Public Function GetLastDayOfMonth(ByVal intMonth, ByVal intYear) As Date
        GetLastDayOfMonth = DateSerial(intYear, intMonth + 1, 0)
    End Function

    Private Sub buttonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnJan.Click, btnFeb.Click, btnMar.Click, _
     btnApr.Click, btnMay.Click, btnJune.Click, btnJul.Click, btnAug.Click, btnSep.Click, btnOct.Click, btnNov.Click, btnDec.Click, btnYTD.Click
        Dim inDate As DateTime = "1/1/1900"
        Dim lastOfMonth As DateTime
        Dim cControl As Control
        For Each cControl In Me.grpMonth.Controls
            If (TypeOf cControl Is Button) Then
                If cControl.Text = strButtonToggle Then cControl.BackColor = Color.Aqua
            End If
        Next cControl

        Dim myButton As Button = sender
        myButton.BackColor = Color.Aqua
        If sender Is btnJan Then
            inDate = "1/1/" & hdnFY.Text
            lastOfMonth = GetLastDayOfMonth(1, hdnFY.Text)
            ' lastOfMonth = inDate.Date.AddDays(-(inDate.Day - 1)).AddMonths(1).AddDays(-1)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnFeb Then
            inDate = "2/1/" & hdnFY.Text
            lastOfMonth = GetLastDayOfMonth(2, hdnFY.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnMar Then
            inDate = "3/1/" & hdnFY.Text
            lastOfMonth = GetLastDayOfMonth(3, hdnFY.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnApr Then
            inDate = "4/1/" & hdnFY.Text
            lastOfMonth = GetLastDayOfMonth(4, hdnFY.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnMay Then
            inDate = "5/1/" & hdnFY.Text
            lastOfMonth = GetLastDayOfMonth(5, hdnFY.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnJune Then
            inDate = "6/1/" & hdnFY.Text
            lastOfMonth = GetLastDayOfMonth(6, hdnFY.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnJul Then
            inDate = "7/1/" & hdnFY.Text
            lastOfMonth = GetLastDayOfMonth(7, hdnFY.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnAug Then
            inDate = "8/1/" & hdnFY.Text
            lastOfMonth = GetLastDayOfMonth(8, hdnFY.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnSep Then
            inDate = "9/1/" & hdnFY.Text
            lastOfMonth = GetLastDayOfMonth(9, hdnFY.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnOct Then
            inDate = "10/1/" & hdnFY.Text
            lastOfMonth = GetLastDayOfMonth(10, hdnFY.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnNov Then
            inDate = "11/1/" & hdnFY.Text
            lastOfMonth = GetLastDayOfMonth(11, hdnFY.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnDec Then
            inDate = "12/1/" & hdnFY.Text
            lastOfMonth = GetLastDayOfMonth(12, hdnFY.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnYTD Then
            lastOfMonth = GetLastDayOfMonth(Date.Now.Month, hdnFY.Text)
            dtPick1.Text = "1/1/" & hdnFY.Text
            myButton.BackColor = Color.YellowGreen
        End If
        dtPick1.Text = inDate
        dtPick2.Text = lastOfMonth
        strButtonToggle = myButton.Text
        DisplayGrid(GetActivityType)

        'dteStartDate = inDate
        'strStartDate = inDate.ToString()
        'dteEndDate = DateAdd(DateInterval.Month, 1, inDate)
        'strEndDate = dteEndDate.ToString()
        'txtYr.Text = inDate.Year
        'txtMonth.Text = MonthName(inDate.Month, True)

    End Sub

    Private Sub rbRental_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRental.CheckedChanged
        If LoadComplete = True Then
            ddlActivity.Enabled = True
            ddlFundraiser.Enabled = False
        End If
    End Sub

    Private Sub rbFundraiser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFundraiser.CheckedChanged
        If LoadComplete = True Then
            ddlFundraiser.Enabled = True
            ddlActivity.Enabled = False
        End If
    End Sub

   
End Class