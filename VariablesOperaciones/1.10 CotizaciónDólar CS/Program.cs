using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._10_CotizaciónDólar_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cantidad_dolar, cambio;

            Console.WriteLine("Ingresar cantidad de dolares a comprar: ");
            cantidad_dolar = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresar el cambio en pesos: ");
            cambio = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("El costo es de: " + cantidad_dolar * cambio);
        }
    }
}
