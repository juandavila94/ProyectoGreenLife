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
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.picTarjeta = new System.Windows.Forms.PictureBox();
            this.picEfectivo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEfectivo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Berlin Sans FB Demi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion.Location = new System.Drawing.Point(58, 9);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(851, 68);
            this.lblIndicacion.TabIndex = 2;
            this.lblIndicacion.Text = "ESCOJA EL METODO DE PAGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "TARJETA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 68);
            this.label2.TabIndex = 4;
            this.label2.Text = "EFECTIVO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(352, 601);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(278, 105);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "VOLVER";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // picTarjeta
            // 
            this.picTarjeta.Image = global::GreenLife.Properties.Resources.picTarjeta1;
            this.picTarjeta.Location = new System.Drawing.Point(482, 199);
            this.picTarjeta.Name = "picTarjeta";
            this.picTarjeta.Size = new System.Drawing.Size(383, 293);
            this.picTarjeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTarjeta.TabIndex = 1;
            this.picTarjeta.TabStop = false;
            this.picTarjeta.Click += new System.EventHandler(this.picTarjeta_Click);
            // 
            // picEfectivo
            // 
            this.picEfectivo.Image = global::GreenLife.Properties.Resources.picEfectivo;
            this.picEfectivo.Location = new System.Drawing.Point(70, 199);
            this.picEfectivo.Name = "picEfectivo";
            this.picEfectivo.Size = new System.Drawing.Size(383, 293);
            this.picEfectivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEfectivo.TabIndex = 0;
            this.picEfectivo.TabStop = false;
            this.picEfectivo.Click += new System.EventHandler(this.picEfectivo_Click);
            // 
            // frmMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.picTarjeta);
            this.Controls.Add(this.picEfectivo);
            this.Name = "frmMetodoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnCancelar;
    }
}