Module Module1

    Sub Main()
        Console.Write("Zadejte po�et ��sel, kter� chcete zadat: ")
        Dim pocetCisel As Integer
        While Not Integer.TryParse(Console.ReadLine(), pocetCisel) OrElse pocetCisel <= 0
            Console.WriteLine("Pros�m, zadejte platn� cel� ��slo v�t�� ne� nula.")
            Console.Write("Zadejte po�et ��sel, kter� chcete zadat: ")
        End While

        Dim cisla(pocetCisel - 1) As Integer

        For i As Integer = 0 To pocetCisel - 1
            Console.Write($"Zadejte ��slo {i + 1}: ")
            While Not Integer.TryParse(Console.ReadLine(), cisla(i))
                Console.WriteLine("Pros�m, zadejte platn� cel� ��slo.")
                Console.Write($"Zadejte ��slo {i + 1}: ")
            End While
        Next

        Console.WriteLine("Zadan� ��sla jsou:")
        For Each cislo As Integer In cisla
            Console.WriteLine(cislo)
        Next

        Console.WriteLine("Stiskn�te jakoukoli kl�vesu pro ukon�en�...")
        Console.ReadKey()
    End Sub

End Module