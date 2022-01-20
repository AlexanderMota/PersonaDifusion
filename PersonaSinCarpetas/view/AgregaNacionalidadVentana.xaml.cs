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
using System.Windows.Shapes;

namespace PersonasUCCommand.view
{
    /// <summary>
    /// Lógica de interacción para AgregarNacionalidadVentana.xaml
    /// </summary>
    public partial class AgregaNacionalidadVentana : Window
    {
        private AgregaNacionalidadVM vm = new AgregaNacionalidadVM();
        public AgregaNacionalidadVentana()
        {
            InitializeComponent();
            this.DataContext = vm;

        }
        private void EnviaNacionalidad_Click(object sender, RoutedEventArgs e)
        {
            vm.EnviaNavionalidad(textNacionalidad.Text);
            DialogResult = false;
        }
    }
}
