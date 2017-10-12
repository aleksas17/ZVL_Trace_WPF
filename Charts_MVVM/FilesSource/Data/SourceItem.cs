namespace Charts_MVVM
{
    /// <summary>
    /// Infromation about Source item from directory
    /// </summary>
    public class SourceItem : BaseViewModel
    {
        /// <summary>
        /// Full path to the Item
        /// </summary>
        private string FullPath { get; set; }
        public string Fullpath
        {
            get
            {
                return FullPath;
            }
            set
            {
                FullPath = value;
                OnPropertyChanged("Fullpath");
            }
        }

        /// <summary>
        /// The name of the file
        /// </summary>
        private string Name { get; set; }
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
                OnPropertyChanged("name");
            }
        }        
    }
}
