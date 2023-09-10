namespace Prog_Entregable_1.Vistas
{
    partial class FrmPrincipal
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sOPORTEToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            sOPORTEToolStripMenuItem1 = new ToolStripMenuItem();
            aRCHIVOSToolStripMenuItem = new ToolStripMenuItem();
            fACTURASToolStripMenuItem = new ToolStripMenuItem();
            cREARToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { sOPORTEToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(141, 28);
            // 
            // sOPORTEToolStripMenuItem
            // 
            sOPORTEToolStripMenuItem.Name = "sOPORTEToolStripMenuItem";
            sOPORTEToolStripMenuItem.Size = new Size(140, 24);
            sOPORTEToolStripMenuItem.Text = "SOPORTE";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sOPORTEToolStripMenuItem1, aRCHIVOSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // sOPORTEToolStripMenuItem1
            // 
            sOPORTEToolStripMenuItem1.Name = "sOPORTEToolStripMenuItem1";
            sOPORTEToolStripMenuItem1.Size = new Size(85, 24);
            sOPORTEToolStripMenuItem1.Text = "SOPORTE";
            // 
            // aRCHIVOSToolStripMenuItem
            // 
            aRCHIVOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fACTURASToolStripMenuItem });
            aRCHIVOSToolStripMenuItem.Name = "aRCHIVOSToolStripMenuItem";
            aRCHIVOSToolStripMenuItem.Size = new Size(94, 24);
            aRCHIVOSToolStripMenuItem.Text = "ARCHIVOS";
            // 
            // fACTURASToolStripMenuItem
            // 
            fACTURASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cREARToolStripMenuItem });
            fACTURASToolStripMenuItem.Name = "fACTURASToolStripMenuItem";
            fACTURASToolStripMenuItem.Size = new Size(224, 26);
            fACTURASToolStripMenuItem.Text = "FACTURAS";
            // 
            // cREARToolStripMenuItem
            // 
            cREARToolStripMenuItem.Name = "cREARToolStripMenuItem";
            cREARToolStripMenuItem.Size = new Size(224, 26);
            cREARToolStripMenuItem.Text = "CREAR";
            cREARToolStripMenuItem.Click += cREARToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sOPORTEToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sOPORTEToolStripMenuItem1;
        private ToolStripMenuItem aRCHIVOSToolStripMenuItem;
        private ToolStripMenuItem fACTURASToolStripMenuItem;
        private ToolStripMenuItem cREARToolStripMenuItem;
    }
}