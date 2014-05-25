Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Threading
Imports Microsoft.VisualBasic

Public Class Distribute
    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Public StartAccountAmount As Decimal
    Public UsedAccountAmount As Decimal
    Public StartAccountID As String

    Private Sub Distribute_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Get passed in journal ID
        UsedAccountAmount = 0
        lblSourceID.Text = StartAccountID
        'Get record for this entry and if no link exists start one.  Oy
        Dim strSql As String = "Select coalesce(a.jnlLink, str(a.jnlID) + '_0') as Link, b.busName as Entity, a.jnlTranAmount as Amount, "
        strSql += "a.jnlTranDesc as Description, a.jnlTranMemo as Memo, a.jnlActivity as Activity, c.actName + ':  ' + c.actDescription as Account from tblDRJournal a"
        strSql += " inner join tblBusiness b on a.jnlTranBusinessID = b.busID "
        strSql += " inner join tblDRCoa c on a.jnlActNum = c.actNum and a.jnlActSeq  = c.actNumSeq "
        strSql += " where jnlActive = 1 and (a.jnlID = " & lblSourceID.Text & ")"
        strSql += " or a.jnlLink like '" + lblSourceID.Text & "%' order by jnlLink"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        ds = New DataSet
        Dim da As New SqlDataAdapter(strSql, cn)
        da.Fill(ds)
        'Display the entry
        dgDistribute.DataSource = ds.Tables(0)
        ' Now find the journal identifier in the first column first row of the table
        Dim dtLoc As DataTable
        Dim drLoc As DataRow
        dtLoc = ds.Tables(0)
        drLoc = dtLoc.Rows(0)
        Dim myVal As String = drLoc(0).ToString.Trim  'The jnllink root is the jnlID of the entry distributed
        StartAccountAmount = drLoc(2) 'The amount to be distributed is also in the first row.
        'If there is only one record then this is the first time this entry has been distrubuted
        Dim intRecs As Integer = ds.Tables(0).Rows.Count
        If intRecs = 1 Then 'This is the initial distributtion
            drLoc(0) = myVal
            'Update the link on the base starting record. The one to be parsed.
            da.UpdateCommand = New SqlCommand("UPDATE tblDRJournal SET jnlLink = '" & myVal & "' WHERE jnlID = " & lblSourceID.Text, cn)
            txtLink.Text = lblSourceID.Text + "_1" '+ CType(myIntVal + 1, String)
        Else 'This is a later distribution.
            'Now calculatet the first additional link number to display for possible addidtional distributions.
            txtLink.Text = lblSourceID.Text + "_" + CType(intRecs, String)
        End If
        da.Update(ds)
        cn.Close()
        DisplayActivites()
        DisplayCommonAccounts()
        txtAmount.Focus()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        'Find the activity ID for the new one.
        Dim intMyActivityID As Int32
        Dim strSql As String = "Select ActivityID from tblActivity where activityDescription = '" & cmbActivity.SelectedValue & "'"
        oCommand = New SqlCommand(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        Try
            intMyActivityID = oCommand.ExecuteScalar()
            If intMyActivityID < 1 Then
                MessageBox.Show("There was an error in adding the activity. See administrator!", "ERROR", MessageBoxButtons.OK)
                Exit Sub
            End If
        Catch
            MessageBox.Show(Err.Description, "ERROR", MessageBoxButtons.OK)
            Exit Sub
        Finally
            cn.Close()
        End Try
        'Find the new sequence numbers from the combo box datarow.
        Dim thisRow As DataRowView
        thisRow = CType(cmbCommonAccounts.SelectedItem, DataRowView)
        Dim myAct As String = thisRow(0)
        Dim actRes() As String = myAct.Split("-")
        'Check whether a deposit of a withdrawl by checking the sign.
        Dim decNewAmount, decDistributedAmount As Decimal
        decDistributedAmount = CType(txtAmount.Text, Decimal) 'Get the newly entered amount for the distribution
        'breaking down expenses or revenues
        If StartAccountAmount > 0 Then
            decNewAmount = (StartAccountAmount - UsedAccountAmount) - decDistributedAmount  'Reduce the positive desposit and leave the new distribution positive
            'deposit
        Else
            'withdrawl
            decDistributedAmount *= -1
            decNewAmount = (StartAccountAmount - UsedAccountAmount) - decDistributedAmount  'subtract the negative amount from a negative to reduce it
        End If
        'This means the amount to be distributed was used up.
        

        'Chekc the new amount and make sure there is enough in the root to cover
        'Dim decNewAmount As Decimal = Math.Abs(StartAccountAmount) - CType(txtAmount.Text, Decimal)
        'If decNewAmount <= 0 Then
        'MessageBox.Show("The amount of funds in the base record below (_0) can not be less than or equal to the new amount distributed!", "Error", MessageBoxButtons.OK)
        'Exit Sub
        'End If
        'Now add the new record to the database with the specified amount
        strSql = "Insert into tblDRJournal select '" & txtLink.Text & "', 0, " & actRes(0) & ", " & actRes(1) & ", a.jnlTranDate, a.jnlTranType, '"
        strSql += decDistributedAmount & "', '" & txtDesc.Text & "', '" & txtMemo.Text & "', a.jnlTranBusinessId, a.jnlBankTranID, a.jnlBankAct, "
        strSql += "a.timestamp, " & intMyActivityID & ", '" & cmbActivity.SelectedValue & "', 1, a.ExternalMark "
        strSql += " from tblDRJournal A where a.jnlID = " & lblSourceID.Text
        oCommand = New SqlCommand(strSql, cn)
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            oCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
            Exit Sub
        End Try
        'Update the original records amount
        strSql = "update tblDRJournal set jnlTranAmount = " & decNewAmount & " where jnlID = " & StartAccountID
        oCommand = New SqlCommand(strSql, cn)
        Try
            oCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
            Exit Sub
        Finally
            cn.Close()
        End Try



        DisplayLinkedRecords()


    End Sub
    Private Sub DisplayLinkedRecords()
        Dim strSql As String = "Select a.jnlLink as Link, b.busName as Entity, a.jnlTranAmount as Amount, a.jnlTranDesc as Description, a.jnlTranMemo as Memo, a.jnlActivity as Activity  from tblDRJournal "
        strSql += "a inner join tblBusiness b on a.jnlTranBusinessID = b.busID where jnlActive = 1 and left(a.jnlLink," & lblSourceID.Text.Length & ") = '" & lblSourceID.Text & "'"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        ds = New DataSet
        Dim da As New SqlDataAdapter(strSql, cn)
        da.Fill(ds)
        'Display the entry
        dgDistribute.DataSource = ds.Tables(0)

        'Sum up the entries skipping the first one which is the original transactio being distributed
        UsedAccountAmount = 0
        For i As Integer = 1 To ds.Tables(0).Rows.Count - 1
            UsedAccountAmount += ds.Tables(0).Rows(i).Item(2)
        Next
        'See if the amounts are all used up
        Dim decLeft As Decimal = StartAccountAmount - UsedAccountAmount
        If decLeft <= 0 Then
            MsgBox("The entry you distributed is now empty and will be deactivated.", MsgBoxStyle.OkOnly, "Notice")
            strSql = "Update tblDRJournal set jnlActive = 0 where jnlID = " & StartAccountID
            oCommand = New SqlCommand(strSql, cn)
            Try
                If cn.State = ConnectionState.Closed Then cn.Open()
                oCommand.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
                Exit Sub
            Finally
                cn.Close()
            End Try

        End If


        'Determine the increment for the next distribution
        Dim intCnt As Integer = ds.Tables(0).Rows.Count
        Dim myRow As DataRow = ds.Tables(0).Rows(intCnt - 1)
        Dim strEntryAry() As String = myRow(0).ToString.Split("_")
        txtLink.Text = strEntryAry(0) & "_" & intCnt.ToString()





    End Sub

    Private Sub DisplayActivites()
        ' populates  dropdown of available Activites
        Dim DS1 As DataSet = New DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "select  ActivityID, ActivityDescription from tblActivity order by ActivitySort "
        DA1 = New SqlDataAdapter(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        DA1.Fill(DS1, "tblActivity")
        Dim myRow As Integer = DS1.Tables(0).Rows.Count
        Dim dt As DataTable = DS1.Tables(0)
        dt.Rows.Add()
        cmbActivity.DataSource = DS1.Tables("tblActivity")
        cmbActivity.DisplayMember = "activityDescription"
        cmbActivity.ValueMember = "activityDescription"
        cn.Close()
    End Sub
    Sub DisplayCommonAccounts()
        'Dim strSql As String = "SELECT ltrim(str(actNum)) + '-' + ltrim(str(actNumSeq)) as accountid,  (actName + ':' + actDescription) as Account"
        'strSql += " FROM tblDRCOA Where jnlActive = 1 and actUse = 20 and actNum IN (9100, 9110, 9115, 9120) ORDER BY actNum, actNumSeq"
        Dim strSql As String = "SELECT ltrim(str(actNum)) + '-' + ltrim(str(actNumSeq)) as accountid,  (actName + ':' + actDescription) as Account"
        strSql += " FROM tblDRCOA Where actUse = 20 order by actname, actDescription   'and actNum IN (9100, 9110, 9115, 9120) ORDER BY actNum, actNumSeq"
        Dim DS1 As DataSet = New DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        DA1 = New SqlDataAdapter(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        DA1.Fill(DS1, "tblDRCOA")
        Dim myRow As Integer = DS1.Tables(0).Rows.Count
        Dim dt As DataTable = DS1.Tables(0)
        dt.Rows.Add()
        cmbCommonAccounts.DataSource = DS1.Tables("tblDRCOA")
        cmbCommonAccounts.DisplayMember = "Account"
        cmbCommonAccounts.ValueMember = "accountid"
        cn.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class