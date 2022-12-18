using MaternityHospital.View.Utils;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class Transperinealnoe : UserControl
    {
        public Transperinealnoe()
        {
            InitializeComponent();
            RaskrMatochnogoZeva.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            YgolMLA.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            RastoanieHPD.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
        }
    }
}
