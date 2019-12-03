using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IBaseDatosJugadores
    {
        IJugador nuevoJugador(string nombreJugador);

        IJugador getJugador(string nombreJugador);

        IJugador getOrCreateJugador(string nombreJugador);

        List<IJugador> getJugadores();

    }
}
