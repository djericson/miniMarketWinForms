using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DAC;
using FormsApp;
namespace FormsApp
{
    public partial class FrmPedido : Form
    {
        string cantidad_total="";
        string StockMIn="";
        string StockMax="";


        

        public int ID_Usuario = FormMain.ID_Usuario;
        public string NameUsuario = FormMain.NameUsuario;
        public string NameRol = FormMain.NameRol;
        public int ID_Rol = FormMain.ID_Rol;


        #region OBJETO QUE ME HACE REFERENCIA  A LA CLASE FRMPEDIDO        1
        private static FrmPedido _instancia;
        #endregion
        #region METODO PARA CREAR INSTANCIA A FRMINGRESO                   2
        public static FrmPedido GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmPedido();//SOLO SE CREARA CUANDO NO EXISTA NINGUNA INSTANCIA
            }
            return _instancia;
        }
        #endregion
        private void FrmPedido_FormClosing(object sender, FormClosingEventArgs e) ////3
        {
            _instancia = null;
        }
        #region ESTABLECER VALORES DESDE VISTA PROVEEDOR Y VISTA PRODUCTO 4
        public void ControlesProveedor(string idproveedor, string nombre, string categoria, string paginaweb)
        {
            txtId_proveedor.Text = idproveedor;
            txtNombreProveedor.Text = nombre;
            txtCategoria.Text = categoria;
            txtPaginaWeb.Text = paginaweb;
        }


        public void ControlesProducto(string idproducto, string StockmIn, string Stockmax, string nombre, string marca,
           string cantidadtotal, string unidadProducto )
        {
            this.txtId_producto.Text = idproducto;
            this.StockMIn = StockmIn;
            this.StockMax = Stockmax;
            this.txtNombreProducto.Text = nombre;
            this.txtMarca.Text = marca;
            this.cantidad_total = cantidadtotal;
            this.txtProdUnidad.Text = unidadProducto;
            txtTotalProducto.Text = cantidadtotal;
        }
        #endregion

        ClsBL_Producto _objProducto;
        ClsBL_Pedido oBlPedido = new ClsBL_Pedido();
        ClsDAC_Pedidos oDacPedido = new ClsDAC_Pedidos();
        public int IdTrabajador = 4;
        private bool IsNuevo = true;
        private DataTable dtDetallePedido;
        private decimal totalPagado = 0; 

        public FrmPedido()
        {
            InitializeComponent();
            ttMensaje.SetToolTip(txtNombreProveedor, "SELECCIONE EL PROVEEDOR");
            ttMensaje.SetToolTip(txtStock, "INGRESE LA CANTIDAD");
            ttMensaje.SetToolTip(txtNombreProducto, "SELECCION EL PRODUCTO");
            //txtId_proveedor.Visible = false;
            //txtId_producto.Visible = false;
            //txtNombreProveedor.ReadOnly = true;
            //txtNombreProducto.ReadOnly = true;
            //txtPaginaWeb.ReadOnly = true;
            //txtCategoria.ReadOnly = true;
        }


        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de minimarket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de minimarket", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Limpiar()
        {
            //txtIdPedido.Text = string.Empty;
            //txtId_proveedor.Text = string.Empty;
            //txtPaginaWeb.Text = string.Empty;
            //txtNombreProveedor.Text = string.Empty;
            //txtCategoria.Text = string.Empty;
            //lblTotal_pagado.Text = "0,0";
            CrearTabla();
        }


        private void limpiarDetalle()
        {
            //txtId_producto.Text = string.Empty;
            //txtNombreProducto.Text = string.Empty;
            //txtStock.Text = string.Empty;
            //txtPrecioCompra.Text = string.Empty;
            //txtProdUnidad.Text = string.Empty;
        }


        private void HabilitarTxt(bool valor)
        {
            //txtIdPedido.ReadOnly = !valor;
            //txtPrecioCompra.ReadOnly = !valor;
            //txtProdUnidad.ReadOnly = !valor;
            //dtFecha.Enabled = valor;


            //btnBuscar_producto.Enabled = valor;
            //btnBuscar_proveedor.Enabled = valor;
            //btnAgregar.Enabled = valor;
            //btnQuitar.Enabled = valor;
        }

        private void Botones()
        {
            if (IsNuevo)
            {
                HabilitarTxt(true);
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                HabilitarTxt(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }


        private void OcultarColumnas()
        {
            dgvListado.Columns[0].Visible = false;//COLUMNA ELIMINAR(CHECBOX)
            dgvListado.Columns[1].Visible = false;//COLUMNA ID DE PEDIDO
        }
        private void Mostrar() //MUESTRA LOS PEDIDOS
        {
            dgvListado.DataSource = ClsBL_Pedido.MOSTRAR();
            OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dgvListado.Rows.Count);
        }
        private void BuscarFechas()
        {
            dgvListado.DataSource = oDacPedido.Buscar_fechas(dtFechaA.Value.ToString("dd/MM/yyyy"), dtFechaB.Value.ToString("dd/MM/yyyy"));
            OcultarColumnas();
            lblTotal.Text = "Total de registros " + Convert.ToString(dgvListado.Rows.Count);
        }
        private void MostrarDetalle() //MUESTRA LOS DETALLES DE UN UNICO INGRESO
        {
            dgvListado_detalle.DataSource = ClsBL_Pedido.MOSTRAR_DETALLE(txtIdPedido.Text);
        }
        private void FrmPedido_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            //MostrarDetalle();
            Mostrar();
            HabilitarTxt(true);
            //Botones();
            CrearTabla();
        }
        private void btnBuscar_proveedor_Click(object sender, EventArgs e)
        {
            FrmVistaProveedor obj = new FrmVistaProveedor();
            obj.ShowDialog();
        }
        private void btnBuscar_producto_Click(object sender, EventArgs e)
        {
            FrmVistaProducto obj = new FrmVistaProducto();
            obj.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarFechas();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea Anular el pedido", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = ClsBL_Pedido.ANULAR(Convert.ToInt32(Codigo));
                            ClsBL_Pedido o = new ClsBL_Pedido();
                            if (Rpta.Equals("OK"))
                            {
                                MensajeOk("SE ANULO CORRECTAMENTE EL ´PEDIDO");
                            }
                            else
                            {
                                MensajeError(Rpta);
                            }
                        }
                    }
                }
                chkGestion.Checked = false;
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkGestion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGestion.Checked)
            {
                dgvListado.Columns[0].Visible = true;
            }
            else
            {
                dgvListado.Columns[0].Visible = false;
            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            if (e.ColumnIndex == dgvListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkGestion = (DataGridViewCheckBoxCell)dgvListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkGestion.Value = !Convert.ToBoolean(chkGestion.Value);
            }
        }
        private void CrearTabla()
        {
            dtDetallePedido = new DataTable("Detalle");
            dtDetallePedido.Columns.Add("Id_Producto", System.Type.GetType("System.Int32"));
            dtDetallePedido.Columns.Add("Nombre_Proveedor", System.Type.GetType("System.String"));
            dtDetallePedido.Columns.Add("Nombre_Producto", System.Type.GetType("System.String"));
            dtDetallePedido.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            dtDetallePedido.Columns.Add("Categoria", System.Type.GetType("System.String"));
            dtDetallePedido.Columns.Add("Precio_Compra", System.Type.GetType("System.Decimal"));
            dtDetallePedido.Columns.Add("Unidad_Producto", System.Type.GetType("System.String"));
            dtDetallePedido.Columns.Add("SubTotal", System.Type.GetType("System.Decimal"));
            dgvListado_detalle.DataSource = dtDetallePedido;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IsNuevo = true;
            Botones();
            Limpiar();
            HabilitarTxt(true);
            txtStock.Focus();
            limpiarDetalle();          // ----PRUEBA
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IsNuevo = false;
            Botones();
            Limpiar();
            HabilitarTxt(false);
            limpiarDetalle();  //PRUEBA
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                
                if (txtId_proveedor.Text == string.Empty || txtPrecioCompra.Text == string.Empty || txtStock.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(txtId_proveedor, "Ingrese un Valor");
                    errorIcono.SetError(txtPrecioCompra, "Ingrese un Valor");
                    errorIcono.SetError(txtStock, "Ingrese un Valor");
                }
                else
                {
                    if (IsNuevo)
                    {
                        rpta = ClsBL_Pedido.INSERTAR(Convert.ToInt32(txtId_proveedor.Text), IdTrabajador, dtFecha.Value, "GENERADO",dtDetallePedido);
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (IsNuevo)
                        {
                            MensajeOk("Se inserto de forma correcta el pedido");
                        }
                    }
                    else
                    {
                        MensajeError(rpta);
                    }
                    IsNuevo = false; 
                    Botones();
                    Limpiar();
                    limpiarDetalle();//PRUEBA
                    Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace); 
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {                
                if (txtId_producto.Text == string.Empty || txtStock.Text == string.Empty || txtPrecioCompra.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(txtId_producto, "Ingrese un Valor");
                    errorIcono.SetError(txtStock, "Ingrese un Valor");
                    errorIcono.SetError(txtPrecioCompra, "Ingrese un Valor");
                }
                else
                {
                    bool registrar = true;
                    foreach (DataRow row in dtDetallePedido.Rows)
                    {
                        if (Convert.ToInt32(row["Id_producto"]) == Convert.ToInt32(txtId_producto.Text))
                        {
                            registrar = false;
                            MensajeError("Este producto ya fue agregado a la lista");
                        }
                    }
                    if (registrar)
                    {
                        decimal subtotal = Convert.ToDecimal(txtStock.Text) * Convert.ToDecimal(txtPrecioCompra.Text);
                        totalPagado = totalPagado + subtotal;
                        lblTotal_pagado.Text = Convert.ToString(totalPagado);                        
                        DataRow row = dtDetallePedido.NewRow();
                        row["Id_Producto"] = Convert.ToInt32(txtId_producto.Text);
                        row["Nombre_Proveedor"] =txtNombreProveedor.Text;
                        row["Nombre_Producto"] =txtNombreProducto.Text;
                        row["Cantidad"] = Convert.ToInt32(txtStock.Text);
                        row["Categoria"] =txtCategoria.Text;
                        row["Precio_Compra"] = Convert.ToDecimal(txtPrecioCompra.Text);
                        row["Unidad_Producto"] = txtProdUnidad.Text;
                        row["SubTotal"] = subtotal;
                        dtDetallePedido.Rows.Add(row);
                        limpiarDetalle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace); // Nos muestra el posible error.
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {   
                int indiceFila = dgvListado_detalle.CurrentCell.RowIndex; 
                DataRow row = dtDetallePedido.Rows[indiceFila];
              
                totalPagado = totalPagado - (Convert.ToDecimal(row["SubTotal"].ToString()));
                lblTotal_pagado.Text = Convert.ToString(totalPagado);                                                                    
                dtDetallePedido.Rows.Remove(row);
            }
            catch (Exception)
            {
                MensajeError("La lista esta vacia");
            }
        }

        private void dgvListado_detalle_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            txtIdPedido.Text = Convert.ToString(dgvListado.CurrentRow.Cells["id_pedido"].Value);
            txtNombreProveedor.Text = Convert.ToString(dgvListado.CurrentRow.Cells["PROVEEDOR"].Value);
            dtFecha.Value = Convert.ToDateTime(dgvListado.CurrentRow.Cells["FECHA_PEDIDO"].Value);
            lblTotal_pagado.Text = Convert.ToString(dgvListado.CurrentRow.Cells["total"].Value);
            MostrarDetalle();
        }
    }
}
