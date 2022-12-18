using MaternityHospital.View.Utils;
using System.Windows;
using System.Windows.Controls;

namespace MaternityHospital.View.Windows
{
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
            
        }

        private void Translabialnoe(object sender, RoutedEventArgs e)
        {
            
        }

        private void Transperenialnoe(object sender, RoutedEventArgs e)
        {
            
        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            Close();
            /*new Window3().Show();*/
            
        }
    }
}
