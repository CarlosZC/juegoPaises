using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface Jugador
    {
        public string nombre { get; }

        public List<Partida> historicoPartidas { get; }

        public Partida nuevaPartida(Continente continenteElegido);




    }
}
