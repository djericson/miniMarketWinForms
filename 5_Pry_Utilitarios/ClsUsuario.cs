using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class ClsUsuario
    {
        public int id_usr { get; set; }
        public string nick_usr { get; set; }
        public string pass_usr { get; set; }
        public int tipoDoc_usr { get; set; }
        public int nroDoc_usr { get; set; }
        public int ruc_usr { get; set; }
        public string nom_usr { get; set; }
        public string apePat_usr { get; set; }
        public string apeMat_usr { get; set; }
        public string email_usr { get; set; }
        public int tlf_usr { get; set; }
        public string dir_usr { get; set; }

        public ClsUsuario() { }

        public ClsUsuario(int _id_usr, string _nick_usr, string _pass_usr, int _tipoDoc_usr, int _nroDoc_usr, int _ruc_usr, string _nom_usr, string _apePat_usr,
            string _apeMat_usr, string _email_usr, int _tlf_usr, string _dir_usr)
        {
            id_usr = _id_usr; nick_usr = _nick_usr; pass_usr = _pass_usr; tipoDoc_usr = _tipoDoc_usr; ; nroDoc_usr = _nroDoc_usr;
            ruc_usr = _ruc_usr; nom_usr = _nom_usr; apePat_usr = _apePat_usr; apeMat_usr = _apeMat_usr; email_usr = _email_usr; tlf_usr = _tlf_usr;
            dir_usr = _dir_usr;
        }

        public ClsUsuario(string _nick_usr, string _pass_usr, int _tipoDoc_usr, int _nroDoc_usr, int _ruc_usr, string _nom_usr, string _apePat_usr,
            string _apeMat_usr, string _email_usr, int _tlf_usr, string _dir_usr)
        {
            nick_usr = _nick_usr; pass_usr = _pass_usr; tipoDoc_usr = _tipoDoc_usr; ; nroDoc_usr = _nroDoc_usr;
            ruc_usr = _ruc_usr; nom_usr = _nom_usr; apePat_usr = _apePat_usr; apeMat_usr = _apeMat_usr; email_usr = _email_usr; tlf_usr = _tlf_usr;
            dir_usr = _dir_usr;
        }
    }

}
