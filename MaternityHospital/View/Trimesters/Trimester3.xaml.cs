using MaternityHospital.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaternityHospital.View.Trimesters
{
    /// <summary>
    /// Логика взаимодействия для Trimester3.xaml
    /// </summary>
    public partial class Trimester3 : UserControl
    {
        public Trimester3()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
        }
    }
}
