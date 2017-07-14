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
    public partial class frmCambio : Form
    {
        private decimal totalFactura = 0;
        private List<clsDetalle> ListaDeDetalles;
        public frmCambio(List<clsDetalle> ListaDetalles, decimal totalFact)
        {
            InitializeComponent();
            totalFactura = Convert.ToDecimal(totalFact);
            ListaDeDetalles = ListaDetalles;
            mskTotal.Text = totalFactura.ToString();
        }

        private void mskEfectivo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskEfectivo_TextChanged(object sender, EventArgs e)
        {
            
        }
    
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal efectivo = Convert.ToDecimal(mskEfectivo.Text);
            if (efectivo > totalFactura) {
                decimal cambio = (efectivo - totalFactura);
                using (var form = new frmOrdenFinalizada(cambio))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }

                this.Dispose();                   
            }
            else
            {
                MessageBox.Show("El efectivo ingresado es menor al total de la orden");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCambio_Load(object sender, EventArgs e)
        {
            mskEfectivo.Focus();
            mskEfectivo.SelectionStart = mskEfectivo.Text.Length;
        }
    }
}
