using Datos;
using Datos.DTO;
using Interfaces;

namespace Logica
{
    public class Cliente : AbsPersona, ICompra
    {
        public override string cNombre()
        {
            throw new System.NotImplementedException();
        }

        public void ComprarProducto(ProductoDTO producto)
        {
            throw new System.NotImplementedException();
        }
    }
}
