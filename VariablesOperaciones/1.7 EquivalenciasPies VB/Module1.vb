Module EquivalenciaPies

    Sub Main()

        Dim distanciaPie, pulgada, yarda, centimetro, metro As Double

        Console.WriteLine("Ingresar medida en pie: ")
        distanciaPie = Console.ReadLine()

        pulgada = distanciaPie * 12

        yarda = distanciaPie / 3

        centimetro = pulgada * 2.54

        metro = centimetro / 100

        Console.WriteLine("Equivalente en pulgadas: " & pulgada)
        Console.WriteLine("Equivalente en yardas: " & yarda)
        Console.WriteLine("Equivalente en cms: " & centimetro)
        Console.WriteLine("Equivalente en mts: " & metro)

    End Sub

End Module
