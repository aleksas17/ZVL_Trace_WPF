using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Charts_MVVM
{
    public class ChartControlViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Page mPage;

        /// <summary>
        /// Combobox selected item
        /// </summary>
        private SourceItem _comboboxSelectedItem;

        #endregion

        #region Public Properties

        public string ChartTitle { get; private set; } = "Trace Graph Data";

        public string SeriesTitle { get; private set; }

        public string ChartYaxisTitle { get; private set; } = "[dB]";

        public string ChartXaxisTitle { get; private set; } = "[Mhz]";

        public static ObservableCollection<SourceItem> FolderItemList { get; set; }

        public PlotModel ChartModel { get; set; }

        #endregion

        #region Public Commands

        public SourceItem ComboboxSelectedItem
        {
            get { return _comboboxSelectedItem; }
            set
            {
                _comboboxSelectedItem = value;
                // Clearing chart series
                ChartModel.Series.Clear();
                // Get data points from .s1p file, that we selected and apply it
                ChartModel.Series.Add(TextParcer.s1pParcer(_comboboxSelectedItem));
                // Refresh chart
                ChartModel.InvalidatePlot(true);
                ChartModel.Series[0].MouseDown += (s, e) =>
                {
                    ChartModel.Subtitle = "Y value of nearest point in LineSeries: " +
                        Math.Round(e.HitTestResult.NearestHitPoint.Y);
                    ChartModel.InvalidatePlot(false);
                };
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChartControlViewModel(Page page)
        {
            mPage = page;

            ChartModel = new PlotModel();
            ChartModel = LineChart.CreateChart("Trace Graph Data", "[Mhz]", "[dB]");
            FolderItemList = new ObservableCollection<SourceItem>();
            
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

        #endregion

    }
}