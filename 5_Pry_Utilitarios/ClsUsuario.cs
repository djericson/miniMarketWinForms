using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class ClsUsuario
    {
        public int id{ get; set; }
        public string Usuario { get; set; }
        public string clave { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public Boolean Activo { get; set; }
        public Boolean Bloqueado { get; set; }
        public int intentos_fallidos { get; set; }
        public ClsUsuario() { }
        public ClsUsuario(string _Usuario, string _clave, string _Nombres, string _Apellidos, string _Correo) 
        {
            Usuario = _Usuario;clave = _clave;Nombres = _Nombres;Apellidos = _Apellidos;
            Correo = _Correo;
        }
    }
    public class clsProveedores
    {
        public int Id_proveedor { get; set; }
        public string Razon_social { get; set; }
        public string Categoria { get; set; }
        public string Tipo_documento { get; set; }
        public string Num_documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Pagina_web { get; set; }
        public string Texto_buscar { get; set; }
      

        public clsProveedores() { }
        public clsProveedores(int id_proveedor, string razon_social, string categoria,
            string tipo_documento, string num_documento, string direccion, string telefono,
            string email, string pagina_web, string texto_buscar)
        {
            Id_proveedor = id_proveedor;
            Razon_social = razon_social;
            Categoria = categoria;
            Tipo_documento = tipo_documento;
            Num_documento = num_documento;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Pagina_web = pagina_web;
            Texto_buscar = texto_buscar;
        }
        public clsProveedores(string razon_social, string categoria,
            string tipo_documento, string num_documento, string direccion, 
            string telefono, string email, string pagina_web)
        {
            Razon_social = razon_social;
            Categoria = categoria;
            Tipo_documento = tipo_documento;
            Num_documento = num_documento;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Pagina_web = pagina_web;
        }
    }
    public class ClsProducto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int id_categoria { get; set; }
        public string marca { get; set; }
        public string presio_prome { get; set; }
        public string descripcion { get; set; }
        public string unida_product { get; set; }
        public int id_producto_detalle { get; set; }
        public int cantidad_producto_venta { get; set; }
        public string stock_entry_date { get; set; }
        
        public string fabrication_date { get; set; }
        public string expiration_date { get; set; }
         public ClsProducto() { }
        public ClsProducto(int id,string name, int id_categoria, string marca, string presio_prome, string descripcion)
        {
            this.id = id; this.name = name; this.id_categoria = id_categoria; this.marca = marca; this.presio_prome = presio_prome; this.descripcion = descripcion;
        }

    }
}
