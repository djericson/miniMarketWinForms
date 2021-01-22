using DAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL_Login
    {
        DAC_Login dac_login = new DAC_Login();
        public List<List<string>> Login(string user, string pasword)
        {
            var Rol_User = dac_login.Login(user, pasword);
            if (Rol_User != null)
            {
                return Rol_User;
            }
            return null;
        }
        public DataTable Forms_For_User(int ID_Rol)
        {
            var _DataTable = dac_login.Forms_For_User(ID_Rol);
            if (_DataTable != null)
            {
                return _DataTable;
            }
            return null;
        }
    }
}
