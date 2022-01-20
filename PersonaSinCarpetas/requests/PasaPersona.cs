using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using PersonasUCCommand.model;

namespace PersonaSinCarpetas.requests
{
    class PasaPersona : ValueChangedMessage<Persona> 
    {
        public PasaPersona(Persona p) : base(p) { }
    }
}
