using MaternityHospital.Services;
using MaternityHospital.View.Utils;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class DoppleromitriaUC : UserControl
    {
        private int _index;
        public DoppleromitriaUC()
        {
            InitializeComponent();
            ArterPypovinyPI.PreviewTextInput += TextBoxFilters.FilterOnlyDoubleNumber;
            ArterPypovinySrok.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            ArterPypovinyMass.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            CMozgPI.PreviewTextInput += TextBoxFilters.FilterOnlyDoubleNumber;
            CMozgSrok.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            CMozgMass.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            MCAPI.PreviewTextInput += TextBoxFilters.FilterOnlyDoubleNumber;
            MCASrok.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            MCAMass.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            DiagKonyga.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
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

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var l = (Dopplerometria)AppSettings.WindowsList[_index];
            SetValues(l);
        }

        private void SetValues(Dopplerometria item)
        {
            ArterPypovinyPI.Text = item.ArterPypovinyPI;
            ArterPypovinySrok.Text = item.ArterPypovinySrok;
            ArterPypovinyMass.Text = item.ArterPypovinyMass;
            CMozgPI.Text = item.CMozgPI;
            CMozgSrok.Text = item.CMozgSrok;
            CMozgMass.Text = item.CMozgMass;
            MCAPI.Text = item.MCAPI;
            MCASrok.Text = item.MCASrok;
            MCAMass.Text = item.MCAMass;
            DiagKonyga.Text = item.DiagKonyga;
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

            if (item.Text != "") pr.SetValue(AppSettings.WindowsList[_index] as Dopplerometria, item.Text);
        }
    }
}
