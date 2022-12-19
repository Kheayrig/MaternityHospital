using MaternityHospital.DB.Models;
using MaternityHospital.DB.Repositories;
using MaternityHospital.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
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
    /// Логика взаимодействия для ChangeDoctor.xaml
    /// </summary>
    public partial class ChangeDoctor : Window
    {
        private BindingList<Doctor> _data = new BindingList<Doctor>();
        public ChangeDoctor()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AddBtn.Width += 10;
            RefreshData();
        }
        void RefreshData()
        {
            _data = Doctor.GetAllTableView();
            DoctorsDataGrid.ItemsSource = _data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win = new AddDoctor();
            if (win.ShowDialog() == true)
            {
                RefreshData();
            }
        }
        private void PatientsDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var doctor = (Doctor)DoctorsDataGrid.SelectedItem;
                AppSettings.CustomSettings.CurrentDoctor = doctor.FIO;
                Close();
            }
        }
        void PatientsDataGrid_DoubleClick(object sender, RoutedEventArgs e)
        {
            var doctor = (Doctor)DoctorsDataGrid.SelectedItem;
            AppSettings.CustomSettings.CurrentDoctor = doctor.FIO;
            DialogResult = true;
            Close();
        }

        private void DeleteDoctor(object sender, RoutedEventArgs e)
        {
            var doctor = (Doctor)DoctorsDataGrid.SelectedItem;
            doctor.Delete();
            RefreshData();
        }

        private void Close(object sender, CancelEventArgs e)
        {
            if (AppSettings.CustomSettings.CurrentDoctor == "???")
            {
                e.Cancel = true;
                MessageBox.Show("Вам нужно выбрать или добавить врача, чтобы продолжить.");
            }
        }
    }
}
