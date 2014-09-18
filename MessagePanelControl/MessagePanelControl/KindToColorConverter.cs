using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace AmadeusW.MessagePanelControl
{
    /// <summary>
    /// Sets the color based on supplied kind of a message.
    /// </summary>
    [ValueConversion(typeof(MessageKind), typeof(SolidColorBrush))]
    public class KindToColorConverter : IValueConverter
    {
        private static SolidColorBrush InfoBrush = new SolidColorBrush(Colors.DeepSkyBlue);
        private static SolidColorBrush FatalBrush = new SolidColorBrush(Colors.Firebrick);
        private static SolidColorBrush ErrorBrush = new SolidColorBrush(Colors.OrangeRed);
        private static SolidColorBrush WarningBrush = new SolidColorBrush(Colors.Gold);
        private static SolidColorBrush SuccessBrush = new SolidColorBrush(Colors.GreenYellow);
        private static SolidColorBrush UnknownBrush = new SolidColorBrush(Colors.Gainsboro);

        static KindToColorConverter()
        {
            InfoBrush.Freeze();
            FatalBrush.Freeze();
            ErrorBrush.Freeze();
            WarningBrush.Freeze();
            SuccessBrush.Freeze();
            UnknownBrush.Freeze();
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is MessageKind))
            {
                return UnknownBrush;
            }
            switch ((MessageKind)value)
            {
                case MessageKind.Info:
                    return InfoBrush;
                case MessageKind.Fatal:
                    return FatalBrush;
                case MessageKind.Error:
                    return ErrorBrush;
                case MessageKind.Warning:
                    return WarningBrush;
                case MessageKind.Success:
                    return SuccessBrush;
                default:
                    return UnknownBrush;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
