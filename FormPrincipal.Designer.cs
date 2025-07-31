namespace AdministracionCondominio
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.residenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicioMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.residenteToolStripMenuItem,
            this.apartamentoToolStripMenuItem,
            this.cuotaToolStripMenuItem,
            this.pagoToolStripMenuItem,
            this.servicioMantenimientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // residenteToolStripMenuItem
            // 
            this.residenteToolStripMenuItem.Name = "residenteToolStripMenuItem";
            this.residenteToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.residenteToolStripMenuItem.Text = "Residentes";
            this.residenteToolStripMenuItem.Click += new System.EventHandler(this.residenteToolStripMenuItem_Click);
            // 
            // apartamentoToolStripMenuItem
            // 
            this.apartamentoToolStripMenuItem.Name = "apartamentoToolStripMenuItem";
            this.apartamentoToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.apartamentoToolStripMenuItem.Text = "Apartamentos";
            this.apartamentoToolStripMenuItem.Click += new System.EventHandler(this.apartamentoToolStripMenuItem_Click);
            // 
            // cuotaToolStripMenuItem
            // 
            this.cuotaToolStripMenuItem.Name = "cuotaToolStripMenuItem";
            this.cuotaToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.cuotaToolStripMenuItem.Text = "Cuotas";
            this.cuotaToolStripMenuItem.Click += new System.EventHandler(this.cuotaToolStripMenuItem_Click);
            // 
            // pagoToolStripMenuItem
            // 
            this.pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            this.pagoToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.pagoToolStripMenuItem.Text = "Pagos";
            this.pagoToolStripMenuItem.Click += new System.EventHandler(this.pagoToolStripMenuItem_Click);
            // 
            // servicioMantenimientoToolStripMenuItem
            // 
            this.servicioMantenimientoToolStripMenuItem.Name = "servicioMantenimientoToolStripMenuItem";
            this.servicioMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.servicioMantenimientoToolStripMenuItem.Text = "Servicios Mantenimiento";
            this.servicioMantenimientoToolStripMenuItem.Click += new System.EventHandler(this.servicioMantenimientoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AdministracionCondominio.Properties.Resources.Captura_de_pantalla_2025_07_22_164614;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 495);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Administracion de Resgristros de Condominios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem residenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicioMantenimientoToolStripMenuItem;
    }
}

