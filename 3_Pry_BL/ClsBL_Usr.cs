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
    public class ClsBL_Usr
    {
        ClsDAC_Usuario dac_usuario
            = new ClsDAC_Usuario();
        public void insertar(ClsUsuario xobj)
        {
            dac_usuario.insertar(xobj);
        }
        public DataTable search_product(string richTextBox1 , string _DataRow)
        {
            var _DataTable = dac_usuario.search_product(richTextBox1, _DataRow);
            if (_DataTable != null)
            {
                return _DataTable;
            }
            return null;
        }
        public int Login(string user, string pasword)
        {
            var Id_rol = dac_usuario.Login(user, pasword);



            if (Id_rol == 1)
            {
                return Id_rol;
            }
            return 0;


        }

    }
    public class clsBLProveedor
    {
        #region METODO INSERTAR
        public static string INSERTAR(string razon_proveedor, string categoria, string tipo_documento, string num_documento,
             string direccion, string telefono, string email, string pagina_web)
        {
            clsDAProveedor obj = new clsDAProveedor();
            clsProveedores insertar = new clsProveedores();
            insertar.Razon_social = razon_proveedor;
            insertar.Categoria = categoria;
            insertar.Tipo_documento = tipo_documento;
            insertar.Num_documento = num_documento;
            insertar.Direccion = direccion;
            insertar.Telefono = telefono;
            insertar.Email = email;
            insertar.Pagina_web = pagina_web;
            return obj.Insertar(insertar);
        }

        #endregion
        #region METODO EDITAR
        public static string EDITAR(int id_proveedor, string razon_proveedor, string categoria, string tipo_documento, string num_documento,
             string direccion, string telefono, string email, string pagina_web)
        {
            clsDAProveedor obj = new clsDAProveedor();
            clsProveedores editar = new clsProveedores();
            editar.Id_proveedor = id_proveedor;
            editar.Razon_social = razon_proveedor;
            editar.Categoria = categoria;
            editar.Tipo_documento = tipo_documento;
            editar.Num_documento = num_documento;
            editar.Direccion = direccion;
            editar.Telefono = telefono;
            editar.Email = email;
            editar.Pagina_web = pagina_web;
            return obj.Insertar(editar);
        }
        #endregion
        #region METODO ELIMINAR
        public static string ELIMINAR(int id_proveedor)
        {
            clsDAProveedor obj = new clsDAProveedor();
            clsProveedores eliminar = new clsProveedores();
            eliminar.Id_proveedor = id_proveedor;
            return obj.Eliminar(eliminar);
        }
        #endregion
        #region METODO MOSTRAR
        public static DataTable MOSTRAR()
        {
            return new clsDAProveedor().Mostrar();
        }
        #endregion
        #region METODO BUSCAR RAZON
        public static DataTable BUSCAR_RAZON_SOCIAL(string textobuscar)
        {
            clsDAProveedor obj = new clsDAProveedor();
            clsProveedores texto = new clsProveedores();
            texto.Texto_buscar = textobuscar;
            return obj.BuscarRazonSocial(texto);

        }
        #endregion
        #region METODO BUSCAR NUMERO
        public static DataTable BUSCAR_NUM_DOCUMENTO(string numero)
        {
            clsDAProveedor obj = new clsDAProveedor();
            clsProveedores texto = new clsProveedores();
            texto.Texto_buscar = numero;
            return obj.BuscarNum_Documento(texto);
        }
        #endregion
    }

}
