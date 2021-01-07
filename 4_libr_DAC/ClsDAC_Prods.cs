using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace DAC
{
    public class ClsDAC_Prods
    {
        SqlConnection cn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net; User ID =edgar; Password =$E012345; Initial Catalog=miniMarket");
        SqlCommand cmd;
        SqlDataReader loDataReader;
        DataTable schemaTable = new DataTable();

        public DataTable search_product(string richTextBox1, string _DataRow)
        {
            if (richTextBox1 != "") {
                cmd = new SqlCommand("Ayuda_producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name_product", richTextBox1);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
                if (schemaTable.Rows.Count == 0) {
                    cn.Close();
                    return null;
                }
                //DataTable schemaTable = loDataReader.GetSchemaTable();
                cn.Close();
                return schemaTable;

            }
            if (_DataRow != "") {
                cmd = new SqlCommand("Seleccionar_UnProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@PROD_ID", _DataRow);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
                //DataTable schemaTable = loDataReader.GetSchemaTable();
                cn.Close();
                return schemaTable;

            }
            return null;
        }

        public void insert_product(ClsProducto xobj)
        {

        }

        public int update_producto(string objProducto)
        {
            cmd = new SqlCommand("update_producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name_product", objProducto);
            cn.Open();
            loDataReader = cmd.ExecuteReader();
            schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
            if (schemaTable.Rows.Count == 0)
            {
                cn.Close();
                return 1;

            }
            //DataTable schemaTable = loDataReader.GetSchemaTable();
            cn.Close();
            return 0;
        }

        public void delete_producto()
        {

        }
    }
}
