using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface Pregunta
    {
        public bool acierto { get; }

        public int intentosRestantes { get; }

        public List<string> respuestasPropuestas { get; }

        public Partida getPartida();

        public Pais getPais();

        public bool proponerRespuesta(string capitalSugerida);        

        


    }
}