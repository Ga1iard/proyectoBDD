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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace negocioPapeleria
{
    public partial class FrmRegistro : Form
    {
        //Producto
        private String nombreProducto = "";
        private String precioProducto = "";

        //Empleado
        private String nombreEmpleado = "";
        private String telefonoEmpleado = "";
        private String sucursalEmpleado = "";

        //Cliente
        private String nombreCliente = "";
        private String apellidoCliente = "";
        private String direccionClinete = "";
        private String telefonoClinete = "";
        private String sucursalCliente = "";

        conexionPostgres conn;
        public FrmRegistro()
        {
            InitializeComponent();
            dgvMostrarDatos.CellMouseMove += dgvMostrarDatos_CellMouseMove;

            conn = new conexionPostgres();

            pnlDatosProductos.Paint += Panel1_Paint;
            pnlDatosEmpleados.Paint += Panel1_Paint;
            pnlDatosClientes.Paint += Panel1_Paint;

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

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.FromArgb(68, 110, 108), ButtonBorderStyle.Solid);
        }

        private string FormatearNumeros(string priceString, string cultureName)
        {
            CultureInfo culture = new CultureInfo(cultureName);
            float precioProducto = float.Parse(priceString, culture);
            return precioProducto.ToString(culture);
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
                    string idProducto = dgvMostrarDatos.Rows[e.RowIndex].Cells["id_producto"].Value.ToString();
                    dgvMostrarDatos[e.ColumnIndex, e.RowIndex].Tag = idProducto;
                    string idProductoSeleccionado = idProducto;
                    Console.WriteLine(idProductoSeleccionado);
                }
            }
            catch (Exception)
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

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
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

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
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
        }

        


        private void InicializarVariables()
        {
            //Producto
            nombreProducto = txtNombreProducto.Text;
            precioProducto = txtPrecioProducto.Text;

            //Empleado
            nombreEmpleado = txtNombreEmpleado.Text;
            telefonoEmpleado = txtTelefonoEmpleado.Text;
            sucursalEmpleado = cmbSucursalEmpleado.Text;

            //Cliente
            nombreCliente = txtNombreCliente.Text;
            apellidoCliente = txtApellidoCliente.Text;
            direccionClinete = txtDireccionCliente.Text;
            telefonoClinete = txtTelefonoCLiente.Text;
            sucursalCliente = cmbSucursalCliente.Text;
        }


        private void btnRegistrarProductosQuito_Click(object sender, EventArgs e)
        {       
            InicializarVariables();
        }

        private void btnRegistrarProductosGuayaquil_Click(object sender, EventArgs e)
        {
            InicializarVariables();
        }

        private void btnEditarProductos_Click(object sender, EventArgs e)
        {
            InicializarVariables();
        }

        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            InicializarVariables();
        }



        private void btnRegistrarEmpleadosQuito_Click(object sender, EventArgs e)
        {
            InicializarVariables();
        }

        private void btnRegistrarEmpleadosGuayaquil_Click(object sender, EventArgs e)
        {
            InicializarVariables();
        }

        private void btnEditarEmpleados_Click(object sender, EventArgs e)
        {
            InicializarVariables();
        }

        private void btnEliminarEmpleados_Click(object sender, EventArgs e)
        {
            InicializarVariables();
        }



        private void btnRegistrarClientesQuito_Click(object sender, EventArgs e)
        {
            InicializarVariables();
        }

        private void btnRegistrarClientesGuayaquil_Click(object sender, EventArgs e)
        {
            InicializarVariables();
        }

        private void btnEditarClientes_Click(object sender, EventArgs e)
        {
            InicializarVariables();
        }

        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {
            InicializarVariables();
        }
    }
}
