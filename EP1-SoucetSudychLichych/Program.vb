Module Module1

    Sub Main()
        Console.Write("Zadejte poèet èísel, která chcete zadat: ")
        Dim pocetCisel As Integer
        While Not Integer.TryParse(Console.ReadLine(), pocetCisel) OrElse pocetCisel <= 0
            Console.WriteLine("Prosím, zadejte platné celé èíslo vìtší než nula.")
            Console.Write("Zadejte poèet èísel, která chcete zadat: ")
        End While

        Dim cisla(pocetCisel - 1) As Integer

        For i As Integer = 0 To pocetCisel - 1
            Console.Write($"Zadejte èíslo {i + 1}: ")
            While Not Integer.TryParse(Console.ReadLine(), cisla(i))
                Console.WriteLine("Prosím, zadejte platné celé èíslo.")
                Console.Write($"Zadejte èíslo {i + 1}: ")
            End While
        Next

        Console.WriteLine("Zadaná èísla jsou:")
        For Each cislo As Integer In cisla
            Console.WriteLine(cislo)
        Next

        Console.WriteLine("Stisknìte jakoukoli klávesu pro ukonèení...")
        Console.ReadKey()
    End Sub

End Module