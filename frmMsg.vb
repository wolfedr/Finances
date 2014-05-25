Public Class frmMsg

    Private _strMessage As String

    Property strMessge() As String
        Get
            Return _strMessage
        End Get
        Set(ByVal Value As String)
            _strMessage = Value
        End Set
    End Property


    Public Sub New(ByVal Value As String)
        _strMessage = Value
        InitializeComponent()
    End Sub
  
    Private Sub frmMsg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Left = 300
        Me.Top = 400
        showit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Sub showit()
        Dim myFont As New Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point)
        Dim myColor As Color = Color.Blue
        txtArea.SelectionFont = myFont
        txtArea.SelectionColor = myColor
        txtArea.SelectedText = _strMessage
        txtArea.Top = 30
        txtArea.Left = 35
    End Sub
End Class
