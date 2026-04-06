using System;
using System.IO;

namespace Gestor_de_Contactos_Simple
{
    internal class Program
    {
        string ruta = "contactos.csv";

        static void Main(string[] args)
        {
            Program Gestor = new Program();

            Gestor.menu();
            Gestor.ejecutar();        
        }

        public void ejecutar()

        {
            
            while (true)
            {
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        agregarContacto();
                        break;
                    case 2:
                        listarContactos();
                        break;
                    case 3:
                        buscarContacto();
                        break;
                    case 4:
                        eliminarContacto();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }   



        public void listarContactos()
        {
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    Console.WriteLine($"Nombre: {datos[0]}, Teléfono: {datos[1]}, Correo: {datos[2]}");
                }
            }
            else
            {
                Console.WriteLine("No hay contactos registrados.");
            }
        }

        public void buscarContacto()
        {
            Console.WriteLine("Ingrese el nombre del contacto a buscar: ");
            string nombre = Console.ReadLine();
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                bool encontrado = false;
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    if (datos[0].Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Nombre: {datos[0]}, Teléfono: {datos[1]}, Correo: {datos[2]}");
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("Contacto no encontrado.");
                }
            }
            else
            {
                Console.WriteLine("No hay contactos registrados.");
            }
        }
        public void eliminarContacto()
        {
            Console.WriteLine("Ingrese el nombre del contacto a eliminar: ");
            string nombre = Console.ReadLine();

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                bool eliminado = false;

                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(';');
                        if (!datos[0].Equals(nombre, StringComparison.OrdinalIgnoreCase))
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
                    Console.WriteLine("Contacto eliminado correctamente.");
                else
                    Console.WriteLine("El contacto no existe en la lista.");
            }
            else
            {
                Console.WriteLine("No hay contactos registrados.");
            }
        }

        public class Contacto
        {
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string ToCSV()
            {
                return $"{Nombre};{Telefono};{Correo}";
            }
        }
        public void menu()
        {
            Console.WriteLine("_ _ _ _ _ _ _ _ Gestor de Contactos _ _ _ _ _ _ _ _");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Listar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Eliminar contacto");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione una opción: ");
        }
        
        public void agregarContacto()
        {
            Console.WriteLine("Ingrese el nombre del contacto: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el teléfono del contacto: ");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese el correo del contacto: ");
            string correo = Console.ReadLine();
            Contacto nuevo = new Contacto
            {
                Nombre = nombre,
                Telefono = telefono,
                Correo = correo
            };

            GuardarContacto(nuevo);
            Console.WriteLine("Envío registrado exitosamente.");

        }

        public void GuardarContacto(Contacto p)
        {
            using (StreamWriter sw = new StreamWriter(ruta, true))
            {
                sw.WriteLine(p.ToCSV());
            }
        }

    }   
}
