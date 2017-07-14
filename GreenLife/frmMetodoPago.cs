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
    public partial class frmMetodoPago : Form
    {
        private decimal totalFactura = 0;
        private List<clsDetalle> ListaDeDetalles;
        public frmMetodoPago(List<clsDetalle> ListaDetalles, decimal totalFact)
        {
            InitializeComponent();
            totalFactura = Convert.ToDecimal(totalFact);
            ListaDeDetalles = ListaDetalles;
        }

        private void frmMetodoPago_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picEfectivo_Click(object sender, EventArgs e)
        {
            using (var form = new frmCambio(ListaDeDetalles, totalFactura))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }

            this.Dispose();


            
            
        }
    }
}
