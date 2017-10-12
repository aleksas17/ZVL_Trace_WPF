using System.Windows;
using System.Windows.Input;
using WinForms = System.Windows.Forms;

namespace Charts_MVVM
{
    public class WindowViewModel : BaseViewModel
    {
        #region Private Member

        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Window mWindow;

        #endregion

        #region Public Properties

        /// <summary>
        /// The smallest width the window can go to
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 400;

        /// <summary>
        /// The smallest height the window can go to
        /// </summary>
        public double WindowMinimumHeight { get; set; } = 400;

        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.ChartControl;

        #endregion

        #region Public Commands

        /// <summary>
        /// Command to select folder
        /// </summary>

        public ICommand SelectDirectory { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public WindowViewModel(Window window)
        {
            mWindow = window;

            // Create commands
            this.SelectDirectory = new RelayCommand(DirectorySelector);
        }

        #endregion

        #region Helper Metahods

        /// <summary>
        /// Pop up window for chosing folder
        /// </summary>
        public void DirectorySelector()
        {
            using (var dialog = new WinForms.FolderBrowserDialog())
            {
                WinForms.DialogResult result = dialog.ShowDialog();
                if (result == WinForms.DialogResult.OK)
                {
                    FileSourceStructure.GetFileNames(dialog.SelectedPath);
                }
            }
        }

        #endregion
    }
}
