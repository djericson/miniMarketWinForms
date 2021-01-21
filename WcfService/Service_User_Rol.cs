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
    [ServiceBehavior(Namespace = "http://localhost:8733/WcfService/Service_User_Rol")]
    public class Service_User_Rol: IGestion_User_Rol
    {
        Gestion_User_Rol BL = new Gestion_User_Rol();

        public void delete(int id)
        {
            BL.delete_rol(id);
        }

        public void insert(string name)
        {
            BL.insert_rol(name);
        }
        public void update(int id, string name)
        {
            BL.update_rol(id, name);
        }

        public void insert_rol_user(int rol, int user)
        {
            BL.insert_Rol_user(rol, user);
        }

      
        public void delete_rol_user(int rol, int user)
        {
            BL.delete_Rol_user(rol, user);
        }

        public string List_User_rol()
        {
             var data = BL.List_User_rol();
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
            
             return output;
          
        }
        public int get_id_rol(string rol)
        {
            var data = BL.get_id_rol(rol);
            return data;
        }

        public void insert_Forms_rol(int rol, int form)
        {
            BL.insert_Forms_rol(rol, form);
        }

        public void delete_Forms_rol(int rol, int form)
        {
            BL.delete_Forms_rol(rol, form);
        }

        public int get_id_form(string form)
        {
            var data = BL.get_id_form(form);
            return data;
        }

        public string List_Forms_rol()
        {
            var data = BL.list_Forms_Rol();
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

            return output;
        }

        public List<List<string>> Login(string user, string pasword)
        {

            BL_Login BL = new BL_Login();
            var data = BL.Login(user, pasword);
            return data;
        }

        public string Forms_For_User(int ID_Rol)
        {
            BL_Login BL = new BL_Login();
            var data_Table = BL.Forms_For_User(ID_Rol);
            Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();
            json.NullValueHandling = NullValueHandling.Ignore;
            json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            json.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //if (type == typeof(DataSet))
            json.Converters.Add(new DataTableConverter());
            StringWriter sw = new StringWriter();
            Newtonsoft.Json.JsonTextWriter writer = new JsonTextWriter(sw);
            writer.Formatting = Formatting.Indented;
            writer.QuoteChar = '"';
            json.Serialize(writer, data_Table);
            string output = sw.ToString();
            writer.Close();
            sw.Close();
            return output;
        }
    }
}
