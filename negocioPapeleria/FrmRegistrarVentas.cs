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

        private bool productoAgregadoCorrectamente = false;

        private string nombreProducto = "";
        private string nombreEmpleado = "";
        private string nombreCliente = "";
        private string sucursal = "";
        private string unidades = "";
        private string numeroFactura = "";
        private string idSucursal = "";

        private string idEmpleado = "";
        private string idProducto = "";
        private string idCliente = "";

        private int lineaDetalles = 0;

        private static List<string> listaIDsProductos = new List<string>();
        private static List<string> listaIDsEmpleados = new List<string>();
        private static List<string> listaIDsClientes = new List<string>();
        private static List<string> listaPrecios = new List<string>();
        private static List<string> listaSubtotales = new List<string>();
        private static List<string> listaUnidades = new List<string>();

        private string nombreProductoSeleccionado = "";

        conexionSQLServer conn;

        public FrmRegistrarVentas()
        {
            InitializeComponent();

            conn = new conexionSQLServer();

            LlenarCMBCliente();
            LlenarCMBEmpleado();
            LlenarCMBProducto();
            LlenarCMBSucursal();

            ObtenerLineaDetalles();

            pnlFacturas.Visible = false;

            lblImpresionPrecioProducto.Visible = false;
            lblRegistroTotal.Visible = false;

            CrearDGVProductosAgregados();
            PersonalizarDataGridView(dgvProductosAgregados);

            CrearDGVFacturas();
            PersonalizarDataGridView(dgvFacturas);

            dgvProductosAgregados.CellMouseMove += new DataGridViewCellMouseEventHandler(DataGridView_CellMouseMove);
            dgvProductosAgregados.CellMouseLeave += new DataGridViewCellEventHandler(DataGridView_CellMouseLeave);


            dgvFacturas.CellMouseMove += new DataGridViewCellMouseEventHandler(DataGridView_CellMouseMove);
            dgvFacturas.CellMouseLeave += new DataGridViewCellEventHandler(DataGridView_CellMouseLeave);




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

        // Llenar el ComboBox de Sucursales
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

        private void ObtenerPrecioProducto()
        {
            string consultaPrecio = "select precio_unit from Productos";

            using (SqlCommand comando = new SqlCommand(consultaPrecio, conn.GetConnection()))
            {
                // Añade el parámetro del nombre del producto a la consulta
                comando.Parameters.AddWithValue("@nombreProducto", nombreProducto);

                try
                {
                    // Abre la conexión
                    conn.AbrirConexion();

                    // Ejecuta la consulta y obtiene el resultado
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        // Convierte el resultado a decimal y luego a string
                        decimal precioProducto = Convert.ToDecimal(resultado);
                        string precioFormateado = precioProducto.ToString().Replace('.', ',');
                        lblImpresionPrecioProducto.Text = precioFormateado;
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el precio del producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Cierra la conexión
                    conn.CerrarConexion();
                }
            }
        }

        private void ObtenerLineaDetalles()
        {
            string obtenerLineas = "select COUNT(*) from Detalles";

            using (SqlCommand comando = new SqlCommand(obtenerLineas, conn.GetConnection()))
            {
                try
                {
                    // Abre la conexión
                    conn.AbrirConexion();

                    // Ejecuta la consulta y obtiene el resultado
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        // Convierte el resultado a entero y muestra el número de líneas
                        lineaDetalles = Convert.ToInt32(resultado);
                        Console.WriteLine($"Número de líneas en Detalles: {lineaDetalles}");
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron registros en la tabla Detalles.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el número de detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Cierra la conexión
                    conn.CerrarConexion();
                }
            }
        }

        private void ObtenerIDEmpleado()
        {
            string consultaID = $"select id_empleado from Empleados where nombre = @nombreEmpleado";

            using (SqlCommand comando = new SqlCommand(consultaID, conn.GetConnection()))
            {
                comando.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);

                try
                {
                    conn.AbrirConexion();
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        idEmpleado = resultado.ToString();
                        Console.WriteLine($"ID Empleado: {idEmpleado}"); // Para verificar el ID obtenido
                    }
                    else
                    {
                        MessageBox.Show("Empleado no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el ID del empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.CerrarConexion();
                }
            }
        }

        private void ObtenerIDProducto()
        {
            string consultaID = $"select id_producto from Productos where nombre_prod = @nombreProducto";

            using (SqlCommand comando = new SqlCommand(consultaID, conn.GetConnection()))
            {
                comando.Parameters.AddWithValue("@nombreProducto", nombreProducto);

                try
                {
                    conn.AbrirConexion();
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        idProducto = resultado.ToString();
                        Console.WriteLine($"ID Producto: {idProducto}"); // Para verificar el ID obtenido
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el ID del producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.CerrarConexion();
                }
            }
        }

        private void ObtenerIDCliente()
        {

            string nombre = "";
            string apellido = "";

            string[] partes = nombreCliente.Split(' ');

            if (partes.Length == 2)
            {
                nombre = partes[0];    // Primer parte es el nombre
                apellido = partes[1];  // Segunda parte es el apellido
            }
            else
            {
                MessageBox.Show("Nombre del cliente no está en el formato esperado (Nombre Apellido).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string consultaID = $"select id_cliente from Clientes where nombre_cli = @nombre AND apellido_cli = @apellido";

            using (SqlCommand comando = new SqlCommand(consultaID, conn.GetConnection()))
            {
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);

                try
                {
                    conn.AbrirConexion();
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        idCliente = resultado.ToString();
                        Console.WriteLine($"ID Cliente: {idCliente}"); // Para verificar el ID obtenido
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el ID del cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.CerrarConexion();
                }
            }

        }



        private void InicializarDatos()
        {
            nombreProducto = cmbNombreProducto.Text;
            nombreEmpleado = cmbNombreEmpleado.Text;
            nombreCliente = cmbNombreCliente.Text;
            sucursal = cmbSucursal.Text;
            unidades = txtUnidades.Text;
            numeroFactura = txtNumeroFactura.Text;
        }

        private void ObtenerIDSucursal(string sucursal)
        {
            if (sucursal == "Quito")
                idSucursal = "1";
            if (sucursal == "Guayaquil")
                idSucursal = "2";
        }

        private void cmbNombreProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerPrecioProducto();
            lblImpresionPrecioProducto.Visible = true;
        }


        /*  
         *  -------------------------------------------------------------------------
         *  EN ESTOS MÉTODOS ÚNICAMENTE SE HACEN COSAS RELACIONADAS AL DATA GRID VIEW
         *  -------------------------------------------------------------------------
         */

        private void CrearDGVProductosAgregados()
        {
            dgvProductosAgregados.Columns.Add("nombre_producto", "Nombre Producto");
            dgvProductosAgregados.Columns.Add("precio_producto", "Precio Producto");
            dgvProductosAgregados.Columns.Add("cantidad_producto", "Cantidad");
            dgvProductosAgregados.Columns.Add("subtotal", "Subtotal");
            dgvProductosAgregados.Columns.Add("sucursal", "Sucursal");
            dgvProductosAgregados.Columns.Add("numero_factura", "Factura");
            dgvProductosAgregados.Columns.Add("nombre_cliente", "Nombre Cliente");
            dgvProductosAgregados.Columns.Add("nombre_empleado", "Nombre Empleado");

            dgvProductosAgregados.Columns[0].Width = 104;
            dgvProductosAgregados.Columns[1].Width = 80;
            dgvProductosAgregados.Columns[2].Width = 80;
            dgvProductosAgregados.Columns[3].Width = 80;
            dgvProductosAgregados.Columns[4].Width = 80;
            dgvProductosAgregados.Columns[5].Width = 80;
            dgvProductosAgregados.Columns[6].Width = 104;
            dgvProductosAgregados.Columns[7].Width = 104;

            dgvProductosAgregados.AllowUserToAddRows = false;
        }

        private void CrearDGVFacturas()
        {
            dgvFacturas.Columns.Add("id_factura", "ID");
            dgvFacturas.Columns.Add("nombre_producto_factura", "Nombre Producto");
            dgvFacturas.Columns.Add("precio_unitario", "Precio Unitario");
            dgvFacturas.Columns.Add("cantidad_factura", "Cantidad");
            dgvFacturas.Columns.Add("precio_total", "Precio Total");
            dgvFacturas.Columns.Add("fecha", "Fecha");
            dgvFacturas.Columns.Add("sucursal_factura", "Sucursal");
            dgvFacturas.Columns.Add("cliente_factura", "Cliente");
            dgvFacturas.Columns.Add("empleado_factura", "Empleado");

            dgvFacturas.Columns[0].Width = 60;
            dgvFacturas.Columns[1].Width = 97;
            dgvFacturas.Columns[2].Width = 70;
            dgvFacturas.Columns[3].Width = 70;
            dgvFacturas.Columns[4].Width = 70;
            dgvFacturas.Columns[5].Width = 80;
            dgvFacturas.Columns[6].Width = 80;
            dgvFacturas.Columns[7].Width = 97;
            dgvFacturas.Columns[8].Width = 97;
        }

        private void PersonalizarDataGridView(DataGridView dgv)
        {
            // Ocultar encabezados de fila
            dgv.RowHeadersVisible = false;

            // Configurar la fuente para encabezados y celdas
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 9);
            dgv.DefaultCellStyle.Font = new Font("Cambria", 9);

            // Configurar colores de fondo y texto de las celdas
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(214, 215, 217);
            dgv.DefaultCellStyle.ForeColor = Color.Black;

            // Configurar colores de encabezado de columna
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(93, 183, 185);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Hacer el DataGridView de solo lectura
            dgv.ReadOnly = true;
        }



        private void DataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv.Cursor = Cursors.Hand;
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(217, 237, 237);
            }
            else
            {
                dgv.Cursor = Cursors.Default;
                if (e.RowIndex >= 0)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(214, 215, 217);
                }
            }
        }

        private void DataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;

            if (e.RowIndex >= 0)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(214, 215, 217);
            }
        }



        // dgvProductosAgregados (índice 1)
        private void dgvProductosAgregados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView_CellClick(sender, e, 1);
        }

        // dgvFacturas (índice 2)
        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView_CellClick(sender, e, 2);
        }


        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e, int indiceBotones)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;

            try
            {
                if (e.RowIndex >= 0)
                {
                    if (indiceBotones == 1) // Nombre del Producto
                    {
                        nombreProductoSeleccionado = dgv.Rows[e.RowIndex].Cells["nombre_producto"].Value.ToString();
                        Console.WriteLine($"Nombre del producto seleccionado: {nombreProductoSeleccionado}");
                    }
                    else if (indiceBotones == 2) // ID de Factura
                    {
                        nombreProductoSeleccionado = dgv.Rows[e.RowIndex].Cells["id_factura"].Value.ToString();
                        Console.WriteLine($"ID de factura seleccionado: {nombreProductoSeleccionado}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una celda válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Llenar dgvProductosAgregados
        private void LlenarDGVProductosAgregados()
        {
            // Calcular el subtotal
            float precioProducto = float.Parse(lblImpresionPrecioProducto.Text);
            int cantidadProducto = Convert.ToInt32(txtUnidades.Text);
            float subtotal = precioProducto * cantidadProducto;

            // Crear una fila con los datos
            string[] row = new string[]
            {
                nombreProducto,
                precioProducto.ToString(),
                unidades.ToString(),
                subtotal.ToString(),
                sucursal,
                numeroFactura,
                nombreCliente,
                nombreEmpleado
            };

            listaSubtotales.Add(subtotal.ToString());
            listaIDsClientes.Add(idCliente);
            listaIDsEmpleados.Add(idEmpleado);
            listaIDsProductos.Add(idProducto);
            listaPrecios.Add(precioProducto.ToString());
            listaUnidades.Add(cantidadProducto.ToString());

            // Agregar la fila al DataGridView
            dgvProductosAgregados.Rows.Add(row);
        }


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
            btnQuitarElemento.Visible = true;
            btnRegistrarVentaProductos.Visible = true;
            pnlFacturas.Visible = false;
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            pnlVenta.Visible = false;
            pnlDatosVenta.Visible = false;
            btnQuitarElemento.Visible = false;
            btnRegistrarVentaProductos.Visible = false;
            pnlFacturas.Visible = true;


        }
       
        private void CalcularTotal()
        {
            // Inicializa la suma total en 0
            float sumaTotal = 0;

            // Itera a través de todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvProductosAgregados.Rows)
            {
                // Asegúrate de que la fila no sea nueva antes de intentar acceder a los datos
                if (fila.IsNewRow) continue;


                float subtotal = Convert.ToSingle(fila.Cells["Subtotal"].Value);
                // Suma el valor del subtotal a la suma total
                sumaTotal += subtotal;
            }

            // Muestra la suma total en el Label (formato con dos decimales)
            lblRegistroTotal.Text = sumaTotal.ToString();
        }


        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                InicializarDatos();
                LlenarDGVProductosAgregados();

                lblRegistroTotal.Visible = true;

                CalcularTotal();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarElemento_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay filas en el DataGridView
                if (dgvProductosAgregados.Rows.Count > 0)
                {
                    // Itera a través de las filas del DataGridView
                    foreach (DataGridViewRow fila in dgvProductosAgregados.Rows)
                    {
                        // Compara el valor de la columna 'nombre_producto' con el nombre proporcionado
                        if (fila.Cells["nombre_producto"].Value != null &&
                            fila.Cells["nombre_producto"].Value.ToString().Equals(nombreProductoSeleccionado, StringComparison.OrdinalIgnoreCase))
                        {
                            // Elimina la fila del DataGridView
                            dgvProductosAgregados.Rows.Remove(fila);

                            CalcularTotal();
                            MessageBox.Show("Producto eliminado correctamente.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Salir del bucle una vez que se elimina la fila
                        }
                    }

                    // Si no se encontró el producto
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No hay productos para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarVentaProductos_Click(object sender, EventArgs e)
        {

            string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd");

            //Meter en for
            string insertarElementos = "SET XACT_ABORT ON; " +
                "BEGIN DISTRIBUTED TRANSACTION " +
                $"insert into Facturas(num_factura, fecha_fact, precio_fact, id_sucursal,id_cliente, id_empleado) " +
                $"Values({numeroFactura},'{fechaHoy}', {listaSubtotales}, {idSucursal}, {idCliente}, {idEmpleado}); " +
                $"insert into Detalles(linea_det, unidades, precio_det, num_factura, id_producto, id_sucursal) " +
                $"Values({lineaDetalles}, {unidades}, {listaPrecios},{numeroFactura}, {idProducto}, {idSucursal}); " +
                "COMMIT TRANSACTION";

            MessageBox.Show(insertarElementos);

        }

        
    }
}
