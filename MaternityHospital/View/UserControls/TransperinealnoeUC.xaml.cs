using MaternityHospital.Services;
using MaternityHospital.View.Utils;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class TransperinealnoeUC : UserControl
    {
        private int _index;
        public TransperinealnoeUC()
        {
            InitializeComponent();
            RaskrMatochnogoZeva.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            YgolMLA.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            RastoanieHPD.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
            switch (AppSettings.CurrentPatient.Trimester)
            {
                case 1:
                    _index = (int)(Trimester1Enum)Enum.Parse(typeof(Trimester1Enum), "Transperinealnoe");
                    break;
                case 2:
                    _index = (int)(Trimester2Enum)Enum.Parse(typeof(Trimester2Enum), "Transperinealnoe");
                    break;
                case 3:
                    _index = (int)(Trimester3Enum)Enum.Parse(typeof(Trimester3Enum), "Transperinealnoe");
                    break;
                case 4:
                    _index = (int)(ChildBirthEnum)Enum.Parse(typeof(ChildBirthEnum), "Transperinealnoe");
                    break;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var l = (Transperinealnoe)AppSettings.WindowsList[_index];
            SetValues(l);
        }

        private void SetValues(Transperinealnoe item)
        {
            RaskrMatochnogoZeva.Text = item.RaskrMatochnogoZeva;
            RastoanieHPD.Text = item.RastoanieHPD;
            YgolMLA.Text = item.YgolMLA;
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsLoaded) return;
            var item = sender as ComboBox;
            var pr = typeof(Transperinealnoe).GetProperty(item.Name);
            pr.SetValue(AppSettings.WindowsList[_index] as Transperinealnoe, (item.SelectedValue as TextBlock).Text);
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            var item = sender as TextBox;
            var pr = typeof(Transperinealnoe).GetProperty(item.Name);
            pr.SetValue(AppSettings.WindowsList[_index] as Transperinealnoe, item.Text);
        }
    }
}
