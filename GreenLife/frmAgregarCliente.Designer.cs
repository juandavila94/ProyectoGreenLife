namespace GreenLife
{
    partial class frmAgregarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelarIngresoCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.mskDireccion = new System.Windows.Forms.MaskedTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.mskNombre = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardarCliente = new System.Windows.Forms.PictureBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.mskCedula = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarIngresoCliente
            // 
            this.btnCancelarIngresoCliente.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarIngresoCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarIngresoCliente.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarIngresoCliente.ForeColor = System.Drawing.Color.White;
            this.btnCancelarIngresoCliente.Location = new System.Drawing.Point(363, 585);
            this.btnCancelarIngresoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarIngresoCliente.Name = "btnCancelarIngresoCliente";
            this.btnCancelarIngresoCliente.Size = new System.Drawing.Size(241, 74);
            this.btnCancelarIngresoCliente.TabIndex = 49;
            this.btnCancelarIngresoCliente.Text = "CANCELAR";
            this.btnCancelarIngresoCliente.UseVisualStyleBackColor = false;
            this.btnCancelarIngresoCliente.Click += new System.EventHandler(this.btnCancelarIngresoCliente_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mskCedula);
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Controls.Add(this.btnGuardarCliente);
            this.panel1.Controls.Add(this.mskTelefono);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.mskDireccion);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.mskNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(175, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 465);
            this.panel1.TabIndex = 48;
            // 
            // mskTelefono
            // 
            this.mskTelefono.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefono.Location = new System.Drawing.Point(166, 270);
            this.mskTelefono.Mask = "0000000000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(417, 40);
            this.mskTelefono.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(18, 273);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(119, 33);
            this.lblTelefono.TabIndex = 40;
            this.lblTelefono.Text = "Telefono";
            // 
            // mskDireccion
            // 
            this.mskDireccion.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDireccion.Location = new System.Drawing.Point(166, 191);
            this.mskDireccion.Name = "mskDireccion";
            this.mskDireccion.Size = new System.Drawing.Size(417, 40);
            this.mskDireccion.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(18, 194);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(126, 33);
            this.lblDireccion.TabIndex = 38;
            this.lblDireccion.Text = "Direccion";
            // 
            // mskNombre
            // 
            this.mskNombre.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNombre.Location = new System.Drawing.Point(166, 104);
            this.mskNombre.Name = "mskNombre";
            this.mskNombre.Size = new System.Drawing.Size(417, 40);
            this.mskNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(18, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(117, 33);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Nombre";
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Image = global::GreenLife.Properties.Resources.guardar;
            this.btnGuardarCliente.Location = new System.Drawing.Point(166, 335);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(286, 76);
            this.btnGuardarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGuardarCliente.TabIndex = 45;
            this.btnGuardarCliente.TabStop = false;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(27, 34);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(104, 33);
            this.lblCedula.TabIndex = 46;
            this.lblCedula.Text = "Cedula";
            // 
            // mskCedula
            // 
            this.mskCedula.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCedula.Location = new System.Drawing.Point(166, 27);
            this.mskCedula.Mask = "0000000000";
            this.mskCedula.Name = "mskCedula";
            this.mskCedula.Size = new System.Drawing.Size(417, 40);
            this.mskCedula.TabIndex = 1;
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.btnCancelarIngresoCliente);
            this.Controls.Add(this.panel1);
            this.Name = "frmAgregarCliente";
            this.Text = "frmAgregarCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarIngresoCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnGuardarCliente;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox mskDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.MaskedTextBox mskNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox mskCedula;
        private System.Windows.Forms.Label lblCedula;
    }
}