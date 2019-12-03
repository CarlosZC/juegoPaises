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

            Assert.Equals(españa.capital,"Madrid");
        }

        [TestMethod]
        public void TestEspaña_Nombre()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais españa = miBaseDatosGeografica.getPais("España");

            Assert.Equals(españa.capital, "España");
        }

        [TestMethod]
        public void TestEspaña_Continente()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais españa = miBaseDatosGeografica.getPais("España");
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");

            Assert.Equals(españa.continente,europa);
        }
    }
}
