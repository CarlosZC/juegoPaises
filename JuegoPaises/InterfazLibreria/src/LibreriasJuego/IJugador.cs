using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IJugador
    {
        string nombre { get; }

        List<IPartida> historicoPartidas { get; }

        IPartida nuevaPartida(IContinente continenteElegido);




    }
}
