using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Juego
    {
        private static Juego elJuego;

        private Juego() {

        }

        // El modificador STATIC está asociado a nivel de la clase
        // Un método o una variable static está asociada a todos los objetos que se instancien de la clase
        // No hace falta instanciarlo porque es la misma.
        public static Juego dameElJuego()
        {
            if (elJuego == null)
            {
                // llama al método privado de la clase
                // Solamente entra la primera vez que se llame a esa función
                // posteriores llamadas devuelven el bojeto creado la primera vez
                elJuego = new Juego();
            }            
            return elJuego;
        }

        public BaseDatosJugadores baseDatosJugadores { get; }

        public BaseDatosGeografica baseDatosGeografica { get; }

    }
}
