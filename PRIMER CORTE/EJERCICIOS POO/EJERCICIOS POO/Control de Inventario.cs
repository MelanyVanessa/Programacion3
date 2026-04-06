using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_POO
{
    public class Control_de_Inventario
    {
        class Producto
        {
            public string Nombre { get; set; }
            public string Codigo { get; set; }
            public decimal Precio { get; set; }
            public int CantidadStock { get; private set; }

            public Producto(string nombre, string codigo, decimal precio, int cantidadInicial)
            {
                Nombre = nombre;
                Codigo = codigo;
                Precio = precio;
                CantidadStock = cantidadInicial;
            }

            public void AgregarStock(int cantidad)
            {
                CantidadStock += cantidad;
                Console.WriteLine($"{cantidad} unidades agregadas. Stock actual: {CantidadStock}");
            }

            public decimal VenderProducto(int cantidad)
            {
                if (cantidad > CantidadStock)
                {
                    Console.WriteLine("No hay suficiente stock disponible.");
                    return 0;
                }

                CantidadStock -= cantidad;
                decimal totalVenta = Precio * cantidad;
                Console.WriteLine($"{cantidad} unidades vendidas. Stock restante: {CantidadStock}");
                return totalVenta;
            }

            public void MostrarInfo()
            {
                Console.WriteLine($"Producto: {Nombre} | Código: {Codigo} | Precio: {Precio:C} | Stock: {CantidadStock}");
            }
        }


        public static void Ejecutar()
        {
            Console.WriteLine("=== Sistema de Control de Inventario ===");

            // Datos iniciales del producto
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el código del producto: ");
            string codigo = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad inicial en stock: ");
            int cantidadInicial = int.Parse(Console.ReadLine());

            Producto producto = new Producto(nombre, codigo, precio, cantidadInicial);

            int opcion;
            do
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Mostrar información del producto");
                Console.WriteLine("2. Agregar stock");
                Console.WriteLine("3. Vender producto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)

                {
                    case 1:
                        producto.MostrarInfo();
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad a agregar: ");
                        int cantidadAgregar = int.Parse(Console.ReadLine());
                        producto.AgregarStock(cantidadAgregar);
                        break;
                    case 3:
                        Console.Write("Ingrese la cantidad a vender: ");
                        int cantidadVender = int.Parse(Console.ReadLine());
                        decimal total = producto.VenderProducto(cantidadVender);
                        if (total > 0)
                            Console.WriteLine($"Total de la venta: {total:C}");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente nuevamente.");
                        break;
                }

            } while (opcion != 4);
        }
        
        class Program
        {
            
    }
    }



}
    