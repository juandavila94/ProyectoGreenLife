using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos_GreenLife;

namespace CapaNegocio_GreenLife
{
    public class clsFactura
    {
        clsDatosFactura objDatosFactura = new clsDatosFactura();

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

        public void insertarFactura(int idUser, int idClient, DateTime fech, string payMethod, decimal subtot, decimal tax, decimal tot)
        {
            try
            {
                IdUsuario = idUser;
                IdCliente = idClient;
                Fecha = fech;
                MetodoDePago = payMethod;
                Subtotal = subtot;
                Iva = tax;
                Total = tot;

                objDatosFactura.InsertarFactura(IdUsuario, IdCliente, Fecha, MetodoDePago, Subtotal, Iva, Total);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void anularFactura(int id)
        {
            try
            {
                IdFactura = id;
                objDatosFactura.AnularFactura(IdFactura);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object consultarFacturasDia(DateTime dia)
        {
            try
            {
                Fecha = dia;
                return objDatosFactura.ConsultarFacturasDia(Fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object consultarFacturacionDiaria(DateTime dia)
        {
            try
            {
                Fecha = dia;
                return objDatosFactura.ConsultarFacturacionDiaria(Fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object consultarFacturasPorCliente(int idClient)
        {
            try
            {
                IdCliente = idClient;
                return objDatosFactura.ConsultarFacturasPorCliente(IdCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object consultarFacturasPorUsuario(int idUser)
        {
            try
            {
                IdUsuario = idUser;
                return objDatosFactura.ConsultarFacturasPorUsuario(IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
              public int consultarUltimoIDFactura ()
            {
            try
            {
                return objDatosFactura.ConsultarUltimoIDFactura();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
