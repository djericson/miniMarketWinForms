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
         
    }
}
