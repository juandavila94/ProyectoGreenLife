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
    public partial class frmOrden : Form
    {
        public frmOrden()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlWraps.Visible = true;
            btnRegresar.Visible = true;
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            if (pnlMenu.Visible == true)
              btnRegresar.Visible = false;
           
        }

        private void btnEnsalada_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlEnsaladas.Visible = true;
            btnRegresar.Visible = true;
        }

        private void btnParfait_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlParfaits.Visible = true;
            btnRegresar.Visible = true;
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlBebidas.Visible = true;
            btnRegresar.Visible = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (pnlBebidas.Visible = true)
            {
                pnlBebidas.Visible = false;
            }
            if (pnlEnsaladas.Visible = true)
            {
                pnlEnsaladas.Visible = false;
            }
            if (pnlWraps.Visible = true)
            {
                pnlWraps.Visible = false;
            }
            if (pnlParfaits.Visible = true)
            {
                pnlParfaits.Visible = false;
            }
        
            btnRegresar.Visible = false;
            pnlMenu.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
