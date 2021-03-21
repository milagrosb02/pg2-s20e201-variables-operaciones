Module GradosFarenheit

    Sub Main()

        Dim temp_celsius As Double

        Console.WriteLine("Ingresar temperatura en Celsius: ")
        temp_celsius = Console.ReadLine()

        Console.WriteLine("F: " & (temp_celsius * 9 / 5) + 32)

    End Sub

End Module
