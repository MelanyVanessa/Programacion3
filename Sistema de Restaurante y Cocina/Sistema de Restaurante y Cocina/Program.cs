using Sistema_de_Restaurante_y_Cocina.Enums;
using SistemaRestaurante.Modelos;
using System;
using System.Collections.Generic;

namespace SistemaRestaurante
{
    internal class Program
    {
        static List<Plato> menu = new List<Plato>();
        static int siguienteId = 1;

        static void Main(string[] args)
        {
            
            CargarPlatosEjemplo();

            int opcion;
            do
            {
                MostrarMenu();
                Console.Write("Seleccione una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        RegistrarPlato();
                        break;
                    case 2:
                        ListarMenu();
                        break;
                    case 3:
                        PrepararOrden();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del sistema... ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 0);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("=== SISTEMA DE RESTAURANTE ===");
            Console.WriteLine("1. Registrar Plato");
            Console.WriteLine("2. Ver Menú");
            Console.WriteLine("3. Preparar Orden");
            Console.WriteLine("0. Salir");
        }

        static void RegistrarPlato()
        {
            Console.WriteLine("Seleccione el tipo de plato:");
            Console.WriteLine("1. Entrada");
            Console.WriteLine("2. Plato Principal");
            Console.WriteLine("3. Postre");
            int tipo = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine();
            Console.Write("Precio Base: ");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de comida (0=Vegetariana, 1=Vegana, 2=Carnivora, 3=Mariscos, 4=Mixta): ");
            TipoComida tipoComida = (TipoComida)int.Parse(Console.ReadLine());

            Console.WriteLine("Nivel de dificultad (0=Facil, 1=Intermedio, 2=Avanzado): ");
            NivelDificultad dificultad = (NivelDificultad)int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    Console.Write("¿Es fría? (true/false): ");
                    bool esFria = bool.Parse(Console.ReadLine());
                    Console.Write("Número de porciones: ");
                    int porciones = int.Parse(Console.ReadLine());
                    menu.Add(new Entrada(siguienteId++, nombre, descripcion, precioBase, tipoComida, dificultad, esFria, porciones));
                    break;

                case 2:
                    Console.Write("Proteína principal: ");
                    string proteina = Console.ReadLine();
                    Console.Write("¿Incluye guarnición? (true/false): ");
                    bool guarnicion = bool.Parse(Console.ReadLine());
                    menu.Add(new PlatoPrincipal(siguienteId++, nombre, descripcion, precioBase, tipoComida, dificultad, proteina, guarnicion));
                    break;

                case 3:
                    Console.Write("¿Contiene lactosa? (true/false): ");
                    bool lactosa = bool.Parse(Console.ReadLine());
                    Console.Write("Calorías por porción: ");
                    int calorias = int.Parse(Console.ReadLine());
                    menu.Add(new Postre(siguienteId++, nombre, descripcion, precioBase, tipoComida, dificultad, lactosa, calorias));
                    break;
            }

            Console.WriteLine("Plato registrado exitosamente.");
        }

        static void ListarMenu()
        {
            Console.WriteLine("=== MENÚ DISPONIBLE ===");
            foreach (var plato in menu)
            {
                plato.MostrarInformacionNutricional();
                Console.WriteLine("-----------------------------------");
            }
        }

        static void PrepararOrden()
        {
            Console.Write("Ingrese el ID del plato a preparar: ");
            int id = int.Parse(Console.ReadLine());

            var platoSeleccionado = menu.Find(p => p.Id == id);

            if (platoSeleccionado != null)
            {
                platoSeleccionado.GenerarOrdenCocina();
                Console.WriteLine($"Tiempo estimado: {platoSeleccionado.CalcularTiempoPreparacion()}");
                Console.WriteLine($"Costo total: {platoSeleccionado.CalcularCostoTotal():C}");
            }
            else
            {
                Console.WriteLine("No se encontró un plato con ese ID.");
            }
        }

        // Función que carga platos de ejemplo al iniciar
        static void CargarPlatosEjemplo()
        {
            menu.Add(new Entrada(
                id: siguienteId++,
                nombre: "Bruschetta",
                descripcion: "Pan con tomate y albahaca fresca",
                precioBase: 12000m,
                tipo: TipoComida.Vegetariana,
                dificultad: NivelDificultad.Facil,
                esFria: true,
                porciones: 2
            ));

            menu.Add(new PlatoPrincipal(
                id: siguienteId++,
                nombre: "Filete de Res",
                descripcion: "Carne jugosa con salsa de vino",
                precioBase: 35000m,
                tipo: TipoComida.Carnivora,
                dificultad: NivelDificultad.Intermedio,
                proteinaPrincipal: "Res",
                incluyeGuarnicion: true
            ));

            menu.Add(new Postre(
                id: siguienteId++,
                nombre: "Cheesecake",
                descripcion: "Pastel de queso con frutos rojos",
                precioBase: 18000m,
                tipo: TipoComida.Mixta,
                dificultad: NivelDificultad.Facil,
                contieneLactosa: true,
                caloriasPorPorcion: 300
            ));

            Console.WriteLine("Platos de ejemplo cargados en el menú.");
        }
    }
}