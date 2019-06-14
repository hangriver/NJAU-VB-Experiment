Class MainWindow
    Function factorial(x)
        Dim f As Integer
        f = 1
        For i = 1 To x
            f = f * i
        Next
        Return f
    End Function
    Private Sub Calc_Click(sender As Object, e As RoutedEventArgs) Handles Calc.Click
        Dim m, n, r, z As Integer
        m = TextBox1.Text
        n = TextBox2.Text
        z = n - m
        r = (factorial(n)) / (factorial(m) * factorial(z))
        Result.Content = r
    End Sub
End Class
