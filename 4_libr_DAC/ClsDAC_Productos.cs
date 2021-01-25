using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarios;

namespace DAC
{
    public class ClsDAC_Productos
    {
        SqlConnection cn = new SqlConnection("Data Source= sql-srv2.database.windows.net; User ID =edgar; Password =$E012345; Initial Catalog=miniMarket");
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
                dataSet.Load(loDataReader, LoadOption.OverwriteChanges, new string[] { "list_productos" });
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
                dataSet.Load(loDataReader, LoadOption.OverwriteChanges, new string[] { "producto", "categorias", "producto_det", "unidad_product" });
                cn.Close();
                return dataSet;

            }
            return null;
        }

        public DataTable search_product(string nombre)
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

        public void update_producto(ClsProducto objProducto, string XmlPut)
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
            cmd.Parameters.AddWithValue("@XMLPut", XmlPut);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
          
        }
        public int insert_producto(ClsProducto objProducto ,string XmlPut)
        {
            cmd = new SqlCommand("insert_producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name_product", objProducto.name);
            cmd.Parameters.AddWithValue("@id_categoria", objProducto.id_categoria);
            cmd.Parameters.AddWithValue("@marca", objProducto.marca);
            cmd.Parameters.AddWithValue("@presio_prome", objProducto.presio_prome);
            cmd.Parameters.AddWithValue("@cantida_total", objProducto.cantida_total);
            cmd.Parameters.AddWithValue("@descripcion", objProducto.descripcion);
            cmd.Parameters.AddWithValue("@unida_product", objProducto.unida_product);
            cmd.Parameters.AddWithValue("@XMLPut", XmlPut);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            return 0;

        }

        public void delete_producto(ClsProducto objProducto)
        {
            cmd = new SqlCommand("delete_producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", objProducto.id);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public DataTable Mostrar()
        {
            DataTable dtResultado = new DataTable("producto");
            try
            {
                cmd = new SqlCommand("mostra_producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dtAdapter = new SqlDataAdapter(cmd);
                dtAdapter.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }
            return dtResultado;
        }

        public DataTable BuscarNombre(ClsProducto Producto)
        {
            DataTable dtResultado = new DataTable("producto");
            try
            {
                cmd = new SqlCommand("buscar_producto_nombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;            
                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 50;
                parTextoBuscar.Value = Producto.Textobuscar;
                cmd.Parameters.Add(parTextoBuscar);
                SqlDataAdapter datAdapter = new SqlDataAdapter(cmd);
                datAdapter.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }

            return dtResultado;
        }


    }
}
