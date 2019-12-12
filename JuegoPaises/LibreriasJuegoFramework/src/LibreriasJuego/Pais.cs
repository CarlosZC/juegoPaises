using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Pais:IPais
    {
        public string nombre { get; }

        public string capital { get; }

        public IContinente continente { get; }

        public Pais (IContinente continente, string nombre, string capital)
        {
            this.continente = continente;
            this.nombre = nombre;
            this.capital = capital;
        }

    }
}
