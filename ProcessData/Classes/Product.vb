Imports System.Data.OleDb


Class Product

#Region "Private Variables"

    Private intID As Integer
    Private strName As String
    Private intCategoryID As Integer
    Private dblRetailPrice As Double
    Private lstUnitSales As New List(Of Integer)
    Private asState As ApplicationState

#End Region

#Region "Constructors"

    Public Sub New()

        For intList As Integer = 0 To 3
            lstUnitSales.Add(0)
        Next

    End Sub

#End Region

#Region "Public Properties"

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

    Public Property CategoryID() As Integer
        Get
            Return intCategoryID
        End Get
        Set(ByVal value As Integer)
            intCategoryID = value
        End Set
    End Property

    Public Property UnitSales() As List(Of Integer)
        Get
            Return lstUnitSales
        End Get
        Set(ByVal value As List(Of Integer))
            lstUnitSales = value
        End Set
    End Property

    Public Property UnitSalesMonth1() As Integer
        Get
            Return lstUnitSales(0)
        End Get
        Set(ByVal value As Integer)
            lstUnitSales(0) = value
        End Set
    End Property

    Public Property UnitSalesMonth2() As Integer
        Get
            Return lstUnitSales(1)
        End Get
        Set(ByVal value As Integer)
            lstUnitSales(1) = value
        End Set
    End Property

    Public Property UnitSalesMonth3() As Integer
        Get
            Return lstUnitSales(2)
        End Get
        Set(ByVal value As Integer)
            lstUnitSales(2) = value
        End Set
    End Property

    Public Property UnitSalesCurrent() As Integer
        Get
            Return lstUnitSales(3)
        End Get
        Set(ByVal value As Integer)
            lstUnitSales(3) = value
        End Set
    End Property

    Public Property RetailPrice() As Double
        Get
            Return dblRetailPrice
        End Get
        Set(ByVal value As Double)
            dblRetailPrice = value
        End Set
    End Property

    Public Property State() As ApplicationState
        Get
            Return asState
        End Get
        Set(ByVal value As ApplicationState)
            asState = value
        End Set
    End Property

#End Region

#Region "Public Functions"

    Public Function DailySales(ByVal StartDate As Date, ByVal EndDate As Date, ByVal ConnectionString As String) As DataTable
        'Builiding datatabe (dtSales). to contain Date and Units solde by Product.
        'Convert to Date and Dollars earned or spent by Account

        Using conOrders As New OleDbConnection(ConnectionString)
            Dim dtSales As New DataTable
            Dim dictSales As New Dictionary(Of Date, Int32)
            Dim cmdDailySales As New OleDbCommand()
            cmdDailySales.CommandText = "SELECT s.InvDate as `Date`, SUM(sd.Quantity) as `Quantity` FROM SalesDetails sd RIGHT JOIN Sales s ON s.ID = sd.SaleID WHERE s.InvDate > #" & StartDate & "# AND s.InvDate < #" & EndDate & "# AND sd.ProductID = " & ID & " GROUP BY s.InvDate"
            cmdDailySales.Connection = conOrders
            conOrders.Open()
            Dim dbrDailySales As OleDbDataReader = cmdDailySales.ExecuteReader
            While dbrDailySales.Read
                Dim dteSale As Date = dbrDailySales.GetDateTime(0)
                Dim intUnitsSold As Integer = dbrDailySales.GetDouble(1)
                dictSales.Add(dteSale, intUnitsSold)
            End While
            Dim dictFinal As New Dictionary(Of Date, Int32)
            For i As Integer = 0 To DateDiff(DateInterval.Day, StartDate, EndDate)
                Dim dteSales As Date = StartDate.AddDays(i)
                If dteSales.DayOfWeek <> DayOfWeek.Saturday And dteSales.DayOfWeek <> DayOfWeek.Sunday And IsHoliday(dteSales) = False Then
                    dictFinal.Add(StartDate.AddDays(i), 0)
                    If dictSales.ContainsKey(StartDate.AddDays(i)) Then
                        dictFinal(StartDate.AddDays(i)) = dictSales(StartDate.AddDays(i))
                    End If
                End If
            Next
            Dim column As DataColumn
            column = New DataColumn() ' Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column.DataType = System.Type.GetType("System.DateTime")
            column.ColumnName = "Date"
            dtSales.Columns.Add(column)
            column = New DataColumn() ' Create second column.
            column.DataType = Type.GetType("System.Int32")
            column.ColumnName = "UnitsSold"
            dtSales.Columns.Add(column)
            For i As Integer = 0 To dictFinal.Count - 1
                Dim row As DataRow = dtSales.NewRow
                '        row("Date") = dictFinal.Keys(i)
                '       row("UnitsSold") = dictFinal.Values(i)
                dtSales.Rows.Add(row)
            Next
            Return dtSales
        End Using

    End Function

#End Region

#Region "Shared Functions"

    Shared Function GetProductsByCategory(ByVal CategoryID As Integer, ByVal ConnectionString As String) As List(Of Product)

        Using conProducts As New OleDbConnection(ConnectionString)
            conProducts.Open()
            Dim cmdProducts As New OleDbCommand()
            cmdProducts.Connection = conProducts
            cmdProducts.CommandText = "SELECT ID, ProdName, SalesMonth1, SalesMonth2, SalesMonth3, SalesCurrentMonth, CategoryID, State, RetailPrice FROM Products WHERE CategoryID = " & CategoryID
            Dim lstProducts As New List(Of Product)
            Dim dbrProduct As OleDbDataReader = cmdProducts.ExecuteReader
            While dbrProduct.Read
                Dim blnNullCheck As Boolean = False 'prepeare boolean to handle null values
                For intFields As Integer = 0 To dbrProduct.FieldCount - 1 'Iterate through fields to check for null
                    If DBNull.Value.Equals(dbrProduct(intFields)) Then 'If db return value is null 
                        blnNullCheck = True                                           'Set boolean to true
                    End If
                Next
                If Not blnNullCheck Then 'If no null values returned in row then create object else goto next record
                    Dim newProduct As New Product()
                    With newProduct
                        .ID = dbrProduct.GetInt16(0)
                        .Name = dbrProduct.GetString(1)
                        .UnitSales = New List(Of Integer)
                        .UnitSales.Add(dbrProduct.GetInt16(2))
                        .UnitSales.Add(dbrProduct.GetInt16(3))
                        .UnitSales.Add(dbrProduct.GetInt16(4))
                        .UnitSales.Add(dbrProduct.GetInt16(5))
                        .CategoryID = dbrProduct.GetInt16(6)
                        .State = dbrProduct.GetInt16(7)
                        .RetailPrice = dbrProduct.GetDouble(8)
                    End With
                    lstProducts.Add(newProduct)
                End If
            End While
            dbrProduct.Close()
            Return lstProducts
        End Using

    End Function

#End Region

End Class
