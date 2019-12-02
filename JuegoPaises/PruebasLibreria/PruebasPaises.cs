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
            Juego.dameElJuego();
            BaseDatosGeografica miBaseDatosGeografica = null;
            Pais españa = miBaseDatosGeografica.getPais("España");

            Assert.Equals(españa.capital,"Madrid");
        }

        [TestMethod]
        public void TestEspaña_Nombre()
        {
            Pais españa = null;

            Assert.Equals(españa.capital, "España");
        }

        [TestMethod]
        public void TestEspaña_Continente()
        {
            Pais españa = null;
            Continente europa = null;

            Assert.Equals(españa.continente,europa);
        }
    }
}
