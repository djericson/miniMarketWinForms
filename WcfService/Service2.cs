using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    [ServiceBehavior(Namespace = "http://localhost:8733/WcfService/Service2")]

    public class Service2 : IService2
    {
        public string GetData(int value)
        {
            throw new NotImplementedException();
        }
    }
}
