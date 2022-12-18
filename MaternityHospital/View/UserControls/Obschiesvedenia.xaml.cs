using MaternityHospital.Services;
using MaternityHospital.View.Utils;
using System.Windows;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class ObschieSvedenia : UserControl
    {
        public ObschieSvedenia()
        {
            InitializeComponent();
            heartRate.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            FontSize = AppSettings.customSettings.CurrentFontSize;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dvijeniye == null || dvijeniye_Copy == null) return;
            var selectedItem = (TextBlock)dvijeniye.SelectedItem;
            if (selectedItem.Text == "нет")
            {
                dvijeniye_Copy.Visibility = Visibility.Hidden;  //не видно
            }
            else
            {
                dvijeniye_Copy.Visibility = Visibility.Visible;  //видно
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (Breath_movement == null || Breath_movement_Copy == null) return;
            var selectedItem = (TextBlock)Breath_movement.SelectedItem;
            if (selectedItem.Text == "нет")
            {
                Breath_movement_Copy.Visibility = Visibility.Hidden;  //не видно
            }
            else
            {
                Breath_movement_Copy.Visibility = Visibility.Visible;  //видно
            }
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
          Fetometria.IsSelected = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
