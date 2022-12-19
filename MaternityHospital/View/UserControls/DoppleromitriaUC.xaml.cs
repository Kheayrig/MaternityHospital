using MaternityHospital.Services;
using MaternityHospital.View.Utils;
using System;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class DoppleromitriaUC : UserControl
    {
        private int _index;
        public DoppleromitriaUC()
        {
            InitializeComponent();
            ArterPypoviny1.PreviewTextInput += TextBoxFilters.FilterOnlyDoubleNumber;
            ArterPypoviny2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            ArterPypoviny3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            CMozg1.PreviewTextInput += TextBoxFilters.FilterOnlyDoubleNumber;
            CMozg2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            CMozg3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            MCA1.PreviewTextInput += TextBoxFilters.FilterOnlyDoubleNumber;
            MCA2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            MCA3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            DiagKonyga.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            switch (AppSettings.CurrentPatient.Trimester)
            {
                case 1:
                    _index = (int)(Trimester1Enum)Enum.Parse(typeof(Trimester1Enum), "Dopplerometria");
                    break;
                case 2:
                    _index = (int)(Trimester2Enum)Enum.Parse(typeof(Trimester2Enum), "Dopplerometria");
                    break;
                case 3:
                    _index = (int)(Trimester3Enum)Enum.Parse(typeof(Trimester3Enum), "Dopplerometria");
                    break;
                case 4:
                    _index = (int)(ChildBirthEnum)Enum.Parse(typeof(ChildBirthEnum), "Dopplerometria");
                    break;
            }
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsLoaded) return;
            var item = sender as ComboBox;
            var pr = typeof(Dopplerometria).GetProperty(item.Name);
            pr.SetValue(AppSettings.WindowsList[_index] as Dopplerometria, (item.SelectedValue as TextBlock).Text);
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            var item = sender as TextBox;
            var pr = typeof(Dopplerometria).GetProperty(item.Name);
            pr.SetValue(AppSettings.WindowsList[_index] as Dopplerometria, item.Text);
        }
    }
}
