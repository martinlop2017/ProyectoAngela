﻿namespace AdministracionAngela.ProyectoAngela.Formularios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liquidaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewLiquidaciones = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBultos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioMedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalLiquidaciones = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
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
            this.dataGridViewLiquidaciones.AllowUserToAddRows = false;
            this.dataGridViewLiquidaciones.AllowUserToDeleteRows = false;
            this.dataGridViewLiquidaciones.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLiquidaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewLiquidaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLiquidaciones.ColumnHeadersHeight = 26;
            this.dataGridViewLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLiquidaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnConcepto,
            this.ColumnBultos,
            this.ColumnKilos,
            this.ColumnPrecioMedio,
            this.ColumnTotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLiquidaciones.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewLiquidaciones.EnableHeadersVisualStyles = false;
            this.dataGridViewLiquidaciones.GridColor = System.Drawing.Color.Black;
            this.dataGridViewLiquidaciones.Location = new System.Drawing.Point(37, 202);
            this.dataGridViewLiquidaciones.Name = "dataGridViewLiquidaciones";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLiquidaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewLiquidaciones.RowHeadersWidth = 20;
            this.dataGridViewLiquidaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewLiquidaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLiquidaciones.Size = new System.Drawing.Size(918, 398);
            this.dataGridViewLiquidaciones.TabIndex = 5;
            this.dataGridViewLiquidaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewLiquidaciones.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLiquidaciones_CellValueChanged);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.DataPropertyName = "CodigoArticulo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.ColumnCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 70;
            // 
            // ColumnConcepto
            // 
            this.ColumnConcepto.DataPropertyName = "Concepto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColumnConcepto.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnConcepto.HeaderText = "Concepto";
            this.ColumnConcepto.Name = "ColumnConcepto";
            this.ColumnConcepto.ReadOnly = true;
            this.ColumnConcepto.Width = 405;
            // 
            // ColumnBultos
            // 
            this.ColumnBultos.DataPropertyName = "Bultos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.ColumnBultos.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnBultos.HeaderText = "  Bultos";
            this.ColumnBultos.Name = "ColumnBultos";
            this.ColumnBultos.Width = 75;
            // 
            // ColumnKilos
            // 
            this.ColumnKilos.DataPropertyName = "Kilos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.ColumnKilos.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnKilos.HeaderText = " Kilos";
            this.ColumnKilos.Name = "ColumnKilos";
            this.ColumnKilos.Width = 125;
            // 
            // ColumnPrecioMedio
            // 
            this.ColumnPrecioMedio.DataPropertyName = "PrecioMedio";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "0";
            this.ColumnPrecioMedio.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnPrecioMedio.HeaderText = " P.Medio";
            this.ColumnPrecioMedio.Name = "ColumnPrecioMedio";
            this.ColumnPrecioMedio.Width = 75;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.DataPropertyName = "Total";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = "0";
            this.ColumnTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnTotal.HeaderText = "  Total";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            this.ColumnTotal.Width = 125;
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEjecutar.BackgroundImage")));
            this.buttonEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEjecutar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonEjecutar.FlatAppearance.BorderSize = 0;
            this.buttonEjecutar.Location = new System.Drawing.Point(519, 121);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(124, 47);
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
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(774, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 18);
            this.label6.TabIndex = 106;
            this.label6.Text = "TOTAL A LIQUIDAR";
            // 
            // labelTotalLiquidaciones
            // 
            this.labelTotalLiquidaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalLiquidaciones.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalLiquidaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLiquidaciones.Location = new System.Drawing.Point(777, 142);
            this.labelTotalLiquidaciones.Name = "labelTotalLiquidaciones";
            this.labelTotalLiquidaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalLiquidaciones.Size = new System.Drawing.Size(153, 0);
            this.labelTotalLiquidaciones.TabIndex = 107;
            this.labelTotalLiquidaciones.Text = "0,00 €";
            this.labelTotalLiquidaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Location = new System.Drawing.Point(255, 634);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(208, 60);
            this.button7.TabIndex = 108;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Location = new System.Drawing.Point(570, 634);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(208, 60);
            this.button8.TabIndex = 109;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
            this.buttonDelete.Location = new System.Drawing.Point(662, 118);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(49, 56);
            this.buttonDelete.TabIndex = 110;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Liquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(988, 737);
            this.ControlBox = false;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.labelTotalLiquidaciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridViewLiquidaciones);
            this.Controls.Add(this.buttonEjecutar);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1004, 775);
            this.MinimumSize = new System.Drawing.Size(1004, 758);
            this.Name = "Liquidaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liquidaciones.";
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
        private System.Windows.Forms.Label labelTotalLiquidaciones;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBultos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioMedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.Button buttonDelete;
    }
}