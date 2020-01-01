using Datos.DTO;
using Datos.Model;
using Interfaces;
using System.ComponentModel;

namespace Logica
{
    /// <summary>
    /// Clase que contiene las operaciones de un producto.
    /// </summary>
    public class Producto : IProducto
    {
        public void AñadirProducto(ProductoDTO Producto)
        {
            ProductoModel.lstProductosModel.Add(Producto);
        }

        public BindingList<ProductoDTO> LstProductos()
        {
            return ProductoModel.lstProductosModel;
        }
    }
}