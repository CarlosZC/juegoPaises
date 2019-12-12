using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServiceEjemplo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMiServicioWeb
    {

        [OperationContract]
        Mensaje eco(string mensaje);

    }

}
    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Mensaje
    {

    public Mensaje()
    {

    }

    public Mensaje(string contenido)
    {
        this.Contenido = contenido;
        this.Exito = true;
    }

    public Mensaje(bool exito)
    {
        this.Contenido = "";
        this.Exito = true;
    }

    [DataMember]
       public bool Exito { get; set; }

        [DataMember]
       public string Contenido { get; set; }
}
