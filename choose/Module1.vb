Module Module1

    Sub Main()
        Dim x, y As Double
        x = Console.ReadLine
        If x >= 0 Then
            y = x ^ 2 - 1
        ElseIf x < 0 Then
            y = 2 * x ^ 3 - x + 1
        End If
        Console.WriteLine(y)
        Main()
    End Sub

End Module
