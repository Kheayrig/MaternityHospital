using MaternityHospital.Services;
using System.Windows;

namespace MaternityHospital.View.extra
{
    public partial class ChestCavityWindow : Window
    {
        public ChestCavityWindow()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
        }
    }
}
