using MaternityHospital.DB.Models;
using MaternityHospital.Services;
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
    /// Логика взаимодействия для AddDoctor.xaml
    /// </summary>
    public partial class AddDoctor : Window
    {
        private Brush _borderColor = Brushes.Purple;
        public AddDoctor()
        {
            InitializeComponent();
            FontSize = AppSettings.CurrentFontSize;
            DoctorInfoTextBox.PreviewTextInput += TextBoxFilters.FilterFIOShortForm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string doctorFIO = DoctorInfoTextBox.Text.Trim();
            if(doctorFIO.Length == 0)
            {
                _borderColor = Brushes.Red;
                WarningLabel.Visibility = Visibility.Visible;
            }
            else
            {
                var doctor = new Doctor(doctorFIO);
                
                doctor.Add();
                DialogResult = true;
                Close();
            }
            
        }

        private void EnterKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Button_Click(sender, e);
            }
        }

    }
}
