using MaternityHospital.Services;
using MaternityHospital.View.Windows;
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
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
            SetInfo();
        }

        private void SetInfo()
        {
            var patient = AppSettings.CurrentPatient;
            FIO.Content = patient.FIO;
            CurrentDate.Content = DateTime.UtcNow.Date;
            if (patient.LastPeriodDate != null) LastPeriodDate.Content = patient.LastPeriodDate;
            PregnancyDuration.Content = $"{patient.PregnancyDurationWeek} н. {patient.PregnancyDurationDay} д.";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new ReportWindow();
            window.ShowDialog();
        }
    }
}
