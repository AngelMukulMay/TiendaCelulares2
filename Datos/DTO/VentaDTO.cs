using System;
using System.ComponentModel;

namespace Datos.DTO
{
    /// <summary>
    /// Clase para las ventas.
    /// </summary>
    public class VentaDTO
    {
        private string Nombre;

        private decimal Precio;

        private DateTime FechaCompra;

        public VentaDTO()
        {

        }

        public VentaDTO(string cNombre, decimal dPrecio, DateTime dtFechaCompra)
        {
            this.cNombre = cNombre;
            this.dPrecio = dPrecio;
            this.dtFechaCompra = dtFechaCompra;
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
                if (this.Precio != value)
                {
                    this.Precio = value;

                    this.OnPropretyChanged("dPrecio");
                }
            }
        }

        public DateTime dtFechaCompra
        {
            get
            {
                return this.FechaCompra;
            }
            set
            {
                if (this.FechaCompra != value)
                {

                    this.FechaCompra = value;

                    this.OnPropretyChanged("dtFechaCompra");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}