using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio_GreenLife;

namespace GreenLife
{
    public partial class frmLogin : Form
    {
        clsUsuario objUsuario = new clsUsuario();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        
        private void picIngresar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
