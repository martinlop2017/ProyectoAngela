using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface IFormOpener
    {
        DialogResult ShowModalForm<TForm>() where TForm : Form;
        Form GetForm<TForm>() where TForm : Form;
    }
}
