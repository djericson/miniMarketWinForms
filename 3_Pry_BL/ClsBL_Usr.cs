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
            objClsUsr.nick_usr = objUsr[0].ToString();
            objClsUsr.pass_usr = objUsr[1].ToString();
            objClsUsr.tipoDoc_usr = Convert.ToInt32(objUsr[2]);
            objClsUsr.nroDoc_usr = objUsr[3].ToString()!= ""? Convert.ToInt32(objUsr[3]) : 0;
            objClsUsr.ruc_usr = objUsr[4].ToString() != "" ? Convert.ToInt32(objUsr[4]) : 0;
            objClsUsr.nom_usr = objUsr[5].ToString();
            objClsUsr.apePat_usr = objUsr[6].ToString();
            objClsUsr.apeMat_usr = objUsr[7].ToString();
            objClsUsr.email_usr = objUsr[8].ToString();
            objClsUsr.tlf_usr= objUsr[9].ToString() != "" ? Convert.ToInt32(objUsr[9]) : 0;
            objClsUsr.dir_usr = objUsr[10].ToString();
            
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

        public List<Object[]> getListUsrs()
        {
            List<Object[]> tmp_objLstObjs = new List<Object[]>();
            List<ClsUsuario> tmp_objLstUsrs = new List<ClsUsuario>();
            tmp_objLstUsrs = dac_usr.getListUsrs();
            foreach (ClsUsuario itmUsr in tmp_objLstUsrs) {
                tmp_objLstObjs.Add(new Object[] { itmUsr.id_usr, itmUsr.nick_usr, itmUsr.pass_usr, itmUsr.tipoDoc_usr, itmUsr.nroDoc_usr, itmUsr.ruc_usr, itmUsr.nom_usr,
                itmUsr.apePat_usr, itmUsr.apeMat_usr, itmUsr.email_usr, itmUsr.tlf_usr, itmUsr.dir_usr
                });
            }
            return tmp_objLstObjs;
        }

    }

}
