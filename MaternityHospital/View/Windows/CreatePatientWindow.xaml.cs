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
            passportNumberTextBox.PreviewTextInput += TextBoxFilters.LimitNumber;
            passportSeriaTextBox.PreviewTextInput += TextBoxFilters.LimitNumber;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            string fio = fioTextBox.Text;
            int passportSeria = int.Parse(passportSeriaTextBox.Text);
            int passportNumber = int.Parse(passportNumberTextBox.Text);
            int snils = 231231;
            DateTime birthday = birthdayDatePicker.SelectedDate.Value;
            Patient patient = new Patient(fio, birthday, passportSeria, passportNumber, snils, DateTime.Now);
            //PatientsRepository.Add(patient);
            MessageBox.Show(patient.ToString());
        }
    }
}
