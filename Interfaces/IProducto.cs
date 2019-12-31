using Datos.DTO;
using System.ComponentModel;

namespace Interfaces
{
    public interface IProducto
    {
        void AñadirProducto(ProductoDTO Producto);

        BindingList<ProductoDTO> LstProductos();
    }
}
