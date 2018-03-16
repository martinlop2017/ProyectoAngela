namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class FormaPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPago));
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewFormasDePago = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormasDePago)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(80, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 42);
            this.label7.TabIndex = 31;
            this.label7.Text = "Forma de Pago";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridViewFormasDePago
            // 
            this.dataGridViewFormasDePago.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFormasDePago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFormasDePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormasDePago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFormasDePago.EnableHeadersVisualStyles = false;
            this.dataGridViewFormasDePago.Location = new System.Drawing.Point(38, 144);
            this.dataGridViewFormasDePago.Name = "dataGridViewFormasDePago";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFormasDePago.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFormasDePago.RowHeadersWidth = 20;
            this.dataGridViewFormasDePago.Size = new System.Drawing.Size(367, 345);
            this.dataGridViewFormasDePago.TabIndex = 32;
            this.dataGridViewFormasDePago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Concepto";
            this.Column1.HeaderText = "Forma Cobro";
            this.Column1.Name = "Column1";
            this.Column1.Width = 240;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Dias";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Dias";
            this.Column2.Name = "Column2";
            this.Column2.Width = 102;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.Location = new System.Drawing.Point(118, 535);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(208, 60);
            this.buttonGuardar.TabIndex = 33;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // FormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(447, 651);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridViewFormasDePago);
            this.Controls.Add(this.label7);
            this.MaximumSize = new System.Drawing.Size(463, 689);
            this.MinimumSize = new System.Drawing.Size(463, 689);
            this.Name = "FormaPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formas de Pago.";
            this.Load += new System.EventHandler(this.FormaPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormasDePago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewFormasDePago;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}