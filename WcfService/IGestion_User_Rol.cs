using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    [ServiceContract(Namespace = "http://localhost:8733/WcfService/Service_User_Rol")]
    public interface IGestion_User_Rol
    {
        [OperationContract]
        string List_Forms_rol();
        [OperationContract]
        string List_User_rol();
        [OperationContract]
        void insert(string name);
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
        [OperationContract]
        List<List<string>> Login(string user,string pasword); 
        [OperationContract]
        string Forms_For_User(int ID_Rol);


    }
}
