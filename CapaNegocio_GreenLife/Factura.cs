using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio_GreenLife
{
    public class Factura
    {
        private int idFactura;

        public int IdFactura
        {
            get { return idFactura; }
            set { idFactura = value; }
        }
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        private int idCliente;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string metodoDePago;

        public string MetodoDePago
        {
            get { return metodoDePago; }
            set { metodoDePago = value; }
        }
        private decimal subtotal;

        public decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        private decimal iva;

        public decimal Iva
        {
            get { return iva; }
            set { iva = value; }
        }
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
