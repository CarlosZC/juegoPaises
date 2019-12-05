using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspaña_Capital()
        {            
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais españa = miBaseDatosGeografica.getPais("España");

            Assert.AreEqual(españa.capital,"Madrid");
        }

        [TestMethod]
        public void TestEspaña_Nombre()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais españa = miBaseDatosGeografica.getPais("España");

            Assert.AreEqual(españa.nombre, "España");
        }

        [TestMethod]
        public void TestEspaña_Continente()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais españa = miBaseDatosGeografica.getPais("España");
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");

            Assert.AreEqual(españa.continente,europa);
        }
    }
}
