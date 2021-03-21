using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5_Cuadratica_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a, b, c, x;
            a = 1;
            b = 5;
            c = 2;

            x = Convert.ToByte(((b * b) - (4 * a * c)) / (2 * a));

            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);
            Console.WriteLine("C: " + c);
            Console.WriteLine("El resultado de la ecuacion es: " + x);
        }
    }
}
