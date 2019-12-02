using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface Partida
    {
        public Jugador jugador { get; }

        public Continente continente { get; }

        public List<Pregunta> historicoPreguntas { get; }

        public Pregunta nuevaPregunta();

    }
}
