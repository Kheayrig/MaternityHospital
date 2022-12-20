using MaternityHospital.Services;
using MaternityHospital.View.Utils;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class TranslabialnoeUC : UserControl
    {
        private int _index;
        public TranslabialnoeUC()
        {
            InitializeComponent();
            DlinaCHeKanala.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            RastoaniePD.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            RastoanieHSD.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
            switch (AppSettings.CurrentPatient.Trimester)
            {
                case 1:
                    _index = (int)(Trimester1Enum)Enum.Parse(typeof(Trimester1Enum), "Translabialnoe");
                    break;
                case 2:
                    _index = (int)(Trimester2Enum)Enum.Parse(typeof(Trimester2Enum), "Translabialnoe");
                    break;
                case 3:
                    _index = (int)(Trimester3Enum)Enum.Parse(typeof(Trimester3Enum), "Translabialnoe");
                    break;
                case 4:
                    _index = (int)(ChildBirthEnum)Enum.Parse(typeof(ChildBirthEnum), "Translabialnoe");
                    break;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var l = (Translabialnoe)AppSettings.WindowsList[_index];
            SetValues(l);
        }

        private void SetValues(Translabialnoe item)
        {
            DlinaCHeKanala.Text = item.DlinaCHeKanala;
            RastoanieHSD.Text = item.RastoanieHSD;
            RastoaniePD.Text = item.RastoaniePD;
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsLoaded) return;
            var item = sender as ComboBox;
            var pr = typeof(Translabialnoe).GetProperty(item.Name);
            pr.SetValue(AppSettings.WindowsList[_index] as Translabialnoe, (item.SelectedValue as TextBlock).Text);
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            var item = sender as TextBox;
            var pr = typeof(Translabialnoe).GetProperty(item.Name);
            pr.SetValue(AppSettings.WindowsList[_index] as Translabialnoe, item.Text);
        }
    }
}
