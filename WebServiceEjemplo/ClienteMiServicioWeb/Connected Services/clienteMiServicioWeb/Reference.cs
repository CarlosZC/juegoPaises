//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace clienteMiServicioWeb
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="clienteMiServicioWeb.IMiServicioWeb")]
    public interface IMiServicioWeb
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMiServicioWeb/eco", ReplyAction="http://tempuri.org/IMiServicioWeb/ecoResponse")]
        System.Threading.Tasks.Task<string> ecoAsync(string mensaje);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IMiServicioWebChannel : clienteMiServicioWeb.IMiServicioWeb, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class MiServicioWebClient : System.ServiceModel.ClientBase<clienteMiServicioWeb.IMiServicioWeb>, clienteMiServicioWeb.IMiServicioWeb
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MiServicioWebClient() : 
                base(MiServicioWebClient.GetDefaultBinding(), MiServicioWebClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMiServicioWeb.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MiServicioWebClient(EndpointConfiguration endpointConfiguration) : 
                base(MiServicioWebClient.GetBindingForEndpoint(endpointConfiguration), MiServicioWebClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MiServicioWebClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MiServicioWebClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MiServicioWebClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MiServicioWebClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MiServicioWebClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> ecoAsync(string mensaje)
        {
            return base.Channel.ecoAsync(mensaje);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMiServicioWeb))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMiServicioWeb))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:2241/MiServicioWeb.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MiServicioWebClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMiServicioWeb);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MiServicioWebClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMiServicioWeb);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMiServicioWeb,
        }
    }
}
