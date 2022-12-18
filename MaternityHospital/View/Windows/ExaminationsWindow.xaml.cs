using System.Windows;
using MaternityHospital.Services;
using MaternityHospital.View.Trimesters;

namespace MaternityHospital.View.Windows
{
    public partial class Examinations : Window
    {
        public Examinations()
        {
            InitializeComponent();
            FontSize = AppSettings.customSettings.CurrentFontSize;
            var trimester = AppSettings.currentPatient.Patient.Trimester;
            switch (trimester)
            {
                case 1:
                    Tabs.Content = new Trimester1();
                    break;
                case 2:
                    Tabs.Content = new Trimester2();
                    break;
            }
        }
    }
}