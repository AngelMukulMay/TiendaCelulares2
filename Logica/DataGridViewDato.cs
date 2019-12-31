using Datos.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Logica
{
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
