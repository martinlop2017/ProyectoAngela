namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class TipoIVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoIVA));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.dataGridViewIVAs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIVAs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(12, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 6);
            this.panel2.TabIndex = 114;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SteelBlue;
            this.label15.Location = new System.Drawing.Point(12, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(310, 42);
            this.label15.TabIndex = 111;
            this.label15.Text = "Tipos Impuestos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 6);
            this.panel1.TabIndex = 110;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.BackgroundImage")));
            this.buttonAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonAceptar.FlatAppearance.BorderSize = 0;
            this.buttonAceptar.Location = new System.Drawing.Point(59, 443);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(208, 60);
            this.buttonAceptar.TabIndex = 112;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridViewIVAs
            // 
            this.dataGridViewIVAs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIVAs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewIVAs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewIVAs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIVAs.Location = new System.Drawing.Point(12, 108);
            this.dataGridViewIVAs.Name = "dataGridViewIVAs";
            this.dataGridViewIVAs.Size = new System.Drawing.Size(307, 291);
            this.dataGridViewIVAs.TabIndex = 115;
            this.dataGridViewIVAs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // TipoIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(332, 530);
            this.Controls.Add(this.dataGridViewIVAs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Name = "TipoIVA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoIVA";
            this.Load += new System.EventHandler(this.TipoIVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIVAs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewIVAs;
    }
}