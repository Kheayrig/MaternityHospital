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

namespace MaternityHospital.View
{
    /// <summary>
    /// Логика взаимодействия для dopplerometria.xaml
    /// </summary>
    public partial class dopplerometria : Window
    {
        public dopplerometria()
        {
            InitializeComponent();
            ArterPypoviny1.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            ArterPypoviny2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            ArterPypoviny3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            CMozg1.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            CMozg2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            CMozg3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            MCA1.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            MCA2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            MCA3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            DiagKonyga.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;



        }
    }
}
