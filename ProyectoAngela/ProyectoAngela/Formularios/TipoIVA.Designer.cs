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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoIVA));
            this.label15 = new System.Windows.Forms.Label();
            this.customGroupBox7 = new AdministracionAngela.CustomControls.CustomGroupBox();
            this.dataGridViewIVAs = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customGroupBox1 = new AdministracionAngela.CustomControls.CustomGroupBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.customGroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIVAs)).BeginInit();
            this.customGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SteelBlue;
            this.label15.Location = new System.Drawing.Point(46, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(310, 42);
            this.label15.TabIndex = 111;
            this.label15.Text = "Tipos Impuestos";
            // 
            // customGroupBox7
            // 
            this.customGroupBox7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.customGroupBox7.BackgroundGradientColor = System.Drawing.Color.White;
            this.customGroupBox7.BackgroundGradientMode = AdministracionAngela.CustomControls.CustomGroupBox.GroupBoxGradientMode.None;
            this.customGroupBox7.BorderColor = System.Drawing.Color.SteelBlue;
            this.customGroupBox7.BorderThickness = 3F;
            this.customGroupBox7.Controls.Add(this.dataGridViewIVAs);
            this.customGroupBox7.CustomGroupBoxColor = System.Drawing.Color.White;
            this.customGroupBox7.GroupImage = null;
            this.customGroupBox7.GroupTitle = "";
            this.customGroupBox7.Location = new System.Drawing.Point(12, 78);
            this.customGroupBox7.Name = "customGroupBox7";
            this.customGroupBox7.PaintGroupBox = false;
            this.customGroupBox7.RoundCorners = 10;
            this.customGroupBox7.ShadowColor = System.Drawing.Color.DarkGray;
            this.customGroupBox7.ShadowControl = false;
            this.customGroupBox7.ShadowThickness = 3;
            this.customGroupBox7.Size = new System.Drawing.Size(388, 325);
            this.customGroupBox7.TabIndex = 116;
            this.customGroupBox7.TabStop = false;
            this.customGroupBox7.Text = "customGroupBox7";
            // 
            // dataGridViewIVAs
            // 
            this.dataGridViewIVAs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewIVAs.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIVAs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIVAs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewIVAs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewIVAs.EnableHeadersVisualStyles = false;
            this.dataGridViewIVAs.Location = new System.Drawing.Point(16, 31);
            this.dataGridViewIVAs.Name = "dataGridViewIVAs";
            this.dataGridViewIVAs.RowHeadersWidth = 15;
            this.dataGridViewIVAs.Size = new System.Drawing.Size(354, 279);
            this.dataGridViewIVAs.TabIndex = 116;
            this.dataGridViewIVAs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIVAs_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Descripcion";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 83.33085F;
            this.Column1.HeaderText = "Descripcion";
            this.Column1.Name = "Column1";
            this.Column1.Width = 185;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Porcentaje";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 114.2132F;
            this.Column2.HeaderText = "Tipo";
            this.Column2.Name = "Column2";
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "RecargoEquivalencia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.FillWeight = 102.456F;
            this.Column3.HeaderText = "R.E.";
            this.Column3.Name = "Column3";
            this.Column3.Width = 75;
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.customGroupBox1.BackgroundGradientColor = System.Drawing.Color.White;
            this.customGroupBox1.BackgroundGradientMode = AdministracionAngela.CustomControls.CustomGroupBox.GroupBoxGradientMode.None;
            this.customGroupBox1.BorderColor = System.Drawing.Color.SteelBlue;
            this.customGroupBox1.BorderThickness = 3F;
            this.customGroupBox1.Controls.Add(this.buttonAceptar);
            this.customGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.customGroupBox1.GroupImage = null;
            this.customGroupBox1.GroupTitle = "";
            this.customGroupBox1.Location = new System.Drawing.Point(12, 409);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.PaintGroupBox = false;
            this.customGroupBox1.RoundCorners = 10;
            this.customGroupBox1.ShadowColor = System.Drawing.Color.DarkGray;
            this.customGroupBox1.ShadowControl = false;
            this.customGroupBox1.ShadowThickness = 3;
            this.customGroupBox1.Size = new System.Drawing.Size(388, 108);
            this.customGroupBox1.TabIndex = 117;
            this.customGroupBox1.TabStop = false;
            this.customGroupBox1.Text = "customGroupBox1";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.BackgroundImage")));
            this.buttonAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonAceptar.FlatAppearance.BorderSize = 0;
            this.buttonAceptar.Location = new System.Drawing.Point(91, 28);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(208, 60);
            this.buttonAceptar.TabIndex = 113;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // TipoIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(413, 539);
            this.ControlBox = false;
            this.Controls.Add(this.customGroupBox1);
            this.Controls.Add(this.customGroupBox7);
            this.Controls.Add(this.label15);
            this.MaximumSize = new System.Drawing.Size(429, 577);
            this.MinimumSize = new System.Drawing.Size(429, 577);
            this.Name = "TipoIVA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoIVA";
            this.Load += new System.EventHandler(this.TipoIVA_Load);
            this.customGroupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIVAs)).EndInit();
            this.customGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private CustomControls.CustomGroupBox customGroupBox7;
        private System.Windows.Forms.DataGridView dataGridViewIVAs;
        private CustomControls.CustomGroupBox customGroupBox1;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}