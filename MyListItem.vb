Public Class MyListItem
    Private displayThing As String
    Private valueThing As String
    Public Sub New(ByVal DisplayItem As String, ByVal ValueItem As String)
        displayThing = DisplayItem
        valueThing = ValueItem
    End Sub
    Property DisplayItem() As String
        Get
            Return displayThing
        End Get
        Set(ByVal value As String)
            displayThing = value
        End Set
    End Property
    Property ValueItem() As String
        Get
            Return valueThing
        End Get
        Set(ByVal value As String)
            valueThing = value
        End Set
    End Property

End Class
