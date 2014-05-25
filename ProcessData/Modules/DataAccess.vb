Module DataAccess

#Region "Data Object Enumerators"

    Public Enum ApplicationState

        Discontinued
        Current

    End Enum

    Public Enum SalesMonth

        SalesMonth1
        SalesMonth2
        SalesMonth3
        SalesCurrentMonth

    End Enum

#End Region

#Region "Data Structures"

    Public Structure AppDataPoint 'Structure to hold various graphing points
        Implements IComparable

        Private objKey As Object
        Private dblValue As Double
        Private objTag As Object

        Public Property DataKey() As Object
            Get
                Return objKey
            End Get
            Set(ByVal value As Object)
                objKey = value
            End Set
        End Property

        Public Property DataValue() As Double
            Get
                Return dblValue
            End Get
            Set(ByVal value As Double)
                dblValue = value
            End Set
        End Property

        Public Property Tag() As Object
            Get
                Return objTag
            End Get
            Set(ByVal value As Object)
                objTag = value
            End Set
        End Property

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo

            If Me.DataValue < CType(obj, AppDataPoint).DataValue Then
                Return 1
            ElseIf Me.DataValue > CType(obj, AppDataPoint).DataValue Then
                Return -1
            Else
                Return 0
            End If
        End Function

    End Structure 'DataPoint

#End Region

End Module
