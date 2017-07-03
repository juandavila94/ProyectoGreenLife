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

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Id";
            c1.ValueType =  typeof(int); 
            c1.ReadOnly = true;
            c1.Width = 50;
            dgvOrden.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Nombre";
            c2.ValueType = typeof(string);
            c2.ReadOnly = true;
            c2.Width = 200;
            dgvOrden.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Cant";
            c3.ValueType = typeof(int);
            c3.ReadOnly = true;
            c3.Width = 60;
            dgvOrden.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.HeaderText = "Precio";
            c4.ValueType = typeof(decimal);
            c4.ReadOnly = true;
            c4.Width = 100;
            dgvOrden.Columns.Add(c4);


            dgvOrden.AllowUserToAddRows = false;

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

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void label14_Click(object sender, EventArgs e)
        {

        }

       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvOrden.Rows.Clear();
        }
        /////////////ENVIO DE DATOS DE LOS BOTONES DE PARFAITS///////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////

        private void picMaracuya_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 3.50m;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add("1", "Parfait Maracuya", "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt16(row.Cells[0].Value) == 1)
                    {
                        row.Cells[2].Value = (Convert.ToInt16(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add("1", "Parfait Maracuya", "1", ValorPlato);
                }

            }
            
        }

        private void picCompleto_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 3.00m;
            if (dgvOrden.RowCount == 0)
                this.dgvOrden.Rows.Add("2", "Parfait Completo", "1", ValorPlato);
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt16(row.Cells[0].Value) == 2)
                    {
                        row.Cells[2].Value = (Convert.ToInt16(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }

                }
                 if(encontrado==false)
                    {
                    this.dgvOrden.Rows.Add("2", "Parfait Completo", "1", ValorPlato);
                }
            }
        }

        private void picFrutosRojos_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        /////////////ENVIO DE DATOS DE LOS BOTONES DE ENSALADAS///////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void picGreenVeraniega_Click(object sender, EventArgs e)
        {

        }

        private void picGreenRusa_Click(object sender, EventArgs e)
        {

        }

        private void picGreenColeslaw_Click(object sender, EventArgs e)
        {

        }

        private void picGreenCesar_Click(object sender, EventArgs e)
        {

        }

        private void picGreenCapres_Click(object sender, EventArgs e)
        {

        }

        private void picGreenTulipan_Click(object sender, EventArgs e)
        {

        }
        /////////////ENVIO DE DATOS DE LOS BOTONES DE ENSALADAS///////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////

        private void picWrapGreenCriollo_Click(object sender, EventArgs e)
        {

        }

        private void picWrapGreenVegano_Click(object sender, EventArgs e)
        {

        }

        private void picWrapGreenAmericano_Click(object sender, EventArgs e)
        {

        }

        private void picWrapGreenCesar_Click(object sender, EventArgs e)
        {

        }

        private void picWrapGreenMar_Click(object sender, EventArgs e)
        {

        }

        private void picWrapGreenGriega_Click(object sender, EventArgs e)
        {

        }

        /////////////ENVIO DE DATOS DE LOS BOTONES DE BEBIDAS///////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void picAguaConGas_Click(object sender, EventArgs e)
        {

        }

        private void picLimonada_Click(object sender, EventArgs e)
        {

        }

        private void picPinkLimonade_Click(object sender, EventArgs e)
        {

        }

        private void picTeLimon_Click(object sender, EventArgs e)
        {

        }

        private void picTeDurazno_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }
    }
}
