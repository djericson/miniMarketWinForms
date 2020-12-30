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
    public class ClsBL_usr
    {
        ClsDAC_Usuario dac_usuario = new ClsDAC_Usuario();
        public void insertar(ClsUsuario xobj)
        {
            dac_usuario.insertar(xobj);
        }
        public DataTable search_product(string richTextBox1 , string _DataRow)
        {
            var _DataTable = dac_usuario.search_product(richTextBox1, _DataRow);
            if (_DataTable != null)
            {
                return _DataTable;
            }
            return null;
        }
    }
}
