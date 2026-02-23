using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos.Ejercicios
{
    internal class CalculadoraDePropinasSolidarias
    {
        public static void Ejecutar()
        {
            // Solicitar el total de la cuenta
            Console.Write("Ingrese el total de la cuenta: ");
            double totalCuenta = double.Parse(Console.ReadLine());

            // Solicitar porcentaje de propina
            Console.Write("Ingrese el porcentaje de propina (10, 15 o 20): ");
            int porcentajePropina = int.Parse(Console.ReadLine());

            // Calcular propina y total
            double propina = totalCuenta * porcentajePropina / 100;
            double totalConPropina = totalCuenta + propina;

            // Mostrar resultados
            Console.WriteLine("\n====================================");
            Console.WriteLine($"Total de la cuenta: ${totalCuenta:N0}");
            Console.WriteLine($"Propina ({porcentajePropina}%): ${propina:N0}");
            Console.WriteLine($"Total a pagar: ${totalConPropina:N0}");

            // Mensaje solidario
            if (totalConPropina > 100000)
            {
                Console.WriteLine("¡Gracias por tu generosidad! Tu aporte hace la diferencia.");
            }
            else
            {
                Console.WriteLine("Gracias por apoyar con tu propina.");
            }
            Console.WriteLine("====================================");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
