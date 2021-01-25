using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAC
{
    public class ProductoDescuento
    {
        SqlConnection cn = new SqlConnection("Data Source= sql-srv2.database.windows.net; User ID =edgar; Password =$E012345; Initial Catalog=miniMarket");
        SqlCommand cmd;
        SqlDataReader loDataReader;
        DataTable schemaTable = new DataTable();
        DataSet dataSet = new DataSet();

        public DataTable lista_ProductoDescuento(string nombre)
        {

            schemaTable.Clear();
            cmd = new SqlCommand("Ayuda_producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name_product", nombre);
            cn.Open();
            loDataReader = cmd.ExecuteReader();
            //schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
            dataSet.Load(loDataReader, LoadOption.OverwriteChanges, new string[] { "list_productos", "ProductDescuento" });
             schemaTable = dataSet.Tables["ProductDescuento"];
            if (schemaTable.Rows.Count == 0)
            {
                cn.Close();
                return null;
            }
            cn.Close();
            return schemaTable;
        }

        public void insert_ProduDescuento(int  id_producto,int Porcentaje,DateTime fecha_inicio,DateTime fecha_fin)
        {
            cmd = new SqlCommand("Insert_ProductoDescuento", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_producto", id_producto);
            cmd.Parameters.AddWithValue("@Porcentaje", Porcentaje);
            cmd.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
            cmd.Parameters.AddWithValue("@fecha_fin", fecha_fin);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Delete_ProduDescuento(int id_producto, int id_descuento)
        {
            cmd = new SqlCommand("Delete_ProductoDescuento", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_producto", id_producto);
            cmd.Parameters.AddWithValue("@id_descuento", id_descuento);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
