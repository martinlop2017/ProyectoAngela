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
          
        }

        private AltaArticuloViewModel ReadNewArticuloFromForm()
        {
            return new AltaArticuloViewModel()
            {
                Id = this.isUpdate ? this.articuloId : 0,
                CodigoArticulo = Convert.ToInt32(this.textBoxCodigoArticulo.Text),
                Descripcion = this.textBoxDescripcion.Text,
                SelectedIVA = this.comboBoxIVA.SelectedValue.ToString()
            };
        }

        private void FillFormWithArticulo(AltaArticuloViewModel articulo)
        {
            this.textBoxCodigoArticulo.Text = articulo.CodigoArticulo.ToString();
            this.textBoxDescripcion.Text = articulo.Descripcion;
            this.comboBoxIVA.DataSource = articulo.IVAs;
        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            AltaArticuloViewModel viewModel = new AltaArticuloViewModel();
            if (this.isUpdate)
            {
                viewModel = this.articuloProvider.GetAltaArticuloById(articuloId);
            }
            else
            {
                viewModel = this.articuloProvider.GetAltaArticulo();
            }

            this.FillFormWithArticulo(viewModel);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                var nuevoArticulo = this.ReadNewArticuloFromForm();
                var Ok = false;

                if (!isUpdate)
                {
                    Ok = this.articuloProvider.SaveArticulo(nuevoArticulo);
                }
                else
                {
                    Ok = this.articuloProvider.UpdateArticulo(nuevoArticulo);
                }

                if(!Ok)
                {
                    MessageBox.Show("El Articulo no se ha guardado correctamente");
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void textBoxCodigoArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxIVA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customGroupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
