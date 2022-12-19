using MaternityHospital.Services;
using MaternityHospital.View.extra;
using MaternityHospital.View.Utils;
using System.Windows;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class RashirenniyOsmotrUC : UserControl
    {
        public RashirenniyOsmotrUC()
        {
            InitializeComponent();
            vish.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
        }

        private void Cns(object sender, RoutedEventArgs e)
        {
            new CnsFaceNeckWindow().Show();
        }

        private void Heart(object sender, RoutedEventArgs e)
        {
            new HeartLargeonesVesselsWindow().Show();
        }

        private void Chest(object sender, RoutedEventArgs e)
        {
            new ChestCavityWindow().Show();
        }

        private void Skelet(object sender, RoutedEventArgs e)
        {
            new SkeletWindow().Show();
        }

        private void Abdominal(object sender, RoutedEventArgs e)
        {
            new AbdominalCavityWindow().Show();
        }

        private void Pypovina(object sender, RoutedEventArgs e)
        {
            new pypovinaWindow().Show();
        }
    }
}
