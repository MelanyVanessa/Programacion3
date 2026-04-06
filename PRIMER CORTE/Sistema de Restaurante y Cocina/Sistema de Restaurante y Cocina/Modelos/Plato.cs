using Sistema_de_Restaurante_y_Cocina.Enums;
using SistemaRestaurante.Interfaces;
using System;

namespace SistemaRestaurante.Modelos
{
    public abstract class Plato : IPreparable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoComida Tipo { get; set; }
        public NivelDificultad Dificultad { get; set; }

        
        protected Plato(int id, string nombre, string descripcion, decimal precioBase, TipoComida tipo, NivelDificultad dificultad)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioBase = precioBase;
            Tipo = tipo;
            Dificultad = dificultad;
        }

        
        public virtual void MostrarInformacionNutricional()
        {
            Console.WriteLine($"Plato: {Nombre} ({Tipo})");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Precio base: {PrecioBase:C}");
            Console.WriteLine($"Dificultad: {Dificultad}");
        }

        
        public abstract TimeSpan CalcularTiempoPreparacion();
        public abstract void GenerarOrdenCocina();
        public abstract decimal CalcularCostoTotal();
    }
}
