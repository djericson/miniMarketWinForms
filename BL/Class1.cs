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
        public void insertar(clsUsuario xobj)
        {
            dausuario.insertar(xobj);
        }
        public Boolean search_product(string valueRichTextBox1)
        {
            
            if(dausuario.search_product1(valueRichTextBox1) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
