using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;
using System.Collections.Generic;

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

            Assert.AreEqual(europa.nombre, "Europa");
        }

        [TestMethod]
        public void TestEuropa_Paises()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");

            Assert.AreNotEqual(europa.paises.Count, 0);
        }

        [TestMethod]
        public void TestEuropa_Espa�a()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            IPais espa�a = europa.getPais("Espa�a");

            Assert.IsNotNull(espa�a);
        }

        [TestMethod]
        public void TestEuropa_Nueva_Zelanda()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            
            Assert.ThrowsException<KeyNotFoundException>(()=>europa.getPais("Nueva Zelanda"));

        /* La llamada del Assert con una funci�n lambda se podr�a cambiar por lo siguiente
         * Action funcionALaQueTengoQueLlamar = recuperarNuevaZelanda;
         * 
         * Assert.ThrowsException<KeyNotFoundException>(funcionALaQueTengoQueLlamar);
         * 
         * 
         * void recuperarNuevaZelanda() {
         * esta funci�n busca en el diccionario, hace lo que sea y finalmente lanza una excepci�n 
         * porque no existe el pa�s Nueva Zelanda en Europa
         * throw new Exception ("Nueva Zelanda no existe");
         * 
         */
        }

    }
}
