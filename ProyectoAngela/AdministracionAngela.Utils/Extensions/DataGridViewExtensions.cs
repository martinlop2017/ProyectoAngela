using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionAngela.Utils.Extensions
{
    public static class DataGridViewExtensions
    {
        /// <summary>
        /// Mapea las selectedRows de un DataGridView a una Lista de objeto "T"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rows"></param>
        /// <returns></returns>
        public static List<T> ToList<T>(this DataGridViewSelectedRowCollection rows)
        {
            var list = new List<T>();
            for (int i = 0; i < rows.Count; i++)
            {
                var entity = (T)rows[i].DataBoundItem;
                if (entity != null)
                {
                    list.Add((T)rows[i].DataBoundItem);
                }
            }

            return list;
        }

        /// <summary>
        /// Mapea todas las fileas de un DataGridView a una Lista de objeto "T"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rows"></param>
        /// <returns></returns>
        public static List<T> ToList<T>(this DataGridViewRowCollection rows)
        {
            var list = new List<T>();
            for (int i = 0; i < rows.Count; i++)
            {
                var entity = (T) rows[i].DataBoundItem;
                if (entity != null)
                {
                    list.Add((T) rows[i].DataBoundItem);
                }
            }
            return list;
        }
    }
}
