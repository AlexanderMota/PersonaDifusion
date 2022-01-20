using PersonasUCCommand.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PersonasUCCommand.service
{
    class Navegacion
    {
        private static ListaPersonasUC dialogo = new ListaPersonasUC();
        public Navegacion() { }
        public AgregaNacionalidadVentana AbreVentanaAgregaNacionalidad() => new AgregaNacionalidadVentana();
        internal UserControl MuestraNuevaPersonaUC() => new AgregaPersona();
        internal UserControl MuestraListaPersonasUC() => dialogo;
    }
}
