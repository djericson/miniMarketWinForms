using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace WcfService
{
     [ServiceContract(Namespace = "http://localhost:8733/WcfService/Service_Productos")]

    public interface IProductos
    {
        [OperationContract]
        string _GetData(string value, string _DataRow);

        [OperationContract]
        object _GetData2(string value, string _DataRow);

        [OperationContract]
        int insert_producto(ClsProducto objProducto, string XmlPut);
        [OperationContract]
        void update_producto(ClsProducto objProducto, string XmlPut);
        [OperationContract]
        void delete_producto(ClsProducto objProducto);

         
    }
}
