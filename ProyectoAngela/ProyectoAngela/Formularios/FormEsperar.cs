﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class FormEsperar : Form
    {
        public FormEsperar(string text)
        {
            InitializeComponent();
            this.label1.Text = text;
        }

        private void FormEsperar_Load(object sender, EventArgs e)
        {

        }
    }
}
