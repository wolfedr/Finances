Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.VisualBasic
Public Class AllocateCash
    Dim oCommand As SqlCommand
    Dim reader As SqlDataReader
    Dim cn As SqlConnection
    Dim dr As SqlDataReader
    Dim LoadComplete As Boolean = False
    Private Sub Allocate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rbATM.Checked = True
        rbExpense.Checked = True
        DisplayGrid()
        LoadList()
        LoadBusinesses()

    End Sub
    Sub LoadBusinesses()
        Dim strSql As String = "select busID, busName, busLeftName, busSiblingID, taggedAccount from tblBusiness where busSiblingID in (1,0) order by busname"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        reader = oCommand.ExecuteReader()
        Dim aryBusiness As ArrayList = New ArrayList
        aryBusiness.Add(New AddValue("None", 0))
        While reader.Read()
            Dim x As String = reader.GetString(2)
            Dim y As String = reader.GetInt64(0)
            'gblBusID = reader.GetInt64(0)
            aryBusiness.Add(New AddValue(reader.GetString(2), Convert.ToInt64(reader.GetInt64(0))))
        End While
        reader.Close()
        cn.Close()
        ddlBusiness.DisplayMember = "Display"
        ddlBusiness.ValueMember = "Value"
        ddlBusiness.DataSource = aryBusiness
    End Sub

    Sub LoadList()
        Dim strSql As String
        Dim n As Integer = 0
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        If rbATM.Checked = True Then

            strSql = "Select jnlID,jnlTranType, Convert(varchar, jnlTranDate, 101), Convert(varchar(10), Convert(money, jnlTranAmount)), jnlBankTranID, jnlBankAct from "
            strSql += "tblDRJournal where jnlActNum = 8590 and jnlActSeq = 7  Order by jnlTranDate Desc"
            oCommand = New SqlCommand(strSql, cn)
            cn.Open()
            dgvTransactions.RowCount = 1
            Dim dr As SqlDataReader = oCommand.ExecuteReader()
            dgvAccounts.Refresh()
            If dr.HasRows Then
                While dr.Read

                    dgvTransactions.Rows.Item(n).Cells(0).Value = dr(0).ToString()
                    dgvTransactions.Rows.Item(n).Cells(1).Value = dr(1).ToString()
                    dgvTransactions.Rows.Item(n).Cells(2).Value = dr(2).ToString()
                    dgvTransactions.Rows.Item(n).Cells(3).Value = dr(3).ToString()
                    dgvTransactions.Rows.Item(n).Cells(4).Value = dr(4).ToString()
                    dgvTransactions.Rows.Item(n).Cells(5).Value = dr(5).ToString()

                    n = dgvTransactions.Rows.Add()
                End While



            End If





        End If



    End Sub

    Sub DisplayGrid()
        Dim strActType As String
        If rbExpense.Checked = True Then
            strActType = "expense"
        Else
            strActType = "income"
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
        LoadComplete = True

        cn.Close()
    End Sub
    Private Sub dgvAccounts_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.RowEnter
        Dim i As Integer = e.RowIndex
        Dim cell1 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(1), DataGridViewCell)
        Dim cell2 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(0), DataGridViewCell)
        Dim cell3 As DataGridViewCell = CType(dgvAccounts.Rows(e.RowIndex).Cells(3), DataGridViewCell)
        If LoadComplete = True Then
            If cell1.Value <> Nothing Then
                txtAccountNum.Text = cell1.Value.ToString().Trim
                txtAccountname.Text = cell2.Value.ToString().Trim
                hdnActID.Text = cell3.Value.ToString().Trim

            End If
        End If
    End Sub


    Private Sub dgvTransactions_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTransactions.RowEnter
        Dim i As Integer = e.RowIndex
        Dim cell1 As DataGridViewCell = CType(dgvTransactions.Rows(e.RowIndex).Cells(0), DataGridViewCell) 'ID
        Dim cell2 As DataGridViewCell = CType(dgvTransactions.Rows(e.RowIndex).Cells(1), DataGridViewCell)  'Type
        Dim cell3 As DataGridViewCell = CType(dgvTransactions.Rows(e.RowIndex).Cells(2), DataGridViewCell) 'Date
        Dim cell4 As DataGridViewCell = CType(dgvTransactions.Rows(e.RowIndex).Cells(3), DataGridViewCell)  'aMOUNT
        Dim cell5 As DataGridViewCell = CType(dgvTransactions.Rows(e.RowIndex).Cells(4), DataGridViewCell)  'bank tran id
        Dim cell6 As DataGridViewCell = CType(dgvTransactions.Rows(e.RowIndex).Cells(5), DataGridViewCell)  'bank acct

        If LoadComplete = True Then
            If cell1.Value <> Nothing Then

                lblTranDate.Text = String.Format("{0:c}", cell3.Value.ToString().Trim) '
                lblAmtOrig.Text = String.Format("{0:c}", cell4.Value.ToString().Trim)
                lblTranType.Text = "CASH"   'Transaction type
                hdnATMID.Text = cell1.Value.ToString().Trim
                hdnBnkTranID.Text = cell5.Value.ToString().Trim
                txtBankTranID.Text = hdnBnkTranID.Text

                hdnBankAct.Text = cell6.Value.ToString().Trim
                txtBankAcct.Text = hdnBankAct.Text
                txtSplitAmount.Text = available(0)
                txtLinker.Text = hdnATMID.Text & "_1"
                txtNewDate.Text = Now().ToString()
                BuildGridView(cell1.Value)
            End If
        End If
    End Sub
    Sub BuildGridView(ByVal intLOA As Int64)

        Dim strSql As String
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        'dgvLOA.RowCount = 1 'This clears any data out of the gird
        'strSql = "select * from tblDRJournal where jnlID = " & intLOA
        strSql = "Select a.jnlID, a.jnlLink, (ltrim(str(a.jnlActNum)) + '-' + ltrim(str(a.jnlActSeq))) as Account, jnlTranDate, a.jnlTranAmount, a.jnlTranType, "
        strSql += "a.jnlTranDesc, a.jnlTranMemo ,b.busName, a.jnlBankTranId, a.jnlBankAct From tblDRJournal A, tblBusiness B "
        strSql += "Where b.busID = a.jnlTranBusinessID and a.jnlID = " & intLOA


        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Dim ds As DataSet = New DataSet
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, cn)
        da.Fill(ds)
        dgvLOA.DataSource = ds.Tables(0)



    End Sub


    Private Sub rbExpense_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExpense.CheckedChanged
        DisplayGrid()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblAmtOrig.Text = ""
        lblAmt1.Text = ""
        lblAmt2.Text = ""
        lblAmt3.Text = ""
        lblTranDate.Text = ""
        txtSplitAmount.Text = ""
        txtAccountNum.Text = ""
        txtAccountname.Text = ""
        hdnActID.Text = ""
        lblTranType.Text = ""
        txtAmtToAllocate.Text = ""
        txtTranDesc.Text = ""
        ddlBusiness.SelectedValue = 0
    End Sub

    Private Sub btnAllocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllocate.Click
        Dim lnkField As String = hdnATMID.Text
        Dim arrAct As String() = txtAccountNum.Text.Split("-")
        Dim actNum As String = arrAct(0)
        Dim actSeq As String = arrAct(1)
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        'validation
        If CSng(txtSplitAmount.Text) - CSng(txtAmtToAllocate.Text) < 0 Then
            'Allocating more than is available
            Exit Sub
        End If
        Dim strSql As String = "Insert into tblDRJournal("
        strSql += "jnlLink,jnlActNum,jnlActSeq,jnlTranDate,jnlTranType, jnlTranAmount, jnlTranDesc, jnlTranMemo,jnlTranBusinessID,jnlBankTranID, jnlBankAcct)"
        strSql += " Values ("
        strSql += "'" & lnkField & "',"
        strSql += "" & actNum & ","
        strSql += "" & actSeq & "',"
        strSql += "'" & lblTranType.Text & "',"
        strSql += "'" & lblTranDate.Text & "',"
        strSql += "" & txtAmtToAllocate.Text & ","
        strSql += "'" & txtTranDesc.Text & "',"
        strSql += "'" & txtTranDesc.Text & "',"
        strSql += "" & ddlBusiness.SelectedValue & "',"

        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        reader = oCommand.ExecuteReader()



    End Sub
    Function available(ByVal inAmt As Single) As Single
        Dim newVal As Single = CSng(lblAmtOrig.Text) - CSng(lblAmt1.Text) - CSng(lblAmt1.Text) - CSng(lblAmt1.Text)
        Return newVal
    End Function

End Class
'Public Class jnlEntry
'    Public Sub New(ByVal id As Int64, ByVal actLink As String, ByVal actNum As Int16, ByVal actSeq As Int16, ByVal tranDate As DateTime, ByVal tranType As String, _
'     ByVal tranAmount As Single, ByVal tranDesc As String, ByVal tranMemo As String, ByVal tranBusID As Int64, ByVal tranID As Int64, ByVal bankAct As String)
'        _id = id
'        _actLink = actLink
'        _actNum = actNum
'        _actSeq = actSeq
'        _tranDate = tranDate
'        _tranType = tranType
'        _tranAmount = tranAmount
'        _tranDesc = tranDesc
'        _tranMemo = tranMemo
'        _tranBusID = tranBusID
'        _tranID = tranID
'        _bankAct = bankAct

'    End Sub

'    Private _id As Int64
'    Public Property ID() As Int64
'        Get
'            Return _id
'        End Get
'        Set(ByVal value As Int64)
'            _id = value
'        End Set
'    End Property


'    Private _actLink As String
'    Public Property ActLink() As String
'        Get
'            Return _actLink
'        End Get
'        Set(ByVal value As String)
'            _actLink = value
'        End Set
'    End Property

'    Private _actNum As Int16
'    Public Property Actnum() As Int16
'        Get
'            Return _actNum
'        End Get
'        Set(ByVal value As Int16)
'            _actNum = value
'        End Set
'    End Property


'    Private _actSeq As Int16
'    Public Property ActSeq() As Int16
'        Get
'            Return _actSeq
'        End Get
'        Set(ByVal value As Int16)
'            _actSeq = value
'        End Set
'    End Property


'    Private _tranDate As DateTime
'    Public Property TranDate() As DateTime
'        Get
'            Return _tranDate
'        End Get
'        Set(ByVal value As DateTime)
'            _tranDate = value
'        End Set
'    End Property


'    Private _tranType As String
'    Public Property TranType() As String
'        Get
'            Return _tranType
'        End Get
'        Set(ByVal value As String)
'            _tranType = value
'        End Set
'    End Property


'    Private _tranAmount As Single
'    Public Property TranAmount() As Single
'        Get
'            Return _tranAmount
'        End Get
'        Set(ByVal value As Single)
'            _tranAmount = value
'        End Set
'    End Property

'    Private _tranDesc As String
'    Public Property TranDesc() As String
'        Get
'            Return _tranDesc
'        End Get
'        Set(ByVal value As String)
'            _tranDesc = value
'        End Set
'    End Property


'    Private _tranMemo As String
'    Public Property TranMemo() As String
'        Get
'            Return _tranMemo
'        End Get
'        Set(ByVal value As String)
'            _tranMemo = value
'        End Set
'    End Property


'    Private _tranBusID As Int64
'    Public Property TranBusID() As Int64
'        Get
'            Return _tranBusID
'        End Get
'        Set(ByVal value As Int64)
'            _tranBusID = value
'        End Set
'    End Property


'    Private _tranID As Int64
'    Public Property Link() As Int64
'        Get
'            Return _tranID
'        End Get
'        Set(ByVal value As Int64)
'            _tranID = value
'        End Set
'    End Property

'    Private _bankAct As String

'    Public Property BankAct() As String
'        Get
'            Return _bankAct
'        End Get
'        Set(ByVal value As String)
'            _bankAct = value
'        End Set
'    End Property

'End Class

