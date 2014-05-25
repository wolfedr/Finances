Imports System.Data.SqlClient
Imports System.Configuration
Public Class GetMorris
    Dim cn As SqlConnection
    Dim oCommand As SqlCommand

    Private Sub GetBank_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.AcceptButton = btnGo
        Dim myDate As Date
        Dim strSql As String = "Select Max(jnlTrandate) from tblDrJournal"
        'Dim myString As String = CType(myDate.Date, String)
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        cn.Open()
        oCommand = New SqlCommand(strSql, cn)
        myDate = CType(oCommand.ExecuteScalar(), Date)
        cn.Close()
        Dim myString As String = CType(myDate.Date, String)
        'Me.CancelButton = btnCancel
        lblBrowse.Text += myString

    End Sub


    'Private Sub btnGo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Me.DialogResult = Windows.Forms.DialogResult.OK
    '    Me.Close()
    'End Sub

    'Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Me.Close()
    'End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class