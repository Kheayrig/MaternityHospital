using MaternityHospital.Services;
using System.Windows.Controls;

namespace MaternityHospital.View.Trimesters
{
    public partial class Trimester2 : UserControl
    {
        public Trimester2()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
        }
    }
}