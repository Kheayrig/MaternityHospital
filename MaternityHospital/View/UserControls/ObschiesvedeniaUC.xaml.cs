using MaternityHospital.Services;
using MaternityHospital.View.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace MaternityHospital.View.UserControls
{
    public partial class ObschieSvedeniaUC : UserControl
    {
        internal static bool IsSelected = false;
        private int _index = 0;
        private bool _selected1 = false;
        private bool _selected2 = false;
        public ObschieSvedeniaUC()
        {
            InitializeComponent();
            heartRate.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
            switch (AppSettings.CurrentPatient.Trimester)
            {
                case 1:
                    _index = (int)(Trimester1Enum)Enum.Parse(typeof(Trimester1Enum), "Obschiesvedenia");
                    break;
                case 2:
                    _index = (int)(Trimester2Enum)Enum.Parse(typeof(Trimester2Enum), "Obschiesvedenia");
                    break;
                case 3:
                    _index = (int)(Trimester3Enum)Enum.Parse(typeof(Trimester3Enum), "Obschiesvedenia");
                    break;
                case 4:
                    _index = (int)(ChildBirthEnum)Enum.Parse(typeof(ChildBirthEnum), "Obschiesvedenia");
                    break;
            }
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
            SelectionChanged(sender, e);
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
            SelectionChanged(sender,e);
        }
        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = sender as ComboBox;
            var pr = typeof(Obschiesvedenia).GetProperty(item.Name);
            pr.SetValue(AppSettings.WindowsList[_index] as Obschiesvedenia, (item.SelectedValue as TextBlock).Text);
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            var item = sender as TextBox;
            var pr = typeof(Obschiesvedenia).GetProperty(item.Name);
            pr.SetValue(AppSettings.WindowsList[_index] as Obschiesvedenia, item.Text);
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
