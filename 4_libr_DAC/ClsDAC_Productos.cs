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
    public class ClsDAC_Productos
    {
        SqlConnection cn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net; User ID =edgar; Password =$E012345; Initial Catalog=miniMarket");
        SqlCommand cmd;
        SqlDataReader loDataReader;
        DataTable schemaTable = new DataTable();
        DataSet dataSet = new DataSet();

        public DataSet search_product(string richTextBox1, string _DataRow)
        {
            dataSet.Clear();
            if (richTextBox1 != "") 
            {
                cmd = new SqlCommand("Ayuda_producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name_product", richTextBox1);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                //schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
                dataSet.Load(loDataReader, LoadOption.PreserveChanges, new string[] { "list_productos" });
                if (dataSet.Tables["list_productos"].Rows.Count == 0)
                {
                    cn.Close();
                    return null;
                }

                cn.Close();
                //dataSet.Tables.Add(schemaTable);
                return dataSet;

            }
            if (_DataRow != "") 
            {
                cmd = new SqlCommand("Seleccionar_UnProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@PROD_ID", _DataRow);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                dataSet.Load(loDataReader, LoadOption.PreserveChanges, new string[] { "producto", "categorias" });
                cn.Close();
                return dataSet;

            }
            return null;
        }

        public void insert_product(ClsProducto xobj)
        {

        }

        public void update_producto(ClsProducto objProducto)
        {
            cmd = new SqlCommand("update_producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", objProducto.id);
            cmd.Parameters.AddWithValue("@name_product", objProducto.name);
            cmd.Parameters.AddWithValue("@id_categoria", objProducto.id_categoria);
            cmd.Parameters.AddWithValue("@marca", objProducto.marca);
            cmd.Parameters.AddWithValue("@presio_prome", objProducto.presio_prome);
            cmd.Parameters.AddWithValue("@cantida_total", objProducto.cantida_total);
            cmd.Parameters.AddWithValue("@descripcion", objProducto.descripcion);
            cmd.Parameters.AddWithValue("@unida_product", objProducto.unida_product);
            cmd.Parameters.AddWithValue("@id_producto_detalle", objProducto.id_producto_detalle);
            cmd.Parameters.AddWithValue("@presio_prome_detalle", objProducto.presio_prome_detalle);
            cmd.Parameters.AddWithValue("@cantidad_producto_venta", objProducto.cantidad_producto_venta);
            cmd.Parameters.AddWithValue("@stock_entry_date", objProducto.stock_entry_date);
            cmd.Parameters.AddWithValue("@fabrication_date", objProducto.fabrication_date);
            cmd.Parameters.AddWithValue("@expiration_date", objProducto.expiration_date);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            
        }

        public void delete_producto()
        {

        }
    }
}
