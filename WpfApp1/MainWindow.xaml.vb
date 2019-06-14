Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Const PI = 3.1415926535
        Dim radius, area As Double
        radius = TextBox1.Text
        area = radius ^ 2 * PI
        Lable1.Content = area
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs)
        Console.WriteLine("content changed as " + TextBox1.Text)
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        TextBox1.Clear()
    End Sub
End Class
