using DAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Gestion_User_Rol
    {
        DacGestion_Rol_Usuario dac_gestion_user_rol = new DacGestion_Rol_Usuario();

         
        public DataSet list_Forms_Rol()
        {
            var data = dac_gestion_user_rol.list_Forms_Rol();
            return data;

        }
        public DataSet List_User_rol()
        {
            var data = dac_gestion_user_rol.List_User_rol();
            return data;

        }
        public void insert_rol(string name)
        {
            dac_gestion_user_rol.insert_Rol(name);
           

        }
        public void update_rol(int id ,string name)
        {
            dac_gestion_user_rol.update_Rol(id, name);


        }
        public void delete_rol(int id)
        {
            dac_gestion_user_rol.delete_Rol(id);


        }
        public void insert_Rol_user(int rol, int user)
        {
            dac_gestion_user_rol.insert_Rol_user(rol,user);


        }
        public void delete_Rol_user(int rol, int user)
        {
            dac_gestion_user_rol.delete_Rol_user(rol, user);


        }
        public int get_id_rol(string rol)
        {
            var data = dac_gestion_user_rol.get_id_rol(rol);

            return data;
        }

        public void insert_Forms_rol(int rol, int form)
        {
            dac_gestion_user_rol.insert_Forms_rol(rol, form);


        }
        public void delete_Forms_rol(int rol, int form)
        {
            dac_gestion_user_rol.delete_Forms_rol(rol, form);


        }
        public int get_id_form(string form)
        {
            var data = dac_gestion_user_rol.get_id_Form(form);

            return data;
        }


    }
}
