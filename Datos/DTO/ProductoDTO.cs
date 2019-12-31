using System.ComponentModel;

namespace Datos.DTO
{
    /// <summary>
    /// Clase para los productos.
    /// </summary>
    public class ProductoDTO : INotifyPropertyChanged
    {
        private string Nombre;

        private decimal Precio;

        public ProductoDTO()
        {

        }

        public ProductoDTO(string cNombre, decimal dPrecio)
        {
            this.cNombre = cNombre;
            this.dPrecio = dPrecio;
        }

        /// <summary>
        /// Al modificarse los valores de la lista, se levanta un evento que indica que hubieron cambios.
        /// </summary>
        /// <param name="cPropiedadNombre">Nombre de la propiedad</param>
        protected virtual void OnPropretyChanged(string cPropiedadNombre)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(cPropiedadNombre));
        }

        public string cNombre
        {
            get
            {
                return this.Nombre;
            }
            set
            {
                if (this.Nombre != value)
                {
                    this.Nombre = value;
                    this.OnPropretyChanged("cNombre");
                }
            }
        }

        public decimal dPrecio
        {
            get
            {
                return this.Precio;
            }
            set
            {
                if(this.Precio != value)
                {
                    this.Precio = value;
                    this.OnPropretyChanged("dPrecio");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
