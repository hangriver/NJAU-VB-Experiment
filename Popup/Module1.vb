Module Module1

    Sub Main()
        '时间作为随机数算子'
        Randomize(Timer)
        Dim a(9), i, j, tmp As Integer
        'For循环生成随机数组'
        For i = 0 To 9
            a(i) = Int(Rnd() * 100 + 1)
        Next
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
        '输出'
        For i = 0 To 9
            Console.WriteLine(a(i))
        Next
        Console.ReadLine() '保持窗口'
    End Sub

End Module
