using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using System.Data;
using System.Data.SqlClient;

namespace DAC
{
    public class ClsDAC_Ventas
    {

        SqlConnection cn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net;Initial Catalog=miniMarket;User ID=katheryne;Password=$K012345");
        SqlCommand cmd;

        public void insertar(ClsVenta xobj)
        {

        }

        public void insertar(Dictionary<string, object> datos_venta, Dictionary<string, object> datos_pago)
        {
            cmd = new SqlCommand("insert_venta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_usuario", datos_venta["id_usuario"].ToString());
            cmd.Parameters.AddWithValue("@id_cajero", datos_venta["id_cajero"].ToString());
            cmd.Parameters.AddWithValue("@id_ayudante", null);
            cmd.Parameters.AddWithValue("@numero_operacion", datos_venta["numero_operacion"].ToString());
            cmd.Parameters.AddWithValue("@numero_comprobante", datos_venta["numero_comprobante"].ToString());
            cmd.Parameters.AddWithValue("@tipo_comprobante", datos_venta["tipo_comprobante"].ToString());
            cmd.Parameters.AddWithValue("@fecha_venta", datos_venta["fecha_venta"]);
            cmd.Parameters.AddWithValue("@precio", datos_venta["precio_total"].ToString());
            cmd.Parameters.AddWithValue("@tipo_pago", datos_pago["tipo_pago"].ToString());
            cmd.Parameters.AddWithValue("@monto_pago", datos_pago["monto_pago"].ToString());
            cmd.Parameters.AddWithValue("@detalle_venta", datos_venta["detalle_venta"].ToString());
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
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

    }
}
