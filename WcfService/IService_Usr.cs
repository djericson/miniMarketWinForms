using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace WcfService
{
    [ServiceContract(Namespace = "http://localhost:8733/WcfService/Service_Usr")]
    public interface IService_Usr
    {
        [OperationContract]
        void insUsr(Object[] objUsr);
        [OperationContract]
        void updUsr(Object[] objUsr);
        [OperationContract]
        void delUsr(int idUsr);

        [OperationContract]
        int get_id_nom_roles(int idUsr);
        [OperationContract]
        List<Object[]> getListUsrs();
    }
}
