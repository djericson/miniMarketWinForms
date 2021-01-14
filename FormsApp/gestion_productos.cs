using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using App.UserControl_to_gestion_productos;
using FormsApp.WCF_Productos;
using Newtonsoft.Json;
using NS_Busqueda;

namespace App
{
    public partial class gestion_productos : Form
    {
        DataSet _dataSet = new DataSet();
        static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        static SqlConnection connection = new SqlConnection();
        static SqlCommand command = new SqlCommand();
        static string datarow;
        FormsApp.WCF_Productos.ProductosClient objwcf = new FormsApp.WCF_Productos.ProductosClient();

        public gestion_productos()
        {
            InitializeComponent();

            update_product2.BringToFront();

        }

        private void buscar_producto_Click(object sender, EventArgs e)
        {


            
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
         

        private void gestion_productos_Load(object sender, EventArgs e)
        {
            try
            {
                

                //builder.DataSource = "srv-bd-sql-server.database.windows.net";
                //builder.UserID = "edgar";
                //builder.Password = "$E012345";
                //builder.InitialCatalog = "miniMarket";
                //builder.ConnectTimeout = 30;
                //builder.Encrypt = true;

                //connection = new SqlConnection(builder.ConnectionString);



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
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
         }
        


        
        private void BtnAyuda_Click(object sender, EventArgs e)
        {

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var _DataSet = objwcf._GetData(richTextBox1.Text, "");
            Type type = _dataSet.GetType();

            if (_DataSet != null)
            {
                var dataset = Deserialize(_DataSet, type);
                Busqueda objayuda = new Busqueda();
                objayuda.objTabla = dataset.Tables["list_productos"];
                objayuda.ShowDialog(this);
                if (objayuda.objRow != null)
                {
                    datarow = objayuda.objRow.Cells[0].Value.ToString();

                    var DataSet_2 = Deserialize(objwcf._GetData("", datarow), type);
                    dataGridView1.DataSource = DataSet_2.Tables["producto"];

                    //double value = double.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString());
                    //dataGridView1.Rows[0].Cells[4].Value = value;

                    //var dgTextBoxCol = new DataGridViewTextBoxColumn();
                    //dgTextBoxCol.Name = "yourColumnName";
                    //dgTextBoxCol.DefaultCellStyle.Format = "N2";

                    //dataGridView1.Rows[0].DefaultCellStyle.Format = "N2";



                    //dataGridView1.Columns[4].DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Underline);
                    dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 10);
 

                    //dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
                    //dataGridView1.Columns[8].DefaultCellStyle.Format = "N2";
                    //dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Blue;

                    // Set column widths.
                    dataGridView1.AutoResizeColumns();

                    // Do not allow automatic editing.
                    //dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;

                    //update_product2.categoria.DataSource = DataSet_2.Tables["categorias"]; ;
                    //update_product2.categoria.DisplayMember = "nombre";
                    //update_product2.categoria.ValueMember = "id_categoria";

                    
                    tag_producto.Image = FormsApp.Properties.Resources.Webp_net_resizeimage__13_;


                }


            }
            else
            {
                tag_producto.Image = FormsApp.Properties.Resources.Webp_net_resizeimage__12_;

            }

        }
        DataSet Deserialize(string DataTable, Type type1)
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

            return (DataSet)result;
        }
        private void gestion_productos_Load_1(object sender, EventArgs e)
        {
            Type type = _dataSet.GetType();
            var DataSet_2 = Deserialize(objwcf._GetData("", "0"), type);
            update_product2.categoria.DataSource = DataSet_2.Tables["categorias"]; ;
            update_product2.categoria.DisplayMember = "nombre";
            update_product2.categoria.ValueMember = "id_categoria";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("_DataTable.Count: ");
            
            int rowIndex = e.RowIndex;
            update_product2.name_producto.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            update_product2.categoria.SelectedValue = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[13].Value.ToString());
            update_product2.marca.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            update_product2.presio_promdio.Value = Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells[4].Value.ToString());
            update_product2.cantida_total.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            update_product2.descripcion.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            update_product2.unidad_produc.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            update_product2.presio_promed_dpt.Value = Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells[8].Value.ToString());
            update_product2.cantida_produ_venta.Text = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
            update_product2.fecha_ingreso_stock.Value = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells[10].Value.ToString());
            update_product2.fecha_fabricacion.Value = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells[11].Value.ToString());
            update_product2.fecha_vencimiento.Value = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells[12].Value.ToString());
            //var date1 = Convert.ToDateTime(objDataReader.GetValue(objDataReader.GetOrdinal("COPR_FECHA")).ToString());
            //update_product2.fecha_ingreso_stock.Text = dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
            //update_product2.fecha_fabricacion.Text = dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
            //update_product2.fecha_vencimiento.Text = dataGridView1.Rows[rowIndex].Cells[12].Value.ToString();


          
                //MessageBox.Show("update "+i);


        }

         

        private void button1_Click(object sender, EventArgs e)
        {

            update_product2.name_producto.Text = "";
            update_product2.marca.Text = "";
            update_product2.presio_promdio.Text = "";
            update_product2.cantida_total.Text = "";
            update_product2.descripcion.Text = "";
            update_product2.unidad_produc.Text = "";
            update_product2.presio_promed_dpt.Text = "";
            update_product2.cantida_produ_venta.Text = "";
          
        }

        private void update_Click(object sender, EventArgs e)
        {
            ////dataGridView1.CurrentRow.Cells[0].Value.ToString();
           
           
        
              ClsProducto objProducto = new ClsProducto();
            objProducto.id = Convert.ToInt32(datarow);
            objProducto.name = update_product2.name_producto.Text;  
            objProducto.id_categoria = Convert.ToInt32(update_product2.categoria.SelectedValue);
            objProducto.marca = update_product2.marca.Text;
            objProducto.presio_prome = update_product2.presio_promdio.Value;
            objProducto.cantida_total = Convert.ToInt32(update_product2.cantida_total.Text);
            objProducto.descripcion = update_product2.descripcion.Text;
            objProducto.unida_product = update_product2.unidad_produc.Text;
            objProducto.id_producto_detalle = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            objProducto.presio_prome_detalle = update_product2.presio_promed_dpt.Value;
            objProducto.cantidad_producto_venta = Convert.ToInt32(update_product2.cantida_produ_venta.Text);
            objProducto.stock_entry_date = update_product2.fecha_ingreso_stock.Value;
            objProducto.fabrication_date = update_product2.fecha_fabricacion.Value;
            objProducto.expiration_date = update_product2.fecha_vencimiento.Value;
            objwcf.update_producto(objProducto);

            //MessageBox.Show("update " );
            Type type = _dataSet.GetType();
            var DataSet_2 = Deserialize(objwcf._GetData("", datarow), type);
            dataGridView1.DataSource = DataSet_2.Tables["producto"];
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ClsProducto objProducto = new ClsProducto();
            objProducto.id = Convert.ToInt32(datarow);
            objProducto.id_producto_detalle = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            objwcf.delete_producto(objProducto);


            Type type = _dataSet.GetType();
            var DataSet_2 = Deserialize(objwcf._GetData("", datarow), type);
            dataGridView1.DataSource = DataSet_2.Tables["producto"];
        }

        private void add_producto_Click(object sender, EventArgs e)
        {
            ClsProducto objProducto = new ClsProducto();
            objProducto.id = Convert.ToInt32(datarow);
            objProducto.name = update_product2.name_producto.Text;
            objProducto.id_categoria = Convert.ToInt32(update_product2.categoria.SelectedValue);
            objProducto.marca = update_product2.marca.Text;
            objProducto.presio_prome = update_product2.presio_promdio.Value;
            objProducto.cantida_total = Convert.ToInt32(update_product2.cantida_total.Text);
            objProducto.descripcion = update_product2.descripcion.Text;
            objProducto.unida_product = update_product2.unidad_produc.Text;
            //objProducto.id_producto_detalle = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            objProducto.presio_prome_detalle = update_product2.presio_promed_dpt.Value;
            objProducto.cantidad_producto_venta = Convert.ToInt32(update_product2.cantida_produ_venta.Text);
            objProducto.stock_entry_date = update_product2.fecha_ingreso_stock.Value;
            objProducto.fabrication_date = update_product2.fecha_fabricacion.Value;
            objProducto.expiration_date = update_product2.fecha_vencimiento.Value;
            int out_id = objwcf.insert_producto(objProducto);

            Type type = _dataSet.GetType();
            var DataSet_2 = Deserialize(objwcf._GetData("", out_id.ToString()), type);
            dataGridView1.DataSource = DataSet_2.Tables["producto"];
        }

        //private void producto_Click(object sender, EventArgs e)
        //{
        //    update_product2.BringToFront();
        //}

        //private void producto_det_Click(object sender, EventArgs e)
        //{
        //    product_det1.BringToFront();
        //}
    }
}
 
