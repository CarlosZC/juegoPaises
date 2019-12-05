using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace LibreriasJuego
{
    public class BaseDatosGeografica: IBaseDatosGeografica
    {
        private Dictionary<string, IPais> paises;
        private Dictionary<string, IContinente> continentes;

        internal BaseDatosGeografica() {

            this.paises = new Dictionary<string, IPais>();
            this.continentes = new Dictionary<string, IContinente>();

            cargarBaseDatos();
        }
        public IList<IContinente> getContinentes()
        {
            return new List<IContinente>(this.continentes.Values).AsReadOnly();
        }

        public IContinente getContinente(string nombreContinente)
        {
            return continentes[nombreContinente];
        }

        public IPais getPais(string nombrePais) {

            return paises[nombrePais];
        }



        private void cargarBaseDatos()
        {
            List<string> nombresContinentes = new List<string>();
            nombresContinentes.Add("Africa");
            nombresContinentes.Add("America");
            nombresContinentes.Add("Asia");
            nombresContinentes.Add("Europa");
            nombresContinentes.Add("Oceania");

            foreach(string nombre in nombresContinentes)
            {
                // Crear objetos de tipo continente
                Continente c = new Continente(nombre);

                // Añadir el continente al diccionario de continentes
                this.continentes.Add(nombre,c);

                // Leer ficheros por continente
                // Extraer el path, a partir de la localización del assembly (.dll)
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"continentes\" + nombre + ".txt");

                string [] lineas = File.ReadAllLines(path);

                // Crear objetos de tipo pais
                foreach (string linea in lineas)
                {
                    IPais p = procesarLineaPais(linea, c);

                    // Almacenar el país en el diccionario de países
                    if (!this.paises.ContainsKey(p.nombre))
                        this.paises.Add(p.nombre, p);

                    // Asignar el objeto país al continente creado anteriormente y que se añadió al diccionario de continentes
                    c.asignarPais(p);
                }

            }

        }

        private IPais procesarLineaPais(string linea, IContinente continente)
        {
            //Ejemplo de línea del fichero: "Egipto: El Cairo - Libra egipcia"
            string[] partes = linea.Split(":");
            string nombre =partes[0].Trim();

            partes = partes[1].Split("-");
            string capital = partes[0].Trim();

            IPais p = new Pais(continente, nombre, capital);

            return p;
        }

    }
}
