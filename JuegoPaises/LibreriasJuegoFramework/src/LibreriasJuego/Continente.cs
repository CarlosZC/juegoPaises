using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Continente:IContinente
    {

        private Dictionary<string, IPais> misPaises { get; }

        public string nombre { get; }

        public IList<IPais> paises { get => new List<IPais>(this.misPaises.Values).AsReadOnly();}
        // Debe devolver un tipo IList para que sea de tipo "sólo lectura"

        public Continente(string nombre)
        {
            this.nombre = nombre;            
            this.misPaises = new Dictionary<string, IPais>();
        }

        public void asignarPais(IPais nuevoPais)
        {
            this.misPaises.Add(nuevoPais.nombre, nuevoPais);
        }

        public IPais getPais(string nombrePais) {

            return misPaises[nombrePais];

        }

       



}
}