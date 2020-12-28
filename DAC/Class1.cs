using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilitarios;
 
using System.Windows.Forms;

namespace DAC
{
    public class clsDAUsario
    {
        SqlConnection cn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net; User ID =edgar; Password =$E012345; Initial Catalog=miniMarket");
        SqlCommand cmd;
        SqlDataReader loDataReader;
        public static string valueRichTextBox1;
        public List<clsUsuario> lista()
        {
            List<clsUsuario> x=new List<clsUsuario>();

            return x;
        }
        public void insertar(clsUsuario xobj )
        {
            cmd = new SqlCommand("[seguridad].[usuario_insert]", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usuario",xobj.Usuario );
            cmd.Parameters.AddWithValue("@clave", xobj.clave);
            cmd.Parameters.AddWithValue("@nombres", xobj.Nombres);
            cmd.Parameters.AddWithValue("@apellidos", xobj.Apellidos);
            cmd.Parameters.AddWithValue("@correo", xobj.Correo);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void eliminar(clsUsuario xobj)
        {
            

        }
        public clsUsuario validar_usuario(string xusuario, string xclave)
        {
            clsUsuario x = new clsUsuario();

            return x;
        }
        public Boolean search_product1(string valueRichTextBox1)
        {

            try
            {
                cmd = new SqlCommand("Ayuda_producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_producto", valueRichTextBox1);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            
                
             
           
        }
        public Boolean search_product2(string obj)
        {
            //Busqueda objayuda = new Busqueda();
            //objayuda.objDR = loDataReader;
            //objayuda.ShowDialog(this);
            if (obj != null)
            {
                cmd = new SqlCommand("Seleccionar_UnProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@PROD_ID", obj);
                loDataReader = cmd.ExecuteReader();
                if (loDataReader.HasRows)
                {
                    MessageBox.Show("loDataReader");
                    loDataReader.Read();
                    //textBox1.Text = loDataReader.GetValue(loDataReader.GetOrdinal("id_prod")).ToString();
                    //textBox2.Text = loDataReader.GetValue(loDataReader.GetOrdinal("name_product")).ToString();
                }
                return true;
            }
            else
            {
                return false;
            }




        }

    }
    public class clsDAAplicaciones
    { }

}
