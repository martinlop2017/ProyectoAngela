namespace AdministracionAngela.ProyectoAngela.Formularios
{
    partial class AltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaUsuario));
            this.label7 = new System.Windows.Forms.Label();
            this.customGroupBox1 = new AdministracionAngela.CustomControls.CustomGroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.customGroupBox3 = new AdministracionAngela.CustomControls.CustomGroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.customGroupBox7 = new AdministracionAngela.CustomControls.CustomGroupBox();
            this.buttonAeptar = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.customGroupBox1.SuspendLayout();
            this.customGroupBox3.SuspendLayout();
            this.customGroupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(32, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(387, 42);
            this.label7.TabIndex = 27;
            this.label7.Text = "Gestión de Ususarios";
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.customGroupBox1.BackgroundGradientColor = System.Drawing.Color.White;
            this.customGroupBox1.BackgroundGradientMode = AdministracionAngela.CustomControls.CustomGroupBox.GroupBoxGradientMode.None;
            this.customGroupBox1.BorderColor = System.Drawing.Color.SteelBlue;
            this.customGroupBox1.BorderThickness = 3F;
            this.customGroupBox1.Controls.Add(this.maskedTextBox2);
            this.customGroupBox1.Controls.Add(this.maskedTextBoxPassword);
            this.customGroupBox1.Controls.Add(this.label8);
            this.customGroupBox1.Controls.Add(this.comboBoxNivel);
            this.customGroupBox1.Controls.Add(this.panel2);
            this.customGroupBox1.Controls.Add(this.label6);
            this.customGroupBox1.Controls.Add(this.textBoxUserName);
            this.customGroupBox1.Controls.Add(this.label11);
            this.customGroupBox1.Controls.Add(this.label10);
            this.customGroupBox1.Controls.Add(this.customGroupBox3);
            this.customGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White;
            this.customGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customGroupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.customGroupBox1.GroupImage = null;
            this.customGroupBox1.GroupTitle = " Datos Generales     ";
            this.customGroupBox1.Location = new System.Drawing.Point(12, 76);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.PaintGroupBox = false;
            this.customGroupBox1.RoundCorners = 10;
            this.customGroupBox1.ShadowColor = System.Drawing.Color.DarkGray;
            this.customGroupBox1.ShadowControl = false;
            this.customGroupBox1.ShadowThickness = 3;
            this.customGroupBox1.Size = new System.Drawing.Size(427, 268);
            this.customGroupBox1.TabIndex = 28;
            this.customGroupBox1.TabStop = false;
            this.customGroupBox1.Text = "customGroupBox1";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(185, 143);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(155, 23);
            this.maskedTextBox2.TabIndex = 2;
            this.maskedTextBox2.UseSystemPasswordChar = true;
            this.maskedTextBox2.Leave += new System.EventHandler(this.maskedTextBox2_Leave);
            // 
            // maskedTextBoxPassword
            // 
            this.maskedTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPassword.Location = new System.Drawing.Point(21, 143);
            this.maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            this.maskedTextBoxPassword.Size = new System.Drawing.Size(155, 23);
            this.maskedTextBoxPassword.TabIndex = 1;
            this.maskedTextBoxPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(18, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nivel:";
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.comboBoxNivel.Location = new System.Drawing.Point(21, 202);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(174, 24);
            this.comboBoxNivel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(346, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 50);
            this.panel2.TabIndex = 21;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.Leave += new System.EventHandler(this.panel2_Leave);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(185, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Repita Contraseña:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(21, 78);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(383, 23);
            this.textBoxUserName.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(18, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Contraseña:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(24, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nombre Usuario:";
            // 
            // customGroupBox3
            // 
            this.customGroupBox3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customGroupBox3.BackgroundGradientColor = System.Drawing.Color.White;
            this.customGroupBox3.BackgroundGradientMode = AdministracionAngela.CustomControls.CustomGroupBox.GroupBoxGradientMode.None;
            this.customGroupBox3.BorderColor = System.Drawing.Color.SteelBlue;
            this.customGroupBox3.BorderThickness = 1F;
            this.customGroupBox3.Controls.Add(this.radioButton1);
            this.customGroupBox3.Controls.Add(this.radioButton2);
            this.customGroupBox3.CustomGroupBoxColor = System.Drawing.Color.White;
            this.customGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customGroupBox3.GroupImage = null;
            this.customGroupBox3.GroupTitle = "";
            this.customGroupBox3.Location = new System.Drawing.Point(230, 172);
            this.customGroupBox3.Name = "customGroupBox3";
            this.customGroupBox3.PaintGroupBox = false;
            this.customGroupBox3.RoundCorners = 10;
            this.customGroupBox3.ShadowColor = System.Drawing.Color.DarkGray;
            this.customGroupBox3.ShadowControl = false;
            this.customGroupBox3.ShadowThickness = 3;
            this.customGroupBox3.Size = new System.Drawing.Size(174, 72);
            this.customGroupBox3.TabIndex = 2;
            this.customGroupBox3.TabStop = false;
            this.customGroupBox3.Text = "Group1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Activo";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(101, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Baja";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // customGroupBox7
            // 
            this.customGroupBox7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.customGroupBox7.BackgroundGradientColor = System.Drawing.Color.White;
            this.customGroupBox7.BackgroundGradientMode = AdministracionAngela.CustomControls.CustomGroupBox.GroupBoxGradientMode.None;
            this.customGroupBox7.BorderColor = System.Drawing.Color.SteelBlue;
            this.customGroupBox7.BorderThickness = 3F;
            this.customGroupBox7.Controls.Add(this.buttonAeptar);
            this.customGroupBox7.Controls.Add(this.button8);
            this.customGroupBox7.CustomGroupBoxColor = System.Drawing.Color.White;
            this.customGroupBox7.GroupImage = null;
            this.customGroupBox7.GroupTitle = "";
            this.customGroupBox7.Location = new System.Drawing.Point(12, 350);
            this.customGroupBox7.Name = "customGroupBox7";
            this.customGroupBox7.PaintGroupBox = false;
            this.customGroupBox7.RoundCorners = 10;
            this.customGroupBox7.ShadowColor = System.Drawing.Color.DarkGray;
            this.customGroupBox7.ShadowControl = false;
            this.customGroupBox7.ShadowThickness = 3;
            this.customGroupBox7.Size = new System.Drawing.Size(427, 111);
            this.customGroupBox7.TabIndex = 29;
            this.customGroupBox7.TabStop = false;
            this.customGroupBox7.Text = "customGroupBox7";
            // 
            // buttonAeptar
            // 
            this.buttonAeptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAeptar.BackgroundImage")));
            this.buttonAeptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAeptar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonAeptar.FlatAppearance.BorderSize = 0;
            this.buttonAeptar.Location = new System.Drawing.Point(21, 40);
            this.buttonAeptar.Name = "buttonAeptar";
            this.buttonAeptar.Size = new System.Drawing.Size(174, 48);
            this.buttonAeptar.TabIndex = 6;
            this.buttonAeptar.UseVisualStyleBackColor = true;
            this.buttonAeptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Location = new System.Drawing.Point(243, 40);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(174, 48);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(452, 481);
            this.ControlBox = false;
            this.Controls.Add(this.customGroupBox7);
            this.Controls.Add(this.customGroupBox1);
            this.Controls.Add(this.label7);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaUsuario";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AltaUsuario_KeyPress);
            this.customGroupBox1.ResumeLayout(false);
            this.customGroupBox1.PerformLayout();
            this.customGroupBox3.ResumeLayout(false);
            this.customGroupBox3.PerformLayout();
            this.customGroupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private CustomControls.CustomGroupBox customGroupBox1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private CustomControls.CustomGroupBox customGroupBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private CustomControls.CustomGroupBox customGroupBox7;
        private System.Windows.Forms.Button buttonAeptar;
        private System.Windows.Forms.Button button8;
    }
}