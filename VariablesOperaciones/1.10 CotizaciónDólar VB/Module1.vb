Module CotizaciónDólar

    Sub Main()

        Dim cantidad_dolar, cambio As Decimal

        Console.WriteLine("Ingresar cantidad de dolares a comprar: ")
        cantidad_dolar = Console.ReadLine()

        Console.WriteLine("Ingresar el cambio en pesos: ")
        cambio = Console.ReadLine()

        Console.WriteLine("El costo es de: " & cantidad_dolar * cambio)

    End Sub

End Module
