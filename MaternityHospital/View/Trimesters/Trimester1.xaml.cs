using MaternityHospital.Services;
using System.Windows.Controls;

namespace MaternityHospital.View.Trimesters
{
    public partial class Trimester1 : UserControl
    {
        public Trimester1()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
        }
    }
}