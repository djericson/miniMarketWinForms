using App;
using FormsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class login : Form
    {
        public static string Pasword = "";
        public static int richTextlent = 1;

        Service_User_Rol.Gestion_User_RolClient objwcf = new Service_User_Rol.Gestion_User_RolClient();
        gestion_productos _gestion_productos = new gestion_productos();
         FormMain _FormMain = new FormMain();


         
        List<Form> listForm = new List<Form>();
        public static string[][] DatosUsuario = new string[10][];
        public static string Usuario = "";
        public static string Rol = "";

        public login()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
         
            if(pasword.Text.Length == richTextlent)
            {
                Pasword += pasword.Text[0].ToString();
                pasword.Text = pasword.Text.Remove(0, 1);
                pasword.Text += "*";
            }
            else
            {
                Pasword = "";
                pasword.Text = "";
            }
            richTextlent = pasword.Text.Length + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                  DatosUsuario = objwcf.Login(user_name.Text, Pasword);
                  Usuario = DatosUsuario[0][1].ToString();
                //MessageBox.Show("userID:" + DatosUsuario[0][0].ToString() + "name" + DatosUsuario[0][1].ToString());

                if (DatosUsuario.Count() > 0)
                {

                    if (DatosUsuario.Count() >= 1)
                    {
                         
                        if (DatosUsuario.Count() == 1)
                        {

                            var id_rol = DatosUsuario[1][0].ToString();
                            var name_rol = DatosUsuario[1][1].ToString();

                            //MessageBox.Show("userID:" + DatosUsuario[0][0].ToString() + "name" + DatosUsuario[0][1].ToString());
                            FormMain formMain = new FormMain();
                            formMain.Show();
                            this.Hide();
                        }
                        else
                        {
                            ////MessageBox.Show("DatosUsuario.Count(): " + DatosUsuario.Count());
                            //foreach (string[] subList in DatosUsuario)
                            //{
                            //    foreach (string data in subList)
                            //    {
                            //        MessageBox.Show(data);
                            //    }
                            //}
                            //MessageBox.Show("userID: " + DatosUsuario[0][0].ToString() + "name: " + DatosUsuario[1][0].ToString());
                            MasDeUnRol _MasDeUnRol = new MasDeUnRol();
                            _MasDeUnRol.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("El Usuario no tiene asociado Roles");
                    }
                    //MessageBox.Show("DatosUsuario.Count(): " + DatosUsuario.Count());
                   

                }
                else
                {
                    MessageBox.Show("NO encontrado");
                }


                //this.Hide();
                //string Rol_User = xwcf.Login(user_name.Text, Pasword);
                //MessageBox.Show("Login Successful!");
                //for (int x= 0; x < listForm.Count(); x++)
                //{
                //    if (x == Rol_User)
                //    {
                //        listForm[x].Show();
                //    }
                //}
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed!");
                MessageBox.Show(ex.Message);
            }
            DatosUsuario = null;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Usuario = "";




        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
