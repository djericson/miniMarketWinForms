using FormsApp;
using Newtonsoft.Json;
using NS_WinFormsApps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        SrvRef_UsrRol.Gestion_User_RolClient objwcf = new SrvRef_UsrRol.Gestion_User_RolClient();
        gestion_productos _gestion_productos = new gestion_productos();
         FormMain _FormMain = new FormMain();


         
        List<Form> listForm = new List<Form>();
        public static string[][] DatosUsuario = new string[10][];
        public static string Usuario = "";
        public static int ID_Usuario = 0;
        public static string Rol = "";
        public static int ic_Rol = 0;
        DataTable Datatable = new DataTable();
        
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
                  ID_Usuario = Convert.ToInt32(DatosUsuario[0][0].ToString());
                //MessageBox.Show("userID:" + DatosUsuario[0][0].ToString() + "name" + DatosUsuario[0][1].ToString());
                //MessageBox.Show("DatosUsuario.Count(): "+DatosUsuario.Count());
                if (DatosUsuario.Count() > 0 )
                {

                    if (DatosUsuario.Count() >= 2)
                    {
                         
                        if (DatosUsuario.Count() == 2)
                        {

                            //var id_rol = DatosUsuario[1][0].ToString();
                             Rol = DatosUsuario[1][1].ToString();
                             ic_Rol = Convert.ToInt32(DatosUsuario[1][0].ToString());
                            //MessageBox.Show("userID:" + DatosUsuario[0][0].ToString() + "name" + DatosUsuario[0][1].ToString());

                            Type type = Datatable.GetType();
                            var data = objwcf.Forms_For_User(ic_Rol);
                            FormMain.dataTable = Deserialize(data, type);
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
                        MessageBox.Show("El Usuario no tiene Roles");
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
            ic_Rol = 0;



        }
        public DataTable Deserialize(string DataTable, Type type1)
        {

            Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();
            json.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            json.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            StringReader sr = new StringReader(DataTable);
            Newtonsoft.Json.JsonTextReader reader = new JsonTextReader(sr);
            //object result = json.Deserialize(reader, valueType);
            var result = json.Deserialize(reader, type1);
            reader.Close();

            return (DataTable)result;
        }
        private void Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
