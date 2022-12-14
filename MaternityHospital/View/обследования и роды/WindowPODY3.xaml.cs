using MaternityHospital.View.Utils;
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
using System.Windows.Shapes;

namespace MaternityHospital.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowPODY3.xaml
    /// </summary>
    public partial class WindowPODY3 : Window
    {
        public WindowPODY3()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            VIZH.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            heartRate.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            BPR.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            DB.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            OZH.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            Massa.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;


        }

        private void Mass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Dopplerometria(object sender, RoutedEventArgs e)
        {
            new dopplerometria().Show();
        }

        private void Translabialnoe(object sender, RoutedEventArgs e)
        {
            new translabialnoe().Show();
        }

        private void Transperenialnoe(object sender, RoutedEventArgs e)
        {
            new transperinealnoe().Show();
        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            Close();
            new Window3().Show();
            
        }
    }
}
