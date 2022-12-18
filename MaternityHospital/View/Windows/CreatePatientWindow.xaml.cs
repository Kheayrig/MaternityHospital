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
using System.Globalization;
using System.Windows.Media.Converters;

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
            FontSize = AppSettings.customSettings.CurrentFontSize;
            SetDatePickersValues();
        }
        private void SetDatePickersValues()
        {
            FirstScanDatePicker.SelectedDate = DateTime.Now;
            FirstScanDatePicker.DisplayDateEnd = DateTime.Now;
            FirstScanDatePicker.DisplayDateStart = DateTime.Now.AddDays(-280);

            LastPeriodDatePicker.DisplayDateEnd = DateTime.Now.AddDays(-7);
            LastPeriodDatePicker.DisplayDateStart = DateTime.Now.AddDays(-280);

            birthdayDatePicker.DisplayDateEnd = DateTime.Now.AddYears(-11);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            var isFilled = CheckIsFilled();
            if (isFilled)
            {
                string fio = fioTextBox.Text.Trim();
                string doctor = AppSettings.customSettings.CurrentDoctor;
                string address = AddressTextBox.Text;
                DateTime? lastPeriodDate = LastPeriodDatePicker.SelectedDate;
                DateTime birthday = birthdayDatePicker.SelectedDate.Value;
                DateTime firstScanDate = FirstScanDatePicker.SelectedDate.Value;
                Patient patient = new Patient(fio, birthday, firstScanDate, doctor, address, lastPeriodDate);
                patient.Add();
                DialogResult = true;
                AppSettings.currentPatient = new CurrentPatient(patient);
                Close();
            }
        }
        private bool CheckIsFilled()
        {
            bool isFilled = true;
            if (fioTextBox.Text.Trim() == "") 
            { 
                fioWarning.Visibility = Visibility.Visible;
                fioTextBox.BorderBrush = Brushes.Red;
                isFilled = false;
            }
            else
            {
                fioWarning.Visibility = Visibility.Hidden;
                fioTextBox.BorderBrush = AddressTextBox.BorderBrush;
            }

            if (birthdayDatePicker.SelectedDate == null)
            {
                birthdayWarning.Visibility = Visibility.Visible;
                birthdayDatePicker.BorderBrush = Brushes.Red;
                isFilled = false;
            }
            else
            {
                birthdayWarning.Visibility = Visibility.Hidden;
                birthdayDatePicker.BorderBrush = AddressTextBox.BorderBrush;
            }
            if (!isFilled)
            {
                WarningLabel.Visibility = Visibility.Visible;
                isFilled = false;
            }
            return isFilled;
        }

        private void SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if((sender as DatePicker).SelectedDate == null)
            {
                DysmenorrheaCheckBox.IsChecked = true;
            }
            else
            {
                DysmenorrheaCheckBox.IsChecked = false;
            }
        }
    }
}
