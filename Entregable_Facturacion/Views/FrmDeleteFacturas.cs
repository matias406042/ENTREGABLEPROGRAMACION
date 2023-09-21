using Entregable_Facturacion.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entregable_Facturacion.Services;
namespace Entregable_Facturacion.Views
{
    public partial class FrmDeleteFacturas : Form
    {
        ServiceFactura serviceFactura;
        ServiceDetalleFactura serviceDetalle;
        Factura seleccionada;
        public FrmDeleteFacturas()
        {
            InitializeComponent();
            serviceFactura = new ServiceFactura();
            serviceDetalle = new ServiceDetalleFactura();
        }

        private void FrmDeleteFacturas_Load(object sender, EventArgs e)
        {
            CargarLstview();
        }

        private void CargarLstview()
        {
            lsvFacturas.View = View.Details;
            List<Factura> facturas = serviceFactura.ListaFacturas();
            int count = 0;
            lsvFacturas.Items.Clear();
            foreach (Factura f in facturas)
            {
                count++;
                ListViewItem i = new ListViewItem();
                i.SubItems[0].Text = f.NroFactura.ToString();
                i.SubItems.Add(f.Fecha.ToString());
                i.SubItems.Add(f.FormaP.Name);

                double total = 0;
                foreach (DetalleFactura d in f.DetFact)
                {
                    total += d.CalcularSubTotal();

                }
                i.SubItems.Add(total.ToString());
                i.SubItems.Add(count.ToString());


                lsvFacturas.Items.Add(i);





            }


        }

        private void lsvFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lsvFacturas.SelectedItems.Clear();

            if (lsvFacturas.SelectedIndices.Count > 0)
            {

                int i = Convert.ToInt32(lsvFacturas.SelectedItems[0].SubItems[0].Text);
                lblNroFactura.Text = "Factura Nro " + i;
               
                CargarDetalles(i);
            }
        }

        private void CargarDetalles(int i)
        {

            List<DetalleFactura> lista = serviceDetalle.ListaDetalleFactura(i);
            int contador = 0;
            foreach (DetalleFactura d in lista)
            {
                contador++;

                dgvDetalles.Rows.Add(contador.ToString(),
                                      d.Art.Nombre,
                                      d.Cantidad.ToString(),
                                      d.CalcularSubTotal()
                                       );

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAmpliar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lsvFacturas.SelectedIndices.Count > 0)
            {
                DialogResult r = MessageBox.Show("Seguro desea eliminar la factura" + lsvFacturas.SelectedItems[0].SubItems[0].Text, "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r.Equals(DialogResult.Yes))
                {
                    int i = Convert.ToInt32(lsvFacturas.SelectedItems[0].SubItems[0].Text);
                    serviceFactura.EliminarFactura(i);

                    MessageBox.Show("Factura ELIMINADA CON EXITO");
                    CargarLstview();
                    dgvDetalles.Rows.Clear();
                    

                }
            }
            else MessageBox.Show("Seleccionar Factura");
        }
    }
}
