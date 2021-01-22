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
    public class ClsBL_Usr
    {
        ClsDAC_Usuarios dac_usr = new ClsDAC_Usuarios();
        public void insertUsr(ClsUsuario xobj)
        {
            dac_usr.insertar(xobj);
        }

        //public DataTable search_(string richTextBox1 , string _DataRow)
        //{
        //    var _DataTable = dac_usr.search_(richTextBox1);
        //    if (_DataTable != null)
        //    {
        //        return _DataTable;
        //    }
        //    return null;
        //}

        public DataTable getUsrCliente(string nombre)
        {
            return dac_usr.getUsrCliente(nombre);
        }

    }

}
