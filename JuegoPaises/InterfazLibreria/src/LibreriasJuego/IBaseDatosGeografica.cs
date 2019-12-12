using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IBaseDatosGeografica
    {
        IList<IContinente> getContinentes();

        IContinente getContinente(string nombreContinente);

        IPais getPais(string nombrePais);

    }
}
