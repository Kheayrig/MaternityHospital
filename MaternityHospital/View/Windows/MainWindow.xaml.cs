using MaternityHospital.DB;
using MaternityHospital.DB.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaternityHospital
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<Patient> _data;

        public MainWindow()
        {
            InitializeComponent();
            new Window1().Show();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using(var db = new ApplicationContext())
            {
                _data = new BindingList<Patient>();
                // загружаем данные из БД
                db.Database.EnsureCreated();
                _data = Patients.GetAllTableView();
                db.Patients.Load();
                _data = db.Patients.Local.ToBindingList();
                PatientsDataGrid.ItemsSource = _data;
            }
            

        }
    }
}
