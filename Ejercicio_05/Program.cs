using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal  sueldoTotal;//Notacion de camello _---_
            byte diasTrabajados;
            const decimal COSTO_DIA = 23.5M;//Valor que no cambia una ves asignado

            Console.WriteLine("Ingresar las Dias trabajados:");
            diasTrabajados = byte.Parse(Console.ReadLine());

            sueldoTotal = diasTrabajados * COSTO_DIA;

            Console.WriteLine("Sueldo Total: " + sueldoTotal);


        }
    }
}
