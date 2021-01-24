using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAC;
using Utilitarios;

namespace BL
{
    public class ClsBL_Pedido
    {
        public static string INSERTAR(int idproveedor, int idadmin, DateTime fechaPedido, string estadoPedido, DataTable dtdetalles)
        {
            ClsDAC_Pedidos obj = new ClsDAC_Pedidos();
            ClsPedido obj_pedido = new ClsPedido();
            obj_pedido.Id_proveedor = idproveedor;
            obj_pedido.Id_usr_logued = idadmin;
            obj_pedido.Fecha_pedido = fechaPedido;
            obj_pedido.Estado_pedido = estadoPedido;


            List<ClsDetallePedido> detalles = new List<ClsDetallePedido>();
            foreach (DataRow row in dtdetalles.Rows)
            {       
                ClsDetallePedido detalle = new ClsDetallePedido();
                //detalle.Id_detalle_pedido = Convert.ToInt32(row["Id_pedido"].ToString());
                //detalle.Id_pedido = Convert.ToInt32(row["Id_pedido"].ToString());
                detalle.Id_producto = Convert.ToInt32(row["Id_producto"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
                detalle.Precio_compra = Convert.ToDecimal(row["Precio_compra"].ToString());
                detalles.Add(detalle);
            }
            return obj.Insertar_pedido(obj_pedido, detalles);  
        }

        #region ...........................METODO ANULAR
        public static string ANULAR(int idpedido)
        {
            ClsDAC_Pedidos obj = new ClsDAC_Pedidos();
            ClsPedido pedido = new ClsPedido();
            pedido.Id_pedido = idpedido;
            return obj.Anular_pedido(pedido);
        }
        #endregion
        #region ...........................METODO MOSTRAR
        public static DataTable MOSTRAR()
        {
            ClsDAC_Pedidos obj = new ClsDAC_Pedidos();
            return obj.Mostrar_pedido();        
        }
        #endregion
        #region........................... METODO BUSCAR POR FECHA
        public static DataTable BUSCAR_FECHAS(string textoBuscar, string textoBuscar2)
        {
            ClsDAC_Pedidos obj = new ClsDAC_Pedidos();
            return obj.Buscar_fechas(textoBuscar, textoBuscar2);
        }
        #endregion
        #region........................... METODO MOSTRAR DETALLE
        public static DataTable MOSTRAR_DETALLE(string textoBuscar)
        {
            ClsDAC_Pedidos obj = new ClsDAC_Pedidos();
            return obj.Mostrar_detalle_pedido(textoBuscar);
        }
        #endregion

    }
}
