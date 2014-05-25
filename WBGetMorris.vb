Imports System.Data.SqlClient
Imports System.Configuration
Public Class WBGetMorris
    Dim cn As SqlConnection
    Dim oCommand As SqlCommand

    Private Sub GetBank_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.AcceptButton = btnGo
        Dim myDate As Date
        Dim strSql As String = "Select Max(jnlTrandate) from tblDrJournal"
        Dim myString As String = CType(myDate.Date, String)
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        cn.Open()
        oCommand = New SqlCommand(strSql, cn)
        myDate = CType(oCommand.ExecuteScalar(), Date)
        cn.Close()
        'Dim myString As String = CType(myDate.Date, String)
        lblBrowse.Text += myString
        Me.WebBrowser1.Navigate("https://www.morrisstate.com/home/home")



    End Sub




    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class