namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class ReportViewerListadoFactura
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
            this.reportViewerListadoFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ImpresionFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImpresionFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerListadoFacturas
            // 
            this.reportViewerListadoFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ImpresionFacturaBindingSource;
            this.reportViewerListadoFacturas.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerListadoFacturas.LocalReport.ReportEmbeddedResource = "AdministracionAngela.ProyectoAngela.Formularios.ListadoFacturas.rdlc";
            this.reportViewerListadoFacturas.Location = new System.Drawing.Point(74, 50);
            this.reportViewerListadoFacturas.Name = "reportViewerListadoFacturas";
            this.reportViewerListadoFacturas.Size = new System.Drawing.Size(396, 246);
            this.reportViewerListadoFacturas.TabIndex = 0;
            // 
            // ImpresionFacturaBindingSource
            // 
            this.ImpresionFacturaBindingSource.DataSource = typeof(AdministracionAngela.Utils.Models.Factura.ImpresionFactura);
            // 
            // ReportViewerListadoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 313);
            this.Controls.Add(this.reportViewerListadoFacturas);
            this.Name = "ReportViewerListadoFactura";
            this.Text = "ReportViewerListadoFactura";
            this.Load += new System.EventHandler(this.ReportViewerListadoFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImpresionFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerListadoFacturas;
        private System.Windows.Forms.BindingSource ImpresionFacturaBindingSource;
    }
}