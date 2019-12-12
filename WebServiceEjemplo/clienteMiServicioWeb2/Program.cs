using System;
using clienteMiServicioWeb2.clienteMiServicioWeb;



namespace ClienteMiServicioWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Web Service World Web !!");

            MiServicioWebClient miCliente = new MiServicioWebClient();
            var respuesta = miCliente.ecoAsync("Hola");

            Mensaje m = respuesta.Result;
            Console.WriteLine(m.Exito);
            Console.WriteLine(m.Contenido);

            Console.ReadKey();
        }
    }
}
