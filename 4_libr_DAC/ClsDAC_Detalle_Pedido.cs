using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilitarios;

namespace DAC
{
    class ClsDAC_Detalle_Pedido
    {
        SqlConnection cnn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net;Initial Catalog=miniMarket;User ID=wilber;Password=$W012345");


        #region ......................METODO INSERTAR
        public string InsertarDetallePedido(ClsDetallePedido Detalle_Pedido,
            ref SqlConnection SqlCnn, ref SqlTransaction sqlTra)
        {           
            string rpta = "";
            try
            {               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SqlCnn;
              
                cmd.Transaction = sqlTra;
                cmd.CommandText = "insertar_detalle_pedido";
                cmd.CommandType = CommandType.StoredProcedure;
               
                SqlParameter parIdPedido_detalle = new SqlParameter();
                parIdPedido_detalle.ParameterName = "@id_pedido_detalle";
                parIdPedido_detalle.SqlDbType = SqlDbType.Int;
                parIdPedido_detalle.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parIdPedido_detalle);

                cmd.Parameters.AddWithValue("@id_pedido", Detalle_Pedido.Id_pedido);
                cmd.Parameters.AddWithValue("@id_producto", Detalle_Pedido.Id_producto);
                cmd.Parameters.AddWithValue("@cantidad", Detalle_Pedido.Cantidad);
                cmd.Parameters.AddWithValue("@precio_compra", Detalle_Pedido.Precio_compra);               
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }           
            return rpta;
        }
        #endregion
    }
}
