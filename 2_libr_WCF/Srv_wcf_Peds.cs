using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Utilitarios;
using BL;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;
using System.IO;
using Newtonsoft.Json.Converters;

namespace NS_WCF_Peds
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Srv_wcf_Peds : ISrv_wcf_Peds
    {
        ClsBL_Usr objBL = new ClsBL_Usr();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

         
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null) {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue) {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void Insertar_(ClsPedido xobj)
        {
            throw new NotImplementedException();
        }

        public void Insertar_Usuario(ClsUsuario xobj)
        {
            ClsBL_Usr x = new ClsBL_Usr();
            //x.insertar(xobj);
        }
        
    }
}
