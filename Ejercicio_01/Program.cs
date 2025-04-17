using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipos de datos--> Enteros : int,long, short, byte
            //Coma flotante o con decimale: float, decimal y double
            //char boolean 
            //Tipos de datos de no primitivos-> son objetos
            //string, arreglos, listas, pilas, colas

            //Declaracion de variables--> tipo_Dato nombre-> declaracion;
            //Definir varibles tipo_dato  nombre = valor;


            long matricula = 100001;
            string nombre = "Roberto";
            string apellido = "Gonzales";
            byte edad = 28;
            char genero = 'M';

            //Impresion de las variables
            Console.WriteLine("Matricula: " + matricula);
            Console.WriteLine("Nombre: " + nombre + " " + apellido);            
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Genero: " + genero);
            Console.ReadKey();//Consola se visualize hasta pulsar tecla




        }
    }
}
