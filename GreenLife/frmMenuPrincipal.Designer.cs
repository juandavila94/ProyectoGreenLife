namespace GreenLife
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Berlin Sans FB", 22F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.uSUARIOSToolStripMenuItem,
            this.rEPORTESToolStripMenuItem,
            this.cLIENTESToolStripMenuItem1,
            this.sALIRToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1540, 49);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 45);
            this.toolStripMenuItem1.Text = "INICIO";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(193, 45);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(200, 45);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // cLIENTESToolStripMenuItem1
            // 
            this.cLIENTESToolStripMenuItem1.Name = "cLIENTESToolStripMenuItem1";
            this.cLIENTESToolStripMenuItem1.Size = new System.Drawing.Size(182, 45);
            this.cLIENTESToolStripMenuItem1.Text = "CLIENTES";
            // 
            // sALIRToolStripMenuItem1
            // 
            this.sALIRToolStripMenuItem1.Name = "sALIRToolStripMenuItem1";
            this.sALIRToolStripMenuItem1.Size = new System.Drawing.Size(120, 45);
            this.sALIRToolStripMenuItem1.Text = "SALIR";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // diarioToolStripMenuItem
            // 
            this.diarioToolStripMenuItem.Name = "diarioToolStripMenuItem";
            this.diarioToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // mensualToolStripMenuItem
            // 
            this.mensualToolStripMenuItem.Name = "mensualToolStripMenuItem";
            this.mensualToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1540, 760);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenuPrincipal";
            this.Text = "GREEN LIFE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem1;
    }
}