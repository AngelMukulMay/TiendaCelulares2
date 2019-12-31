using Datos.DTO;
using System.ComponentModel;

namespace Datos.Model
{
    /// <summary>
    /// Clase que contiene la lista de productos.
    /// </summary>
    public static class ProductoModel
    {
        public static BindingList<ProductoDTO> lstProductosModel { get; set; } = new BindingList<ProductoDTO>() {
            new ProductoDTO { cNombre = "Galaxy Note", dPrecio = 12000 },
            new ProductoDTO { cNombre = "Galaxy Note plus ", dPrecio = 15000 },
            new ProductoDTO { cNombre = "Galaxy Note 10", dPrecio = 19000 }
        };

    }
}
