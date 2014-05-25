Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration

Public Class SubView
    Public stDate As Date
    Public enDate As Date
    Public intAct As Int16
    Public intMon As Int16
    Public strFlag As String
    Dim cn As SqlConnection
    Dim myCommand As SqlCommand

    Private Sub SubView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Get Data
        On Error Resume Next
        Dim strSql As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        strSql = "Select b.actDescription, sum(a.jnlTranAmount)*-1 as tot "
        strSql += "from tblDRJournal a "
        strSql += ", tblDRCOA b  "
        strSql += "Where a.jnlTranDate <= '" & enDate & "'"
        strSql += " and a.jnlTranDate >= '" & stDate & "'"
        'Are we looking at monthly or yearly data.
        If strFlag = "Y" Then
            strSql += " and month(a.jnlTranDate) = " & intMon
        Else
            strSql += " and datepart(week,jnlTranDate) = " & intMon
        End If
        strSql += " and a.jnlActNum = b.actNum "
        strSql += " and a.jnlActSeq = b.actNumSeq "
        strSql += " and a.jnlActNum = " & intAct
        strSql += " group by b.actDescription  "
        strSql += "order by b.actDescription"
        Dim custDA As New SqlDataAdapter
        ' Create a database command on the connection using query	
        Dim myCommand As New SqlCommand(strSql, cn)
        custDA.SelectCommand = myCommand
        Dim dt As New DataTable
        cn.Open()
        custDA.Fill(dt)
        dgvSub.DataSource = dt
        'If this is empty the error routine will skip it.
        lblSubTotal.Text = Format(dt.Compute("Sum(tot)", ""), "$###,###.#0")
        ' Open the connection	
        cn.Close()
        dgvSub.Columns(0).Width = 200
        dgvSub.Columns(1).Width = 100
        dgvSub.Columns(1).DefaultCellStyle.Format = "C2"
        dgvSub.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


End Class
