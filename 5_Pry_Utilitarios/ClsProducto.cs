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
        public object presio_prome { get; set; }
        public int cantida_total { get; set; }
        public string descripcion { get; set; }
        public string unida_product { get; set; }
        public int id_producto_detalle { get; set; }
        public object presio_prome_detalle { get; set; }
        public int cantidad_producto_venta { get; set; }
        public DateTime stock_entry_date { get; set; }
        public DateTime fabrication_date { get; set; }
        public DateTime expiration_date { get; set; }
        
        public ClsProducto() { }
        public ClsProducto(int id, string name, int id_categoria, string marca, object presio_prome, string descripcion , int cantida_total , string unida_product , int  id_producto_detalle  , object presio_prome_detalle , int cantidad_producto_venta , DateTime stock_entry_date , DateTime fabrication_date , DateTime expiration_date)
        {
            this.id = id; 
            this.name = name; 
            this.id_categoria = id_categoria; 
            this.marca = marca; 
            this.presio_prome = presio_prome; 
            this.descripcion = descripcion;
            this.cantida_total = cantida_total;
            this.unida_product = unida_product;
            this.id_producto_detalle = id_producto_detalle;
            this.presio_prome_detalle = presio_prome_detalle;
            this.cantidad_producto_venta = cantidad_producto_venta;
            this.stock_entry_date = stock_entry_date;
            this.fabrication_date = fabrication_date;
            this.expiration_date = expiration_date;
        }

    }
}
