namespace Entregable_Facturacion.Views
{
    partial class FrmReporteFacturas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSFacturas = new Entregable_Facturacion.Reports.DSFacturas();
            this.dSFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPSELECTFACTURASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_SELECT_FACTURASTableAdapter = new Entregable_Facturacion.Reports.DSFacturasTableAdapters.SP_SELECT_FACTURASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSELECTFACTURASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPSELECTFACTURASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Entregable_Facturacion.Reports.ReporteFacturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSFacturas
            // 
            this.dSFacturas.DataSetName = "DSFacturas";
            this.dSFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSFacturasBindingSource
            // 
            this.dSFacturasBindingSource.DataSource = this.dSFacturas;
            this.dSFacturasBindingSource.Position = 0;
            // 
            // sPSELECTFACTURASBindingSource
            // 
            this.sPSELECTFACTURASBindingSource.DataMember = "SP_SELECT_FACTURAS";
            this.sPSELECTFACTURASBindingSource.DataSource = this.dSFacturas;
            // 
            // sP_SELECT_FACTURASTableAdapter
            // 
            this.sP_SELECT_FACTURASTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteFacturas";
            this.Text = "FrmReporteFacturas";
            this.Load += new System.EventHandler(this.FrmReporteFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSELECTFACTURASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSFacturasBindingSource;
        private Reports.DSFacturas dSFacturas;
        private System.Windows.Forms.BindingSource sPSELECTFACTURASBindingSource;
        private Reports.DSFacturasTableAdapters.SP_SELECT_FACTURASTableAdapter sP_SELECT_FACTURASTableAdapter;
    }
}