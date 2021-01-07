using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BL;
using Newtonsoft.Json;
using Utilitarios;

namespace NS_WCF_Prods 

{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISrv_wcf_Prods
    {
        [OperationContract]
        string GetData(int value);


        [OperationContract]
        void Insertar_(ClsProducto xobj);

        [OperationContract] 
        string _GetData(string value, string _DataRow);

        [DataContract]
        public class MyDataContract
        {
            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public SqlDataReader _sqlDataReader { get; set; }
        }
        [OperationContract]

        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "WCFSegurida.ContractType".
    [DataContract]
     
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
