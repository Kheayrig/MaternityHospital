using MaternityHospital.Services;
using MaternityHospital.View;
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
            heartRate.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            WindowState = WindowState.Maximized;
            FontSize = AppSettings.CurrentFontSize;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dvijeniye == null || dvijeniye_Copy == null) return;
            var selectedItem = (TextBlock)dvijeniye.SelectedItem;
            if (selectedItem.Text == "нет")
            {
                dvijeniye_Copy.Visibility = Visibility.Hidden;  //не видно
            }
            else
            {
                dvijeniye_Copy.Visibility = Visibility.Visible;  //видно
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (Breath_movement == null || Breath_movement_Copy == null) return;
            var selectedItem = (TextBlock)Breath_movement.SelectedItem;
            if (selectedItem.Text == "нет")
            {
                Breath_movement_Copy.Visibility = Visibility.Hidden;  //не видно
            }
            else
            {
                Breath_movement_Copy.Visibility = Visibility.Visible;  //видно
            }
        }

        private void heartRate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
            new Window2().Show();
        }
    }
}
