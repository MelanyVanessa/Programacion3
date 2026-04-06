using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Concesionario_de_Vehículos.Interfaces
{
    public interface IVendible
    {

        void GenerarFacturaVenta();
        void CalcularComisionVendedor();
        void CalcularPrecioFinal();

    }
}
