using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using FormsApp;

//using App.UserControl_to_gestion_productos;
using FormsApp.WCF_Productos;
using Newtonsoft.Json;
using NS_Busqueda;

namespace NS_WinFormsApps
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

            //update_product2.BringToFront();

        }

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

                    list_productos.Rows.Clear();
                    var DataSet_2 = Deserialize(objwcf._GetData("", datarow), type);
                    var Table_detalle = DataSet_2.Tables["producto_det"];
                    var  Table_producto = DataSet_2.Tables["producto"];
                    //list_productos.DataSource = dataTable;

                    numero_producto.Text = Table_producto.Rows[0]["numero_cab"].ToString();
                    richTextBox1.Text = Table_producto.Rows[0]["nombre"].ToString();
                    categoria.Text = Table_producto.Rows[0]["categoria"].ToString();
                    marca.Text =  Table_producto.Rows[0]["marca"].ToString();
                    presio_promdio.Value = Convert.ToDecimal(Table_producto.Rows[0]["precio_promedio"].ToString());

                   cantida_total.Text =  Table_producto.Rows[0]["cantidad_total"].ToString();
                    descripcion.Text = Table_producto.Rows[0]["descripcion"].ToString();
                    unidad_produc.Text = Table_producto.Rows[0]["und_prod"].ToString();


                    try
                    {
                        foreach (DataRow dataRow in Table_detalle.Rows)
                        {
                            if (dataRow != null)
                            {
                                list_productos.Rows.Add(dataRow["id_det_prod"], Convert.ToDecimal(dataRow["precio_prod"].ToString()), dataRow["cant_prods_vta"], dataRow["fch_ingr_stock"], dataRow["fch_fab_prod"], dataRow["fch_Vec_prod"]);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }
                    

                    ////double value = double.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString());
                    ////dataGridView1.Rows[0].Cells[4].Value = value;

                    ////var dgTextBoxCol = new DataGridViewTextBoxColumn();
                    ////dgTextBoxCol.Name = "yourColumnName";
                    ////dgTextBoxCol.DefaultCellStyle.Format = "N2";

                    ////dataGridView1.Rows[0].DefaultCellStyle.Format = "N2";

                    ////string.IsNullOrEmpty(dt.Rows[x][i].ToString();

                    ////var col = dataGridView1.Columns.Count;
                    ////foreach (DataGridViewRow i in dataGridView1.Rows)
                    ////{
                    ////    for(int x = 0; x < col; x++)
                    ////    {
                    ////        if(string.IsNullOrEmpty(i.Cells[x].ToString()))
                    ////        {
                    ////            i.Cells[x].Value = "blank";
                    ////            MessageBox.Show("_DataTable.Count: ");
                    ////        }
                    ////        MessageBox.Show("_DataTable.Count: ");
                    ////        //string.IsNullOrEmpty((string)i.Field<object>("sd"));
                    ////        //dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                    ////    }
                    ////}



                    ////dataGridView1.Columns[4].DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Underline);
                    //dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 10);
                    ////dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;

                    ////dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
                    ////dataGridView1.Columns[8].DefaultCellStyle.Format = "N2";
                    ////dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Blue;

                    //// Set column widths.
                    //dataGridView1.AutoResizeColumns();

                    //// Do not allow automatic editing.
                    ////dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                    //dataGridView1.AllowUserToAddRows = false;
                    //dataGridView1.AllowUserToDeleteRows = false;

                    //update_product2.categoria.DataSource = DataSet_2.Tables["categorias"]; ;
                    //update_product2.categoria.DisplayMember = "nombre";
                    //update_product2.categoria.ValueMember = "id_categoria";


                    //tag_producto.Image = FormsApp.Properties.Resources.Webp_net_resizeimage__13_;


                }


            }
            else
            {
                //tag_producto.Image = FormsApp.Properties.Resources.Webp_net_resizeimage__12_;

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
            list_productos.Columns.Clear();
            list_productos.Columns.Add("id_det_prod", "Codigo det"); 
            list_productos.Columns.Add("precio_prod", "presio promedio det");
            list_productos.Columns.Add("cant_prods_vta", "cantidad prod venta");
            list_productos.Columns.Add("fch_ingr_stock", "fecha ingreso stock");
            list_productos.Columns.Add("fch_fab_prod", "fecha fabricacion");
            list_productos.Columns.Add("fch_Vec_prod", "fecha vencimiento");
            list_productos.Rows.Clear();

             


            Type type = _dataSet.GetType();
            var DataSet_2 = Deserialize(objwcf._GetData("", "0"), type);
            categoria.DataSource = DataSet_2.Tables["categorias"]; ;
            categoria.DisplayMember = "nombre";
            categoria.ValueMember = "id_categoria";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("_DataTable.Count: ");
            
            int rowIndex = e.RowIndex;
            //update_product2.name_producto.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            //update_product2.categoria.SelectedValue = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[13].Value.ToString());
            //update_product2.marca.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            //update_product2.presio_promdio.Value = Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells[4].Value.ToString());
            //update_product2.cantida_total.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            //update_product2.descripcion.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            //update_product2.unidad_produc.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();


            //update_product2.presio_promed_dpt.Value = Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells[8].Value.ToString());
            //update_product2.cantida_produ_venta.Text = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
            //update_product2.fecha_ingreso_stock.Value = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells[10].Value.ToString());
            //update_product2.fecha_fabricacion.Value = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells[11].Value.ToString());
            //update_product2.fecha_vencimiento.Value = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells[12].Value.ToString());
         



          
              



        }

         

        private void button1_Click(object sender, EventArgs e)
        {

            //update_product2.name_producto.Text = "";
            //update_product2.marca.Text = "";
            //update_product2.presio_promdio.Text = "";
            //update_product2.cantida_total.Text = "";
            //update_product2.descripcion.Text = "";
            //update_product2.unidad_produc.Text = "";


            //update_product2.presio_promed_dpt.Text = "";
            //update_product2.cantida_produ_venta.Text = "";
          
        }

        private void update_Click(object sender, EventArgs e)
        {
        
            ClsProducto objProducto = new ClsProducto();
            objProducto.id = Convert.ToInt32(numero_producto.Text);
            objProducto.name = richTextBox1.Text;
            objProducto.id_categoria = Convert.ToInt32(categoria.SelectedValue);
            objProducto.marca = marca.Text;
            objProducto.presio_prome = Convert.ToDecimal(presio_promdio.Value);
            objProducto.cantida_total = Convert.ToInt32(cantida_total.Text);
            objProducto.descripcion = descripcion.Text;
            objProducto.unida_product = unidad_produc.Text;

            string XmlPut = "";
            foreach (DataGridViewRow DataRow in list_productos.Rows)
            {

               XmlPut = XmlPut + "<row precio_prod=\"" + Convert.ToDecimal(DataRow.Cells["precio_prod"].Value) +
                                  "\" cant_prods_vta=\"" + DataRow.Cells["cant_prods_vta"].Value +
                                  "\" fch_ingr_stock=\"" + Convert.ToDateTime(DataRow.Cells["fch_ingr_stock"].Value).ToString("yyyy-M-dd ") +
                                  "\" fch_fab_prod=\"" + Convert.ToDateTime(DataRow.Cells["fch_fab_prod"].Value).ToString("yyyy-M-dd ") +
                                  "\" fch_Vec_prod=\"" + Convert.ToDateTime(DataRow.Cells["fch_Vec_prod"].Value).ToString("yyyy-M-dd ") + "\"></row>\n";

            }


            objwcf.update_producto(objProducto, XmlPut);

            MessageBox.Show("reguistro actualizado");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ClsProducto objProducto = new ClsProducto();
            objProducto.id = Convert.ToInt32(numero_producto.Text);
            objwcf.delete_producto(objProducto);
            list_productos.Rows.Clear();
            MessageBox.Show("reguistro eliminado");
        }

        private void add_producto_Click(object sender, EventArgs e)
        {
            ClsProducto objProducto = new ClsProducto();
            //objProducto.id = Convert.ToInt32(datarow);
            objProducto.name = richTextBox1.Text;
            objProducto.id_categoria = Convert.ToInt32(categoria.SelectedValue);
            objProducto.marca = marca.Text;
            objProducto.presio_prome = Convert.ToDecimal(presio_promdio.Value);
            objProducto.cantida_total = Convert.ToInt32(cantida_total.Text);
            objProducto.descripcion = descripcion.Text;
            objProducto.unida_product = unidad_produc.Text;
            //objProducto.id_producto_detalle = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            string XmlPut = "";
            foreach (DataGridViewRow DataRow in list_productos.Rows)
            {
               
                XmlPut = XmlPut + "<row precio_prod=\"" + Convert.ToDecimal(DataRow.Cells["precio_prod"].Value) +
                                  "\" cant_prods_vta=\"" + DataRow.Cells["cant_prods_vta"].Value +
                                  "\" fch_ingr_stock=\"" + Convert.ToDateTime(DataRow.Cells["fch_ingr_stock"].Value.ToString()).ToString("yyyy-M-dd") +
                                  "\" fch_fab_prod=\"" + Convert.ToDateTime(DataRow.Cells["fch_fab_prod"].Value.ToString()).ToString("yyyy-M-dd") +
                                  "\" fch_Vec_prod=\"" + Convert.ToDateTime(DataRow.Cells["fch_Vec_prod"].Value.ToString()).ToString("yyyy-M-dd") + "\"></row>\n";
              
            }

            //MessageBox.Show("stock_entry_date: " + Convert.ToDateTime(list_productos.CurrentRow.Cells["stock_entry_date"].Value).ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
            //MessageBox.Show("stock_entry_date: " + Convert.ToDateTime(list_productos.CurrentRow.Cells["stock_entry_date"].Value).ToShortDateString());
            int out_id = objwcf.insert_producto(objProducto, XmlPut);

            MessageBox.Show("reguistro insertado");
        }

        private void produc_cabe_Click(object sender, EventArgs e)
        {
            //update_product2.BringToFront();
        }

        private void product_det_Click(object sender, EventArgs e)
        {
            //product_det2.BringToFront();
        }

        private void agregar_datagridview_Click(object sender, EventArgs e)
        {

            list_productos.Rows.Add("",presio_promed_dpt.Value, cantida_produ_venta.Text, fecha_ingreso_stock.Value, fecha_fabricacion.Value, fecha_vencimiento.Value);
        }

        private void update_datagridview_Click(object sender, EventArgs e)
        {
            list_productos.CurrentRow.Cells["precio_prod"].Value = presio_promed_dpt.Value;
            list_productos.CurrentRow.Cells["cant_prods_vta"].Value = cantida_produ_venta.Text;
            list_productos.CurrentRow.Cells["fch_ingr_stock"].Value = fecha_ingreso_stock.Value;
            list_productos.CurrentRow.Cells["fch_fab_prod"].Value = fecha_fabricacion.Value;
            list_productos.CurrentRow.Cells["fch_Vec_prod"].Value = fecha_vencimiento.Value;
        }

        private void delete_datagridview_Click(object sender, EventArgs e)
        {
            list_productos.Rows.Remove(list_productos.CurrentRow);
        }

        private void list_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("stock_ent"+ Convert.ToDecimal(list_productos.CurrentRow.Cells["precio_prod"].Value));

           presio_promed_dpt.Value = Convert.ToDecimal(list_productos.CurrentRow.Cells["precio_prod"].Value);
            cantida_produ_venta.Text = list_productos.CurrentRow.Cells["cant_prods_vta"].Value.ToString();
            fecha_ingreso_stock.Value = (DateTime)list_productos.CurrentRow.Cells["fch_ingr_stock"].Value ;
            fecha_fabricacion.Value = (DateTime)list_productos.CurrentRow.Cells["fch_fab_prod"].Value;
            fecha_vencimiento.Value = (DateTime)list_productos.CurrentRow.Cells["fch_Vec_prod"].Value;

        }

        

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("stock_entry_datessss: " + DateTime.Parse(list_productos.CurrentRow.Cells["fch_ingr_stock"].Value.ToString()).ToString("yyyy-M-dd hh:mm:ss"));
            MessageBox.Show("stock_entry_date: " + Convert.ToDateTime(list_productos.CurrentRow.Cells["fch_ingr_stock"].Value).ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
            MessageBox.Show("stock_entry_date: " + Convert.ToDateTime(list_productos.CurrentRow.Cells["fch_ingr_stock"].Value).ToShortDateString());
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Close();
        }


        private void Vista_Todos_los_Productos_Click(object sender, EventArgs e)
        {

        }

        private void Vista_Producto_det_Click(object sender, EventArgs e)
        {

        }
    }



}
 
