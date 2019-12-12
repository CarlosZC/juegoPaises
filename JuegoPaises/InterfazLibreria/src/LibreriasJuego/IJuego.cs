using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public abstract class IJuego<T> where T:IJuego<T>
    {
        private static IJuego<T> instancia;

        // testigo para evitar la concurrencia 
        // readonly asegura que solamente se pueda asignar un valor una vez, a partir de esa asignación, se convierte 
        // en una constante.
        private static readonly object testigo = new object();

        public IBaseDatosJugadores baseDatosJugadores { get; protected set; }

        public IBaseDatosGeografica baseDatosGeografica { get; protected set; }



        // El modificador STATIC está asociado a nivel de la clase
        // Un método o una variable static está asociada a todos los objetos que se instancien de la clase
        // No hace falta instanciarlo porque es la misma.

            // Devuelve un IJuego
        public static IJuego<T> dameElJuego()
        {
            //Este método implementa el patrón doublelock
            // Evita la posible concurrencia en la creación de la variable static instancia 
            // Una vez que se ha creado, ya no entra en el if porque instancia ya no es null

            if (instancia == null)  
            {
                lock(testigo)
                {
                    if (instancia== null)
                    {
                        instancia = Activator.CreateInstance(typeof(T), true) as T;
                    }
                }
            }            
            return instancia;
        }    
    }
}
