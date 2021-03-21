Module Cuadratica

    Sub Main()

        Dim a, b, c, x As Byte
        a = 1
        b = 5
        c = 2

        x = ((b * b) - (4 * a * c)) / (2 * a)

        Console.WriteLine("A: " & a)
        Console.WriteLine("B: " & b)
        Console.WriteLine("C: " & c)
        Console.WriteLine("El resultado de la ecuacion es: " & x)

    End Sub

End Module
