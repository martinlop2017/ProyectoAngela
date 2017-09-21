using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionAngela.Utils.Extensions
{
    public static class DataGridViewRowExtensions
    {
        public static bool HasNullValues(this DataGridViewRow row)
        {
            return row.Cells.Cast<DataGridViewCell>().Any(c => c.Value == null);
        }
    }
}
