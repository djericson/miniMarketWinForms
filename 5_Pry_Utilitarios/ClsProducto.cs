using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class ClsProducto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int id_categoria { get; set; }
        public string marca { get; set; }
        public string presio_prome { get; set; }
        public string descripcion { get; set; }
        public string unida_product { get; set; }
        public int id_producto_detalle { get; set; }
        public int cantidad_producto_venta { get; set; }
        public string stock_entry_date { get; set; }

        public string fabrication_date { get; set; }
        public string expiration_date { get; set; }
        public ClsProducto() { }
        public ClsProducto(int id, string name, int id_categoria, string marca, string presio_prome, string descripcion)
        {
            this.id = id; this.name = name; this.id_categoria = id_categoria; this.marca = marca; this.presio_prome = presio_prome; this.descripcion = descripcion;
        }

    }
}
