using MaternityHospital.Services;
using System.Security.Policy;
using System.Windows;

namespace MaternityHospital.View.Windows
{
    public partial class ReportWindow : Window
    {
        public ReportWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var test = AppSettings.WindowsList[0] as Obschiesvedenia;

            var list = AppSettings.WindowsList;
            
            if (AppSettings.isUpdating)
            {
                foreach (var item in list)
                {
                    item.Update();
                }
            }
            else
            {
                foreach (var item in list)
                {
                    item.Add();
                }
            }
            DialogResult = true;
            Close();

        }
    }
}