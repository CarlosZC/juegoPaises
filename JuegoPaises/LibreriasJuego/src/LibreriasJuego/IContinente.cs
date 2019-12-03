using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IContinente
    {

        string nombre { get; }
  
        List<IPais> paises { get; }

        IPais getPais(string nombrePais);



}
}