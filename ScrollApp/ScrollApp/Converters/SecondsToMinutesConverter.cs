using System;
using System.Globalization;
using Xamarin.Forms;

namespace ScrollApp.Converters
{
    public class SecondsToMinutesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return "";
            var seconds = (int) value;
            var timespan = TimeSpan.FromSeconds(seconds);
            return timespan.ToString(@"mm\:ss");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}