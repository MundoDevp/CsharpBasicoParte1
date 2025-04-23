using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AppConcursoProgramacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] equipos = new string[5];
            int[] puntajesTotales = new int[5];
            int[,] puntosPorEquipo = new int[5, 5];
            int opSeleccionada=0;
            string opcionesMenu = "****Bievenidos al AppCoPro****";
            opcionesMenu += "\n 1. Registrar equipos.";
            opcionesMenu += "\n 2. Equipos registrados.";
            opcionesMenu += "\n 3. Calificar ejercicios.";
            opcionesMenu += "\n 4. Puntajes por equipo.";
            opcionesMenu += "\n 5. Puntajes totales por equipo.";
            opcionesMenu += "\n 6. Mostrar Ganador.";
            opcionesMenu += "\n 7. Salir.";

            while (opSeleccionada != -1)
            {
                Console.WriteLine(opcionesMenu);
                opSeleccionada = int.Parse(Console.ReadLine());
                switch (opSeleccionada)
                {
                    case 1:
                        LlenarNombresEquipo(equipos);
                        break;
                    case 2:
                        ImprimirEquipos(equipos);
                        break;
                    case 3:
                        CalificarEjercicios(puntosPorEquipo);
                        break;
                    case 4:
                        ImprimirPuntajes(puntosPorEquipo, equipos);
                        break;
                    case 5:
                        CalPuntajesPorEquipo(puntosPorEquipo, puntajesTotales);
                        ImprimirPuntajesTotales(equipos, puntajesTotales);
                        break;
                    case 6:
                        MostrarGanador(equipos, puntajesTotales);
                        break;

                    case 7:
                        opSeleccionada = -1;
                        break;
                }

            }



        }

       

        public static void LlenarNombresEquipo(string[] equipos)
        {
            for (int i = 0; i < equipos.Length; i++)
            {
                Console.WriteLine($"Ingresar nombre del equipo {i+1}");
                equipos[i] = Console.ReadLine();
            }
        }

        public static void ImprimirEquipos(string[] equipos)
        {
            Console.WriteLine("---Equipos Registrados al concurso---");
            for(int i = 0;  i < equipos.Length; i++)
            {
                Console.WriteLine($"{i+1}. {equipos[i]}.");
            }
        }

        private static void CalificarEjercicios(int[,] puntosPorEquipo)
        {
            Random puntaje = new Random();

            for (int i = 0; i < puntosPorEquipo.GetLength(0); i++)
            {
                for (int j = 0; j < puntosPorEquipo.GetLength(1); j++)
                {
                    puntosPorEquipo[i, j] = puntaje.Next(0, 101);
                }
            }
        }

        public static void ImprimirPuntajes(int[,] puntosPorEquipo, string[]equipos)
        {
            for (int i = 0; i < puntosPorEquipo.GetLength(0); i++)
            {
                Console.Write($"{i+1}. {equipos[i]}\t---> ");
                for (int j = 0; j < puntosPorEquipo.GetLength(1); j++)
                {
                    Console.Write($"{puntosPorEquipo[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void CalPuntajesPorEquipo(int[,] puntosPorEquipo, int[] puntajesTotales)
        {
            for (int i = 0; i < puntosPorEquipo.GetLength(0); i++)
            {
                int puntos = 0;
                for(int j = 0; j < puntosPorEquipo.GetLength(1); j++)
                {
                    puntos += puntosPorEquipo[i, j];
                }
                puntajesTotales[i]= puntos;
            }

        }

        public static void ImprimirPuntajesTotales(string[] equipos, int[] puntajesTotales) 
        {
           
            Console.WriteLine("****Resultados de puntajes totales por equipo****");

            for (int i = 0; i < equipos.Length; i++)
            {
                Console.WriteLine($"{i+1}. {equipos[i]}\t---->  {puntajesTotales[i]}");
            }
        }

        public static void MostrarGanador(string[] equipos,int[] puntajesTotales)
        {
            int indiceGanador = 0;
            int puntajeGanador = puntajesTotales[0];

            for (int i = 1; i < puntajesTotales.Length; i++)
            {
                if (puntajesTotales[i] > puntajeGanador)
                {
                    puntajeGanador = puntajesTotales[i];
                    indiceGanador = i;

                }
            }
            Console.WriteLine("****Ganador del Tercer concurso de programación****");
            Console.WriteLine($"Ganador {equipos[indiceGanador]} con {puntajesTotales[indiceGanador]} puntos.");
            Console.WriteLine("Muchas felicidades, esperamos verlos la siguiente edición.");

        }
    }
}
