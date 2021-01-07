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
        ClsDAC_Prods dac_prods = new ClsDAC_Prods();
        public void insertar(ClsProducto xobj)
        {
            dac_prods.insert_product(xobj);
        }

        public DataTable search_product(string richTextBox1, string _DataRow)
        {
            var _DataTable = dac_prods.search_product(richTextBox1, _DataRow);
            if (_DataTable != null) {
                return _DataTable;
            }
            return null;
        }

    }

}
