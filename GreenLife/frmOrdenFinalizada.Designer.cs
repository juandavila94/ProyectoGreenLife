namespace GreenLife
{
    partial class frmOrdenFinalizada
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
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Berlin Sans FB Demi", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion.Location = new System.Drawing.Point(217, 27);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(445, 62);
            this.lblIndicacion.TabIndex = 8;
            this.lblIndicacion.Text = "FIN DEL PEDIDO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 108);
            this.label1.TabIndex = 9;
            this.label1.Text = "Recuerde entregar el recibo\r\n o la factura al cliente\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(198, 254);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(0, 54);
            this.lblCambio.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GreenLife.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFacturar.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Location = new System.Drawing.Point(316, 334);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(246, 82);
            this.btnFacturar.TabIndex = 23;
            this.btnFacturar.Text = "CONTINUAR";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // frmOrdenFinalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 419);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIndicacion);
            this.Name = "frmOrdenFinalizada";
            this.Text = "frmOrdenFinalizada";
            this.Load += new System.EventHandler(this.frmOrdenFinalizada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFacturar;
    }
}