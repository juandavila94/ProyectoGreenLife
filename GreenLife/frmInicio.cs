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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private static frmInicio m_FormDefInstance;
        public static frmInicio DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmInicio();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void picFacturar_Click(object sender, EventArgs e)
        {
            frmOrden orden = new frmOrden();
            orden.Show();
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Dispose();
        }
    }
}
