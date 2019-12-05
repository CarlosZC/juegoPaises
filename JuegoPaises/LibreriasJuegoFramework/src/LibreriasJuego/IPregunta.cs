using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IPregunta
    {
        IPartida partida { get; }

        IPais pais { get; }

        bool acierto { get; }

        int intentosRestantes { get; }

        List<string> respuestasPropuestas { get; }       

        bool proponerRespuesta(string capitalSugerida);        

    }
}