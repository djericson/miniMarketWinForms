using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pry_4_DAC;
using Utilitarios;

namespace BL
{
    public class clsBLUsuario
    {
        clsDAUsario dausuario = new clsDAUsario();
        public void insertar(ClsUsuario xobj)
        {
            dausuario.insertar(xobj);
        }
        public SqlDataReader search_product(string valueRichTextBox1)
        {

            if (dausuario.search_product(valueRichTextBox1) != null)
            {
                var sqlDataReader = dausuario.search_product(valueRichTextBox1);
                return sqlDataReader;
            }
            else
            {
                return null;
            }
        }

    }
}
