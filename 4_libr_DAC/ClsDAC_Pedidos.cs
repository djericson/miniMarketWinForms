using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilitarios;
using System.Data.SqlClient;
//using 

namespace DAC
{
    public class ClsDAC_Pedidos
    {
        SqlConnection cnn = new SqlConnection("Data Source=sql-srv2.database.windows.net;Initial Catalog=miniMarket;User ID=wilber;Password=$W012345");

        public int comprobarStock(int id_prod, int cantApedir, object _timestamp)
        {
            cnn.Open();
            SqlTransaction ObjTran = cnn.BeginTransaction();
            try {
                SqlCommand cmd = new SqlCommand("ped_comparar_ts_cant", cnn);
                cmd.Transaction = ObjTran;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_prod", id_prod);
                cmd.Parameters.AddWithValue("@cantApedir", cantApedir);
                cmd.Parameters.AddWithValue("@VersionTimestam", _timestamp);

                SqlParameter pRes = new SqlParameter("@output", SqlDbType.Int);
                pRes.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pRes);

                //cn.Open();
                cmd.ExecuteNonQuery();
                ObjTran.Commit();

                int li_pRes = Convert.ToInt32(cmd.Parameters["@output"].Value);
                return li_pRes;
            }
            catch (SqlException sqlex) {
                ObjTran.Rollback();
                cnn.Close();
                return -1;
            }
            catch (Exception ex) {
                return -2;
                //MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally { cnn.Close(); }

        }

        #region ......................METODO INSERTAR LOS INGRESOS Y LOS DETALES DE INGRESO A LA MISMA VEZ
        public string Insertar_pedido(ClsPedido Pedido, List<ClsDetallePedido> Detalle)
        {                                               
            string rpta = "";
            cnn.Open();
            SqlTransaction SqlTra = cnn.BeginTransaction();
            try {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.Transaction = SqlTra;
                cmd.CommandText = "insertar_pedido";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parIdpedido = new SqlParameter();
                parIdpedido.ParameterName = "@id_pedido";
                parIdpedido.SqlDbType = SqlDbType.Int;
                parIdpedido.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parIdpedido);

                cmd.Parameters.AddWithValue("@id_proveedor", Pedido.Id_proveedor);
                cmd.Parameters.AddWithValue("@id_admin", Pedido.Id_usr_logued);               
                cmd.Parameters.AddWithValue("@fecha_pedido", Pedido.Fecha_pedido);
                cmd.Parameters.AddWithValue("@estado_pedido", Pedido.Estado_pedido);              
              
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";//INSERTAMOS EL INGRESO       
                if (rpta.Equals("OK"))  {        

                    Pedido.Id_pedido = Convert.ToInt32(cmd.Parameters["@id_pedido"].Value);

                    foreach (ClsDetallePedido det in Detalle) {
                        ClsDAC_Detalle_Pedido x = new ClsDAC_Detalle_Pedido();
                        det.Id_pedido = Pedido.Id_pedido;                        
                        rpta = x.InsertarDetallePedido(det, ref cnn, ref SqlTra);
                        if (!rpta.Equals("OK")) {
                            break;
                        }
                    }
                }
                if (rpta.Equals("OK")) {
                    SqlTra.Commit();
                }
                else {
                    SqlTra.Rollback();
                }
                return rpta;
            }
            catch (SqlException sqlex) {
                SqlTra.Rollback();
                cnn.Close();
                return "-1";
            }
            catch (Exception ex) {
                rpta = ex.Message;
                return rpta; 
            }
            finally { cnn.Close(); }
            
        }
        #endregion
        #region .............................METODO ANULAR INGRESO
        public string Anular_pedido(ClsPedido Pedido)
        {
            string rpta = "";
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "anular_pedido";
                cmd.CommandType = CommandType.StoredProcedure;           

                cmd.Parameters.AddWithValue("@id_pedido", Pedido.Id_pedido);              
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se anulo el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            cnn.Close();
            return rpta;
        }
        #endregion
        #region ..............................METODO MOSTRAR PEDIDO
        public DataTable Mostrar_pedido()
        {
            DataTable dtResultado = new DataTable("pedido");
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "mostrar_pedido";
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
        #endregion
        #region ........................METODO BUSCAR FECHAS
        public DataTable Buscar_fechas(string TextoBuscar, string TextoBuscar2)
        {
            DataTable dtResultado = new DataTable("pedido");
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "buscar_ingreso_fecha";
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.Parameters.AddWithValue("@textobuscar", TextoBuscar);
                cmd.Parameters.AddWithValue("@textobuscar2", TextoBuscar2);
                SqlDataAdapter datAdapter = new SqlDataAdapter(cmd);
                datAdapter.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }

            return dtResultado;
        }
        #endregion
        #region ........................METODO MOSTRAR DETALLE PEDIDO
        public DataTable Mostrar_detalle_pedido(string TextoBuscar)
        {
            DataTable dtResultado = new DataTable("detalle_pedido");
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "mostrar_detalle_pedido";
                cmd.CommandType = CommandType.StoredProcedure;              
                SqlParameter parTextoBuscar = new SqlParameter();
                cmd.Parameters.AddWithValue("@textobuscar", TextoBuscar);               
                SqlDataAdapter datAdapter = new SqlDataAdapter(cmd);
                datAdapter.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }

            return dtResultado;
        }
        #endregion


    }
}
