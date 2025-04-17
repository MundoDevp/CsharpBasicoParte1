using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valor1, valor2;
            float resta;

            Console.WriteLine("ingresar primer valor:");
            valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar segundo valor:");
            valor2 = float.Parse(Console.ReadLine());

            resta = valor1 - valor2;//Asignacion desde una expresion, metodo..

            Console.WriteLine($"La suma de {valor1} + {valor2} = {valor1+valor2}");
            Console.WriteLine($"La resta de {valor1} - {valor2} = {resta}");
            Console.WriteLine("La multiplicacion de " + valor1 + " * "+ valor2 + " = " + (valor1 * valor2));
            Console.WriteLine($"La division de {valor1} + {valor2} = {valor1 / valor2}");


        }
    }
}
