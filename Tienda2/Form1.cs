using Datos.DTO;
using Logica;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Tienda2
{
    public partial class Form1 : Form
    {
        private BindingList<ProductoDTO> lstProductos;
        private BindingList<VentaDTO> lstVentas;

        Producto objProducto = new Producto();
        Venta objVenta = new Venta();

        public Form1()
        {
            InitializeComponent();

            lstProductos = objProducto.LstProductos();
            lstVentas = objVenta.LstVentas();

            this.dgvProductos.DataSource = lstProductos;
            this.dgvVentas.DataSource = lstVentas;

        }

        /// <summary>
        /// Añade un producto seleccionado a la lista de ventas.
        /// </summary>
        /// <param name="datosProducto"></param>
        private void AñadirVenta(VentaDTO datosProducto)
        {
            objVenta.AñadirVenta(datosProducto);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            DGV objDGV = new DGV();

            Imprimir objImprimir = new Imprimir();

            bool filaSeleccionada = objDGV.ValidarFilaSeleccionada(dgvProductos);

            if (filaSeleccionada)
            {

                VentaDTO datosProducto = objDGV.ObtenerDatosSeleccionadosDGV(dgvProductos);

                AñadirVenta(datosProducto);

                string cMensaje = "Compra realizada con éxito";

                objImprimir.ImprimirMensaje(cMensaje);

            }
            else
            {
                string cMensaje = "Por favor seleccione una fila";

                objImprimir.ImprimirMensaje(cMensaje);
            }

            dgvProductos.ClearSelection();
            dgvVentas.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProductos.ClearSelection();
            dgvVentas.ClearSelection();
        }

    }
}
