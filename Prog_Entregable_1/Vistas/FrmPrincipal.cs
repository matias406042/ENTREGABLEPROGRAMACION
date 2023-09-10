using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Entregable_1.Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cREARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFactura nueva = new FrmFactura();
            nueva.ShowDialog();
            
        }

    }
}
