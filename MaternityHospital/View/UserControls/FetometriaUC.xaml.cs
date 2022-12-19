using MaternityHospital.Services;
using MaternityHospital.View.Utils;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class FetometriaUC : UserControl
    {
        private int _index = 1;
        public FetometriaUC()
        {
            InitializeComponent();
            BR.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            DBK.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            OJ.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            Mass.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
        }

        private void CancelFet_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        //  new ObschieSvedenia().Show();
        }

        private void OKFet_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
