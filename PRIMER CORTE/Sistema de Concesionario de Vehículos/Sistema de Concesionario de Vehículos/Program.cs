using Sistema_de_Concesionario_de_Vehículos.Enums;
using Sistema_de_Concesionario_de_Vehículos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sistema_de_Concesionario_de_Vehículos
{
    internal class Program
    {
        public static List<Vehiculo> VehiculosDisponibles = new List<Vehiculo>();
        public static int siguienteId = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("   BIENVENIDO A NUESTRO CONCESIONARIO VIRTUAL   ");

            // Cargar ejemplos al inicio
            Elementos_Ejemplo();

            int opcion;
            do
            {
                MostrarMenu();
                Console.Write("Selecciona una opción: ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }
            } while (opcion != 3);
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("\n MENÚ PRINCIPAL ");
            Console.WriteLine("1. Comprar un Vehículo");
            Console.WriteLine("2. Ver todas las opciones disponibles");
            Console.WriteLine("3. Salir");
        }

        public static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el ID del Vehículo que desea comprar: ");
                    int idBuscado = int.Parse(Console.ReadLine());

                    var vehiculoSeleccionado = VehiculosDisponibles.FirstOrDefault(v => v.Id == idBuscado);

                    if (vehiculoSeleccionado != null)
                    {
                        vehiculoSeleccionado.GenerarFacturaVenta();
                        vehiculoSeleccionado.CalcularComisionVendedor();
                    }
                    else
                    {
                        Console.WriteLine("No se encontró un vehículo con ese ID.");
                    }
                    break;

                case 2:
                    MostrarVehiculosDisponibles();
                    break;

                case 3:
                    Console.WriteLine("Has escogido salir, ¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        public static void Elementos_Ejemplo()
        {
            var auto1 = new Auto(siguienteId++, "Toyota", "Corolla", 2022, 8500m, TipoCombustible.Gasolina, EstadoVehiculo.Nuevo, 4, true);
            var motocicleta1 = new Motocicleta(siguienteId++, "Yamaha", "R1", 2023, 65000m, TipoCombustible.Gasolina, EstadoVehiculo.Nuevo, 1000, true);
            var camion1 = new Camion(siguienteId++, "Volvo", "FH16", 2024, 250000M, TipoCombustible.Diesel, EstadoVehiculo.Nuevo, 20m, 4);
            var auto2 = new Auto(siguienteId++, "Ford", "Mustang GT", 2021, 120000m, TipoCombustible.Gasolina, EstadoVehiculo.Usado, 2, false);

            VehiculosDisponibles.Add(auto1);
            VehiculosDisponibles.Add(motocicleta1);
            VehiculosDisponibles.Add(camion1);
            VehiculosDisponibles.Add(auto2);
        }

        public static void MostrarVehiculosDisponibles()
        {
            Console.WriteLine("\n=== VEHÍCULOS DISPONIBLES ===");
            foreach (var v in VehiculosDisponibles)
            {
                v.MostrarEspecificaciones();
                Console.WriteLine("-----------------------------");
            }
        }
    }
}