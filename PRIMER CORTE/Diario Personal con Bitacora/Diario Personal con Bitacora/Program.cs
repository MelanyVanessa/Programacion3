using System;
using System.IO;

namespace Diario_Personal_con_Bitacora
{
    internal class Program
    {


        string Diario = "Diario.txt";
        static void Main(string[] args)
        {
            
        }




        public void mostrar_menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bienvenido a tu diario personal con bitácora.");
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1. Agregar entrada");
            Console.WriteLine("2. Ver entradas");
            Console.WriteLine("2. Salir");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    AgregarEntrada();
                    break;
                case "2":
                    VerEntradas();
                    break;
                case "3":
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                    break;
            }
        }


        public void VerEntradas()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string Diario = "Diario.txt";
            if (File.Exists(Diario))
            {
                string[] lineas = File.ReadAllLines(Diario);
                Console.WriteLine("Entradas del diario:");
                foreach (string linea in lineas)
                {
                    Console.WriteLine(linea);
                }
            }
            else
            {
                Console.WriteLine("No hay entradas en el diario.");
            }
        }


        public void AgregarEntrada()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bienvenido a tu diario personal con bitácora.");
            Console.WriteLine("Por favor, ingresa tu nombre:");
            string nombre = Console.ReadLine();

            DateTime fecha = DateTime.Now;
            Console.WriteLine("Hola " + nombre + ", hoy es " + fecha.ToString("dd/MM/yyyy") + ". ¿Cómo te sientes hoy?");
            string estado = Console.ReadLine();

            string Diario = "Diario.txt";


            string linea = $"[{fecha}] - USUARIO: {nombre}: {estado}";

            File.AppendAllText(Diario, linea + Environment.NewLine);

            Console.WriteLine("Tu entrada ha sido guardada en el diario.");
        }

        public void Ejemplos()
        {
            
        }


    }
}

