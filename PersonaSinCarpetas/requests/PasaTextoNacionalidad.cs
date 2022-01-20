using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaSinCarpetas.requests
{
    class PasaTextoNacionalidad : ValueChangedMessage<String> 
    {
        public PasaTextoNacionalidad(String str) : base(str) { }
    }
}
