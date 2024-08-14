namespace negocioPapeleria
{
    partial class FrmRegistrarVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlVenta = new System.Windows.Forms.Panel();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNombreCliente = new System.Windows.Forms.ComboBox();
            this.cmbNombreProducto = new System.Windows.Forms.ComboBox();
            this.cmbNombreEmpleado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDolares = new System.Windows.Forms.Label();
            this.lblImpresionPrecioProducto = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnRegistroVenta = new System.Windows.Forms.Button();
            this.pnlDatosVenta = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPresentacionDatosRegistrados = new System.Windows.Forms.Panel();
            this.lblRegistroNombreEmpleado = new System.Windows.Forms.Label();
            this.lblRegistroNombreCliente = new System.Windows.Forms.Label();
            this.lblRegistroSucursal = new System.Windows.Forms.Label();
            this.lblRegistroSubtotal = new System.Windows.Forms.Label();
            this.lblRegistroProductos = new System.Windows.Forms.Label();
            this.lblRegistroPrecios = new System.Windows.Forms.Label();
            this.lblRegistroCantidad = new System.Windows.Forms.Label();
            this.lblDolaresDelRegistro = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblRegistroTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            this.lblPrecioRegistro = new System.Windows.Forms.Label();
            this.lblNombreProductoRegistro = new System.Windows.Forms.Label();
            this.lblProductosAgregados = new System.Windows.Forms.Label();
            this.btnRegistrarVentaProductos = new System.Windows.Forms.Button();
            this.btnQuitarUltimoAgregado = new System.Windows.Forms.Button();
            this.pnlFacturas = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlVenta.SuspendLayout();
            this.pnlDatosVenta.SuspendLayout();
            this.pnlPresentacionDatosRegistrados.SuspendLayout();
            this.pnlFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVenta
            // 
            this.pnlVenta.Controls.Add(this.txtUnidades);
            this.pnlVenta.Controls.Add(this.label4);
            this.pnlVenta.Controls.Add(this.cmbNombreCliente);
            this.pnlVenta.Controls.Add(this.cmbNombreProducto);
            this.pnlVenta.Controls.Add(this.cmbNombreEmpleado);
            this.pnlVenta.Controls.Add(this.label9);
            this.pnlVenta.Controls.Add(this.label3);
            this.pnlVenta.Controls.Add(this.label1);
            this.pnlVenta.Controls.Add(this.label2);
            this.pnlVenta.Controls.Add(this.lblDolares);
            this.pnlVenta.Controls.Add(this.lblImpresionPrecioProducto);
            this.pnlVenta.Controls.Add(this.cmbSucursal);
            this.pnlVenta.Controls.Add(this.lblPrecioProducto);
            this.pnlVenta.Controls.Add(this.btnAgregarProductos);
            this.pnlVenta.Location = new System.Drawing.Point(34, 45);
            this.pnlVenta.Name = "pnlVenta";
            this.pnlVenta.Size = new System.Drawing.Size(1035, 241);
            this.pnlVenta.TabIndex = 0;
            this.pnlVenta.Paint += new System.Windows.Forms.PaintEventHandler(this.CambiarColorPaneles_Paint);
            // 
            // txtUnidades
            // 
            this.txtUnidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnidades.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidades.Location = new System.Drawing.Point(694, 70);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(316, 27);
            this.txtUnidades.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(690, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Unidades";
            // 
            // cmbNombreCliente
            // 
            this.cmbNombreCliente.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombreCliente.FormattingEnabled = true;
            this.cmbNombreCliente.Location = new System.Drawing.Point(243, 96);
            this.cmbNombreCliente.Name = "cmbNombreCliente";
            this.cmbNombreCliente.Size = new System.Drawing.Size(368, 28);
            this.cmbNombreCliente.TabIndex = 41;
            // 
            // cmbNombreProducto
            // 
            this.cmbNombreProducto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombreProducto.FormattingEnabled = true;
            this.cmbNombreProducto.Location = new System.Drawing.Point(243, 48);
            this.cmbNombreProducto.Name = "cmbNombreProducto";
            this.cmbNombreProducto.Size = new System.Drawing.Size(368, 28);
            this.cmbNombreProducto.TabIndex = 40;
            // 
            // cmbNombreEmpleado
            // 
            this.cmbNombreEmpleado.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombreEmpleado.FormattingEnabled = true;
            this.cmbNombreEmpleado.Location = new System.Drawing.Point(243, 144);
            this.cmbNombreEmpleado.Name = "cmbNombreEmpleado";
            this.cmbNombreEmpleado.Size = new System.Drawing.Size(368, 28);
            this.cmbNombreEmpleado.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Nombre del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre del Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre del Cliente";
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolares.Location = new System.Drawing.Point(779, 145);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(64, 20);
            this.lblDolares.TabIndex = 31;
            this.lblDolares.Text = "Dólares";
            // 
            // lblImpresionPrecioProducto
            // 
            this.lblImpresionPrecioProducto.AutoSize = true;
            this.lblImpresionPrecioProducto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpresionPrecioProducto.Location = new System.Drawing.Point(690, 145);
            this.lblImpresionPrecioProducto.Name = "lblImpresionPrecioProducto";
            this.lblImpresionPrecioProducto.Size = new System.Drawing.Size(37, 20);
            this.lblImpresionPrecioProducto.TabIndex = 28;
            this.lblImpresionPrecioProducto.Text = "lbl1";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(243, 196);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(368, 28);
            this.cmbSucursal.TabIndex = 32;
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProducto.Location = new System.Drawing.Point(690, 123);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(153, 20);
            this.lblPrecioProducto.TabIndex = 27;
            this.lblPrecioProducto.Text = "Precio del Producto";
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.btnAgregarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnAgregarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(172)))), ((int)(((byte)(169)))));
            this.btnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductos.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductos.Location = new System.Drawing.Point(694, 178);
            this.btnAgregarProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(316, 45);
            this.btnAgregarProductos.TabIndex = 20;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = false;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(172)))), ((int)(((byte)(169)))));
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.Location = new System.Drawing.Point(273, 11);
            this.btnFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(233, 45);
            this.btnFacturas.TabIndex = 22;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnRegistroVenta
            // 
            this.btnRegistroVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.btnRegistroVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnRegistroVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(172)))), ((int)(((byte)(169)))));
            this.btnRegistroVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroVenta.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroVenta.Location = new System.Drawing.Point(34, 11);
            this.btnRegistroVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistroVenta.Name = "btnRegistroVenta";
            this.btnRegistroVenta.Size = new System.Drawing.Size(233, 45);
            this.btnRegistroVenta.TabIndex = 21;
            this.btnRegistroVenta.Text = "Registrar Venta";
            this.btnRegistroVenta.UseVisualStyleBackColor = false;
            this.btnRegistroVenta.Click += new System.EventHandler(this.btnRegistroVenta_Click);
            // 
            // pnlDatosVenta
            // 
            this.pnlDatosVenta.Controls.Add(this.label7);
            this.pnlDatosVenta.Controls.Add(this.label6);
            this.pnlDatosVenta.Controls.Add(this.label5);
            this.pnlDatosVenta.Controls.Add(this.pnlPresentacionDatosRegistrados);
            this.pnlDatosVenta.Controls.Add(this.lblDolaresDelRegistro);
            this.pnlDatosVenta.Controls.Add(this.lblSubtotal);
            this.pnlDatosVenta.Controls.Add(this.lblRegistroTotal);
            this.pnlDatosVenta.Controls.Add(this.lblTotal);
            this.pnlDatosVenta.Controls.Add(this.lblCantidadProductos);
            this.pnlDatosVenta.Controls.Add(this.lblPrecioRegistro);
            this.pnlDatosVenta.Controls.Add(this.lblNombreProductoRegistro);
            this.pnlDatosVenta.Controls.Add(this.lblProductosAgregados);
            this.pnlDatosVenta.Location = new System.Drawing.Point(34, 302);
            this.pnlDatosVenta.Name = "pnlDatosVenta";
            this.pnlDatosVenta.Size = new System.Drawing.Size(1035, 286);
            this.pnlDatosVenta.TabIndex = 25;
            this.pnlDatosVenta.Paint += new System.Windows.Forms.PaintEventHandler(this.CambiarColorPaneles_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(820, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Nombre del Empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(626, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nombre del Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Sucursal";
            // 
            // pnlPresentacionDatosRegistrados
            // 
            this.pnlPresentacionDatosRegistrados.AutoScroll = true;
            this.pnlPresentacionDatosRegistrados.Controls.Add(this.lblRegistroNombreEmpleado);
            this.pnlPresentacionDatosRegistrados.Controls.Add(this.lblRegistroNombreCliente);
            this.pnlPresentacionDatosRegistrados.Controls.Add(this.lblRegistroSucursal);
            this.pnlPresentacionDatosRegistrados.Controls.Add(this.lblRegistroSubtotal);
            this.pnlPresentacionDatosRegistrados.Controls.Add(this.lblRegistroProductos);
            this.pnlPresentacionDatosRegistrados.Controls.Add(this.lblRegistroPrecios);
            this.pnlPresentacionDatosRegistrados.Controls.Add(this.lblRegistroCantidad);
            this.pnlPresentacionDatosRegistrados.Location = new System.Drawing.Point(19, 79);
            this.pnlPresentacionDatosRegistrados.Name = "pnlPresentacionDatosRegistrados";
            this.pnlPresentacionDatosRegistrados.Size = new System.Drawing.Size(991, 172);
            this.pnlPresentacionDatosRegistrados.TabIndex = 40;
            // 
            // lblRegistroNombreEmpleado
            // 
            this.lblRegistroNombreEmpleado.AutoSize = true;
            this.lblRegistroNombreEmpleado.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroNombreEmpleado.Location = new System.Drawing.Point(801, 9);
            this.lblRegistroNombreEmpleado.Name = "lblRegistroNombreEmpleado";
            this.lblRegistroNombreEmpleado.Size = new System.Drawing.Size(37, 20);
            this.lblRegistroNombreEmpleado.TabIndex = 41;
            this.lblRegistroNombreEmpleado.Text = "lbl1";
            // 
            // lblRegistroNombreCliente
            // 
            this.lblRegistroNombreCliente.AutoSize = true;
            this.lblRegistroNombreCliente.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroNombreCliente.Location = new System.Drawing.Point(607, 9);
            this.lblRegistroNombreCliente.Name = "lblRegistroNombreCliente";
            this.lblRegistroNombreCliente.Size = new System.Drawing.Size(37, 20);
            this.lblRegistroNombreCliente.TabIndex = 40;
            this.lblRegistroNombreCliente.Text = "lbl1";
            // 
            // lblRegistroSucursal
            // 
            this.lblRegistroSucursal.AutoSize = true;
            this.lblRegistroSucursal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroSucursal.Location = new System.Drawing.Point(482, 9);
            this.lblRegistroSucursal.Name = "lblRegistroSucursal";
            this.lblRegistroSucursal.Size = new System.Drawing.Size(37, 20);
            this.lblRegistroSucursal.TabIndex = 39;
            this.lblRegistroSucursal.Text = "lbl1";
            // 
            // lblRegistroSubtotal
            // 
            this.lblRegistroSubtotal.AutoSize = true;
            this.lblRegistroSubtotal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroSubtotal.Location = new System.Drawing.Point(370, 9);
            this.lblRegistroSubtotal.Name = "lblRegistroSubtotal";
            this.lblRegistroSubtotal.Size = new System.Drawing.Size(37, 20);
            this.lblRegistroSubtotal.TabIndex = 38;
            this.lblRegistroSubtotal.Text = "lbl1";
            // 
            // lblRegistroProductos
            // 
            this.lblRegistroProductos.AutoSize = true;
            this.lblRegistroProductos.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroProductos.Location = new System.Drawing.Point(2, 9);
            this.lblRegistroProductos.Name = "lblRegistroProductos";
            this.lblRegistroProductos.Size = new System.Drawing.Size(37, 20);
            this.lblRegistroProductos.TabIndex = 29;
            this.lblRegistroProductos.Text = "lbl1";
            // 
            // lblRegistroPrecios
            // 
            this.lblRegistroPrecios.AutoSize = true;
            this.lblRegistroPrecios.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroPrecios.Location = new System.Drawing.Point(177, 9);
            this.lblRegistroPrecios.Name = "lblRegistroPrecios";
            this.lblRegistroPrecios.Size = new System.Drawing.Size(37, 20);
            this.lblRegistroPrecios.TabIndex = 30;
            this.lblRegistroPrecios.Text = "lbl1";
            // 
            // lblRegistroCantidad
            // 
            this.lblRegistroCantidad.AutoSize = true;
            this.lblRegistroCantidad.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroCantidad.Location = new System.Drawing.Point(285, 9);
            this.lblRegistroCantidad.Name = "lblRegistroCantidad";
            this.lblRegistroCantidad.Size = new System.Drawing.Size(37, 20);
            this.lblRegistroCantidad.TabIndex = 34;
            this.lblRegistroCantidad.Text = "lbl1";
            // 
            // lblDolaresDelRegistro
            // 
            this.lblDolaresDelRegistro.AutoSize = true;
            this.lblDolaresDelRegistro.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolaresDelRegistro.Location = new System.Drawing.Point(169, 254);
            this.lblDolaresDelRegistro.Name = "lblDolaresDelRegistro";
            this.lblDolaresDelRegistro.Size = new System.Drawing.Size(64, 20);
            this.lblDolaresDelRegistro.TabIndex = 39;
            this.lblDolaresDelRegistro.Text = "Dólares";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(386, 56);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(53, 20);
            this.lblSubtotal.TabIndex = 37;
            this.lblSubtotal.Text = "Sub. T.";
            // 
            // lblRegistroTotal
            // 
            this.lblRegistroTotal.AutoSize = true;
            this.lblRegistroTotal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroTotal.Location = new System.Drawing.Point(88, 254);
            this.lblRegistroTotal.Name = "lblRegistroTotal";
            this.lblRegistroTotal.Size = new System.Drawing.Size(37, 20);
            this.lblRegistroTotal.TabIndex = 36;
            this.lblRegistroTotal.Text = "lbl1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(19, 254);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 35;
            this.lblTotal.Text = "Total:";
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.AutoSize = true;
            this.lblCantidadProductos.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProductos.Location = new System.Drawing.Point(304, 56);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(45, 20);
            this.lblCantidadProductos.TabIndex = 33;
            this.lblCantidadProductos.Text = "Cant.";
            // 
            // lblPrecioRegistro
            // 
            this.lblPrecioRegistro.AutoSize = true;
            this.lblPrecioRegistro.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioRegistro.Location = new System.Drawing.Point(196, 56);
            this.lblPrecioRegistro.Name = "lblPrecioRegistro";
            this.lblPrecioRegistro.Size = new System.Drawing.Size(63, 20);
            this.lblPrecioRegistro.TabIndex = 32;
            this.lblPrecioRegistro.Text = "Precios";
            // 
            // lblNombreProductoRegistro
            // 
            this.lblNombreProductoRegistro.AutoSize = true;
            this.lblNombreProductoRegistro.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProductoRegistro.Location = new System.Drawing.Point(19, 56);
            this.lblNombreProductoRegistro.Name = "lblNombreProductoRegistro";
            this.lblNombreProductoRegistro.Size = new System.Drawing.Size(139, 20);
            this.lblNombreProductoRegistro.TabIndex = 31;
            this.lblNombreProductoRegistro.Text = "Nombre Producto";
            // 
            // lblProductosAgregados
            // 
            this.lblProductosAgregados.AutoSize = true;
            this.lblProductosAgregados.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosAgregados.Location = new System.Drawing.Point(21, 17);
            this.lblProductosAgregados.Name = "lblProductosAgregados";
            this.lblProductosAgregados.Size = new System.Drawing.Size(176, 20);
            this.lblProductosAgregados.TabIndex = 28;
            this.lblProductosAgregados.Text = "Productos Agregados";
            // 
            // btnRegistrarVentaProductos
            // 
            this.btnRegistrarVentaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(209)))), ((int)(((byte)(167)))));
            this.btnRegistrarVentaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarVentaProductos.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVentaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVentaProductos.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVentaProductos.Location = new System.Drawing.Point(728, 593);
            this.btnRegistrarVentaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarVentaProductos.Name = "btnRegistrarVentaProductos";
            this.btnRegistrarVentaProductos.Size = new System.Drawing.Size(341, 57);
            this.btnRegistrarVentaProductos.TabIndex = 7;
            this.btnRegistrarVentaProductos.Text = "Registrar Venta de Productos";
            this.btnRegistrarVentaProductos.UseVisualStyleBackColor = false;
            this.btnRegistrarVentaProductos.Click += new System.EventHandler(this.btnRegistrarVentaProductos_Click);
            // 
            // btnQuitarUltimoAgregado
            // 
            this.btnQuitarUltimoAgregado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(209)))), ((int)(((byte)(167)))));
            this.btnQuitarUltimoAgregado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarUltimoAgregado.FlatAppearance.BorderSize = 0;
            this.btnQuitarUltimoAgregado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnQuitarUltimoAgregado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarUltimoAgregado.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarUltimoAgregado.Location = new System.Drawing.Point(34, 593);
            this.btnQuitarUltimoAgregado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarUltimoAgregado.Name = "btnQuitarUltimoAgregado";
            this.btnQuitarUltimoAgregado.Size = new System.Drawing.Size(341, 57);
            this.btnQuitarUltimoAgregado.TabIndex = 28;
            this.btnQuitarUltimoAgregado.Text = "Quitar Último Producto Agregado";
            this.btnQuitarUltimoAgregado.UseVisualStyleBackColor = false;
            this.btnQuitarUltimoAgregado.Click += new System.EventHandler(this.btnQuitarUltimoAgregado_Click);
            // 
            // pnlFacturas
            // 
            this.pnlFacturas.Controls.Add(this.dataGridView1);
            this.pnlFacturas.Location = new System.Drawing.Point(34, 45);
            this.pnlFacturas.Name = "pnlFacturas";
            this.pnlFacturas.Size = new System.Drawing.Size(1035, 605);
            this.pnlFacturas.TabIndex = 44;
            this.pnlFacturas.Paint += new System.Windows.Forms.PaintEventHandler(this.CambiarColorPaneles_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(991, 569);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmRegistrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1103, 676);
            this.Controls.Add(this.pnlVenta);
            this.Controls.Add(this.btnRegistroVenta);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnQuitarUltimoAgregado);
            this.Controls.Add(this.btnRegistrarVentaProductos);
            this.Controls.Add(this.pnlDatosVenta);
            this.Controls.Add(this.pnlFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistrarVentas";
            this.Text = "FrmRegistrarVentas";
            this.pnlVenta.ResumeLayout(false);
            this.pnlVenta.PerformLayout();
            this.pnlDatosVenta.ResumeLayout(false);
            this.pnlDatosVenta.PerformLayout();
            this.pnlPresentacionDatosRegistrados.ResumeLayout(false);
            this.pnlPresentacionDatosRegistrados.PerformLayout();
            this.pnlFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVenta;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Button btnRegistroVenta;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Panel pnlDatosVenta;
        private System.Windows.Forms.Button btnRegistrarVentaProductos;
        private System.Windows.Forms.Label lblImpresionPrecioProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblProductosAgregados;
        private System.Windows.Forms.Button btnQuitarUltimoAgregado;
        private System.Windows.Forms.Label lblRegistroPrecios;
        private System.Windows.Forms.Label lblRegistroProductos;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.Label lblPrecioRegistro;
        private System.Windows.Forms.Label lblNombreProductoRegistro;
        private System.Windows.Forms.Label lblRegistroTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRegistroCantidad;
        private System.Windows.Forms.Label lblCantidadProductos;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblRegistroSubtotal;
        private System.Windows.Forms.Label lblDolaresDelRegistro;
        private System.Windows.Forms.Panel pnlPresentacionDatosRegistrados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRegistroNombreEmpleado;
        private System.Windows.Forms.Label lblRegistroNombreCliente;
        private System.Windows.Forms.Label lblRegistroSucursal;
        private System.Windows.Forms.ComboBox cmbNombreCliente;
        private System.Windows.Forms.ComboBox cmbNombreProducto;
        private System.Windows.Forms.ComboBox cmbNombreEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlFacturas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}