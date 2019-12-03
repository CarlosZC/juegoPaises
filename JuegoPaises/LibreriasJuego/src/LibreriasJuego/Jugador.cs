using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Jugador:IJugador
    {
        
        public string nombre { get; }

        public List<IPartida> historicoPartidas { get; }


        internal Jugador(string nombre)
        {
            this.nombre = nombre;
            this.historicoPartidas = new List<IPartida>();
        }

        public IPartida nuevaPartida(IContinente continenteElegido) {

            Partida p = new Partida(this,continenteElegido);
            this.historicoPartidas.Add(p);
            return p;
        }
        
        

    }
}
