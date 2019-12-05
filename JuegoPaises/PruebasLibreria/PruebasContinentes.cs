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
            
            Assert.ThrowsException<KeyNotFoundException>(()=>europa.getPais("Nueva Zelanda"));

        /* La llamada del Assert con una función lambda se podría cambiar por lo siguiente
         * Action funcionALaQueTengoQueLlamar = recuperarNuevaZelanda;
         * 
         * Assert.ThrowsException<KeyNotFoundException>(funcionALaQueTengoQueLlamar);
         * 
         * 
         * void recuperarNuevaZelanda() {
         * esta función busca en el diccionario, hace lo que sea y finalmente lanza una excepción 
         * porque no existe el país Nueva Zelanda en Europa
         * throw new Exception ("Nueva Zelanda no existe");
         * 
         */
        }

    }
}
