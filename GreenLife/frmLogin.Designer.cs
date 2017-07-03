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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrsena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.mskContrsena = new System.Windows.Forms.MaskedTextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnIngresarLogin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(64, 203);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(130, 37);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblContrsena
            // 
            this.lblContrsena.AutoSize = true;
            this.lblContrsena.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrsena.ForeColor = System.Drawing.Color.White;
            this.lblContrsena.Location = new System.Drawing.Point(10, 282);
            this.lblContrsena.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblContrsena.Name = "lblContrsena";
            this.lblContrsena.Size = new System.Drawing.Size(184, 37);
            this.lblContrsena.TabIndex = 1;
            this.lblContrsena.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(226, 203);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(337, 46);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "juandavila27";
            // 
            // mskContrsena
            // 
            this.mskContrsena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mskContrsena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskContrsena.Location = new System.Drawing.Point(226, 282);
            this.mskContrsena.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mskContrsena.Name = "mskContrsena";
            this.mskContrsena.PasswordChar = '*';
            this.mskContrsena.Size = new System.Drawing.Size(337, 46);
            this.mskContrsena.TabIndex = 2;
            this.mskContrsena.Text = "juandavila27";
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
            // btnIngresarLogin
            // 
            this.btnIngresarLogin.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIngresarLogin.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarLogin.ForeColor = System.Drawing.Color.Indigo;
            this.btnIngresarLogin.Location = new System.Drawing.Point(226, 378);
            this.btnIngresarLogin.Name = "btnIngresarLogin";
            this.btnIngresarLogin.Size = new System.Drawing.Size(337, 83);
            this.btnIngresarLogin.TabIndex = 4;
            this.btnIngresarLogin.Text = "INGRESAR";
            this.btnIngresarLogin.UseVisualStyleBackColor = false;
            this.btnIngresarLogin.Click += new System.EventHandler(this.btnIngresarLogin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSalir.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Indigo;
            this.btnSalir.Location = new System.Drawing.Point(644, 477);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 47);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::GreenLife.Properties.Resources.logo3;
            this.pictureBox1.Location = new System.Drawing.Point(226, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIngresarLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(751, 536);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIngresarLogin);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.mskContrsena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContrsena);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN   GREEN LIFE";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrsena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox mskContrsena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnIngresarLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}