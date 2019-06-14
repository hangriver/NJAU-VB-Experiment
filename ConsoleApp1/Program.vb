Imports System

Module Program
    Sub Main(args As String())
        Dim x, y, remainder, tmp As Integer
        Console.WriteLine("Input x:")
        x = Console.ReadLine
        Console.WriteLine("Input y:")
        y = Console.ReadLine
        tmp = y
        Do
            Console.WriteLine(remainder)
            remainder = x Mod tmp
            x = tmp
            tmp = remainder
        Loop Until remainder = 0
        Console.WriteLine(x)
    End Sub
End Module
