using CapaNegocio_GreenLife;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace GreenLife
{
    public partial class frmCambio : Form
    {
        private decimal totalFactura = 0;
        private List<clsDetalle> ListaDeDetalles;
        clsFactura objFactura= new clsFactura ();
        clsDetalle objDetalle = new clsDetalle();
        private string tipoDePago;
        public frmCambio(List<clsDetalle> ListaDetalles, decimal totalFact,string tipoPago)
        {
            InitializeComponent();
            totalFactura = Convert.ToDecimal(totalFact);
            ListaDeDetalles = ListaDetalles;
            mskTotal.Text = totalFactura.ToString();
            tipoDePago = tipoPago;
        }

        private void mskEfectivo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskEfectivo_TextChanged(object sender, EventArgs e)
        {
            
        }
    
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (mskEfectivo.Text != string.Empty)
            {
                decimal efectivo = Convert.ToDecimal(mskEfectivo.Text);
                if (efectivo > totalFactura)
                {
                    decimal cambio = (efectivo - totalFactura);
                    using (var form = new frmOrdenFinalizada(cambio))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    Decimal total = Convert.ToDecimal(mskTotal.Text);
                    Decimal iva = decimal.Round(total * 0.12m, 2);
                    Decimal subototal = total - iva;
                    try
                    {

                        objFactura.insertarFactura(Global.IdUsuario, Global.IdCliente, DateTime.Now, tipoDePago, subototal, iva, total);
                       
                        int idSiguiente = objFactura.consultarUltimoIDFactura();
                        foreach (clsDetalle detalle in ListaDeDetalles)
                            objDetalle.insertarDetalle(idSiguiente, detalle.IdPlato, detalle.Cantidad, detalle.Precio);
                            
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar en la base de datos");
                    }   
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("El efectivo ingresado es menor al total de la orden");
                }
            }
            else
            {
                MessageBox.Show("ESCRIBA EL EFECTIVO QUE LE DIO EL CLIENTE");
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

        private bool alreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        private void mskEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (mskEfectivo.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (mskEfectivo.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(mskEfectivo.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (mskEfectivo.SelectionStart != mskEfectivo.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = mskEfectivo.Text.Substring(mskEfectivo.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(mskEfectivo.Text, ref sepratorChar))
                {
                    int sepratorPosition = mskEfectivo.Text.IndexOf(sepratorChar);
                    string afterSepratorString = mskEfectivo.Text.Substring(sepratorPosition + 1);
                    if (mskEfectivo.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mskTotal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
