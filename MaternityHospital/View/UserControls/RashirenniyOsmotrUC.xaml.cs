using MaternityHospital.Services;
using MaternityHospital.View.extra;
using MaternityHospital.View.Utils;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class RashirenniyOsmotrUC : UserControl
    {
        private int _index;
        public RashirenniyOsmotrUC()
        {
            InitializeComponent();
            vish.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
            switch (AppSettings.CurrentPatient.Trimester)
            {
                case 1:
                    _index = (int)(Trimester1Enum)Enum.Parse(typeof(Trimester1Enum), "RasshirennOsmotr");
                    break;
                case 2:
                    _index = (int)(Trimester2Enum)Enum.Parse(typeof(Trimester2Enum), "RasshirennOsmotr");
                    break;
                case 3:
                    _index = (int)(Trimester3Enum)Enum.Parse(typeof(Trimester3Enum), "RasshirennOsmotr");
                    break;
                case 4:
                    _index = (int)(ChildBirthEnum)Enum.Parse(typeof(ChildBirthEnum), "RasshirennOsmotr");
                    break;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var l = (RasshirennOsmotr)AppSettings.WindowsList[_index];
            SetValues(l);
        }

        private void SetValues(RasshirennOsmotr item)
        {
            //костыль
            for(int i = 0; i < placenta.Items.Count; i++)
            {
                if ((placenta.Items[i] as TextBlock).Text == item.placenta )
                {
                    placenta.SelectedIndex = i;
                    break;
                }
            }
            PPoverxnost.SelectedItem = PPoverxnost.FindName(item.PPoverxnost);
            for (int i = 0; i < stryctyra.Items.Count; i++)
            {
                if ((stryctyra.Items[i] as TextBlock).Text == item.stryctyra)
                {
                    stryctyra.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < StepenZrelosti.Items.Count; i++)
            {
                if ((StepenZrelosti.Items[i] as TextBlock).Text == item.StepenZrelosti)
                {
                    StepenZrelosti.SelectedIndex = i;
                    break;
                }
            }
            kolVod.SelectedItem = kolVod.FindName(item.kolVod);
            vish.Text = item.vish;
        }

        private void Cns(object sender, RoutedEventArgs e)
        {
            new CnsFaceNeckWindow().ShowDialog();
        }

        private void Heart(object sender, RoutedEventArgs e)
        {
            new HeartLargeonesVesselsWindow().Show();
        }

        private void Chest(object sender, RoutedEventArgs e)
        {
            new ChestCavityWindow().Show();
        }

        private void Skelet(object sender, RoutedEventArgs e)
        {
            new SkeletWindow().Show();
        }

        private void Abdominal(object sender, RoutedEventArgs e)
        {
            new AbdominalCavityWindow().Show();
        }

        private void Pypovina(object sender, RoutedEventArgs e)
        {
            new pypovinaWindow().Show();
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            var item = sender as TextBox;
            var pr = typeof(RasshirennOsmotr).GetProperty(item.Name);
            pr.SetValue(AppSettings.WindowsList[_index] as RasshirennOsmotr, item.Text);
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsLoaded) return;
            var item = sender as ComboBox;
            var pr = typeof(RasshirennOsmotr).GetProperty(item.Name);
            var i = item.SelectedValue as TextBlock;
            if(i==null) return;
            pr.SetValue(AppSettings.WindowsList[_index] as RasshirennOsmotr, i.Text);
        }
    }
}
