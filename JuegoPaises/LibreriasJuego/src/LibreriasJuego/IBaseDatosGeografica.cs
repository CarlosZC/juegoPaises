using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IBaseDatosGeografica
    {
        List<IContinente> getContinentes();

        IContinente getContinente(string nombreContinente);

        IPais getPais(string nombrePais);

        List<IPais> getPaises();

    }
}
