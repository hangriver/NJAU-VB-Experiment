Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim x, y, remainder, tmp As Integer
        x = Box1.Text
        y = Box2.Text
        Console.WriteLine(x & "/" & y)
        tmp = y
        Do
            Console.WriteLine(remainder)
            remainder = x Mod tmp
            x = tmp
            tmp = remainder
        Loop Until remainder = 0
        Out.Content = "The maxnium remainder is: " & x
    End Sub
End Class
