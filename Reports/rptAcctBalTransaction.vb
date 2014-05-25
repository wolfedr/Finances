Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class rptAcctBalTransaction
    Dim dsBal As DataSet
    Dim cn As SqlConnection
    Dim oCommand As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Private strStartDate As String
    Private strEndDate As String
    Private strAccount As String
    Private dteStartDate As DateTime
    Private dteEndDate As DateTime
    Private Account As String
    Private myButton As Button
    Private loadComplete As Boolean = False
    Dim upCount As Integer

    Private int

    Private Sub AcctBalTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strSql As String = ""
        myButton = New Button
        myButton.BackColor = Color.Aqua
        Dim nowDate As DateTime
        nowDate = Now()
        dteStartDate = nowDate.Date.AddDays(-nowDate.Day + 1)
        dteEndDate = GetLastDayOfMonth(dteStartDate.Month, dteStartDate.Year)
        strStartDate = dteStartDate.ToString()
        strEndDate = dteEndDate.ToString()
        txtYr.Text = nowDate.Year
        txtMonth.Text = MonthName(nowDate.Month, True)
        ShowMonth()
        loadComplete = True
    End Sub

    Sub RetrieveAccountFromButtons()
        Dim strTemp As String = ""
        Dim checkedRadioButton As RadioButton
        checkedRadioButton = gbAccount.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(radioButton) radioButton.Checked)
        strTemp = checkedRadioButton.Text
        Select Case strTemp.ToUpper
            Case "DUBLIN RISING"
                strAccount = "56855"
            Case "DR RENTAL"
                strAccount = "67121"
            Case "FUNDRAISING"
                strAccount = "1250836"
            Case "ALL"
                strAccount = ""
            Case Else
        End Select
    End Sub

    Private Sub ShowMonth()
        Dim strSql As String = ""
        dsBal = New DataSet
        RetrieveAccountFromButtons()
        'Get data for the month
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand("GetBalance", cn)
        oCommand.CommandType = CommandType.StoredProcedure
        Dim pStartDate As SqlParameter = New SqlParameter("@startDate", SqlDbType.VarChar, 100, ParameterDirection.Input)
        pStartDate.Value = strStartDate
        oCommand.Parameters.Add(pStartDate)
        Dim pEndDate As SqlParameter = New SqlParameter("@endDate", SqlDbType.VarChar, 100, ParameterDirection.Input)
        pEndDate.Value = strEndDate
        oCommand.Parameters.Add(pEndDate)
        'this parameter added 10/13 to filter by account.
        Dim pAccount As SqlParameter = New SqlParameter("@Account", SqlDbType.VarChar, 50, ParameterDirection.Input)
        pAccount.Value = strAccount
        oCommand.Parameters.Add(pAccount)
        da = New SqlDataAdapter(oCommand)
        cn.Open()
        da.Fill(dsBal, "tblDRJournal")
        If dsBal.Tables("tblDRJournal").Rows.Count > 0 Then
            Dim tmpInc As Decimal = dsBal.Tables("tblDRJournal").Compute("SUM(income)", String.Empty)
            Dim tmpExp As Decimal = dsBal.Tables("tblDRJournal").Compute("SUM(expenses)", String.Empty)
            Dim tmpDif As Decimal = tmpInc + tmpExp
            lblAccountInc.Text = tmpInc.ToString("C")
            lblAccountExp.Text = tmpExp.ToString("C")
            lblAccountCalc.Text = tmpDif.ToString("C")
            dgvBalance.DataSource = dsBal.Tables("tblDRJournal")
            da.Dispose()
            dsBal.Dispose()
            oCommand.Dispose()
            cn.Close()
            cn.Dispose()
            'Get starting and ending balances
            GetStoredBalances(strStartDate, "S")
            GetStoredBalances(strEndDate, "E")
            lblAccountErr.Text = (CDec(lblAccountComp.Text) - tmpDif).ToString("C")
        Else
            MsgBox("No Data for this month!", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub GetStoredBalances(ByVal myDate As Date, ByVal strFlag As String)
        'Get current month
        Dim strSql As String = ""
        Dim dr As SqlDataReader
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        strSql = "Select  * from tblAccountBal where balDate between '" & DateAdd(DateInterval.Day, -1, dteStartDate) & "' and '" & DateAdd(DateInterval.Day, 2, dteEndDate) & "' and balBankAcct = '" & strAccount & "'"
        strSql += " order by balDate"
        'Get the balance table records for this period
        oCommand = New SqlCommand(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        dr = oCommand.ExecuteReader()
        Dim upNum As Integer = 0
        If dr.HasRows Then
            While dr.Read()
                If upNum = 0 Then
                    lblSAccount.Text = CDec(dr(1)).ToString("C")
                    upNum += 1

                Else 'This is ending month value
                    lblEAccount.Text = CDec(dr(1)).ToString("C")
                    lblAccountComp.Text = (CDec(lblEAccount.Text) - CDec(lblSAccount.Text)).ToString("C")
                End If
            
            End While
        End If
        dr.Close()

    End Sub
    Public Function GetLastDayOfMonth(ByVal intMonth, ByVal intYear) As Date
        GetLastDayOfMonth = DateSerial(intYear, intMonth + 1, 0)
    End Function

    Private Sub buttonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnJan.Click, btnFeb.Click, btnMar.Click, _
        btnApr.Click, btnMay.Click, btnJune.Click, btnJul.Click, btnAug.Click, btnSep.Click, btnOct.Click, btnNov.Click, btnDec.Click
        Dim inDate As DateTime = "1/1/1900"
        Dim lastOfMonth As DateTime
        myButton.BackColor = Color.Aqua
        myButton = sender
        If sender Is btnJan Then
            inDate = "1/1/" & txtYr.Text
            lastOfMonth = GetLastDayOfMonth(1, txtYr.Text)
            ' lastOfMonth = inDate.Date.AddDays(-(inDate.Day - 1)).AddMonths(1).AddDays(-1)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnFeb Then
            inDate = "2/1/" & txtYr.Text
            lastOfMonth = GetLastDayOfMonth(2, txtYr.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnMar Then
            inDate = "3/1/" & txtYr.Text
            lastOfMonth = GetLastDayOfMonth(3, txtYr.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnApr Then
            inDate = "4/1/" & txtYr.Text
            lastOfMonth = GetLastDayOfMonth(4, txtYr.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnMay Then
            inDate = "5/1/" & txtYr.Text
            lastOfMonth = GetLastDayOfMonth(5, txtYr.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnJune Then
            inDate = "6/1/" & txtYr.Text
            lastOfMonth = GetLastDayOfMonth(6, txtYr.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnJul Then
            inDate = "7/1/" & txtYr.Text
            lastOfMonth = GetLastDayOfMonth(7, txtYr.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnAug Then
            inDate = "8/1/" & txtYr.Text
            lastOfMonth = GetLastDayOfMonth(8, txtYr.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnSep Then
            inDate = "9/1/" & txtYr.Text
            lastOfMonth = GetLastDayOfMonth(9, txtYr.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnOct Then
            inDate = "10/1/" & txtYr.Text
            lastOfMonth = GetLastDayOfMonth(10, txtYr.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnNov Then
            inDate = "11/1/" & txtYr.Text
            lastOfMonth = GetLastDayOfMonth(11, txtYr.Text)
            myButton.BackColor = Color.LightYellow
        ElseIf sender Is btnDec Then
            inDate = "12/1/" & txtYr.Text
            lastOfMonth = GetLastDayOfMonth(12, txtYr.Text)
            myButton.BackColor = Color.LightYellow
        End If
        dteStartDate = inDate
        strStartDate = inDate.ToString()
        dteEndDate = DateAdd(DateInterval.Month, 1, inDate)
        strEndDate = dteEndDate.ToString()
        txtYr.Text = inDate.Year
        txtMonth.Text = MonthName(inDate.Month, True)
        ShowMonth()

    End Sub

    Private Sub GroupCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles rbDR.CheckedChanged, _
    rbDRRent.CheckedChanged, _
    rbFR.CheckedChanged, _
    rbAll.CheckedChanged
        If loadComplete = True Then
            RetrieveAccountFromButtons()
            ShowMonth()
        End If
    End Sub

    
End Class