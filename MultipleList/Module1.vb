Module Module1
    Sub multiple(x, y)
        Dim product As Integer
        product = x * y
        'VB可以自动将int转换为string，使用&运算符与字符串连接'
        Console.Write(x & "*" & y & "=" & product & " ")
    End Sub
    Sub Main()
        Dim i, j As Integer
        For i = 1 To 9
            For j = 1 To i
                multiple(i, j)
                '进行换行'
                If j = i Then
                    Console.Write(vbCrLf)
                End If
            Next
        Next
        Console.ReadLine()
    End Sub

End Module
