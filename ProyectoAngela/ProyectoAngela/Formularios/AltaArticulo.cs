﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionAngela.Utils.Interfaces;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class AltaArticulo : Form
    {
        private IArticuloProvider articuloProvider;

        public AltaArticulo(IArticuloProvider articuloProvider)
        {
            this.articuloProvider = articuloProvider;
            InitializeComponent();
        }
    }
}
