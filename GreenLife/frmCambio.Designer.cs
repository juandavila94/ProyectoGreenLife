namespace GreenLife
{
    partial class frmCambio
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
            this.mskEfectivo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTotal = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // mskEfectivo
            // 
            this.mskEfectivo.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskEfectivo.Location = new System.Drawing.Point(480, 278);
            this.mskEfectivo.Mask = "999.99";
            this.mskEfectivo.Name = "mskEfectivo";
            this.mskEfectivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mskEfectivo.Size = new System.Drawing.Size(260, 73);
            this.mskEfectivo.TabIndex = 46;
            this.mskEfectivo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskEfectivo_MaskInputRejected);
            this.mskEfectivo.TextChanged += new System.EventHandler(this.mskEfectivo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 66);
            this.label2.TabIndex = 48;
            this.label2.Text = "EFectivo";
            // 
            // mskTotal
            // 
            this.mskTotal.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTotal.Location = new System.Drawing.Point(480, 191);
            this.mskTotal.Name = "mskTotal";
            this.mskTotal.ReadOnly = true;
            this.mskTotal.Size = new System.Drawing.Size(260, 73);
            this.mskTotal.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 66);
            this.label1.TabIndex = 46;
            this.label1.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(877, 66);
            this.label3.TabIndex = 53;
            this.label3.Text = "INGRESE EL EFECTIVO RECIBIDO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::GreenLife.Properties.Resources.print;
            this.btnGuardar.Location = new System.Drawing.Point(257, 461);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(413, 108);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(333, 615);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(278, 105);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "VOLVER";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mskEfectivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskTotal);
            this.Controls.Add(this.label1);
            this.Name = "frmCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCambio";
            this.Load += new System.EventHandler(this.frmCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.MaskedTextBox mskEfectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
    }
}