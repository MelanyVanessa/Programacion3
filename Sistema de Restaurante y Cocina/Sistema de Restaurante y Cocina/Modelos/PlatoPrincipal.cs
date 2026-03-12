using Sistema_de_Restaurante_y_Cocina.Enums;
using System;

namespace SistemaRestaurante.Modelos
{
    public class PlatoPrincipal : Plato
    {
        public string ProteinaPrincipal { get; set; }
        public bool IncluyeGuarnicion { get; set; }

        public PlatoPrincipal(int id, string nombre, string descripcion, decimal precioBase,
                              TipoComida tipo, NivelDificultad dificultad,
                              string proteinaPrincipal, bool incluyeGuarnicion)
            : base(id, nombre, descripcion, precioBase, tipo, dificultad)
        {
            ProteinaPrincipal = proteinaPrincipal;
            IncluyeGuarnicion = incluyeGuarnicion;
        }

        public override TimeSpan CalcularTiempoPreparacion()
        {
            // Tiempo base: 30 min + dificultad * 15 min
            int dificultadExtra = (int)Dificultad * 15;
            return TimeSpan.FromMinutes(30 + dificultadExtra);
        }

        public override void GenerarOrdenCocina()
        {
            Console.WriteLine($"Orden generada: Plato Principal {Nombre}");
            Console.WriteLine($"Proteína: {ProteinaPrincipal}");
            Console.WriteLine($"Incluye guarnición: {(IncluyeGuarnicion ? "Sí" : "No")}");
        }

        public override decimal CalcularCostoTotal()
        {
            // Si incluye guarnición, se suma un costo adicional
            return PrecioBase + (IncluyeGuarnicion ? 5000m : 0);
        }
    }
}