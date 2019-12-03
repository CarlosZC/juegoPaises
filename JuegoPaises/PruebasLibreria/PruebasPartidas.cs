using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPartidas
    {
        [TestMethod]
        public void TestRecuperarListaPartidas()
        {            
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");                       

            Assert.IsNotNull(ivan.historicoPartidas);
        }

        [TestMethod]
        public void TestNuevaPartida1()
        {
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");

            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);
            Assert.IsNotNull(partida);
        }

        [TestMethod]
        public void TestNuevaPartida2()
        {
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");

            int cuantasLlevaba = ivan.historicoPartidas.Count;

            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);

            int cuantasLleva = ivan.historicoPartidas.Count;

            // Comprueba si hay una partida más 
            Assert.AreEqual(cuantasLlevaba+1,cuantasLleva);

            // Comprueba si la última es la dada de alta (partida)
            Assert.AreEqual(ivan.historicoPartidas[ivan.historicoPartidas.Count-1],partida);
        }



    }
}
