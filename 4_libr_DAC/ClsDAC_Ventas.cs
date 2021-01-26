using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAC
{
    public class ClsDAC_Ventas
    {

        SqlConnection cn = new SqlConnection("Data Source = sql-srv2.database.windows.net;Initial Catalog=miniMarket;User ID=katheryne;Password=$K012345");
        SqlCommand cmd;

        public void insertar(ClsVenta xobj)
        {

        }

        public int  insertar(Dictionary<string, object> datos_venta, Dictionary<string, object> datos_pago)
        {
            cmd = new SqlCommand("insert_venta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_usuario", datos_venta["id_usuario"].ToString());
            cmd.Parameters.AddWithValue("@id_cajero", datos_venta["id_cajero"].ToString());
            cmd.Parameters.AddWithValue("@numero_operacion", datos_venta["numero_operacion"].ToString());
            cmd.Parameters.AddWithValue("@numero_comprobante", datos_venta["numero_comprobante"].ToString());
            cmd.Parameters.AddWithValue("@tipo_comprobante", datos_venta["tipo_comprobante"].ToString());
            cmd.Parameters.AddWithValue("@fecha_venta", datos_venta["fecha_venta"]);
            cmd.Parameters.AddWithValue("@precio", datos_venta["precio_total"].ToString());
            cmd.Parameters.AddWithValue("@tipo_pago", datos_pago["tipo_pago"].ToString());
            cmd.Parameters.AddWithValue("@monto_pago", datos_pago["monto_pago"].ToString());
            cmd.Parameters.AddWithValue("@detalle_venta", datos_venta["detalle_venta"].ToString());

            SqlParameter Validacion = new SqlParameter("@Validacion", SqlDbType.Int);
            Validacion.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(Validacion);

            cn.Open();
            cmd.ExecuteNonQuery();
            int validacion = Convert.ToInt32(cmd.Parameters["@Validacion"].Value);
            cn.Close();

            return validacion;
        }

        public DataTable search()
        {
            cmd = new SqlCommand("listado_ventas", cn);
            DataTable table = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader, LoadOption.OverwriteChanges);
            cn.Close();
            return table;
        }
        public DataTable search_(string val) 
        {
            return null;
        }
        public static object Column(this DataRow source, string columnName)
        {
            var c = source.Table.Columns[columnName];
            if (c != null)
            {
                return source.ItemArray[c.Ordinal];
            }

            return null;
        }
        public DataTable search_product(string nombre)
        {
            DataTable schemaTable = new DataTable();
            cmd = new SqlCommand("Producto_Venta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@name_product", nombre);
            cn.Open();
            SqlDataReader loDataReader = cmd.ExecuteReader();
            //Object timestam = loDataReader.GetValue(loDataReader.GetOrdinal("timestam"));
            schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
            var d = schemaTable.Rows[0].Table.Columns["timestam"].Ordinal;
            MessageBox.Show(d.ToString());
            if (schemaTable.Rows.Count == 0)
            {
                cn.Close();
                return null;
            }

            cn.Close();
            return schemaTable;
        }

        public DataTable search_client(string nombre)
        {
            DataTable schemaTable = new DataTable();
            cmd = new SqlCommand("buscar_cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usr_nom", nombre);
            cn.Open();
            SqlDataReader loDataReader = cmd.ExecuteReader();
            schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
            if (schemaTable.Rows.Count == 0)
            {
                cn.Close();
                return null;
            }

            cn.Close();
            return schemaTable;
        }

        public int getNumeroOperacion()
        {
            int numero = 0;
            cmd = new SqlCommand("obtener_numero", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cn.Open();
            SqlDataReader loDataReader = cmd.ExecuteReader();
            if (loDataReader.HasRows)
            {
                loDataReader.Read();
                numero = (int)loDataReader["Numero"];
                cn.Close();
                return numero;
            }

            return 0;
            cn.Close();
        }

    }
}
