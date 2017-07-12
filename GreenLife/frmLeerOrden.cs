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
    public partial class frmLeerOrden : Form
    {
        private int caseSwitch = 0;
        private decimal totalFactura=0;
        private List<clsDetalle> ListaDeDetalles;
        public frmLeerOrden(object dataSource,string total, List<clsDetalle> ListaDetalles)
        {
            InitializeComponent();
            dgvLeerOrden.DataSource = dataSource;
            lblTotal.Text = "TOTAL = " + total;
            dgvLeerOrden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; ;
            totalFactura = Convert.ToDecimal(total);
            ListaDeDetalles = ListaDetalles;

        }

        private void frmLeerOrden_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
            timer1.Enabled = true;
            dgvLeerOrden.AllowUserToAddRows = false;
            dgvLeerOrden.AllowUserToDeleteRows = false;
            dgvLeerOrden.ReadOnly = true;
            dgvLeerOrden.RowTemplate.Height = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            caseSwitch++;
            switch (caseSwitch)
            {
                case 1:
                    lblIndicacion.ForeColor = Color.Indigo;
                    break;
                case 2:
                    lblIndicacion.ForeColor = Color.Indigo;                    
                    break;
                case 3:
                    lblIndicacion.ForeColor = Color.Indigo;
                    break;
                case 4:
                    lblIndicacion.ForeColor = Color.Indigo;
                    break;
                case 5:
                    lblIndicacion.ForeColor = Color.DarkGreen;
                    break;
                case 6:
                    lblIndicacion.ForeColor = Color.DarkGreen;
                    break;
                case 7:
                    lblIndicacion.ForeColor = Color.DarkGreen;
                    break;
                case 8:
                    lblIndicacion.ForeColor = Color.DarkGreen;
                    break;

            }
            if (caseSwitch == 8) caseSwitch = 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            frmConsumidorOFactura frmCF = new frmConsumidorOFactura(ListaDeDetalles,totalFactura);
            frmCF.ShowDialog();
            this.Dispose();
        }
    }
}
