using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

        public static ObservableCollection<SourceItem> FolderItemList { get; set; }

        public PlotModel ChartModel { get; set; }

        public LineSeries ChartSeries { get; set; }

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
                ChartSeries = TextParcer.s1pParcer(_comboboxSelectedItem);
                ChartModel.Series.Add(ChartSeries);
                AddLineAnnotation();
                // Refresh chart
                ChartModel.InvalidatePlot(true);
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
            ChartSeries = new LineSeries();
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

        /// <summary>
        /// Creates annotation line (generating polarchart line) for chart 
        /// </summary>
        public void AddLineAnnotation()
        {
            // Annotation line
            var lineAnnotation = new LineAnnotation
            {
                Type = LineAnnotationType.Vertical,
                X = Convert.ToDouble(ChartSeries.Points[0].X),
                Text = ChartSeries.Points[0].Y.ToString(),
                Color = OxyColor.Parse("#368632"),
                TextOrientation = AnnotationTextOrientation.Horizontal,
                TextPadding = 5,
                TextHorizontalAlignment = OxyPlot.HorizontalAlignment.Left,
                TextMargin = 5,
                TextColor = OxyColor.Parse("#368632"),

            };

            // When mouse down on anotation line
            lineAnnotation.MouseDown += (s, e) =>
            {
                if (e.ChangedButton != OxyMouseButton.Left)
                {
                    return;
                }

                lineAnnotation.StrokeThickness *= 2;
                ChartModel.InvalidatePlot(false);
                e.Handled = true;
            };

            // Handle mouse movements (note: this is only called when the mousedown event was handled)
            lineAnnotation.MouseMove += (s, e) =>
            {
                lineAnnotation.X = lineAnnotation.InverseTransform(e.Position).X;
                lineAnnotation.Text = ChartSeries.GetNearestPoint(e.Position, true).ToString();
                //lineAnnotation.Text = lineAnnotation.InverseTransform(e.Position).X;
                //lineAnnotation.Text = ChartModel.Series[0].GetNearestPoint(e.Position, true).ToString();
                Debug.WriteLine(ChartSeries.GetNearestPoint(e.Position, true));
                ChartModel.InvalidatePlot(false);
                e.Handled = true;
            };

            // When mouse released on anotation line
            lineAnnotation.MouseUp += (s, e) =>
            {
                lineAnnotation.StrokeThickness /= 2;
                ChartModel.InvalidatePlot(false);
                e.Handled = true;
                Debug.WriteLine(lineAnnotation.X);
            };
            ChartModel.Annotations.Add(lineAnnotation);
        }

        #endregion

    }
}