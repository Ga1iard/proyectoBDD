using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace negocioPapeleria
{
    public partial class FrmRegistrarVentas : Form
    {
    
        public static List<string> listaNombresProductos = new List<string>();
        public static List<string> listaTiposProductos = new List<string>();
        public static List<float> listaPrecios = new List<float>();
        public static List<int> listaCantidadProductos = new List<int>();
        
        conexionSQLServer conn;

        public FrmRegistrarVentas()
        {
            InitializeComponent();

            conn = new conexionSQLServer();

            pnlFacturas.Visible = false;


            //dgvMostrarDatos.CellMouseMove += dgvMostrarDatos_CellMouseMove;
            //PersonalizarDgvMostrarDatos();

        }

        // Llenar el ComboBox de Productos
        private void LlenarCMBProducto()
        {
            string consultaProducto = "SELECT nombre_prod FROM Productos";

            cmbNombreProducto.Items.Clear();

            conn.AbrirConexion();

            try
            {
                SqlCommand comando = new SqlCommand(consultaProducto, conn.GetConnection());
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    cmbNombreProducto.Items.Add(reader["nombre_prod"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el ComboBox de productos: {ex.Message}");
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        // Llenar el ComboBox de Clientes
        private void LlenarCMBCliente()
        {
            string consultaCliente = "SELECT nombre_cli + ' ' + apellido_cli AS nombre_completo FROM Clientes";

            cmbNombreCliente.Items.Clear();

            conn.AbrirConexion();

            try
            {
                SqlCommand comando = new SqlCommand(consultaCliente, conn.GetConnection());
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    cmbNombreCliente.Items.Add(reader["nombre_completo"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el ComboBox de clientes: {ex.Message}");
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        // Llenar el ComboBox de Empleados
        private void LlenarCMBEmpleado()
        {
            string consultaEmpleado = "SELECT nombre FROM Empleados";

            cmbNombreEmpleado.Items.Clear();

            conn.AbrirConexion();

            try
            {
                SqlCommand comando = new SqlCommand(consultaEmpleado, conn.GetConnection());
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    cmbNombreEmpleado.Items.Add(reader["nombre"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el ComboBox de empleados: {ex.Message}");
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        // Para llenar el ComboBox de Sucursales
        private void LlenarCMBSucursal()
        {
            string consultaSucursal = "SELECT ciudad FROM Sucursales";

            cmbSucursal.Items.Clear();

            conn.AbrirConexion();

            try
            {
                SqlCommand comando = new SqlCommand(consultaSucursal, conn.GetConnection());
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    cmbSucursal.Items.Add(reader["ciudad"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el ComboBox de sucursales: {ex.Message}");
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        private void ConsultarPrecioProducto()
        {
            //string consultaPrecio = $"SELECT precio_producto FROM productos WHERE nombre_producto = '{nombreProducto}' AND id_tipo = {idTipo}";

            //try
            //{
            //    conn.AbrirConexion();

            //    using (NpgsqlCommand command = new NpgsqlCommand(consultaPrecio, conn.GetConnection()))
            //    {
            //        object precio = command.ExecuteScalar();
            //        precioProducto = Convert.ToString(precio);
            //        Console.Write("precioProducto: " + precioProducto);
            //    }

            //    hayNombreProducto = true;
            //    Console.WriteLine("Si hay nombre producto " + hayNombreProducto);
            //}
            //catch (Exception)
            //{
            //    hayNombreProducto = false;
            //    Console.WriteLine("No hay nombre producto " + hayNombreProducto);

            //}

            //Console.WriteLine(consultaPrecio);
        }
        private void ConsultarIdVenta()
        {
            //conn.AbrirConexion();

            //string consultaVenta = "SELECT id_venta FROM ventas ORDER BY id_venta DESC LIMIT 1";

            //using (NpgsqlCommand command = new NpgsqlCommand(consultaVenta, conn.GetConnection()))
            //{
            //    object idVenta = command.ExecuteScalar();
            //    idVentaSeleccionada = idVenta.ToString();
            //    Console.Write("idVentaSeleccionada: " + idVentaSeleccionada);
            //}
        }
        private void ConsultarIdProducto()
        {
            //conn.AbrirConexion();

            //string consultaVenta = $"SELECT id_producto FROM productos WHERE nombre_producto = '{nombreProducto}' AND id_tipo = {idTipo}";

            //using (NpgsqlCommand command = new NpgsqlCommand(consultaVenta, conn.GetConnection()))
            //{
            //    try
            //    {
            //        object idProductoObtenido = command.ExecuteScalar();
            //        idProducto = idProductoObtenido.ToString();
            //        Console.Write("idProducto: " + idProducto);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Error en consultar ID producto " + ex);
            //    }
            //}
        }



        private void ObtenerDatosDelMenu(int categoria)
        {
            
        }


        /*  
         *  -------------------------------------------------------------------------
         *  EN ESTOS MÉTODOS ÚNICAMENTE SE HACEN COSAS RELACIONADAS AL DATA GRID VIEW
         *  -------------------------------------------------------------------------
         */

        //private void PersonalizarDgvMostrarDatos()
        //{
        //    //Tabla Productos
        //    dgvMostrarDatos.Columns.Add("id_venta", "ID Venta");
        //    dgvMostrarDatos.Columns.Add("nombre_producto", "Nombre Producto");
        //    dgvMostrarDatos.Columns.Add("cantidad", "Cantidad");
        //    dgvMostrarDatos.Columns.Add("fecha_venta", "Fecha Venta");

        //    dgvMostrarDatos.RowHeadersVisible = false;

        //    dgvMostrarDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 9);
        //    dgvMostrarDatos.DefaultCellStyle.Font = new Font("Cambria", 9);

        //    dgvMostrarDatos.DefaultCellStyle.BackColor = Color.FromArgb(214, 215, 217);
        //    dgvMostrarDatos.DefaultCellStyle.ForeColor = Color.Black;

        //    dgvMostrarDatos.EnableHeadersVisualStyles = false;
        //    dgvMostrarDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(93, 183, 185);
        //    dgvMostrarDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

        //    dgvMostrarDatos.Columns[0].Width = 77;
        //    dgvMostrarDatos.Columns[1].Width = 205;
        //    dgvMostrarDatos.Columns[2].Width = 63;
        //    dgvMostrarDatos.Columns[3].Width = 94;

        //    dgvMostrarDatos.ReadOnly = true;
        //}

        //private void LlenarDgvMostrarDatos()
        //{
        //    dgvMostrarDatos.Rows.Clear();

        //    conn.AbrirConexion();

        //    string obtenerDatosProducto = $"SELECT v.id_venta, p.nombre_producto, dv.cantidad, v.fecha_venta " +
        //        $"FROM ventas v " +
        //        $"INNER JOIN detalle_ventas dv ON v.id_venta = dv.id_venta " +
        //        $"INNER JOIN productos p ON dv.id_producto = p.id_producto " +
        //        $"INNER JOIN categorias c ON p.id_categoria = c.id_categoria " +
        //        $"WHERE c.id_categoria = {categoriaElegida} ORDER BY fecha_venta DESC";

        //    int idVenta = 0;
        //    string nombreProducto = "";
        //    int cantidad = 0;
        //    DateTime fechaVenta;

        //    try
        //    {
        //        using (NpgsqlCommand command = new NpgsqlCommand(obtenerDatosProducto, conn.GetConnection()))
        //        {
        //            using (NpgsqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    idVenta = reader.GetInt32(0);
        //                    nombreProducto = reader.GetString(1);
        //                    cantidad = reader.GetInt32(2);
        //                    fechaVenta = reader.GetDateTime(3);

        //                    Console.WriteLine(idVenta);
        //                    Console.WriteLine(nombreProducto);
        //                    Console.WriteLine(cantidad);
        //                    Console.WriteLine(fechaVenta);

        //                    string fechaFormateada = fechaVenta.ToString("yyyy-MM-dd");

        //                    dgvMostrarDatos.Rows.Add(idVenta, nombreProducto, cantidad, fechaFormateada);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Ejecución finalizada");
        //    }
        //}

        //private void dgvMostrarDatos_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        dgvMostrarDatos.Cursor = Cursors.Hand;
        //        dgvMostrarDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(217, 237, 237);
        //    }
        //    else
        //    {
        //        dgvMostrarDatos.Cursor = Cursors.Default;
        //        // Verifica si e.RowIndex es mayor o igual a 0 antes de cambiar el estilo de la fila
        //        if (e.RowIndex >= 0)
        //        {
        //            dgvMostrarDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(214, 215, 217);
        //        }
        //    }
        //}

        //private void dgvMostrarDatos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        dgvMostrarDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(214, 215, 217);
        //    }
        //}

        //private void dgvMostrarDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if (e.RowIndex >= 0)
        //        {
        //            string idVenta = dgvMostrarDatos.Rows[e.RowIndex].Cells["id_venta"].Value.ToString();
        //            string nombreProductoSeleccionado = dgvMostrarDatos.Rows[e.RowIndex].Cells["nombre_producto"].Value.ToString();
        //            string cantidadSeleccionada = dgvMostrarDatos.Rows[e.RowIndex].Cells["cantidad"].Value.ToString();

        //            dgvMostrarDatos[e.ColumnIndex, e.RowIndex].Tag = new { idVenta, nombreProductoSeleccionado, cantidadSeleccionada };
        //            idVentaSeleccionada = idVenta;
        //            nombreProducto = nombreProductoSeleccionado;
        //            cantidadProducto = int.Parse(cantidadSeleccionada);

        //            string consultaIdTipo = $"SELECT p.id_tipo FROM detalle_ventas dv " +
        //            $"INNER JOIN productos p ON dv.id_producto = p.id_producto " +
        //            $"WHERE dv.id_venta = {idVentaSeleccionada} AND p.nombre_producto = '{nombreProducto}' AND dv.cantidad = {cantidadProducto}";

        //            using (NpgsqlCommand command = new NpgsqlCommand(consultaIdTipo, conn.GetConnection()))
        //            {
        //                object idTipoSeleccionado = command.ExecuteScalar();
        //                string idTipoTemporal = idTipoSeleccionado.ToString();
        //                idTipo = int.Parse(idTipoTemporal);
        //                Console.Write("idTipo: " + idTipo);
        //            }

        //            Console.WriteLine($"ID Venta: {idVentaSeleccionada}, Producto: {nombreProducto}, Cantidad: {cantidadProducto}, ID Tipo: {idTipo}");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        /*
         * -------------------------------------------------------------------------
         *              AQUÍ TERMINAN LOS MÉTODOS DEL DATA GRID VIEW
         * -------------------------------------------------------------------------
         */

        private void CambiarColorPaneles_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.FromArgb(68, 110, 108), ButtonBorderStyle.Solid);
        }

        private void btnRegistroVenta_Click(object sender, EventArgs e)
        {
            pnlVenta.Visible = true;
            pnlDatosVenta.Visible = true;
            btnQuitarUltimoAgregado.Visible = true;
            btnRegistrarVentaProductos.Visible = true;
            pnlFacturas.Visible = false;
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            pnlVenta.Visible = false;
            pnlDatosVenta.Visible = false;
            btnQuitarUltimoAgregado.Visible = false;
            btnRegistrarVentaProductos.Visible = false;
            pnlFacturas.Visible = true;


        }


        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            //try
            //{   
            //    ObtenerDatosDelMenu(categoriaElegida);
            //    cantidadProducto = int.Parse(txtCantidad.Text);

            //    listaNombresProductos.Add(nombreProducto);
            //    listaTiposProductos.Add(tipoProducto);
            //    listaCantidadProductos.Add(cantidadProducto);

            //    listaPrecios.Add(float.Parse(lblImpresionPrecioProducto.Text));

            //    if (cantidadProducto < 1)
            //    {
            //        throw new FormatException("La cantidad debe ser mayor o igual a 1");
            //    }

            //    if (categoriaElegida != 1 && categoriaElegida != 2)
            //    {
            //        lblRegistroProductos.Text += $"{nombreProducto}{Environment.NewLine}";
            //    }

            //    if (categoriaElegida == 1)
            //    {
            //        string nombreIngresoLabel = $"{tipoProducto} - {nombreProducto}{Environment.NewLine}";

            //        if (rbtCaja.Checked)
            //        {
            //            nombreIngresoLabel = $"Caja de helados{Environment.NewLine}";
            //        }
            //        if (rbtChocoBanana.Checked)
            //        {
            //            nombreIngresoLabel = $"Choco banana{Environment.NewLine}";
            //        }

            //        lblRegistroProductos.Text += nombreIngresoLabel;
            //    }

            //    if (categoriaElegida == 2)
            //    {
            //        string nombreIngresoLabel = "";

            //        if (rbtBlancoNegro.Checked)
            //        {
            //            nombreIngresoLabel = $"{tipoProducto} - B/N{Environment.NewLine}";
            //        }
            //        if (rbtColor.Checked)
            //        {
            //            nombreIngresoLabel = $"{tipoProducto} - Color{Environment.NewLine}";
            //        }

            //        lblRegistroProductos.Text += nombreIngresoLabel;
            //    }

            //    lblRegistroPrecios.Text += $"{lblImpresionPrecioProducto.Text}{Environment.NewLine}";
            //    lblRegistroCantidad.Text += $"{txtCantidad.Text}{Environment.NewLine}";

            //    float cantidadTemporal = float.Parse(txtCantidad.Text);
            //    float precioTemporal = float.Parse(lblImpresionPrecioProducto.Text);
            //    float subtotal = cantidadTemporal * precioTemporal;

            //    string subtotalStr = subtotal.ToString("F2");

            //    totalPrecio += subtotal;
                
            //    lblRegistroSubtotal.Text += $"{subtotalStr}{Environment.NewLine}";
            //    lblRegistroTotal.Text = totalPrecio.ToString("F2");

            //    lblTotal.Visible = true;
            //    lblDolaresDelRegistro.Visible = true;
            //    pnlPresentacionDatosRegistrados.Visible = true;

            //    txtCantidad.Text = "";

            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("La cantidad debe ser un número entero mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error en el ingreso de datos del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            

        }

        private void btnQuitarUltimoAgregado_Click(object sender, EventArgs e)
        {
            //if (listaNombresProductos.Count == 0)
            //{
            //    MessageBox.Show("No hay elementos para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //if (listaNombresProductos.Count > 0)
            //{

            //    float precioEliminado = listaPrecios[listaPrecios.Count - 1];
            //    int cantidadEliminada = listaCantidadProductos[listaCantidadProductos.Count - 1];

            //    listaNombresProductos.RemoveAt(listaNombresProductos.Count - 1);
            //    listaTiposProductos.RemoveAt(listaTiposProductos.Count - 1);
            //    listaCantidadProductos.RemoveAt(listaCantidadProductos.Count - 1);
            //    listaPrecios.RemoveAt(listaPrecios.Count - 1);

            //    string textoProductos = "";
            //    string textoPrecios = "";
            //    string textoCantidad = "";
            //    string textoSubtotal = "";

            //    for (int i = 0; i < listaNombresProductos.Count; i++)
            //    {
            //        textoProductos += $"{listaNombresProductos[i]}{Environment.NewLine}";
            //        textoPrecios += $"{listaPrecios[i]}{Environment.NewLine}";
            //        textoCantidad += $"{listaCantidadProductos[i]}{Environment.NewLine}";

            //        float subtotalActualizado = listaPrecios[i] * listaCantidadProductos[i];
            //        textoSubtotal += $"{subtotalActualizado.ToString("F2")}{Environment.NewLine}";
            //    }

            //    lblRegistroProductos.Text = textoProductos;
            //    lblRegistroPrecios.Text = textoPrecios;
            //    lblRegistroCantidad.Text = textoCantidad;
            //    lblRegistroSubtotal.Text = textoSubtotal;

            //    float nuevoTotal = totalPrecio - (precioEliminado * cantidadEliminada);
            //    totalPrecio = nuevoTotal;

            //    lblRegistroTotal.Text = totalPrecio.ToString("F2");

            //    MessageBox.Show("Elemento eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //} 

        }

        private void btnRegistrarVentaProductos_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    string crearVenta = "INSERT INTO ventas(fecha_venta) VALUES(CURRENT_DATE)";
            //    string agregarProductosDetalleVenta = "";

            //    //Crear venta
            //    using (NpgsqlCommand command = new NpgsqlCommand(crearVenta, conn.GetConnection()))
            //    {
            //        command.ExecuteNonQuery();
            //    }

            //    //Obtener ID de la venta creada
            //    ConsultarIdVenta();
            //    Console.WriteLine("ID venta: " + idVentaSeleccionada);

            //    //Agregar productos a la venta
            //    for (int i = 0; i < listaNombresProductos.Count; i++)
            //    {
            //        ConsultarIdTipo(listaTiposProductos[i]);
            //        nombreProducto = listaNombresProductos[i];

            //        ConsultarIdProducto();

            //        cantidadProducto = listaCantidadProductos[i];

            //        Console.WriteLine(agregarProductosDetalleVenta);


            //        agregarProductosDetalleVenta = $"INSERT INTO detalle_ventas(id_venta, id_producto, cantidad) " +
            //        $"VALUES ({idVentaSeleccionada}, {idProducto}, {cantidadProducto})";

            //        using (NpgsqlCommand command = new NpgsqlCommand(agregarProductosDetalleVenta, conn.GetConnection()))
            //        {
            //            command.ExecuteNonQuery();
            //            ventaCreadaCorrectamente = true;

            //        }
                    
            //    }

            //    if (ventaCreadaCorrectamente == true)
            //    {
            //        MessageBox.Show("La venta se guardó correctamente");
            //    }

            //    listaNombresProductos.Clear();
            //    listaTiposProductos.Clear();
            //    listaPrecios.Clear();
            //    listaCantidadProductos.Clear();

            //    lblRegistroCantidad.Text = "";
            //    lblRegistroPrecios.Text = "";
            //    lblRegistroProductos.Text = "";
            //    lblRegistroSubtotal.Text = "";
            //    lblRegistroTotal.Text = "";

            //    lblTotal.Visible = false;
            //    lblDolaresDelRegistro.Visible = false;
            //    pnlPresentacionDatosRegistrados.Visible = false;

            //    totalPrecio = 0;


            //    LlenarDgvMostrarDatos();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al registrar la venta " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

    }
}
