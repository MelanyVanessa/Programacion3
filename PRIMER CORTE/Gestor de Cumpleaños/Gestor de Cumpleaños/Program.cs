using System;
using System.IO;

namespace Gestor_de_Cumpleaños
{
    internal class Program
    {
       
        static string archivoCumpleaños = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "cumpleaños.txt"
        );

        static void Main(string[] args)
        {
            // Crear el archivo si no existe
            if (!File.Exists(archivoCumpleaños))
            {
                File.Create(archivoCumpleaños).Close();
                Console.WriteLine("Archivo 'cumpleaños.txt' creado exitosamente en Documentos.\n");
            }

            Console.WriteLine("Bienvenido al Gestor de Cumpleaños\n");
            MostrarMenu();
            Ejecutar();
        }

        static void Ejecutar()
        {
            while (true)
            {
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        AgregarAmigo();
                        break;
                    case "2":
                        VerListaAmigos();
                        break;
                    case "3":
                        BorrarLista();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }
                Console.WriteLine("");
                MostrarMenu();
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Gestor de Cumpleaños");
            Console.WriteLine("1. Agregar amigo");
            Console.WriteLine("2. Ver lista de amigos");
            Console.WriteLine("3. Borrar lista completa");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static void VerListaAmigos()
        {
            string[] amigos = File.ReadAllLines(archivoCumpleaños);
            if (amigos.Length > 0)
            {
                Console.WriteLine("\nLista de amigos:");
                foreach (string amigo in amigos)
                {
                    Console.WriteLine(amigo);

                    string[] partes = amigo.Split('-');
                    if (partes.Length == 2)
                    {
                        string nombre = partes[0].Trim();
                        DateTime fechaNacimiento;
                        if (DateTime.TryParseExact(partes[1].Trim(), "dd/MM/yyyy", null,
                            System.Globalization.DateTimeStyles.None, out fechaNacimiento))
                        {
                            Amigo a = new Amigo(nombre, fechaNacimiento);
                            a.CalcularFaltanDias();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay amigos registrados.");
            }
        }

        static void AgregarAmigo()
        {
            Console.WriteLine("Ingrese el nombre del amigo:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento (dd/MM/yyyy):");
            DateTime fechaNacimiento;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null,
                System.Globalization.DateTimeStyles.None, out fechaNacimiento))
            {
                Console.WriteLine("Formato de fecha inválido. Por favor, ingrese la fecha en formato dd/MM/yyyy:");
            }

            Amigo nuevoAmigo = new Amigo(nombre, fechaNacimiento);
            File.AppendAllText(archivoCumpleaños, $"{nuevoAmigo.Nombre} - {nuevoAmigo.FechaNacimiento:dd/MM/yyyy}{Environment.NewLine}");
            Console.WriteLine("Amigo agregado exitosamente.");
        }

        static void BorrarLista()
        {
            File.WriteAllText(archivoCumpleaños, string.Empty);
            Console.WriteLine("La lista de amigos ha sido borrada.");
        }
    }

    class Amigo
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Amigo(string nombre, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
        }

        public void CalcularFaltanDias()
        {
            DateTime hoy = DateTime.Today;
            DateTime proximoCumpleaños = new DateTime(hoy.Year, FechaNacimiento.Month, FechaNacimiento.Day);

            if (proximoCumpleaños < hoy)
            {
                proximoCumpleaños = proximoCumpleaños.AddYears(1);
            }

            int diasFaltantes = (proximoCumpleaños - hoy).Days;
            Console.WriteLine($"Faltan {diasFaltantes} días para el próximo cumpleaños de {Nombre}.");
        }
    }
}