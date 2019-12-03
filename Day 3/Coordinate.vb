Public Class Coordinate

    Public X As Integer

    Public Y As Integer

    Public Sub New(x As Integer, y As Integer)
        Me.X = x
        Me.Y = y
    End Sub

    Public Overrides Function ToString() As String
        Return "[" + Me.X.ToString() + " | " + Me.Y.ToString() + "]"
    End Function

End Class
