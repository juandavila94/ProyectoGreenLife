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
    public partial class frmPrincipal : Form
    {
        int id = 0;

        public frmPrincipal(string userName, int access)
        {

            InitializeComponent();
            id = access;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //MdiClient ctlMDI;

            //// Loop through all of the form's controls looking
            //// for the control of type MdiClient.
            //foreach (Control ctl in this.Controls)
            //{
            //    try
            //    {
            //        // Attempt to cast the control to type MdiClient.
            //        ctlMDI = (MdiClient)ctl;

            //        // Set the BackColor of the MdiClient control.
            //        ctlMDI.BackColor = this.BackColor;
            //    }
            //    catch (InvalidCastException exc)
            //    {
            //        // Catch and ignore the error if casting failed.
            //        throw exc;
            //    }
            //}

            //// Display a child form to show this is still an MDI application.
          
        }
      

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Dispose();
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Dispose();
        }

        private void picFacturar_Click(object sender, EventArgs e)
        {
            frmOrden frmFactura = new frmOrden();
            frmFactura.Show();
  
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios Usuario = new frmUsuarios();
            Usuario.Show();
        }
    }
}
