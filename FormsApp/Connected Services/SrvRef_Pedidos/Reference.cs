﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormsApp.SrvRef_Pedidos {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:8733/WcfService/Service_Pedidos", ConfigurationName="SrvRef_Pedidos.IService_Pedidos")]
    public interface IService_Pedidos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/update", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/updateResponse")]
        void update(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/update", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/updateResponse")]
        System.Threading.Tasks.Task updateAsync(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/delete", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/deleteResponse")]
        void delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/delete", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/insert_rol_user" +
            "", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/insert_rol_user" +
            "Response")]
        void insert_rol_user(int rol, int user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/insert_rol_user" +
            "", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/insert_rol_user" +
            "Response")]
        System.Threading.Tasks.Task insert_rol_userAsync(int rol, int user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/delete_rol_user" +
            "", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/delete_rol_user" +
            "Response")]
        void delete_rol_user(int rol, int user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/delete_rol_user" +
            "", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/delete_rol_user" +
            "Response")]
        System.Threading.Tasks.Task delete_rol_userAsync(int rol, int user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/get_id_rol", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/get_id_rolRespo" +
            "nse")]
        int get_id_rol(string rol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/get_id_rol", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/get_id_rolRespo" +
            "nse")]
        System.Threading.Tasks.Task<int> get_id_rolAsync(string rol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/insert_Forms_ro" +
            "l", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/insert_Forms_ro" +
            "lResponse")]
        void insert_Forms_rol(int rol, int form);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/insert_Forms_ro" +
            "l", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/insert_Forms_ro" +
            "lResponse")]
        System.Threading.Tasks.Task insert_Forms_rolAsync(int rol, int form);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/delete_Forms_ro" +
            "l", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/delete_Forms_ro" +
            "lResponse")]
        void delete_Forms_rol(int rol, int form);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/delete_Forms_ro" +
            "l", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/delete_Forms_ro" +
            "lResponse")]
        System.Threading.Tasks.Task delete_Forms_rolAsync(int rol, int form);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/get_id_form", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/get_id_formResp" +
            "onse")]
        int get_id_form(string form);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/get_id_form", ReplyAction="http://localhost:8733/WcfService/Service_Pedidos/IService_Pedidos/get_id_formResp" +
            "onse")]
        System.Threading.Tasks.Task<int> get_id_formAsync(string form);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_PedidosChannel : FormsApp.SrvRef_Pedidos.IService_Pedidos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_PedidosClient : System.ServiceModel.ClientBase<FormsApp.SrvRef_Pedidos.IService_Pedidos>, FormsApp.SrvRef_Pedidos.IService_Pedidos {
        
        public Service_PedidosClient() {
        }
        
        public Service_PedidosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_PedidosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_PedidosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_PedidosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void update(int id, string name) {
            base.Channel.update(id, name);
        }
        
        public System.Threading.Tasks.Task updateAsync(int id, string name) {
            return base.Channel.updateAsync(id, name);
        }
        
        public void delete(int id) {
            base.Channel.delete(id);
        }
        
        public System.Threading.Tasks.Task deleteAsync(int id) {
            return base.Channel.deleteAsync(id);
        }
        
        public void insert_rol_user(int rol, int user) {
            base.Channel.insert_rol_user(rol, user);
        }
        
        public System.Threading.Tasks.Task insert_rol_userAsync(int rol, int user) {
            return base.Channel.insert_rol_userAsync(rol, user);
        }
        
        public void delete_rol_user(int rol, int user) {
            base.Channel.delete_rol_user(rol, user);
        }
        
        public System.Threading.Tasks.Task delete_rol_userAsync(int rol, int user) {
            return base.Channel.delete_rol_userAsync(rol, user);
        }
        
        public int get_id_rol(string rol) {
            return base.Channel.get_id_rol(rol);
        }
        
        public System.Threading.Tasks.Task<int> get_id_rolAsync(string rol) {
            return base.Channel.get_id_rolAsync(rol);
        }
        
        public void insert_Forms_rol(int rol, int form) {
            base.Channel.insert_Forms_rol(rol, form);
        }
        
        public System.Threading.Tasks.Task insert_Forms_rolAsync(int rol, int form) {
            return base.Channel.insert_Forms_rolAsync(rol, form);
        }
        
        public void delete_Forms_rol(int rol, int form) {
            base.Channel.delete_Forms_rol(rol, form);
        }
        
        public System.Threading.Tasks.Task delete_Forms_rolAsync(int rol, int form) {
            return base.Channel.delete_Forms_rolAsync(rol, form);
        }
        
        public int get_id_form(string form) {
            return base.Channel.get_id_form(form);
        }
        
        public System.Threading.Tasks.Task<int> get_id_formAsync(string form) {
            return base.Channel.get_id_formAsync(form);
        }
    }
}