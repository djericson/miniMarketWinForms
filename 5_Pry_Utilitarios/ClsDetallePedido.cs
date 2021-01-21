using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class ClsDetallePedido
    {
        public int Id_detalle_pedido { get; set; }
        public int Id_pedido { get; set; }
        public int Id_producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_compra { get; set; }

        public ClsDetallePedido() { }
        public ClsDetallePedido(int id_detalle_pedido, int id_pedido, int id_producto,
            int cantidad, decimal precio_compra)
        {
            Id_detalle_pedido = id_detalle_pedido;
            Id_pedido = id_pedido;
            Id_producto = id_producto;
            Cantidad = cantidad;
            Precio_compra = precio_compra;
        }
        public ClsDetallePedido(int id_pedido, int id_producto,
        int cantidad, decimal precio_compra)
        {
            Id_pedido = id_pedido;
            Id_producto = id_producto;
            Cantidad = cantidad;
            Precio_compra = precio_compra;
        }
    }
}
