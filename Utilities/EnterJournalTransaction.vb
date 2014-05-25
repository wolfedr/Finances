Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.VisualBasic

Public Class EnterJournalTransaction
    Dim oCommand As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim reader As SqlDataReader
    Dim cn As SqlConnection
    Dim LoadComplete As Boolean = False

    Private upcount As Integer
    Private Sub EnterJournalTransaction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '************ FIll business combo box ****************************
        Dim strSql As String = "select max(busID),  busName as busID from tblBusiness group by busName order by busName"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        reader = oCommand.ExecuteReader()
        Dim aryBusiness As ArrayList = New ArrayList
        aryBusiness.Add(New AddValue("Select Business", "0"))
        While reader.Read()
            Dim x As String = reader.GetString(1)
            Dim y As String = reader.GetInt64(0)
            aryBusiness.Add(New AddValue(reader.GetString(1), Convert.ToInt64(reader.GetInt64(0))))
        End While
        reader.Close()
        cmbBusiness.DisplayMember = "Display"
        cmbBusiness.ValueMember = "Value"
        cmbBusiness.DataSource = aryBusiness
        '***************** Fill Bank Account combo box
        strSql = "select actNum, actName, actBank from tblBankAcct where actStatus = 'A' order by actName"
        oCommand = New SqlCommand(strSql, cn)
        'cn.Open()
        reader = oCommand.ExecuteReader()
        Dim aryBankAccount As ArrayList = New ArrayList
        aryBankAccount.Add(New AddValue("Select Bank Account", "0"))
        aryBankAccount.Add(New AddValue("CASH(Bank Not Needed)", "1"))
        While reader.Read()
            Dim x As String = reader.GetString(1).Trim.ToUpper
            Dim y As String = reader.GetString(1)
            aryBankAccount.Add(New AddValue(x, Convert.ToInt64(reader.GetInt64(0))))
        End While
        reader.Close()
        cmbBankAct.DisplayMember = "Display"
        cmbBankAct.ValueMember = "Value"
        cmbBankAct.DataSource = aryBankAccount

        '***************** Fill Transaction Type combo box
        strSql = "select typename + ':' + typeDescription as typeDescription, typeName from tblTransactionTypes order by typeDescription"
        oCommand = New SqlCommand(strSql, cn)
        reader = oCommand.ExecuteReader()
        Dim aryTranType As ArrayList = New ArrayList
        'Dim strAntiRepeat As String
        reader.Read()
        'strAntiRepeat = reader.GetString(1)
        aryTranType.Add(New MyListItem("Select Transaction Type", "0"))
        aryTranType.Add(New MyListItem(reader.GetString(1), reader.GetString(0)))
        While reader.Read()
            'If reader.GetString(1) <> strAntiRepeat Then
            aryTranType.Add(New MyListItem(reader.GetString(0), reader.GetString(1)))
            ' strAntiRepeat = reader.GetString(1)
            'End If
        End While
        cmbTranType.DisplayMember = "DisplayItem"
        cmbTranType.ValueMember = "ValueItem"
        cmbTranType.DataSource = aryTranType
        cn.Close()
        DisplayActivites()
        GetEntries("ALL")
        DisplayGrid()
        LoadComplete = True
    End Sub

    Sub GetEntries(ByVal strRange As String)
        'strRange = strMyRange
        upcount = 0
        Dim dteMydate As DateTime = Now() ' dtpJournal.Value
        dteMydate = dteMydate.ToShortDateString
        Dim StrSql As String = "Select coalesce(jnlLink,'0'), Convert(varchar(30), a.jnlTranDate, 101)  + ' : $'  + CONVERT(varchar, CONVERT(money, a.jnlTranAmount), 1) + ' : ' + substring(coalesce(b.busname,'NO BUSINESS ID' + str(a.jnlTranBusinessID)),0,30) + ' (' + ltrim(str(jnlID))  + ')'    as jnlEntry,"
        StrSql += "jnlID from tblDRJournal a  left outer join  tblBusiness b on  a.jnlTranBusinessID = b.BusID where a.jnlActive = 1 order by a.jnlTranDate Desc "
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        Try
            cn.Open()
            'dr = oCommand.ExecuteReader
            da = New SqlDataAdapter(strSql, cn)
            ds = New DataSet

            da.Fill(ds, "tblDRJournal")
            Dim myRow As Integer = ds.Tables("tblDRJournal").Rows.Count
            Dim dt As DataTable = ds.Tables("tblDRJournal")
            dt.Rows.Add()
            cmbTransaction.DataSource = ds.Tables("tblDRJournal")
            cmbTransaction.DisplayMember = "jnlEntry"
            cmbTransaction.ValueMember = "jnlID"
        Catch ex As Exception
            MsgBox("Error in selection:" & Err.Description, MsgBoxStyle.OkOnly, "Selection Error")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub DisplayActivites()
        ' populates  dropdown of available Activites
        Dim DS1 As DataSet
        Dim DA1 As SqlDataAdapter
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "select ActivityID, ActivityDescription from tblActivity order by ActivitySort "
        DS1 = New DataSet
        DA1 = New SqlDataAdapter(strSql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        DA1.Fill(DS1, "tblActivity")
        Dim myRow As Integer = DS1.Tables(0).Rows.Count
        Dim dt As DataTable = DS1.Tables(0)
        dt.Rows.Add()
        cmbActivity.DataSource = DS1.Tables("tblActivity")
        cmbActivity.DisplayMember = "activityDescription"
        cmbActivity.ValueMember = "activityID"
        cn.Close()
    End Sub

    Sub DisplayGrid()
        Dim strActType As String = ""
        If rbExpense.Checked = True Then
            strActType = "expense"
        ElseIf rbRevenue.Checked = True Then
            strActType = "income"
        ElseIf rbAsset.Checked = True Then
            strActType = "asset"
        ElseIf rbLiability.Checked = True Then
            strActType = "liability"
        End If
        Dim strSql As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        dgvAccounts.RowCount = 1 'This clears any data out of the gird
        strSql = "select acntID, (str(actNum) + '-' + LTrim(str(actNumSeq))) as actNumJoin, actName, actDescription "
        strSql += "from tblDRCOA where actUse = 20" & " And actTypeName = '" & strActType & "' "
        strSql += "order by actNum, actDescription "
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
            aRecord = Trim(dr(2).ToString())
            If aRecord <> bRecord Then

                bRecord = aRecord
                dgvAccounts.Rows.Item(n).Cells(0).Value = dr(2).ToString()
                dgvAccounts.Rows.Item(n).Cells(1).Value = 0
                dgvAccounts.Rows.Item(n).Cells(2).Value = 0
                Me.dgvAccounts.Rows(n).Cells(0).Style.BackColor = Color.Cyan
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.dgvAccounts.Rows(n).Cells(0).Style.Font = New Font("calibri", 14, FontStyle.Bold)
                n = dgvAccounts.Rows.Add()
                'GoTo JUMP
                dgvAccounts.Rows.Item(n).Cells(0).Value = Trim(dr.GetString(3))
                dgvAccounts.Rows.Item(n).Cells(1).Value = Trim(dr.GetString(1))
                dgvAccounts.Rows.Item(n).Cells(3).Value = Convert.ToInt32(dr(0))
                n = dgvAccounts.Rows.Add()
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            Else
                dgvAccounts.Rows.Item(n).Cells(0).Value = Trim(dr.GetString(3))
                dgvAccounts.Rows.Item(n).Cells(1).Value = Trim(dr.GetString(1))
                dgvAccounts.Rows.Item(n).Cells(3).Value = Convert.ToInt32(dr(0))
                n = dgvAccounts.Rows.Add()
                Me.dgvAccounts.Rows(n).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            End If
            'Exit Sub
JUMP:   Loop
        cn.Close()
    End Sub
    Sub ClearForm()
        txtActName.Text = ""
        txtActSeq.Text = ""
        txtActnum.Text = ""
        txtAmount.Text = ""
        txtDescription.Text = ""
        txtMemo.Text = ""
        cmbBankAct.SelectedIndex = 0
        cmbBusiness.SelectedIndex = 0
        cmbTranType.SelectedIndex = 0
        cmbActivity.SelectedIndex = 0
        cmbTransaction.SelectedIndex = 0
    End Sub
    Function displayMessage(ByVal strMessage As String, ByVal intCode As Int16) As Int16
        Dim Result As DialogResult

        Result = MessageBox.Show(strMessage, "Error Check", MessageBoxButtons.OK)
        If Result = Windows.Forms.DialogResult.OK Then
            Return 0
        End If
        Return 0

    End Function

    Private Sub rbAsset_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAsset.CheckedChanged
        If LoadComplete = True Then
            DisplayGrid()
        End If
    End Sub
    Private Sub rbExpense_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbExpense.CheckedChanged
        If LoadComplete = True Then
            DisplayGrid()
        End If
    End Sub
    Private Sub dgvAccounts_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.RowEnter
        Dim i As Integer = e.RowIndex
        Dim cell1 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(1), DataGridViewCell)
        Dim cell2 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(0), DataGridViewCell)
        Dim cell3 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(3), DataGridViewCell)
        If LoadComplete = True Then
            If cell1.Value <> Nothing Then

                txtActnum.Text = Microsoft.VisualBasic.Left(cell1.Value.ToString().Trim, 4)
                If Len(cell1.Value.ToString().Trim) > 6 Then
                    txtActSeq.Text = Microsoft.VisualBasic.Right(cell1.Value.ToString().Trim, 2)
                Else
                    txtActSeq.Text = Microsoft.VisualBasic.Right(cell1.Value.ToString().Trim, 1)
                End If
                txtActName.Text = cell2.Value.ToString().Trim
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strEnter As String
        'Check that selections have been made on all combo boxes
        If cmbBankAct.SelectedIndex = 0 Then
            Dim myAnswer As Int16 = displayMessage("You must select a Bank Account for this transaction!", 1)
            If myAnswer = 0 Then Exit Sub
        End If
        If cmbBusiness.SelectedIndex = 0 Then
            Dim myAnswer As Int16 = displayMessage("You must select a Business for this transaction!", 1)
            If myAnswer = 0 Then Exit Sub
        End If
        If cmbActivity.SelectedIndex = 0 Then
            Dim myAnswer As Int16 = displayMessage("You must select an Activity for this transaction!", 1)
            If myAnswer = 0 Then Exit Sub
        End If
        If cmbTranType.SelectedIndex = 0 Then
            Dim myAnswer As Int16 = displayMessage("You must select a Transaction type for this transaction!", 1)
            If myAnswer = 0 Then Exit Sub
        End If
        'Check the amount to see if it's numeric
        If Not IsNumeric(txtAmount.Text) Then
            Dim myAnswer As Int16 = displayMessage("You entered a value for the amount that the application does not recognize as a number!", 1)
            If myAnswer = 0 Then Exit Sub
        End If
        'Make sure an complete account number is entered
        If Len(txtActnum.Text.Trim) = 0 Or Len(txtActSeq.Text.Trim) = 0 Then
            Dim myAnswer As Int16 = displayMessage("You have  not selected an acount number. !", 1)
            If myAnswer = 0 Then Exit Sub
        End If

        If pnlEdit.Enabled = False Then  'Add a new journal entry
            'Build query to insert new transaction into journal
            Dim strSql As String = "Insert into tblDRJournal"
            strSql += "(jnlLink, jnlActID,jnlActNum,jnlActSeq,jnlTranDate,jnlTranType,jnlTranAmount, jnlTranDesc, jnlTranMemo,jnlTranBusinessID, jnlBankTranID,jnlActivityID, jnlActivity, jnlBankAct, jnlHaveReceipt, timestamp"
            strSql += ") Values ("
            strSql += "'0',0,"
            strSql += txtActnum.Text & ","
            strSql += txtActSeq.Text & ","
            'myDate = Convert.ToDateTime(dteJnlTranDate.Text)
            strSql += "'" & dteJnlTranDate.Value & "',"
            strSql += "'" & cmbTranType.SelectedValue & "',"
            strSql += txtAmount.Text & ","
            strEnter = txtDescription.Text.Replace("'", "")
            strSql += "'" & strEnter & "',"
            strEnter = txtMemo.Text.Replace("'", "")
            strSql += "'" & strEnter & "',"
            strSql += cmbBusiness.SelectedValue & ", 0, "
            strSql += cmbActivity.SelectedValue & ", '"
            strSql += cmbActivity.Text & "', "
            strSql += cmbBankAct.SelectedValue.ToString() & ", '"
            strSql += chkHaveReceipt.CheckState & "', "
            strSql += "'" & Now() & "'"
            strSql += ")"
            cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
            Try
                oCommand = New SqlCommand(strSql, cn)
                cn.Open()
                Dim res As Object = oCommand.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error saving data!" & ex.Message, "Information", MessageBoxButtons.OK)
                Exit Sub
            Finally
                cn.Close()
            End Try
            If chkRepeat.Checked = False Then
                ClearForm()
            Else
                'Clear only non repeating fields
                txtAmount.Text = ""
                txtDescription.Text = ""
                txtMemo.Text = ""
            End If
        Else    'Edit a Journal Entry
            'Build query to update existing transaction in journal
            Dim strSql As String = "Update tblDRJournal "
            strSql += "set jnlActNum = " & txtActnum.Text & ", "
            strSql += "jnlActSeq = " & txtActSeq.Text & ", "
            strSql += "jnlTranDate = '" & dteJnlTranDate.Value & "', "
            strSql += "jnlHaveReceipt = '" & chkHaveReceipt.CheckState & "'"


            strSql += " Where jnlID = " & lblJnlID.Text
            Try
                oCommand = New SqlCommand(strSql, cn)
                cn.Open()
                Dim res As Object = oCommand.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error saving data!" & ex.Message, "Information", MessageBoxButtons.OK)
                Exit Sub
            Finally
                cn.Close()
            End Try

        End If
        If chkRepeat.Checked = True Then
            txtAmount.Text = ""
            txtDescription.Text = ""
            txtMemo.Text = ""
        Else
            
            ClearForm()
        End If

        pnlEdit.Enabled = False
    End Sub

    Private Sub cmbBusiness_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBusiness.SelectedIndexChanged
        Dim strSql As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        strSql = "select taggedaccount from tblBusiness where busID = " & cmbBusiness.SelectedValue
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim tagAccount As Integer = oCommand.ExecuteScalar()
        If tagAccount > 0 Then
            strSql = "Select ActNum, actNumSeq, actDescription from tblDRCOA where acntID = " & tagAccount
            oCommand = New SqlCommand(strSql, cn)
            dr = oCommand.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                txtActnum.Text = dr(0)
                txtActSeq.Text = dr(1)
                txtActName.Text = dr(2)
            End If
            dr.Close()
            cn.Close()
        End If

    End Sub

    Private Sub grpDisplay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grpDisplay.KeyPress

    End Sub

    'Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
    Private Sub GetData()
        On Error GoTo Err_Handler
        Dim strSql As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim cn2 As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)

        'Get the journal id which is a number at the end of the string enclosed in parenthesis
        'Dim x1 As String = cmbTransaction.SelectedValue.ToString()
        'Dim x2 As String = cmbTransaction.Text
        'Dim strJnlDate As String = cmbTransaction.SelectedValue.ToString.Substring(0, 10)
        'Dim intST As Integer = cmbTransaction.SelectedValue.ToString.LastIndexOf("(") + 1
        'Dim intED As Integer = cmbTransaction.SelectedValue.ToString.LastIndexOf(")")
        'Dim intLN As Integer = intED - intST
        'Dim strJnl As String = cmbTransaction.SelectedValue.ToString.Substring(intST, intLN)
        Dim strJnlDate As String = cmbTransaction.Text.Substring(0, 10)
        Dim intST As Integer = cmbTransaction.Text.LastIndexOf("(") + 1
        Dim intED As Integer = cmbTransaction.Text.LastIndexOf(")")
        Dim intLN As Integer = intED - intST
        Dim strJnl As String = cmbTransaction.SelectedValue.ToString()
        strSql = "select * from tblDRJournal where jnlID = " & strJnl
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            lblJnlID.Text = dr("jnlID").ToString()
            txtActnum.Text = dr("jnlActNum").ToString()
            txtActSeq.Text = dr("jnlActSeq").ToString()
            dteJnlTranDate.Value = dr("jnlTranDate")
            txtDescription.Text = dr("jnlTranDesc")

            If dr("jnlHaveReceipt") = 0 Then
                chkHaveReceipt.Checked = False
            Else
                chkHaveReceipt.Checked = True
            End If
            txtMemo.Text = dr("jnlTranMemo")
            txtAmount.Text = dr.GetDecimal(dr.GetOrdinal("jnlTranAmount")).ToString("C")
            Dim x As String = dr("jnlTranType")
            If dr("jnlTranType").ToString.Substring(0, 3) = "CHE" Then
                cmbTranType.SelectedValue = "CHECK"
            Else
                cmbTranType.SelectedValue = dr("jnlTranType").ToString()
            End If
            Dim index As Integer
            Dim strSql2 As String
            Dim myY As String
            Dim xcommand As SqlCommand
            'Get Activity
            index = cmbActivity.FindString(dr("jnlActivity"))
            cmbActivity.SelectedIndex = index
            'Get BAnk

            strSql2 = "Select actName from tblBankAcct where actNum = " & dr("jnlBankAct").ToString()
            cn2.Open()
            xcommand = New SqlCommand(strSql2, cn2)
            myY = xcommand.ExecuteScalar()
            cn2.Close()
            index = cmbBankAct.FindString(myY)
            cmbBankAct.SelectedIndex = index

            index = 0
            'Get Business
            strSql2 = "Select busName from tblBusiness where busID = " & dr("jnlTranBusinessID")
            cn2.Open()
            xcommand = New SqlCommand(strSql2, cn2)
            myY = xcommand.ExecuteScalar()
            cn2.Close()
            If Not Nothing Then
                index = cmbBusiness.FindString(myY)
            Else
                index = 0
            End If
            cmbBusiness.SelectedIndex = index
        Else
            MessageBox.Show("No Data Returned!", "Information", MessageBoxButtons.OK)
        End If
        dr.Close()
        cn.Close()
Normal_Exit:
        Exit Sub
Err_Handler:
        MsgBox("An Error Occurred! Contact developer if it persists or repeats. Error:" & Err.Description, MsgBoxStyle.OkOnly, "Error Handler")
        Resume Normal_Exit

    End Sub


    Private Sub cmbTransaction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTransaction.SelectedIndexChanged
        If LoadComplete = True Then
            GetData()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If pnlEdit.Enabled = False Then
            pnlEdit.Enabled = True
            btnDistribute.Enabled = True
            GetData()
        Else
            pnlEdit.Enabled = False
            ClearForm()
        End If

    End Sub

    Private Sub cmbTranType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTranType.SelectedIndexChanged
        If LoadComplete = True Then
            Dim x As String = cmbTranType.SelectedValue.ToString.Trim()
            If cmbTranType.SelectedValue.ToString.Trim = "CASH" Then
                cmbBankAct.SelectedIndex = 1
            Else
                cmbBankAct.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnDistribute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistribute.Click

        Dim myDRV As DataRowView = CType(cmbTransaction.SelectedItem, DataRowView)
        Dim myVal As String = myDRV(0)
        If myVal.Length > 1 Then  'This means a link has been assigned
            If myVal.EndsWith("0") Then  'This means the linke is a base link and ok to user
                Distribute.StartAccountID = lblJnlID.Text
                Distribute.ShowDialog()
            Else  'This means the link is a secondary one and can not be distributed since it is a distribution itself.
                MessageBox.Show("This entry is a distribution itself and cannot be distributed!", "ERROR", MessageBoxButtons.OK)
                Exit Sub
            End If
        Else
            Distribute.StartAccountID = lblJnlID.Text
            Distribute.ShowDialog()
        End If







    End Sub


    Private Sub cmbTransaction_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cmbTransaction.DrawItem
        'Exit Sub
        On Error GoTo ERRORS
        e.DrawBackground()

        ' Define the default color of the brush as black.
        Dim myBrush As Brush = Brushes.Black
        ' Determine the color of the brush to draw each item based on   
        ' the index of the item to draw.
        Dim dr As DataRowView = CType(cmbTransaction.Items.Item(e.Index), DataRowView)
        Dim strLink As String
        Dim strText As String
        If IsNothing(dr) Then Exit Sub
        strLink = dr(0)
        strText = dr(1)
        myBrush = Brushes.Black
        upcount += 1
        If strLink.Length > 1 Then
            If strLink.Substring(strLink.IndexOf("_") + 1, 1) = "0" Then
                If strLink.EndsWith("0") Then
                    myBrush = Brushes.Blue
                End If
            End If
        Else
            myBrush = Brushes.Blue
        End If
        strText = dr(1)
        'End If

        ' Draw the current item text based on the current 
        ' Font and the custom brush settings.
        e.Graphics.DrawString(strText, e.Font, myBrush, e.Bounds, StringFormat.GenericDefault)
        ' If the ListBox has focus, draw a focus rectangle around  _ 
        ' the selected item.
        e.DrawFocusRectangle()
ERRORS:
        Exit Sub

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim myForm As Main
        myForm = New Main
        Me.Close()
        myForm.Show()
    End Sub

    
    Private Sub btnSave_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles btnSave.ControlAdded

    End Sub
End Class
