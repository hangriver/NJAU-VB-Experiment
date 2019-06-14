Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        '时间作为随机数算子'
        Randomize(Timer)
        Dim a(9), i, j, tmp As Integer
        Dim str1, str2 As String
        'For循环生成随机数组'
        str1 = ""
        For i = 0 To 9
            a(i) = Int(Rnd() * 100 + 1)
            str1 = str1 & a(i) & " "
        Next
        Random.Text = str1
        '冒泡排序'
        For i = 0 To 9
            For j = 0 To 8
                If a(j) >= a(j + 1) Then
                    tmp = a(j)
                    a(j) = a(j + 1)
                    a(j + 1) = tmp
                End If
            Next
        Next
        '生成输出字符串'
        str2 = ""
        For i = 0 To 9
            str2 = str2 & a(i) & " "
        Next
        Arranged.Text = str2 '输出'
    End Sub
End Class
