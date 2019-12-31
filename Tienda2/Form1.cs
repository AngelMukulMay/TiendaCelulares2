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

        public Form1()
        {
            InitializeComponent();

            this.lstProductos = new BindingList<ProductoDTO>();
            this.lstVentas = new BindingList<VentaDTO>();
            this.AñadirProductos();
            this.dgvProductos.DataSource = lstProductos;
            this.dgvVentas.DataSource = lstVentas;

        }

        private void AñadirProductos()
        {
            this.lstProductos.Add(new ProductoDTO { cNombre = "Galaxy Note", dPrecio = 12000 });
            this.lstProductos.Add(new ProductoDTO { cNombre = "Galaxy Note plus ", dPrecio = 15000 });
            this.lstProductos.Add(new ProductoDTO { cNombre = "Galaxy Note 10", dPrecio = 19000 });
        }

        private void AñadirVenta(VentaDTO datosProducto)
        {
            this.lstVentas.Add(datosProducto);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            ValidarFilaDGV objValidarFila = new ValidarFilaDGV();

            Imprimir objImprimir = new Imprimir();

            bool filaSeleccionada = objValidarFila.ValidarFilaSeleccionada(dgvProductos);

            if (filaSeleccionada)
            {
                DataGridViewDato objDataGridViewDato = new DataGridViewDato();

                VentaDTO datosProducto = objDataGridViewDato.ObtenerDatosSeleccionadosDGV(dgvProductos);

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
