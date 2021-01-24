using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class ProductoDescuento : Form
    {
        ProductDescuento productDescuento = new ProductDescuento();
        public ProductoDescuento()
        {
            InitializeComponent();
        }
        public void list_productDescuent()
        {
          
           
            list_productos.DataSource = productDescuento.search_product("");
            list_productos.Columns["id_descuento"].Visible = false;
            list_productos.Columns["id_prod"].Visible = false;
        }
        private void ProductoDescuento_Load(object sender, EventArgs e)
        {
            list_productDescuent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if(list_productos.Columns.Count >1)
            {
                var id_prod = Convert.ToInt32(list_productos.CurrentRow.Cells["id_prod"].Value);
                var porcentaje = Convert.ToInt32(Descuento.Text);
                var fecha_inicio = Convert.ToDateTime(Fecha_Inicio.Value.ToString()).ToString("yyyy-M-dd");
                var fecha_fin = Convert.ToDateTime(Fecha_Fin.Value.ToString()).ToString("yyyy-M-dd");

                productDescuento.insert_ProduDescuento(id_prod, porcentaje, Convert.ToDateTime(fecha_inicio), Convert.ToDateTime(fecha_fin));
                list_productDescuent();
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (list_productos.Columns.Count > 1)
            {
                var id_prod = Convert.ToInt32(list_productos.CurrentRow.Cells["id_prod"].Value);
                if(list_productos.CurrentRow.Cells["id_descuento"].Value != DBNull.Value)
                {
                    var id_descuento = Convert.ToInt32(list_productos.CurrentRow.Cells["id_descuento"].Value);
                    productDescuento.Delete_ProduDescuento(id_prod, id_descuento);
                    list_productDescuent();
                }
               
            }
        }
    }
}
