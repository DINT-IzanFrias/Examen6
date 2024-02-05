using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Examen6Izan
{
    /// <summary>
    /// Lógica de interacción para DialogoEliminar.xaml
    /// </summary>
    public partial class DialogoEliminar : Window
    {
        DialogoEliminarVM vm;
        public DialogoEliminar()
        {
            InitializeComponent();
            vm = new DialogoEliminarVM();
            this.DataContext = vm;
        }

        private void Eliminar(object sender, MouseButtonEventArgs e)
        {
         
            vm.Eliminar();
            this.DialogResult = null;
        }
    }
}
