'Sebastian Soto
'RCET0265
'Fall 2021
'Roll Of The Dice
'https://github.com/SebastianSotoMk4/RollOfTheDice.git
Option Strict On
Option Explicit On
Module RollOfTheDice
    Sub Main()
        Dim currentRoll(12) As Integer
        Dim linePrint As Integer
        'Two Random numbers between 1 and 6 and added together and corresponding Array variable is incremented by 1
        For i = 1 To 1000
            currentRoll((RollOneDie(5)) + (RollOneDie(5))) += 1
        Next
        Console.Write(StrDup(19, " "))
        Console.WriteLine("Roll Of the Dice")
        Console.WriteLine(StrDup(55, "="))
        For i = LBound(currentRoll) To UBound(currentRoll)
            linePrint += 1
            If linePrint > 2 Then
                Console.Write(CStr(i).PadLeft(4) & "|")
            End If
        Next
        Console.WriteLine()
        Console.WriteLine(StrDup(55, "-"))
        For i = LBound(currentRoll) To UBound(currentRoll)
            Select Case currentRoll(i)
                Case = 0
                    'If 0 then do nothing
                Case <> 0
                    Console.Write(CStr(currentRoll(i)).PadLeft(4) & "|")
            End Select
        Next
        Console.WriteLine()
        Console.WriteLine(StrDup(55, "="))
        Console.ReadLine()
    End Sub
    'The RollOneDie() function will return a random number between 1 and a maximum inputed number 
    'Example, RollOneDie(10) will return a number between 1 and 10
    Function RollOneDie(max As Integer) As Integer
        Dim randomDouble As Double
        Dim randomInteger As Integer
        Randomize(Now.Millisecond)
        'This random Numbeer will round down to a whole number
        randomDouble = System.Math.Floor(CDbl(Rnd() * (max + 1)))
        randomInteger = CInt(randomDouble)
        '1 is added to the number to prevent 0's
        randomInteger += 1
        Return randomInteger
    End Function
End Module