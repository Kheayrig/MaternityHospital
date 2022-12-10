using MaternityHospital.DB;
using MaternityHospital.DB.Repositories;
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
using MaternityHospital.View.Utils;
using MaternityHospital.DB.Models;
using MaternityHospital.Services;

namespace MaternityHospital.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для CreatePatient.xaml
    /// </summary>
    public partial class CreatePatientWindow : Window
    {
        public CreatePatientWindow()
        {
            InitializeComponent();
            fioTextBox.PreviewTextInput += TextBoxFilters.FilterRusLettersSpaceDashApostrophe;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            string fio = fioTextBox.Text.Trim();
            string doctor = Settings.GetCurrentDoctor();
            string address = AddressTextBox.Text;
            DateTime? lastPeriodDate = LastPeriodDatePicker.SelectedDate;
            DateTime birthday = birthdayDatePicker.SelectedDate.Value;

            Patient patient = new Patient(fio, birthday, DateTime.Now, doctor, address, lastPeriodDate);
            patient.Add();
            DialogResult = true;
            Close();
        }
    }
}
