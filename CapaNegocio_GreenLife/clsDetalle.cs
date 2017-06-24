using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio_GreenLife
{
    public class clsDetalle
    {
        private int idDetalle;

        public int IdDetalle
        {
            get { return idDetalle; }
            set { idDetalle = value; }
        }
        private int idFactura;

        public int IdFactura
        {
            get { return idFactura; }
            set { idFactura = value; }
        }
        private int idPlato;

        public int IdPlato
        {
            get { return idPlato; }
            set { idPlato = value; }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
