using System;
using System.Globalization;
using Xamarin.Forms;

namespace StudyBinding.Converter
{
    public class StringToAmountIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || string.IsNullOrEmpty((string)value))
                return 0;

            int converValue;

            if(int.TryParse(value.ToString().Replace(",",""),out converValue))
            {
                return converValue;
            }

            return value;
        }
    }
}
