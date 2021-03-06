﻿using FormsApp;
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
        


         
        List<Form> listForm = new List<Form>();
        public static string[][] DatosUsuario = new string[10][];
        public static string Usuario = "";
        public static int ID_Usuario = 0;
        public static string Name_Rol = "";
        public static string Name_Usuario = "";
        public static int ID_Rol = 0;
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

        public void Login(string name, string pasword)
        {
            try
            {
               
                DatosUsuario = objwcf.Login(name, pasword);
                Usuario = DatosUsuario[0][1].ToString();
                ID_Usuario = Convert.ToInt32(DatosUsuario[0][0].ToString());
                if (DatosUsuario.Count() > 0)
                {

                    if (DatosUsuario.Count() >= 2)
                    {

                        if (DatosUsuario.Count() == 2)
                        {

                            Name_Rol = DatosUsuario[1][1].ToString();
                            ID_Rol = Convert.ToInt32(DatosUsuario[1][0].ToString());
                            Type type = Datatable.GetType();
                            var data = objwcf.Forms_For_User(ID_Rol);
                            FormMain.dataTable = Deserialize(data, type);
                            if (FormMain.dataTable != null)
                            {
                                FormMain formMain = new FormMain();
                                formMain.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("El Rol de "+ Name_Rol+" no tiene asociado Forms");
                            }

                        }
                        else
                        {
                            MasDeUnRol _MasDeUnRol = new MasDeUnRol();
                            _MasDeUnRol.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("El Usuario no tiene Roles");
                        
                    }


                }
                else
                {
                    MessageBox.Show("No encontrado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed!");
                MessageBox.Show(ex.Message);
            }
            DatosUsuario = null;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Name_Usuario = user_name.Text;
            Login(Name_Usuario, Pasword);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
            FormMain.dataTable = null;
            Usuario = "";
            ID_Rol = 0;

            //MessageBox.Show(""+ Name_Usuaio + ""+ Pasword);

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
            Application.Exit();
        }
    }
}
