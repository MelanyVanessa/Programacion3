using EjerciciosBasicos.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();

                Console.WriteLine("========MENU PRINCIPAL=======");
                Console.WriteLine("1. Perfil Gamer");
                Console.WriteLine("2. Calculadora de propinas solidarias");
                Console.WriteLine("3. Control de Aforo en Eventos");
                Console.WriteLine("4. Generador de Correos Corporativos");
                Console.WriteLine("5. Simulador de Semáforo Inteligente");
                Console.WriteLine("0. Salir");
                Console.WriteLine("============================");

                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = -1;
                }
                Console.Clear();


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Elegiste: Perfil Gamer");
                        PerfilGamer.Ejecutar();
                        break;
                    case 2:

                        Console.WriteLine("Elegiste: Calculadora de propinas solidarias");
                        CalculadoraDePropinasSolidarias.Ejecutar();
                        break;

                    case 3:
                        Console.WriteLine("Elegiste: Control de Aforo en Eventos");
                        ControldeAforoenEventos.Ejecutar();
                        break;

                    case 4:
                        Console.WriteLine("Elegiste: Generador de Correos Corporativos");
                        GeneradordeCorreosCorporativos.Ejecutar();
                        break;
                    case 5:
                        Console.WriteLine("Elegiste: Simulador de Semáforo Inteligente");
                        SimuladordeSemáforoInteligente.Ejecutar();
                        break;

                    case 6:
                        Console.WriteLine("elegiste: Salir");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                        break;
                }







            } while (opcion != 0);




        }
    }
}
