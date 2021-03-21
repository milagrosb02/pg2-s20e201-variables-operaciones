Module AreaCirculo

    Sub Main()

        Dim radio As Single

        Console.WriteLine("Ingresar radio de un circulo: ")
        radio = Console.ReadLine()

        Console.WriteLine("El área del circulo es de: " & (Math.PI * Math.Pow(radio, 2)))

    End Sub

End Module
