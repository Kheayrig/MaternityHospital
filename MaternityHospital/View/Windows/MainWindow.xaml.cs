using MaternityHospital.DB.Repositories;
using MaternityHospital.View.Windows;
using MaternityHospital.Services;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;

namespace MaternityHospital
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<Patient> _data = new BindingList<Patient>();

        public MainWindow()
        {
            InitializeComponent();
            AppSettings.SetAppSettings();
            WindowState = WindowState.Maximized; 
            FontSize = AppSettings.CurrentFontSize;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PatientsDataGrid.Columns[2].Header = "Срок беременности\n(в неделях)";
            RefreshData();
        }

        private void createPatientButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new CreatePatientWindow();
            if(win.ShowDialog() == true)
            {
                RefreshData();
            }
        }

        void RefreshData()
        {
            _data = Patient.GetAllTableView();
            PatientsDataGrid.ItemsSource = _data;
            if (AppSettings.CurrentDoctor == "???")
            {
                var win = new ChangeDoctor();
                win.Owner = this;
                win.ShowDialog();
            }
            currentDoctor.Content = AppSettings.CurrentDoctor;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox.Text == "") RefreshData();
            else
            {
                string pattern = $"^[А-Яа-я'\\s-]*({SearchTextBox.Text.ToLower()})+[А-Яа-я\\s'-]*$";
                var filteredData = _data.Where(x => Regex.IsMatch(x.FIO.ToLower(), pattern));
                PatientsDataGrid.ItemsSource = new BindingList<Patient>(filteredData.ToList());
            }
            
        }

        private void PatientsDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ToNextWindow();
            }
        }
        void PatientsDataGrid_DoubleClick(object sender, RoutedEventArgs e)
        {
            ToNextWindow();
            
        }

        private void ToNextWindow()
        {
            AppSettings.currentPatient = new CurrentPatient((Patient)PatientsDataGrid.SelectedItem);
            new Window1().ShowDialog();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win = new ChangeDoctor();
            if (win.ShowDialog() == true)
            {
                RefreshData();
            }
        }
    }
}
