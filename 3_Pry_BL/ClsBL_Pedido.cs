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
        ClsDAC_Pedidos dac_pedido = new ClsDAC_Pedidos();
        public void insertar(ClsPedido xobj)
        {
            dac_pedido.insertar(xobj);
        }
        public DataTable search_(string richTextBox1, string _DataRow)
        {
            var _DataTable = dac_pedido.search_(richTextBox1, _DataRow);
            if (_DataTable != null)
            {
                return _DataTable;
            }
            return null;
        }

    }
}
