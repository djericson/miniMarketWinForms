using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    [ServiceContract(Namespace = "http://localhost:8733/WcfService/ServiceProveedor")]

    public interface IServiceProveedor
    {
        [OperationContract]
        string GetData(int value);
    }
}
