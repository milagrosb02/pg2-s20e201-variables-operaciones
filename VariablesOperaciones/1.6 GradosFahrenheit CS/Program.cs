using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_GradosFahrenheit_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp_celsius;

            Console.WriteLine("Ingresar temperatura en Celsius: ");
            temp_celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("F: " + (temp_celsius * 9 / 5) + 32);
        }
    }
}
