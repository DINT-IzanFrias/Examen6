using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Examen6Izan
{
    internal class TipoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case "pelicula":
                    return "./Recursos/movies.png";
                case "libro":
                    return "./Recursos/read.png";
                case "juego":
                    return "./Recursos/board-games.png";
                case "disco":
                    return "./Recursos/listening.png";
                case "videojuegos":
                    return "./Recursos/gamepad.png";
                default:
                    return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
