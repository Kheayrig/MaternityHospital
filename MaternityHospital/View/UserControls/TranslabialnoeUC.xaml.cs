using MaternityHospital.View.Utils;
using System.Windows.Controls;

namespace MaternityHospital.View.UserControls
{
    public partial class TranslabialnoeUC : UserControl
    {
        public TranslabialnoeUC()
        {
            InitializeComponent();
            DlinaCHeKanala.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            RastoaniePD.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
            RastoanieHSD.PreviewTextInput += TextBoxFilters.FilterOnlyNumber;
        }
    }
}
