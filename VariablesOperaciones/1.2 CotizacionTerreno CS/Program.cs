using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_CotizacionTerreno_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal ancho, longitud, costo_metro, calculo;

            Console.WriteLine("Ingresar ancho de terreno: ");
            ancho = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Longitud en metros: ");
            longitud = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresar costo del metro cuadrado: ");
            costo_metro = Convert.ToDecimal(Console.ReadLine());

            calculo = Convert.ToDecimal(ancho * longitud) * costo_metro;

            Console.WriteLine("El costo del terreno es de: " + calculo);

        }
    }
}
