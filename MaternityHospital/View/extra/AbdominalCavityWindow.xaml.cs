using MaternityHospital.Services;
using System.Windows;

namespace MaternityHospital.View.extra
{
    public partial class AbdominalCavityWindow : Window
    {
        public AbdominalCavityWindow()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
        }

    }
}
