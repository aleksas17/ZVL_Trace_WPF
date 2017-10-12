using System.Windows.Controls;

namespace Charts_MVVM
{
    /// <summary>
    /// Interaction logic for FileDropPage.xaml
    /// </summary>
    public partial class FileDropPage : Page
    {
        public FileDropPage()
        {
            InitializeComponent();

            this.DataContext = new FileDropPageViewModel(this);
        }
    }
}
