using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace AmadeusW.MessagePanelControl
{
    [ValueConversion(typeof(MessageKind), typeof(SolidColorBrush))]
    public class KindToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is MessageKind))
            {
                return new SolidColorBrush(Colors.Gainsboro);
            }
            switch ((MessageKind)value)
            {
                case MessageKind.Info:
                    return new SolidColorBrush(Colors.DeepSkyBlue);
                case MessageKind.Fatal:
                    return new SolidColorBrush(Colors.Firebrick);
                case MessageKind.Error:
                    return new SolidColorBrush(Colors.OrangeRed);
                case MessageKind.Warning:
                    return new SolidColorBrush(Colors.Goldenrod);
                case MessageKind.Success:
                    return new SolidColorBrush(Colors.GreenYellow);
                default:
                    return new SolidColorBrush(Colors.Gainsboro);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
