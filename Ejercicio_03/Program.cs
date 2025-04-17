using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizacion de variables auxiliares
            float sueldoA = 2500.50F;
            float sueldoB = 3500.35F;
            float sueldoAux = sueldoA;

            sueldoA = sueldoB;
            sueldoB = sueldoAux;

            Console.WriteLine("Sueldo A: " + sueldoA);
            Console.WriteLine("Sueldo B: " + sueldoB);

        }
    }
}
