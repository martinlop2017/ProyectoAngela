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
            AdministracionAngela.CustomControls.ValidationProvider.ValidationRule validationRule1 = new AdministracionAngela.CustomControls.ValidationProvider.ValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaArticulo));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.validationProvider1 = new AdministracionAngela.CustomControls.ValidationProvider.ValidationProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigoArticulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(270, 70);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescripcion.TabIndex = 1;
            validationRule1.ErrorMessage = "Required";
            validationRule1.IsRequired = true;
            this.validationProvider1.SetValidationRule(this.textBoxDescripcion, validationRule1);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(131, 152);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Ok";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // validationProvider1
            // 
            this.validationProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.validationProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("validationProvider1.Icon")));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo:";
            // 
            // textBoxCodigoArticulo
            // 
            this.textBoxCodigoArticulo.Location = new System.Drawing.Point(82, 70);
            this.textBoxCodigoArticulo.Name = "textBoxCodigoArticulo";
            this.textBoxCodigoArticulo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoArticulo.TabIndex = 4;
            // 
            // AltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 240);
            this.Controls.Add(this.textBoxCodigoArticulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "AltaArticulo";
            this.Text = "AltaArticulo";
            this.Load += new System.EventHandler(this.AltaArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonSave;
        private CustomControls.ValidationProvider.ValidationProvider validationProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigoArticulo;
    }
}