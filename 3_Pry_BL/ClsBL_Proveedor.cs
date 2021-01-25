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
    public class ClsBLProveedor
    {
        #region METODO INSERTAR
        public static string INSERTAR(string razon_proveedor, string categoria, string tipo_documento, string num_documento,
             string direccion, string telefono, string email, string pagina_web)
        {
            ClsDAC_Proveedores obj = new ClsDAC_Proveedores();
            ClsProveedor obj_insertar = new ClsProveedor();
            obj_insertar.Id_usr = razon_proveedor;
            obj_insertar.Categoria = categoria;
            obj_insertar.Tipo_documento = tipo_documento;
            obj_insertar.Num_documento = num_documento;
            obj_insertar.Direccion = direccion;
            obj_insertar.Telefono = telefono;
            obj_insertar.Email = email;
            obj_insertar.Pagina_web = pagina_web;
            return obj.Insertar(obj_insertar);
        }

        #endregion
        #region METODO EDITAR
        public static string EDITAR(int id_proveedor, string razon_proveedor, string categoria, string tipo_documento, string num_documento,
             string direccion, string telefono, string email, string pagina_web)
        {
            ClsDAC_Proveedores obj = new ClsDAC_Proveedores();
            ClsProveedor obj_editar = new ClsProveedor();
            obj_editar.Id_proveedor = id_proveedor;
            obj_editar.Id_usr = razon_proveedor;
            obj_editar.Categoria = categoria;
            obj_editar.Tipo_documento = tipo_documento;
            obj_editar.Num_documento = num_documento;
            obj_editar.Direccion = direccion;
            obj_editar.Telefono = telefono;
            obj_editar.Email = email;
            obj_editar.Pagina_web = pagina_web;
            return obj.Insertar(obj_editar);
        }
        #endregion
        #region METODO ELIMINAR
        public static string ELIMINAR(int id_proveedor)
        {
            ClsDAC_Proveedores obj = new ClsDAC_Proveedores();
            ClsProveedor obj_eliminar = new ClsProveedor();
            obj_eliminar.Id_proveedor = id_proveedor;
            return obj.Eliminar(obj_eliminar);
        }
        #endregion
        #region METODO MOSTRAR
        public static DataTable MOSTRAR()
        {
            return new ClsDAC_Proveedores().Mostrar();
        }
        #endregion
        #region METODO BUSCAR RAZON
        public DataTable BUSCAR_RAZON_SOCIAL(string textobuscar)
        {
            ClsDAC_Proveedores obj = new ClsDAC_Proveedores();
            ClsProveedor obj_texto = new ClsProveedor();
            obj_texto.Texto_buscar = textobuscar;
            return obj.BuscarRazonSocial(obj_texto);

        }
        #endregion
        #region METODO BUSCAR NUMERO
        public DataTable BUSCAR_NUM_DOCUMENTO(string numero)
        {
            ClsDAC_Proveedores obj = new ClsDAC_Proveedores();
            ClsProveedor texto = new ClsProveedor();
            texto.Texto_buscar = numero;
            return obj.BuscarNum_Documento(texto);
        }
        #endregion
    }

}
