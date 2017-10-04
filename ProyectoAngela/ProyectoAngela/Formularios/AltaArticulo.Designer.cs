namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class AltaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaArticulo));
            this.validationProvider1 = new AdministracionAngela.CustomControls.ValidationProvider.ValidationProvider(this.components);
            this.textBoxCodigoArticulo = new System.Windows.Forms.TextBox();
            this.customGroupBox7 = new AdministracionAngela.CustomControls.CustomGroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.customGroupBox1 = new AdministracionAngela.CustomControls.CustomGroupBox();
            this.comboBoxIVA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customGroupBox7.SuspendLayout();
            this.customGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // validationProvider1
            // 
            this.validationProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.validationProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("validationProvider1.Icon")));
            // 
            // textBoxCodigoArticulo
            // 
            this.textBoxCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoArticulo.Location = new System.Drawing.Point(21, 64);
            this.textBoxCodigoArticulo.Name = "textBoxCodigoArticulo";
            this.textBoxCodigoArticulo.Size = new System.Drawing.Size(84, 23);
            this.textBoxCodigoArticulo.TabIndex = 4;
            this.textBoxCodigoArticulo.Text = "fdfdf";
            this.textBoxCodigoArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigoArticulo_KeyPress);
            // 
            // customGroupBox7
            // 
            this.customGroupBox7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.customGroupBox7.BackgroundGradientColor = System.Drawing.Color.White;
            this.customGroupBox7.BackgroundGradientMode = AdministracionAngela.CustomControls.CustomGroupBox.GroupBoxGradientMode.None;
            this.customGroupBox7.BorderColor = System.Drawing.Color.SteelBlue;
            this.customGroupBox7.BorderThickness = 3F;
            this.customGroupBox7.Controls.Add(this.button7);
            this.customGroupBox7.Controls.Add(this.button8);
            this.customGroupBox7.CustomGroupBoxColor = System.Drawing.Color.White;
            this.customGroupBox7.GroupImage = null;
            this.customGroupBox7.GroupTitle = "";
            this.customGroupBox7.Location = new System.Drawing.Point(24, 214);
            this.customGroupBox7.Name = "customGroupBox7";
            this.customGroupBox7.PaintGroupBox = false;
            this.customGroupBox7.RoundCorners = 10;
            this.customGroupBox7.ShadowColor = System.Drawing.Color.DarkGray;
            this.customGroupBox7.ShadowControl = false;
            this.customGroupBox7.ShadowThickness = 3;
            this.customGroupBox7.Size = new System.Drawing.Size(591, 111);
            this.customGroupBox7.TabIndex = 32;
            this.customGroupBox7.TabStop = false;
            this.customGroupBox7.Text = "customGroupBox7";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Location = new System.Drawing.Point(64, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(208, 60);
            this.button7.TabIndex = 0;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Location = new System.Drawing.Point(335, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(208, 60);
            this.button8.TabIndex = 1;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.customGroupBox1.BackgroundGradientColor = System.Drawing.Color.White;
            this.customGroupBox1.BackgroundGradientMode = AdministracionAngela.CustomControls.CustomGroupBox.GroupBoxGradientMode.None;
            this.customGroupBox1.BorderColor = System.Drawing.Color.SteelBlue;
            this.customGroupBox1.BorderThickness = 3F;
            this.customGroupBox1.Controls.Add(this.comboBoxIVA);
            this.customGroupBox1.Controls.Add(this.label1);
            this.customGroupBox1.Controls.Add(this.textBoxCodigoArticulo);
            this.customGroupBox1.Controls.Add(this.label5);
            this.customGroupBox1.Controls.Add(this.textBoxDescripcion);
            this.customGroupBox1.Controls.Add(this.label10);
            this.customGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.customGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customGroupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.customGroupBox1.GroupImage = null;
            this.customGroupBox1.GroupTitle = " Datos Articulos    ";
            this.customGroupBox1.Location = new System.Drawing.Point(24, 97);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.PaintGroupBox = false;
            this.customGroupBox1.RoundCorners = 10;
            this.customGroupBox1.ShadowColor = System.Drawing.Color.DarkGray;
            this.customGroupBox1.ShadowControl = false;
            this.customGroupBox1.ShadowThickness = 3;
            this.customGroupBox1.Size = new System.Drawing.Size(591, 111);
            this.customGroupBox1.TabIndex = 31;
            this.customGroupBox1.TabStop = false;
            this.customGroupBox1.Text = "customGroupBox1";
            // 
            // comboBoxIVA
            // 
            this.comboBoxIVA.FormattingEnabled = true;
            this.comboBoxIVA.Location = new System.Drawing.Point(434, 63);
            this.comboBoxIVA.Name = "comboBoxIVA";
            this.comboBoxIVA.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIVA.TabIndex = 24;
            this.comboBoxIVA.SelectedIndexChanged += new System.EventHandler(this.comboBoxIVA_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "IVA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(18, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Referencia";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(121, 64);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(296, 23);
            this.textBoxDescripcion.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(121, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Descripcion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(150, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 42);
            this.label7.TabIndex = 30;
            this.label7.Text = "Gestión de Articulos";
            // 
            // AltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::AdministracionAngela.ProyectoAngela.Properties.Resources.Rectangulo_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 344);
            this.ControlBox = false;
            this.Controls.Add(this.customGroupBox7);
            this.Controls.Add(this.customGroupBox1);
            this.Controls.Add(this.label7);
            this.DoubleBuffered = true;
            this.Name = "AltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaArticulo";
            this.Load += new System.EventHandler(this.AltaArticulo_Load);
            this.customGroupBox7.ResumeLayout(false);
            this.customGroupBox1.ResumeLayout(false);
            this.customGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.ValidationProvider.ValidationProvider validationProvider1;
        private System.Windows.Forms.TextBox textBoxCodigoArticulo;
        private CustomControls.CustomGroupBox customGroupBox7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private CustomControls.CustomGroupBox customGroupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxIVA;
        private System.Windows.Forms.Label label1;
    }
}