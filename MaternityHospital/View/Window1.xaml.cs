using MaternityHospital.View.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MaternityHospital
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            heartRate.PreviewTextInput += TextBoxFilters.LimitNumber;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (TextBlock)plod.SelectedItem;
            if(selectedItem.Text == "один")
            {
                plod_Copy.Visibility = Visibility.Hidden;  //не видно
            }
            else
            {
                plod_Copy.Visibility = Visibility.Visible;  //видно
            }
        }
    }
}
