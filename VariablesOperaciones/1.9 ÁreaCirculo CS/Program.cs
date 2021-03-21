using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_ÁreaCirculo_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio;

            Console.WriteLine("Ingresar radio de un circulo: ");
            radio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El área del circulo es de: " + (Math.PI * Math.Pow(radio, 2)));
        }
    }
}
