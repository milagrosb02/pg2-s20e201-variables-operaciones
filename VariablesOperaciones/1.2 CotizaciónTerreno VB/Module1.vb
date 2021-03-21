Module CotizacionTerreno

    Sub Main()

        Dim ancho, longitud, costo_metro, calculo As Decimal

        Console.WriteLine("Ingresar ancho de terreno: ")
        ancho = Console.ReadLine()

        Console.WriteLine("Longitud en metros: ")
        longitud = Console.ReadLine()

        Console.WriteLine("Ingresar costo del metro cuadrado: ")
        costo_metro = Console.ReadLine()

        calculo = (ancho * longitud) * costo_metro

        Console.WriteLine("El costo del terreno es de: " & calculo)

    End Sub

End Module
