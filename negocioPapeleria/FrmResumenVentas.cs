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

namespace negocioPapeleria
{
    public partial class FrmResumenVentas : Form
    {

        int numeroElementos = 0;

        int idTipoMenor = 0;
        int idTipoMayor = 0;

        int idVenta = 0;
        float precioProducto = 0;
        float precioTotalVenta = 0;

        int cantidad = 0;

        string nombreProducto = "";
        string nombreTipo = "";
        string nombreCategoria = "";

        string fechaString = "";
        string mesString = "";
        string anioString = "";

        string mensaje = "Tabla correspondiente a todos las ventas existentes";

        bool validadorTodosLosProductosSeleccionados = true;

        DateTime fechaDeHoy;
        DateTime fechaVenta;

        conexionPostgres conn;
        exportarArchivo exp;

        public FrmResumenVentas()
        {
            InitializeComponent();

            conn = new conexionPostgres();
            exp = new exportarArchivo();

            fechaDeHoy = DateTime.Today;
            lblIngresosFecha.Text = "Ingresos a lo largo del tiempo";

            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy";

            rbtDia.Checked = true;


            LlenarCmbCategoria();
            PersonalizarDgvMostrarDatos();
            LlenarDgvMostrarDatos();
            ObtenerNumeroElementos();
            SumarPrecioTotal();
        }

        private void LlenarCmbCategoria()
        {
            conn.AbrirConexion();
            string consulta = $"SELECT nombre_categoria FROM categorias";
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(consulta, conn.GetConnection());
            da.Fill(ds, "categorias");
            cmbCategoria.DataSource = ds.Tables[0].DefaultView;
            cmbCategoria.ValueMember = "nombre_categoria";
            cmbCategoria.SelectedIndex = -1;
        }
        private void LlenarCmbTipo()
        {
            conn.AbrirConexion();
            string consulta = $"SELECT nombre_tipo FROM tipo_productos WHERE id_tipo >= {idTipoMenor} AND id_tipo < {idTipoMayor} ORDER BY nombre_tipo ASC";
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(consulta, conn.GetConnection());
            da.Fill(ds, "tipo_productos");
            cmbTipo.DataSource = ds.Tables[0].DefaultView;
            cmbTipo.ValueMember = "nombre_tipo";
            cmbTipo.SelectedIndex = -1;
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

        private void SumarPrecioTotal()
        {
            precioTotalVenta = 0;

            foreach (DataGridViewRow fila in dgvMostrarDatos.Rows)
            {
                if (fila.Cells["precio_producto"].Value != null && fila.Cells["cantidad"].Value != null)
                {
                    float precio;
                    float cantidad;
                    if (float.TryParse(fila.Cells["precio_producto"].Value.ToString(), out precio) && 
                        float.TryParse(fila.Cells["cantidad"].Value.ToString(), out cantidad))
                    {
                        precioTotalVenta += precio * cantidad;
                    }
                }
            }

            lblIngresos.Text = precioTotalVenta.ToString() + " dólares";
        }



        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerRangoIdTipo();
            LlenarCmbTipo();
        }


        private void btgFiltrarSegun_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtDia.Checked)
            {
                dtpFecha.Format = DateTimePickerFormat.Custom;
                dtpFecha.CustomFormat = "dd/MM/yyyy";
            }
            if (rbtMes.Checked)
            {
                dtpFecha.Format = DateTimePickerFormat.Custom;
                dtpFecha.CustomFormat = "MM/yyyy";
            }
            if (rbtAnio.Checked)
            {
                dtpFecha.Format = DateTimePickerFormat.Custom;
                dtpFecha.CustomFormat = "yyyy";
            }


            }


        /*  
         *  -------------------------------------------------------------------------
         *  EN ESTOS MÉTODOS ÚNICAMENTE SE HACEN COSAS RELACIONADAS AL DATA GRID VIEW
         *  -------------------------------------------------------------------------
         */

        private void PersonalizarDgvMostrarDatos()
        {

            //Tabla Productos
            dgvMostrarDatos.Columns.Add("id_venta", "ID Venta");
            dgvMostrarDatos.Columns.Add("nombre_producto", "Nombre del Producto");
            dgvMostrarDatos.Columns.Add("nombre_tipo", "Tipo de Producto");
            dgvMostrarDatos.Columns.Add("precio_producto", "Precio Producto");
            dgvMostrarDatos.Columns.Add("cantidad", "Cantidad");
            dgvMostrarDatos.Columns.Add("fecha_venta", "Fecha Venta");

            dgvMostrarDatos.RowHeadersVisible = false;

            dgvMostrarDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 9);
            dgvMostrarDatos.DefaultCellStyle.Font = new Font("Cambria", 9);

            dgvMostrarDatos.DefaultCellStyle.BackColor = Color.FromArgb(214, 215, 217);
            dgvMostrarDatos.DefaultCellStyle.ForeColor = Color.Black;

            dgvMostrarDatos.EnableHeadersVisualStyles = false;
            dgvMostrarDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(93, 183, 185);
            dgvMostrarDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvMostrarDatos.Columns[0].Width = 100;
            dgvMostrarDatos.Columns[1].Width = 200;
            dgvMostrarDatos.Columns[2].Width = 122;
            dgvMostrarDatos.Columns[3].Width = 115;
            dgvMostrarDatos.Columns[4].Width = 90;
            dgvMostrarDatos.Columns[5].Width = 112;

            dgvMostrarDatos.ReadOnly = true;
        }
        private void LlenarDgvMostrarDatos()
        {
            dgvMostrarDatos.Rows.Clear();

            conn.AbrirConexion();

            string obtenerDatosProducto = "SELECT v.id_venta, p.nombre_producto, t.nombre_tipo, p.precio_producto, d.cantidad, v.fecha_venta " +
                "FROM ventas v " +
                "INNER JOIN detalle_ventas d ON v.id_venta = d.id_venta " +
                "INNER JOIN productos p ON d.id_producto = p.id_producto " +
                "INNER JOIN tipo_productos t ON p.id_tipo = t.id_tipo ORDER BY id_venta ASC";

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(obtenerDatosProducto, conn.GetConnection()))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idVenta = reader.GetInt32(0);
                            nombreProducto = reader.GetString(1);
                            nombreTipo = reader.GetString(2);
                            precioProducto = reader.GetFloat(3);
                            cantidad = reader.GetInt32(4);
                            fechaVenta = reader.GetDateTime(5);


                            Console.WriteLine(idVenta);
                            Console.WriteLine(nombreProducto);
                            Console.WriteLine(nombreTipo);
                            Console.WriteLine(precioProducto);
                            Console.WriteLine(cantidad);
                            Console.WriteLine(fechaVenta);

                            string fechaFormateada = fechaVenta.ToString("dd-MM-yyyy");

                            dgvMostrarDatos.Rows.Add(idVenta, nombreProducto, nombreTipo, precioProducto, cantidad, fechaFormateada);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Ejecución finalizada");
            }
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
            
            try
            {
                dgvMostrarDatos.Rows.Clear();

                nombreTipo = cmbTipo.Text;
                nombreCategoria = cmbCategoria.Text;

                fechaVenta = dtpFecha.Value.Date;

                

                string consultaCmb = "";
                string consultaRbt = "";
                string orderBy = "ORDER BY id_venta ASC";
                string consultaFiltrarDatos = "SELECT v.id_venta, p.nombre_producto, t.nombre_tipo, p.precio_producto, d.cantidad, v.fecha_venta " +
                "FROM ventas v " +
                "INNER JOIN detalle_ventas d ON v.id_venta = d.id_venta " +
                "INNER JOIN productos p ON d.id_producto = p.id_producto " +
                "INNER JOIN tipo_productos t ON p.id_tipo = t.id_tipo " +
                "INNER JOIN categorias c ON p.id_categoria = c.id_categoria ";


                if (numeroElementos == 0)
                {
                    //throw new ArgumentException("No hay ventas en esa fecha");
                }

                if (cmbTipo.SelectedIndex == -1)
                {
                    consultaCmb = $"WHERE c.nombre_categoria = '{nombreCategoria}' ";
                }
                if (cmbTipo.SelectedIndex != -1)
                {
                    consultaCmb = $"WHERE c.nombre_categoria = '{nombreCategoria}' AND t.nombre_tipo = '{nombreTipo}' ";
                }


                if (rbtDia.Checked)
                {
                    fechaString = fechaVenta.ToString("dd-MM-yyyy");
                    lblIngresosFecha.Text = "Ingresos el " + fechaDeHoy.ToString("dd-MM-yyyy");

                    if (cmbCategoria.SelectedIndex == -1 && cmbTipo.SelectedIndex == -1)
                    {
                        consultaCmb = "";
                        consultaRbt = $"WHERE v.fecha_venta = '{fechaString}' ";

                    }
                    if (cmbCategoria.SelectedIndex != -1)
                    {
                        consultaRbt = $"AND v.fecha_venta = '{fechaString}' ";
                    }
                }
                if (rbtMes.Checked)
                {
                    mesString = fechaVenta.ToString("MM");
                    anioString = fechaVenta.ToString("yyyy");
                    lblIngresosFecha.Text = "Ingresos el mes " + mesString + "-" + anioString;

                    if (cmbCategoria.SelectedIndex == -1 && cmbTipo.SelectedIndex == -1)
                    {
                        consultaCmb = "";
                        consultaRbt = $"WHERE EXTRACT(MONTH FROM v.fecha_venta) = {mesString} AND EXTRACT(YEAR FROM v.fecha_venta) = {anioString} ";
                    }
                    if (cmbCategoria.SelectedIndex != -1)
                    {
                        consultaRbt = $"AND EXTRACT(MONTH FROM v.fecha_venta) = {mesString} AND EXTRACT(YEAR FROM v.fecha_venta) = {anioString} ";
                    }
                }

                if (rbtAnio.Checked)
                {

                    anioString = fechaVenta.ToString("yyyy");
                    lblIngresosFecha.Text = "Ingresos en " + anioString;

                    if (cmbCategoria.SelectedIndex == -1 && cmbTipo.SelectedIndex == -1)
                    {
                        consultaCmb = "";
                        consultaRbt = $"WHERE EXTRACT(YEAR FROM v.fecha_venta) = {anioString} ";
                    }
                    if (cmbCategoria.SelectedIndex != -1)
                    {
                        consultaRbt = $"AND EXTRACT(YEAR FROM v.fecha_venta) = {anioString} ";
                    }
                }

                consultaFiltrarDatos += consultaCmb += consultaRbt += orderBy;

                using (NpgsqlCommand command = new NpgsqlCommand(consultaFiltrarDatos, conn.GetConnection()))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idVenta = reader.GetInt32(0);
                            nombreProducto = reader.GetString(1);
                            nombreTipo = reader.GetString(2);
                            precioProducto = reader.GetFloat(3);
                            cantidad = reader.GetInt32(4);
                            fechaVenta = reader.GetDateTime(5);

                            string fechaFormateada = fechaVenta.ToString("dd-MM-yyyy");

                            dgvMostrarDatos.Rows.Add(idVenta, nombreProducto, nombreTipo, precioProducto, cantidad, fechaFormateada);
                        }
                    }
                }

                ObtenerNumeroElementos();
                SumarPrecioTotal();

                validadorTodosLosProductosSeleccionados = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiarFitros_Click(object sender, EventArgs e)
        {

            cmbCategoria.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;

            rbtDia.Checked = true;
            rbtMes.Checked = false;
            rbtAnio.Checked = false;

        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            LlenarDgvMostrarDatos();
            ObtenerNumeroElementos();
            SumarPrecioTotal();

            validadorTodosLosProductosSeleccionados = true;

            lblIngresosFecha.Text = "Ingresos a lo largo del tiempo";
            
        }

        private void btnGenerarDocumento_Click(object sender, EventArgs e)
        {
            string nombre = "Ventas realizadas";
            string numeroVentas = "El número de ventas realizadas es: " + numeroElementos.ToString();
            string ruta = "C:\\Users\\jacqu\\OneDrive\\Escritorio\\DocumentosVentas";

            string mensajePreeliminar = "Tabla de ventas realizadas";
            string mensajeTotal = "Total: " + precioTotalVenta.ToString() + " dólares";
            mensaje = "";

            
            string fechaMensaje = "";

            if (cmbCategoria.SelectedIndex != -1)
            {
                mensajePreeliminar += " categoría: " + cmbCategoria.Text;

                if (cmbTipo.SelectedIndex != -1)
                {

                    mensajePreeliminar += "\ntipo: " + cmbTipo.Text;
                }
            }

            if (rbtDia.Checked)
            {
                fechaMensaje = fechaDeHoy.ToString("dd-MM-yyyy");
            }
            if (rbtMes.Checked)
            {
                fechaMensaje = mesString + " del año" + anioString;
            }
            if (rbtAnio.Checked)
            {
                fechaMensaje = "Año " + anioString;
            }
            if (validadorTodosLosProductosSeleccionados == true)
            {
                fechaMensaje = "A lo largo del tiempo";
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
                    exp.ExportarExcel(dgvMostrarDatos, nombre, ruta, mensaje, numeroVentas, fechaMensaje, mensajeTotal);
                }
                if (result == DialogResult.No)
                {
                    //PDF
                    exp.ExportarPdf(dgvMostrarDatos, nombre, ruta, mensaje, numeroVentas, fechaMensaje, mensajeTotal);
                }
            }
        }
    }
    
}
