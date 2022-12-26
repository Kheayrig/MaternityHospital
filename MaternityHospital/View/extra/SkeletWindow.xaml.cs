using MaternityHospital.Services;
using System.Windows;

namespace MaternityHospital.View.extra
{
    public partial class SkeletWindow : Window
    {
        public SkeletWindow()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
        }
    }
}
