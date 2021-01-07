using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class ClsUsuario
    {
        public int id { get; set; }
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
            Usuario = _Usuario; clave = _clave; Nombres = _Nombres; Apellidos = _Apellidos;
            Correo = _Correo;
        }
    }

}
