using System.Windows.Forms;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonEliminarLinea = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewLineasFactura = new System.Windows.Forms.DataGridView();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLote = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.labelTotalRE = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.labelTotalIVA = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.labelTotalBase = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalCajas = new System.Windows.Forms.Label();
            this.labelNumeroFactura = new System.Windows.Forms.Label();
            this.ColumnProducto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCajas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKgs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLineasFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(772, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "&Salir";
            this.label5.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "&Eliminar";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "&Añadir";
            this.label8.Visible = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Location = new System.Drawing.Point(761, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 50);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(145, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 50);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonEliminarLinea
            // 
            this.buttonEliminarLinea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminarLinea.BackgroundImage")));
            this.buttonEliminarLinea.Location = new System.Drawing.Point(87, 139);
            this.buttonEliminarLinea.Name = "buttonEliminarLinea";
            this.buttonEliminarLinea.Size = new System.Drawing.Size(52, 50);
            this.buttonEliminarLinea.TabIndex = 4;
            this.buttonEliminarLinea.UseVisualStyleBackColor = true;
            this.buttonEliminarLinea.Click += new System.EventHandler(this.buttonEliminarLinea_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(29, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 50);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewLineasFactura
            // 
            this.dataGridViewLineasFactura.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewLineasFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLineasFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLineasFactura.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewLineasFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLineasFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLineasFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLineasFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLineasFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProducto,
            this.ColumnCodigo,
            this.ColumnCajas,
            this.ColumnKgs,
            this.ColumnPrecio,
            this.ColumnImporte});
            this.dataGridViewLineasFactura.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLineasFactura.Location = new System.Drawing.Point(28, 210);
            this.dataGridViewLineasFactura.Name = "dataGridViewLineasFactura";
            this.dataGridViewLineasFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewLineasFactura.Size = new System.Drawing.Size(785, 260);
            this.dataGridViewLineasFactura.StandardTab = true;
            this.dataGridViewLineasFactura.TabIndex = 6;
            this.dataGridViewLineasFactura.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLineasFactura_CellEndEdit);
            this.dataGridViewLineasFactura.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewLineasFactura_EditingControlShowing);
            this.dataGridViewLineasFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewLineasFactura_KeyPress);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(542, 65);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerFecha.RightToLeftLayout = true;
            this.dateTimePickerFecha.Size = new System.Drawing.Size(135, 24);
            this.dateTimePickerFecha.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(545, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Fecha.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.66242F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.46497F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.92994F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.46497F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.47771F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 488);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 156);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(697, 682);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 38);
            this.buttonSave.TabIndex = 49;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nº Factura.";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(165, 62);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(344, 26);
            this.comboBoxClientes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(706, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Lote.";
            // 
            // textBoxLote
            // 
            this.textBoxLote.Location = new System.Drawing.Point(703, 67);
            this.textBoxLote.Name = "textBoxLote";
            this.textBoxLote.Size = new System.Drawing.Size(105, 24);
            this.textBoxLote.TabIndex = 53;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(781, 604);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(25, 25);
            this.label42.TabIndex = 29;
            this.label42.Text = "€";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(640, 604);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(58, 25);
            this.labelTotal.TabIndex = 28;
            this.labelTotal.Text = "0.00";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(786, 562);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(20, 24);
            this.label40.TabIndex = 27;
            this.label40.Text = "€";
            // 
            // labelTotalRE
            // 
            this.labelTotalRE.AutoSize = true;
            this.labelTotalRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRE.Location = new System.Drawing.Point(675, 562);
            this.labelTotalRE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalRE.Name = "labelTotalRE";
            this.labelTotalRE.Size = new System.Drawing.Size(45, 24);
            this.labelTotalRE.TabIndex = 26;
            this.labelTotalRE.Text = "0.00";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(786, 538);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(20, 24);
            this.label38.TabIndex = 25;
            this.label38.Text = "€";
            // 
            // labelTotalIVA
            // 
            this.labelTotalIVA.AutoSize = true;
            this.labelTotalIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalIVA.Location = new System.Drawing.Point(675, 538);
            this.labelTotalIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalIVA.Name = "labelTotalIVA";
            this.labelTotalIVA.Size = new System.Drawing.Size(45, 24);
            this.labelTotalIVA.TabIndex = 24;
            this.labelTotalIVA.Text = "0.00";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(786, 514);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(20, 24);
            this.label37.TabIndex = 23;
            this.label37.Text = "€";
            // 
            // labelTotalBase
            // 
            this.labelTotalBase.AutoSize = true;
            this.labelTotalBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBase.Location = new System.Drawing.Point(675, 514);
            this.labelTotalBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalBase.Name = "labelTotalBase";
            this.labelTotalBase.Size = new System.Drawing.Size(45, 24);
            this.labelTotalBase.TabIndex = 22;
            this.labelTotalBase.Text = "0.00";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(556, 605);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(72, 25);
            this.label35.TabIndex = 21;
            this.label35.Text = "Total.";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(556, 565);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(92, 24);
            this.label34.TabIndex = 20;
            this.label34.Text = "Total R.E.";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(556, 538);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(101, 24);
            this.label33.TabIndex = 19;
            this.label33.Text = "Total I.V.A.";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(554, 514);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(103, 24);
            this.label32.TabIndex = 18;
            this.label32.Text = "Total Base.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 672);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Total Bultos: ";
            // 
            // labelTotalCajas
            // 
            this.labelTotalCajas.AutoSize = true;
            this.labelTotalCajas.Location = new System.Drawing.Point(126, 672);
            this.labelTotalCajas.Name = "labelTotalCajas";
            this.labelTotalCajas.Size = new System.Drawing.Size(0, 18);
            this.labelTotalCajas.TabIndex = 55;
            // 
            // labelNumeroFactura
            // 
            this.labelNumeroFactura.AutoSize = true;
            this.labelNumeroFactura.Location = new System.Drawing.Point(60, 73);
            this.labelNumeroFactura.Name = "labelNumeroFactura";
            this.labelNumeroFactura.Size = new System.Drawing.Size(46, 18);
            this.labelNumeroFactura.TabIndex = 56;
            this.labelNumeroFactura.Text = "label9";
            // 
            // ColumnProducto
            // 
            this.ColumnProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnProducto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnProducto.HeaderText = "Producto";
            this.ColumnProducto.Name = "ColumnProducto";
            this.ColumnProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnCajas
            // 
            this.ColumnCajas.HeaderText = "Cajas";
            this.ColumnCajas.Name = "ColumnCajas";
            // 
            // ColumnKgs
            // 
            this.ColumnKgs.HeaderText = "Kgs";
            this.ColumnKgs.Name = "ColumnKgs";
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnImporte
            // 
            this.ColumnImporte.HeaderText = "Importe";
            this.ColumnImporte.Name = "ColumnImporte";
            this.ColumnImporte.ReadOnly = true;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 750);
            this.Controls.Add(this.labelNumeroFactura);
            this.Controls.Add(this.labelTotalCajas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.textBoxLote);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.labelTotalRE);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelTotalIVA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotalBase);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.dataGridViewLineasFactura);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonEliminarLinea);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLineasFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonEliminarLinea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewLineasFactura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonSave;
        private Label label1;
        private ComboBox comboBoxClientes;
        private Label label2;
        private Label label3;
        private TextBox textBoxLote;
        private Label label42;
        private Label labelTotal;
        private Label label40;
        private Label labelTotalRE;
        private Label label38;
        private Label labelTotalIVA;
        private Label label37;
        private Label labelTotalBase;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label4;
        private Label labelTotalCajas;
        private Label labelNumeroFactura;
        private DataGridViewComboBoxColumn ColumnProducto;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnCajas;
        private DataGridViewTextBoxColumn ColumnKgs;
        private DataGridViewTextBoxColumn ColumnPrecio;
        private DataGridViewTextBoxColumn ColumnImporte;
    }
}