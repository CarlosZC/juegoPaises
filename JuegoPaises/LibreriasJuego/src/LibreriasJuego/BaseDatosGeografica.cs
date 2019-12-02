using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface BaseDatosGeografica
    {
        public List<Continente> getContinentes();

        public Continente getContinente(string nombreContinente);

        public Pais getPais(string nombrePais);

        public List<Pais> getPaises();

    }
}
