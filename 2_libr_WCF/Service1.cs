using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Utilitarios;
using BL;

namespace WCFSegurida
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class service1 : IService1

    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void Insertar_Usuario(ClsUsuario xobj)
        {
            BL.ClsBL_usr x = new ClsBL_usr();
            x.insertar(xobj);
        }
        public Boolean search_product(string valueRichTextBox1)
        {
            BL.ClsBL_usr x = new ClsBL_usr();
            
            if (x.search_product(valueRichTextBox1) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     
        public  void search_produc2222t(string valueRichTextBox1)
        {
            
        }

       

        public void buscar(string valueRichTextBox1)
        {
           
        }
    }
}
