﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormsApp.SrvRef_Usr {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:8733/WcfService/Service_Usr", ConfigurationName="SrvRef_Usr.IService_Usr")]
    public interface IService_Usr {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/insUsr", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/insUsrResponse")]
        void insUsr(object objUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/insUsr", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/insUsrResponse")]
        System.Threading.Tasks.Task insUsrAsync(object objUsr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/update", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/updateResponse")]
        void update(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/update", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/updateResponse")]
        System.Threading.Tasks.Task updateAsync(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/delete", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/deleteResponse")]
        void delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/delete", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/insert_rol_user", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/insert_rol_userResponse" +
            "")]
        void insert_rol_user(int rol, int user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/insert_rol_user", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/insert_rol_userResponse" +
            "")]
        System.Threading.Tasks.Task insert_rol_userAsync(int rol, int user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/delete_rol_user", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/delete_rol_userResponse" +
            "")]
        void delete_rol_user(int rol, int user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/delete_rol_user", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/delete_rol_userResponse" +
            "")]
        System.Threading.Tasks.Task delete_rol_userAsync(int rol, int user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/get_id_rol", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/get_id_rolResponse")]
        int get_id_rol(string rol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/get_id_rol", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/get_id_rolResponse")]
        System.Threading.Tasks.Task<int> get_id_rolAsync(string rol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/insert_Forms_rol", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/insert_Forms_rolRespons" +
            "e")]
        void insert_Forms_rol(int rol, int form);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/insert_Forms_rol", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/insert_Forms_rolRespons" +
            "e")]
        System.Threading.Tasks.Task insert_Forms_rolAsync(int rol, int form);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/delete_Forms_rol", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/delete_Forms_rolRespons" +
            "e")]
        void delete_Forms_rol(int rol, int form);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/delete_Forms_rol", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/delete_Forms_rolRespons" +
            "e")]
        System.Threading.Tasks.Task delete_Forms_rolAsync(int rol, int form);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/get_id_form", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/get_id_formResponse")]
        int get_id_form(string form);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Usr/IService_Usr/get_id_form", ReplyAction="http://localhost:8733/WcfService/Service_Usr/IService_Usr/get_id_formResponse")]
        System.Threading.Tasks.Task<int> get_id_formAsync(string form);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_UsrChannel : FormsApp.SrvRef_Usr.IService_Usr, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_UsrClient : System.ServiceModel.ClientBase<FormsApp.SrvRef_Usr.IService_Usr>, FormsApp.SrvRef_Usr.IService_Usr {
        
        public Service_UsrClient() {
        }
        
        public Service_UsrClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_UsrClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_UsrClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_UsrClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insUsr(object objUsr) {
            base.Channel.insUsr(objUsr);
        }
        
        public System.Threading.Tasks.Task insUsrAsync(object objUsr) {
            return base.Channel.insUsrAsync(objUsr);
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
