Module Facturacion

    Sub Main()

        Dim nombreArt As String

        Dim costo, utilidadP, utilidad, precioVenta, calculoImpuesto As Decimal

        utilidadP = 1.5

        Const impuesto As Decimal = 0.21

        Console.WriteLine("Ingresar nombre de articulo: ")
        nombreArt = Console.ReadLine()

        Console.WriteLine("Ingresar costo del articulo: ")
        costo = Console.ReadLine()

        utilidad = costo * utilidadP

        precioVenta = costo + utilidad

        calculoImpuesto = precioVenta * impuesto

        precioVenta += calculoImpuesto

        Console.WriteLine("Articulo: " & nombreArt)
        Console.WriteLine("Costo: " & costo)
        Console.WriteLine("Utilidad: " & utilidad)
        Console.WriteLine("Impuesto: " & calculoImpuesto)
        Console.WriteLine("Precio de venta: " & precioVenta)

    End Sub

End Module
