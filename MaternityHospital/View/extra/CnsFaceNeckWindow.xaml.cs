using System.Windows;
using MaternityHospital.DB.Models.ViewClasses;
using MaternityHospital.Services;
using MaternityHospital.View.Utils;
using System.Windows;
using System.Windows.Controls;

namespace MaternityHospital.View.extra
{
    public partial class CnsFaceNeckWindow : Window
    {
        public CnsFaceNeckWindow()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
        }

    }
}
