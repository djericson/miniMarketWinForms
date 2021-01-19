using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class MasDeUnRol : Form
    {
        public static List<Button> listbutton = new List<Button>();
        public int Index = 0;
        public static int x = 70;
        public static int y = 25;
        public static int index_rol = 1;
        public static int ID_ROL = 0;
        public static string Name_Rol = "";
        public MasDeUnRol()
        {
            InitializeComponent();
        }
        public void create_richtexbox(string data, int xPosition, int yPosition)
        {
            Button richTB = new Button();
            listbutton.Add(richTB);
            listbutton[Index].Name = login.DatosUsuario[index_rol][0].ToString(); ;
            listbutton[Index].Text = login.DatosUsuario[index_rol][1].ToString();
            listbutton[Index].Height = 35;
            listbutton[Index].Width = 150;
            //listbutton[Index].BackColor = Color.FromArgb(240, 240, 240);
            //listbutton[Index].FlatAppearance.fla = FlatStyle.System;
            listbutton[Index].Location = new Point(yPosition, xPosition);
            x = x + 50;
            listbutton[Index].Click += new EventHandler(_click);
            listbutton[Index].Font = new Font(" Century Gothic", 12);
            Index = Index + 1;
            index_rol = index_rol + 1;
            groupBox1.Controls.Add(richTB);
            this.Controls.Add(groupBox1);

        }
        void _click(object action, EventArgs eventArgs)
        {
            for (int q = 0; q <= listbutton.Count; q++)
            {
                if (listbutton[q].GetHashCode().ToString() == action.GetHashCode().ToString())
                {
                    ID_ROL = Convert.ToInt32(listbutton[q].Name.ToString());
                    Name_Rol = listbutton[q].Text.ToString();
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();
                    //MessageBox.Show("data" + ID_ROL);
                    break;
                }
            }
        }
        private void MasDeUnRol_Load(object sender, EventArgs e)
        {
            Index = 0;
            x = 70;
            y = 25;
            index_rol = 1;
            ID_ROL = 0;
            Name_Rol = "";
            groupBox1.Controls.Clear();
            listbutton.Clear();
            for (int i = 2; i <= login.DatosUsuario.Count(); i++)
            {

                create_richtexbox(null, x, y);
            }

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            login.DatosUsuario = null;
            login gestion_cursos = new login();
            gestion_cursos.Show();
            this.Close();
        }

    }
}
