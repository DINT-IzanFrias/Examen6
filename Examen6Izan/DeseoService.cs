using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen6Izan
{
    internal class DeseoService
    {
        public static ObservableCollection<Deseo> GetSamples()
        {
            ObservableCollection<Deseo> resultado = new ObservableCollection<Deseo>();

            resultado.Add(new Deseo("película", "Todo a la vez en todas partes", "todo.jpg", 90));
            resultado.Add(new Deseo("libro", "Cicatriz", "cicatriz.jpg", 20));
            resultado.Add(new Deseo("juego", "Código secreto", "codigo.jpg", 70));
            resultado.Add(new Deseo("disco", "Gaia & friends", "gaia.jpg", 50));
            resultado.Add(new Deseo("videojuego", "Zelda: Link's awakening", "zelda.jpg", 60));

            return resultado;
        }
    }
}
