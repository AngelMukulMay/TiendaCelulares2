using Datos.DTO;
using System.ComponentModel;

namespace Datos.Model
{
    /// <summary>
    /// Clase que contiene la lista de ventas
    /// </summary>
    public class VentaModel
    {
        public static BindingList<VentaDTO> lstVentasModel { get; set; } = new BindingList<VentaDTO>();
    }
}
