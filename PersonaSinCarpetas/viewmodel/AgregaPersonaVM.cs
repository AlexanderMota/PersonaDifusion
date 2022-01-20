using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using PersonaSinCarpetas.requests;
using PersonasUCCommand.model;
using PersonasUCCommand.service;
using PersonasUCCommand.view;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PersonasUCCommand.viewmodel
{
    class AgregaPersonaVM : ObservableRecipient
    {
        private ObservableCollection<String> nacs;
        public ObservableCollection<String> Nacionalidades
        {
            get => nacs;
            set => SetProperty(ref nacs, value);
        }
        private readonly Navegacion nav;
        public RelayCommand UserControlNacionalidadCommand { get; }
        public AgregaPersonaVM()
        {
            WeakReferenceMessenger.Default.Register<PasaTextoNacionalidad>(this, (r, m) =>
            { Nacionalidades.Add(m.Value); });

            this.nav = new Navegacion();
            this.Nacionalidades = new ObservableCollection<String>{ "R. Dominicana","Venezuela","España"};
            this.UserControlNacionalidadCommand = new RelayCommand(AbreVentanaAgregaNacionalidad);
        }
        private void AbreVentanaAgregaNacionalidad() =>
            nav.AbreVentanaAgregaNacionalidad().ShowDialog();
        public void GuardaPersona(Persona persona) =>
            WeakReferenceMessenger.Default.Send(new PasaPersona(persona));
    }
}
