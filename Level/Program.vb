Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Please input score:")
        Dim score As Double
        Dim word As String
        word = "Your level is: "
        score = Console.ReadLine()
        Select Case score
            Case >= 90
                Console.WriteLine(word + "A")
            Case 80 <= score <= 90
                Console.WriteLine(word + "B")
            Case 60 <= score <= 80
                Console.WriteLine(word + "C")
            Case <= 60
                Console.WriteLine(word + "F")
        End Select
    End Sub
End Module
