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
            cmd = new SqlCommand("Ayuda_producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name_product", nombre);
            cn.Open();
            loDataReader = cmd.ExecuteReader();
            schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
            if (schemaTable.Rows.Count == 0)
            {
                cn.Close();
                return null;
            }

            cn.Close();
            return schemaTable;
        }

        public void insert_ProduDescuento(string name)
        {
            cmd = new SqlCommand("insert_ProduDescuento", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name_Rol", name);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Delete_ProduDescuento(int id)
        {
            cmd = new SqlCommand("delete_ProduDescuento", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_rol", id);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
