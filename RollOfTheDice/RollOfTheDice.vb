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
        For u = 1 To 1000
            currentRoll((RollOneDie(5) + 1) + (RollOneDie(5) + 1)) += 1

        Next
        Console.Write(StrDup(19, " "))
        Console.WriteLine("Roll Of the Dice")

        Console.WriteLine(StrDup(55, "-"))
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
        Console.WriteLine(StrDup(55, "-"))
        Console.ReadLine()
    End Sub
    Function RollOneDie(max As Integer) As Integer
        Dim randomDouble As Double
        Dim randomInteger As Integer
        Randomize(Now.Millisecond)
        randomDouble = System.Math.Floor(CDbl(Rnd() * (max + 1)))
        randomInteger = CInt(randomDouble)
        Return randomInteger
    End Function
End Module