Imports System.Data.SqlClient
Imports System.Configuration

Public Class AllocDep
    Dim oCommand As SqlCommand
    Dim reader As SqlDataReader
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim dsATM As DataSet
    Dim LoadComplete As Boolean = False
    Dim ATMtable As DataTable
    Dim intCurrentRow As Int16
    Public journlID As Integer

    Private Sub AllocateDeposit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ClearInput()
        hdnCounter.Text = 0 'set hidden count of records in split array.
        hdnRowCount.Text = 0
        DisplayDeposit()
        DisplayActivites()
        If journlID > 0 Then
            ShowData()
        End If
        LoadComplete = True
    End Sub

    Private Sub ShowData()
        Dim tstID As Long = journlID
        If ddlDeposits.SelectedIndex = 0 Then Exit Sub
        fillform(tstID)
        DisplayGrid()
        hdnRowCount.Text = 0
        txtNewDesciption.TextAlign = HorizontalAlignment.Center
        txtAmountToAllocate.TextAlign = HorizontalAlignment.Center
        LoadComplete = True
    End Sub

    Private Sub DisplayDeposit()
        ' populates  dropdown of available Deposits
        'Fill Deposit  Dropdown
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "SELECT jnlID, (convert(varchar, jnlTranDate, 101) + ' : ' +  '$' + convert(varchar,cast(jnlTranAmount as money),-1)) "
        strSql += "+ CASE LEN(COALESCE(jnlLink,'X')) WHEN '1' THEN '' ELSE  ' ***' END as jnlListing FROM tblDRJournal WHERE jnlTranType = 'DEP' ORDER BY jnlTranDate desc"
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        DA1.Fill(DS1, "tblDRJournal")
        'Dim myRow As Integer = DS1.Tables(0).Rows.Count
        Dim dt As DataTable = DS1.Tables(0)
        Dim drw As DataRow = dt.NewRow()
        drw.Item(0) = "0"
        drw.Item(1) = "Select Deposit"
        Dim selvalue As Integer
        dt.Rows.InsertAt(drw, selvalue)
        dt.AcceptChanges()
        dt.Rows.Add()
        ddlDeposits.DataSource = dt  ' DS1.Tables("tblDRJournal")
        ddlDeposits.DisplayMember = "jnlListing"
        ddlDeposits.ValueMember = "jnlID"
        cn.Close()
    End Sub

    Private Sub fillform(ByVal id As Long)
        'Add a new row
        hdnLinker.Text = id.ToString.Trim
        FillAllocateView(id)  'This creates the main datagrid of journal entries.
        Dim intRowCnt As Integer = Convert.ToInt32(hdnRowCount.Text)
        hdnCounter.Text = (Convert.ToSingle(hdnCounter.Text) + 1).ToString()
        'Add next row of data to main datagrid
        Dim drow As DataRow = ATMtable.NewRow
        drow(0) = hdnLinker.Text
        SearchExisiting(drow(0))
        drow(1) = hdnLinker.Text & "_" & hdnCounter.Text
        drow(3) = dgvLOA.Rows(0).Cells(3).Value   'Copy date to next row
        drow(4) = "DEP"
        drow(9) = hdnBankTranID.Text
        drow(10) = hdnBankAccount.Text
        drow(12) = ddlActivity.SelectedValue
        drow(13) = ddlActivity.Text
        'ATMtable.Rows.Add(drow)
        'Change enabled and viewable screen objects
        dgvLOA.Visible = True 'Show new record and edited atm record for journal we are preparing
        dgvLOA.Rows(1).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Sub FillAllocateView(ByVal myID As Int64)
        Dim strSql As String = "select jnlID as ID,  ltrim(str(jnlID)) + '_0' as Linker,  (ltrim(str(jnlActNum)) + '-' + ltrim(str(jnlActSeq))) as [Account], jnlTranDate as [Transaction Date], "
        strSql += " jnlTranType as [Type], jnlTranAmount as Amount, jnlTranDesc as Description, jnlTranMemo as Memo, b.busName as Entity, jnlBankTranID as BankID,  jnlBankAct as [Bank Account], jnlTranBusinessID as EntityID,jnlActivityID, jnlActivity  "
        strSql += " From tblDRJournal, tblBusiness b "
        strSql += "  where jnlID =" & myID & " and jnlTranBusinessID = b.busID "
        dgvLOA.AutoGenerateColumns = False
        dgvLOA.DataSource = Nothing
        dgvLOA.Refresh()
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Try
            cn.Open()
            da = New SqlDataAdapter(strSql, cn)
            ds = New DataSet
            dt = New DataTable("Table")
            Dim bs As BindingSource = New BindingSource
            bs.DataSource = ds
            da.Fill(ds)
            dt = ds.Tables(0)
            bs.DataMember = "Table"
            If ds.Tables(0).Rows.Count > 0 Then
                dgvLOA.DataSource = bs
            Else
                MsgBox("No Journal Entries for this day", MsgBoxStyle.OkOnly, "Check Date")
            End If
        Catch ex As Exception
            MsgBox("Error in selection", MsgBoxStyle.OkOnly, "Selection Error")
        End Try

        ATMtable = dt

        If ATMtable.Rows.Count = 1 Then            'First time through set hidden variables
            hdnRowCount.Text = 1
            hdnATMOriginalAmount.Text = dgvLOA.Rows(0).Cells(5).Value 'Set amounts for allocation math
            hdnATMRemaining.Text = dgvLOA.Rows(0).Cells(5).Value                   'Set amounts for allocation math
            'hdnEntityID.Text = dgvLOA.Rows(0).Cells(8).Value
            hdnBankTranID.Text = dgvLOA.Rows(0).Cells(9).Value
            hdnBankAccount.Text = dgvLOA.Rows(0).Cells(10).Value
            hdnEntityID.Text = dgvLOA.Rows(0).Cells(11).Value
            hdnActivityID.Text = dgvLOA.Rows(0).Cells(12).Value
            Dim tstX As String = dgvLOA.Rows(0).Cells(13).Value

        End If
        If cn.State = ConnectionState.Open Then cn.Close()
    End Sub

    Private Sub btnAllocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllocate.Click
        Dim n As Integer = hdnCounter.Text
        Dim strMsg As String = "ERROR"

        Dim sngDivAmount, sngRemAmount As Single
        If IsNumeric(txtAmountToAllocate.Text) Then
            sngDivAmount = Convert.ToSingle(txtAmountToAllocate.Text)
        Else
            GoTo abnNote
        End If
        If IsNumeric(hdnATMRemaining.Text) Then  'convert amount remaining stored as value to decimal
            sngRemAmount = System.Math.Abs(Convert.ToSingle(Convert.ToSingle(dgvLOA.Rows(0).Cells(5).Value)))
        Else
            strMsg = "Error: The remaining amount of unallocated Dollars is invalid"
            GoTo abnNote
        End If
        Dim strChkAct As String
        If IsDBNull(dgvLOA.Rows(n).Cells(2).Value) Then
            strMsg = "Error: The Account Number is either missing or invalid"
            GoTo abnNote
        Else
            strChkAct = dgvLOA.Rows(n).Cells(2).Value
        End If
        If sngDivAmount <= sngRemAmount Then
            dgvLOA.Rows(0).Cells(5).Value = (sngRemAmount - sngDivAmount) '* -1   'Change original amount in first  row
            Dim dr As DataRow = ATMtable.NewRow
            dr(0) = hdnLinker.Text
            dr(1) = hdnLinker.Text & "_" & hdnCounter.Text 'The linker increments with each new row.
            dr(2) = txtActNum.Text
            dr(3) = dgvLOA.Rows(0).Cells(3).Value  'This is the date
            dr(4) = "DEP"  'Always dealing with depostits for now although ATM withdrawls at some future time
            dr(5) = txtAmountToAllocate.Text
            dr(6) = txtNewDesciption.Text
            dr(7) = txtActName.Text
            dr(8) = dgvLOA.Rows(0).Cells(8).Value
            dr(9) = hdnBankTranID.Text
            dr(10) = hdnBankAccount.Text
            dr(13) = ddlActivity.Text
            ATMtable.Rows.Add(dr)
            hdnCounter.Text = (CType(hdnCounter.Text, Integer) + 1).ToString()
        Else
            strMsg = "Error: Not enough remaining to allocate!"
            GoTo abnNote
        End If
        txtAmountToAllocate.Text = " "
        txtNewDesciption.Text = " "

        ddlActivity.SelectedIndex = 0

        Exit Sub
abnNote: MsgBox(strMsg, MsgBoxStyle.OkOnly)
    End Sub

    Sub SearchExisiting(ByVal myjnlId As Int32)
        Dim strSql As String = "select Max(CONVERT(INT,RIGHT(jnlLink,CHARINDEX('-',REVERSE(jnlLink))-1))) from tblDRJournal where left(jnlLink,4) = " & myjnlId
    End Sub

    Sub DisplayGrid()
        Dim strActType As String
        strActType = "income"  'For Deposits
        Dim strSql As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        dgvAccounts.RowCount = 1 'This clears any data out of the gird
        strSql = "select acntID, (str(actNum) + '-' + LTrim(str(actNumSeq))) as actNumJoin, actName, actDescription "
        strSql += "from tblDRCOA where actUse = 20 And left(ltrim(STR(actnum)),1) IN(4,5) "
        strSql += "order by actName, actDescription "
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim dr As SqlDataReader = oCommand.ExecuteReader()
        Dim dt As New DataTable
        Dim count As Integer = dr.FieldCount - 1
        'add rows TO GRID
        Dim n As Integer = 0
        dgvAccounts.Refresh()
        Dim aRecord As String = ""
        Dim bRecord As String = ""
        Do While dr.Read()
            Dim x As String = dr(0).ToString()
            Dim y As String = dr(1)
            Dim z As String = dr(2)
            dgvAccounts.Rows.Item(n).Cells(0).Value = x 'dr(0).ToString()
            dgvAccounts.Rows.Item(n).Cells(1).Value = y ' dr(1)  'Trim(dr.GetString(1))
            dgvAccounts.Rows.Item(n).Cells(2).Value = z 'dr(2)
            n = dgvAccounts.Rows.Add()
        Loop
        cn.Close()
    End Sub

    Private Sub DisplayActivites()
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "select  ActivityDescription,ActivityID from tblActivity order by ActivitySort "
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        DA1.Fill(DS1, "tblActivity")
        cn.Close()
        'Dim myRow As Integer = DS1.Tables(0).Rows.Count
        Dim dt As DataTable = DS1.Tables(0)
        Dim drw As DataRow = dt.NewRow()
        drw.Item(1) = 0
        drw.Item(0) = "Select Activity"
        Dim selvalue As Integer
        dt.Rows.InsertAt(drw, selvalue)
        dt.AcceptChanges()
        dt.Rows.Add()
        ddlActivity.DataSource = DS1.Tables("tblActivity") '
        ddlActivity.DisplayMember = "ActivityDescription"
        ddlActivity.ValueMember = "ActivityID"
    End Sub

    Private Sub dgvAccounts_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.RowEnter
        Dim n As Integer = Convert.ToInt32(hdnCounter.Text)
        Dim i As Integer = e.RowIndex
        Dim cell1 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(0), DataGridViewCell)
        Dim cell2 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(1), DataGridViewCell)
        Dim cell3 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(2), DataGridViewCell)
        If LoadComplete = True Then
            If cell1.Value <> Nothing Then
                hdnAccount.Text = cell3.Value.ToString().Trim
                txtActName.Text = hdnAccount.Text 'Textual Name
                txtActNum.Text = cell2.Value.ToString.Trim  'Journal Account Number
                'dgvLOA.Rows(n).Cells(2).Value = hdnAccount.Text
                'dgvLOA.Rows(n).Cells(7).Value = cell3.Value.ToString.Trim  'Memo column
            End If
            'grpNewDat.Enabled = True
        End If

    End Sub

    Private Sub dgvLOA_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvLOA.DefaultValuesNeeded
        Dim myVal As String = CType(e.Row.Cells(0).Value, String)

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Sub Clear()
        txtAmountToAllocate.Text = " "
        txtNewDesciption.Text = " "
        dgvLOA.DataSource = Nothing
        ddlActivity.SelectedIndex = 0
        hdnAccount.Text = ""
        hdnCounter.Text = "0"
        hdnATMOriginalAmount.Text = "0"
        hdnATMRemaining.Text = "0"
        hdnBankAccount.Text = ""
        hdnBankTranID.Text = "0"
        hdnEntityID.Text = "0"
        hdnLinker.Text = ""
        hdnRowCount.Text = "0"
    End Sub

    Private Sub btnStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStore.Click
        Dim strTemp As String = dgvLOA.Rows(0).Cells(1).Value
        'Update the base record which is already in the DB. with new amount and linker.
        Dim strSql As String = "update tblDRJournal set jnlLink = '" & strTemp.Trim & "', jnlTranMemo = '" & dgvLOA.Rows(0).Cells(7).Value & "', jnlTranDesc = '" & dgvLOA.Rows(0).Cells(6).Value & "', jnlTranAmount = " & dgvLOA.Rows(0).Cells(5).Value & " where jnlID =  " & hdnLinker.Text
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim intCounter As Integer = oCommand.ExecuteNonQuery()
        cn.Close()
        'Save the new Journal records
        Dim all As Integer = dgvLOA.Rows.Count
        Dim n As Integer
        cn.Open()

        'Add the new records
        For n = 1 To all - 2 'Adjust off the extra record which was auto prepared but not filled in.
            Dim strAct As String = dgvLOA.Rows(1).Cells(2).Value
              strSql = "insert into tblDRJournal (jnlLink,jnlActID,jnlActNum,jnlActSeq, jnlTranDate, jnlTranType, jnlTranAmount, jnlTranDesc, jnlTranMemo, jnlTranBusinessID, jnlBankTranID, jnlBankAct, jnlActivityID, jnlActivity) Values ("
            strSql += " '" & dgvLOA.Rows(n).Cells(1).Value & "',"    'Linker
            strSql += "0,"    'jnlActID not used
            'Split the account transaction
            Dim ary As String() = strAct.Split("-")
            strSql += " " & ary(0) & ","                                                    'Account Number
            strSql += " " & ary(1) & ","                                                    'Account Sequence
            strSql += " '" & dgvLOA.Rows(n).Cells(3).Value & "',"      'Date
            strSql += " '" & dgvLOA.Rows(n).Cells(4).Value & "',"        'TYPE
            strSql += " " & dgvLOA.Rows(n).Cells(5).Value & ","      'Amount
            strSql += " '" & dgvLOA.Rows(n).Cells(6).Value & "',"      'Description
            strSql += " '" & dgvLOA.Rows(n).Cells(7).Value & "',"      'Memo
            strSql += " " & hdnEntityID.Text & ","                                   'Entity-ID
            strSql += " " & dgvLOA.Rows(n).Cells(9).Value & ","         'Date
            strSql += " '" & dgvLOA.Rows(n).Cells(10).Value & "',"     'Bank Account
            strSql += " '" & dgvLOA.Rows(n).Cells(12).Value & "',"     'Activity ID
            strSql += " '" & dgvLOA.Rows(n).Cells(13).Value & "'"     'Activity
            strSql += ")"
            oCommand = New SqlCommand(strSql, cn)
            oCommand.ExecuteNonQuery()
        Next n
        cn.Close()
        Clear()
        ATMtable.Rows.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        baseform.Show()
    End Sub

    Function RetrieveBusNameFromBusID(ByVal busID As Int32) As String
        Dim strSql As String = "select busName from tblBusiness where  busID =  " & busID
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim strbus As String = oCommand.ExecuteScalar()
        cn.Close()
        Return strbus
    End Function

    Private Sub ddlDeposits_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlDeposits.SelectedIndexChanged
        If LoadComplete = True Then
            Dim jnlTest As String = ddlDeposits.Text
            jnlTest = ddlDeposits.SelectedValue.ToString()
            journlID = CType(ddlDeposits.SelectedValue, Int32)
            ShowData()

        End If
    End Sub

    Private Sub dgvLOA_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLOA.CellClick, dgvLOA.CellContentClick, dgvLOA.CellDoubleClick
        Dim x As Integer = e.RowIndex
        Dim y As Integer = e.ColumnIndex
        Dim myRow As DataGridViewRow = dgvLOA.Rows(x)
        If y = 5 Then
            Dim newDat As Decimal
            Dim strChange As String = myRow.Cells(5).Value
            shortEdit.changeValue = strChange
            If shortEdit.blnFirst = False Then
                If IsNumeric(strChange) Then
                    shortEdit.ShowDialog()
                    newDat = CType(shortEdit.changeValue, Decimal)
                    myRow.Cells(5).Value = newDat
                End If
            Else
                dgvLOA.Rows(0).Cells(5).Value = CType(hdnATMOriginalAmount.Text, Decimal) - newDat
                shortEdit.blnFirst = False
            End If
        End If
    End Sub
End Class
