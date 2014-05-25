Imports System.Data.SqlClient
Imports System.Configuration
Public Class Utilities
    Dim cn As SqlConnection
    Dim oCommand As SqlCommand
    Dim dr As SqlDataReader


    Private Sub Utilities_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnImportBusinesses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportBusinesses.Click

        Dim strSql As String = "select distinct left(bnkTranName,20) from tblMorrisTransactions where not left(bnkTranName,20) in"
        strSql += "(Select distinct BusLeftName FROM tblBusiness)"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader()
        If dr.HasRows Then
            While dr.Read




            End While
            dr.Close()
        End If




    End Sub
End Class
