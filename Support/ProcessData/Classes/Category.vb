Imports System.Data.OleDb


Class Category

#Region "Class Variables"

    Private intID As Integer
    Private strName As String
    Private csCategoryState As ApplicationState
    Private decTotalSales As New List(Of Decimal)(3)
    Private lstProducts As New List(Of Product)

#End Region

#Region "Class Properties"

    Public Property ID() As Integer
        Get
            Return intID
        End Get
        Set(ByVal value As Integer)
            intID = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property

    Public Property State() As ApplicationState
        Get
            Return csCategoryState
        End Get
        Set(ByVal value As ApplicationState)
            csCategoryState = value
        End Set
    End Property

    Public ReadOnly Property Products() As List(Of Product)
        Get
            Return lstProducts
        End Get
    End Property

    Public ReadOnly Property TotalSales() As List(Of Decimal)
        Get
            Return decTotalSales
        End Get
    End Property

#End Region

#Region "Constructors"

    Public Sub New()

    End Sub

    Public Sub New(ByVal CategoryID As Integer, ByVal ConnectionString As String)

        ID = CategoryID
        GetOrderCategory(ConnectionString)
        lstProducts = Product.GetProductsByCategory(Me.ID, ConnectionString)

    End Sub

#End Region

#Region "Class Routines"

#Region "Private Routines"

    Private Sub GetOrderCategory(ByVal ConnectionString As String)

        Using conOrders As New OleDbConnection(ConnectionString)
            conOrders.Open()
            Dim cmdDays As New OleDbCommand("SELECT c.CategoryName, c.State  FROM Categories c WHERE ID = " & ID, conOrders)
            Dim dbrCategories As OleDbDataReader = cmdDays.ExecuteReader
            While dbrCategories.Read
                Dim blnNullCheck As Boolean = False 'prepeare boolean to handle null values
                For intFields As Integer = 0 To dbrCategories.FieldCount - 1 'Iterate through fields to check for null
                    If DBNull.Value.Equals(dbrCategories(intFields)) Then 'If db return value is null 
                        blnNullCheck = True                                            'Set boolean to true
                    End If
                Next
                If Not blnNullCheck Then 'If no null values returned in row then create object else goto next record
                    Name = dbrCategories.GetString(0)
                    State = dbrCategories.GetInt16(1)
                End If
            End While
            dbrCategories.Close()
            For intMonths As Integer = 0 To 3
                TotalSales.Add(GetTotalSales(intMonths, ConnectionString))
            Next
        End Using

    End Sub

    Private Function GetTotalSales(ByVal TotalMonth As SalesMonth, ByVal ConnectionString As String) As Decimal

        Using conOrders As New OleDbConnection(ConnectionString)
            conOrders.Open()
            Dim cmdTotalSales As New OleDbCommand()
            cmdTotalSales.CommandText = "SELECT Sum(" & TotalMonth.ToString & " * RetailPrice) FROM Products  WHERE CategoryID = " & ID
            cmdTotalSales.Connection = conOrders
            Dim objResult As Object = cmdTotalSales.ExecuteScalar
            If IsNumeric(objResult) Then
                Return CType(objResult, Decimal)
            Else
                Return 0
            End If
        End Using

    End Function

#End Region

#Region "Shared Routines"

    Shared Function GetAllCategories(ByVal ConnectionString As String) As List(Of Category)

        Using conOrders As New OleDbConnection(ConnectionString)
            conOrders.Open()
            Dim lstCategories As New List(Of Category)
            Dim cmdCategories As New OleDbCommand()
            cmdCategories.CommandText = "SELECT c.ID FROM Categories c WHERE State = " & ApplicationState.Current
            cmdCategories.Connection = conOrders
            Dim dbrCategories As OleDbDataReader = cmdCategories.ExecuteReader
            While dbrCategories.Read
                Dim newCategory As New Category(CInt(dbrCategories(0).ToString), ConnectionString)
                lstCategories.Add(newCategory)
            End While
            dbrCategories.Close()
            Return lstCategories
        End Using

    End Function

#End Region

#End Region

End Class
