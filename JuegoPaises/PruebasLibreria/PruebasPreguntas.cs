using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPreguntas
    {
        [TestMethod]
        public void TestNuevaPregunta() { 
            
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");

            int cuantasLlevaba = ivan.historicoPartidas.Count;

            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);

            // Creamos una pregunta
            IPregunta pregunta = partida.nuevaPregunta();

            Assert.IsNotNull(pregunta);
            Assert.IsNotNull(pregunta.pais);
           
        }

        [TestMethod]
        public void TestRespuestaFallida()
        {

            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");

            int cuantasLlevaba = ivan.historicoPartidas.Count;

            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);

            // Creamos una pregunta
            IPregunta pregunta = partida.nuevaPregunta();

            // Propongo una respuesta err�nea
            bool resultado = pregunta.proponerRespuesta("Ruina");

            Assert.IsFalse(resultado);            
        }

        [TestMethod]
        public void TestRespuestasFallidaMultiples()
        {

            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");

            int cuantasLlevaba = ivan.historicoPartidas.Count;

            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);

            // Creamos una pregunta
            IPregunta pregunta = partida.nuevaPregunta();

            int intentos = pregunta.intentosRestantes;
            // Se comprueba si los intentos iniciales son 3
            Assert.AreEqual(intentos, 3);

            // Propongo 3 veces una respuesta err�nea
            pregunta.proponerRespuesta("Ruina");
            pregunta.proponerRespuesta("Ruina");
            pregunta.proponerRespuesta("Ruina");

            // Deben quedar cero intentos
            intentos = pregunta.intentosRestantes;
            Assert.AreEqual(intentos, 0);

            // Intenta dar una respuesta m�s all� del l�mite
            // pregunta.proponerRespuesta("Ruina");

            // Debe devolver una excepci�n

        }

        [TestMethod]
        public void TestRespuestaCorrecta()
        {

            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");

            int cuantasLlevaba = ivan.historicoPartidas.Count;

            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);

            // Creamos una pregunta
            IPregunta pregunta = partida.nuevaPregunta();

            // Propongo una respuesta correcta
            bool resultado = pregunta.proponerRespuesta(pregunta.pais.capital);

            Assert.IsTrue(resultado);
        }

    }
}
