using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IPais
    {
        string nombre { get; }

        string capital { get; }

        IContinente continente { get; }

    }
}
