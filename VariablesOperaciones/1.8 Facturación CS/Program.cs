using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_Facturación_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreArt;

            decimal costo, utilidadP, utilidad, precioVenta, calculoImpuesto;

            utilidadP = 1.5M;

            const decimal impuesto = 0.21M;

            Console.WriteLine("Ingresar nombre de articulo: ");
            nombreArt = Console.ReadLine();

            Console.WriteLine("Ingresar costo del articulo: ");
            costo = Convert.ToDecimal(Console.ReadLine());

            utilidad = costo * utilidadP;

            precioVenta = costo + utilidad;

            calculoImpuesto = precioVenta * impuesto;

            precioVenta += calculoImpuesto;

            Console.WriteLine("Articulo: " + nombreArt);
            Console.WriteLine("Costo: " + costo);
            Console.WriteLine("Utilidad: " + utilidad);
            Console.WriteLine("Impuesto: " + calculoImpuesto);
            Console.WriteLine("Precio de venta: " + precioVenta);
        }
    }
}
