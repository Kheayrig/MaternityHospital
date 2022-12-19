using MaternityHospital.View.Utils;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class TransperinealnoeUC : UserControl
    {
        public TransperinealnoeUC()
        {
            InitializeComponent();
            RaskrMatochnogoZeva.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            YgolMLA.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            RastoanieHPD.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
        }
    }
}
