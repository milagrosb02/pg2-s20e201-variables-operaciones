using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_EquivalenciasHoras_CS
{
    class Program
    {
        static void Main(string[] args)
        {
          
            const byte minutos = 60;

            ushort horas;

            const float horas_porDia = 24;

            const ushort segundos = 3600;


            Console.WriteLine("Ingresar numero de horas: ");
            horas = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Equivalente en minutos: " + horas * minutos);
            Console.WriteLine("Equivalente en segundos: " + horas * segundos);
            Console.WriteLine("Equivalente en dias: " + horas / horas_porDia);
        }
    }
}
