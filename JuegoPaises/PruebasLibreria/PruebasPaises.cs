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
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais espa�a = miBaseDatosGeografica.getPais("Espa�a");

            Assert.Equals(espa�a.capital,"Madrid");
        }

        [TestMethod]
        public void TestEspa�a_Nombre()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais espa�a = miBaseDatosGeografica.getPais("Espa�a");

            Assert.Equals(espa�a.capital, "Espa�a");
        }

        [TestMethod]
        public void TestEspa�a_Continente()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");

            Assert.Equals(espa�a.continente,europa);
        }
    }
}
