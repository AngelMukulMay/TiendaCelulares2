using Datos.DTO;
using Datos.Model;
using Interfaces;
using System.ComponentModel;

namespace Logica
{
    /// <summary>
    /// Clase que contiene las operaciones ventas.
    /// </summary>
    public class Venta : IVenta
    {
        public void AñadirVenta(VentaDTO datosVenta)
        {
            VentaModel.lstVentasModel.Add(datosVenta);
        }

        public BindingList<VentaDTO> LstVentas()
        {
            return VentaModel.lstVentasModel;
        }
    }
}
