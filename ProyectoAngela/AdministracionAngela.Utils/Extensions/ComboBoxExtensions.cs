using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionAngela.Utils.Extensions
{
    public static class ComboBoxExtensions
    {
        public static void FilterByTextIntroduced(this ComboBox Combo, List<string> OriginalValues )
        {
            string filter_param = Combo.Text.ToUpper();

            //if empty, it should contain original values
            //else it will contains filtered values
            Combo.DataSource = String.IsNullOrWhiteSpace(filter_param)
                ? OriginalValues
                : OriginalValues.FindAll(x => x.Contains(filter_param));

            Combo.SetSettingsToDisplayComboWhenFiltering(filter_param);
        }

        public static void SetSettingsToDisplayComboWhenFiltering(this ComboBox combo, string filterValue)
        {
            //display all the available values
            combo.DroppedDown = true;

            //to avoid the cursor to disappear
            Cursor.Current = Cursors.Default;

            // this will ensure that the drop down is as long as the list
            combo.IntegralHeight = true;

            // remove automatically selected first item
            combo.SelectedIndex = -1;

            combo.Text = filterValue;

            // set the position of the cursor
            combo.SelectionStart = filterValue.Length;
            combo.SelectionLength = 0;
        }
    }
}
