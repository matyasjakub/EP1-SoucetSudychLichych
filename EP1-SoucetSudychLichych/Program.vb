Module Module1
    Sub Main()
        ' Zjistíme, kolik èísel chce uživatel zadat
        Console.WriteLine("Zadejte poèet èísel:")
        Dim pocetCisel As Integer = Convert.ToInt32(Console.ReadLine())
        ' Pole pro uložení èísel
        Dim cisla(pocetCisel - 1) As Integer
        ' Cyklické zadávání èísel
        For i As Integer = 0 To pocetCisel - 1
            Dim cislo As Integer
            Do
                Console.WriteLine("Zadejte nezáporné èíslo " & (i + 1) & ":")
                cislo = Convert.ToInt32(Console.ReadLine())
                If cislo >= 0 Then
                    cisla(i) = cislo
                    Exit Do
                Else
                    Console.WriteLine("Zadaná hodnota musí být nezáporná. Zkuste to znovu.")
                End If
            Loop
        Next
        ' Vypsání zadaných èísel
        Console.WriteLine("Zadali jste následující èísla:")
        For Each cislo As Integer In cisla
            Console.WriteLine(cislo)
        Next
        ' Ukonèení programu
        Console.WriteLine("Stisknìte libovolnou klávesu pro ukonèení programu.")
        Console.ReadKey()
    End Sub
End Module