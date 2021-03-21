using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Costos_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string descripcion;
            byte numero_unidades;
            decimal costo;

            const decimal costos_materiales = 3.5M;

            const decimal costo_fijo = 10.7M;

            Console.WriteLine("Ingresar descripcion del producto: ");
            descripcion = Console.ReadLine();

            Console.WriteLine("Ingresar numero de unidades producidas: ");
            numero_unidades = Convert.ToByte(Console.ReadLine());

            costo = Convert.ToDecimal((numero_unidades * costos_materiales) + costo_fijo);

            Console.WriteLine("Producto: " + descripcion);
            Console.WriteLine("Unidades producidas: " + numero_unidades);
            Console.WriteLine("El costo de producción del articulo es de: " + costo);
        }
    }
}
