using MaternityHospital.Services;
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
            MessageBox.Show(test.position);
            MessageBox.Show(test.plod);
            MessageBox.Show(test.predlejanie);

            /*var list = AppSettings.WindowsList;
            foreach(var item in list)
            {
                item.SendToDB();
            }*/
        }
    }
}