Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class rptFinancialA
    Dim cn As SqlConnection
    Dim dr As SqlDataReader
    Dim oCommand As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim reportPath As String
    Dim strMainQuery As String
    Private Sub ConfigureCrystalReports()
        reportPath = "C:\development\finances\finances\Reports\Crystal\BusinessAccount.rpt"
        Dim xReport As New BusinessAccount
        xReport.PrintOptions.PaperOrientation = PaperOrientation.Landscape


        'CrystalReportViewer1.ReportSource = reportPath

    End Sub
    Private Sub rptMonthly_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfigureCrystalReports()
        strMainQuery = "B"
        DisplayReport()

    End Sub
    Sub DisplayReport()
        Dim strSql As String = ""
        Select Case strMainQuery
            Case "B"
                strSql = "select Convert(varchar, jnlTrandate,101)  as col1,  jnlTranAmount as col2,  busName as col3, (actName + ' - ' + actDescription)  as col4, BankAccount as Col5, jnlTranDate from vwFundsA order by jnlTrandate"
            Case "M"
                strSql = "select a.busID as col1, a.busName as col2, ( c.actName + ' - ' + c.actDescription)  as col3  from tblBusiness a, tblDRCOA c where a.taggedAccount = c.acntID and a.busSiblingID in (1,0)  order by c.actName "
            Case "S"
                strSql = "select a.busID as col1, a.busName as col2, ( c.actDescription + ' - ' + c.actName)  as col3 from tblBusiness a, tblDRCOA c where a.taggedAccount = c.acntID and a.busSiblingID in (1,0)  order by c.actDescription  "
            Case Else
        End Select

        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader()

        'dataset that will hold data for crystal
        Dim ds As New dsBusiness
        Dim t As DataTable = ds.Tables.Add("Members")
        t.Columns.Add("col1", Type.GetType("System.String"))
        t.Columns.Add("col2", Type.GetType("System.Decimal"))
        t.Columns.Add("col3", Type.GetType("System.String"))
        t.Columns.Add("col4", Type.GetType("System.String"))
        t.Columns.Add("col5", Type.GetType("System.String"))
        Dim r As DataRow
        'Get data from query and put into crystal dataset. This is where custom formatting is applied.
      

        If dr.HasRows Then
            While dr.Read
                r = t.NewRow()
                'dtA = dr(0) : intA = dtA.Year ' + dtA.Month '   : strA = Convert.ToDateTime(dtA.Month) ' & "-" & dtA.Year
                Dim x As String = dr(0).ToString()
                r("col1") = dr(0).ToString ' & "-" & dtA.Year  '  strA 'dr(0).ToString()  ' i.ToString()
                r("col2") = dr(1)   '"Item" & i.ToString()
                r("col3") = dr(2).ToString()   '"Item" & i.ToString()
                r("col4") = dr(3).ToString()   '"Item" & i.ToString()
                r("col5") = dr(4).ToString()   '"Item" & i.ToString()
                t.Rows.Add(r)
            End While
        End If
        cn.Close()

        Dim objRpt As New BusinessAccount
        'Set display objects on the crystal report
        Dim txtTitle As TextObject = Nothing
        Dim txtHeader1 As TextObject = Nothing
        Dim txtHeader2 As TextObject = Nothing
        Dim txtHeader3 As TextObject = Nothing
        Dim txtHeader4 As TextObject = Nothing
        Dim txtHeader5 As TextObject = Nothing
        Dim txtData1 As FieldObject
        Dim txtData2 As FieldObject
        Dim txtData3 As FieldObject
        Dim txtData4 As FieldObject
        Dim txtData5 As FieldObject
        If objRpt.ReportDefinition.ReportObjects("crlTitle") IsNot Nothing Then
            txtTitle = CType(objRpt.ReportDefinition.ReportObjects("crlTitle"), TextObject)
            txtTitle.Width = 4000
            txtTitle.Left = 3500
            txtTitle.Text = "Financial Data"

            txtHeader1 = CType(objRpt.ReportDefinition.ReportObjects("Header1"), TextObject)
            txtData1 = CType(objRpt.ReportDefinition.ReportObjects("Data1"), FieldObject)
            txtHeader1.Text = "Date"
            txtHeader1.Width = 800
            txtHeader1.Left = 200
            txtData1.Width = 1000
            txtData1.Left = 300

            txtHeader2 = CType(objRpt.ReportDefinition.ReportObjects("Header2"), TextObject)
            txtData2 = CType(objRpt.ReportDefinition.ReportObjects("Data2"), FieldObject)
            txtHeader2.Text = "Amount "
            txtHeader2.Left = 1500
            txtHeader2.Width = 900
            txtData2.Left = 1200
            txtData2.Width = 900
            txtData2.ObjectFormat.HorizontalAlignment = Alignment.RightAlign

            txtHeader3 = CType(objRpt.ReportDefinition.ReportObjects("Header3"), TextObject)
            txtData3 = CType(objRpt.ReportDefinition.ReportObjects("Data3"), FieldObject)
            txtHeader3.Text = "Business "
            txtHeader3.Width = 3000
            txtHeader3.Left = 2500
            txtData3.Width = 3000
            txtData3.Left = 2500

            txtHeader4 = CType(objRpt.ReportDefinition.ReportObjects("Header4"), TextObject)
            txtData4 = CType(objRpt.ReportDefinition.ReportObjects("Data4"), FieldObject)
            txtHeader4.Text = "Related Account "
            txtHeader4.Width = 2000
            txtHeader4.Left = 5500
            txtData4.Width = 5000
            txtData4.Left = 5000

            txtHeader5 = CType(objRpt.ReportDefinition.ReportObjects("Header5"), TextObject)
            txtData5 = CType(objRpt.ReportDefinition.ReportObjects("Data5"), FieldObject)
            txtHeader5.Text = "Bank Account "
            txtHeader5.Width = 1400
            txtHeader5.Left = 10500
            txtData5.Width = 1400
            txtData5.Left = 10500


        End If
        objRpt.SetDataSource(ds.Tables("Members"))
        CrystalReportViewer1.ReportSource = objRpt
        objRpt.PrintOptions.PaperOrientation = PaperOrientation.Landscape
        'CrystalReportViewer1.Refresh()
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub rbBusiness_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBusiness.CheckedChanged
        strMainQuery = "B"
        DisplayReport()
    End Sub

    Private Sub rbMaster_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMaster.CheckedChanged
        strMainQuery = "M"
        DisplayReport()
    End Sub

    Private Sub rbSub_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSub.CheckedChanged
        strMainQuery = "S"
        DisplayReport()
    End Sub
End Class