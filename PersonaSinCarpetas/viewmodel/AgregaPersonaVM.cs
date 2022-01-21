using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using PersonaEnCarpetas.Properties;
using PersonaSinCarpetas.requests;
using PersonaSinCarpetas.service;
using PersonasUCCommand.model;
using PersonasUCCommand.service;
using PersonasUCCommand.view;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PersonasUCCommand.viewmodel
{
    class AgregaPersonaVM : ObservableObject
    {
        //Propiedades
        private String nombre;
        public String Nombre
        {
            get => this.nombre;
            set => SetProperty(ref nombre, value);
        }
        private int edad;
        public int Edad
        {
            get => this.edad;
            set => SetProperty(ref edad, value);
        }
        private String nacionalidad;
        public String Nacionalidad
        {
            get => this.nacionalidad;
            set => SetProperty(ref nacionalidad, value);
        }
        private ObservableCollection<String> nacs = new ObservableCollection<String>();
        public ObservableCollection<String> Nacionalidades
        {
            get => nacs;
            set => SetProperty(ref nacs, value);
        }

        //Servicios y comandos
        private readonly Navegacion nav;
        public RelayCommand UserControlNacionalidadCommand { get; }
        public RelayCommand AceptarPersonadCommand { get; }

        //Constructores
        public AgregaPersonaVM()
        {
            foreach (String s in Settings.Default.SamplesNacionalidades) this.Nacionalidades.Add(s);
            WeakReferenceMessenger.Default.Register<PasaTextoNacionalidad>(this, (r, m) =>
            { Nacionalidades.Add(m.Value); });

            this.nav = new Navegacion();
            this.UserControlNacionalidadCommand = new RelayCommand(AbreVentanaAgregaNacionalidad);
            this.AceptarPersonadCommand = new RelayCommand(AceptarPersonad_click);
        }

        //Métodos privados
        private void AceptarPersonad_click()=>
            WeakReferenceMessenger.Default.Send(
                new PasaPersona(
                    new Persona(Nombre,Edad,Nacionalidad)));

        private void AbreVentanaAgregaNacionalidad() =>
            nav.AbreVentanaAgregaNacionalidad().ShowDialog();

        //Métodos publicos
        public void GuardaPersona(Persona persona) =>
            WeakReferenceMessenger.Default.Send(new PasaPersona(persona));
    }
}
