namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class ReportViewerListadoArticulos
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
            this.ReportViewerListadoAlbaranes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AltaArticuloViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AltaArticuloViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewerListadoAlbaranes
            // 
            this.ReportViewerListadoAlbaranes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AltaArticuloViewModelBindingSource;
            this.ReportViewerListadoAlbaranes.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerListadoAlbaranes.LocalReport.ReportEmbeddedResource = "AdministracionAngela.ProyectoAngela.Formularios.ListadoArticulos.rdlc";
            this.ReportViewerListadoAlbaranes.Location = new System.Drawing.Point(45, 12);
            this.ReportViewerListadoAlbaranes.Name = "ReportViewerListadoAlbaranes";
            this.ReportViewerListadoAlbaranes.Size = new System.Drawing.Size(545, 381);
            this.ReportViewerListadoAlbaranes.TabIndex = 0;
            // 
            // AltaArticuloViewModelBindingSource
            // 
            this.AltaArticuloViewModelBindingSource.DataSource = typeof(AdministracionAngela.Utils.Models.Articulo.AltaArticuloViewModel);
            // 
            // ReportViewerListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 396);
            this.Controls.Add(this.ReportViewerListadoAlbaranes);
            this.Name = "ReportViewerListadoArticulos";
            this.Text = "ReportViewerListadoArticulos";
            this.Load += new System.EventHandler(this.ReportViewerListadoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AltaArticuloViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerListadoAlbaranes;
        private System.Windows.Forms.BindingSource AltaArticuloViewModelBindingSource;
    }
}