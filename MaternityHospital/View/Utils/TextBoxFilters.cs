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
            Regex re = new Regex("[^А-ЯЁа-яё\\s'-]+");
            e.Handled = re.IsMatch(e.Text);
        }
        internal static void FilterFIOShortForm(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[^А-ЯЁа-яё.\\s'-]+");
            e.Handled = re.IsMatch(e.Text);
        }
        internal static bool CheckFIO(string fio)
        {
            var pattern1 = "[А-ЯЁ]+";
            var pattern2 = "[а-яё]+";
            var pattern3 = @"^([А-ЯЁа-яё]+[\-\s\']?){2,}$";
            var pattern4 = @"[\s\'\-]{3,}";
            if (!Regex.IsMatch(fio, pattern1) || !Regex.IsMatch(fio, pattern2) || !Regex.IsMatch(fio, pattern3) || Regex.IsMatch(fio, pattern4)) return false;
            return true;
        }
        internal static bool CheckFIOWithPoints(string fio)
        {
            var pattern1 = "[А-ЯЁ]+";
            var pattern2 = "[а-яё]+";
            var pattern3 = @"[\s]{2,}";
            var pattern4 = @"[\.\'\-]{2,}";
            var pattern5 = @"[\.\'\-][А-ЯЁа-яё]";
            if (!Regex.IsMatch(fio, pattern1) || !Regex.IsMatch(fio, pattern2) || Regex.IsMatch(fio, pattern3) || Regex.IsMatch(fio, pattern4) || Regex.IsMatch(fio, pattern5)) return false;
            return true;
        }
    }
}
