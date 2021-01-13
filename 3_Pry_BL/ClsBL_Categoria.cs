using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAC;
using Utilitarios;

namespace BL
{
    public class ClsBL_Categoria
    {
        public static string INSERTAR(string nombre, string descripcion)
        {
            ClsDAC_Categoria obj = new ClsDAC_Categoria();
            ClsCategoria editar = new ClsCategoria();
            editar.Nombre = nombre;
            editar.Descripcion = descripcion;
            return obj.Insertar(editar);
        }
        #region .................................METODO EDITAR
        public static string EDITAR(int idcategoria, string nombre, string descripcion)
        {
            ClsDAC_Categoria obj = new ClsDAC_Categoria();
            ClsCategoria editar = new ClsCategoria();
            editar.IdCategoria = idcategoria;
            editar.Nombre = nombre;
            editar.Descripcion = descripcion;
            return obj.Editar(editar);
        }
        #endregion
        #region ...........................METODO ELIMINAR
        public static string ELIMINAR(int idcategoria)
        {
            ClsDAC_Categoria obj = new ClsDAC_Categoria();
            ClsCategoria texto = new ClsCategoria();
            texto.IdCategoria = idcategoria;
            return obj.Eliminar(texto);
        }
        #endregion
        #region ...........................METODO MOSTRAR
        public static DataTable MOSTRAR()
        {
            return new ClsDAC_Categoria().Mostrar();
        }
        #endregion
        #region........................... METODO BUSCAR NOMBRE
        public  DataTable BUSCAR_NOMBRE(string textobuscar)
        {
            ClsDAC_Categoria obj = new ClsDAC_Categoria();
            ClsCategoria texto = new ClsCategoria();
            texto.TextoBuscar = textobuscar;
            return obj.BuscarNombre(texto);
        }
        #endregion
    }
}
