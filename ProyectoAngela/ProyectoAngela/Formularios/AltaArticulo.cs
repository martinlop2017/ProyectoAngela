using System;
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
        private bool isUpdate = false;
        private long articuloId;

        public AltaArticulo(IArticuloProvider articuloProvider)
        {
            this.articuloProvider = articuloProvider;
            InitializeComponent();
        }

        public void IsUpdate(long articuloId)
        {
            this.isUpdate = true;
            this.articuloId = articuloId;
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

                if (!isUpdate)
                {
                    this.articuloProvider.SaveArticulo(nuevoArticulo);
                }
                else
                {
                    //this.articuloProvider.UpdateArticulo(nuevoArticulo);
                }
            }
        }

        private AltaArticuloViewModel ReadNewArticuloFromForm()
        {
            return new AltaArticuloViewModel()
            {
                CodigoArticulo = Convert.ToInt32(this.textBoxCodigoArticulo.Text),
                Descripcion = this.textBoxDescripcion.Text
            };
        }

        private void FillFormWithArticulo(AltaArticuloViewModel articulo)
        {
            this.textBoxCodigoArticulo.Text = articulo.CodigoArticulo.ToString();
            this.textBoxDescripcion.Text = articulo.Descripcion;
        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            if (this.isUpdate)
            {
                var articulo = this.articuloProvider.GetAltaArticuloById(articuloId);
                this.FillFormWithArticulo(articulo);
            }
        }
    }
}
