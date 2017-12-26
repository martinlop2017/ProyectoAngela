namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class Liquidaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liquidaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewLiquidaciones = new System.Windows.Forms.DataGridView();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBultos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioMedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiquidaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(34, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liquidacion de fecha.";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(204, 131);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(102, 24);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.Value = new System.DateTime(2017, 12, 19, 17, 25, 49, 0);
            // 
            // dataGridViewLiquidaciones
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLiquidaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLiquidaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnConcepto,
            this.ColumnBultos,
            this.ColumnKilos,
            this.ColumnPrecioMedio,
            this.ColumnTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLiquidaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLiquidaciones.Location = new System.Drawing.Point(39, 218);
            this.dataGridViewLiquidaciones.Name = "dataGridViewLiquidaciones";
            this.dataGridViewLiquidaciones.RowHeadersWidth = 20;
            this.dataGridViewLiquidaciones.Size = new System.Drawing.Size(907, 545);
            this.dataGridViewLiquidaciones.TabIndex = 5;
            this.dataGridViewLiquidaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEjecutar.BackgroundImage")));
            this.buttonEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEjecutar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonEjecutar.FlatAppearance.BorderSize = 0;
            this.buttonEjecutar.Location = new System.Drawing.Point(519, 121);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(169, 47);
            this.buttonEjecutar.TabIndex = 4;
            this.buttonEjecutar.UseVisualStyleBackColor = true;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonEjecutar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SteelBlue;
            this.label15.Location = new System.Drawing.Point(340, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(404, 42);
            this.label15.TabIndex = 101;
            this.label15.Text = "Gestión Liquidaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(314, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 102;
            this.label3.Text = "a fecha.";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(388, 131);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(102, 24);
            this.dateTimePickerEnd.TabIndex = 103;
            this.dateTimePickerEnd.Value = new System.DateTime(2017, 12, 19, 17, 25, 49, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(774, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 18);
            this.label6.TabIndex = 106;
            this.label6.Text = "TOTAL A LIQUIDAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(763, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 26);
            this.label8.TabIndex = 107;
            this.label8.Text = "9.999.9999,99 €";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Location = new System.Drawing.Point(238, 803);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(208, 60);
            this.button7.TabIndex = 108;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Location = new System.Drawing.Point(549, 803);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(208, 60);
            this.button8.TabIndex = 109;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.DataPropertyName = "CodigoArticulo";
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnConcepto
            // 
            this.ColumnConcepto.DataPropertyName = "Concepto";
            this.ColumnConcepto.HeaderText = "Concepto";
            this.ColumnConcepto.Name = "ColumnConcepto";
            this.ColumnConcepto.ReadOnly = true;
            // 
            // ColumnBultos
            // 
            this.ColumnBultos.DataPropertyName = "Bultos";
            this.ColumnBultos.HeaderText = "Bultos";
            this.ColumnBultos.Name = "ColumnBultos";
            this.ColumnBultos.ReadOnly = true;
            // 
            // ColumnKilos
            // 
            this.ColumnKilos.DataPropertyName = "Kilos";
            this.ColumnKilos.HeaderText = "Kilos";
            this.ColumnKilos.Name = "ColumnKilos";
            this.ColumnKilos.ReadOnly = true;
            // 
            // ColumnPrecioMedio
            // 
            this.ColumnPrecioMedio.DataPropertyName = "PrecioMedio";
            this.ColumnPrecioMedio.HeaderText = "PrecioMedio";
            this.ColumnPrecioMedio.Name = "ColumnPrecioMedio";
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.DataPropertyName = "Total";
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            // 
            // Liquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(991, 781);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridViewLiquidaciones);
            this.Controls.Add(this.buttonEjecutar);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label1);
            this.Name = "Liquidaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liquidaciones";
            this.Load += new System.EventHandler(this.Liquidaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiquidaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.DataGridView dataGridViewLiquidaciones;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBultos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioMedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
    }
}