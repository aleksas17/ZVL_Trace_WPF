using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using System.Diagnostics;

namespace Charts_MVVM
{
    public class LineChart
    {
        /// <summary>
        /// Creating (oxyPlot) line chart with annotation
        /// </summary>
        /// <param name="chartTitle">Chart Title</param>
        /// <param name="asxisXTitle">Chart X axis Title</param>
        /// <param name="asxisYTitle">Chart Y axis Title</param>
        /// <returns>line chart modle</returns>
        public static PlotModel CreateChart(string chartTitle, string asxisXTitle, string asxisYTitle)
        {
            // Creating chart it self and its area with its style
            var ChartModel = new PlotModel
            {
                Title = chartTitle,
                IsLegendVisible = true,
                LegendOrientation = LegendOrientation.Horizontal,
                LegendPosition = LegendPosition.BottomLeft,
                LegendTextColor = OxyColor.Parse("#1e1e1e"),
                LegendPlacement = LegendPlacement.Outside,
                LegendFont = "Segeo UI Semilight",
                LegendFontSize = 11,
                LegendSymbolLength = 50,
                //DefaultColors = new IList<ListItem>({ "#117dbb", }); <-- need to fix
                PlotAreaBorderColor = OxyColor.Parse("#117dbb"),
                TitleFontWeight = FontWeights.Normal,
                TitleFont = "Segeo UI Semilight",
                TitleColor = OxyColor.Parse("#1e1e1e"),
                TitleFontSize = 26
            };

            // Creating axesisY and styling it
            var lineAxesY = new LinearAxis
            {
                Title = asxisYTitle,
                Position = AxisPosition.Left,
                TickStyle = TickStyle.None,
                MajorGridlineStyle = LineStyle.Solid,
                MajorGridlineColor = OxyColor.Parse("#d9eaf4"),
                TitleFont = "Segeo UI Semilight",
                TitleColor = OxyColor.Parse("#1e1e1e"),
                TitleFontSize = 16,
                FontWeight = FontWeights.Normal,
                Font = "Segeo UI Semilight",
                TextColor = OxyColor.Parse("#a6a6a6"),
                FontSize = 16,
                MinimumPadding = .1,
                MaximumPadding = .1
            };
            ChartModel.Axes.Add(lineAxesY);

            // Creating axesisX and styling it
            var lineAxesX = new LinearAxis
            {
                Title = asxisXTitle,
                Position = AxisPosition.Bottom,
                TickStyle = TickStyle.None,
                MajorGridlineStyle = LineStyle.Solid,
                MajorGridlineColor = OxyColor.Parse("#d9eaf4"),
                TitleFont = "Segeo UI Semilight",
                TitleColor = OxyColor.Parse("#1e1e1e"),
                TitleFontSize = 16,
                FontWeight = OxyPlot.FontWeights.Normal,
                Font = "Segeo UI Semilight",
                TextColor = OxyColor.Parse("#a6a6a6"),
                FontSize = 16,
                MinimumPadding = .1,
                MaximumPadding = .1
            };
            ChartModel.Axes.Add(lineAxesX);

            // Text annotation that shows X cordanate for line annotation
            var ta = new TextAnnotation
            {
                Background = OxyColor.Parse("#368632"),
                StrokeThickness = 0
            };



            // Annotation line
            var la = new LineAnnotation
            {
                Type = LineAnnotationType.Vertical,
                X = 0,
                Color = OxyColor.Parse("#368632")
            };
            la.MouseDown += (s, e) =>
            {
                if (e.ChangedButton != OxyMouseButton.Left)
                {
                    return;
                }

                la.StrokeThickness *= 5;
                ChartModel.InvalidatePlot(false);
                e.Handled = true;
            };

            // Handle mouse movements (note: this is only called when the mousedown event was handled)
            la.MouseMove += (s, e) =>
            {
                la.X = la.InverseTransform(e.Position).X;
                ta.TextPosition = new DataPoint(la.X, 60);
                ta.Text = la.InverseTransform(e.Position).X.ToString();
                ChartModel.InvalidatePlot(false);
                e.Handled = true;
            };
            la.MouseUp += (s, e) =>
            {
                la.StrokeThickness /= 5;
                ChartModel.InvalidatePlot(false);
                e.Handled = true;
                Debug.WriteLine(la.X);
            };
            ChartModel.Annotations.Add(la);
            ChartModel.Annotations.Add(ta);


            return ChartModel;
        }
    }
}
