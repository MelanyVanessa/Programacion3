using System;
using System.IO;

namespace Ferreteria_Pro
{
    internal class Program
    {
        static string ruta = "stock.csv";

        static void Main(string[] args)
        {
            MostrarMenu();
            Ejecutar();
        }

        // funcion para crear nueva herramienta
        public static void Crear()
        {
            Console.WriteLine("Has escogido agregar una nueva herramienta");

            Console.Write("Por favor ingresa el Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Por favor ingresa la descripción: ");
            string descripcion = Console.ReadLine();

            Console.Write("Por favor ingresa el precio: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Por favor ingrese el Tipo (Manual-Electrica-Medicion): ");
            string tipoStr = Console.ReadLine();

            string linea = $"{id};{descripcion};{precio};{tipoStr}";
            File.AppendAllText(ruta, linea + Environment.NewLine);

            Console.WriteLine("herramienta agregada correctamente.");
        }

        // funcion para listar herramientas
        public static void Leer()
        {
            Console.WriteLine("lista de productos disponibles:");
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    Console.WriteLine(linea);
                }
            }
            else
            {
                Console.WriteLine("No hay herramientas registradas.");
            }
        }

        // funcion para actualizar una herramienta
        public static void Actualizar()
        {
            Console.Write("Ingrese el Id de la herramienta a actualizar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                bool encontrado = false;

                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] datos = lineas[i].Split(';');
                    if (int.Parse(datos[0]) == id)
                    {
                        Console.Write("Nueva descripción: ");
                        datos[1] = Console.ReadLine();

                        Console.Write("Nuevo precio: ");
                        datos[2] = Console.ReadLine();

                        Console.Write("Nuevo tipo (Manual-Electrica-Medicion): ");
                        datos[3] = Console.ReadLine();

                        lineas[i] = string.Join(";", datos);
                        encontrado = true;
                        break;
                    }
                }

                File.WriteAllLines(ruta, lineas);

                if (encontrado)
                    Console.WriteLine("Herramienta actualizada correctamente.");
                else
                    Console.WriteLine("Herramienta no encontrada.");
            }
        }

        // funcion para eliminar una herramienta
        public static void Eliminar()
        {
            Console.Write("Ingrese el Id de la herramienta a eliminar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                bool eliminado = false;

                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(';');
                        if (int.Parse(datos[0]) != id)
                        {
                            sw.WriteLine(linea);
                        }
                        else
                        {
                            eliminado = true;
                        }
                    }
                }

                if (eliminado)
                    Console.WriteLine("Herramienta eliminada correctamente.");
                else
                    Console.WriteLine("Herramienta no encontrada.");
            }
        }

        // funcion de menu princial 
        public static void MostrarMenu()
        {
            Console.WriteLine("Bienvenido a Nuestra Ferretería Pro");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Crear");
            Console.WriteLine("2. Listar");
            Console.WriteLine("3. Modificar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir");
        }

        // funcion para ejecutar la opcion que me de el menú
        public static void Ejecutar()
        {
            int opcion = 0;
            do
            {
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Crear();
                        break;
                    case 2:
                        Leer();
                        break;
                    case 3:
                        Actualizar();
                        break;
                    case 4:
                        Eliminar();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            } while (opcion != 5);
        }
    }
}