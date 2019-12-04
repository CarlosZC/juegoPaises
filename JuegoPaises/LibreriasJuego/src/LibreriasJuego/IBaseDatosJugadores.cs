using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IBaseDatosJugadores
    {
        IList<IJugador> Jugadores { get; }

        IJugador nuevoJugador(string nombreJugador);

        IJugador getJugador(string nombreJugador);

        IJugador getOrCreateJugador(string nombreJugador);        

    }
}
