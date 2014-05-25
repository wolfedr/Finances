Imports System.Data.SqlClient
Imports System.Configuration
Public Class EditJournal
    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim blnComplete As Boolean = False
    Dim intbusID As Integer
    Dim strRange As String
    Dim strbusName As String
    Dim blnMasterAcctReady As Boolean = False
    Dim blnSubAcctReady As Boolean = False
    Dim aryAll As ArrayList = New ArrayList
    Public StrSource As String  'This is the module that called EditJournal
    Public strStart As String   'This is for a preset journal transaction to view.
    Dim blnDidSave As Boolean = False
    Dim blnHideOrClose As Boolean = False
    Private isDirty As Boolean = False

    Private Sub EditJournal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim id As Int32 = Convert.ToInt32(strStart)
        If id > 0 Then
            ShowData(id)
            blnHideOrClose = True
        Else
            'Fill unselected dropdowns
            FillDropDowns(0, 0, 0, 0, 0, "X", 0)
        End If
    End Sub

    Sub GetEntries(ByVal strMyRange As String)
        strRange = strMyRange
        Dim dteMydate As DateTime = dtpJournal.Value
        dteMydate = dteMydate.ToShortDateString
        Dim strSql As String = "Select jnlID, (ltrim(a.jnlActNum) + '-' + ltrim(a.jnlActSeq)) as Account, b.busName, a.jnlTranAmount, a.jnlTranDate as [Day] from tblDRJournal a "
        strSql += " left outer join  tblBusiness b on  a.jnlTranBusinessID = b.BusID"
        strSql += " Where "
        If strRange = "One" Then
            strSql += " a.jnlTranDate = '" & dteMydate & "' "
        Else
            strSql += " a.jnlTranDate > DateAdd(dd,-5,'" & dteMydate & "')and a.jnlTranDate < DateAdd(dd,5, '" & dteMydate & "') "
        End If
        strSql += "order by a.jnlTranDate "
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        Try
            cn.Open()
            da = New SqlDataAdapter(strSql, cn)
            ds = New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                dgvEntries.DataSource = ds.Tables(0)
            Else
                MsgBox("No Journal Entries for this day", MsgBoxStyle.OkOnly, "Check Date")
            End If
        Catch ex As Exception
            MsgBox("Error in selection", MsgBoxStyle.OkOnly, "Selection Error")
        End Try
    End Sub

    Private Sub btnGetEntries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtraDays.Click
        GetEntries("Many")
    End Sub

    Private Sub dgvEntries_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEntries.RowEnter
        Dim columnID As DataGridViewColumn = dgvEntries.Columns(0)
        columnID.HeaderText = "ID"
        columnID.Width = 40
        columnID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim columnAct As DataGridViewColumn = dgvEntries.Columns(1)
        columnAct.HeaderText = "Acct."
        columnAct.Width = 50
        columnAct.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim columnBus As DataGridViewColumn = dgvEntries.Columns(2)
        columnBus.HeaderText = "Business"
        columnBus.Width = 180
        columnBus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim columnAmt As DataGridViewColumn = dgvEntries.Columns(3)
        columnAmt.HeaderText = "Amount"
        columnAmt.Width = 90
        columnAmt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        columnAmt.DefaultCellStyle.Format = "c"

        Dim columnDate As DataGridViewColumn = dgvEntries.Columns(4)
        columnDate.HeaderText = "Date"
        columnDate.Width = 80
        columnDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'columnDate.DefaultCellStyle.Format = "c"
    End Sub

    Sub ShowData(ByVal lngID As Long)
        Dim busID, actBankNum, intActivity As Int64
        Dim actNum As Int16 = 0
        Dim actNumSeq As Int16 = 0
        Dim actSrcID As Int16 = 0
        Dim strExtName As String = "None"
        Dim strSql As String = "select * from tblDRJournal where jnlID = " & lngID
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            txtJnlID.Text = dr.GetInt64(0)
            txtJnlActNum.Text = Convert.ToInt16(dr(3))
            actNum = Convert.ToInt16(dr(3))
            actNumSeq = Convert.ToInt16(dr(4))
            txtJnlSequence.Text = actNumSeq
            txtjnlTranDate.Text = dr.GetDateTime(5)
            txtJnlTranType.Text = dr.GetString(6)
            txtJnlTranAmount.Text = Convert.ToSingle(dr(7)).ToString("c")
            txtJnlDescription.Text = dr.GetString(8)
            txtJnlMemo.Text = dr.GetString(9)
            txtJnlBusID.Text = Convert.ToInt64(dr(10))
            busID = Convert.ToInt64(dr(10))
            txtBankTranID.Text = Convert.ToInt64(dr(11))
            txtBankAct.Text = Convert.ToInt64(dr(12))
            actBankNum = Convert.ToInt64(dr(12))
            intActivity = dr(14).ToString
            If dr("jnlHaveReceipt") = 0 Then
                cbReceipt.Checked = False
            Else
                cbReceipt.Checked = True
            End If
        End If
        dr.Close()
        cn.Close()
        FillDropDowns(lngID, busID, actBankNum, actNum, actNumSeq, strExtName, intActivity)
        blnComplete = True
    End Sub

    Sub FillDropDowns(ByVal recID As Int64, ByVal lngBusID As Int64, ByVal lngBankAcctID As Int64, ByVal intActNum As Int16, ByVal intActSeq As Int16, ByVal strExternal As String, ByVal intActivityID As Int32)
        'Fill Business Dropdown
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        'If cn.State = ConnectionState.Closed Then
        cn.Open()
        'End If
        Dim strSql As String = "select busID, (ltrim(busLeftName) + '(' + ltrim(str(busID)) + ')') as Name from tblBusiness order by busName"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim da1 As New SqlDataAdapter(strSql, cn)
        Dim ds1 As New DataSet
        cn.Open()
        da1.Fill(ds1, "tblBusiness")
        cmbBusiness.DataSource = ds1.Tables("tblBusiness")
        cmbBusiness.DisplayMember = "Name"
        cmbBusiness.ValueMember = "busID"
        If lngBusID > 0 Then
            cmbBusiness.SelectedValue = lngBusID
        End If
        'Fill Bannk Account dropdown
        strSql = "Select actNum, actName from tblBankAcct order by actName"
        ds1 = New DataSet
        da1 = New SqlDataAdapter(strSql, cn)
        da1.Fill(ds1, "tblBankAcct")
        cmbBankAccount.DataSource = ds1.Tables("tblBankAcct")
        cmbBankAccount.DisplayMember = "actName"
        cmbBankAccount.ValueMember = "actNum"
        If lngBankAcctID > 0 Then
            cmbBankAccount.SelectedValue = lngBankAcctID
        End If
        'Fill Major Acccount dropdown
        strSql = "select distinct actNum, (rtrim(actName) + '(' + ltrim(str(actNum)) + ')') as actName  from tblDRCOA where actUse > 0 and left(ltrim(str(actNum)),1) not in ('2','3', '9') order by actName"  '('1', '2','3', '9')
        ds1 = New DataSet
        da1 = New SqlDataAdapter(strSql, cn)
        da1.Fill(ds1, "tblDRCOA")
        cmbMajorAcct.DataSource = ds1.Tables("tblDRCOA")
        cmbMajorAcct.DisplayMember = "actName"
        cmbMajorAcct.ValueMember = "actNum"
        If intActNum > 0 Then
            cmbMajorAcct.SelectedValue = intActNum
        Else
            cmbMajorAcct.SelectedValue = 1010
        End If
        'Fill sub-account dropdown from major account
        strSql = "select actNumSeq, actDescription from tblDRCOA where actNum = coalesce('" & cmbMajorAcct.SelectedValue & "',1010) and actUse > 0 order by actDescription"
        ds1 = New DataSet
        da1 = New SqlDataAdapter(strSql, cn)
        da1.Fill(ds1, "tblDRCOA")
        cmbSubAcct.DataSource = ds1.Tables("tblDRCOA")
        cmbSubAcct.DisplayMember = "actDescription"
        cmbSubAcct.ValueMember = "actNumSeq"
        cmbSubAcct.SelectedValue = intActSeq

        ''Fill external-account dropdown 
        'strSql = "select srcID, srcName from tblExternalSource order by srcID"
        'ds1 = New DataSet
        'da1 = New SqlDataAdapter(strSql, cn)
        'da1.Fill(ds1, "tblExternalSource")
        'cmbExternalSource.DataSource = ds1.Tables("tblExternalSource")
        'cmbExternalSource.DisplayMember = "srcName"
        'cmbExternalSource.ValueMember = "srcID"
        'If Len(strExternal) > 0 Then
        '    cmbExternalSource.SelectedValue = intSrcID
        'End If

        'Fill Activity Dropdown
        strSql = "select activityID, ActivityDescription from tblActivity order by ActivitySort"
        ds1 = New DataSet
        da1 = New SqlDataAdapter(strSql, cn)
        da1.Fill(ds1, "tblActivity")

        ddlActivity.DataSource = ds1.Tables("tblActivity")
        ddlActivity.DisplayMember = "activityDescription"
        ddlActivity.ValueMember = "ActivityID"
        If Len(strExternal) > 0 Then
            ddlActivity.SelectedValue = intActivityID
        End If





        cn.Close()
    End Sub

    Private Sub dgvEntries_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEntries.CellContentClick
        Dim i As Integer = e.ColumnIndex
        If i <> 0 Then Exit Sub
        Dim J As Integer = e.RowIndex
        Dim id As Long = dgvEntries.Rows(J).Cells(i).Value
        ShowData(id)
    End Sub

    Private Sub cmbMajorAcct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMajorAcct.Click
        blnMasterAcctReady = True
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Dim strSql As String = "Update tblDRJournal set "
        strSql += "jnlActNum=" & Convert.ToInt16(txtJnlActNum.Text) & ", "
        strSql += "jnlActSeq=" & Convert.ToInt16(txtJnlSequence.Text) & ", "
        strSql += "jnlTranBusinessID=" & cmbBusiness.SelectedValue & ", "
        strSql += "jnlTranDesc='" & txtJnlDescription.Text & "', "
        strSql += "jnlTranMemo='" & txtJnlMemo.Text & "', "
        strSql += "ExternalMark='" & cmbExternalSource.SelectedValue & "', "
        strSql += "jnlBankAct=" & Convert.ToInt64(txtBankAct.Text) & ", "
        strSql += "jnlActivityID=" & Convert.ToInt64(ddlActivity.SelectedValue) & ", "
        strSql += "jnlActivity='" & ddlActivity.Text & "', "
        strSql += "timestamp='" & Now() & "', "
        strSql += "jnlHaveReceipt='" & cbReceipt.CheckState & "'"
        strSql += " Where jnlID=" & Convert.ToInt64(txtJnlID.Text)
        oCommand = New SqlCommand(strSql, cn)
        Dim xx As Object
        Try
            cn.Open()
            xx = oCommand.ExecuteNonQuery
        Catch ex As Exception
            MsgBox("Save Failed!", MsgBoxStyle.OkOnly, "Save Dialog")
        End Try
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        blnDidSave = True
        If blnHideOrClose = False Then
            GetEntries(strRange)
        End If
    End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If blnDidSave = False Then
            Dim intDecision As Integer = MessageBox.Show("Do you want to save this record before you exit?", "Review", MessageBoxButtons.YesNo)
            If intDecision = vbYes Then
                Exit Sub
            End If
        End If
        'hide or close is true if this module was called by another and false if it was opened directly by the user/
        '
        If blnHideOrClose = True Then
            Select Case StrSource
                Case "rptTransactions"
                    Dim myForm As rptTransactions
                    Me.Close()
                    myForm = New rptTransactions
                    myForm.intPreCheckedID = strStart
                    'myForm.DisplayData()
                    myForm.Show()
                Case Else
                    Me.Close()
            End Select


            'Dim myForm As baseform
            'Me.Close()
            'myForm = New baseform
            'myForm.Show()

        Else
            Me.Close()
            Main.Show()
        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GetEntries("One")
    End Sub

    Private Sub cmbSubAcct_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSubAcct.SelectedIndexChanged
        isDirty = True
        If blnSubAcctReady = True Then
            txtJnlSequence.Text = Convert.ToString(cmbSubAcct.SelectedValue)
            blnSubAcctReady = False
        End If
    End Sub

    Private Sub cmbBusiness_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBusiness.Leave
        isDirty = True
        strbusName = cmbBusiness.Text
        Dim intLoc = Microsoft.VisualBasic.InStr(strbusName, "(")
        strbusName = strbusName.Substring(0, intLoc - 1)
        intbusID = cmbBusiness.SelectedValue
    End Sub
    Private Sub cmbSubAcct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSubAcct.Click
        isDirty = True
        blnSubAcctReady = True
    End Sub


    Private Sub cmbMajorAcct_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMajorAcct.SelectedValueChanged
        isDirty = True
        Dim strSql As String
        'Dim actSeq As Int16
        Dim arySource As ArrayList = New ArrayList
        Dim myItem As actItem
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        If blnMasterAcctReady = True Then
            blnMasterAcctReady = False
            txtJnlActNum.Text = cmbMajorAcct.SelectedValue
            'Fill sub-account dropdown from major account
            strSql = "select actNumSeq, actDescription from tblDRCOA where actNum = " & cmbMajorAcct.SelectedValue & " and actUse > 0 order by actDescription"
            oCommand = New SqlCommand(strSql, cn)
            'Dim ds1 As New DataSet
            'Dim da1 As New SqlDataAdapter(strSql, cn)
            'da1.Fill(ds1, "tblDRCOA")
            myItem = New actItem
            myItem.actDescription = "Select Sub Account...."
            myItem.actSeq = 0
            arySource.Add(myItem)
            cn.Open()
            dr = oCommand.ExecuteReader()
            If dr.HasRows Then
                While dr.Read()
                    myItem = New actItem
                    myItem.actDescription = dr(1).ToString
                    myItem.actSeq = Convert.ToInt16(dr(0))
                    arySource.Add(myItem)
                End While
            End If
            cmbSubAcct.DataSource = arySource
            cmbSubAcct.DisplayMember = "actDescription"
            cmbSubAcct.ValueMember = "actSeq"
            cmbSubAcct.SelectedIndex = 0
            txtJnlSequence.Text = Convert.ToString(cmbSubAcct.SelectedValue)
            cn.Close()
        End If
    End Sub



End Class

Public Class actItem
    Private stor0 As String
    Private stor1 As String
    Public Sub actItem(ByVal actDescription As String, ByVal actSeq As Int16)
        stor0 = actDescription
        stor1 = actSeq
    End Sub
    Property actDescription() As String
        Get
            Return stor0
        End Get
        Set(ByVal Value As String)
            stor0 = Value
        End Set
    End Property

    Property actSeq() As Int16
        Get
            Return stor1
        End Get
        Set(ByVal Value As Int16)
            stor1 = Value
        End Set
    End Property


End Class

Public Class Externals
    Public extName As String
    Public extID As Int32
    Public Sub New( _
       ByVal m_extName As String, _
       ByVal m_extID As Int32)
        extName = m_extName
        extID = m_extID
    End Sub

    Property m_extName() As String
        Get
            Return extName
        End Get
        Set(ByVal value As String)
            extName = value
        End Set
    End Property
    Property m_extID() As Int32
        Get
            Return extID
        End Get
        Set(ByVal value As Int32)
            extID = value
        End Set
    End Property


End Class