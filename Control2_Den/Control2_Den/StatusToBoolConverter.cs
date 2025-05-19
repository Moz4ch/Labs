using System;
using System.Windows.Data;
using System.Globalization;

namespace LibrarySystem.Converters
{
    public class StatusToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is BookStatus status && parameter is string expectedStatus)
            {
                return status.ToString() == expectedStatus;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}