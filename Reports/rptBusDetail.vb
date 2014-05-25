Imports System.Data.SqlClient
Imports System.Configuration
Public Class rptBusDetail
    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim bs As BindingSource
    Dim LoadComplete As Boolean = False
    Public gblbusName As String
    Public strDetailStart As String
    Public strDetailEnd As String

    Private Sub rptDetail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strSql As String
        Dim n As Integer
        lblAccountName.Text = "Details for " & gblbusName & vbCrLf & strDetailStart & " to " & strDetailEnd
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        dgvActDetail.RowCount = 1 'This clears any data out of the gird
        strSql = "select (ltrim(str(a.jnlActNum)) + '-' + ltrim(str(a.jnlActSeq))) as Account,  sum(a.jnlTranAmount) as Total, jnlTranDate, b.actName, b.actDescription, c.busName, a.jnlID "
        strSql += "from tblDRJournal a, tblDRCOA b, tblBusiness c where(b.actNum = a.jnlActNum And a.jnlActSeq = b.actNumSeq And a.jnlTranBusinessID = c.busID)"
        strSql += " and c.busName = '" & gblbusName & "' and a.jnlTranDate >= '" & strDetailStart & "' and a.jnlTranDate < '" & strDetailEnd & "' "
        strSql += "group by a.jnlActNum, a.jnlActSeq, a.jnlTranDate, b.actDescription, c.busName, b.actName, a.jnlID order by a.jnlTranDate"
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim dr As SqlDataReader = oCommand.ExecuteReader()
        Dim CNT As Integer = 0
        Dim sngActSum As Single
        While dr.Read()
            'If CNT = 0 Then
            'If Len(actID) > 4 Then
            'lblAccountName.Text = dr(3) & " : " & dr(4) & " : " & strCaption
            'Else
            'lblAccountName.Text = dr(3) & " : " & strCaption
            'End If
            'End If

            CNT += 1
            dgvActDetail.Rows.Item(n).Cells(0).Value = dr(6)
            dgvActDetail.Rows.Item(n).Cells(1).Value = dr(0)
            dgvActDetail.Rows.Item(n).Cells(2).Value = dr(4)
            Dim sx As Single = dr.GetSqlMoney(1)
            dgvActDetail.Rows.Item(n).Cells(3).Value = String.Format("{0:C}", sx)
            dgvActDetail.Rows.Item(n).Cells(4).Value = dr(5)
            Dim dt As Date = dr.GetSqlDateTime(2)
            dgvActDetail.Rows.Item(n).Cells(5).Value = String.Format("{0:d}", dt)

            sngActSum += sx
            n = dgvActDetail.Rows.Add()
        End While
        dgvActDetail.Rows(n).Cells(1).Style.BackColor = Color.Beige
        dgvActDetail.Rows(n).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvActDetail.Rows(n).Cells(1).Style.Font = New Font("calibri", 12, FontStyle.Bold)
        dgvActDetail.Rows.Item(n).Cells(1).Value = "Total"
        dgvActDetail.Rows(n).Cells(2).Style.Font = New Font("calibri", 12, FontStyle.Bold)
        dgvActDetail.Rows(n).Cells(2).Style.BackColor = Color.Beige
        dgvActDetail.Rows(n).Cells(2).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvActDetail.Rows(n).Cells(2).Style.Font = New Font("calibri", 12, FontStyle.Bold)
        dgvActDetail.Rows.Item(n).Cells(2).Value = String.Format("{0:C}", sngActSum)
        n = dgvActDetail.Rows.Add()
        dr.Close()
        cn.Close()
    End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvActDetail_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvActDetail.CellContentClick
        Dim strSendAccount As String

        If e.RowIndex < 0 Or e.RowIndex >= dgvActDetail.Rows.Count Or e.ColumnIndex < 0 Or e.ColumnIndex >= dgvActDetail.Columns.Count Then
            Exit Sub
        Else

            If e.ColumnIndex() = 0 Then
                Dim linkCell As DataGridViewLinkCell = dgvActDetail.Rows(e.RowIndex).Cells(e.ColumnIndex) 'as DataGridViewLinkCell

                If linkCell.Value = Nothing Then Exit Sub
                strSendAccount = dgvActDetail.Rows(e.RowIndex).Cells(0).Value
                JournalDetail.strID = strSendAccount
                JournalDetail.ShowDialog()

                'Dim s As String = linkCell.Value
            End If
        End If



    End Sub
End Class