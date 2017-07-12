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
    public partial class frmDatosFactura : Form
    {
        private decimal totalFactura = 0;
        private List<clsDetalle> ListaDeDetalles;
        clsCliente cliente1 = new clsCliente();

        public frmDatosFactura(List<clsDetalle> ListaDetalles, decimal totalFact)
        {
            InitializeComponent();
            totalFactura = Convert.ToDecimal(totalFact);
            ListaDeDetalles = ListaDetalles;
        }

        private void frmDatosFactura_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource= cliente1.consultarClientes();
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[3].Visible = false;
            dgvClientes.Columns[4].Visible = false;
            dgvClientes.Columns[1].Width = 100;
            dgvClientes.Columns[2].Width = 200;
            dgvClientes.ClearSelection(); 
            mskCedula.Text = String.Empty;
            mskNombre.Text = String.Empty;
            mskDireccion.Text =  String.Empty;
            mskTelefono.Text = String.Empty;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvClientes.SelectedCells.Count > 0)
            {

                int selectedrowindex = dgvClientes.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvClientes.Rows[selectedrowindex];
                mskCedula.Text = Convert.ToString(selectedRow.Cells["cedula"].Value);
                mskNombre.Text = Convert.ToString(selectedRow.Cells["nombre"].Value);
                mskDireccion.Text = Convert.ToString(selectedRow.Cells["direccion"].Value);
                mskTelefono.Text = Convert.ToString(selectedRow.Cells["telefono"].Value);

            }
        }

        private void btnBuscarPorCedula_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = cliente1.consultarClientesPorCedula(mskCedula.Text);
            this.DialogResult = DialogResult.None;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltroNombre.Text == string.Empty) { }
            else
            {
                dgvClientes.ClearSelection();
                dgvClientes.DataSource = cliente1.consultarClientesPorNombre(txtFiltroNombre.Text);
                dgvClientes.Columns[0].Visible = false;
                dgvClientes.Columns[3].Visible = false;
                dgvClientes.Columns[4].Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = cliente1.consultarClientesPorCedula(mskCedula.Text);
            this.DialogResult = DialogResult.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAC = new frmAgregarCliente();
            frmAC.ShowDialog();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
