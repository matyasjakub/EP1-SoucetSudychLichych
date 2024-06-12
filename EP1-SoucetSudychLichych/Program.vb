Module Module1
    Sub Main()
        ' Hlavn� smy�ka programu, kter� se opakuje, dokud u�ivatel neukon�� aplikaci zav�en�m konzolov�ho okna
        While True
            ' Zjist�me, kolik ��sel chce u�ivatel zadat
            Console.WriteLine("Zadejte po�et ��sel:")
            Dim pocetCisel As Integer = Convert.ToInt32(Console.ReadLine())
            ' Prom�nn� pro sou�ty a po�ty sud�ch a lich�ch ��sel
            Dim soucetSudych As Integer = 0
            Dim soucetLichych As Integer = 0
            Dim pocetSudych As Integer = 0
            Dim pocetLichych As Integer = 0
            ' Cyklick� zad�v�n� ��sel
            For i As Integer = 0 To pocetCisel - 1
                Dim cislo As Integer
                Do
                    Console.WriteLine("Zadejte nez�porn� ��slo " & (i + 1) & ":")
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
                        Console.WriteLine("Zadan� hodnota mus� b�t nez�porn�. Zkuste to znovu.")
                    End If
                Loop
            Next
            ' Vyps�n� v�sledk�
            Console.WriteLine("Sou�et sud�ch ��sel: " & soucetSudych)
            Console.WriteLine("Po�et sud�ch ��sel: " & pocetSudych)
            Console.WriteLine("Sou�et lich�ch ��sel: " & soucetLichych)
            Console.WriteLine("Po�et lich�ch ��sel: " & pocetLichych)
            ' Upozorn�n� pro u�ivatele
            Console.WriteLine("Stiskn�te Enter pro nov� v�po�et nebo zav�ete okno pro ukon�en� programu.")
            Console.ReadLine()
        End While
    End Sub
    End Modul