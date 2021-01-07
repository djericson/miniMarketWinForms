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
    public class ClsBL_Vta
    {
        ClsDAC_Ventas dac_vta = new ClsDAC_Ventas();
        public void insertar(ClsVenta xobj)
        {
            dac_vta.insertar(xobj);
        }
        public DataTable search_(string richTextBox1)
        {
            var _DataTable = dac_vta.search_(richTextBox1);
            if (_DataTable != null) {
                return _DataTable;
            }
            return null;
        }

    }

}
