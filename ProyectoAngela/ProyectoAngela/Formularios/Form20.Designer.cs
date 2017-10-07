namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class Form20
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
            this.LineaFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetnUEVO = new AdministracionAngela.ProyectoAngela.Formularios.DataSetnUEVO();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LineaFacturaTableAdapter = new AdministracionAngela.ProyectoAngela.Formularios.DataSetnUEVOTableAdapters.LineaFacturaTableAdapter();
            this.ImpresionFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LineaFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetnUEVO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImpresionFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LineaFacturaBindingSource
            // 
            this.LineaFacturaBindingSource.DataMember = "LineaFactura";
            this.LineaFacturaBindingSource.DataSource = this.DataSetnUEVO;
            // 
            // DataSetnUEVO
            // 
            this.DataSetnUEVO.DataSetName = "DataSetnUEVO";
            this.DataSetnUEVO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetImpresion";
            reportDataSource1.Value = this.ImpresionFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AdministracionAngela.ProyectoAngela.Formularios.ReportTestEntity.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(726, 339);
            this.reportViewer1.TabIndex = 0;
            // 
            // LineaFacturaTableAdapter
            // 
            this.LineaFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // ImpresionFacturaBindingSource
            // 
            this.ImpresionFacturaBindingSource.DataSource = typeof(AdministracionAngela.Utils.Models.Factura.ImpresionFactura);
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 339);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form20";
            this.Text = "Form20";
            this.Load += new System.EventHandler(this.Form20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LineaFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetnUEVO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImpresionFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LineaFacturaBindingSource;
        private DataSetnUEVO DataSetnUEVO;
        private DataSetnUEVOTableAdapters.LineaFacturaTableAdapter LineaFacturaTableAdapter;
        private System.Windows.Forms.BindingSource ImpresionFacturaBindingSource;
    }
}