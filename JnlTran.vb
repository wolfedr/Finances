Imports System.Data.SqlClient
Imports System.Configuration
Public Class JnlTran

    Private _trandate As DateTime
    Private _tranYear As Int16
    Private _tranMonth As Int16
    Private _tranAccount As Int16
    Private _tranSequence As Int16
    Private _tranBankAccount As Int16
    Private _tranEntityList As String
    Private cn As SqlConnection
    Dim aryAll As ArrayList = New ArrayList
    'Public Property TranDate() As DateTime
    '    Get
    '        Return _trandate
    '    End Get
    '    Set(ByVal value As DateTime)
    '        value = _trandate
    '    End Set
    'End Property
    'Public Property TranYear() As Int16
    '    Get
    '        Return _tranYear
    '    End Get
    '    Set(ByVal value As Int16)
    '        value = _tranYear
    '    End Set
    'End Property

    'Public Property TranMonth() As Int16
    '    Get
    '        Return _tranMonth
    '    End Get
    '    Set(ByVal value As Int16)
    '        value = _tranMonth
    '    End Set
    'End Property
    'Public Property TranAccount() As Int16
    '    Get
    '        Return _tranAccount
    '    End Get
    '    Set(ByVal value As Int16)
    '        value = _tranAccount
    '    End Set
    'End Property

    'Public Property TranSequence() As Int16
    '    Get
    '        Return _tranSequence
    '    End Get
    '    Set(ByVal value As Int16)
    '        value = _tranSequence
    '    End Set
    'End Property

    'Public Property TranBankAccount() As Int64
    '    Get
    '        Return _tranBankAccount
    '    End Get
    '    Set(ByVal value As Int64)
    '        value = _tranBankAccount
    '    End Set
    'End Property
    'Public Property TranEntityList() As String
    '    Get
    '        Return _tranEntityList
    '    End Get
    '    Set(ByVal value As String)
    '        value = _tranEntityList
    '    End Set
    'End Property
    'Public Sub New()

    'End Sub


    Public Function DisplayData(ByVal TranYear As Int16, ByVal TranMonth As Int16, ByVal TranAccount As Int16, ByVal TranSequence As Int16, ByVal TranBankAccount As String, ByVal TranEntityList As String) As DataTable
        Dim strSql As String = ""
        Dim strSql2 As String = ""
        Dim strSql3 As String = ""
        Dim intSqlId As Integer = 0
        'Cnnection
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        'Basic query to retrieve journal records for analysis
        strSql = "SELECT a.jnlID, a.jnlTranDate,  d.actName,(ltrim(a.jnlActNum) + '-' + ltrim(a.jnlActSeq)) as Account, a.jnlTranType, a.jnlTranAmount, b.busName, "
        strSql += "a.jnlTranDesc, a.jnlTranMemo, c.actName, c.actDescription,left(a.jnlActNum,1) as 'N' "
        strSql += "FROM tblDRJournal a, tblBusiness b, tblDRCOA c, tblBankAcct d "
        strSql += "WHERE a.jnlTranBusinessID = b.busID And a.jnlActNum = c.actNum And a.jnlActSeq = c.actNumSeq and a.jnlBankAct = d.actNum  "

        strSql2 = "SELECT    c.actDescription, Sum(a.jnlTranAmount) as Tot, (ltrim(a.jnlActNum) + '-' + ltrim(a.jnlActSeq)) as Account"
        strSql2 += " FROM tblDRJournal a, tblBusiness b, tblDRCOA c, tblBankAcct d "
        strSql2 += " WHERE(a.jnlTranBusinessID = b.busID And a.jnlActNum = c.actNum And a.jnlActSeq = c.actNumSeq And a.jnlBankAct = d.actNum)"

        strSql3 = "SELECT c.actName, Sum(a.jnlTranAmount) as Tot, (ltrim(a.jnlActNum)) as Account"
        strSql3 += " FROM tblDRJournal a, tblBusiness b, tblDRCOA c, tblBankAcct d "
        strSql3 += " WHERE(a.jnlTranBusinessID = b.busID And a.jnlActNum = c.actNum And a.jnlActSeq = c.actNumSeq And a.jnlBankAct = d.actNum)"
        'Filter Criteria to view Journal information based on preferences
        If TranYear > 0 Then
            strSql += " and DATEPART(year, a.jnlTranDate)  = " & TranYear
            strSql2 += " and DATEPART(year, a.jnlTranDate)  = " & TranYear
            strSql3 += " and DATEPART(year, a.jnlTranDate)  = " & TranYear
        End If
        If TranMonth > 0 Then
            strSql += " and DATEPART(month, a.jnlTranDate)  = " & TranMonth
            strSql2 += " and DATEPART(month, a.jnlTranDate)  = " & TranMonth
            strSql3 += " and DATEPART(month, a.jnlTranDate)  = " & TranMonth
        End If
        If Len(TranEntityList) > 0 Then
            'Dim testy As String = aryAll(TranEntityList)
            strSql += " and b.busID in ( " & TranEntityList & ")"
            strSql2 += " and b.busID in ( " & TranEntityList & ")"
            strSql3 += " and b.busID in ( " & TranEntityList & ")"
        End If
        If Len(TranBankAccount) > 0 Then
            strSql += " and d.actName = '" & TranBankAccount & "'"
            strSql2 += " and d.actName = '" & TranBankAccount & "'"
            strSql3 += " and d.actName = '" & TranBankAccount & "'"
        End If
        If TranAccount > 0 Then
            strSql += " and a.jnlActNum = " & TranAccount & " and a.jnlActSeq = " & TranSequence
            strSql2 += " and a.jnlActNum = " & TranAccount & " and a.jnlActSeq = " & TranSequence
            strSql3 += " and a.jnlActNum = " & TranAccount & " and a.jnlActSeq = " & TranSequence
        End If
        strSql += " order by jnlTranDate desc"
        strSql2 += " group by c.actDescription, a.jnlActNum, a.jnlActSeq order by c.actDescription"
        strSql3 += " group by c.actName, a.jnlActNum order by c.actName"

        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, cn)
        Dim dt As DataTable = New DataTable
        cn.Open()
        da.Fill(dt)
        cn.Close()
        cn.Close()
        da.Dispose()
        da = Nothing
        Return dt


    End Function








End Class
