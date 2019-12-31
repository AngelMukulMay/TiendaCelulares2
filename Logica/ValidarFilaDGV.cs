using System.Windows.Forms;

namespace Logica
{
    public class ValidarFilaDGV
    {
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
