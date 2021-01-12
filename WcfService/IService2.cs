using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    [ServiceContract(Namespace = "http://localhost:8733/WcfService/Service_Productos")]

    public interface IService2
    {
        [OperationContract]
        string GetData(int value);
    }
}
