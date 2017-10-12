using OxyPlot;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Charts_MVVM
{
    public class TextParcer
    {
        public static ObservableCollection<DataPoint> s1pParcer(SourceItem file)
        {
            using (StreamReader folderFile = new StreamReader(file.Fullpath))
            {
                var DataPoints = new ObservableCollection<DataPoint>();
                // Skiping first line
                var line = folderFile.ReadLine();
                // Reseter for counter .
                var counter = 0;
                var counter1 = 0;
                while ((line = folderFile.ReadLine()) != null)
                {
                    if (counter > 3)
                    {
                        // seperating line to 3 collums (3.000000000000000E5    -6.293950718827546E-5   -1.453014462304343E-4)
                        double[] traceData = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries)
                            .Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToArray();
                        // Adding data points (x, y) for chart
                        DataPoints.Add(new DataPoint(traceData[0] * Math.Pow(10, -6), 
                                                     20 * Math.Log10(Math.Sqrt((Math.Pow(traceData[1], 2) + Math.Pow(traceData[2], 2))))));
                        counter1++;
                    }
                    counter++;
                }
                return DataPoints;
            }
        }

    }
}
