using BL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace WcfService
{
    [ServiceBehavior(Namespace = "http://localhost:8733/WcfService/Service_Usr")]
    public class Service_Usr : IService_Usr
    {
        ClsBL_Usr objBL_Usr = new ClsBL_Usr();

        public void insUsr(Object[] objUsr)
        {
            objBL_Usr.insertUsr(objUsr);
        }
        public void updUsr(Object[] objUsr)
        {
            //objBL_Usr.updUsr(id, name);
        }

        public void delUsr(int idUsr)
        {
            //objBL_Usr.delUsr(idUsr);
        }

        public int get_id_nom_roles(int idUsr)
        {
            int res = 0;
            //var data = BL.get_id_nom_roles(rol);
            return res;
        }

        public List<Object[]> getListUsrs()
        {
            //string output = "";
            //List<ClsUsuario> lstUsrs = new List<ClsUsuario>;

            return objBL_Usr.getListUsrs();
        }
    }
}
