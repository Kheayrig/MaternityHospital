using MaternityHospital.DB.Models.ViewClasses;
using MaternityHospital.Services;
using MaternityHospital.View.Utils;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MaternityHospital.View.UserControls
{
    public partial class MalSrokiUC : UserControl
    {
        private int _index = 0;
        public MalSrokiUC()
        {
            InitializeComponent();
            RazMatki1.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            Yvelichina1.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;

            SrednDiametrPlodAiza1.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            SrednDiametrPlodAiza2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            KTR1.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            KTR2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            DiamZheltMechka.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            LOvary3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;

            POvary3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
            switch (AppSettings.CurrentPatient.Trimester)
            {
                case 1:
                    _index = (int)(Trimester1Enum)Enum.Parse(typeof(Trimester1Enum), "MalSroki");
                    break;
                case 2:
                    _index = (int)(Trimester2Enum)Enum.Parse(typeof(Trimester2Enum), "MalSroki");
                    break;
                case 3:
                    _index = (int)(Trimester3Enum)Enum.Parse(typeof(Trimester3Enum), "MalSroki");
                    break;
                case 4:
                    _index = (int)(ChildBirthEnum)Enum.Parse(typeof(ChildBirthEnum), "MalSroki");
                    break;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var l = (MalSroki)AppSettings.WindowsList[_index];
            SetValues(l);
        }

        private void SetValues(MalSroki item)
        {
            //костыль
            RazMatki1.Text = item.RazMatki1;
            RazMatki2.SelectedItem = RazMatki2.FindName(item.RazMatki2);
            Yvelichina1.Text = item.Yvelichina1;
            for (int i = 0; i < FormaMatki.Items.Count; i++)
            {
                if ((FormaMatki.Items[i] as TextBlock).Text == item.FormaMatki)
                {
                    FormaMatki.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < echostructure1.Items.Count; i++)
            {
                if ((echostructure1.Items[i] as TextBlock).Text == item.echostructure1)
                {
                    echostructure1.SelectedIndex = i;
                    break;
                }
            }
            SrednDiametrPlodAiza1.Text = item.SrednDiametrPlodAiza1;
            KTR1.Text = item.KTR1;
            DiamZheltMechka.Text = item.DiamZheltMechka;
            Serdchbienie.SelectedItem = Serdchbienie.FindName(item.Serdchbienie);
            
            for (int i = 0; i < LOvary1.Items.Count; i++)
            {
                if ((LOvary1.Items[i] as TextBlock).Text == item.LOvary1)
                {
                    LOvary1.SelectedIndex = i;
                    break;
                }
            }
            LOvary3.Text = item.LOvary3;

            for (int i = 0; i < LOvary4.Items.Count; i++)
            {
                if ((LOvary4.Items[i] as TextBlock).Text == item.LOvary4)
                {
                    LOvary4.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < POvary1.Items.Count; i++)
            {
                if ((POvary1.Items[i] as TextBlock).Text == item.POvary1)
                {
                    POvary1.SelectedIndex = i;
                    break;
                }
            }
            POvary3.Text = item.POvary3;
            for (int i = 0; i < POvary4.Items.Count; i++)
            {
                if ((POvary4.Items[i] as TextBlock).Text == item.POvary4)
                {
                    POvary4.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < Xirion.Items.Count; i++)
            {
                if ((Xirion.Items[i] as TextBlock).Text == item.Xirion)
                {
                    Xirion.SelectedIndex = i;
                    break;
                }
            }
            DopDann.Text = item.DopDann;
        }
        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsLoaded) return;
            var item = sender as ComboBox;
            if(item.SelectedValue == null) return;
            var pr = typeof(MalSroki).GetProperty(item.Name);
            pr.SetValue(AppSettings.WindowsList[_index] as MalSroki, (item.SelectedValue as TextBlock).Text);
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            var item = sender as TextBox;
            var pr = typeof(MalSroki).GetProperty(item.Name);
            if(item.Name == "DopDann") pr.SetValue(AppSettings.WindowsList[_index] as MalSroki, item.Text);
            else pr.SetValue(AppSettings.WindowsList[_index] as MalSroki, (item.Text));
        }
    }
}
