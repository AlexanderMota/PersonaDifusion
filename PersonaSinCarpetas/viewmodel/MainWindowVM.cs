using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using PersonasUCCommand.model;
using PersonasUCCommand.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PersonasUCCommand.viewmodel
{
    class MainWindowVM : ObservableObject
    {
        //Propiedades
        private UserControl uc;
        public UserControl UsControl
        {
            get => uc;
            set => SetProperty(ref uc, value);
        }

        //Servicios y comandos
        private Navegacion nav;
        public RelayCommand UCListaPersonasCommand { get; }
        public RelayCommand UCNuevaPersonaCommand { get; }

        //Constructores
        public MainWindowVM()
        {
            this.nav = new Navegacion();
            this.UCListaPersonasCommand = new RelayCommand(MuestraUCListaPersonas);
            this.UCNuevaPersonaCommand = new RelayCommand(MuestraUCNuevaPersona);
        }

        //Métodos privados
        private void MuestraUCListaPersonas() => this.UsControl = nav.MuestraListaPersonasUC();

        private void MuestraUCNuevaPersona() => this.UsControl = nav.MuestraNuevaPersonaUC();

        //Métodos publicos
    }
}
