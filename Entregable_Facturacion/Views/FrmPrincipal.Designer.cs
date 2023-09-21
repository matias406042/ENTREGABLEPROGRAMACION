namespace Entregable_Facturacion
{
    partial class FrmPrincipal
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
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVAFACTURAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bORRARFACTURAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACTURASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteToolStripMenuItem,
            this.archivosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVAFACTURAToolStripMenuItem,
            this.bORRARFACTURAToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // nUEVAFACTURAToolStripMenuItem
            // 
            this.nUEVAFACTURAToolStripMenuItem.Name = "nUEVAFACTURAToolStripMenuItem";
            this.nUEVAFACTURAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nUEVAFACTURAToolStripMenuItem.Text = "NUEVA FACTURA";
            this.nUEVAFACTURAToolStripMenuItem.Click += new System.EventHandler(this.nUEVAFACTURAToolStripMenuItem_Click);
            // 
            // bORRARFACTURAToolStripMenuItem
            // 
            this.bORRARFACTURAToolStripMenuItem.Name = "bORRARFACTURAToolStripMenuItem";
            this.bORRARFACTURAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bORRARFACTURAToolStripMenuItem.Text = "BORRAR FACTURA";
            this.bORRARFACTURAToolStripMenuItem.Click += new System.EventHandler(this.bORRARFACTURAToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fACTURASToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // fACTURASToolStripMenuItem
            // 
            this.fACTURASToolStripMenuItem.Name = "fACTURASToolStripMenuItem";
            this.fACTURASToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.fACTURASToolStripMenuItem.Text = "FACTURAS";
            this.fACTURASToolStripMenuItem.Click += new System.EventHandler(this.fACTURASToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVAFACTURAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bORRARFACTURAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACTURASToolStripMenuItem;
    }
}

