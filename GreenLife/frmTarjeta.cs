using CapaNegocio_GreenLife;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GreenLife
{
    public partial class frmTarjeta : Form
    {
        private decimal totalFactura = 0;
        private List<clsDetalle> ListaDeDetalles;
        clsFactura objFactura = new clsFactura();
        clsDetalle objDetalle = new clsDetalle();
        private string tipoDePago;

        public frmTarjeta(List<clsDetalle> ListaDetalles, decimal totalFact, string tipoPago)
        {
            InitializeComponent();
            totalFactura = Convert.ToDecimal(totalFact);
            ListaDeDetalles = ListaDetalles;
            mskTotal.Text = totalFactura.ToString();
            tipoDePago = tipoPago;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            using (var form = new frmOrdenFinalizadaTarjeta())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            Decimal total = Convert.ToDecimal(mskTotal.Text);
            Decimal iva = decimal.Round(total * 0.12m, 2);
            Decimal subototal = total - iva;
            try
            {

                objFactura.insertarFactura(Global.IdUsuario, Global.IdCliente, DateTime.Now, tipoDePago, subototal, iva, total);

                int idSiguiente = objFactura.consultarUltimoIDFactura();
                foreach (clsDetalle detalle in ListaDeDetalles)
                    objDetalle.insertarDetalle(idSiguiente, detalle.IdPlato, detalle.Cantidad, detalle.Precio);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos");
            }
            this.Dispose();
        }
    
           
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void frmTarjeta_Load(object sender, EventArgs e)
        {

        }
    }
}
