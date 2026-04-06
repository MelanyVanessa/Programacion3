using System;
using Sistema_de_Concesionario_de_Vehículos.Enums;

namespace Sistema_de_Concesionario_de_Vehículos.Modelos
{
    public class Camion : Vehiculo
    {
        public decimal CapacidadCarga { get; set; } // en toneladas
        public int NumeroEjes { get; set; }

        public Camion(int id, string marca, string modelo, int anio, decimal precioBase,
                      TipoCombustible combustible, EstadoVehiculo estado,
                      decimal capacidadCarga, int numeroEjes)
            : base(id, marca, modelo, anio, precioBase, combustible, estado)
        {
            CapacidadCarga = capacidadCarga;
            NumeroEjes = numeroEjes;
        }

        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga} toneladas");
            Console.WriteLine($"Número de ejes: {NumeroEjes}");
        }

        public override void CalcularPrecioFinal()
        {
            decimal precioFinal = PrecioBase + (CapacidadCarga * 500); // costo adicional por carga
            decimal impuestos = precioFinal * 0.19m; // IVA 19%
            precioFinal += impuestos;

            Console.WriteLine($"Precio final con impuestos: {precioFinal:C}");
        }

        public override void CalcularComisionVendedor()
        {
            decimal precioFinal = PrecioBase + (CapacidadCarga * 500);
            decimal impuestos = precioFinal * 0.19m;
            precioFinal += impuestos;

            decimal comision = precioFinal * 0.07m; // comisión 7% para camiones
            Console.WriteLine($"Comisión del vendedor: {comision:C}");
        }

        public override void GenerarFacturaVenta()
        {
            decimal precioFinal = PrecioBase + (CapacidadCarga * 500);
            decimal impuestos = precioFinal * 0.19m;
            precioFinal += impuestos;

            decimal comision = precioFinal * 0.07m;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("             FACTURA DE VENTA");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Anio}");
            Console.WriteLine($"Precio Base: {PrecioBase:C}");
            Console.WriteLine($"Capacidad de Carga: {CapacidadCarga} toneladas");
            Console.WriteLine($"Número de Ejes: {NumeroEjes}");
            Console.WriteLine($"Precio Final: {precioFinal:C}");
            Console.WriteLine($"Comisión del Vendedor: {comision:C}");
            Console.WriteLine("----------------------------------------------------");
        }
    }
}