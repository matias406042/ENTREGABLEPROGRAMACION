namespace Prog_Entregable_1.Vistas
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
            lblFECHA = new Label();
            btnOK = new Button();
            btnAgregar = new Button();
            btnCancel = new Button();
            dgvDetalles = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colArticulo = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colAccion = new DataGridViewButtonColumn();
            cboArticulos = new ComboBox();
            txbFecha = new TextBox();
            lblFormaPago = new Label();
            cboFormas = new ComboBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lblAticulo = new Label();
            lblCantidad = new Label();
            txbCantidad = new TextBox();
            txbTotal = new TextBox();
            lblTOTAL = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // lblFECHA
            // 
            lblFECHA.AutoSize = true;
            lblFECHA.Location = new Point(50, 47);
            lblFECHA.Name = "lblFECHA";
            lblFECHA.Size = new Size(61, 20);
            lblFECHA.TabIndex = 0;
            lblFECHA.Text = "FECHA :";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(50, 370);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(608, 149);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(177, 370);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { colID, colArticulo, colPrecio, colCantidad, colAccion });
            dgvDetalles.Location = new Point(53, 185);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.RowTemplate.Height = 29;
            dgvDetalles.Size = new Size(680, 153);
            dgvDetalles.TabIndex = 4;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            colID.Width = 125;
            // 
            // colArticulo
            // 
            colArticulo.HeaderText = "ARTICULOS";
            colArticulo.MinimumWidth = 6;
            colArticulo.Name = "colArticulo";
            colArticulo.ReadOnly = true;
            colArticulo.Width = 250;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "PRECIO";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 125;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "CANTIDAD";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 125;
            // 
            // colAccion
            // 
            colAccion.HeaderText = "ACCION";
            colAccion.MinimumWidth = 6;
            colAccion.Name = "colAccion";
            colAccion.ReadOnly = true;
            colAccion.Resizable = DataGridViewTriState.True;
            colAccion.SortMode = DataGridViewColumnSortMode.Automatic;
            colAccion.Width = 125;
            // 
            // cboArticulos
            // 
            cboArticulos.FormattingEnabled = true;
            cboArticulos.Location = new Point(53, 150);
            cboArticulos.Name = "cboArticulos";
            cboArticulos.Size = new Size(303, 28);
            cboArticulos.TabIndex = 5;
            // 
            // txbFecha
            // 
            txbFecha.Location = new Point(127, 44);
            txbFecha.Name = "txbFecha";
            txbFecha.Size = new Size(125, 27);
            txbFecha.TabIndex = 6;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(349, 44);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(124, 20);
            lblFormaPago.TabIndex = 7;
            lblFormaPago.Text = "FORMA DE PAGO";
            // 
            // cboFormas
            // 
            cboFormas.FormattingEnabled = true;
            cboFormas.Location = new Point(507, 41);
            cboFormas.Name = "cboFormas";
            cboFormas.Size = new Size(151, 28);
            cboFormas.TabIndex = 8;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // lblAticulo
            // 
            lblAticulo.AutoSize = true;
            lblAticulo.Location = new Point(136, 118);
            lblAticulo.Name = "lblAticulo";
            lblAticulo.Size = new Size(83, 20);
            lblAticulo.TabIndex = 9;
            lblAticulo.Text = "ARTICULOS";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(390, 154);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 20);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "CANTIDAD";
            // 
            // txbCantidad
            // 
            txbCantidad.Location = new Point(479, 151);
            txbCantidad.Name = "txbCantidad";
            txbCantidad.Size = new Size(112, 27);
            txbCantidad.TabIndex = 11;
            // 
            // txbTotal
            // 
            txbTotal.BackColor = Color.Silver;
            txbTotal.Location = new Point(621, 370);
            txbTotal.Name = "txbTotal";
            txbTotal.Size = new Size(112, 27);
            txbTotal.TabIndex = 13;
            // 
            // lblTOTAL
            // 
            lblTOTAL.AutoSize = true;
            lblTOTAL.Location = new Point(549, 373);
            lblTOTAL.Name = "lblTOTAL";
            lblTOTAL.Size = new Size(57, 20);
            lblTOTAL.TabIndex = 14;
            lblTOTAL.Text = "TOTAL :";
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTOTAL);
            Controls.Add(txbTotal);
            Controls.Add(txbCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(lblAticulo);
            Controls.Add(cboFormas);
            Controls.Add(lblFormaPago);
            Controls.Add(txbFecha);
            Controls.Add(cboArticulos);
            Controls.Add(dgvDetalles);
            Controls.Add(btnCancel);
            Controls.Add(btnAgregar);
            Controls.Add(btnOK);
            Controls.Add(lblFECHA);
            Name = "FrmFactura";
            Text = "FACTURA";
            Load += FrmFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFECHA;
        private Button btnOK;
        private Button btnAgregar;
        private Button btnCancel;
        private DataGridView dgvDetalles;
        private ComboBox cboArticulos;
        private TextBox txbFecha;
        private Label lblFormaPago;
        private ComboBox cboFormas;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblAticulo;
        private Label lblCantidad;
        private TextBox txbCantidad;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colArticulo;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewButtonColumn colAccion;
        private TextBox txbTotal;
        private Label lblTOTAL;
    }
}