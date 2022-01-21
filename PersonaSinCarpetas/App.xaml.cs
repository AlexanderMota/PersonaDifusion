using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PersonaEnCarpetas.Properties;
using Syncfusion.Licensing;

namespace PersonasUCCommand
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()  =>  //Register Syncfusion license
            SyncfusionLicenseProvider.RegisterLicense(Settings.Default.ClaveSyncfusion);
    }
}
