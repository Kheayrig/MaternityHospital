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
    /// Логика взаимодействия для Childbirth.xaml
    /// </summary>
    public partial class Childbirth : UserControl
    {
        public Childbirth()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
        }
    }
}
