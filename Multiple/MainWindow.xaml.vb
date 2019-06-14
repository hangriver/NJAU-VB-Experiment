Class MainWindow
    Dim str As String
    Sub MultipleList() Handles Box.Loaded
        Dim i, j As Integer
        str = ""
        For i = 1 To 9
            For j = 1 To i
                multiple(i, j)
                '进行换行'
                If j = i Then
                    str = str & vbCrLf
                End If
            Next
        Next
        Box.Text = str
    End Sub
    Sub multiple(x, y)
        Dim product As Integer
        product = x * y
        'VB可以自动将int转换为string，使用&运算符与字符串连接'
        str = str & y & "*" & x & "=" & product & " "
    End Sub
End Class
