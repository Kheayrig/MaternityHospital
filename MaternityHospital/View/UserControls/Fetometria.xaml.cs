using MaternityHospital.View.Utils;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class Fetometria : UserControl
    {
        public Fetometria()
        {
            InitializeComponent();
            BR.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            DBK.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            OJ.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            Mass.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
        }
    }
}
