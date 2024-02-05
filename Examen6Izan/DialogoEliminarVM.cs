using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen6Izan
{
    
    internal class DialogoEliminarVM : ObservableObject
    {
        private Deseo d;

        public Deseo D { get { return d; }
            set { SetProperty(ref d, value); }
        }
        public DialogoEliminarVM()
        {
            WeakReferenceMessenger.Default.Register<DeseoEliminarMessage>(this, (r, m) =>
            {
                Deseos=(m.value);
            });
        }

        public void Eliminar()
        {
            WeakReferenceMessenger.Default.Send(new DeseoEliminarMessagge(Deseo));
        }
    }
}
