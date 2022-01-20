using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasUCCommand.model
{
    class Persona
    {
        private String nombre;
        public String Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        private int edad;
        public int Edad
        {
            get => edad;
            set => edad = value;
        }
        private String nacionalidad;
        public String Nacionalidad
        {
            get => nacionalidad;
            set => nacionalidad = value;
        }
        public Persona() { }
        public Persona(String nombre, int edad, String nac) 
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacionalidad = nac;
        }
    }
}
