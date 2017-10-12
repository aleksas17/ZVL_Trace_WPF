using System;
using System.Diagnostics;
using System.Globalization;

namespace Charts_MVVM
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropiate page
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.FileDrop:
                    return new FileDropPage();

                case ApplicationPage.ChartControl:
                    return new ChartControlPage();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
