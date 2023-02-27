Module Module1
    Sub Main()
        Dim Array() As Integer = {25, 27, 3, 4, 8, 2, 0, 35, 47, 2}
        Call BubbleSort(Array)
    End Sub

    Sub BubbleSort(Array() As Integer)
        Dim Counter, Counter1, Temp, Temp1 As Integer
        Dim Sorted As Boolean

        For Counter1 = 0 To 999
            For Counter = 0 To 8
                Sorted = False
                If Array(Counter) > Array(Counter + 1) Then
                    Temp = Array(Counter)
                    Temp1 = Array(Counter + 1)
                    Array(Counter) = Temp1
                    Array(Counter + 1) = Temp
                    Sorted = True
                End If
            Next
        Next

        Console.WriteLine("Outputing the sorted loop")

        For Counter = 0 To 9
            Console.WriteLine(Array(Counter))
        Next

        Console.ReadLine()
    End Sub

End Module
