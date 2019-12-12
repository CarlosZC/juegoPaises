
using LibreriasJuego;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazJuego
{
    class Juego:IJuego<Juego>
    {
        private Juego()
        {
            baseDatosJugadores = new BaseDatosJugadoresCutre();
            baseDatosGeografica = new BaseDatosGeografica();
        }
    }
}
