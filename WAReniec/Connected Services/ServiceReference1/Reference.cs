//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WAReniec.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WSReniecSoap")]
    public interface WSReniecSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Buscar(string Ingrese_dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string Ingrese_dni);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSReniecSoapChannel : WAReniec.ServiceReference1.WSReniecSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSReniecSoapClient : System.ServiceModel.ClientBase<WAReniec.ServiceReference1.WSReniecSoap>, WAReniec.ServiceReference1.WSReniecSoap {
        
        public WSReniecSoapClient() {
        }
        
        public WSReniecSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSReniecSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSReniecSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSReniecSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Buscar(string Ingrese_dni) {
            return base.Channel.Buscar(Ingrese_dni);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string Ingrese_dni) {
            return base.Channel.BuscarAsync(Ingrese_dni);
        }
    }
}
