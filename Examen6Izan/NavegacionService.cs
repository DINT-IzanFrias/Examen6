using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Examen6Izan
{
    internal class NavegacionService
    {
        public static UserControl Listado = new ListadoUc();

        public UserControl InicioUserControl()
        {
            return new InicioUC();
        }

        public UserControl ListadoUserControl()
        {
            return new ListadoUc();
        }
        public UserControl AbrirDialogoEliminar()
        {
            AbrirDialogoEliminar d = new AbrirDialogoEliminar();
            return d.ShowDialog();
        }
    }
}
