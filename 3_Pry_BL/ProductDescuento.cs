using DAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ProductDescuento
    {
        ProductoDescuento productoDescuento = new ProductoDescuento();
        public DataTable search_product(string nombre)
        {
            var data = productoDescuento.lista_ProductoDescuento(nombre);
            return data;
        }

        public void insert_ProduDescuento(int id_producto, int Porcentaje, DateTime fecha_inicio, DateTime fecha_fin)
        {
            productoDescuento.insert_ProduDescuento(id_producto, Porcentaje, fecha_inicio, fecha_fin);

        }
        public void Delete_ProduDescuento(int id_producto, int id_descuento)
        {
            productoDescuento.Delete_ProduDescuento(id_producto, id_descuento);
        }
    }
}
