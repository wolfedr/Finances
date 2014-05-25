Imports System.Data.SqlClient
Imports System.Configuration

Public Class AllocateDeposit
    Dim oCommand As SqlCommand
    Dim reader As SqlDataReader
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dsATM As DataSet
    Dim LoadComplete As Boolean = False
    Dim ATMtable As DataTable
    Dim intCurrentRow As Int16
    Public journlID As Integer

    Private Sub AllocateDeposit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ClearInput()
        hdnCounter.Text = 1 'set hidden count of records in split array.
        Dim tstID As Long = 1058
        FIllEntry(tstID)
        DisplayGrid()
        'FillBusinessEntity()
        DisplayActivites()
        lblInst1.Visible = True
        'lblInst3B.Visible = False
        'lblInst2.Visible = False
        'lblInst4.Visible = False
        hdnRowCount.Text = 0
        txtNewDesciption.TextAlign = HorizontalAlignment.Center
        'txtNewMemo.TextAlign = HorizontalAlignment.Center
        txtAmountToAllocate.TextAlign = HorizontalAlignment.Center
        'grpAccount.Enabled = False
        LoadComplete = True
    End Sub

    Sub FIllEntry(ByVal jnlId As Long)
        Dim strSql As String = "Select jnlID, a.jnlTranType, b.busName, a.jnlTranAmount, a.jnlTranDate from tblDRJournal a, tblBusiness b "
        strSql += "Where a.jnlTranBusinessID = b.busID and  a.jnlID = " & jnlId
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        Try
            cn.Open()
            da = New SqlDataAdapter(strSql, cn)
            dsATM = New DataSet
            da.Fill(dsATM)
            If dsATM.Tables(0).Rows.Count > 0 Then
                dgvEntries.DataSource = dsATM.Tables(0)
            Else
                MsgBox("No Journal Entries for this Category", MsgBoxStyle.OkOnly, "Check Date")
            End If
        Catch ex As Exception
            MsgBox("Error in selection", MsgBoxStyle.OkOnly, "Selection Error")
        End Try
        lblInst1.Visible = True
    End Sub

    Private Sub dgvEntries_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEntries.CellContentClick
        Dim i As Integer = e.ColumnIndex
        If i <> 0 Then Exit Sub 'make sure user selected the first column with the  j ournal ID in it.
        Dim J As Integer = e.RowIndex
        Dim id As Long = dgvEntries.Rows(J).Cells(i).Value

        If LoadComplete = True Then
            hdnLinker.Text = id.ToString()
            FillAllocateView(id)  'This creates the main datagrid of journal entries.
            Dim intRowCnt As Integer = Convert.ToInt32(hdnRowCount.Text)
            'hdnCounter.Text = (Convert.ToSingle(hdnCounter.Text) + 1).ToString()
            'Add next row of data to main datagrid
            Dim dr As DataRow = ATMtable.NewRow
            dr(0) = hdnLinker.Text
            SearchExisiting(dr(0))
            dr(1) = hdnLinker.Text & "_" & hdnCounter.Text
            dr(3) = dgvLOA.Rows(0).Cells(3).Value
            dr(4) = "Cash"
            dr(9) = hdnBankTranID.Text
            dr(10) = hdnBankAccount.Text
            ATMtable.Rows.Add(dr)
            'Change enabled and viewable screen objects
            dgvLOA.Visible = True 'Show new record and edited atm record for journal we are preparing
            'lblInst1.Visible = False
            'lblInst2.Visible = True
            'lblInst3A.Visible = True
            'lblInst3B.Visible = True
            dgvLOA.Rows(1).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleRight
            ' grpAccount.Enabled = True
            ' grpATMTransaction.Enabled = False
            'grpNewDat.Enabled = True  'This changed 10/18/ to allows selecting account with business if business exists in database.
            'lblInst2.Visible = False

        End If
    End Sub
    Sub SearchExisiting(ByVal myjnlId As Int32)
        Dim strSql As String = "select Max(CONVERT(INT,RIGHT(jnlLink,CHARINDEX('-',REVERSE(jnlLink))-1))) from tblDRJournal where left(jnlLink,4) = " & myjnlId



    End Sub

    Sub DisplayGrid()
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


JUMP:   Loop
        cn.Close()
    End Sub

    'Sub FillBusinessEntity()
    '    Dim lst As New List(Of String)
    '    'AutoComplete collection that will help to filter keep the records.
    '    Dim MySource As New AutoCompleteStringCollection
    '    Dim strSql As String = "select busID, busName, busLeftName, busSiblingID, taggedAccount from tblBusiness where busSiblingID in (1,0) order by busname"
    '    cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
    '    oCommand = New SqlCommand(strSql, cn)
    '    cn.Open()
    '    reader = oCommand.ExecuteReader()
    '    Dim lt, mt, rt As Integer
    '    Dim strCenter As String
    '    Dim aryBusiness As ArrayList = New ArrayList
    '    aryBusiness.Add(New AddValue("Select from List", 0))
    '    While reader.Read()
    '        lst.Add(reader.GetString(1))
    '        Dim x As String = reader.GetString(2)
    '        Dim y As String = reader.GetInt64(0)
    '        lt = Len(x)
    '        mt = 30 - lt
    '        rt = mt / 2
    '        strCenter = Space(rt) & x

    '        aryBusiness.Add(New AddValue(reader.GetString(2) & "-" & Convert.ToString(reader.GetInt64(0)), Convert.ToInt64(reader.GetInt64(0))))
    '    End While
    '    reader.Close()
    '    cn.Close()
    '    ddlEntity.DisplayMember = "Display"
    '    ddlEntity.ValueMember = "Value"
    '    ddlEntity.DataSource = aryBusiness
    '    MySource.AddRange(lst.ToArray)
    '    'this AutocompleteStringcollection bound to the textbox as custom
    '    'source.
    '    ddlEntity.AutoCompleteCustomSource = MySource
    '    'Auto complete mode set to suggest append so that it will sugesst one
    '    'or more suggested completion strings it has bith ‘Suggest’ and
    '    '‘Append’ functionality
    '    ddlEntity.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '    'Set to Custom source we have filled already
    '    ddlEntity.AutoCompleteSource = AutoCompleteSource.CustomSource
    '    'ddlBusiness.Visible = False
    'End Sub


    Private Sub DisplayActivites()
        ' populates  dropdown of available Activites
        'Fill Actity Dropdown
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "select  ActivityDescription,ActivitySort from tblActivity order by ActivitySort "
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        DA1.Fill(DS1, "tblActivity")
        Dim myRow As Integer = DS1.Tables(0).Rows.Count
        Dim dt As DataTable = DS1.Tables(0)
        dt.Rows.Add()
        ddlActivity.DataSource = DS1.Tables("tblActivity")
        ddlActivity.DisplayMember = "ActivityDescription"
        ddlActivity.ValueMember = "ActivitySort"
        cn.Close()
    End Sub

    Private Sub dgvAccounts_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.RowEnter
        Dim n As Integer = Convert.ToInt32(hdnCounter.Text)
        Dim i As Integer = e.RowIndex
        Dim cell1 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(0), DataGridViewCell)
        Dim cell2 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(1), DataGridViewCell)
        Dim cell3 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(2), DataGridViewCell)
        If LoadComplete = True Then
            If cell1.Value <> Nothing Then
                hdnAccount.Text = cell2.Value.ToString().Trim
                dgvLOA.Rows(n).Cells(2).Value = hdnAccount.Text
                'grpNewDat.Enabled = True
                'lblInst2.Visible = False
                'lblInst3.Visible = True
                'txtAccountNum.Text = cell1.Value.ToString().Trim
                'txtAccountname.Text = cell2.Value.ToString().Trim
                'hdnActID.Text = cell0.Value.ToString().Trim
            End If
            grpNewDat.Enabled = True
        End If

    End Sub

    Sub FillAllocateView(ByVal myID As Int64)
        Dim strSql As String = "select jnlID as ID, (case jnlTranType when'ATM' Then str(jnlID) + '_0' ELSE jnlLink end) as Linker,  (ltrim(str(jnlActNum)) + '-' + ltrim(str(jnlActSeq))) as [Account], jnlTranDate as [Transaction Date], "
        strSql += " jnlTranType as [Type], jnlTranAmount as Amount, jnlTranDesc as Description, jnlTranMemo as Memo, b.busName as Entity, jnlBankTranID as BankID,  jnlBankAct as [Bank Account], jnlTranBusinessID as EntityID "
        strSql += " From tblDRJournal, tblBusiness b "
        strSql += "  where jnlID =" & myID & " and jnlTranBusinessID = b.busID "
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Try
            cn.Open()
            da = New SqlDataAdapter(strSql, cn)
            ds = New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                dgvLOA.DataSource = ds.Tables(0)
            Else
                MsgBox("No Journal Entries for this day", MsgBoxStyle.OkOnly, "Check Date")
            End If
        Catch ex As Exception
            MsgBox("Error in selection", MsgBoxStyle.OkOnly, "Selection Error")
        End Try
        ATMtable = ds.Tables(0)
        If ATMtable.Rows.Count = 1 Then            'First time through
            hdnRowCount.Text = 1
            hdnATMOriginalAmount.Text = dgvLOA.Rows(0).Cells(5).Value 'Set amounts for allocation math
            hdnATMRemaining.Text = dgvLOA.Rows(0).Cells(5).Value                   'Set amounts for allocation math
            hdnBankTranID.Text = dgvLOA.Rows(0).Cells(9).Value
            hdnBankAccount.Text = dgvLOA.Rows(0).Cells(10).Value
            hdnEntityID.Text = dgvLOA.Rows(0).Cells(11).Value
        End If
        If cn.State = ConnectionState.Open Then cn.Close()

    End Sub

    Private Sub dgvLOA_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvLOA.DefaultValuesNeeded
        Dim myVal As String = CType(e.Row.Cells(0).Value, String)
        'e.Row.Cells(0).Value = hdnLinker.Text
        'e.Row.Cells(1).Value = hdnLinker.Text & "_" & hdnCounter.Text
        'e.Row.Cells(2).Value = hdnAccount.Text        'account
        'e.Row.Cells(3).Value = Today.ToShortDateString           'date

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear()
        '  If dsATM.IsInitialized Then
        'dsATM.Tables(0).Clear()
        'End If
        ' If ds.Tables(0).IsInitialized Then
        'ds.Tables(0).Clear()
        ' End If
        'illAllocateView()
        'txtAmountToAllocate.Text = " "
        'txtNewDesciption.Text = " "
        'txtNewMemo.Text = " "

    End Sub
    Sub Clear()
        txtAmountToAllocate.Text = " "
        txtNewDesciption.Text = " "
        'txtNewMemo.Text = " "
        'ddlEntity.SelectedIndex = 0
        lblInst1.Visible = True
        'lblInst2.Visible = False
        'lblInst3A.Visible = False
        'lblInst3B.Visible = False
        'grpAccount.Enabled = False
        'grpNewDat.Enabled = False
        ' grpATMTransaction.Enabled = True
        FIllEntry(1058)
        dgvLOA.DataSource = Nothing
        ddlActivity.SelectedIndex = 0

    End Sub

    Private Sub btnAllocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllocate.Click
        Dim n As Integer = hdnCounter.Text
        Dim strMsg As String = "ERROR"
        If btnAllocate.Text = "Allocate" Then
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
            If sngDivAmount > 0 Then 'If an amount is available to allocate
                If sngDivAmount < sngRemAmount Then 'If it is less than the amount availabe
                    dgvLOA.Rows(n).Cells(2).Value = strChkAct
                    dgvLOA.Rows(0).Cells(5).Value = (sngRemAmount - sngDivAmount) * -1   'Change prior amount
                    dgvLOA.Rows(n).Cells(5).Value = sngDivAmount * -1  'Insert new amount
                    dgvLOA.Rows(0).Cells(5).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvLOA.Rows(n).Cells(6).Value = txtNewDesciption.Text
                    dgvLOA.Rows(n).Cells(7).Value = ddlentity.Text
                    dgvLOA.Rows(n).Cells(8).Value = ddlActivity.Text
                    If ddlActivity.SelectedValue = Nothing Then
                        dgvLOA.Rows(n).Cells(11).Value = 0
                        dgvLOA.Rows(n).Cells(8).Value = "Unlisted"
                    Else
                        dgvLOA.Rows(n).Cells(8).Value = ddlActivity.Text
                        dgvLOA.Rows(n).Cells(11).Value = ddlActivity.SelectedValue
                        '  dgvLOA.Rows(n).Cells(2).Value = RetrieveAccountFromBusID(ddlEntity.SelectedValue) 'moved to event
                    End If
                    hdnEntityID.Text = ddlActivity.SelectedValue

                Else
                    strMsg = "Error: Not enough remaining to allocate!"
                    GoTo abnNote
                End If
            Else
                strMsg = "Error: No Funds to allocate!"
                GoTo abnNote
            End If
            ' increment  hidden counter for next record line.
            'dgvLOA.Rows.Add()
            'btnAllocate.Text = "Add Another"
            'lblAllocate.Text = "Insert New Row"
        Else   'This means the record was allocated and the user has chosen to add another row
            hdnCounter.Text = n + 1
            Dim dr As DataRow = ATMtable.NewRow
            dr(0) = hdnLinker.Text
            dr(1) = hdnLinker.Text & "_" & hdnCounter.Text
            dr(3) = dgvLOA.Rows(0).Cells(3).Value
            dr(4) = "Cash"
            dr(9) = hdnBankTranID.Text
            dr(10) = hdnBankAccount.Text
            ATMtable.Rows.Add(dr)
            dgvLOA.Rows(n).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleRight
            btnAllocate.Text = "Allocate"
            txtAmountToAllocate.Text = " "
            txtNewDesciption.Text = " "

            ddlActivity.SelectedIndex = 0
        End If


        Exit Sub
abnNote: MsgBox(strMsg, MsgBoxStyle.OkOnly)
    End Sub

    Private Sub btnStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStore.Click
        Dim strTemp As String = dgvLOA.Rows(0).Cells(1).Value
        Dim strSql As String = "update tblDRJournal set jnlLink = '" & strTemp.Trim & "', jnlTranAmount = " & dgvLOA.Rows(0).Cells(5).Value & " where jnlID =  " & hdnLinker.Text
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim intCounter As Integer = oCommand.ExecuteNonQuery()
        cn.Close()
        'Save the new Journal records
        Dim all As Integer = hdnCounter.Text
        Dim n As Integer
        cn.Open()
        For n = 1 To all
            Dim strAct As String = dgvLOA.Rows(1).Cells(2).Value
            Dim strBus As String = dgvLOA.Rows(1).Cells(11).Value
            'strBus = strBus.Substring(strBus.LastIndexOf("-"), strBus.Length)
            Dim ary As String() = strAct.Split("-")
            'Dim aryBus As String() = strBus.Split("-")
            strSql = "insert into tblDRJournal (jnlLink,jnlActID,jnlActNum,jnlActSeq, jnlTranDate, jnlTranType, jnlTranAmount, jnlTranDesc, jnlTranMemo, jnlTranBusinessID, jnlBankTranID, jnlBankAct) Values ("
            strSql += " '" & dgvLOA.Rows(n).Cells(1).Value & "',"    'Linker
            strSql += "0,"    'jnlActID not used
            'Split the account transaction
            strSql += " " & ary(0) & ","                                                    'Account Number
            strSql += " " & ary(1) & ","                                                    'Account Sequence
            strSql += " '" & dgvLOA.Rows(n).Cells(3).Value & "',"      'Date
            strSql += " '" & dgvLOA.Rows(n).Cells(4).Value & "',"        'TYPE
            strSql += " " & dgvLOA.Rows(n).Cells(5).Value & ","      'Amount
            strSql += " '" & dgvLOA.Rows(n).Cells(6).Value & "',"      'Description
            strSql += " '" & dgvLOA.Rows(n).Cells(7).Value & "',"      'Memo
            strSql += " " & dgvLOA.Rows(n).Cells(11).Value & ","                                   'Entity-ID
            strSql += " " & dgvLOA.Rows(n).Cells(9).Value & ","         'Date
            strSql += " '" & dgvLOA.Rows(n).Cells(10).Value & "'"     'Bank Account
            strSql += ")"
            oCommand = New SqlCommand(strSql, cn)
            oCommand.ExecuteNonQuery()

        Next n
        cn.Close()
        Clear()
        ATMtable.Rows.Clear()



        lblInst1.Visible = True
        'lblInst2.Visible = False
        'lblInst3A.Visible = False
        'lblInst3B.Visible = False
        'grpAccount.Enabled = False
        'grpNewDat.Enabled = False
        'grpATMTransaction.Enabled = True
        'FIllATMEntries()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        baseform.Show()

    End Sub

    Private Sub ddlEntity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlActivity.SelectedIndexChanged
        If LoadComplete = True Then
            If ddlActivity.SelectedValue > 0 Then
                Dim n As Integer = hdnCounter.Text
                dgvLOA.Rows(n).Cells(2).Value = RetrieveAccountFromBusID(ddlActivity.SelectedValue)
                dgvLOA.Rows(n).Cells(8).Value = RetrieveBusNameFromBusID(ddlActivity.SelectedValue)
            End If
        End If
    End Sub
    Function RetrieveAccountFromBusID(ByVal busID As Int32) As String
        Dim strSql As String = "select (ltrim(str(b.actNum)) + '-' + ltrim(str(b.actNumSeq))) as Account from tblBusiness a, tblDRCOA b where b.acntID = a.taggedAccount and  busID =  " & busID
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim strAct As String = oCommand.ExecuteScalar()
        cn.Close()
        Return strAct
    End Function
    Function RetrieveBusNameFromBusID(ByVal busID As Int32) As String
        Dim strSql As String = "select busName from tblBusiness where  busID =  " & busID
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim strbus As String = oCommand.ExecuteScalar()
        cn.Close()
        Return strbus
    End Function

    
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub dgvAccounts_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.CellContentClick
        Dim x As String = "5"
    End Sub
End Class
