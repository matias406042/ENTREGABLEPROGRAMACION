using Prog_Entregable_1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prog_Entregable_1.Dominio;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prog_Entregable_1.Vistas
{
    public partial class FrmFactura : Form
    {

        ServiceFactura serviceFactura;
        ServiceFormaPago serviceFormaPago;
        ServiceArticulo serviceArticulo;
        Factura nueva;
        public FrmFactura()
        {
            InitializeComponent();
            
        }




        private void FrmFactura_Load(object sender, EventArgs e)
        {
            nueva = new Factura();
           
            txbFecha.Enabled = false;
            txbFecha.Text = (string)DateTime.Now.ToString("dd/MM/yyyy");
            CargarCbo(cboFormas);
            CargarCbo(cboArticulos);

        }

        private void CargarCbo(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (comboBox == cboFormas)
            {
                serviceFormaPago = new ServiceFormaPago();

                comboBox.DataSource = serviceFormaPago.listaFormasPago();
                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "Id";
            }

            if (comboBox == cboArticulos)
            {
                serviceArticulo = new ServiceArticulo();

                comboBox.DataSource = serviceArticulo.listaArticulos();
                comboBox.DisplayMember = "Nombre";
                comboBox.ValueMember = "Id";

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDetalle())
            {
                DetalleFactura d = new DetalleFactura();
                OtorgarValoresDetalle(d);
                nueva.AgregarDetalle(d);

                dgvDetalles.Rows.Add(d.Art.ID,
                                     d.Art.Nombre,
                                     d.Art.PrecioUnitario,
                                     txbCantidad.Text,
                                     "QUITAR");
                PrintTotal();

            }

        }

        public void PrintTotal()
        {
            txbTotal.Text = Convert.ToString(nueva.TotalDetalles());
        }



        public void OtorgarValoresDetalle(DetalleFactura d)
        {

            d.Art = (Articulo)cboArticulos.Items[cboArticulos.SelectedIndex];
            d.Cantidad = Convert.ToInt32(txbCantidad.Text);
           

        }
        public bool ValidarDetalle()
        {
            bool aux = true;
            if (string.IsNullOrEmpty(txbCantidad.Text) || int.TryParse(txbCantidad.Text, out _) == false)
            {
                string texto = "El Valor ingresado en 'CANTIDAD' es INCORRECTO";
                MessageBox.Show(texto, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboArticulos.SelectedIndex < 0)
            {
                string texto = "Seleccione ARTICULO";
                MessageBox.Show(texto, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboFormas.SelectedIndex < 0)
            {
                string texto = "Seleccione FORMA DE PAGO";
                MessageBox.Show(texto, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {

                if (fila.Cells["colArticulo"].Value.ToString().Equals(cboArticulos.Text))
                {
                    MessageBox.Show("El producto ya fue Agregado Anteriormente ..."
                                , "Control"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            

            return aux;

        }



        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                nueva.RemoverDetalle(e.RowIndex);
                dgvDetalles.Rows.RemoveAt(e.RowIndex);
                PrintTotal();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe Agregar al menos un ARTICULO ..."
                                   , "Control"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Exclamation);

            }
            else
            {
                serviceFactura = new ServiceFactura();
                nueva.Fecha = Convert.ToDateTime(txbFecha.Text);
                nueva.FormaP = (FormaPago)cboFormas.SelectedItem;
               
                if (serviceFactura.InsertarFactura(nueva)) 
                {
                    MessageBox.Show("Factura Guardada Exitosamente ..."
                                      , "Informacion"
                                      , MessageBoxButtons.OK
                                      , MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error..."
                                     , "Control"
                                     , MessageBoxButtons.OK
                                     , MessageBoxIcon.Exclamation);
                }
            }


        }
    }
}
