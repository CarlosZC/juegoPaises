using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspa�a_Capital()
        {
            Juego.dameElJuego();
            BaseDatosGeografica miBaseDatosGeografica = null;
            Pais espa�a = miBaseDatosGeografica.getPais("Espa�a");

            Assert.Equals(espa�a.capital,"Madrid");
        }

        [TestMethod]
        public void TestEspa�a_Nombre()
        {
            Pais espa�a = null;

            Assert.Equals(espa�a.capital, "Espa�a");
        }

        [TestMethod]
        public void TestEspa�a_Continente()
        {
            Pais espa�a = null;
            Continente europa = null;

            Assert.Equals(espa�a.continente,europa);
        }
    }
}
