Imports System.Data.SqlClient
Imports System.Configuration
Public Class GetBusiness
    Dim cn As SqlConnection
    Dim reader As SqlDataReader
    Dim oCommand As SqlCommand
    Public busName As String
    Public busID As Long
    Public actID As Long
    Dim aryAccount As ArrayList
    Dim LoadComplete As Boolean = False
    Dim mySource As New AutoCompleteStringCollection()
    Protected lst As New List(Of String)

    Private Sub GetBusiness_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetData()
        btnClose.Focus()
        txtTemp.Text = ddlBusiness.SelectedValue 'busName
        LoadComplete = True
    End Sub
    Private Sub GetData()
        'Fill the dropdown of businesses
        Dim strSql As String = "select busID, busName, taggedAccount from tblBusiness where busSiblingID in (1,0) order by busname"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        aryAccount = New ArrayList()
        cn.Open()
        reader = oCommand.ExecuteReader()
        Dim aryBusiness As ArrayList = New ArrayList
        aryBusiness.Add(New AddValue("Select Business", 0))
        While reader.Read()
            lst.Add(reader.GetString(1))
            Dim x As String = reader.GetString(1)
            Dim y As String = reader.GetInt64(0)
            Dim z As String = reader.GetInt64(2)
            'this array will tag an account to the list entry.
            aryAccount.Add(z)
            aryBusiness.Add(New AddValue(reader.GetString(1), Convert.ToInt64(reader.GetInt64(0))))
        End While
        reader.Close()
        cn.Close()
        mySource.AddRange(lst.ToArray)
        ddlBusiness.AutoCompleteCustomSource = mySource
        ddlBusiness.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddlBusiness.AutoCompleteSource = AutoCompleteSource.CustomSource
        ddlBusiness.DisplayMember = "Display"
        ddlBusiness.ValueMember = "Value"
        ddlBusiness.DataSource = aryBusiness


    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        busName = ddlBusiness.Text.Trim
        busID = ddlBusiness.SelectedValue
        actID = lblHdnAct.Text
        If actID = 0 Then
            If busID = 0 Then
                actID = aryAccount(ddlBusiness.SelectedIndex)
            Else
                Dim strSql As String = "select taggedAccount from tblBusiness where busID = " & busID
                cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
                oCommand = New SqlCommand(strSql, cn)
                cn.Open()
                actID = oCommand.ExecuteScalar
                cn.Close()
            End If
        End If
        Me.Close()
    End Sub

   

    Private Sub ddlBusiness_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlBusiness.SelectedIndexChanged
        If LoadComplete = True Then
            busName = ddlBusiness.Text.Trim
            busID = ddlBusiness.SelectedValue
            actID = aryAccount(ddlBusiness.SelectedIndex)
            lblHdnAct.Text = actID.ToString

        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        actID = 0  'Going to Add or Edit business so unset act id from getbusiness dropdown
        AddBusiness.ShowDialog()
        GetData()
        ddlBusiness.SelectedValue = AddBusiness.gblBusID

    End Sub
End Class
Public Class AddValue
    Private m_Display As String
    Private m_Value As Long
    Public Sub New(ByVal Display As String, ByVal Value As Long)
        m_Display = Display
        m_Value = Value
    End Sub
    Property Value() As Long
        Set(ByVal Value As Long)
            m_Value = Value
        End Set
        Get
            Return m_Value
        End Get
    End Property
    Property Display() As String
        Set(ByVal Display As String)
            m_Display = Display
        End Set
        Get
            Return m_Display
        End Get
    End Property
End Class