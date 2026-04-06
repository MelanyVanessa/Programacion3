using Sistema_de_Restaurante_y_Cocina.Enums;
using System;

namespace SistemaRestaurante.Modelos
{
    public class Entrada : Plato
    {
        public bool EsFria { get; set; }
        public int Porciones { get; set; }

        public Entrada(int id, string nombre, string descripcion, decimal precioBase,
                       TipoComida tipo, NivelDificultad dificultad,
                       bool esFria, int porciones)
            : base(id, nombre, descripcion, precioBase, tipo, dificultad)
        {
            EsFria = esFria;
            Porciones = porciones;
        }

        public override TimeSpan CalcularTiempoPreparacion()
        {
            
            return EsFria ? TimeSpan.FromMinutes(10) : TimeSpan.FromMinutes(20);
        }

        public override void GenerarOrdenCocina()
        {
            Console.WriteLine($"Orden generada: Entrada {Nombre}");
            Console.WriteLine($"Tipo: {(EsFria ? "Fría" : "Caliente")}");
            Console.WriteLine($"Porciones: {Porciones}");
        }

        public override decimal CalcularCostoTotal()
        {
            return PrecioBase * Porciones;
        }
    }
}