﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormsApp.WCF_Productos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClsProducto", Namespace="http://schemas.datacontract.org/2004/07/Utilitarios")]
    [System.SerializableAttribute()]
    public partial class ClsProducto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cantida_totalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cantidad_producto_ventaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime expiration_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fabrication_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_categoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_producto_detalleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string marcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object presio_promeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object presio_prome_detalleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime stock_entry_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string unida_productField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cantida_total {
            get {
                return this.cantida_totalField;
            }
            set {
                if ((this.cantida_totalField.Equals(value) != true)) {
                    this.cantida_totalField = value;
                    this.RaisePropertyChanged("cantida_total");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cantidad_producto_venta {
            get {
                return this.cantidad_producto_ventaField;
            }
            set {
                if ((this.cantidad_producto_ventaField.Equals(value) != true)) {
                    this.cantidad_producto_ventaField = value;
                    this.RaisePropertyChanged("cantidad_producto_venta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionField, value) != true)) {
                    this.descripcionField = value;
                    this.RaisePropertyChanged("descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime expiration_date {
            get {
                return this.expiration_dateField;
            }
            set {
                if ((this.expiration_dateField.Equals(value) != true)) {
                    this.expiration_dateField = value;
                    this.RaisePropertyChanged("expiration_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fabrication_date {
            get {
                return this.fabrication_dateField;
            }
            set {
                if ((this.fabrication_dateField.Equals(value) != true)) {
                    this.fabrication_dateField = value;
                    this.RaisePropertyChanged("fabrication_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_categoria {
            get {
                return this.id_categoriaField;
            }
            set {
                if ((this.id_categoriaField.Equals(value) != true)) {
                    this.id_categoriaField = value;
                    this.RaisePropertyChanged("id_categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_producto_detalle {
            get {
                return this.id_producto_detalleField;
            }
            set {
                if ((this.id_producto_detalleField.Equals(value) != true)) {
                    this.id_producto_detalleField = value;
                    this.RaisePropertyChanged("id_producto_detalle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string marca {
            get {
                return this.marcaField;
            }
            set {
                if ((object.ReferenceEquals(this.marcaField, value) != true)) {
                    this.marcaField = value;
                    this.RaisePropertyChanged("marca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object presio_prome {
            get {
                return this.presio_promeField;
            }
            set {
                if ((object.ReferenceEquals(this.presio_promeField, value) != true)) {
                    this.presio_promeField = value;
                    this.RaisePropertyChanged("presio_prome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object presio_prome_detalle {
            get {
                return this.presio_prome_detalleField;
            }
            set {
                if ((object.ReferenceEquals(this.presio_prome_detalleField, value) != true)) {
                    this.presio_prome_detalleField = value;
                    this.RaisePropertyChanged("presio_prome_detalle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime stock_entry_date {
            get {
                return this.stock_entry_dateField;
            }
            set {
                if ((this.stock_entry_dateField.Equals(value) != true)) {
                    this.stock_entry_dateField = value;
                    this.RaisePropertyChanged("stock_entry_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string unida_product {
            get {
                return this.unida_productField;
            }
            set {
                if ((object.ReferenceEquals(this.unida_productField, value) != true)) {
                    this.unida_productField = value;
                    this.RaisePropertyChanged("unida_product");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:8733/WcfService/Service_Productos", ConfigurationName="WCF_Productos.IProductos")]
    public interface IProductos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Productos/IProductos/_GetData", ReplyAction="http://localhost:8733/WcfService/Service_Productos/IProductos/_GetDataResponse")]
        string _GetData(string value, string _DataRow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Productos/IProductos/_GetData", ReplyAction="http://localhost:8733/WcfService/Service_Productos/IProductos/_GetDataResponse")]
        System.Threading.Tasks.Task<string> _GetDataAsync(string value, string _DataRow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Productos/IProductos/_GetData2", ReplyAction="http://localhost:8733/WcfService/Service_Productos/IProductos/_GetData2Response")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FormsApp.WCF_Productos.ClsProducto))]
        object _GetData2(string value, string _DataRow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Productos/IProductos/_GetData2", ReplyAction="http://localhost:8733/WcfService/Service_Productos/IProductos/_GetData2Response")]
        System.Threading.Tasks.Task<object> _GetData2Async(string value, string _DataRow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Productos/IProductos/insert_producto", ReplyAction="http://localhost:8733/WcfService/Service_Productos/IProductos/insert_productoResp" +
            "onse")]
        int insert_producto(FormsApp.WCF_Productos.ClsProducto objProducto, string XmlPut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Productos/IProductos/insert_producto", ReplyAction="http://localhost:8733/WcfService/Service_Productos/IProductos/insert_productoResp" +
            "onse")]
        System.Threading.Tasks.Task<int> insert_productoAsync(FormsApp.WCF_Productos.ClsProducto objProducto, string XmlPut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Productos/IProductos/update_producto", ReplyAction="http://localhost:8733/WcfService/Service_Productos/IProductos/update_productoResp" +
            "onse")]
        void update_producto(FormsApp.WCF_Productos.ClsProducto objProducto, string XmlPut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Productos/IProductos/update_producto", ReplyAction="http://localhost:8733/WcfService/Service_Productos/IProductos/update_productoResp" +
            "onse")]
        System.Threading.Tasks.Task update_productoAsync(FormsApp.WCF_Productos.ClsProducto objProducto, string XmlPut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Productos/IProductos/delete_producto", ReplyAction="http://localhost:8733/WcfService/Service_Productos/IProductos/delete_productoResp" +
            "onse")]
        void delete_producto(FormsApp.WCF_Productos.ClsProducto objProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/WcfService/Service_Productos/IProductos/delete_producto", ReplyAction="http://localhost:8733/WcfService/Service_Productos/IProductos/delete_productoResp" +
            "onse")]
        System.Threading.Tasks.Task delete_productoAsync(FormsApp.WCF_Productos.ClsProducto objProducto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductosChannel : FormsApp.WCF_Productos.IProductos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductosClient : System.ServiceModel.ClientBase<FormsApp.WCF_Productos.IProductos>, FormsApp.WCF_Productos.IProductos {
        
        public ProductosClient() {
        }
        
        public ProductosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string _GetData(string value, string _DataRow) {
            return base.Channel._GetData(value, _DataRow);
        }
        
        public System.Threading.Tasks.Task<string> _GetDataAsync(string value, string _DataRow) {
            return base.Channel._GetDataAsync(value, _DataRow);
        }
        
        public object _GetData2(string value, string _DataRow) {
            return base.Channel._GetData2(value, _DataRow);
        }
        
        public System.Threading.Tasks.Task<object> _GetData2Async(string value, string _DataRow) {
            return base.Channel._GetData2Async(value, _DataRow);
        }
        
        public int insert_producto(FormsApp.WCF_Productos.ClsProducto objProducto, string XmlPut) {
            return base.Channel.insert_producto(objProducto, XmlPut);
        }
        
        public System.Threading.Tasks.Task<int> insert_productoAsync(FormsApp.WCF_Productos.ClsProducto objProducto, string XmlPut) {
            return base.Channel.insert_productoAsync(objProducto, XmlPut);
        }
        
        public void update_producto(FormsApp.WCF_Productos.ClsProducto objProducto, string XmlPut) {
            base.Channel.update_producto(objProducto, XmlPut);
        }
        
        public System.Threading.Tasks.Task update_productoAsync(FormsApp.WCF_Productos.ClsProducto objProducto, string XmlPut) {
            return base.Channel.update_productoAsync(objProducto, XmlPut);
        }
        
        public void delete_producto(FormsApp.WCF_Productos.ClsProducto objProducto) {
            base.Channel.delete_producto(objProducto);
        }
        
        public System.Threading.Tasks.Task delete_productoAsync(FormsApp.WCF_Productos.ClsProducto objProducto) {
            return base.Channel.delete_productoAsync(objProducto);
        }
    }
}
