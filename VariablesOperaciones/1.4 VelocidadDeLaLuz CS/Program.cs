using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_VelocidadDeLaLuz_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            const long c = 300000;

            double tiempo;

            Console.WriteLine("Ingresar tiempo en segundos: ");
            tiempo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("La distancia que recorre la luz es de: " + c * tiempo);

        }
    }
}
