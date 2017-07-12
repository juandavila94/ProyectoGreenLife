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
    public partial class frmConsumidorOFactura : Form
    {
        private decimal totalFactura = 0;
        private List<clsDetalle> ListaDeDetalles;
        public frmConsumidorOFactura(List<clsDetalle> ListaDetalles,decimal totalFact)
        {
            InitializeComponent();
            totalFactura = Convert.ToDecimal(totalFact);
            ListaDeDetalles = ListaDetalles;
        }

        private void picCF_Click(object sender, EventArgs e)
        {
            frmMetodoPago frmCF = new frmMetodoPago(ListaDeDetalles, totalFactura);
            frmCF.ShowDialog();
        }

        private void picFactura_Click(object sender, EventArgs e)
        {
            frmDatosFactura frmCF = new frmDatosFactura(ListaDeDetalles, totalFactura);
            frmCF.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
