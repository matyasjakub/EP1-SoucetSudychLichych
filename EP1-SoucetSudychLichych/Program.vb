Module Module1
    Sub Main()
        ' Zjist�me, kolik ��sel chce u�ivatel zadat
        Console.WriteLine("Zadejte po�et ��sel:")
        Dim pocetCisel As Integer = Convert.ToInt32(Console.ReadLine())
        ' Pole pro ulo�en� ��sel
        Dim cisla(pocetCisel - 1) As Integer
        ' Cyklick� zad�v�n� ��sel
        For i As Integer = 0 To pocetCisel - 1
            Dim cislo As Integer
            Do
                Console.WriteLine("Zadejte nez�porn� ��slo " & (i + 1) & ":")
                cislo = Convert.ToInt32(Console.ReadLine())
                If cislo >= 0 Then
                    cisla(i) = cislo
                    Exit Do
                Else
                    Console.WriteLine("Zadan� hodnota mus� b�t nez�porn�. Zkuste to znovu.")
                End If
            Loop
        Next
        ' Vyps�n� zadan�ch ��sel
        Console.WriteLine("Zadali jste n�sleduj�c� ��sla:")
        For Each cislo As Integer In cisla
            Console.WriteLine(cislo)
        Next
        ' Ukon�en� programu
        Console.WriteLine("Stiskn�te libovolnou kl�vesu pro ukon�en� programu.")
        Console.ReadKey()
    End Sub
End Module