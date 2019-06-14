Imports System

Module Program
    Sub Main(args As String())
        Randomtime
        Dim a(9), i As Integer
        For i = 0 To 10
            a(i) = rnd() * (100 - 1 + 1) + 1
            Console.WriteLine(a(i))
        Next
    End Sub
End Module
