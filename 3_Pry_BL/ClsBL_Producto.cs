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
    public class ClsBL_Producto
    {
        ClsDAC_Productos dac_prods = new ClsDAC_Productos();
        public void insertar(ClsProducto xobj)
        {
            //dac_prods.insert_product(xobj);
        }

        public DataSet search_product(string richTextBox1, string _DataRow)
        {
            var _DataSet = dac_prods.search_product(richTextBox1, _DataRow);
            if (_DataSet != null) {
                return _DataSet;
            }
            return null;
        }
        public DataTable search_product(string nombre)
        {
            return dac_prods.search_product(nombre);
        }

        public int insert_producto(ClsProducto objProducto , string XmlPut )
        {
            int out_id = dac_prods.insert_producto(objProducto, XmlPut);
            return out_id;
        }
        public void update_producto(ClsProducto objProducto, string XmlPut)
        {
            dac_prods.update_producto(objProducto, XmlPut);
        }
        public void delete_producto(ClsProducto objProducto)
        {
            dac_prods.delete_producto(objProducto);
        }
        public DataTable MOSTRAR()
        {
          return new ClsDAC_Productos().Mostrar();
        }
        public DataTable BUSCAR_NOMBRE(string textoBuscar)
        {
            ClsDAC_Productos x = new ClsDAC_Productos();
            ClsProducto obj = new ClsProducto();
            obj.Textobuscar = textoBuscar;
           return  x.BuscarNombre(obj);
        }

    }

}
