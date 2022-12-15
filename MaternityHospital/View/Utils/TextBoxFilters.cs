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
        /// <summary>
        /// ставить в TextBox в событие PreviewTextInput, чтобы установить ввод только цифр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal static void FilterOnlyNumber(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[^0-9]+");
            e.Handled = re.IsMatch(e.Text);
        }
        internal static void FilterOnlyDoubleNumber(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[^0-9.]+");
            e.Handled = re.IsMatch(e.Text);
        }
        /// <summary>
        /// тавить в TextBox в событие PreviewTextInput, чтобы установить ввод только русских букв(А-я), тире(-), апострофа(') и пробела
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal static void FilterRusLettersSpaceDashApostrophe(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[^А-Яа-я\\s'-]+");
            e.Handled = re.IsMatch(e.Text);
        }
        internal static void FilterFIOShortForm(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[^А-Яа-я.\\s'-]+");
            e.Handled = re.IsMatch(e.Text);
        }
    }
}
