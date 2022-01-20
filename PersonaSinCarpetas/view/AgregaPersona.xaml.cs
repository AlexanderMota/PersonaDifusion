using PersonasUCCommand.model;
using PersonasUCCommand.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonasUCCommand.view
{
    /// <summary>
    /// Lógica de interacción para AgregaPersona.xaml
    /// </summary>
    public partial class AgregaPersona : UserControl
    {
        AgregaPersonaVM vm =  new AgregaPersonaVM();
        public AgregaPersona()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void GuardaPersona_Click(object sender, RoutedEventArgs e) =>
            vm.GuardaPersona(new Persona(textNombre.Text, int.Parse(textEdad.Text), textCBNacionalidad.SelectedItem.ToString()));
        
    }
}
