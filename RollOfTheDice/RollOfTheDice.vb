'Sebastian Soto
'RCET0265
'Fall 2021
'Roll Of The Dice
'https://github.com/SebastianSotoMk4/RollOfTheDice.git
Option Strict On
Option Explicit On
Module RollOfTheDice

    Sub Main()
        Dim randomNumbers(12) As Integer
        Dim firstDieRoll(6) As Integer
        For u = 1 To 6
            firstDieRoll(u) = RollOneDie(6)
            Console.WriteLine(firstDieRoll(u))
        Next
        For u = 1 To 6
            firstDieRoll(u) = RollOneDie(6)
            Console.WriteLine(firstDieRoll(u))
        Next
        For o = LBound(firstDieRoll) To UBound(firstDieRoll)
            Console.Write(CStr(o).PadLeft(4))
        Next

        'For i = 0 To 100
        '    randomNumbers(RollOneDie(6)) += 2

        'Next
        Console.WriteLine()

        For i = LBound(randomNumbers) To UBound(randomNumbers)
            Console.Write(CStr(i).PadLeft(4))
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

    Sub CodeStorage()

        Dim randomNumbers(12) As Integer
        For i = 0 To 100
            randomNumbers(RollOneDie(6)) += 2

        Next

        For i = LBound(randomNumbers) To UBound(randomNumbers)
            Console.Write(CStr(i).PadLeft(4))
        Next
        Console.WriteLine()



    End Sub

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