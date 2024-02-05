using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen6Izan
{
    internal class ListadoUCVM : ObservableObject
    {
        private Deseo deseoSelecc;
        public Deseo DeseoSelecc
        {
            get { return deseoSelecc; }
            set { SetProperty(ref deseoSelecc, value); }
        }
        private ObservableCollection<Deseo> deseos;
        public ObservableCollection<Deseo> Deseos
        {
            get { return deseos; }
            set { SetProperty(ref deseos, value); }
        }

        public ListadoUCVM()
        {
            Deseos = DeseoService.GetSamples();
            WeakReferenceMessenger.Default.Register<ListadoUCVM, DeseoMessage>(this, (r, m) => { m.Reply(DeseoSelecc); });
            WeakReferenceMessenger.Default.Register<DeseoEliminarMessage>(this, (r, m) =>
            {
                Deseos.Remove(m.value);
            });
        }
    }
}
