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

        For u = 1 To 1000
            currentRoll((RollOneDie(5) + 1) + (RollOneDie(5) + 1)) += 1

        Next

        Console.WriteLine()

        For i = LBound(currentRoll) To UBound(currentRoll)
            Console.Write(CStr(i).PadLeft(4))
        Next

        Console.WriteLine()

        For i = LBound(currentRoll) To UBound(currentRoll)
            Console.Write(CStr(currentRoll(i)).PadLeft(4))
        Next

        Console.ReadLine()

    End Sub
    Function RollOneDie(max As Integer) As Integer
        Dim rndNum As Double
        Dim NumRnd As Integer
        Randomize(Now.Millisecond)
        rndNum = System.Math.Floor(CDbl(Rnd() * (max + 1)))
        NumRnd = CInt(rndNum)
        Return NumRnd
    End Function



    Sub TestRandom()
        Dim randomNumbers(6) As Integer

        For i = 0 To 10000

            randomNumbers(RollOneDie(6)) += 1
        Next

        For i = LBound(randomNumbers) To UBound(randomNumbers)
            Console.Write(CStr(i).PadLeft(7))
        Next
        Console.WriteLine()
        Console.WriteLine(StrDup(80, "-"))


        For i = LBound(randomNumbers) To UBound(randomNumbers)
            Console.Write(CStr(randomNumbers(i)).PadLeft(7))
        Next
    End Sub
End Module
'https://elearn.isu.edu/moodle/mod/assign/view.php?id=2180759