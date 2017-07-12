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
        public frmMetodoPago(List<clsDetalle> ListaDeDetalles, decimal totalFactura)
        {
            InitializeComponent();
        }

        private void frmMetodoPago_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
