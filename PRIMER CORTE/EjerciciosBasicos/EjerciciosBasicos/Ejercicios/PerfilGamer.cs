using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos.Ejercicios
{
    public class PerfilGamer
    {
        public static void Ejecutar()
        {
            //Primero solicitamos los datos al usuario
            Console.Write("Por favor ingresa tu Nickname: ");
            string nickname = Console.ReadLine();

            Console.Write("Por favor ingresa tu nivel de experiencia (1-100): ");
            int nivel = int.Parse(Console.ReadLine());

            Console.Write("¿Tienes suscripción Premium? (true/false): ");
            bool premium = bool.Parse(Console.ReadLine());

            // Ahora vamos a crear el mensaje personalizado
            Console.WriteLine("\n====================================");
            Console.WriteLine($"¡Bienvenido {nickname}!");
            Console.WriteLine($"Tu nivel de experiencia es {nivel}.");

            if (premium)
            {
                Console.WriteLine("Gracias por ser usuario Premium. ¡Disfruta de beneficios exclusivos!");
            }
            else
            {
                Console.WriteLine("Considera adquirir Premium para más ventajas en tu aventura gamer.");
            }

            // Clasificación por nivel
            if (nivel <= 20)
            {
                Console.WriteLine("Estás comenzando tu viaje gamer. ¡Sigue practicando!");
            }
            else if (nivel <= 50)
            {
                Console.WriteLine("Ya tienes experiencia sólida. ¡Vas por buen camino!");
            }
            else if (nivel <= 80)
            {
                Console.WriteLine("Eres un jugador avanzado. ¡Impresionante!");
            }
            else
            {
                Console.WriteLine("¡Leyenda gamer! Tu habilidad es extraordinaria.");
            }

            Console.WriteLine("====================================");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();

        }


    }
}
