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
    /// <summary>
    /// Логика взаимодействия для MalSroki.xaml
    /// </summary>
    public partial class MalSroki : Window
    {
        public MalSroki()
        {
            InitializeComponent();
            RazMatki1.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            RazMatki3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            Yvelichina1.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            Yvelichina2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;

            SrednDiametrPlodAiza1.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            SrednDiametrPlodAiza2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            KTR1.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            KTR2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            DiamZheltMechka.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            LOvary2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            LOvary3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;

            POvary2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            POvary3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
        }
    }
}
