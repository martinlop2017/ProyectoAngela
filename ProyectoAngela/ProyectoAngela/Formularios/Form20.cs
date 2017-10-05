using System;
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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetnUEVO.LineaFactura' table. You can move, or remove it, as needed.
            this.LineaFacturaTableAdapter.Fill(this.DataSetnUEVO.LineaFactura);

            this.reportViewer1.RefreshReport();
        }
    }
}
