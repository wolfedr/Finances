Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Threading
Imports Microsoft.VisualBasic

Public Class Divide
    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim myDataset As New DataSet
    Dim bs As BindingSource
    Dim rowCnt, rowCnt2 As Integer
    Dim aryGets As New ArrayList()
    Dim LoadComplete As Boolean = False

    Private Sub Divide_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DisplayTransactions()
        LoadComplete = True

    End Sub


    Private Sub DisplayTransactions()
        ' populates  dropdown of available Transactions
        Dim strSql As String
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        If rbDeposit.Checked Then
            strSql = "SELECT jnlID, (CONVERT(VARCHAR(10),jnlTranDate,111) + '  :  $' + CONVERT(VARCHAR,jnlTranAmount,1) + '  :  ' +  jnlTranMemo + ' : ' + jnlTranDesc )as Display"
            strSql += " FROM tblDRJournal where jnlTranType = 'DEP' ORDER BY jnlTranDate"
        Else
            strSql = "SELECT jnlID, (CONVERT(VARCHAR(10),jnlTranDate,111) + '  :  $' + CONVERT(VARCHAR,jnlTranAmount,1) + '  :  ' +  jnlTranMemo + ' : ' + jnlTranDesc )as Display"
            strSql += " FROM tblDRJournal where jnlTranType = 'ATM' ORDER BY jnlTranDate"
        End If
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        DA1.Fill(DS1, "tblDRJournal")
        Dim myRow As Integer = DS1.Tables(0).Rows.Count
        Dim dt As DataTable = DS1.Tables(0)
        dt.Rows.Add()
        cmbTransact.DataSource = DS1.Tables("tblDRJournal")
        cmbTransact.DisplayMember = "Display"
        cmbTransact.ValueMember = "jnlID"
        cn.Close()
    End Sub


    Private Sub rbDeposit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDeposit.CheckedChanged
        If LoadComplete = True Then
            DisplayTransactions()
        End If
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        AllocDep.journlID = cmbTransact.SelectedValue
        AllocDep.ShowDialog()
    End Sub
End Class