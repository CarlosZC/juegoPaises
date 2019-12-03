using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasContinentes

    {        
        [TestMethod]
        public void TestEuropa_Nombre()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");

            Assert.Equals(europa.nombre, "Europa");
        }

        [TestMethod]
        public void TestEuropa_Paises()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");

            Assert.AreNotEqual(europa.paises.Count, 0);
        }

        [TestMethod]
        public void TestEuropa_España()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            IPais españa = europa.getPais("España");

            Assert.IsNotNull(españa);
        }

        [TestMethod]
        public void TestEuropa_Nueva_Zelanda()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            IPais nuevaZelanda = europa.getPais("Nueva Zelanda");

            Assert.IsNull(nuevaZelanda);
        }

    }
}
