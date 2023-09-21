using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entregable_Facturacion.Reports;
namespace Entregable_Facturacion.Views
{
    public partial class FrmReporteFacturas : Form
    {
        public FrmReporteFacturas()
        {
            InitializeComponent();
        }

        private void FrmReporteFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSFacturas.SP_SELECT_FACTURAS' Puede moverla o quitarla según sea necesario.
            this.sP_SELECT_FACTURASTableAdapter.Fill(this.dSFacturas.SP_SELECT_FACTURAS);

            this.reportViewer1.RefreshReport();
       //     this.reportViewer2.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
