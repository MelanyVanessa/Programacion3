using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos.Ejercicios
{
    internal class ControldeAforoenEventos
    {
        public static void Ejecutar()
        {
            const int aforoMaximo = 50;

            // Preguntar cuántas personas quieren entrar
            Console.Write("¿Cuántas personas desean entrar a la discoteca? ");
            int personasEntrando = int.Parse(Console.ReadLine());

            Console.WriteLine("\n====================================");

            if (personasEntrando <= aforoMaximo)
            {
                Console.WriteLine($"¡Bienvenidos! Hay espacio para {personasEntrando} personas.");
                Console.WriteLine($"Aún quedan {aforoMaximo - personasEntrando} cupos disponibles.");
            }
            else
            {
                int exceso = personasEntrando - aforoMaximo;
                Console.WriteLine("Lo sentimos, no hay suficiente espacio.");
                Console.WriteLine($"Deben salir {exceso} personas para que puedan entrar todos.");
            }

            Console.WriteLine("====================================");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();

        }

    }
}
