using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class BaseDatosGeografica: IBaseDatosGeografica
    {
        public List<IContinente> getContinentes();

        public IContinente getContinente(string nombreContinente);

        public IPais getPais(string nombrePais);

        public List<IPais> getPaises();

    }
}
