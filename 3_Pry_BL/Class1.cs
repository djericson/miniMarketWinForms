using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAC;
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
