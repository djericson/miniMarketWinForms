using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NS_Busqueda;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using xDialog;
 


namespace App
{
    public partial class gestion_productos : Form
    {
        DataTable objTabla = new DataTable();
        static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        static SqlConnection connection = new SqlConnection();
        static SqlCommand command = new SqlCommand();

        //SqlConnection cn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net; User ID =edgar; Password =$E012345; Initial Catalog=miniMarket");

        public gestion_productos()
        {
            InitializeComponent();
            panel.Height = button4.Height;
            panel.Top = button4.Top;
         }

        private void buscar_producto_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            NS_WCF_Prods.Srv_wcf_Prods xwcf = new NS_WCF_Prods.Srv_wcf_Prods();
            var _DataTable = xwcf._GetData(richTextBox1.Text , "");
            Type type = objTabla.GetType();
            if (_DataTable != null)
            {
                Busqueda objayuda = new Busqueda();
                objayuda.objTabla = Deserialize(_DataTable, type);
                objayuda.ShowDialog(this);
                if (objayuda.objRow != null)
                {
                    string datarow = objayuda.objRow.Cells[0].Value.ToString();
                   
                    var _DataTable_2 = Deserialize(xwcf._GetData("", datarow), type);
                    //MessageBox.Show("_DataTable2: "+ _DataTable_2.ToString());
                    foreach (DataRow row in _DataTable_2.Rows)
                    {
                        string file = row.Field<string>(1);
                        MessageBox.Show("_DataTable: " + file);

                    }
                    MessageBox.Show("_DataTable.Count: " + datarow);

                   MessageBox.Show("_DataTable.Count: " + _DataTable_2.Rows.Count);  
                   //view_product view_Product = new view_product();
                    //view_product1.dataGridView1.DataSource = _DataTable_2;
                    tag_producto.Image = App.Properties.Resources.check;
                  

                }
                

            }
            else
            {
                tag_producto.Image = App.Properties.Resources.Webp_net_resizeimage__12_;

            }
            DataTable Deserialize(string _DataTable, Type type1)
            {

                Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();
                json.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
                json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
                json.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

                StringReader sr = new StringReader(_DataTable);
                Newtonsoft.Json.JsonTextReader reader = new JsonTextReader(sr);
                //object result = json.Deserialize(reader, valueType);
                var result = json.Deserialize(reader, type1);
                reader.Close();

                return (DataTable)result;
            }
            //try
            //{
            //
            //     
            //    command = new SqlCommand("Ayuda_producto", connection);
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.Clear();
            //    command.Parameters.AddWithValue("@id_producto", richTextBox1.Text);
            //    connection.Open();
            //    loDataReader = command.ExecuteReader();
            //    Busqueda objayuda = new Busqueda();
            //    objayuda.objDR = loDataReader;
            //    objayuda.ShowDialog(this);
            //    if (objayuda.objRow != null)
            //    {
            //        command = new SqlCommand("Seleccionar_UnProducto", connection);
            //        command.CommandType = CommandType.StoredProcedure;
            //        command.Parameters.Clear();
            //        command.Parameters.AddWithValue("@PROD_ID", objayuda.objRow.Cells[0].Value);
            //        loDataReader = command.ExecuteReader();
            //        if (loDataReader.HasRows)
            //        {
            //            MessageBox.Show("loDataReader");
            //            loDataReader.Read();
            //            //textBox1.Text = loDataReader.GetValue(loDataReader.GetOrdinal("id_prod")).ToString();
            //            //textBox2.Text = loDataReader.GetValue(loDataReader.GetOrdinal("name_product")).ToString();
            //        }
            //    }
            //     
            //
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    connection.Close();
            //}
            //
            //DialogResult result = MsgBox.Show("edit product ?", "id: " + 323, MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
            //
            //if (result == DialogResult.Yes)
            //{
            //    MessageBox.Show("Exiting now");
            //}
            //if (value.buttonResult == "edit")
            //{
            //    MessageBox.Show("edit");
            //}
            //if (value.buttonResult == "delete")
            //{
            //    MessageBox.Show("delete");
            //}
        }

        private void gestion_productos_Load(object sender, EventArgs e)
        {
            try
            {
                

                builder.DataSource = "srv-bd-sql-server.database.windows.net";
                builder.UserID = "edgar";
                builder.Password = "$E012345";
                builder.InitialCatalog = "miniMarket";
                builder.ConnectTimeout = 30;
                builder.Encrypt = true;

                connection = new SqlConnection(builder.ConnectionString);



                //command.Connection = connection;

              
                //   connection.Open();
                //
                //   String sql = "SELECT id_prod, name_product FROM producto";
                //
                //   using (command = new SqlCommand(sql, connection))
                //   {
                //       using (SqlDataReader reader = command.ExecuteReader())
                //       {
                //           if (reader.HasRows)
                //           {
                //               reader.Read();
                //               textBox1.Text = reader.GetValue(reader.GetOrdinal("id_prod")).ToString();
                //               textBox2.Text = reader.GetValue(reader.GetOrdinal("name_product")).ToString();
                //           }
                //       }
                //   }
                //
                //   connection.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void search_produ_Click(object sender, EventArgs e)
        {
            panel.Height = search_produ.Height;
            panel.Top = search_produ.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel.Height = button4.Height;
            panel.Top = button4.Top;
         }

        
        // con.ConnectionString = "Server=EDGAR;DataBase=Pachacamac_;Integrated Security=SSPI;";
        //
        // cmd.CommandType = CommandType.StoredProcedure;
        //
        // cmd.Connection = con;

    }
}
