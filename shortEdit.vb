Imports System.Data.SqlClient
Imports System.Configuration
Public Class shortEdit
    Dim cn As SqlConnection
    Dim oCommand As SqlCommand
    Dim dr As SqlDataReader
    Public changeValue As String
    Public blnFirst As Boolean = False

    Private Sub shortEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        txtEditItem.Text = changeValue



    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        changeValue = txtEditItem.Text
        blnFirst = True
        Me.Close()
    End Sub
End Class
