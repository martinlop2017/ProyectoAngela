namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class GestionListados
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Articulos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Clientes");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sistema", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Albaranes Clientes Entre Fechas", 0, 0);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Facturas Clientes Entre Fechas");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Gestion", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionListados));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClienteFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClienteInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFechaFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFechaInicial = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 1;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(35, 110);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "Articulos";
            treeNode1.Text = "Articulos";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "Clientes";
            treeNode2.Text = "Clientes";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Sistema";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Sistema";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Albaranes";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "Albaranes Clientes Entre Fechas";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "Nodo5";
            treeNode5.Text = "Facturas Clientes Entre Fechas";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "Facturas";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "Gestion";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(276, 226);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            this.treeView1.MouseCaptureChanged += new System.EventHandler(this.treeView1_MouseCaptureChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bill.png");
            this.imageList1.Images.SetKeyName(1, "documents.png");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(213, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 42);
            this.label9.TabIndex = 44;
            this.label9.Text = "Listados";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(331, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "A Cliente";
            // 
            // textBoxClienteFinal
            // 
            this.textBoxClienteFinal.Enabled = false;
            this.textBoxClienteFinal.Location = new System.Drawing.Point(335, 217);
            this.textBoxClienteFinal.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxClienteFinal.Name = "textBoxClienteFinal";
            this.textBoxClienteFinal.Size = new System.Drawing.Size(233, 23);
            this.textBoxClienteFinal.TabIndex = 47;
            this.textBoxClienteFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(331, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "De Cliente";
            // 
            // textBoxClienteInicial
            // 
            this.textBoxClienteInicial.Enabled = false;
            this.textBoxClienteInicial.Location = new System.Drawing.Point(334, 157);
            this.textBoxClienteInicial.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxClienteInicial.Name = "textBoxClienteInicial";
            this.textBoxClienteInicial.Size = new System.Drawing.Size(234, 23);
            this.textBoxClienteInicial.TabIndex = 45;
            this.textBoxClienteInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(458, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "A Fecha";
            // 
            // textBoxFechaFinal
            // 
            this.textBoxFechaFinal.Enabled = false;
            this.textBoxFechaFinal.Location = new System.Drawing.Point(461, 293);
            this.textBoxFechaFinal.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxFechaFinal.Name = "textBoxFechaFinal";
            this.textBoxFechaFinal.Size = new System.Drawing.Size(107, 23);
            this.textBoxFechaFinal.TabIndex = 51;
            this.textBoxFechaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(333, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "De Fecha";
            // 
            // textBoxFechaInicial
            // 
            this.textBoxFechaInicial.Enabled = false;
            this.textBoxFechaInicial.Location = new System.Drawing.Point(336, 293);
            this.textBoxFechaInicial.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxFechaInicial.Name = "textBoxFechaInicial";
            this.textBoxFechaInicial.Size = new System.Drawing.Size(108, 23);
            this.textBoxFechaInicial.TabIndex = 49;
            this.textBoxFechaInicial.Text = "12/12/2018";
            this.textBoxFechaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Location = new System.Drawing.Point(317, 379);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(208, 60);
            this.button8.TabIndex = 54;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(84, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 60);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GestionListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(616, 502);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFechaFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFechaInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxClienteFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxClienteInicial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(632, 540);
            this.MinimumSize = new System.Drawing.Size(632, 540);
            this.Name = "GestionListados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionListados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClienteFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClienteInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFechaFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFechaInicial;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
    }
}