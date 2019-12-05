using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IContinente
    {

        string nombre { get; }
  
        IList<IPais> paises { get; }

        IPais getPais(string nombrePais);



}
}