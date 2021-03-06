﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class ClsProveedor
    {
        public int Id_proveedor { get; set; }
        public string Id_usr { get; set; }
        public string Categoria { get; set; }
        public string Tipo_documento { get; set; }
        public string Num_documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Pagina_web { get; set; }
        public string Texto_buscar { get; set; }

        public ClsProveedor() { }
        public ClsProveedor(int id_proveedor, string razon_social, string categoria,
            string tipo_documento, string num_documento, string direccion, string telefono,
            string email, string pagina_web, string texto_buscar)
        {
            Id_proveedor = id_proveedor;
            Id_usr = razon_social;
            Categoria = categoria;
            Tipo_documento = tipo_documento;
            Num_documento = num_documento;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Pagina_web = pagina_web;
            Texto_buscar = texto_buscar;
        }
        public ClsProveedor(string razon_social, string categoria,
            string tipo_documento, string num_documento, string direccion,
            string telefono, string email, string pagina_web)
        {
            Id_usr = razon_social;
            Categoria = categoria;
            Tipo_documento = tipo_documento;
            Num_documento = num_documento;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Pagina_web = pagina_web;
        }
    }
    
}
