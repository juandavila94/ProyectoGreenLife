﻿using CapaNegocio_GreenLife;
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
    public partial class frmAgregarCliente : Form
    {
        clsCliente cliente1 = new clsCliente();
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente1.insertarCliente(mskCedula.Text, mskNombre.Text, mskDireccion.Text, mskTelefono.Text);
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ingresar el cliente, verifique los datos");            
            }
            

        }

        private void btnCancelarIngresoCliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
