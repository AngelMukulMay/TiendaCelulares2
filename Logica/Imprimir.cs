using Interfaces;
using System.Windows.Forms;

namespace Logica
{
    /// <summary>
    /// Clase que sirve para imprimir mensajes genéricos.
    /// </summary>
    public class Imprimir : IImprimir
    {
        public void ImprimirMensaje(string cMensaje)
        {
            MessageBox.Show(cMensaje);
        }
    }
}
