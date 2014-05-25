Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class rptMonthlyBase
    Dim cn As SqlConnection
    Dim dr As SqlDataReader
    Dim oCommand As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim reportPath As String
    Dim strMainQuery As String
    Private Sub ConfigureCrystalReports()
        reportPath = "C:\development\finances\finances\Reports\Crystal\BusinessAccount.rpt"
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
                strSql = "select a.busID as col1, a.busName as col2, ( c.actName + ' - ' + c.actDescription)  as col3 from tblBusiness a, tblDRCOA c where a.taggedAccount = c.acntID and a.busSiblingID in (1,0)  order by a.busname  "
            Case "M"
                strSql = "select a.busID as col1, a.busName as col2, ( c.actName + ' - ' + c.actDescription)  as col3 from tblBusiness a, tblDRCOA c where a.taggedAccount = c.acntID and a.busSiblingID in (1,0)  order by c.actName "
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
        t.Columns.Add("col1", Type.GetType("System.Int32"))
        t.Columns.Add("col2", Type.GetType("System.String"))
        t.Columns.Add("col3", Type.GetType("System.String"))
        Dim r As DataRow
        'Get data from query and put into crystal dataset
        If dr.HasRows Then
            While dr.Read
                r = t.NewRow()
                r("col1") = dr(0).ToString() ' i.ToString()
                r("col2") = dr(1).ToString()   '"Item" & i.ToString()
                r("col3") = dr(2).ToString()   '"Item" & i.ToString()
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
        Dim txtData1 As FieldObject
        Dim txtData2 As FieldObject
        Dim txtData3 As FieldObject

        If objRpt.ReportDefinition.ReportObjects("crlTitle") IsNot Nothing Then
            txtTitle = CType(objRpt.ReportDefinition.ReportObjects("crlTitle"), TextObject)
            txtTitle.Width = 4000
            txtTitle.Left = 3500
            txtTitle.Text = "Business Accounts"

            txtHeader1 = CType(objRpt.ReportDefinition.ReportObjects("Header1"), TextObject)
            txtData1 = CType(objRpt.ReportDefinition.ReportObjects("Data1"), FieldObject)
            txtHeader1.Text = " ID "
            txtHeader1.Width = 400
            txtHeader1.Left = 700
            txtData1.Width = 400
            txtData1.Left = 700

            txtHeader2 = CType(objRpt.ReportDefinition.ReportObjects("Header2"), TextObject)
            txtData2 = CType(objRpt.ReportDefinition.ReportObjects("Data2"), FieldObject)
            txtHeader2.Text = " Business Name "
            txtHeader2.Left = 2000
            txtHeader2.Width = 2000
            txtData2.Left = 1500
            txtData2.Width = 3000

            txtHeader3 = CType(objRpt.ReportDefinition.ReportObjects("Header3"), TextObject)
            txtData3 = CType(objRpt.ReportDefinition.ReportObjects("Data3"), FieldObject)
            txtHeader3.Text = "Related Account "
            txtHeader3.Width = 2000
            txtHeader3.Left = 5500
            txtData3.Width = 5000
            txtData3.Left = 5000


        End If
        objRpt.SetDataSource(ds.Tables("Members"))
        CrystalReportViewer1.ReportSource = objRpt
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