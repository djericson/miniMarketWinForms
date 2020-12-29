using System;
using System.Collections.Generic;
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
    }
}
