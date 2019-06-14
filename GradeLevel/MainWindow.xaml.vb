Class MainWindow
    'textbox中成绩变化时就执行'
    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs)
        Dim score As Double
        Dim word As String
        word = "Your level is: "
        score = ScoreBox.Text
        Console.WriteLine(score)
        Select Case score
            Case 90 To 100
                level.Content = word + "A"
            Case 80 To 90
                level.Content = word + "B"
            Case 60 To 80
                level.Content = word + "C"
            Case 0 To 60
                level.Content = word + "F"
            Case Else
                level.Content = "Wrong score!"
        End Select
    End Sub
End Class
