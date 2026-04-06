using System;
using Sistema_de_Concesionario_de_Vehículos.Enums;

namespace Sistema_de_Concesionario_de_Vehículos.Modelos
{
    public class Motocicleta : Vehiculo
    {
        public int Cilindraje { get; set; }
        public bool EsDeportiva { get; set; }

        public Motocicleta(int id, string marca, string modelo, int anio, decimal precioBase,
                           TipoCombustible combustible, EstadoVehiculo estado,
                           int cilindraje, bool esDeportiva)
            : base(id, marca, modelo, anio, precioBase, combustible, estado)
        {
            Cilindraje = cilindraje;
            EsDeportiva = esDeportiva;
        }

        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Cilindraje: {Cilindraje} cc");
            Console.WriteLine($"Es deportiva: {(EsDeportiva ? "Sí" : "No")}");
        }

        public override void CalcularPrecioFinal()
        {
            decimal precioFinal = PrecioBase;

            if (EsDeportiva)
            {
                precioFinal += Cilindraje * 10; // costo adicional por ser deportiva
            }

            decimal impuestos = precioFinal * 0.19m; // IVA 19%
            precioFinal += impuestos;

            Console.WriteLine($"Precio final con impuestos: {precioFinal:C}");
        }

        public override void CalcularComisionVendedor()
        {
            decimal precioFinal = PrecioBase;

            if (EsDeportiva)
            {
                precioFinal += Cilindraje * 10;
            }

            decimal impuestos = precioFinal * 0.19m;
            precioFinal += impuestos;

            decimal comision = precioFinal * 0.06m; // comisión 6% para motos
            Console.WriteLine($"Comisión del vendedor: {comision:C}");
        }

        public override void GenerarFacturaVenta()
        {
            decimal precioFinal = PrecioBase;

            if (EsDeportiva)
            {
                precioFinal += Cilindraje * 10;
            }

            decimal impuestos = precioFinal * 0.19m;
            precioFinal += impuestos;

            decimal comision = precioFinal * 0.06m;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("             FACTURA DE VENTA");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Anio}");
            Console.WriteLine($"Precio Base: {PrecioBase:C}");
            Console.WriteLine($"Cilindraje: {Cilindraje} cc");
            Console.WriteLine($"Es Deportiva: {(EsDeportiva ? "Sí" : "No")}");
            Console.WriteLine($"Precio Final: {precioFinal:C}");
            Console.WriteLine($"Comisión del Vendedor: {comision:C}");
            Console.WriteLine("----------------------------------------------------");
        }
    }
}