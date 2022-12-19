using MaternityHospital.Services;
using MaternityHospital.View.Utils;
using System.Windows.Controls;
using System;

namespace MaternityHospital.View.UserControls
{
    public partial class FetometriaUC : UserControl
    {
        private int _index = 1;
        public FetometriaUC()
        {
            InitializeComponent();
            BR.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            DBK.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            OJ.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            Mass.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            switch (AppSettings.CurrentPatient.Trimester)
            {
                case 1:
                    _index = (int)(Trimester1Enum)Enum.Parse(typeof(Trimester1Enum), "Fetometria");
                    break;
                case 2:
                    _index = (int)(Trimester2Enum)Enum.Parse(typeof(Trimester2Enum), "Fetometria");
                    break;
                case 3:
                    _index = (int)(Trimester3Enum)Enum.Parse(typeof(Trimester3Enum), "Fetometria");
                    break;
                case 4:
                    _index = (int)(ChildBirthEnum)Enum.Parse(typeof(ChildBirthEnum), "Fetometria");
                    break;
            }
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsLoaded) return;
            var item = sender as ComboBox;
            var pr = typeof(Fetometria).GetProperty(item.Name);
            pr.SetValue(AppSettings.WindowsList[_index] as Fetometria, (item.SelectedValue as TextBlock).Text);
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            var item = sender as TextBox;
            var pr = typeof(Fetometria).GetProperty(item.Name);
            pr.SetValue(AppSettings.WindowsList[_index] as Fetometria, int.Parse(item.Text));
        }

        private void CancelFet_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        //  new ObschieSvedenia().Show();
        }

        private void OKFet_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
