using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace negocioPapeleria
{
    public partial class FrmRegistro : Form
    {

        private int indiceBotones = 1;  //1 = Productos, 2 = Empleados, 3 = Clientes

        private String idSucursal = ""; //1 = Quito, 2 = Guayaquil

        //Producto
        private String idProducto = "";
        private String nombreProducto = "";
        private String precioProducto = "";
        private String idProductoSeleccionado = "";

        //Empleado
        private String idEmpleado = "";
        private String nombreEmpleado = "";
        private String telefonoEmpleado = "";
        private String sucursalEmpleado = "";
        private String idEmpleadoSeleccionado = "";

        //Cliente
        private String idCliente = "";
        private String nombreCliente = "";
        private String apellidoCliente = "";
        private String direccionCliente = "";
        private String telefonoCliente = "";
        private String sucursalCliente = "";
        private String idClienteSeleccionado = "";

        conexionSQLServer conn;

        public FrmRegistro()
        {
            InitializeComponent();
            dgvMostrarDatos.CellMouseMove += dgvMostrarDatos_CellMouseMove;

            conn = new conexionSQLServer();

            pnlDatosProductos.Paint += Panel_Paint;
            pnlDatosEmpleados.Paint += Panel_Paint;
            pnlDatosClientes.Paint += Panel_Paint;

            pnlDatosProductos.Parent = this;
            pnlDatosEmpleados.Parent = this;
            pnlDatosClientes.Parent = this;

            pnlDatosProductos.Visible = true;
            pnlDatosEmpleados.Visible = false;
            pnlDatosClientes.Visible = false;

            //Personalizar DGV
            dgvMostrarDatos.ReadOnly = true;

            dgvMostrarDatos.RowHeadersVisible = false;
            dgvMostrarDatos.EnableHeadersVisualStyles = false;

            dgvMostrarDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 9);
            dgvMostrarDatos.DefaultCellStyle.Font = new Font("Cambria", 9);

            dgvMostrarDatos.DefaultCellStyle.BackColor = Color.FromArgb(214, 215, 217);
            dgvMostrarDatos.DefaultCellStyle.ForeColor = Color.Black;

            dgvMostrarDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(93, 183, 185);
            dgvMostrarDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvMostrarDatos.Columns.Add("id_producto", "ID del Producto");
            dgvMostrarDatos.Columns.Add("nombre_producto", "Nombre del Producto");
            dgvMostrarDatos.Columns.Add("precio_producto", "Precio Producto");

            dgvMostrarDatos.Columns[0].Width = 186;
            dgvMostrarDatos.Columns[1].Width = 368;
            dgvMostrarDatos.Columns[2].Width = 208;


            LlenarDGV();



        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.FromArgb(68, 110, 108), ButtonBorderStyle.Solid);
        }

        public void ObtenerSucursal(ComboBox comboBox)
        {
            String consultaSucursal = "SELECT ciudad FROM Sucursales";

            // Limpia el ComboBox antes de agregar nuevos elementos
            comboBox.Items.Clear();

            // Abre la conexión
            conn.AbrirConexion();

            try
            {
                // Crear el comando
                SqlCommand comando = new SqlCommand(consultaSucursal, conn.GetConnection());

                // Ejecutar la consulta y obtener los resultados
                SqlDataReader reader = comando.ExecuteReader();

                // Procesar los resultados
                while (reader.Read())
                {
                    // Obtener el valor de la columna "ciudad"
                    string ciudad = reader["ciudad"].ToString();

                    // Agregar el valor al ComboBox
                    comboBox.Items.Add(ciudad);
                }

                // Cerrar el lector
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
            }
            finally
            {
                // Cierra la conexión
                conn.CerrarConexion();
            }
        }

        private void LlenarDGV()
        {
            String consultaLlenarDGV = "";

            if (indiceBotones == 1)
            {
                consultaLlenarDGV = "select id_producto, nombre_prod, precio_unit  from Productos";
            }
            if (indiceBotones == 2)
            {
                consultaLlenarDGV = "select id_empleado, nombre, num_telefono, id_sucursal  from Empleados";
            }
            if (indiceBotones == 3)
            {
                consultaLlenarDGV = "select c.id_cliente, c.nombre_cli, c.apellido_cli, c.tel_cli, cu.dir_cli, c.id_sucursal " +
                    "from Clientes c JOIN ClientesUbicacion cu ON c.id_cliente = cu.id_cliente";
            }

            conn.AbrirConexion();

            try
            {
                // Crear el comando
                SqlCommand comando = new SqlCommand(consultaLlenarDGV, conn.GetConnection());
                SqlDataReader reader = comando.ExecuteReader();

                // Limpiar las filas actuales del DataGridView
                dgvMostrarDatos.Rows.Clear();

                // Llenar el DataGridView con los datos
                while (reader.Read())
                {
                    if (indiceBotones == 1)
                    {
                        dgvMostrarDatos.Rows.Add(reader["id_producto"], reader["nombre_prod"], reader["precio_unit"]);
                    }
                    else if (indiceBotones == 2)
                    {
                        dgvMostrarDatos.Rows.Add(reader["id_empleado"], reader["nombre"], reader["num_telefono"], reader["id_sucursal"]);
                    }
                    else if (indiceBotones == 3)
                    {
                        dgvMostrarDatos.Rows.Add(reader["id_cliente"], reader["nombre_cli"], reader["apellido_cli"], 
                            reader["dir_cli"], reader["tel_cli"], reader["id_sucursal"]);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al llenar el DataGridView: {ex.Message}");
            }
            finally
            {
                // Cierra la conexión
                conn.CerrarConexion();
            }
        }


            /*  
             *  -------------------------------------------------------------------------
             *  EN ESTOS MÉTODOS ÚNICAMENTE SE HACEN COSAS RELACIONADAS AL DATA GRID VIEW
             *  -------------------------------------------------------------------------
             */

        private void dgvMostrarDatos_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvMostrarDatos.Cursor = Cursors.Hand;
                dgvMostrarDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(217, 237, 237);
            }
            else
            {
                dgvMostrarDatos.Cursor = Cursors.Default;
                // Verifica si e.RowIndex es mayor o igual a 0 antes de cambiar el estilo de la fila
                if (e.RowIndex >= 0)
                {
                    dgvMostrarDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(214, 215, 217);
                }
            }
        }

        private void dgvMostrarDatos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvMostrarDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(214, 215, 217);
            }
        }

        private void dgvMostrarDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string idSeleccionado = "";

                    if (indiceBotones == 1) // Productos
                    {
                        idSeleccionado = dgvMostrarDatos.Rows[e.RowIndex].Cells["id_producto"].Value.ToString();
                        idProductoSeleccionado = idSeleccionado;
                    }
                    else if (indiceBotones == 2) // Empleados
                    {
                        idSeleccionado = dgvMostrarDatos.Rows[e.RowIndex].Cells["id_empleado"].Value.ToString();
                        idEmpleadoSeleccionado = idSeleccionado;
                    }
                    else if (indiceBotones == 3) // Clientes
                    {
                        idSeleccionado = dgvMostrarDatos.Rows[e.RowIndex].Cells["id_cliente"].Value.ToString();
                        idClienteSeleccionado = idSeleccionado;
                    }

                    // Mostrar el ID seleccionado en la consola para verificación
                    Console.WriteLine(idSeleccionado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una celda válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * -------------------------------------------------------------------------
         *              AQUÍ TERMINAN LOS MÉTODOS DEL DATA GRID VIEW
         * -------------------------------------------------------------------------
         */


        private void btnProductos_Click(object sender, EventArgs e)
        {
            indiceBotones = 1;

            lblMensajeIndicativo.Visible = false;


            //Colores del botón
            btnEmpleados.BackColor = Color.FromArgb(93, 183, 185);
            btnProductos.BackColor = Color.FromArgb(157, 196, 201);
            btnClientes.BackColor = Color.FromArgb(93, 183, 185);

            //Mostrar panel
            pnlDatosProductos.Visible = true;
            pnlDatosClientes.Visible = false;
            pnlDatosEmpleados.Visible = false;
            pnlDatosProductos.Location = new Point(20, 51);
            pnlDatosProductos.BringToFront();

            //Tabla Productos
            dgvMostrarDatos.Rows.Clear();
            dgvMostrarDatos.Columns.Clear();

            dgvMostrarDatos.Columns.Add("id_producto", "ID del Producto");
            dgvMostrarDatos.Columns.Add("nombre_producto", "Nombre del Producto");
            dgvMostrarDatos.Columns.Add("precio_producto", "Precio Producto");

            dgvMostrarDatos.Columns[0].Width = 186;
            dgvMostrarDatos.Columns[1].Width = 368;
            dgvMostrarDatos.Columns[2].Width = 208;

            LlenarDGV();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            indiceBotones = 2;

            lblMensajeIndicativo.Visible = false;

            //Colores del botón
            btnEmpleados.BackColor = Color.FromArgb(157, 196, 201);
            btnProductos.BackColor = Color.FromArgb(93, 183, 185);
            btnClientes.BackColor = Color.FromArgb(93, 183, 185);

            //Mostar panel
            pnlDatosProductos.Visible = false;
            pnlDatosEmpleados.Visible = true;
            pnlDatosClientes.Visible = false;
            pnlDatosEmpleados.Location = new Point(20, 51);
            pnlDatosEmpleados.BringToFront();

            //Tabla Empleados
            dgvMostrarDatos.Rows.Clear();
            dgvMostrarDatos.Columns.Clear();

            dgvMostrarDatos.Columns.Add("id_empleado", "ID del Empleado");
            dgvMostrarDatos.Columns.Add("nombre_empleado", "Nombre del Empleado");
            dgvMostrarDatos.Columns.Add("telefono_empleado", "Número de teléfono");
            dgvMostrarDatos.Columns.Add("sucursal_empleado", "Sucursal");

            dgvMostrarDatos.Columns[0].Width = 120;
            dgvMostrarDatos.Columns[1].Width = 328;
            dgvMostrarDatos.Columns[2].Width = 162;
            dgvMostrarDatos.Columns[3].Width = 152;

            //Llenar CMB
            ObtenerSucursal(cmbSucursalEmpleado);

            LlenarDGV();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            indiceBotones = 3;

            lblMensajeIndicativo.Visible = false;

            //Colores del botón
            btnEmpleados.BackColor = Color.FromArgb(93, 183, 185);
            btnProductos.BackColor = Color.FromArgb(93, 183, 185);
            btnClientes.BackColor = Color.FromArgb(157, 196, 201);

            //Mostrar panel
            pnlDatosProductos.Visible= false;
            pnlDatosEmpleados.Visible = false;
            pnlDatosClientes.Visible = true;
            pnlDatosClientes.Location = new Point(20, 51);
            pnlDatosClientes.BringToFront();

            //Tabla Clientes
            dgvMostrarDatos.Rows.Clear();
            dgvMostrarDatos.Columns.Clear();

            dgvMostrarDatos.Columns.Add("id_cliente", "ID del Cliente");
            dgvMostrarDatos.Columns.Add("nombre_cliente", "Nombre del Cliente");
            dgvMostrarDatos.Columns.Add("apellido_cliente", "Apellido del Cliente");
            dgvMostrarDatos.Columns.Add("direccion_cliente", "Dirección del Cliente");
            dgvMostrarDatos.Columns.Add("telefono_cliente", "Número de teléfono");
            dgvMostrarDatos.Columns.Add("sucursal_empleado", "Sucursal");

            dgvMostrarDatos.Columns[0].Width = 80;
            dgvMostrarDatos.Columns[1].Width = 147;
            dgvMostrarDatos.Columns[2].Width = 147;
            dgvMostrarDatos.Columns[3].Width = 168;
            dgvMostrarDatos.Columns[4].Width = 110;
            dgvMostrarDatos.Columns[5].Width = 110;

            //Llenar CMB
            ObtenerSucursal(cmbSucursalCliente);

            LlenarDGV();
        }



        private void InicializarVariables()
        {
            //Producto
            idProducto = txtIDProducto.Text;
            nombreProducto = txtNombreProducto.Text;
            precioProducto = txtPrecioProducto.Text;

            //Empleado
            idEmpleado = txtIDEmpleado.Text;
            nombreEmpleado = txtNombreEmpleado.Text;
            telefonoEmpleado = txtTelefonoEmpleado.Text;
            sucursalEmpleado = cmbSucursalEmpleado.Text;

            //Cliente
            idCliente = txtIDCliente.Text;
            nombreCliente = txtNombreCliente.Text;
            apellidoCliente = txtApellidoCliente.Text;
            direccionCliente = txtDireccionCliente.Text;
            telefonoCliente = txtTelefonoCLiente.Text;
            sucursalCliente = cmbSucursalCliente.Text;
        }

        private void LimpiarVariables()
        {
            // Limpiar campos de Producto
            txtIDProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();

            // Limpiar campos de Empleado
            txtIDEmpleado.Clear();
            txtNombreEmpleado.Clear();
            txtTelefonoEmpleado.Clear();
            cmbSucursalEmpleado.SelectedIndex = 0;

            // Limpiar campos de Cliente
            txtIDCliente.Clear();
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtDireccionCliente.Clear();
            txtTelefonoCLiente.Clear();
            cmbSucursalCliente.SelectedIndex = 0;
        }


        // Obtener ID sucursal
        private void ObtenerIDSucursal(string sucursal)
        {
            if (sucursal == "Quito")
                idSucursal = "1";
            if (sucursal == "Guayaquil")
                idSucursal = "2";
        }

        // Función para ejecutar consultas de inserción, edición y eliminación
        private void EjecutarConsulta(string consultaSQL)
        {
            // Abre la conexión
            conn.AbrirConexion();

            try
            {
                // Crear y ejecutar el comando
                SqlCommand comando = new SqlCommand(consultaSQL, conn.GetConnection());
                int filasAfectadas = comando.ExecuteNonQuery();

                // Mostrar mensaje de éxito
                MessageBox.Show("Operación realizada con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cierra la conexión
                conn.CerrarConexion();
            }
        }


        /* Productos */
        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            InicializarVariables();

            string insertarProducto = "INSERT INTO Productos(id_producto, nombre_prod, precio_unit) " +
                $"VALUES({idProducto}, '{nombreProducto}', {precioProducto})";

            EjecutarConsulta(insertarProducto);

            LlenarDGV();
            LimpiarVariables();
        }

        private void btnEditarProductos_Click(object sender, EventArgs e)
        {
            InicializarVariables();

            string editarProducto = $"UPDATE Productos SET nombre_prod = '{nombreProducto}', " +
                $"precio_unit = {precioProducto} WHERE id_producto = {idProductoSeleccionado}";

            EjecutarConsulta(editarProducto);

            LlenarDGV();
            LimpiarVariables();
        }

        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            InicializarVariables();

            string eliminarProducto = $"DELETE FROM Productos WHERE id_producto = {idProductoSeleccionado}";

            EjecutarConsulta(eliminarProducto);

            LlenarDGV();
            LimpiarVariables();
        }



        /* Empleados */
        private void btnRegistrarEmpleados_Click(object sender, EventArgs e)
        {
            InicializarVariables();
            ObtenerIDSucursal(sucursalEmpleado);

            string insertarEmpleado = "SET XACT_ABORT ON; " +
                "BEGIN DISTRIBUTED TRANSACTION " +
                "insert into empleados(id_empleado,nombre, num_telefono, id_sucursal) " +
                $"Values({idEmpleado},'{nombreEmpleado}', '{telefonoEmpleado}', {idSucursal}) " +
                "COMMIT TRANSACTION";

            EjecutarConsulta(insertarEmpleado);

            LlenarDGV();
            LimpiarVariables();
        }

        private void btnEditarEmpleados_Click(object sender, EventArgs e)
        {
            InicializarVariables();
            ObtenerIDSucursal(sucursalEmpleado);

            string editarEmpleado = "SET XACT_ABORT ON; " +
                "BEGIN DISTRIBUTED TRANSACTION " +
                $"update empleados set id_empleado = {idEmpleado}, nombre = '{nombreEmpleado}', num_telefono = '{telefonoEmpleado}', " +
                $"id_sucursal = {idSucursal} " +
                $"where id_empleado = {idEmpleadoSeleccionado} " +
                "COMMIT TRANSACTION";

            EjecutarConsulta(editarEmpleado);

            LlenarDGV();
            LimpiarVariables();
        }

        private void btnEliminarEmpleados_Click(object sender, EventArgs e)
        {
            InicializarVariables();
            ObtenerIDSucursal(sucursalEmpleado);

            string eliminarEmpleado = "SET XACT_ABORT ON; " +
                "BEGIN DISTRIBUTED TRANSACTION " +
                $"Delete from empleados where id_empleado = {idEmpleadoSeleccionado} " +
                "COMMIT TRANSACTION";

            EjecutarConsulta(eliminarEmpleado);

            LlenarDGV();
            LimpiarVariables();
        }



        /* Clientes */
        private void btnRegistrarClientes_Click(object sender, EventArgs e)
        {
            InicializarVariables();
            ObtenerIDSucursal(sucursalCliente);

            string insertarCliente = "SET XACT_ABORT ON; " +
                "BEGIN DISTRIBUTED TRANSACTION " +
                "insert into Clientes(id_cliente,nombre_cli, apellido_cli, tel_cli, id_sucursal) " +
                $"values({idCliente}, '{nombreCliente}', '{apellidoCliente}', '{telefonoCliente}', {idSucursal}); " +
                "insert into ClientesUbicacion(id_cliente,dir_cli) " +
                $"values({idCliente}, '{direccionCliente}'); " +
                "COMMIT TRANSACTION";

            EjecutarConsulta(insertarCliente);

            LlenarDGV();
            LimpiarVariables();
        }

        private void btnEditarClientes_Click(object sender, EventArgs e)
        {
            InicializarVariables();
            ObtenerIDSucursal(sucursalCliente);

            string editarCliente = "SET XACT_ABORT ON; " +
                "BEGIN DISTRIBUTED TRANSACTION " +
                $"update Clientes set id_cliente = {idCliente}, nombre_cli = '{nombreCliente}', apellido_cli = '{apellidoCliente}', " +
                $"tel_cli ='{telefonoCliente}', id_sucursal = {idSucursal} " +
                $"where id_cliente = {idClienteSeleccionado}; " +
                $"update ClientesUbicacion set dir_cli = '{direccionCliente}' " +
                $"where id_cliente = {idClienteSeleccionado}; " +
                "COMMIT TRANSACTION";

            EjecutarConsulta(editarCliente);

            LlenarDGV();
            LimpiarVariables();
        }

        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {
            InicializarVariables();
            ObtenerIDSucursal(sucursalCliente);

            string eliminarCliente = "SET XACT_ABORT ON; " +
                "BEGIN DISTRIBUTED TRANSACTION " +
                $"Delete from ClientesUbicacion where id_cliente = {idClienteSeleccionado}; " +
                $"Delete from Clientes where id_cliente = {idClienteSeleccionado}; " +
                "COMMIT TRANSACTION";

            EjecutarConsulta(eliminarCliente);

            LlenarDGV();
            LimpiarVariables();
        }
    }
}
