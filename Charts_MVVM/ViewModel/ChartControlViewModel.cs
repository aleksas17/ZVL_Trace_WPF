using OxyPlot;
using OxyPlot.Wpf;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace Charts_MVVM
{
    public class ChartControlViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Page mPage;

        #endregion

        #region Public Properties

        public string ChartTitle { get; private set; } = "Trace Graph Data";

        public string SeriesTitle { get; private set; }

        public string ChartYaxisTitle { get; private set; } = "[dB]";

        public string ChartXaxisTitle { get; private set; } = "[Mhz]";

        public static ObservableCollection<DataPoint> Points { get; private set; }

        public static ObservableCollection<SourceItem> FolderItemList { get; set; }

        #endregion

        #region Public Commands


        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChartControlViewModel(Page page)
        {
            mPage = page;

            FolderItemList = new ObservableCollection<SourceItem>();

            Points = new ObservableCollection<DataPoint>()
            { new DataPoint(12, 14), new DataPoint(20, 26) };
        }

        #endregion

        #region Helper Metahods

        /// <summary>
        /// Populate combobox with folder file names
        /// </summary>
        /// <param name="list">SourceItem</param>
        public static void AddItemsToCombobox(List<SourceItem> list)
        {            
            list.ForEach(FolderItemList.Add);
        }

        public void AddNewDataPoints()
        {
            Points.Clear();
            for (int i = 0; i < 20; i++)
            {
                Points.Add(new DataPoint(10 + i, i * 10));
            }
        }


    #endregion

}
}