using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen6Izan
{
    internal class Mensajes
    {
        class DeseoEliminarMessage : ValueChangedMessage<Deseo> { 
            public DeseoEliminarMessage(Deseo deseoEliminar):base(deseoEliminar)
            { 
        
            }
        }

        class DeseoMessage : RequestMessage<Deseo> {}
    }
}
