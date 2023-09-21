using Entregable_Facturacion.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entregable_Facturacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void nUEVAFACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFactura nueva = new FrmFactura();
            nueva.ShowDialog();
        }

        private void fACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteFacturas n = new FrmReporteFacturas();
            n.ShowDialog();
        }

        private void bORRARFACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteFacturas n = new FrmDeleteFacturas(); n.ShowDialog();
        }
    }
}
