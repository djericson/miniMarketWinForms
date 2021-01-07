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

namespace App
{
    public partial class login : Form
    {
        public static string Pasword = "";
        public static int richTextlent = 1;
      
        static gestion_productos _adm = new gestion_productos();
        //static alumno _alumno = new alumno();
        List<Form> listForm = new List<Form>();
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
                NS_WCF_Login.Srv_wcf_Login xwcf = new NS_WCF_Login.Srv_wcf_Login();
                this.Hide();
                int id_Rol = xwcf.Login(user_name.Text, Pasword);
                MessageBox.Show("Login Successful!");
                for (int x= 0; x < listForm.Count(); x++)
                {
                    if (x == id_Rol)
                    {
                        listForm[x].Show();
                    }
                }
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed!");
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            //listForm.Add(_adm);
            //listForm.Add(_alumno);
           



        }
    }
}
