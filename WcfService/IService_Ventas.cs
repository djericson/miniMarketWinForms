using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    [ServiceContract(Namespace = "http://localhost:8733/WcfService/Service_Ventas")]
    public interface IService_Ventas
    {
        /*
        [OperationContract]
        string List_Forms_rol();
        [OperationContract]
        string List_User_rol();
        [OperationContract]
        */
        void insUsr(object objUsr);
        [OperationContract]
        void update(int id, string name);
        [OperationContract]
        void delete(int id);

        [OperationContract]
        void insert_rol_user(int rol, int user);
        [OperationContract]
        void delete_rol_user(int rol, int user);
        [OperationContract]
        int get_id_rol(string rol);
        [OperationContract]
        void insert_Forms_rol(int rol, int form);
        [OperationContract]
        void delete_Forms_rol(int rol, int form);
        [OperationContract]
        int get_id_form(string form);


    }
}
