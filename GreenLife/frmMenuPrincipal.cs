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
    public partial class frmMenuPrincipal : Form
    {
        int id = 0;

        public frmMenuPrincipal(string userName, int access)
        {

            InitializeComponent();
            id = access;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {


        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios Usuario = new frmUsuarios();
            Usuario.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInicio.DefInstance.MdiParent = this;
            frmInicio.DefInstance.Show(); 
        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Dispose();
        }
    }
}
