using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionAngela.Domain.Interfaces
{
    public interface IFormOpener
    {
        DialogResult ShowModalForm<TForm>() where TForm : Form;
    }
}
