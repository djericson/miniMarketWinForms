﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.service_1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="service_1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insertar_Usuario", ReplyAction="http://tempuri.org/IService1/Insertar_UsuarioResponse")]
        void Insertar_Usuario(Utilitarios.ClsUsuario xobj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insertar_Usuario", ReplyAction="http://tempuri.org/IService1/Insertar_UsuarioResponse")]
        System.Threading.Tasks.Task Insertar_UsuarioAsync(Utilitarios.ClsUsuario xobj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/_GetData", ReplyAction="http://tempuri.org/IService1/_GetDataResponse")]
        string _GetData(string value, string _DataRow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/_GetData", ReplyAction="http://tempuri.org/IService1/_GetDataResponse")]
        System.Threading.Tasks.Task<string> _GetDataAsync(string value, string _DataRow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        int Login(string user, string pasword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<int> LoginAsync(string user, string pasword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WCFSegurida.CompositeType GetDataUsingDataContract(WCFSegurida.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WCFSegurida.CompositeType> GetDataUsingDataContractAsync(WCFSegurida.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : App.service_1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<App.service_1.IService1>, App.service_1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public void Insertar_Usuario(Utilitarios.ClsUsuario xobj) {
            base.Channel.Insertar_Usuario(xobj);
        }
        
        public System.Threading.Tasks.Task Insertar_UsuarioAsync(Utilitarios.ClsUsuario xobj) {
            return base.Channel.Insertar_UsuarioAsync(xobj);
        }
        
        public string _GetData(string value, string _DataRow) {
            return base.Channel._GetData(value, _DataRow);
        }
        
        public System.Threading.Tasks.Task<string> _GetDataAsync(string value, string _DataRow) {
            return base.Channel._GetDataAsync(value, _DataRow);
        }
        
        public int Login(string user, string pasword) {
            return base.Channel.Login(user, pasword);
        }
        
        public System.Threading.Tasks.Task<int> LoginAsync(string user, string pasword) {
            return base.Channel.LoginAsync(user, pasword);
        }
        
        public WCFSegurida.CompositeType GetDataUsingDataContract(WCFSegurida.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WCFSegurida.CompositeType> GetDataUsingDataContractAsync(WCFSegurida.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
