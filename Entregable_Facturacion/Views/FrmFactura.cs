﻿using Entregable_Facturacion.Entitys;
using Entregable_Facturacion.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entregable_Facturacion.Views
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

            
            txbFecha.Text = (string)DateTime.Now.ToString("dd/MM/yyyy");
            CargarCbo(cboFormaPago);
            CargarCbo(cboArticulos);
        }



        private void CargarCbo(ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (comboBox == cboFormaPago)
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

        private void OtorgarValoresDetalle(DetalleFactura d)
        {
            d.Art = (Articulo)cboArticulos.Items[cboArticulos.SelectedIndex];
            d.Cantidad = Convert.ToInt32(txbCantidad.Text);
        }

        private bool ValidarDetalle()
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
            if (cboFormaPago.SelectedIndex < 0)
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

        public void PrintTotal()
            {
                txbTotal.Text = Convert.ToString(nueva.TotalDetalles());
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

        private void btnOk_Click(object sender, EventArgs e)
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
                nueva.FormaP = (FormaPago)cboFormaPago.SelectedItem;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }
}
