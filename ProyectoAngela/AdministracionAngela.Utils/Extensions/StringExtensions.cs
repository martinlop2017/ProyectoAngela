using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Extensions
{
    public static class StringExtensions
    {
        public static bool IsInt(this string value)
        {
            int number;
            return int.TryParse(value, out number);
        }
    }
}
