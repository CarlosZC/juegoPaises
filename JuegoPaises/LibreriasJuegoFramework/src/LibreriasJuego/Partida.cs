using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Partida:IPartida
    {

        #region Atributos 
        static Random generadorNumerosAleatorios = new Random();

        public IJugador jugador { get; }

        public IContinente continente { get; }

        public List<IPregunta> historicoPreguntas { get; }
        #endregion Atributos 

        #region métodos
        public Partida(IJugador jugador, IContinente continente)
        // El modificador INTERNAL solamente puede ser llamado desde la misma compilación (esté dentro de la misma dll)
        {
            this.jugador = jugador;
            this.continente = continente;
            this.historicoPreguntas = new List<IPregunta>();

        }
        
        public IPregunta nuevaPregunta() {

            int total = this.continente.paises.Count;
            double numeroAleatorio = Partida.generadorNumerosAleatorios.NextDouble();
            int elegido = (int)(numeroAleatorio * total);

            // Selecciona un elemento aleatorio de la lista de países
            IPais pais = this.continente.paises[elegido];

            // Creamos la pregunta, pasando el jugador y el país por parámetro
            IPregunta p = new Pregunta(this,pais);

            historicoPreguntas.Add(p);
            return p;
        }
        
        #endregion métodos
    }
}
