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
                FontWeight = FontWeights.Normal,
                Font = "Segeo UI Semilight",
                TextColor = OxyColor.Parse("#a6a6a6"),
                FontSize = 16,
                MinimumPadding = .1,
                MaximumPadding = .1
            };
            ChartModel.Axes.Add(lineAxesX);

            
            return ChartModel;
        }
    }
}
