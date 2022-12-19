using MaternityHospital.Services;
using MaternityHospital.View.Utils;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class Fetometria : UserControl
    {
        internal static bool IsSelected= false;

        public Fetometria()
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
