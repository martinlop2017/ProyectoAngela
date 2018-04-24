namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class ReportViewerListadoAlbaran
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
            this.reportViewerListadoAlbaranes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ListadoAlbaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoAlbaranBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerListadoAlbaranes
            // 
            this.reportViewerListadoAlbaranes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ListadoAlbaranBindingSource;
            this.reportViewerListadoAlbaranes.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerListadoAlbaranes.LocalReport.ReportEmbeddedResource = "AdministracionAngela.ProyectoAngela.Formularios.ListadoAlbaranes.rdlc";
            this.reportViewerListadoAlbaranes.Location = new System.Drawing.Point(32, 56);
            this.reportViewerListadoAlbaranes.Name = "reportViewerListadoAlbaranes";
            this.reportViewerListadoAlbaranes.Size = new System.Drawing.Size(396, 246);
            this.reportViewerListadoAlbaranes.TabIndex = 0;
            // 
            // ListadoAlbaranBindingSource
            // 
            this.ListadoAlbaranBindingSource.DataSource = typeof(AdministracionAngela.Utils.Models.Impresion.ListadoAlbaran);
            // 
            // ReportViewerListadoAlbaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 347);
            this.Controls.Add(this.reportViewerListadoAlbaranes);
            this.Name = "ReportViewerListadoAlbaran";
            this.Text = "ReportViewerListadoAlbaran";
            this.Load += new System.EventHandler(this.ReportViewerListadoAlbaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoAlbaranBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerListadoAlbaranes;
        private System.Windows.Forms.BindingSource ListadoAlbaranBindingSource;
    }
}