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
    public partial class frmOrdenFinalizadaTarjeta : Form
    {
        public frmOrdenFinalizadaTarjeta()
        {
            InitializeComponent();
        }

        private void frmOrdenFinalizadaTarjeta_Load(object sender, EventArgs e)
        {

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
