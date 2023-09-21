namespace Entregable_Facturacion.Views
{
    partial class FrmFactura
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
            this.txbFecha = new System.Windows.Forms.TextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cboArticulos = new System.Windows.Forms.ComboBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // txbFecha
            // 
            this.txbFecha.Enabled = false;
            this.txbFecha.Location = new System.Drawing.Point(145, 37);
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.Size = new System.Drawing.Size(100, 22);
            this.txbFecha.TabIndex = 0;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(420, 156);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(100, 22);
            this.txbCantidad.TabIndex = 1;
            // 
            // txbTotal
            // 
            this.txbTotal.Enabled = false;
            this.txbTotal.Location = new System.Drawing.Point(520, 390);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(100, 22);
            this.txbTotal.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Enabled = false;
            this.lblFecha.Location = new System.Drawing.Point(84, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "FECHA:";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(454, 46);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(96, 16);
            this.lblFormaPago.TabIndex = 4;
            this.lblFormaPago.Text = "FORMA PAGO";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(327, 157);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(76, 16);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "CANTIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOTAL";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colArticulo,
            this.colPrecio,
            this.colCantidad,
            this.colAccion});
            this.dgvDetalles.Location = new System.Drawing.Point(25, 202);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(554, 150);
            this.dgvDetalles.TabIndex = 7;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 125;
            // 
            // colArticulo
            // 
            this.colArticulo.HeaderText = "ARTICULOS";
            this.colArticulo.MinimumWidth = 6;
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.ReadOnly = true;
            this.colArticulo.Width = 125;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "PRECIOS";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 125;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "CANTIDAD";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 125;
            // 
            // colAccion
            // 
            this.colAccion.HeaderText = "ACCION";
            this.colAccion.MinimumWidth = 6;
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAccion.Width = 125;
            // 
            // cboArticulos
            // 
            this.cboArticulos.FormattingEnabled = true;
            this.cboArticulos.Location = new System.Drawing.Point(25, 154);
            this.cboArticulos.Name = "cboArticulos";
            this.cboArticulos.Size = new System.Drawing.Size(279, 24);
            this.cboArticulos.TabIndex = 8;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(133, 120);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(83, 16);
            this.lblArticulo.TabIndex = 9;
            this.lblArticulo.Text = "ARTICULOS";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(556, 43);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(121, 24);
            this.cboFormaPago.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(539, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 30);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(136, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 36);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(25, 382);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 37);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "GRABAR";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboFormaPago);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.cboArticulos);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.txbFecha);
            this.Name = "FrmFactura";
            this.Text = "FrmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbFecha;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.ComboBox cboArticulos;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn colAccion;
    }
}