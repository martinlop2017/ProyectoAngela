using AdministracionAngela.ProyectoAngela.Formularios;
using AdministracionAngela.Servicios.ServicioDatos;
using AdministracionAngela.Servicios.ServicioDatos.DocumentosGestion;
using AdministracionAngela.Utils.Interfaces;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionAngela.ProyectoAngela.Utils
{
    public class FormOpener : IFormOpener
    {
        private readonly IContainer container;

        public FormOpener(IContainer container)
        {
            this.container = container;
        }

        public DialogResult ShowModalFormWithParameter<TForm>(int Id) where TForm : Form
        {
            using (var form = this.GetForm<TForm>())
            {
                return form.ShowDialog();
            }
        }

        public DialogResult ShowModalForm<TForm>() where TForm : Form
        {
            try
            {
                using (var form = this.GetForm<TForm>())
                {
                    return form.ShowDialog();
                }
            }
            catch(Exception exp)
            {
                return DialogResult.Abort;
            }
        }

        public DialogResult ShowDocumentoGestionForm(string documento)
        {
            try
            {
                Form form = null;
                IDocumentoGestion documentoGestion = null;

                if (documento.Equals("Factura"))
                {
                    documentoGestion = this.container.GetInstance<DocumentoFactura>();
                }

                using (form = new GestionFacturas(this, documentoGestion))
                {
                    return form.ShowDialog();
                }
            }
            catch(Exception exp)
            {
                return DialogResult.Abort;
            }
        }

        public Form GetForm<TForm>() where TForm : Form
        {
            return this.container.GetInstance<TForm>();
        }

    }
}
