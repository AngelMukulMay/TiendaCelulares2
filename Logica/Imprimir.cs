using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Logica
{
    public class Imprimir : IImprimir
    {
        public void ImprimirMensaje(string cMensaje)
        {
            MessageBox.Show(cMensaje);
        }
    }
}
