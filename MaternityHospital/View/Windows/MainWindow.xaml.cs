using MaternityHospital.DB;
using MaternityHospital.DB.Models;
using MaternityHospital.DB.Repositories;
using MaternityHospital.Services;
using MaternityHospital.View.Windows;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            WindowState = WindowState.Maximized; 
            currentDoctor.Content = Settings.GetCurrentDoctor();
            new Window1().Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshData();
            currentDoctorLabel.Margin = new Thickness(0, 0, currentDoctor.ActualWidth + 10, 0);
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
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox.Text == "") RefreshData();
            else
            {
                string pattern = $"^[А-Яа-я'\\s-]*({SearchTextBox.Text})+[А-Яа-я\\s'-]*$";
                var filteredData = _data.Where(x => Regex.IsMatch(x.FIO, pattern));
                PatientsDataGrid.ItemsSource = new BindingList<Patient>(filteredData.ToList());
            }
            
        }

        private void PatientsDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MessageBox.Show(PatientsDataGrid.SelectedItem.ToString());
            }
        }
    }
}
