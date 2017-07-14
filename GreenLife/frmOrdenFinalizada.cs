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
    public partial class frmOrdenFinalizada : Form
    {
        Decimal cambioOrden;
        public bool FinalOk { get; set; }
        public frmOrdenFinalizada(decimal Cambio)
        {
            InitializeComponent();
            cambioOrden = Cambio;
        }

        private void frmOrdenFinalizada_Load(object sender, EventArgs e)
        {
            lblCambio.Text = "Entregue el cambio = $" + cambioOrden;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            this.FinalOk =true;        
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
