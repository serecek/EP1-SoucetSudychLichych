Imports System

Module Module1

    Sub Main()
        Dim pocetCisel As Integer
        Dim cisla(pocetCisel - 1) As Integer

        Console.WriteLine("Zadejte po�et ��sel, kter� chcete zadat:")
        pocetCisel = Integer.Parse(Console.ReadLine())

        For i As Integer = 0 To pocetCisel - 1
            Console.WriteLine("Zadejte ��slo {0}:", i + 1)
            cisla(i) = Integer.Parse(Console.ReadLine())
        Next

        Console.WriteLine("Zadan� ��sla jsou:")

        For Each cislo As Integer In cisla
            Console.WriteLine(cislo)
        Next
        Console.WriteLine("Stiskn�te libovolnou kl�vesu pro ukon�en� programu.")
        Console.ReadKey()

    End Sub

End Module