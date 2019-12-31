using Datos.DTO;
using System.Windows.Forms;

namespace Logica
{
    /// <summary>
    /// Clase que sirve para obtener los datos seleccionados del datagridview.
    /// </summary>
    public class DataGridViewDato
    {
        public VentaDTO ObtenerDatosSeleccionadosDGV(DataGridView cNombreDGV)
        {
            VentaDTO Producto = new VentaDTO();

            string cNombreProducto = cNombreDGV.SelectedRows[0].Cells[0].Value + string.Empty;

            decimal dPrecioProducto = (decimal)cNombreDGV.SelectedRows[0].Cells[1].Value;

            Producto.cNombre = cNombreProducto;

            Producto.dPrecio = dPrecioProducto;

            return Producto;
        }
    }
}
