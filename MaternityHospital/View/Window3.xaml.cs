using MaternityHospital.View.Utils;
using MaternityHospital.View.Windows;
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

namespace MaternityHospital.View
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            vish.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
        }


        private void dalee(object sender, RoutedEventArgs e)
        {
            Close();
            new WindowPODY3().Show();
        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            Close();
            new Window2().Show();
        }

        private void Cns(object sender, RoutedEventArgs e)
        {
            new CnsFaceNeck().Show();
        }

        private void Heart(object sender, RoutedEventArgs e)
        {
            new HeartLargeonesVessels().Show();
        }

        private void Chest(object sender, RoutedEventArgs e)
        {
            new ChestCavity().Show();
        }

        private void Skelet(object sender, RoutedEventArgs e)
        {
            new Skelet().Show();
        }

        private void Abdominal(object sender, RoutedEventArgs e)
        {
            new AbdominalCavity().Show();
        }

        private void Pypovina(object sender, RoutedEventArgs e)
        {
            new pypovina().Show();
        }

     
    }
}
