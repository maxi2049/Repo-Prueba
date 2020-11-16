using System;
using System.Collections.Generic;
using System.Text;

namespace BilleteraClip
{
    class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Persona()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            return apellido + ", " + nombre;
        }
    }
}
