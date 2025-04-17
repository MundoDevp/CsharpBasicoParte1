using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variables permite el cambio de su valor durante el programa
            byte calificacion;
            bool tareaEntregada;
            calificacion = 8;
            tareaEntregada = true;

            Console.WriteLine("Calificacion: " + calificacion);

            //Cambiando calificacion

            if (tareaEntregada)
            {
                calificacion = 9;
            }
            

            Console.WriteLine("Calificacion: " + calificacion);




        }
    }
}
