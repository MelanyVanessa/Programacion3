using System;
using System.IO;

namespace GlobalShip
{
    internal class Program
    {
        string ruta = "Paquetes.csv";

        static void Main(string[] args)
        {
            Program GlobalShip = new Program();

            
            if (!File.Exists(GlobalShip.ruta))
            {
                File.Create(GlobalShip.ruta).Close();
                Console.WriteLine("Archivo 'Paquetes.csv' creado exitosamente.\n");
            }

            
            GlobalShip.EjemplosEnvios();

            
            GlobalShip.Ejecutar();
        }

        public void Ejecutar()
        {
            while (true)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        NuevoEnvio();
                        break;
                    case "2":
                        VerPesoTotal();
                        break;
                    case "3":
                        MostrarPaquetes();
                        break;
                    case "4":
                        BuscarEnvio();
                        break;
                    case "5":
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Console.WriteLine();
            }
        }

        public void BuscarEnvio()
        {
            Console.WriteLine("Ingrese número de guía a buscar:");
            int guia = int.Parse(Console.ReadLine());
            using (StreamReader sr = new StreamReader(ruta))
            {
                string linea;
                bool encontrado = false;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] partes = linea.Split(';');
                    if (partes.Length >= 4 && int.TryParse(partes[0], out int guiaActual) && guiaActual == guia)
                    {
                        Console.WriteLine($"Envío encontrado: {linea}");
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encontró un envío con ese número de guía.");
                }
            }
        }

        public void MostrarMenu()
        {
            Console.WriteLine("========== Bienvenido a GlobalShip ==========");
            Console.WriteLine("1. Nuevo Envío");
            Console.WriteLine("2. Ver peso total");
            Console.WriteLine("3. Ver lista de envíos");
            Console.WriteLine("4. Buscar envio por numero de Guia");
            Console.WriteLine("5. Salir");
            Console.WriteLine("============================================");
            Console.Write("Seleccione una opción: ");
        }




        public void MostrarPaquetes()
        {
            Console.WriteLine("\nLista de envíos registrados:");
            using (StreamReader sr = new StreamReader(ruta))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
        }

        public void GuardarPaquete(paquete p)
        {
            using (StreamWriter sw = new StreamWriter(ruta, true))
            {
                sw.WriteLine(p.ToCSV());
            }
        }

        public void NuevoEnvio()
        {
            Console.WriteLine("Ingrese número de guía:");
            int guia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nombre del destinatario:");
            string destinatario = Console.ReadLine();

            Console.WriteLine("Ingrese peso del paquete (kg):");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione tipo de envío (0 = Nacional, 1 = Internacional):");
            int tipo = int.Parse(Console.ReadLine());

            paquete nuevo = new paquete
            {
                Guia = guia,
                Destinatario = destinatario,
                peso = peso,
                Tipo = (Envio)tipo
            };

            GuardarPaquete(nuevo);
            Console.WriteLine("Envío registrado exitosamente.");
        }

        public void VerPesoTotal()
        {
            double total = 0;
            using (StreamReader sr = new StreamReader(ruta))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] partes = linea.Split(';');
                    if (partes.Length >= 3)
                    {
                        double peso;
                        if (double.TryParse(partes[2], out peso))
                        {
                            total += peso;
                        }
                    }
                }
            }
            Console.WriteLine($"\nEl peso total de todos los envíos es: {total} kg");
        }

        public class paquete
        {
            public int Guia { get; set; }
            public string Destinatario { get; set; }
            public double peso { get; set; }
            public Envio Tipo { get; set; }

            public string ToCSV() => $"{Guia};{Destinatario};{peso};{Tipo}";
        }

        public enum Envio
        {
            Nacional,
            Internacional
        }

        public void EjemplosEnvios()
        {
            
            if (new FileInfo(ruta).Length == 0)
            {
                Console.WriteLine("Agregando envíos de ejemplo...\n");

                paquete p1 = new paquete { Guia = 1001, Destinatario = "Juan Pérez", peso = 2.5, Tipo = Envio.Nacional };
                paquete p2 = new paquete { Guia = 1002, Destinatario = "María Gómez", peso = 5.0, Tipo = Envio.Internacional };
                paquete p3 = new paquete { Guia = 1003, Destinatario = "Carlos López", peso = 1.2, Tipo = Envio.Nacional };

                GuardarPaquete(p1);
                GuardarPaquete(p2);
                GuardarPaquete(p3);

                Console.WriteLine("Ejemplos agregados correctamente.\n");
            }
        }
    }
}