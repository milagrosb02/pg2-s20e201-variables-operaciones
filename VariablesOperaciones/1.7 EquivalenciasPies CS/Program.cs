using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_EquivalenciasPies_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanciaPie, pulgada, yarda, centimetro, metro;

            Console.WriteLine("Ingresar medida en pie: ");
            distanciaPie = Convert.ToDouble(Console.ReadLine());

            pulgada = distanciaPie * 12;

            yarda = distanciaPie / 3;

            centimetro = pulgada * 2.54;

            metro = centimetro / 100;

            Console.WriteLine("Equivalente en pulgadas: " + pulgada);
            Console.WriteLine("Equivalente en yardas: " + yarda);
            Console.WriteLine("Equivalente en cms: " + centimetro);
            Console.WriteLine("Equivalente en mts: " + metro);
        }
    }
}
