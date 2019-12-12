using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IPartida
    {
        IJugador jugador { get; }

        IContinente continente { get; }

        List<IPregunta> historicoPreguntas { get; }

        IPregunta nuevaPregunta();

    }
}
