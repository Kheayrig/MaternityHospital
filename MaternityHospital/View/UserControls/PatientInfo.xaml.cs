using MaternityHospital.Services;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class PatientInfo : UserControl
    {
        public PatientInfo()
        {
            InitializeComponent();
            FontSize = AppSettings.customSettings.CurrentFontSize;
            FIO.Content = AppSettings.currentPatient.Patient.FIO;
            TodayDate.Content = DateTime.Today;
            LastPeriodDate.Content = AppSettings.currentPatient.Patient.LastPeriodDate;
            PregnancyDuration.Content = $"{AppSettings.currentPatient.Patient.PregnancyDurationWeek} н. {AppSettings.currentPatient.Patient.PregnancyDurationDay} д.";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
