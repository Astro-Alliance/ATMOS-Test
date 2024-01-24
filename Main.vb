Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fill Chart1 with 100 random data points
        Dim rnd As New Random()
        For i As Integer = 0 To 99
            Chart1.Series(0).Points.AddXY(i, rnd.Next(100))
        Next
    End Sub
End Class
