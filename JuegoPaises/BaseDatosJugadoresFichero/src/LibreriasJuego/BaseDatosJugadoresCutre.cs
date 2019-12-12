using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class BaseDatosJugadoresCutre:IBaseDatosJugadores
    {
        private Dictionary<string, IJugador> misJugadores { get; }

        public IList<IJugador> Jugadores {get => new List<IJugador>(this.misJugadores.Values).AsReadOnly(); }

        public BaseDatosJugadoresCutre()
        {
            this.misJugadores = new Dictionary<string, IJugador>();
        }

        public IJugador nuevoJugador(string nombreJugador) {

            IJugador j = new Jugador(nombreJugador);
            this.misJugadores.Add(nombreJugador, j);
            return j;
        }

        public IJugador getJugador(string nombreJugador) {

            return misJugadores[nombreJugador];
        }

        public IJugador getOrCreateJugador(string nombreJugador) {

            if (misJugadores.ContainsKey(nombreJugador))
                return getJugador(nombreJugador);

            // Si no existe el jugador llama a la función nuevoJugador para crearlo
            return nuevoJugador(nombreJugador);
        }

    }
}
