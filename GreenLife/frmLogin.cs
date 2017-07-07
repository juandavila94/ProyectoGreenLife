using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio_GreenLife;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

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
            /*
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
            */
        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            var resultadoLogin = objUsuario.login(txtUsuario.Text, mskContrsena.Text);
            JavaScriptSerializer jss = new JavaScriptSerializer();
            
            List<clsUsuario> temp = JsonConvert.DeserializeObject<List<clsUsuario>>(jss.Serialize(resultadoLogin));
            if (temp.Count == 0)
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS!");
                mskContrsena.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();
            }
            else {
                int rol = temp[0].Rol;
                MessageBox.Show("GREEN LIFE", "BIENVENIDO");
                this.Hide();
                frmMenuPrincipal principal = new frmMenuPrincipal(txtUsuario.Text, rol);
                principal.Show();
            }
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
