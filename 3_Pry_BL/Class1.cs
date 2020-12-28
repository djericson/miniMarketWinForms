using System;
using System.Collections.Generic;
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
    }
}
