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
    public class ClsBL_Vta
    {
        ClsDAC_Ventas dac_vta = new ClsDAC_Ventas();
        public void insertar(ClsVenta xobj)
        {
            dac_vta.insertar(xobj);
        }

        public void insertar(Dictionary<string, object> datos_venta,
            Dictionary<string, object> datos_pago)
        {
            dac_vta.insertar(datos_venta, datos_pago);
        }

        public DataTable search()
        {
            return dac_vta.search();
        }

        public DataTable search_product(string nombre)
        {
            return dac_vta.search_product(nombre);
        }

        public DataTable search_client(string nombre)
        {
            return dac_vta.search_client(nombre);
        }


    }

}
