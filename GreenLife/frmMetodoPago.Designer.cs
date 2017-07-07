namespace GreenLife
{
    partial class frmMetodoPago
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
            this.picTarjeta = new System.Windows.Forms.PictureBox();
            this.picEfectivo = new System.Windows.Forms.PictureBox();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEfectivo)).BeginInit();
            this.SuspendLayout();
            // 
            // picTarjeta
            // 
            this.picTarjeta.Image = global::GreenLife.Properties.Resources.picTarjeta1;
            this.picTarjeta.Location = new System.Drawing.Point(462, 114);
            this.picTarjeta.Name = "picTarjeta";
            this.picTarjeta.Size = new System.Drawing.Size(383, 293);
            this.picTarjeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTarjeta.TabIndex = 1;
            this.picTarjeta.TabStop = false;
            // 
            // picEfectivo
            // 
            this.picEfectivo.Image = global::GreenLife.Properties.Resources.picEfectivo;
            this.picEfectivo.Location = new System.Drawing.Point(50, 114);
            this.picEfectivo.Name = "picEfectivo";
            this.picEfectivo.Size = new System.Drawing.Size(383, 293);
            this.picEfectivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEfectivo.TabIndex = 0;
            this.picEfectivo.TabStop = false;
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion.Location = new System.Drawing.Point(215, 20);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(485, 39);
            this.lblIndicacion.TabIndex = 2;
            this.lblIndicacion.Text = "ESCOJA EL METODO DE PAGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "TARJETA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "EFECTIVO";
            // 
            // frmMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.picTarjeta);
            this.Controls.Add(this.picEfectivo);
            this.Name = "frmMetodoPago";
            this.Text = "frmMetodoPago";
            this.Load += new System.EventHandler(this.frmMetodoPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEfectivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEfectivo;
        private System.Windows.Forms.PictureBox picTarjeta;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}