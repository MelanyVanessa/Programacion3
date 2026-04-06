using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_POO
{
    internal class Calculadora_de_Calificaciones
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== Bienvenido a Nuestra Calculadora de Calificaciones ===");

            Console.WriteLine("por favor ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("por favor ingrese el nombre de la materia");
            string materia = Console.ReadLine();

            Console.WriteLine("por favor ingrese la primera calificación");
            double calificacion1 = double.Parse(Console.ReadLine());

            Console.WriteLine("por favor ingrese la segunda calificación");
            double calificacion2 = double.Parse(Console.ReadLine());

            Console.WriteLine("por favor ingrese la tercera calificación");
            double calificacion3 = double.Parse(Console.ReadLine());

            double R = (calificacion1 + calificacion2 + calificacion3) / 3;

            Console.WriteLine("=== Resultados ===");
            Console.WriteLine($"el promedio del estudiante {nombre} es: {R} ");
            
            
            if ( R >= 3.0 )
            {
                Console.WriteLine($"el estudiante {nombre} aprobó la materia de { materia}");
            }
            else
            {
                Console.WriteLine($"el estudiante {nombre} reprobó la materia de { materia} ");
            }
        }
    }
}
