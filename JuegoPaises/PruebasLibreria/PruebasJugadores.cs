using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasJugadores
    {
        [TestMethod]
        public void TestAltaJugador()
        {            
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.nuevoJugador("Ivan");            

            Assert.IsNotNull(ivan);
        }

        [TestMethod]
        public void TestRecuperacionJugador()
        {
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getJugador("Ivan");

            Assert.IsNotNull(ivan);
        }

        public void TestAltaYRecuperacionJugador()
        {
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");

            Assert.IsNotNull(ivan);
        }

        public void TestNombreJugador()
        {
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");

            Assert.Equals(ivan.nombre, "Ivan");
        }
        
    }
}
