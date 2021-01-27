using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class ClsPedido
    {
        public int Id_pedido { get; set; }
        public int Id_proveedor { get; set; }
        public int Id_usr_logued { get; set; }
        public string Pedido_descripcion { get; set; }
        public DateTime Fecha_pedido { get; set; }
        public string Estado_pedido { get; set; }

        public object timeStamp { get; set; }
        
        public ClsPedido() { }
        public ClsPedido(int id_pedido, int id_proveedor, int id_admin, string pedido_descripcion,
            DateTime fecha_pedido, string estado_pedido)
        {
            Id_pedido = id_pedido;
            Id_proveedor = id_proveedor;
            Id_usr_logued = id_admin;
            Pedido_descripcion = pedido_descripcion;
            Fecha_pedido = fecha_pedido;
            Estado_pedido = estado_pedido;
        }

        public ClsPedido(int id_proveedor, int id_admin, string pedido_descripcion,
            DateTime fecha_pedido, string estado_pedido)
        {
            Id_proveedor = id_proveedor;
            Id_usr_logued = id_admin;
            Pedido_descripcion = pedido_descripcion;
            Fecha_pedido = fecha_pedido;
            Estado_pedido = estado_pedido;
        }
    }
}
