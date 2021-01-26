using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace DAC
{
    public class ClsDAC_Ventas
    {

        SqlConnection cn = new SqlConnection("Data Source = sql-srv2.database.windows.net;Initial Catalog=miniMarket;User ID=katheryne;Password=$K012345");
        SqlCommand cmd;

        public void insertar(ClsVenta xobj)
        {

        }

        public int insertar(Dictionary<string, object> datos_venta, Dictionary<string, object> datos_pago)
        {
            cn.Open();
            SqlTransaction ObjTran = cn.BeginTransaction();
            try {
                cmd = new SqlCommand("insert_venta", cn);
                cmd.Transaction = ObjTran;

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
                cmd.Parameters.AddWithValue("@VersionTimestam", datos_venta["timeStamp_prod"]);

                SqlParameter pVta_id = new SqlParameter("@output", SqlDbType.Int);
                pVta_id.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pVta_id);

                //cn.Open();
                cmd.ExecuteNonQuery();
                ObjTran.Commit();

                int li_pVta_id = Convert.ToInt32(cmd.Parameters["@output"].Value);
                return li_pVta_id;
            }
            catch (SqlException sqlex) {
                ObjTran.Rollback();
                cn.Close();
                return -1;
            }
            catch (Exception ex) {
                return -1;
                //MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally { cn.Close(); }

            

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

        public DataTable search_product(string nombre)
        {
            DataTable schemaTable = new DataTable();
            cmd = new SqlCommand("Producto_Venta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@name_product", nombre);
            cn.Open();
            SqlDataReader loDataReader = cmd.ExecuteReader();
            schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
            if (schemaTable.Rows.Count == 0) {
                cn.Close();
                return null;
            }

            cn.Close();
            return schemaTable;
        }

        public object selectUnProd(int id_prod)
        {
            object ts_Res = null;
            cmd = new SqlCommand("[Vta_buscar_prod_ts]", cn);
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_prod", id_prod);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) {
                dr.Read();
                ts_Res = dr.GetValue(dr.GetOrdinal("timestam"));
            }
            cn.Close();

            return ts_Res;
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
