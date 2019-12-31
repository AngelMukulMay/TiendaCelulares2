using Datos.DTO;
using System.ComponentModel;

namespace Interfaces
{
    public interface IVenta
    {
        void AñadirVenta(VentaDTO datosVenta);

        BindingList<VentaDTO> LstVentas();
    }
}
