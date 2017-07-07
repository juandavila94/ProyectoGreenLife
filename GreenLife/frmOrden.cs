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
    public partial class frmOrden : Form
    {
        decimal decTotal = 0;
        public frmOrden()
        {
            InitializeComponent();
        }
        private static frmOrden m_FormDefInstance;
        public static frmOrden DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmOrden();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
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
            dgvOrden.AllowUserToDeleteRows = false;
            dgvOrden.ReadOnly = true;
            dgvOrden.RowTemplate.Height = 50;

        }

        private void CalcularTotal()
        {
            decTotal = 0;
            if (dgvOrden.RowCount == 0)
            {
                decTotal = 0;
                txtTotal.Text = string.Empty;
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {

                    decTotal += (Convert.ToDecimal(row.Cells[3].Value));

                }
                txtTotal.Text = "$= " + decTotal.ToString();
            }
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
            CalcularTotal();
            txtTotal.Text = string.Empty;
        }
      

        /////////////ENVIO DE DATOS DE LOS BOTONES DE ENSALADAS///////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 5.50m;
            int idPlato = 1;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Griega", "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Griega", "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

      
        private void picGreenRusa_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 4.99m;
            int idPlato = 2;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Rusa", "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Rusa", "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picGreenColeslaw_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 4.50m;
            int idPlato = 3;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Coleslaw", "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Coleslaw", "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picGreenCesar_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 3.99m;
            int idPlato = 4;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Cesar", "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Cesar", "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picGreenCapres_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 6.99m;
            int idPlato = 5;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Capres", "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Capres", "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picGreenTulipan_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 4.50m;
            int idPlato = 6;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Tulipan", "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Tulipan", "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picGreenVeraniega_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 6.50m;
            int idPlato =7;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Veraniega", "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, "Ensalada Green-Veraniega", "1", ValorPlato);
                }
            }
            CalcularTotal();
        }
        /////////////ENVIO DE DATOS DE LOS BOTONES DE WRAPS///////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////

        private void picWrapGreenCriollo_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 4.50m;
            string nombrePlato = "Wrap Green-Criollo";
            int idPlato = 8;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picWrapGreenVegano_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 3.99m;
            string nombrePlato = "Wrap Green-Vegano";
            int idPlato = 9;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picWrapGreenAmericano_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 4.99m;
            string nombrePlato = "Wrap Green-Americano";
            int idPlato = 10;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picWrapGreenCesar_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 4.99m;
            string nombrePlato = "Wrap Green-Cesar";
            int idPlato = 11;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picWrapGreenMar_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 5.99m;
            string nombrePlato = "Wrap Green-Mar";
            int idPlato = 12;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picWrapGreenGriega_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 5.25m;
            string nombrePlato = "Wrap Green-Griego";
            int idPlato = 13;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }
        /////////////ENVIO DE DATOS DE LOS BOTONES DE PARFAITS///////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////

       

        private void picCompleto_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 2.99m;
            string nombrePlato = "Parfait Completo";
            int idPlato = 14;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 3.50m;
            string nombrePlato = "Parfait Greengurt";
            int idPlato = 15;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }
        private void picFrutosRojos_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 2.99m;
            string nombrePlato = "Parfait Fruto Rojos";
            int idPlato = 16;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }
      

        private void picMaracuya_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 4.50m;
            string nombrePlato = "Parfait Maracuya";
            int idPlato = 17;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }
        /////////////ENVIO DE DATOS DE LOS BOTONES DE BEBIDAS///////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 1.00m;
            string nombrePlato = "Agua";
            int idPlato = 20;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picAguaConGas_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 1.00m;
            string nombrePlato = "Agua con gas";
            int idPlato = 21;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picLimonada_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 2.30m;
            string nombrePlato = "Limonada";
            int idPlato = 24;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picPinkLimonade_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 2.30m;
            string nombrePlato = "Pink lemonade";
            int idPlato = 25;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picTeLimon_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 2.30m;
            string nombrePlato = "Te limon";
            int idPlato = 23;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void picTeDurazno_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 2.30m;
            string nombrePlato = "Te durazno";
            int idPlato = 22;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Decimal ValorPlato = 1m;
            string nombrePlato = "Cola 250 ml";
            int idPlato = 18;
            if (dgvOrden.RowCount == 0)
            {
                this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrden.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == idPlato)
                    {
                        row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value)) + 1;
                        row.Cells[3].Value = (Convert.ToDecimal(row.Cells[3].Value)) + ValorPlato;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    this.dgvOrden.Rows.Add(idPlato, nombrePlato, "1", ValorPlato);
                }
            }
            CalcularTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell celdaSeleccionada in dgvOrden.SelectedCells)
            {
                if (celdaSeleccionada.Selected)
                    dgvOrden.Rows.RemoveAt(celdaSeleccionada.RowIndex);
            }
            CalcularTotal();
        }
        public DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn columnaOrden in dgv.Columns)
            {
                if (columnaOrden.Visible)
                {
                    DataColumn columnaAEnviar;
                    columnaAEnviar = new DataColumn();
                    columnaAEnviar.ColumnName = columnaOrden.HeaderText;
                    columnaAEnviar.DataType = columnaOrden.ValueType;
                    
                    dt.Columns.Add(columnaAEnviar);
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (dgvOrden.RowCount == 0)
                MessageBox.Show("LA ORDEN ESTA VACIA");


            List<clsDetalle> ListaDetalles = new List<clsDetalle>();
            foreach (DataGridViewRow row in dgvOrden.Rows)
            {
                clsDetalle detalle = new clsDetalle(Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[2].Value), Convert.ToDecimal(row.Cells[3].Value));
                ListaDetalles.Add(detalle);
            }
            
            frmLeerOrden leerOrden = new frmLeerOrden(GetDataTableFromDGV(dgvOrden),txtTotal.Text);
            leerOrden.Show();

        }
    }
}
