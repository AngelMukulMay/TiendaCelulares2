using Datos.DTO;
using System;
using System.Windows.Forms;

namespace Logica
{
    /// <summary>
    /// Clase que contiene las operaciones de un datagridview.
    /// </summary>
    public class DGV
    {
        public VentaDTO ObtenerDatosSeleccionadosDGV(DataGridView cNombreDGV)
        {
            VentaDTO Producto = new VentaDTO();

            string cNombreProducto = cNombreDGV.SelectedRows[0].Cells[0].Value + string.Empty;

            decimal dPrecioProducto = (decimal)cNombreDGV.SelectedRows[0].Cells[1].Value;

            Producto.cNombre = cNombreProducto;

            Producto.dPrecio = dPrecioProducto;

            Producto.dtFechaCompra = DateTime.Today;

            return Producto;
        }

        public bool ValidarFilaSeleccionada(DataGridView cNombreDGV)
        {
            if (cNombreDGV.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
