using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos.Ejercicios
{
    internal class SimuladordeSemáforoInteligente
    {
        public static void Ejecutar()
        {
            // Solicitamos el color actual del semáforo
            Console.Write("Ingrese el color actual del semáforo por favor seleccione entre: (Verde, Amarillo, Rojo) " +
                ": ");
            string color = Console.ReadLine().ToLower();

            Console.WriteLine("\n=============================================0");

            // Evaluamos el color ingresado
            switch (color)
            {
                case "verde":
                    Console.WriteLine("Sigue adelante");
                    break;

                case "amarillo":
                    Console.WriteLine("Prepárate para frenar");
                    break;

                case "rojo":
                    Console.WriteLine("¡Detente!");
                    break;

                default:
                    Console.WriteLine("Color inválido. Por favor ingrese Verde, Amarillo o Rojo.");
                    break;
            }

            Console.WriteLine("====================================");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
