namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class ReportViewerListadoClientes
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
            this.reportViewerListadoCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AltaClienteViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AltaClienteViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerListadoCliente
            // 
            this.reportViewerListadoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AltaClienteViewModelBindingSource;
            this.reportViewerListadoCliente.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerListadoCliente.LocalReport.ReportEmbeddedResource = "AdministracionAngela.ProyectoAngela.Formularios.ListadoClientes.rdlc";
            this.reportViewerListadoCliente.Location = new System.Drawing.Point(24, 23);
            this.reportViewerListadoCliente.Name = "reportViewerListadoCliente";
            this.reportViewerListadoCliente.Size = new System.Drawing.Size(396, 246);
            this.reportViewerListadoCliente.TabIndex = 0;
            // 
            // AltaClienteViewModelBindingSource
            // 
            this.AltaClienteViewModelBindingSource.DataSource = typeof(AdministracionAngela.Utils.Models.Cliente.AltaClienteViewModel);
            // 
            // ReportViewerListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 339);
            this.Controls.Add(this.reportViewerListadoCliente);
            this.Name = "ReportViewerListadoClientes";
            this.Text = "ReportViewerListadoClientes";
            this.Load += new System.EventHandler(this.ReportViewerListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AltaClienteViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerListadoCliente;
        private System.Windows.Forms.BindingSource AltaClienteViewModelBindingSource;
    }
}