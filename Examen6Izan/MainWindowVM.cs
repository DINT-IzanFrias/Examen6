using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Examen6Izan
{
    internal class MainWindowVM : ObservableObject
    {
        public RelayCommand InicioCommand { get; }
        public RelayCommand AbrirListadoCommand { get; }
        private UserControl contenidoVista;
        public UserControl ContenidoVista
        {
            get { return contenidoVista; }
            set { SetProperty(ref contenidoVista, value); }
        }


        public MainWindowVM() {
            ContenidoVista = new UserControl();
            servicioUserControl = new NavegacionService();
            ContenidoVista = servicioUserControl.InicioUserControl();
            InicioCommand = new RelayCommand(Inicio);
            AbrirListadoCommand = new RelayCommand(AbrirListado);
        }

        private void Inicio()
        {
            ContenidoVista = servicioUserControl.InicioUserControl();
        }

        private void AbrirListado()
        {
            ContenidoVista = servicioUserControl.ListaUserControl();
        }
    }
}
