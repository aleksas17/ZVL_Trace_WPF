using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Charts_MVVM
{
    public class FileDropPageViewModel : BaseViewModel
    {
        #region Private Member

        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Page mPage;

        #endregion

        #region Public Properties

        /// <summary>
        /// The border brush thickness
        /// </summary>
        public double BorderBrushThickness { get; set; }

        /// <summary>
        /// The border brush color
        /// </summary>
        public Brush BorderBrushColor { get; set; }

        /// <summary>
        /// The grid background
        /// </summary>
        public Brush BorderBackroundColor { get; set; }

        #endregion

        #region Commands



        #endregion

        #region Methods

        /// <summary>
        /// The hover effect when file is above
        /// </summary>
        public void DragEnter()
        {
            BorderBrushThickness = 1;
            BorderBrushColor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#007acc"));
            BorderBackroundColor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#c9def5"));
        }

        /// <summary>
        /// Hover effect remover
        /// </summary>
        public void DragLeave()
        {
            BorderBrushThickness = 0;
            BorderBackroundColor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffffff"));
        }

        /// <summary>
        /// Get files directory
        /// </summary>
        public void DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null)
            {
                IDataObject ido = e.Data as IDataObject;
                if (ido != null)
                {
                    var fileDrop = ido.GetData(DataFormats.FileDrop, true);
                    var filesOrDirectories = fileDrop as String[];
                    if (filesOrDirectories != null && filesOrDirectories.Length > 0)
                    {
                        foreach (string fullPath in filesOrDirectories)
                        {
                            if (Directory.Exists(fullPath))
                            {
                                var s1pFilesDirectory = new DirectoryInfo(fullPath);
                                DragLeave();
                            }
                            else if (File.Exists(fullPath))
                            {
                                MessageBox.Show("Please drag a folder");
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public FileDropPageViewModel(Page page)
        {
            mPage = page;
        }

        #endregion
    }
}
