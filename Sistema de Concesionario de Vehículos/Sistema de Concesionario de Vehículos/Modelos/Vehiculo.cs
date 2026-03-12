using Sistema_de_Concesionario_de_Vehículos.Enums;
using Sistema_de_Concesionario_de_Vehículos.Interfaces;
using System;

namespace Sistema_de_Concesionario_de_Vehículos.Modelos
{
    public abstract class Vehiculo : IVendible
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoCombustible Combustible { get; set; }
        public EstadoVehiculo Estado { get; set; }

        protected Vehiculo(int id, string marca, string modelo, int anio, decimal precioBase, TipoCombustible combustible, EstadoVehiculo estado)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            PrecioBase = precioBase;
            Combustible = combustible;
            Estado = estado;
        }

        public virtual void MostrarEspecificaciones()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Anio}");
            Console.WriteLine($"Precio base: {PrecioBase:C}");
            Console.WriteLine($"Combustible: {Combustible}");
            Console.WriteLine($"Estado: {Estado}");
        }

        // Métodos de la interfaz IVendible
        public abstract void GenerarFacturaVenta();

        public virtual void CalcularComisionVendedor()
        {
            decimal comision = PrecioBase * 0.05m; // 5% por defecto
            Console.WriteLine($"La comisión del vendedor es: {comision:C}");
        }

        public virtual void CalcularPrecioFinal()
        {
            decimal impuestos = PrecioBase * 0.19m; // IVA 19% por defecto
            decimal precioFinal = PrecioBase + impuestos;
            Console.WriteLine($"El precio final con impuestos es: {precioFinal:C}");
        }
    }
}