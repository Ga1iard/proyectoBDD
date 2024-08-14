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

namespace negocioPapeleria
{
    public partial class FrmProductosExistentes : Form
    {
        int idTipoMenor = 0;
        int idTipoMayor = 0;

        int numeroElementos = 0;

        int idProducto = 0;
        float precioProducto = 0;
        float precioProductoHasta = 0;

        string nombreProducto = "";
        string nombreCategoria = "";
        string nombreTipo = "";

        DateTime fechaDeHoy;

        string mensaje = "Tabla correspondiente a todos los productos existentes";

        CultureInfo cultureInfo = new CultureInfo("en-US");

        conexionSQLServer conn;
        exportarArchivo exp;

        public FrmProductosExistentes()
        {
            InitializeComponent();

            conn = new conexionSQLServer();
            exp = new exportarArchivo();

            LlenarCmbCategoria();
            PersonalizarDgvMostrarDatos();
            LlenarDgvMostrarDatos();

            OcultarElementosPrecio();
            ObtenerNumeroElementos();

            fechaDeHoy = DateTime.Today;
            lblFecha.Text = fechaDeHoy.ToString("dd-MM-yyyy");


        }

        private void LlenarCmbCategoria()
        {
            //conn.AbrirConexion();
            //string consulta = $"SELECT nombre_categoria FROM categorias";
            //DataSet ds = new DataSet();
            //NpgsqlDataAdapter da = new NpgsqlDataAdapter(consulta, conn.GetConnection());
            //da.Fill(ds, "categorias");
            //cmbCategoria.DataSource = ds.Tables[0].DefaultView;
            //cmbCategoria.ValueMember = "nombre_categoria";
            //cmbCategoria.SelectedIndex = -1;
        }
        private void LlenarCmbTipo()
        {
            //conn.AbrirConexion();
            //string consulta = $"SELECT nombre_tipo FROM tipo_productos WHERE id_tipo >= {idTipoMenor} AND id_tipo < {idTipoMayor} ORDER BY nombre_tipo ASC";
            //DataSet ds = new DataSet();
            //NpgsqlDataAdapter da = new NpgsqlDataAdapter(consulta, conn.GetConnection());
            //da.Fill(ds, "tipo_productos");
            //cmbTipo.DataSource = ds.Tables[0].DefaultView;
            //cmbTipo.ValueMember = "nombre_tipo";
            //cmbTipo.SelectedIndex = -1;
        }


        private void ObtenerRangoIdTipo()
        {
            if (cmbCategoria.Text == "heladería")
            {
                idTipoMenor = 1000;
                idTipoMayor = 2000;
            }

            if (cmbCategoria.Text == "copiadora")
            {
                idTipoMenor = 2000;
                idTipoMayor = 3000;
            }

            if (cmbCategoria.Text == "papelería")
            {
                idTipoMenor = 3000;
                idTipoMayor = 4000;
            }

            if (cmbCategoria.Text == "confección")
            {
                idTipoMenor = 4000;
                idTipoMayor = 5000;
            }
        }
        private void ObtenerNumeroElementos()
        {
            numeroElementos = dgvMostrarDatos.RowCount;
            lblNumeroProductos.Text = numeroElementos.ToString();
        }


        private void OcultarElementosPrecio()
        {
            lblPrecio.Visible = false;
            lblPrecioMayor.Visible = false;
            txtPrecio.Visible = false;
            txtPrecioMayor.Visible = false;
        }


        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerRangoIdTipo();
            LlenarCmbTipo();
        }
        private void btgFiltroPrecio_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtPrecioEspecífico.Checked)
            {
                lblPrecio.Text = "Precio";
                txtPrecio.Text = "";
                lblPrecio.Visible = true;
                txtPrecio.Visible = true;
                lblPrecioMayor.Visible = false;
                txtPrecioMayor.Visible = false;
            }
            if (rbtRangoPrecio.Checked)
            {
                lblPrecio.Text = "Desde";
                txtPrecio.Text = "";
                txtPrecioMayor.Text = "";
                lblPrecio.Visible = true;
                txtPrecio.Visible = true;
                lblPrecioMayor.Visible = true;
                txtPrecioMayor.Visible = true;
            }

        }


        /*  
         *  -------------------------------------------------------------------------
         *  EN ESTOS MÉTODOS ÚNICAMENTE SE HACEN COSAS RELACIONADAS AL DATA GRID VIEW
         *  -------------------------------------------------------------------------
         */

        private void PersonalizarDgvMostrarDatos()
        {
            // id_producto nombre_producto precio_producto nombre_categoria nombre_tipo

            //Tabla Productos
            dgvMostrarDatos.Columns.Add("id_producto", "ID del Producto");
            dgvMostrarDatos.Columns.Add("nombre_producto", "Nombre del Producto");
            dgvMostrarDatos.Columns.Add("precio_producto", "Precio Producto");

            

            dgvMostrarDatos.RowHeadersVisible = false;

            dgvMostrarDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 9);
            dgvMostrarDatos.DefaultCellStyle.Font = new Font("Cambria", 9);

            dgvMostrarDatos.DefaultCellStyle.BackColor = Color.FromArgb(214, 215, 217);
            dgvMostrarDatos.DefaultCellStyle.ForeColor = Color.Black;

            dgvMostrarDatos.EnableHeadersVisualStyles = false;
            dgvMostrarDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(93, 183, 185);
            dgvMostrarDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvMostrarDatos.Columns[0].Width = 186;
            dgvMostrarDatos.Columns[1].Width = 368;
            dgvMostrarDatos.Columns[2].Width = 208;

            dgvMostrarDatos.ReadOnly = true;
        }
        private void LlenarDgvMostrarDatos()
        {
            //dgvMostrarDatos.Rows.Clear();

            //conn.AbrirConexion();

            //string obtenerDatosProducto = "SELECT p.id_producto, p.nombre_producto, p.precio_producto, c.nombre_categoria, t.nombre_tipo FROM productos p " +
            //    "INNER JOIN categorias c ON p.id_categoria = c.id_categoria INNER JOIN tipo_productos t ON p.id_tipo = t.id_tipo ORDER BY id_producto ASC";

            //try
            //{
            //    using (NpgsqlCommand command = new NpgsqlCommand(obtenerDatosProducto, conn.GetConnection()))
            //    {
            //        using (NpgsqlDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                idProducto = reader.GetInt32(0);
            //                nombreProducto = reader.GetString(1);
            //                precioProducto = reader.GetFloat(2);
            //                nombreCategoria = reader.GetString(3);
            //                nombreTipo = reader.GetString(4);

            //                Console.WriteLine(idProducto);
            //                Console.WriteLine(nombreProducto);
            //                Console.WriteLine(nombreCategoria);
            //                Console.WriteLine(nombreTipo);
            //                Console.WriteLine(precioProducto);

            //                dgvMostrarDatos.Rows.Add(idProducto, nombreProducto, nombreTipo, precioProducto, nombreCategoria);
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Ejecución finalizada");
            //}
        }
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



        /*
         * -------------------------------------------------------------------------
         *              AQUÍ TERMINAN LOS MÉTODOS DEL DATA GRID VIEW
         * -------------------------------------------------------------------------
         */


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    dgvMostrarDatos.Rows.Clear();

            //    nombreTipo = cmbTipo.Text;
            //    nombreCategoria = cmbCategoria.Text;

            //    string consultaCmb = "";
            //    string consultaRbt = "";
            //    string orderBy = "ORDER BY id_producto ASC";
            //    string consultaFiltrarDatos = "SELECT p.id_producto, p.nombre_producto, p.precio_producto, c.nombre_categoria, t.nombre_tipo FROM productos p " +
            //        "INNER JOIN categorias c ON p.id_categoria = c.id_categoria INNER JOIN tipo_productos t ON p.id_tipo = t.id_tipo ";

            //    if (cmbCategoria.SelectedIndex == -1 && cmbTipo.SelectedIndex == -1 && !rbtRangoPrecio.Checked && !rbtPrecioEspecífico.Checked)
            //    {
            //        throw new ArgumentException("Seleccione una opción válida");
            //    }

            //    if ((rbtPrecioEspecífico.Checked && (txtPrecio.Text == "0" || txtPrecio.Text == "")) || (rbtRangoPrecio.Checked &&
            //        (txtPrecio.Text == "0" || txtPrecio.Text == "" || txtPrecioMayor.Text == "0" || txtPrecioMayor.Text == "")))
            //    {
            //        throw new ArgumentException("Ingrese un precio válido");
            //    }

            //    if (cmbTipo.SelectedIndex == -1)
            //    {
            //        consultaCmb = $"WHERE c.nombre_categoria = '{nombreCategoria}' ";
            //    }
            //    if (cmbTipo.SelectedIndex != -1)
            //    {
            //        consultaCmb = $"WHERE c.nombre_categoria = '{nombreCategoria}' AND t.nombre_tipo = '{nombreTipo}' ";
            //    }

            //    if (rbtPrecioEspecífico.Checked)
            //    {
            //        precioProducto = float.Parse(txtPrecio.Text, cultureInfo);

            //        string precioProductoString = precioProducto.ToString(cultureInfo);

            //        if (cmbCategoria.SelectedIndex == -1 && cmbTipo.SelectedIndex == -1)
            //        {
            //            consultaCmb = "";
            //            consultaRbt = $"WHERE p.precio_producto = {precioProductoString} ";

            //        }
            //        if (cmbCategoria.SelectedIndex != -1)
            //        {
            //            consultaRbt = $"AND p.precio_producto = {precioProductoString} ";
            //        }
            //    }
            //    if (rbtRangoPrecio.Checked)
            //    {

            //        precioProducto = float.Parse(txtPrecio.Text, cultureInfo);
            //        precioProductoHasta = float.Parse(txtPrecioMayor.Text, cultureInfo);

            //        string precioProductoString = precioProducto.ToString(cultureInfo);
            //        string precioProductoHastaString = precioProductoHasta.ToString(cultureInfo);

            //        if (precioProducto > precioProductoHasta)
            //        {
            //            throw new ArgumentException("El precio en el apartado <Hasta> debe ser mayor");
            //        }

            //        if (cmbCategoria.SelectedIndex == -1 && cmbTipo.SelectedIndex == -1)
            //        {
            //            consultaCmb = "";
            //            consultaRbt = $"WHERE p.precio_producto >= {precioProductoString} AND p.precio_producto <= {precioProductoHastaString} ";
            //        }
            //        if (cmbCategoria.SelectedIndex != -1)
            //        {
            //            consultaRbt = $"AND p.precio_producto >= {precioProductoString} AND p.precio_producto <= {precioProductoHastaString} ";
            //        }
            //    }

            //    consultaFiltrarDatos += consultaCmb += consultaRbt += orderBy;

            //    Console.WriteLine(consultaFiltrarDatos);

            //    using (NpgsqlCommand command = new NpgsqlCommand(consultaFiltrarDatos, conn.GetConnection()))
            //    {
            //        using (NpgsqlDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                idProducto = reader.GetInt32(0);
            //                nombreProducto = reader.GetString(1);
            //                precioProducto = reader.GetFloat(2);
            //                nombreCategoria = reader.GetString(3);
            //                nombreTipo = reader.GetString(4);

            //                Console.WriteLine(idProducto);
            //                Console.WriteLine(nombreProducto);
            //                Console.WriteLine(nombreCategoria);
            //                Console.WriteLine(nombreTipo);
            //                Console.WriteLine(precioProducto);

            //                dgvMostrarDatos.Rows.Add(idProducto, nombreProducto, nombreTipo, precioProducto, nombreCategoria);
            //            }
            //        }
            //    }

            //    ObtenerNumeroElementos();


            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}


        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            LlenarDgvMostrarDatos();
            ObtenerNumeroElementos();     
        }

        private void btnLimpiarFitros_Click(object sender, EventArgs e)
        {
            OcultarElementosPrecio();

            cmbCategoria.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;

            rbtPrecioEspecífico.Checked = false;
            rbtRangoPrecio.Checked = false;

            txtPrecio.Text = "";
            txtPrecioMayor.Text = "";
        }

        private void btnGenerarDocumento_Click(object sender, EventArgs e)
        {

            string nombre = "Productos existentes";
            string numeroProductos = "El número de productos existentes es: " + numeroElementos.ToString();
            string ruta = "C:\\Users\\jacqu\\OneDrive\\Escritorio\\DocumentosVentas";

            string mensajePreeliminar = "Tabla de productos existentes de";
            mensaje = "";

            DateTime fecha = DateTime.Now;
            string fechaHoy = fecha.ToString("dd-MM-yyyy");

            if (cmbCategoria.SelectedIndex != -1)
            {
                mensajePreeliminar += " categoría: " + cmbCategoria.Text;

                if (cmbTipo.SelectedIndex != -1)
                {

                    mensajePreeliminar += "\ntipo: " + cmbTipo.Text;
                }
            }

            if (rbtPrecioEspecífico.Checked)
            {
                mensajePreeliminar += " precio: " + txtPrecio.Text + " dólares";
            }

            if (rbtRangoPrecio.Checked)
            {
                mensajePreeliminar += " precio desde: " + txtPrecio.Text + " hasta: " + txtPrecioMayor.Text + " dólares";
            }

            if (mensajePreeliminar == "Tabla de productos existentes de")
            {
                mensaje = "Tabla correspondiente a todos los productos existentes";
            }
            else
            {
                mensaje = mensajePreeliminar;
            }
            

            MessageBoxPersonalizado messageBox = new MessageBoxPersonalizado();
            DialogResult result = messageBox.Show("¿En qué formato deseas exportar los datos?", "Seleccionar formato", MessageBoxButtons.YesNo);
            {

                // Verificar la opción seleccionada por el usuario
                if (result == DialogResult.Yes)
                {
                    //Excel
                    exp.ExportarExcel(dgvMostrarDatos, nombre, ruta, mensaje, numeroProductos, fechaHoy, "");
                }
                if (result == DialogResult.No)
                {
                    //PDF
                    exp.ExportarPdf(dgvMostrarDatos, nombre, ruta, mensaje, numeroProductos, fechaHoy, "");
                }
            }
        }
    }
}
