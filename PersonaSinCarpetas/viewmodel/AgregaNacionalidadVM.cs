using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using PersonaSinCarpetas.requests;
using PersonasUCCommand.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasUCCommand.viewmodel
{
    class AgregaNacionalidadVM : ObservableObject
    {
        public AgregaNacionalidadVM() { }
        public void EnviaNavionalidad(String nacionalidad) =>
            WeakReferenceMessenger.Default.Send(new PasaTextoNacionalidad(nacionalidad));
    }
}
