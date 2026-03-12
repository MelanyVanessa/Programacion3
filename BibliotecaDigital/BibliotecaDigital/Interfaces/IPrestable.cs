using System;

namespace BibliotecaDigital.Interfaces
{
    public interface IPrestable
    {
        DateTime CalcularFechaDevolucion();
        void GenerarComprobantePrestramo();
        decimal CalcularMultaPorRetraso(int diasRetraso);
    }
}
