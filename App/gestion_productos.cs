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
using PracticaCalificada;

namespace App
{
    public partial class gestion_productos : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader loDataReader;
       
        public gestion_productos()
        {
            InitializeComponent();
        }

        private void buscar_producto_Click(object sender, EventArgs e)
        {


            try
            {
                cmd.CommandText = "Ayuda_producto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_producto", codigo_producto.Text);
                con.Open();
                loDataReader = cmd.ExecuteReader();
                Busqueda objayuda = new Busqueda();
                objayuda.objDR = loDataReader;
                objayuda.ShowDialog(this);
                if (objayuda.objRow != null)
                {
                    cmd.CommandText = "Seleccionar_UnProducto";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@PROD_ID", objayuda.objRow.Cells[0].Value);
                    loDataReader = cmd.ExecuteReader();
                    if (loDataReader.HasRows)
                    {
                        loDataReader.Read();
                        textBox1.Text = loDataReader.GetValue(loDataReader.GetOrdinal("Id")).ToString();
                        textBox2.Text = loDataReader.GetValue(loDataReader.GetOrdinal("NombreProducto")).ToString();
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void gestion_productos_Load(object sender, EventArgs e)
        {


            con.ConnectionString = "Server=EDGAR;DataBase=Pachacamac_;Integrated Security=SSPI;";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = con;
        }
    }
}
