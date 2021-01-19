using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    [ServiceBehavior(Namespace = "http://localhost:8733/WcfService/ServiceProveedor")]

    public class ServiceProveedor : IServiceProveedor
    {
        public string GetData(int value)
        {
            throw new NotImplementedException();
        }
    }
}
