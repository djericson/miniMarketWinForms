using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Utilitarios;
using BL;
using System.Data.SqlClient;

using Newtonsoft.Json;
using System.Data;
using System.IO;
using Newtonsoft.Json.Converters;

namespace NS_WCF_AccesosRolesUsrs
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Srv_wcf_AccesosRolesUsrs: ISrv_wcf_AccesosRolesUsrs
    {
        ClsBL_Usr objBL = new ClsBL_Usr();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string _GetData(string value, string _DataRow)
        {
            var _DataTable = objBL.search_product(value, _DataRow);
            if (_DataTable != null) {
                Type type = _DataTable.GetType();
                Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();
                json.NullValueHandling = NullValueHandling.Ignore;
                json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
                json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
                json.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                if (type == typeof(DataTable))
                    json.Converters.Add(new DataTableConverter());
                //if (type == typeof(DataRow))
                //    json.Converters.Add(new DataRowConverter());
                StringWriter sw = new StringWriter();
                Newtonsoft.Json.JsonTextWriter writer = new JsonTextWriter(sw);
                writer.Formatting = Formatting.Indented;
                // writer.Formatting = Formatting.None;
                writer.QuoteChar = '"';
               
                json.Serialize(writer, _DataTable);
                string output = sw.ToString();
                writer.Close();
                sw.Close();

                return output;

                //MyDataContract myDataContract = new MyDataContract();
                //myDataContract._sqlDataReader = sqlDataReader;
                //string JsonResponse = string.Empty;
                //JsonResponse = JsonConvert.SerializeObject(myDataContract._sqlDataReader);
                //Type type = value.GetType();

                //return JsonResponse;
            }
            return null;

        }

        public ISrv_wcf_AccesosRolesUsrs.MyDataContract GetData()
        {
            //List<MyDataContract> list = new List<MyDataContract>();
            ////your code
            //BL.ClsBL_usr x = new ClsBL_usr();
            //var sqlDataReader = x.search_product(null);
            //if (sqlDataReader != null)
            //{
            //    //MyDataContract myDataContract = new MyDataContract();
            //    //myDataContract._sqlDataReader = sqlDataReader;
            //    //var value = myDataContract._sqlDataReader;
            //    return null;
            //}
             
            return null;

        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null) {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue) {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void Insertar_Usuario(ClsUsuario xobj)
        {
            ClsBL_Usr x = new ClsBL_Usr();
            x.insertar(xobj);
        }
        public int Login(string user, string pasword)
        {
            var Id_rol = objBL.Login(user, pasword);
            if (Id_rol == 1) {
                return Id_rol;
            }
            return 0;
        }
    }
}
