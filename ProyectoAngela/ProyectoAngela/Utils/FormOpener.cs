using AdministracionAngela.ProyectoAngela.Formularios;
using AdministracionAngela.Servicios.ServicioDatos;
using AdministracionAngela.Servicios.ServicioDatos.DocumentosGestion;
using AdministracionAngela.Utils.Enumerados;
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

        public DialogResult ShowModalForm<TForm>() where TForm : Form
        {
            using (var form = this.GetForm<TForm>())
            {
                try
                {
                    return form.ShowDialog();
                }
                catch (Exception exp)
                {
                    return DialogResult.Abort;
                }
            }
        }

        public DialogResult ShowDocumentoGestionForm(EnumDocumentosGestion documento)
        {
            try
            {
                Form form = null;
                IDocumentoGestion documentoGestion = GetDocumentoGestion(documento);

                using (form = new GestionFacturas(this, documentoGestion))
                {
                    return form.ShowDialog();
                }
            }
            catch (Exception exp)
            {
                return DialogResult.Abort;
            }
        }

        public DialogResult ShowDocumentoForm(EnumDocumentosGestion documento)
        {
                if (documento == EnumDocumentosGestion.Factura)
                    return this.ShowModalForm<Facturacion>();
                else
                    return this.ShowModalForm<Albaranes>();
        }

        private IDocumentoGestion GetDocumentoGestion(EnumDocumentosGestion documento)
        {
            IDocumentoGestion documentoGestion;
            if (documento == EnumDocumentosGestion.Factura)
            {
                documentoGestion = this.container.GetInstance<DocumentoFactura>();
            }
            else
            {
                documentoGestion = this.container.GetInstance<DocumentoAlbaran>();
            }

            return documentoGestion;
        }

        public Form GetForm<TForm>() where TForm : Form
        {
            return this.container.GetInstance<TForm>();
        }

    }
}
