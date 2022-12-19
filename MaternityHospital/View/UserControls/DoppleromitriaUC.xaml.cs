using MaternityHospital.View.Utils;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class DoppleromitriaUC : UserControl
    {
        private int _index;
        public DoppleromitriaUC()
        {
            InitializeComponent();
            ArterPypoviny1.PreviewTextInput += TextBoxFilters.FilterOnlyDoubleNumber;
            ArterPypoviny2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            ArterPypoviny3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            CMozg1.PreviewTextInput += TextBoxFilters.FilterOnlyDoubleNumber;
            CMozg2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            CMozg3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            MCA1.PreviewTextInput += TextBoxFilters.FilterOnlyDoubleNumber;
            MCA2.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            MCA3.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            DiagKonyga.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
        }
    }
}
