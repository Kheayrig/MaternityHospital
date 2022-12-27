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
using System.Text.RegularExpressions;

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
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
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
            birthdayDatePicker.SelectedDate = DateTime.Now.AddYears(-18);
            birthdayDatePicker.DisplayDateEnd = DateTime.Now.AddYears(-60);
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
                if (!TextBoxFilters.CheckFIO(fio))
                {
                    MessageBox.Show("Проверьте правильность ввода ФИО!");
                    return;
                }
                string address = AddressTextBox.Text;
                if (address != "" && !Regex.IsMatch(address, "[А-ЯЁа-яё]{5,}"))
                {
                    MessageBox.Show("Проверьте правильность ввода адреса!");
                    return;
                }
                DateTime? lastPeriodDate = LastPeriodDatePicker.SelectedDate;
                if(lastPeriodDate != null && (lastPeriodDate < DateTime.Now.AddDays(-280) || lastPeriodDate > DateTime.Now.AddDays(-7)))
                {
                    MessageBox.Show($"Неправильно заполнена дата месячных\nДата должна быть в пределах от {DateTime.Now.AddDays(-280)} до {DateTime.Now.AddDays(-7)}.");
                    return;
                }
                DateTime birthday = birthdayDatePicker.SelectedDate.Value;
                if (birthday < DateTime.Now.AddYears(-60) || birthday > DateTime.Now.AddYears(-11))
                {
                    MessageBox.Show($"Неправильно заполнена дата рождения\nДата должна быть в пределах от {DateTime.Now.AddYears(-60)} до {DateTime.Now.AddYears(-11)}.");
                    return;
                }
                DateTime firstScanDate = FirstScanDatePicker.SelectedDate.Value;
                if (firstScanDate < DateTime.Now.AddYears(-2) || firstScanDate > DateTime.Now)
                {
                    MessageBox.Show($"Неправильно заполнена дата сканирования\nДата должна быть в пределах от {DateTime.Now.AddYears(-2)} до {DateTime.Now}.");
                    return;
                }
                Patient patient = new Patient(fio, birthday, firstScanDate, AppSettings.CustomSettings.CurrentDoctor, address, lastPeriodDate);
                patient.Add();
                DialogResult = true;
                AppSettings.CurrentPatient = patient;
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
