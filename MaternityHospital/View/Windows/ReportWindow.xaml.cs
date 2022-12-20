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
                AppSettings.CurrentVisit.Update();
            }
            else
            {
                AppSettings.CurrentVisit.Add();
                AppSettings.CurrentVisit.GetBy(AppSettings.CurrentPatient.Id);
                foreach (var item in list)
                {
                    item.ChangeProperty("VisitId", AppSettings.CurrentVisit.Id);
                    item.Add();
                }
            }
            DialogResult = true;
            AppSettings.isUpdating = false;
            AppSettings.WindowsList.Clear();
            Close();

        }
    }
}