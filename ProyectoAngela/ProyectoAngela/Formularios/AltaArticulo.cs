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
using AdministracionAngela.Utils.Models.Articulo;

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

        private bool Validate()
        {
            return
                string.IsNullOrEmpty(this.validationProvider1.ValidationMessages(!this.validationProvider1.Validate()));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                var nuevoArticulo = this.ReadNewArticuloFromForm();
                this.articuloProvider.SaveArticulo(nuevoArticulo);
            }
        }

        private AltaArticuloViewModel ReadNewArticuloFromForm()
        {
            return new AltaArticuloViewModel()
            {
                Descripcion = this.textBoxDescripcion.Text
            };
        }
    }
}
