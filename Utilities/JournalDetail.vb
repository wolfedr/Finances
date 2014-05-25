Imports System.Data.SqlClient
Imports System.Configuration
Public Class JournalDetail
    Dim cn As SqlConnection
    Dim oCommand As SqlCommand
    Dim LoadComplete As Boolean = False
    Dim strSql As String
    Dim dr As SqlDataReader
    Dim n As Integer
    Public strID As String
     
    Private Sub JournalDetail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        strSql = "select * from tblDRJournal where jnlId = " & strID
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            txtJnlID.Text = dr("jnlID")
            txtActID.Text = dr("jnlActID")
            txtAccountNum.Text = dr("jnlActNum")
            txtAccountSeq.Text = dr("jnlActSeq")
            txtTranDAte.Text = dr("jnlTranDate")
            txtTranType.Text = dr("jnlTranType")
            txtTramAmount.Text = dr("jnlTranAmount")
            txtDesc.Text = dr("jnlTranDesc")
            txtMemo.Text = dr("jnlTranMemo")
            txtActivity.Text = dr("jnlActivity")
            txtBusID.Text = dr("jnlTranBusinessID")
            txtBnkTranID.Text = dr("jnlBankTranID")
            txtTranType.Text = dr("jnlTranType")
            txtBnkAccountID.Text = dr("jnlBankAct")
        End If
        dr.Close()
        cn.Close()


    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class