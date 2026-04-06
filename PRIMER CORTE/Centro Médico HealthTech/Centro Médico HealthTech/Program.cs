using System;
using System.Collections.Generic;
using System.IO;

namespace HealthTechApp
{
    enum Especialidad
    {
        General = 1,
        Pediatria = 2,
        Odontologia = 3
    }

    interface IPrioritario
    {
        decimal AplicarDescuento();
    }

    class CitaMedica : IPrioritario
    {
        public string Paciente { get; set; }
        public Especialidad Especialidad { get; set; }
        public decimal CostoBase { get; set; }

        public decimal AplicarDescuento()
        {
            if (Especialidad == Especialidad.Pediatria)
            {
                return CostoBase * 0.8m;
            }
            return CostoBase;
        }
    }

    class Program
    {
        static List<CitaMedica> citas = new List<CitaMedica>();
        static string rutaArchivo = "citas.csv";

        static void Main(string[] args)
        {
            CargarCitas();

            int opcion;
            do
            {
                Console.WriteLine("\n--- MEDICAL MENU ---");
                Console.WriteLine("1. Agendar Cita");
                Console.WriteLine("2. Ver Factura");
                Console.WriteLine("3. Cambiar Especialidad");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgendarCita();
                        break;
                    case 2:
                        VerFactura();
                        break;
                    case 3:
                        CambiarEspecialidad();
                        break;
                    case 0:
                        GuardarCitas();
                        Console.WriteLine("Gracias por usar HealthTech.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 0);
        }

        static void AgendarCita()
        {
            Console.Write("Nombre del Paciente: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Seleccione Especialidad:");
            Console.WriteLine("1. General");
            Console.WriteLine("2. Pediatría");
            Console.WriteLine("3. Odontología");

            if (!int.TryParse(Console.ReadLine(), out int espNum) || espNum < 1 || espNum > 3)
            {
                Console.WriteLine("Especialidad inválida.");
                return;
            }

            Especialidad especialidad = (Especialidad)espNum;

            Console.Write("Costo Base: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal costo))
            {
                Console.WriteLine("Costo inválido.");
                return;
            }

            citas.Add(new CitaMedica
            {
                Paciente = nombre,
                Especialidad = especialidad,
                CostoBase = costo
            });

            Console.WriteLine("Cita agendada correctamente.");
        }

        static void VerFactura()
        {
            Console.Write("Ingrese el nombre del paciente: ");
            string nombre = Console.ReadLine();

            CitaMedica cita = citas.Find(c => c.Paciente.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (cita == null)
            {
                Console.WriteLine("No se encontró la cita.");
                return;
            }

            Console.WriteLine($"\nNombre del Paciente: {cita.Paciente}");
            Console.WriteLine($"Especialidad: {cita.Especialidad}");
            Console.WriteLine($"Costo Original: ${cita.CostoBase}");

            decimal total = cita.AplicarDescuento();
            if (cita.Especialidad == Especialidad.Pediatria)
            {
                Console.WriteLine($">> TOTAL A PAGAR (Con Desc. Pediatría): ${total}");
            }
            else
            {
                Console.WriteLine($">> TOTAL A PAGAR: ${total}");
            }
        }

        static void CambiarEspecialidad()
        {
            Console.Write("Ingrese el nombre del paciente: ");
            string nombre = Console.ReadLine();

            CitaMedica cita = citas.Find(c => c.Paciente.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (cita == null)
            {
                Console.WriteLine("No se encontró la cita.");
                return;
            }

            Console.WriteLine("Seleccione nueva Especialidad:");
            Console.WriteLine("1. General");
            Console.WriteLine("2. Pediatría");
            Console.WriteLine("3. Odontología");

            if (!int.TryParse(Console.ReadLine(), out int espNum) || espNum < 1 || espNum > 3)
            {
                Console.WriteLine("Especialidad inválida.");
                return;
            }

            cita.Especialidad = (Especialidad)espNum;
            Console.WriteLine("Especialidad actualizada correctamente.");
        }

        static void GuardarCitas()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    foreach (var cita in citas)
                    {
                        sw.WriteLine($"{cita.Paciente};{cita.Especialidad};{cita.CostoBase}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar archivo: {ex.Message}");
            }
        }

        static void CargarCitas()
        {
            try
            {
                if (File.Exists(rutaArchivo))
                {
                    string[] lineas = File.ReadAllLines(rutaArchivo);
                    foreach (var linea in lineas)
                    {
                        string[] datos = linea.Split(';');
                        if (datos.Length == 3)
                        {
                            Especialidad especialidad;
                            if (!Enum.TryParse(datos[1], out especialidad))
                            {
                                especialidad = Especialidad.General;
                            }

                            decimal costo;
                            if (!decimal.TryParse(datos[2], out costo))
                            {
                                costo = 0;
                            }

                            citas.Add(new CitaMedica
                            {
                                Paciente = datos[0],
                                Especialidad = especialidad,
                                CostoBase = costo
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar archivo: {ex.Message}");
            }
        }
    }
}