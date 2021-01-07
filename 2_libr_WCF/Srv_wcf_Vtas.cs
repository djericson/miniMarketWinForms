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

namespace NS_WCF_Vtas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Srv_wcf_Vtas: ISrv_wcf_Vtas
    {
        ClsBL_Vta objBL = new ClsBL_Vta();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string _GetData(string val)
        {
            var _DataTable = objBL.search_(val);
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

        public void Insertar_(ClsVenta xobj)
        {
            ClsBL_Vta x = new ClsBL_Vta();
            //x.insertar(xobj);
        }

        public ISrv_wcf_Vtas.MyDataContract GetData()
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

        
        
    }
}
