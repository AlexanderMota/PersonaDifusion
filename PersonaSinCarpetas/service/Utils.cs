using PersonasUCCommand.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaSinCarpetas.service
{
    class Utils
    {
        public static ObservableCollection<Persona> getSamples()
            => new ObservableCollection<Persona> { 
                new Persona("Alex",26,"Venezuela"), 
                new Persona("Jose",22,"España"), 
                new Persona("Laura",22,"España") 
            };
    }
}
