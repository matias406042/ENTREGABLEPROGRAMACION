namespace Entregable_Facturacion.Views
{
    partial class FrmDeleteFacturas
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
            this.lsvFacturas = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFormaPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticullo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvFacturas
            // 
            this.lsvFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.colFecha,
            this.colFormaPago,
            this.colTotal,
            this.columnHeader1});
            this.lsvFacturas.FullRowSelect = true;
            this.lsvFacturas.HideSelection = false;
            this.lsvFacturas.Location = new System.Drawing.Point(12, 97);
            this.lsvFacturas.MultiSelect = false;
            this.lsvFacturas.Name = "lsvFacturas";
            this.lsvFacturas.Size = new System.Drawing.Size(304, 263);
            this.lsvFacturas.TabIndex = 0;
            this.lsvFacturas.UseCompatibleStateImageBehavior = false;
            this.lsvFacturas.View = System.Windows.Forms.View.Details;
            this.lsvFacturas.SelectedIndexChanged += new System.EventHandler(this.lsvFacturas_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // colFecha
            // 
            this.colFecha.Text = "FECHA ";
            // 
            // colFormaPago
            // 
            this.colFormaPago.Text = "Forma de Pago";
            // 
            // colTotal
            // 
            this.colTotal.Text = "TOTAL";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "item";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.Location = new System.Drawing.Point(7, 26);
            this.lblNroFactura.MaximumSize = new System.Drawing.Size(200, 200);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(114, 25);
            this.lblNroFactura.TabIndex = 1;
            this.lblNroFactura.Text = "Factura Nro";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 366);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 35);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.MaximumSize = new System.Drawing.Size(200, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "-Seleccione factura";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(456, 74);
            this.lblDetalles.MaximumSize = new System.Drawing.Size(200, 200);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(174, 20);
            this.lblDetalles.TabIndex = 5;
            this.lblDetalles.Text = "Detalles de la Factura";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colArticullo,
            this.colCantidad,
            this.ColSubTotal});
            this.dgvDetalles.Location = new System.Drawing.Point(353, 97);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(417, 263);
            this.dgvDetalles.TabIndex = 6;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 35;
            // 
            // colArticullo
            // 
            this.colArticullo.HeaderText = "Articulo";
            this.colArticullo.MinimumWidth = 6;
            this.colArticullo.Name = "colArticullo";
            this.colArticullo.ReadOnly = true;
            this.colArticullo.Width = 88;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 60;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.HeaderText = "SUB-TOTAL";
            this.ColSubTotal.MinimumWidth = 6;
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            this.ColSubTotal.Width = 78;
            // 
            // FrmDeleteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblNroFactura);
            this.Controls.Add(this.lsvFacturas);
            this.Name = "FrmDeleteFacturas";
            this.Text = "Eliminar Factura";
            this.Load += new System.EventHandler(this.FrmDeleteFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvFacturas;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.ColumnHeader colFormaPago;
        private System.Windows.Forms.ColumnHeader colTotal;
        public System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.Button btnBorrar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticullo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
    }
}