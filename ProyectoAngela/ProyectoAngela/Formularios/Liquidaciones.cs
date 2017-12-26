using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionAngela.Utils.Models.Liquidaciones;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class Liquidaciones : Form
    {
        IFacturaProvider facturaProvider;

        public Liquidaciones(IFacturaProvider facturaProvider)
        {
            this.facturaProvider = facturaProvider;
            InitializeComponent();
        }

        private void Liquidaciones_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonEjecutar_Click(object sender, EventArgs e)
        {
            var startDate = this.dateTimePickerStart.Value;
            var endDate = this.dateTimePickerEnd.Value;

            if(startDate > endDate)
            {
                MessageBox.Show("Las fechas introducidas son incorrectas.");
            }
            else
            {
                var viewModel = this.facturaProvider.GetLineasFacturaParaFechas(startDate, endDate);
                this.FillForm(viewModel);
            }
        }

        private void FillForm(LiquidacionesViewModel viewModel)
        {
            this.dataGridViewLiquidaciones.DataSource = viewModel.LineasLiquidacion;
        }
    }
}
