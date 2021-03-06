﻿namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class GestionAvisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionAvisos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerToFecha = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxPendientes = new System.Windows.Forms.CheckBox();
            this.checkBoxCobradas = new System.Windows.Forms.CheckBox();
            this.textBoxToCodigo = new System.Windows.Forms.TextBox();
            this.textBoxFromCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewAvisos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.botonfiltrar = new System.Windows.Forms.Button();
            this.ColumnCodigoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCobrada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvisos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dateTimePickerToFecha);
            this.panel1.Controls.Add(this.dateTimePickerFromFecha);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxPendientes);
            this.panel1.Controls.Add(this.checkBoxCobradas);
            this.panel1.Controls.Add(this.textBoxToCodigo);
            this.panel1.Controls.Add(this.textBoxFromCodigo);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(35, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 72);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePickerToFecha
            // 
            this.dateTimePickerToFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToFecha.Location = new System.Drawing.Point(258, 35);
            this.dateTimePickerToFecha.Name = "dateTimePickerToFecha";
            this.dateTimePickerToFecha.RightToLeftLayout = true;
            this.dateTimePickerToFecha.Size = new System.Drawing.Size(83, 20);
            this.dateTimePickerToFecha.TabIndex = 36;
            this.dateTimePickerToFecha.Value = new System.DateTime(2018, 12, 26, 0, 0, 0, 0);
            // 
            // dateTimePickerFromFecha
            // 
            this.dateTimePickerFromFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromFecha.Location = new System.Drawing.Point(169, 35);
            this.dateTimePickerFromFecha.Name = "dateTimePickerFromFecha";
            this.dateTimePickerFromFecha.RightToLeftLayout = true;
            this.dateTimePickerFromFecha.Size = new System.Drawing.Size(83, 20);
            this.dateTimePickerFromFecha.TabIndex = 35;
            this.dateTimePickerFromFecha.Value = new System.DateTime(2018, 11, 10, 11, 28, 40, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fecha Ftra. Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fecha Ftra. Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Hasta Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Desde Cliente";
            // 
            // checkBoxPendientes
            // 
            this.checkBoxPendientes.AutoSize = true;
            this.checkBoxPendientes.Location = new System.Drawing.Point(363, 35);
            this.checkBoxPendientes.Name = "checkBoxPendientes";
            this.checkBoxPendientes.Size = new System.Drawing.Size(79, 17);
            this.checkBoxPendientes.TabIndex = 9;
            this.checkBoxPendientes.Text = "Pendientes";
            this.checkBoxPendientes.UseVisualStyleBackColor = true;
            // 
            // checkBoxCobradas
            // 
            this.checkBoxCobradas.AutoSize = true;
            this.checkBoxCobradas.Location = new System.Drawing.Point(448, 35);
            this.checkBoxCobradas.Name = "checkBoxCobradas";
            this.checkBoxCobradas.Size = new System.Drawing.Size(71, 17);
            this.checkBoxCobradas.TabIndex = 8;
            this.checkBoxCobradas.Text = "Cobradas";
            this.checkBoxCobradas.UseVisualStyleBackColor = true;
            // 
            // textBoxToCodigo
            // 
            this.textBoxToCodigo.Location = new System.Drawing.Point(95, 35);
            this.textBoxToCodigo.Name = "textBoxToCodigo";
            this.textBoxToCodigo.Size = new System.Drawing.Size(64, 20);
            this.textBoxToCodigo.TabIndex = 1;
            this.textBoxToCodigo.Text = "999999";
            this.textBoxToCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxFromCodigo
            // 
            this.textBoxFromCodigo.Location = new System.Drawing.Point(16, 35);
            this.textBoxFromCodigo.Name = "textBoxFromCodigo";
            this.textBoxFromCodigo.Size = new System.Drawing.Size(64, 20);
            this.textBoxFromCodigo.TabIndex = 0;
            this.textBoxFromCodigo.Text = "0";
            this.textBoxFromCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(843, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "&Salir";
            this.label5.Visible = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(831, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 56);
            this.button5.TabIndex = 28;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            // 
            // dataGridViewAvisos
            // 
            this.dataGridViewAvisos.AllowUserToDeleteRows = false;
            this.dataGridViewAvisos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewAvisos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAvisos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAvisos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAvisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAvisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAvisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAvisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigoFactura,
            this.ColumnCliente,
            this.ColumnFecha,
            this.ColumnVencimiento,
            this.ColumnImporte,
            this.ColumnCobro,
            this.ColumnCobrada,
            this.ColumnBase,
            this.ColumnIva,
            this.ColumnRE});
            this.dataGridViewAvisos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewAvisos.EnableHeadersVisualStyles = false;
            this.dataGridViewAvisos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAvisos.Location = new System.Drawing.Point(35, 195);
            this.dataGridViewAvisos.Name = "dataGridViewAvisos";
            this.dataGridViewAvisos.RowHeadersWidth = 20;
            this.dataGridViewAvisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAvisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvisos.Size = new System.Drawing.Size(848, 472);
            this.dataGridViewAvisos.TabIndex = 32;
            this.dataGridViewAvisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAvisos_CellContentClick);
            this.dataGridViewAvisos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAvisos_CellValueChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(705, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 56);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(178, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 42);
            this.label7.TabIndex = 35;
            this.label7.Text = "Gestión de Cobros";
            // 
            // botonfiltrar
            // 
            this.botonfiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonfiltrar.BackgroundImage")));
            this.botonfiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonfiltrar.Location = new System.Drawing.Point(579, 118);
            this.botonfiltrar.Name = "botonfiltrar";
            this.botonfiltrar.Size = new System.Drawing.Size(120, 56);
            this.botonfiltrar.TabIndex = 36;
            this.botonfiltrar.UseVisualStyleBackColor = true;
            this.botonfiltrar.Click += new System.EventHandler(this.botonfiltrar_Click);
            // 
            // ColumnCodigoFactura
            // 
            this.ColumnCodigoFactura.DataPropertyName = "CodigoFactura";
            this.ColumnCodigoFactura.HeaderText = "N. Fac ";
            this.ColumnCodigoFactura.Name = "ColumnCodigoFactura";
            this.ColumnCodigoFactura.ReadOnly = true;
            this.ColumnCodigoFactura.Width = 60;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.DataPropertyName = "Cliente";
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
            this.ColumnCliente.Width = 325;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.DataPropertyName = "FechaFactura";
            this.ColumnFecha.HeaderText = "F. Fact.";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            this.ColumnFecha.Width = 95;
            // 
            // ColumnVencimiento
            // 
            this.ColumnVencimiento.DataPropertyName = "FechaVencimiento";
            this.ColumnVencimiento.HeaderText = "F. Vencim.";
            this.ColumnVencimiento.Name = "ColumnVencimiento";
            this.ColumnVencimiento.ReadOnly = true;
            this.ColumnVencimiento.Width = 95;
            // 
            // ColumnImporte
            // 
            this.ColumnImporte.DataPropertyName = "Importe";
            this.ColumnImporte.HeaderText = "Importe";
            this.ColumnImporte.Name = "ColumnImporte";
            this.ColumnImporte.ReadOnly = true;
            // 
            // ColumnCobro
            // 
            this.ColumnCobro.DataPropertyName = "FechaCobro";
            this.ColumnCobro.HeaderText = "F. Cobro";
            this.ColumnCobro.Name = "ColumnCobro";
            this.ColumnCobro.Width = 95;
            // 
            // ColumnCobrada
            // 
            this.ColumnCobrada.DataPropertyName = "Cobrada";
            this.ColumnCobrada.HeaderText = "Cobrada";
            this.ColumnCobrada.Name = "ColumnCobrada";
            this.ColumnCobrada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCobrada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnCobrada.Width = 50;
            // 
            // ColumnBase
            // 
            this.ColumnBase.DataPropertyName = "Base";
            this.ColumnBase.HeaderText = "Base";
            this.ColumnBase.Name = "ColumnBase";
            this.ColumnBase.Visible = false;
            // 
            // ColumnIva
            // 
            this.ColumnIva.DataPropertyName = "Iva";
            this.ColumnIva.HeaderText = "Iva";
            this.ColumnIva.Name = "ColumnIva";
            this.ColumnIva.Visible = false;
            // 
            // ColumnRE
            // 
            this.ColumnRE.DataPropertyName = "RE";
            this.ColumnRE.HeaderText = "RE";
            this.ColumnRE.Name = "ColumnRE";
            this.ColumnRE.Visible = false;
            // 
            // GestionAvisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AdministracionAngela.ProyectoAngela.Properties.Resources.Gestion_Articulos1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 710);
            this.ControlBox = false;
            this.Controls.Add(this.botonfiltrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewAvisos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(16, 726);
            this.Name = "GestionAvisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionAvisos";
            this.Load += new System.EventHandler(this.GestionAvisos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridViewAvisos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxToCodigo;
        private System.Windows.Forms.TextBox textBoxFromCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxPendientes;
        private System.Windows.Forms.CheckBox checkBoxCobradas;
        private System.Windows.Forms.Button botonfiltrar;
        private System.Windows.Forms.DateTimePicker dateTimePickerToFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCobro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCobrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRE;
    }
}