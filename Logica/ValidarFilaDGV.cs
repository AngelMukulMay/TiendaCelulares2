using System.Windows.Forms;

namespace Logica
{
    /// <summary>
    /// Clase que valida si existe una fila seleccionada en el datagridview
    /// </summary>
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
