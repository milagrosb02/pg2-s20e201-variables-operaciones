Module EquivalenciasHoras

    Sub Main()

        Dim horas

        Const minutos As Byte = 60

        Const segundos As UShort = 3600

        Const horas_porDia As Byte = 24

        Console.WriteLine("Ingresar numero de horas: ")
        horas = Console.ReadLine()

        Console.WriteLine("Equivalente en minutos: " & horas * minutos)
        Console.WriteLine("Equivalente en segundos: " & horas * segundos)
        Console.WriteLine("Equivalente en dias: " & horas / horas_porDia)

    End Sub

End Module
