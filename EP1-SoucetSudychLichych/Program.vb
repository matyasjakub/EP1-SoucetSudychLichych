Module Module1
    Sub Main()
        ' Hlavní smyèka programu, která se opakuje, dokud uživatel neukonèí aplikaci zavøením konzolového okna
        While True
            ' Zjistíme, kolik èísel chce uživatel zadat
            Console.WriteLine("Zadejte poèet èísel:")
            Dim pocetCisel As Integer = Convert.ToInt32(Console.ReadLine())
            ' Promìnné pro souèty a poèty sudých a lichých èísel
            Dim soucetSudych As Integer = 0
            Dim soucetLichych As Integer = 0
            Dim pocetSudych As Integer = 0
            Dim pocetLichych As Integer = 0
            ' Cyklické zadávání èísel
            For i As Integer = 0 To pocetCisel - 1
                Dim cislo As Integer
                Do
                    Console.WriteLine("Zadejte nezáporné èíslo " & (i + 1) & ":")
                    cislo = Convert.ToInt32(Console.ReadLine())
                    If cislo >= 0 Then
                        If cislo Mod 2 = 0 Then
                            soucetSudych += cislo
                            pocetSudych += 1
                        Else
                            soucetLichych += cislo
                            pocetLichych += 1
                        End If
                        Exit Do
                    Else
                        Console.WriteLine("Zadaná hodnota musí být nezáporná. Zkuste to znovu.")
                    End If
                Loop
            Next
            ' Vypsání výsledkù
            Console.WriteLine("Souèet sudých èísel: " & soucetSudych)
            Console.WriteLine("Poèet sudých èísel: " & pocetSudych)
            Console.WriteLine("Souèet lichých èísel: " & soucetLichych)
            Console.WriteLine("Poèet lichých èísel: " & pocetLichych)
            ' Upozornìní pro uživatele
            Console.WriteLine("Stisknìte Enter pro nový výpoèet nebo zavøete okno pro ukonèení programu.")
            Console.ReadLine()
        End While
    End Sub
    End Modul