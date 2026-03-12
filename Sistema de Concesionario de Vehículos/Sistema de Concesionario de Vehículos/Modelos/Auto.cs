using System;
using Sistema_de_Concesionario_de_Vehículos.Enums;

namespace Sistema_de_Concesionario_de_Vehículos.Modelos
{
    public class Auto : Vehiculo
    {
        public int NumeroPuertas { get; set; }
        public bool TieneAireAcondicionado { get; set; }

        public Auto(int id, string marca, string modelo, int anio, decimal precioBase,
                    TipoCombustible combustible, EstadoVehiculo estado,
                    int numeroPuertas, bool tieneAireAcondicionado)
            : base(id, marca, modelo, anio, precioBase, combustible, estado)
        {
            NumeroPuertas = numeroPuertas;
            TieneAireAcondicionado = tieneAireAcondicionado;
        }

        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Número de puertas: {NumeroPuertas}");
            Console.WriteLine($"Aire acondicionado: {(TieneAireAcondicionado ? "Sí" : "No")}");
        }

        public override void CalcularPrecioFinal()
        {
            decimal precioFinal = PrecioBase;

            if (TieneAireAcondicionado)
            {
                precioFinal += 1000m; // costo adicional por aire acondicionado
            }

            decimal impuestos = precioFinal * 0.19m; // IVA 19%
            precioFinal += impuestos;

            Console.WriteLine($"Precio final con impuestos: {precioFinal:C}");
        }

        public override void CalcularComisionVendedor()
        {
            decimal precioFinal = PrecioBase;

            if (TieneAireAcondicionado)
            {
                precioFinal += 1000m;
            }

            decimal impuestos = precioFinal * 0.19m;
            precioFinal += impuestos;

            decimal comision = precioFinal * 0.05m; // 5% comisión
            Console.WriteLine($"Comisión del vendedor: {comision:C}");
        }

        public override void GenerarFacturaVenta()
        {
            decimal precioFinal = PrecioBase;

            if (TieneAireAcondicionado)
            {
                precioFinal += 1000m;
            }

            decimal impuestos = precioFinal * 0.19m;
            precioFinal += impuestos;

            decimal comision = precioFinal * 0.05m;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("             FACTURA DE VENTA");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Anio}");
            Console.WriteLine($"Precio Base: {PrecioBase:C}");
            Console.WriteLine($"Aire Acondicionado: {(TieneAireAcondicionado ? "Sí" : "No")}");
            Console.WriteLine($"Precio Final: {precioFinal:C}");
            Console.WriteLine($"Comisión del Vendedor: {comision:C}");
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
