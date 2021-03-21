Module VelocidadDeLaLuz

    Sub Main()

        Const c As ULong = 300000

        Dim tiempo As Double

        Console.WriteLine("Ingresar tiempo en segundos: ")
        tiempo = Console.ReadLine()

        Console.WriteLine("La distancia que recorre la luz es de: " & c * tiempo)

    End Sub

End Module
