using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
                Console.WriteLine("============= MENU =============");
                Console.WriteLine("1. Simulador de Cajero Automatico");
                Console.WriteLine("2. Control de Inventario");
                Console.WriteLine("3. Calculadora de calificaciones");
                Console.WriteLine("4. Salir");
    
                int opcion;
                do
                {
                    Console.Write("\nSeleccione una opción: ");
                    opcion = int.Parse(Console.ReadLine());
    
                    switch (opcion)
                    {
                        case 1:
                            Silmulador_de_Cajero_Automatico.Ejecutar();
                        break;
                        case 2:
                            Control_de_Inventario.Ejecutar();
                        break;
                        case 3:
                            Calculadora_de_Calificaciones.Ejecutar();
                            break;
                        case 4:
                            Console.WriteLine("Gracias por usar el programa.");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                } while (opcion != 4);
        }
    }
}
