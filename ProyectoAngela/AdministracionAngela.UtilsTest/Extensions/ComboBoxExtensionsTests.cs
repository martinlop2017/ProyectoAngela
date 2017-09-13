using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Windows.Forms;
using AdministracionAngela.Utils.Extensions;

namespace AdministracionAngela.UtilsTest.Extensions
{
    public class ComboBoxExtensionsTests
    {
        public ComboBoxExtensionsTests()
        {
            
        }

        [Fact]
        public void Should_Filter_ComboBox()
        {
            List<string> originalValues = new List<string>()
            {
                "value1",
                "value2",
                "value3",
                "value11"
            };

            ComboBox combo = new ComboBox();
            combo.DataSource = originalValues;
            combo.Text = "1";

            combo.FilterByTextIntroduced(originalValues);

            Assert.Equal(2, (combo.DataSource as List<string>).Count);
        }

        [Fact]
        public void Should_Get_Empty_When_Filtering_ComboBox()
        {
            List<string> originalValues = new List<string>()
            {
                "value1",
                "value2",
                "value3",
                "value11"
            };

            ComboBox combo = new ComboBox();
            combo.DataSource = originalValues;
            combo.Text = "test";

            combo.FilterByTextIntroduced(originalValues);

            Assert.Equal(0, (combo.DataSource as List<string>).Count);
        }

        [Fact]
        public void Should_Hae_Original_Values_After_Text_Combo_Is_Set_To_Empty()
        {
            List<string> originalValues = new List<string>()
            {
                "value1",
                "value2",
                "value3",
                "value11"
            };

            ComboBox combo = new ComboBox();
            combo.DataSource = originalValues;
            combo.Text = "test";

            combo.FilterByTextIntroduced(originalValues);

            combo.Text = string.Empty;

            combo.FilterByTextIntroduced(originalValues);

            Assert.Equal(originalValues, (combo.DataSource as List<string>));
        }
    }
}
