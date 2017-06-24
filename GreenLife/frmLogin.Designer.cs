namespace GreenLife
{
    partial class frmLogin
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrsena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.mskContrsena = new System.Windows.Forms.MaskedTextBox();
            this.picIngresar = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIngresar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(36, 53);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(116, 31);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblContrsena
            // 
            this.lblContrsena.AutoSize = true;
            this.lblContrsena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrsena.Location = new System.Drawing.Point(36, 125);
            this.lblContrsena.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblContrsena.Name = "lblContrsena";
            this.lblContrsena.Size = new System.Drawing.Size(163, 31);
            this.lblContrsena.TabIndex = 1;
            this.lblContrsena.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(228, 46);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(276, 38);
            this.txtUsuario.TabIndex = 1;
            // 
            // mskContrsena
            // 
            this.mskContrsena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mskContrsena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskContrsena.Location = new System.Drawing.Point(228, 125);
            this.mskContrsena.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mskContrsena.Name = "mskContrsena";
            this.mskContrsena.PasswordChar = '*';
            this.mskContrsena.Size = new System.Drawing.Size(276, 38);
            this.mskContrsena.TabIndex = 2;
            // 
            // picIngresar
            // 
            this.picIngresar.Image = global::GreenLife.Properties.Resources.ingresar;
            this.picIngresar.Location = new System.Drawing.Point(150, 191);
            this.picIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.picIngresar.Name = "picIngresar";
            this.picIngresar.Size = new System.Drawing.Size(354, 132);
            this.picIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIngresar.TabIndex = 4;
            this.picIngresar.TabStop = false;
            this.picIngresar.Tag = "Ingresar al Sistema";
            this.picIngresar.Click += new System.EventHandler(this.picIngresar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(-6, -2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(10, 10);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(563, 360);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.picIngresar);
            this.Controls.Add(this.mskContrsena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContrsena);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN   GREEN LIFE";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIngresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrsena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox mskContrsena;
        private System.Windows.Forms.PictureBox picIngresar;
        private System.Windows.Forms.Button btnIngresar;
    }
}