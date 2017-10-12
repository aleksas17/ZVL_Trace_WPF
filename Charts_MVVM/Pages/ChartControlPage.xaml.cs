using System.Windows.Controls;

namespace Charts_MVVM
{
    /// <summary>
    /// Interaction logic for ChartControlPage.xaml
    /// </summary>
    public partial class ChartControlPage : Page
    {
        public ChartControlPage()
        {
            InitializeComponent();

            this.DataContext = new ChartControlViewModel(this);
        }
    }
}
