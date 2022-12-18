using MaternityHospital.Services;
using MaternityHospital.View.Utils;
using System.Windows;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class RashirenniyOsmotr : UserControl
    {
        public RashirenniyOsmotr()
        {
            InitializeComponent();
            vish.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            FontSize = AppSettings.customSettings.CurrentFontSize;
        }

        private void Cns(object sender, RoutedEventArgs e)
        {
            new CnsFaceNeck().Show();
        }

        private void Heart(object sender, RoutedEventArgs e)
        {
            new HeartLargeonesVessels().Show();
        }

        private void Chest(object sender, RoutedEventArgs e)
        {
            new ChestCavity().Show();
        }

        private void Skelet(object sender, RoutedEventArgs e)
        {
            new Skelet().Show();
        }

        private void Abdominal(object sender, RoutedEventArgs e)
        {
            new AbdominalCavity().Show();
        }

        private void Pypovina(object sender, RoutedEventArgs e)
        {
            new pypovina().Show();
        }
    }
}
