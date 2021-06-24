using System;
using System.Collections.Generic;
using System.Text;

namespace Lista
{
    public class Cancion
    {
        public Cancion(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get; set; }
    }
}
