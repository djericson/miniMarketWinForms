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

namespace WcfService
{
    [ServiceBehavior(Namespace = "http://localhost:8733/WcfService/Service_Usr")]
    public class Service_Usr : IService_Usr
    {
        ClsBL_Usr objBL_Usr = new ClsBL_Usr();
       

        public void insUsr(Object[] objUsr)
        {
            //Parametros my_params = (Parametros)objUsr;
            
            //objBL_Usr.
            
            //Console.WriteLine("Datr", f);
            //int n_bio = my_params.pos_bio;
            objBL_Usr.insertUsr(objUsr);
        }
        public void update(int id, string name)
        {
            //objBL_Usr._(id, name);
        }

        public void delete(int id)
        {
            //objBL_Usr.delete_rol(id);
        }

        public void insert_rol_user(int rol, int user)
        {
            //BL.insert_Rol_user(rol, user);
        }

      
        public void delete_rol_user(int rol, int user)
        {
            //BL.delete_Rol_user(rol, user);
        }



        public int get_id_rol(string rol)
        {
            int res = 0;
            //var data = BL.get_id_rol(rol);
            return res;
        }

        public void insert_Forms_rol(int rol, int form)
        {
            //BL.insert_Forms_rol(rol, form);
        }

        public void delete_Forms_rol(int rol, int form)
        {
            //BL.delete_Forms_rol(rol, form);
        }

        public int get_id_form(string form)
        {

            //var data = BL.get_id_form(form);
            return 0;
        }

        public string List_Forms_rol()
        {
            string output = "";
            /*
            //var data = BL.list_Forms_Rol();
            Type type = data.GetType();
            Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();
            json.NullValueHandling = NullValueHandling.Ignore;
            json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            json.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            if (type == typeof(DataSet))
                json.Converters.Add(new DataSetConverter());
            StringWriter sw = new StringWriter();
            Newtonsoft.Json.JsonTextWriter writer = new JsonTextWriter(sw);
            writer.Formatting = Formatting.Indented;
            writer.QuoteChar = '"';
            json.Serialize(writer, data);
            string output = sw.ToString();
            writer.Close();
            sw.Close();
            */
            return output;
        }
    }
}
