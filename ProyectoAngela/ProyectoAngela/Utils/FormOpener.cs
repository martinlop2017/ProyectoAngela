using AdministracionAngela.Domain.Interfaces;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAngela.Utils
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
                return form.ShowDialog();
            }
        }

        private Form GetForm<TForm>() where TForm : Form
        {
            return this.container.GetInstance<TForm>();
        }
    }
}
