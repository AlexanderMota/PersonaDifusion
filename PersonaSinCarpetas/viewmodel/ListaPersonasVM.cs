using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using PersonaSinCarpetas.requests;
using PersonaSinCarpetas.service;
using PersonasUCCommand.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasUCCommand.viewmodel
{
    class ListaPersonasVM : ObservableObject
    {
        private ObservableCollection<Persona> personas;
        public ObservableCollection<Persona> Personas
        {
            get => personas;
            set => SetProperty(ref personas, value);
        }
        public ListaPersonasVM()
        {
            WeakReferenceMessenger.Default.Register<PasaPersona>(this, (r, m) =>
            { Personas.Add(m.Value); });
            this.Personas = Utils.getSamples();
        }
    }
}
