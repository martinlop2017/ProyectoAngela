namespace AdministracionAngela.ProyectoAngela.Formularios
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
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewAvisos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ColumnCodigoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCobrada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvisos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBoxBusqueda);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(201, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 56);
            this.panel1.TabIndex = 31;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(12, 20);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(388, 20);
            this.textBoxBusqueda.TabIndex = 29;
            this.textBoxBusqueda.MouseEnter += new System.EventHandler(this.textBoxBusqueda_MouseEnter);
            this.textBoxBusqueda.MouseLeave += new System.EventHandler(this.textBoxBusqueda_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "&Salir";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "&Buscar";
            this.label4.Visible = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(621, 118);
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
            this.ColumnCobrada});
            this.dataGridViewAvisos.EnableHeadersVisualStyles = false;
            this.dataGridViewAvisos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAvisos.Location = new System.Drawing.Point(26, 195);
            this.dataGridViewAvisos.Name = "dataGridViewAvisos";
            this.dataGridViewAvisos.ReadOnly = true;
            this.dataGridViewAvisos.RowHeadersWidth = 20;
            this.dataGridViewAvisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAvisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvisos.Size = new System.Drawing.Size(647, 455);
            this.dataGridViewAvisos.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(26, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 56);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
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
            // ColumnCodigoFactura
            // 
            this.ColumnCodigoFactura.DataPropertyName = "CodigoFactura";
            this.ColumnCodigoFactura.HeaderText = "Cod.";
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
            this.ColumnCliente.Width = 275;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.DataPropertyName = "FechaFactura";
            this.ColumnFecha.HeaderText = "F. Fact.";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            this.ColumnFecha.Width = 80;
            // 
            // ColumnVencimiento
            // 
            this.ColumnVencimiento.DataPropertyName = "FechaVencimiento";
            this.ColumnVencimiento.HeaderText = "F. Vencim.";
            this.ColumnVencimiento.Name = "ColumnVencimiento";
            this.ColumnVencimiento.ReadOnly = true;
            this.ColumnVencimiento.Width = 80;
            // 
            // ColumnImporte
            // 
            this.ColumnImporte.DataPropertyName = "Importe";
            this.ColumnImporte.HeaderText = "Importe";
            this.ColumnImporte.Name = "ColumnImporte";
            this.ColumnImporte.ReadOnly = true;
            this.ColumnImporte.Width = 80;
            // 
            // ColumnCobrada
            // 
            this.ColumnCobrada.DataPropertyName = "Cobrada";
            this.ColumnCobrada.HeaderText = "Cobrada";
            this.ColumnCobrada.Name = "ColumnCobrada";
            this.ColumnCobrada.ReadOnly = true;
            this.ColumnCobrada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCobrada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnCobrada.Width = 50;
            // 
            // GestionAvisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AdministracionAngela.ProyectoAngela.Properties.Resources.Gestion_Articulos1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 687);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewAvisos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(716, 726);
            this.MinimumSize = new System.Drawing.Size(716, 726);
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
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridViewAvisos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImporte;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCobrada;
    }
}