using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Data;
using Utilitarios;

namespace WcfService
{
    [ServiceBehavior(Namespace = "http://localhost:8733/WcfService/Service_Productos")]

    public class Service_Productos: IProductos
    {
        ClsBL_Producto objBL = new ClsBL_Producto();

        public void delete_producto(int id_producto)
        {
            throw new NotImplementedException();
        }

        public void update_producto(ClsProducto objProducto)
        {
            objBL.update_producto(objProducto);
        }

        public string _GetData(string value, string _DataRow)
        {
            var _DataSet = objBL.search_product(value, _DataRow);
            if (_DataSet != null)
            {
                Type type = _DataSet.GetType();
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
                // writer.Formatting = Formatting.None;
                writer.QuoteChar = '"';

                json.Serialize(writer, _DataSet);
                string output = sw.ToString();
                writer.Close();
                sw.Close();

                return output;
            }
            return null;

        }
       

        object IProductos._GetData2(string value, string _DataRow)
        {
            var _DataTable = objBL.search_product(value, _DataRow);
            if (_DataTable != null)
            {


                return _DataTable;
            }
            return null;

        }
    }
}
