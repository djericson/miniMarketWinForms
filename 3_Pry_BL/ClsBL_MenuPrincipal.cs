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
    public class ClsBL_MenuPrincipal
    {
        ClsDAC_MenuPrincipal dac_menuPrinc = new ClsDAC_MenuPrincipal();
        
        public DataTable findOptionsByIdUsrRol(int usrIdLogued)
        {
            var _Data = dac_menuPrinc.findOptionsByIdUsrRol(usrIdLogued);
            if (_Data != null)
            {
                return null;
            }
            return null;
        }
        
    }

}
