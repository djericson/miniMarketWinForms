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
        ClsUsuario objClsUsr = new ClsUsuario();
        public void insertUsr(Object[] objUsr)
        {
            /*
            objClsUsr.id_usr = Convert.ToInt32(objUsr[0]);
            objClsUsr.nick_usr = objUsr[1].ToString();
            objClsUsr.pass_usr = objUsr[2].ToString();
            objClsUsr.tipoDoc_usr = Convert.ToInt32( objUsr[3] );
            objClsUsr.nroDoc_usr = Convert.ToInt32(objUsr[4]);
            objClsUsr.ruc_usr = Convert.ToInt32(objUsr[5]);
            objClsUsr.nom_usr = objUsr[6].ToString();
            objClsUsr.apePat_usr = objUsr[7].ToString();
            objClsUsr.apeMat_usr = objUsr[8].ToString();
            objClsUsr.email_usr = objUsr[9].ToString();
            objClsUsr.tlf_usr= Convert.ToInt32( objUsr[10].ToString() );
            objClsUsr.dir_usr = objUsr[11].ToString();
            */
            dac_usr.insUsr(objClsUsr);
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
