namespace GreenLife
{
    partial class frmConsumidorOFactura
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.picFactura = new System.Windows.Forms.PictureBox();
            this.picCF = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCF)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 112);
            this.label2.TabIndex = 9;
            this.label2.Text = "CONSUMIDOR \r\nFINAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 62);
            this.label1.TabIndex = 8;
            this.label1.Text = "FACTURA";
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Berlin Sans FB Demi", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion.Location = new System.Drawing.Point(28, 42);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(892, 62);
            this.lblIndicacion.TabIndex = 7;
            this.lblIndicacion.Text = "ESCOJA EL TIPO DE FACTURACIÓN";
            // 
            // picFactura
            // 
            this.picFactura.Image = global::GreenLife.Properties.Resources.factura;
            this.picFactura.Location = new System.Drawing.Point(496, 237);
            this.picFactura.Name = "picFactura";
            this.picFactura.Size = new System.Drawing.Size(367, 271);
            this.picFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFactura.TabIndex = 6;
            this.picFactura.TabStop = false;
            this.picFactura.Click += new System.EventHandler(this.picFactura_Click);
            // 
            // picCF
            // 
            this.picCF.Image = global::GreenLife.Properties.Resources.picConsumidorFinal;
            this.picCF.Location = new System.Drawing.Point(80, 241);
            this.picCF.Name = "picCF";
            this.picCF.Size = new System.Drawing.Size(357, 280);
            this.picCF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCF.TabIndex = 5;
            this.picCF.TabStop = false;
            this.picCF.Click += new System.EventHandler(this.picCF_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(334, 577);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(281, 100);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "VOLVER";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmConsumidorOFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.picFactura);
            this.Controls.Add(this.picCF);
            this.Name = "frmConsumidorOFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsumidorOFactura";
            ((System.ComponentModel.ISupportInitialize)(this.picFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.PictureBox picFactura;
        private System.Windows.Forms.PictureBox picCF;
        private System.Windows.Forms.Button btnCancelar;
    }
}