Module Module1
    Sub Main()
        ' Zjist�me, kolik ��sel chce u�ivatel zadat
        Console.WriteLine("Zadejte po�et ��sel:")
        Dim pocetCisel As Integer = Convert.ToInt32(Console.ReadLine())
        ' Prom�nn� pro sou�ty sud�ch a lich�ch ��sel
        Dim soucetSudych As Integer = 0
        Dim soucetLichych As Integer = 0
        ' Cyklick� zad�v�n� ��sel
        For i As Integer = 0 To pocetCisel - 1
            Dim cislo As Integer
            Do
                Console.WriteLine("Zadejte nez�porn� ��slo " & (i + 1) & ":")
                cislo = Convert.ToInt32(Console.ReadLine())
                If cislo >= 0 Then
                    If cislo Mod 2 = 0 Then
                        soucetSudych += cislo
                    Else
                        soucetLichych += cislo
                    End If
                    Exit Do
                Else
                    Console.WriteLine("Zadan� hodnota mus� b�t nez�porn�. Zkuste to znovu.")
                End If
            Loop
        Next
        ' Vyps�n� v�sledk�
        Console.WriteLine("Sou�et sud�ch ��sel: " & soucetSudych)
        Console.WriteLine("Sou�et lich�ch ��sel: " & soucetLichych)
        ' Ukon�en� programu
        Console.WriteLine("Stiskn�te libovolnou kl�vesu pro ukon�en� programu.")
        Console.ReadKey()
    End Sub
End Module