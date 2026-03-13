using Sistema_de_Restaurante_y_Cocina.Enums;
using System;

namespace SistemaRestaurante.Modelos
{
    public class Postre : Plato
    {
        public bool ContieneLactosa { get; set; }
        public int CaloriasPorPorcion { get; set; }

        public Postre(int id, string nombre, string descripcion, decimal precioBase,
                      TipoComida tipo, NivelDificultad dificultad,
                      bool contieneLactosa, int caloriasPorPorcion)
            : base(id, nombre, descripcion, precioBase, tipo, dificultad)
        {
            ContieneLactosa = contieneLactosa;
            CaloriasPorPorcion = caloriasPorPorcion;
        }

        public override TimeSpan CalcularTiempoPreparacion()
        {
            
            return TimeSpan.FromMinutes(25 + (ContieneLactosa ? 5 : 0));
        }

        public override void GenerarOrdenCocina()
        {
            Console.WriteLine($"Orden generada: Postre {Nombre}");
            Console.WriteLine($"Contiene lactosa: {(ContieneLactosa ? "Sí" : "No")}");
            Console.WriteLine($"Calorías por porción: {CaloriasPorPorcion}");
        }

        public override decimal CalcularCostoTotal()
        {
          
            return PrecioBase;
        }
    }
}