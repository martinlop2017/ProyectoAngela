﻿namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class ImprimirFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimirFacturas));
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDocumentoInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDocumentoFinal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Location = new System.Drawing.Point(267, 261);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(208, 60);
            this.button8.TabIndex = 38;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(49, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Documento Inical";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxDocumentoInicial
            // 
            this.textBoxDocumentoInicial.Location = new System.Drawing.Point(190, 130);
            this.textBoxDocumentoInicial.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDocumentoInicial.Name = "textBoxDocumentoInicial";
            this.textBoxDocumentoInicial.Size = new System.Drawing.Size(96, 20);
            this.textBoxDocumentoInicial.TabIndex = 39;
            this.textBoxDocumentoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(49, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Documento Final";
            // 
            // textBoxDocumentoFinal
            // 
            this.textBoxDocumentoFinal.Location = new System.Drawing.Point(188, 178);
            this.textBoxDocumentoFinal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDocumentoFinal.Name = "textBoxDocumentoFinal";
            this.textBoxDocumentoFinal.Size = new System.Drawing.Size(98, 20);
            this.textBoxDocumentoFinal.TabIndex = 41;
            this.textBoxDocumentoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(59, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(405, 42);
            this.label9.TabIndex = 43;
            this.label9.Text = "Imprimir Documentos";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.checkBox1.Location = new System.Drawing.Point(360, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 21);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "Imprimir";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.checkBox2.Location = new System.Drawing.Point(360, 177);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 21);
            this.checkBox2.TabIndex = 45;
            this.checkBox2.Text = "Archivo";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGuardar.Location = new System.Drawing.Point(42, 261);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(208, 60);
            this.buttonGuardar.TabIndex = 37;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // ImprimirFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(523, 384);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDocumentoFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDocumentoInicial);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonGuardar);
            this.KeyPreview = true;
            this.Name = "ImprimirFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImprimirFacturas";
            this.Load += new System.EventHandler(this.ImprimirFacturas_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImprimirFacturas_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDocumentoInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDocumentoFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button buttonGuardar;
    }
}