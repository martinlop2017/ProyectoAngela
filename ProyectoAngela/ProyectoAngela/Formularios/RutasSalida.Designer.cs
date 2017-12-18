namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class RutasSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RutasSalida));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonFacturas = new System.Windows.Forms.Button();
            this.buttonListados = new System.Windows.Forms.Button();
            this.buttonAlbaranes = new System.Windows.Forms.Button();
            this.textBoxFacturas = new System.Windows.Forms.TextBox();
            this.textBoxListados = new System.Windows.Forms.TextBox();
            this.textBoxAlbaranes = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogFacturas = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogAlbaranes = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogListados = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Albaranes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Listados:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.Location = new System.Drawing.Point(93, 214);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(179, 51);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonFacturas
            // 
            this.buttonFacturas.Location = new System.Drawing.Point(216, 64);
            this.buttonFacturas.Name = "buttonFacturas";
            this.buttonFacturas.Size = new System.Drawing.Size(29, 23);
            this.buttonFacturas.TabIndex = 35;
            this.buttonFacturas.Text = "...";
            this.buttonFacturas.UseVisualStyleBackColor = true;
            this.buttonFacturas.Click += new System.EventHandler(this.buttonFacturas_Click);
            // 
            // buttonListados
            // 
            this.buttonListados.Location = new System.Drawing.Point(216, 144);
            this.buttonListados.Name = "buttonListados";
            this.buttonListados.Size = new System.Drawing.Size(29, 23);
            this.buttonListados.TabIndex = 36;
            this.buttonListados.Text = "...";
            this.buttonListados.UseVisualStyleBackColor = true;
            this.buttonListados.Click += new System.EventHandler(this.buttonListados_Click);
            // 
            // buttonAlbaranes
            // 
            this.buttonAlbaranes.Location = new System.Drawing.Point(216, 102);
            this.buttonAlbaranes.Name = "buttonAlbaranes";
            this.buttonAlbaranes.Size = new System.Drawing.Size(29, 23);
            this.buttonAlbaranes.TabIndex = 37;
            this.buttonAlbaranes.Text = "...";
            this.buttonAlbaranes.UseVisualStyleBackColor = true;
            this.buttonAlbaranes.Click += new System.EventHandler(this.buttonAlbaranes_Click);
            // 
            // textBoxFacturas
            // 
            this.textBoxFacturas.Location = new System.Drawing.Point(109, 66);
            this.textBoxFacturas.Name = "textBoxFacturas";
            this.textBoxFacturas.Size = new System.Drawing.Size(100, 20);
            this.textBoxFacturas.TabIndex = 38;
            // 
            // textBoxListados
            // 
            this.textBoxListados.Location = new System.Drawing.Point(109, 147);
            this.textBoxListados.Name = "textBoxListados";
            this.textBoxListados.Size = new System.Drawing.Size(100, 20);
            this.textBoxListados.TabIndex = 39;
            // 
            // textBoxAlbaranes
            // 
            this.textBoxAlbaranes.Location = new System.Drawing.Point(110, 104);
            this.textBoxAlbaranes.Name = "textBoxAlbaranes";
            this.textBoxAlbaranes.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlbaranes.TabIndex = 40;
            // 
            // RutasSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 303);
            this.Controls.Add(this.textBoxAlbaranes);
            this.Controls.Add(this.textBoxListados);
            this.Controls.Add(this.textBoxFacturas);
            this.Controls.Add(this.buttonAlbaranes);
            this.Controls.Add(this.buttonListados);
            this.Controls.Add(this.buttonFacturas);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RutasSalida";
            this.Text = "RutasSalida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonFacturas;
        private System.Windows.Forms.Button buttonListados;
        private System.Windows.Forms.Button buttonAlbaranes;
        private System.Windows.Forms.TextBox textBoxFacturas;
        private System.Windows.Forms.TextBox textBoxListados;
        private System.Windows.Forms.TextBox textBoxAlbaranes;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogFacturas;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogAlbaranes;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogListados;
    }
}