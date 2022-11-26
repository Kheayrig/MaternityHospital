using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MaternityHospital.View.Utils
{
    internal static class TextBoxFilters
    {
        internal static void FilterOnlyNumber(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[^0-9]+");
            e.Handled = re.IsMatch(e.Text);
        }
        internal static void FilterRusLettersSpaceDashApostrophe(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[^А-Яа-я\\s'-]+");
            e.Handled = re.IsMatch(e.Text);
        }
    }
}
