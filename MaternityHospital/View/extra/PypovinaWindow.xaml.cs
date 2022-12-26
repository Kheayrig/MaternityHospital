using MaternityHospital.Services;
using System.Windows;

namespace MaternityHospital.View.extra
{
    public partial class pypovinaWindow : Window
    {
        public pypovinaWindow()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
        }
    }
}
