Module Costos

    Sub Main()

        Dim descripcion As String
        Dim numero_unidades As Byte
        Dim costo As Decimal

        Const costos_materiales As Decimal = 3.5

        Const costo_fijo As Decimal = 10.7

        Console.WriteLine("Ingresar nombre de articulo: ")
        descripcion = Console.ReadLine()

        Console.WriteLine("Ingresar numero de unidades producidas: ")
        numero_unidades = Console.ReadLine()

        costo = (numero_unidades * costos_materiales) + costo_fijo

        Console.WriteLine("Producto: " & descripcion)
        Console.WriteLine("Unidades producidas: " & numero_unidades)
        Console.WriteLine("El costo de producción del articulo es de: " & costo)
    End Sub

End Module
