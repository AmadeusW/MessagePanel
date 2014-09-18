using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace AmadeusW.MessagePanelControl
{
    /// <summary>
    /// Converts MessageKind to a glyph in Wingdings font
    /// </summary>
    [ValueConversion(typeof(MessageKind), typeof(String))]
    public class KindToGlyphConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is MessageKind))
            {
                return " ";
            }
            switch ((MessageKind)value)
            {
                case MessageKind.Info:
                    return "w";
                case MessageKind.Fatal:
                    return "I";
                case MessageKind.Error:
                    return "û";
                case MessageKind.Warning:
                    return "Ö";
                case MessageKind.Success:
                    return "ü";
                default:
                    return " ";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
