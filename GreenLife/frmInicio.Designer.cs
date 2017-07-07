namespace GreenLife
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.picFacturar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.picSalir);
            this.panel1.Controls.Add(this.picFacturar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(93, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1423, 584);
            this.panel1.TabIndex = 8;
            // 
            // picSalir
            // 
            this.picSalir.BackColor = System.Drawing.Color.Transparent;
            this.picSalir.Image = global::GreenLife.Properties.Resources.icoSalir;
            this.picSalir.Location = new System.Drawing.Point(941, 67);
            this.picSalir.Margin = new System.Windows.Forms.Padding(4);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(454, 423);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSalir.TabIndex = 2;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // picFacturar
            // 
            this.picFacturar.BackColor = System.Drawing.Color.Transparent;
            this.picFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFacturar.Image = ((System.Drawing.Image)(resources.GetObject("picFacturar.Image")));
            this.picFacturar.Location = new System.Drawing.Point(13, 67);
            this.picFacturar.Margin = new System.Windows.Forms.Padding(4);
            this.picFacturar.Name = "picFacturar";
            this.picFacturar.Size = new System.Drawing.Size(451, 423);
            this.picFacturar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFacturar.TabIndex = 3;
            this.picFacturar.TabStop = false;
            this.picFacturar.Click += new System.EventHandler(this.picFacturar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GreenLife.Properties.Resources.icoAnular;
            this.pictureBox1.Location = new System.Drawing.Point(471, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 856);
            this.Controls.Add(this.panel1);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.PictureBox picFacturar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}