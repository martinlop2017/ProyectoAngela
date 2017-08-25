﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAngela
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes myForm = new ProyectoAngela.Clientes();
            myForm.ShowDialog();
        }

        private void factruasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionFacturas myForm = new ProyectoAngela.GestionFacturas();
            myForm.ShowDialog();
        }
    }
}
