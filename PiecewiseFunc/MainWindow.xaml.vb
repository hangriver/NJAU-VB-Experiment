Class MainWindow
    Private Sub Calc_Click(sender As Object, e As RoutedEventArgs) Handles calc.Click
        Dim x, y As Double
        x = ValueX.Text
        If x >= 0 Then
            y = x ^ 2 - 1
        ElseIf x < 0 Then
            y = 2 * x ^ 3 - x + 1
        End If
        ValueY.Content = y
    End Sub
End Class
