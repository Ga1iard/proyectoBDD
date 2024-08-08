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
            this.lblDolares = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.btgTipoServicio = new System.Windows.Forms.Panel();
            this.rbtCopiaCedula = new System.Windows.Forms.RadioButton();
            this.rbtCopia = new System.Windows.Forms.RadioButton();
            this.rbtImpresion = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btgTamanio = new System.Windows.Forms.Panel();
            this.rbtChocoBanana = new System.Windows.Forms.RadioButton();
            this.rbtPequenio = new System.Windows.Forms.RadioButton();
            this.rbtCaja = new System.Windows.Forms.RadioButton();
            this.rbtGrande = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblImpresionPrecioProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.btgTipoTinta = new System.Windows.Forms.Panel();
            this.rbtBlancoNegro = new System.Windows.Forms.RadioButton();
            this.rbtColor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblVentaTipo = new System.Windows.Forms.Label();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.lblIdentificadorNombre = new System.Windows.Forms.Label();
            this.lblIdentificadorTipo = new System.Windows.Forms.Label();
            this.btnPapeleria = new System.Windows.Forms.Button();
            this.btnHeladeria = new System.Windows.Forms.Button();
            this.btnConfeccion = new System.Windows.Forms.Button();
            this.btnImpresiones = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPresentacionDatosRegistrados = new System.Windows.Forms.Panel();
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
            this.dgvMostrarDatos = new System.Windows.Forms.DataGridView();
            this.btnEliminarVentaErronea = new System.Windows.Forms.Button();
            this.btnRegistrarVentaProductos = new System.Windows.Forms.Button();
            this.btnQuitarUltimoAgregado = new System.Windows.Forms.Button();
            this.pnlVenta.SuspendLayout();
            this.btgTipoServicio.SuspendLayout();
            this.btgTamanio.SuspendLayout();
            this.btgTipoTinta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPresentacionDatosRegistrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVenta
            // 
            this.pnlVenta.Controls.Add(this.lblDolares);
            this.pnlVenta.Controls.Add(this.lblError);
            this.pnlVenta.Controls.Add(this.cmbNombre);
            this.pnlVenta.Controls.Add(this.btgTipoServicio);
            this.pnlVenta.Controls.Add(this.cmbTipo);
            this.pnlVenta.Controls.Add(this.btgTamanio);
            this.pnlVenta.Controls.Add(this.lblImpresionPrecioProducto);
            this.pnlVenta.Controls.Add(this.lblPrecioProducto);
            this.pnlVenta.Controls.Add(this.btgTipoTinta);
            this.pnlVenta.Controls.Add(this.txtCantidad);
            this.pnlVenta.Controls.Add(this.lblCantidad);
            this.pnlVenta.Controls.Add(this.lblVentaTipo);
            this.pnlVenta.Controls.Add(this.btnAgregarProductos);
            this.pnlVenta.Controls.Add(this.lblIdentificadorNombre);
            this.pnlVenta.Controls.Add(this.lblIdentificadorTipo);
            this.pnlVenta.Location = new System.Drawing.Point(316, 33);
            this.pnlVenta.Name = "pnlVenta";
            this.pnlVenta.Size = new System.Drawing.Size(753, 241);
            this.pnlVenta.TabIndex = 0;
            this.pnlVenta.Paint += new System.Windows.Forms.PaintEventHandler(this.CambiarColorPaneles_Paint);
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolares.Location = new System.Drawing.Point(594, 134);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(64, 20);
            this.lblDolares.TabIndex = 31;
            this.lblDolares.Text = "Dólares";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(107, 106);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(37, 20);
            this.lblError.TabIndex = 30;
            this.lblError.Text = "lbl1";
            // 
            // cmbNombre
            // 
            this.cmbNombre.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(108, 129);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(352, 28);
            this.cmbNombre.TabIndex = 29;
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbNombre_SelectedIndexChanged);
            this.cmbNombre.TextChanged += new System.EventHandler(this.cmbNombre_TextChanged);
            // 
            // btgTipoServicio
            // 
            this.btgTipoServicio.Controls.Add(this.rbtCopiaCedula);
            this.btgTipoServicio.Controls.Add(this.rbtCopia);
            this.btgTipoServicio.Controls.Add(this.rbtImpresion);
            this.btgTipoServicio.Controls.Add(this.label4);
            this.btgTipoServicio.Controls.Add(this.label2);
            this.btgTipoServicio.Location = new System.Drawing.Point(267, 46);
            this.btgTipoServicio.Name = "btgTipoServicio";
            this.btgTipoServicio.Size = new System.Drawing.Size(193, 137);
            this.btgTipoServicio.TabIndex = 26;
            // 
            // rbtCopiaCedula
            // 
            this.rbtCopiaCedula.AutoSize = true;
            this.rbtCopiaCedula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtCopiaCedula.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCopiaCedula.Location = new System.Drawing.Point(26, 100);
            this.rbtCopiaCedula.Name = "rbtCopiaCedula";
            this.rbtCopiaCedula.Size = new System.Drawing.Size(145, 24);
            this.rbtCopiaCedula.TabIndex = 36;
            this.rbtCopiaCedula.TabStop = true;
            this.rbtCopiaCedula.Text = "Copia de Cédula";
            this.rbtCopiaCedula.UseVisualStyleBackColor = true;
            this.rbtCopiaCedula.CheckedChanged += new System.EventHandler(this.btgTipoServicio_CheckedChanged);
            // 
            // rbtCopia
            // 
            this.rbtCopia.AutoSize = true;
            this.rbtCopia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtCopia.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCopia.Location = new System.Drawing.Point(26, 70);
            this.rbtCopia.Name = "rbtCopia";
            this.rbtCopia.Size = new System.Drawing.Size(71, 24);
            this.rbtCopia.TabIndex = 35;
            this.rbtCopia.TabStop = true;
            this.rbtCopia.Text = "Copia";
            this.rbtCopia.UseVisualStyleBackColor = true;
            this.rbtCopia.CheckedChanged += new System.EventHandler(this.btgTipoServicio_CheckedChanged);
            // 
            // rbtImpresion
            // 
            this.rbtImpresion.AutoSize = true;
            this.rbtImpresion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtImpresion.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtImpresion.Location = new System.Drawing.Point(26, 40);
            this.rbtImpresion.Name = "rbtImpresion";
            this.rbtImpresion.Size = new System.Drawing.Size(104, 24);
            this.rbtImpresion.TabIndex = 34;
            this.rbtImpresion.TabStop = true;
            this.rbtImpresion.Text = "Impresión";
            this.rbtImpresion.UseVisualStyleBackColor = true;
            this.rbtImpresion.CheckedChanged += new System.EventHandler(this.btgTipoServicio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tipo de servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 30;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(108, 69);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(352, 28);
            this.cmbTipo.TabIndex = 28;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // btgTamanio
            // 
            this.btgTamanio.Controls.Add(this.rbtChocoBanana);
            this.btgTamanio.Controls.Add(this.rbtPequenio);
            this.btgTamanio.Controls.Add(this.rbtCaja);
            this.btgTamanio.Controls.Add(this.rbtGrande);
            this.btgTamanio.Controls.Add(this.label3);
            this.btgTamanio.Location = new System.Drawing.Point(3, 60);
            this.btgTamanio.Name = "btgTamanio";
            this.btgTamanio.Size = new System.Drawing.Size(530, 50);
            this.btgTamanio.TabIndex = 25;
            // 
            // rbtChocoBanana
            // 
            this.rbtChocoBanana.AutoSize = true;
            this.rbtChocoBanana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtChocoBanana.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtChocoBanana.Location = new System.Drawing.Point(388, 12);
            this.rbtChocoBanana.Name = "rbtChocoBanana";
            this.rbtChocoBanana.Size = new System.Drawing.Size(130, 24);
            this.rbtChocoBanana.TabIndex = 28;
            this.rbtChocoBanana.TabStop = true;
            this.rbtChocoBanana.Text = "Choco banana";
            this.rbtChocoBanana.UseVisualStyleBackColor = true;
            this.rbtChocoBanana.CheckedChanged += new System.EventHandler(this.btgTamanio_CheckedChanged);
            // 
            // rbtPequenio
            // 
            this.rbtPequenio.AutoSize = true;
            this.rbtPequenio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtPequenio.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPequenio.Location = new System.Drawing.Point(87, 12);
            this.rbtPequenio.Name = "rbtPequenio";
            this.rbtPequenio.Size = new System.Drawing.Size(92, 24);
            this.rbtPequenio.TabIndex = 22;
            this.rbtPequenio.TabStop = true;
            this.rbtPequenio.Text = "Pequeño";
            this.rbtPequenio.UseVisualStyleBackColor = true;
            this.rbtPequenio.CheckedChanged += new System.EventHandler(this.btgTamanio_CheckedChanged);
            // 
            // rbtCaja
            // 
            this.rbtCaja.AutoSize = true;
            this.rbtCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtCaja.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCaja.Location = new System.Drawing.Point(303, 12);
            this.rbtCaja.Name = "rbtCaja";
            this.rbtCaja.Size = new System.Drawing.Size(61, 24);
            this.rbtCaja.TabIndex = 27;
            this.rbtCaja.TabStop = true;
            this.rbtCaja.Text = "Caja";
            this.rbtCaja.UseVisualStyleBackColor = true;
            this.rbtCaja.CheckedChanged += new System.EventHandler(this.btgTamanio_CheckedChanged);
            // 
            // rbtGrande
            // 
            this.rbtGrande.AutoSize = true;
            this.rbtGrande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtGrande.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGrande.Location = new System.Drawing.Point(199, 12);
            this.rbtGrande.Name = "rbtGrande";
            this.rbtGrande.Size = new System.Drawing.Size(81, 24);
            this.rbtGrande.TabIndex = 23;
            this.rbtGrande.TabStop = true;
            this.rbtGrande.Text = "Grande";
            this.rbtGrande.UseVisualStyleBackColor = true;
            this.rbtGrande.CheckedChanged += new System.EventHandler(this.btgTamanio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tamaño";
            // 
            // lblImpresionPrecioProducto
            // 
            this.lblImpresionPrecioProducto.AutoSize = true;
            this.lblImpresionPrecioProducto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpresionPrecioProducto.Location = new System.Drawing.Point(505, 134);
            this.lblImpresionPrecioProducto.Name = "lblImpresionPrecioProducto";
            this.lblImpresionPrecioProducto.Size = new System.Drawing.Size(37, 20);
            this.lblImpresionPrecioProducto.TabIndex = 28;
            this.lblImpresionPrecioProducto.Text = "lbl1";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProducto.Location = new System.Drawing.Point(505, 112);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(153, 20);
            this.lblPrecioProducto.TabIndex = 27;
            this.lblPrecioProducto.Text = "Precio del Producto";
            // 
            // btgTipoTinta
            // 
            this.btgTipoTinta.Controls.Add(this.rbtBlancoNegro);
            this.btgTipoTinta.Controls.Add(this.rbtColor);
            this.btgTipoTinta.Controls.Add(this.label1);
            this.btgTipoTinta.Location = new System.Drawing.Point(6, 46);
            this.btgTipoTinta.Name = "btgTipoTinta";
            this.btgTipoTinta.Size = new System.Drawing.Size(193, 118);
            this.btgTipoTinta.TabIndex = 25;
            // 
            // rbtBlancoNegro
            // 
            this.rbtBlancoNegro.AutoSize = true;
            this.rbtBlancoNegro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtBlancoNegro.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBlancoNegro.Location = new System.Drawing.Point(34, 54);
            this.rbtBlancoNegro.Name = "rbtBlancoNegro";
            this.rbtBlancoNegro.Size = new System.Drawing.Size(140, 24);
            this.rbtBlancoNegro.TabIndex = 29;
            this.rbtBlancoNegro.TabStop = true;
            this.rbtBlancoNegro.Text = "Blanco y Negro";
            this.rbtBlancoNegro.UseVisualStyleBackColor = true;
            this.rbtBlancoNegro.CheckedChanged += new System.EventHandler(this.btgTipoTinta_CheckedChanged);
            // 
            // rbtColor
            // 
            this.rbtColor.AutoSize = true;
            this.rbtColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtColor.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtColor.Location = new System.Drawing.Point(34, 84);
            this.rbtColor.Name = "rbtColor";
            this.rbtColor.Size = new System.Drawing.Size(70, 24);
            this.rbtColor.TabIndex = 28;
            this.rbtColor.TabStop = true;
            this.rbtColor.Text = "Color";
            this.rbtColor.UseVisualStyleBackColor = true;
            this.rbtColor.CheckedChanged += new System.EventHandler(this.btgTipoTinta_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tipo de tinta";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(111, 184);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(209, 27);
            this.txtCantidad.TabIndex = 21;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(13, 191);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblVentaTipo
            // 
            this.lblVentaTipo.AutoSize = true;
            this.lblVentaTipo.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaTipo.Location = new System.Drawing.Point(19, 16);
            this.lblVentaTipo.Name = "lblVentaTipo";
            this.lblVentaTipo.Size = new System.Drawing.Size(343, 27);
            this.lblVentaTipo.TabIndex = 21;
            this.lblVentaTipo.Text = "Seleccione la categoría de venta";
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.btnAgregarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnAgregarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(172)))), ((int)(((byte)(169)))));
            this.btnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductos.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductos.Location = new System.Drawing.Point(509, 179);
            this.btnAgregarProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(231, 45);
            this.btnAgregarProductos.TabIndex = 20;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = false;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // lblIdentificadorNombre
            // 
            this.lblIdentificadorNombre.AutoSize = true;
            this.lblIdentificadorNombre.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificadorNombre.Location = new System.Drawing.Point(17, 132);
            this.lblIdentificadorNombre.Name = "lblIdentificadorNombre";
            this.lblIdentificadorNombre.Size = new System.Drawing.Size(68, 20);
            this.lblIdentificadorNombre.TabIndex = 18;
            this.lblIdentificadorNombre.Text = "Nombre";
            // 
            // lblIdentificadorTipo
            // 
            this.lblIdentificadorTipo.AutoSize = true;
            this.lblIdentificadorTipo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificadorTipo.Location = new System.Drawing.Point(17, 72);
            this.lblIdentificadorTipo.Name = "lblIdentificadorTipo";
            this.lblIdentificadorTipo.Size = new System.Drawing.Size(42, 20);
            this.lblIdentificadorTipo.TabIndex = 13;
            this.lblIdentificadorTipo.Text = "Tipo";
            // 
            // btnPapeleria
            // 
            this.btnPapeleria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.btnPapeleria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPapeleria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnPapeleria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(172)))), ((int)(((byte)(169)))));
            this.btnPapeleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapeleria.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapeleria.Location = new System.Drawing.Point(34, 33);
            this.btnPapeleria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPapeleria.Name = "btnPapeleria";
            this.btnPapeleria.Size = new System.Drawing.Size(233, 45);
            this.btnPapeleria.TabIndex = 21;
            this.btnPapeleria.Text = "Papelería";
            this.btnPapeleria.UseVisualStyleBackColor = false;
            this.btnPapeleria.Click += new System.EventHandler(this.btnPapeleria_Click);
            // 
            // btnHeladeria
            // 
            this.btnHeladeria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.btnHeladeria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeladeria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnHeladeria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(172)))), ((int)(((byte)(169)))));
            this.btnHeladeria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeladeria.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeladeria.Location = new System.Drawing.Point(34, 93);
            this.btnHeladeria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHeladeria.Name = "btnHeladeria";
            this.btnHeladeria.Size = new System.Drawing.Size(233, 45);
            this.btnHeladeria.TabIndex = 22;
            this.btnHeladeria.Text = "Heladería";
            this.btnHeladeria.UseVisualStyleBackColor = false;
            this.btnHeladeria.Click += new System.EventHandler(this.btnHeladeria_Click);
            // 
            // btnConfeccion
            // 
            this.btnConfeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.btnConfeccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfeccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnConfeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(172)))), ((int)(((byte)(169)))));
            this.btnConfeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfeccion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfeccion.Location = new System.Drawing.Point(34, 157);
            this.btnConfeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfeccion.Name = "btnConfeccion";
            this.btnConfeccion.Size = new System.Drawing.Size(233, 45);
            this.btnConfeccion.TabIndex = 23;
            this.btnConfeccion.Text = "Confección";
            this.btnConfeccion.UseVisualStyleBackColor = false;
            this.btnConfeccion.Click += new System.EventHandler(this.btnConfeccion_Click);
            // 
            // btnImpresiones
            // 
            this.btnImpresiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.btnImpresiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpresiones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnImpresiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(172)))), ((int)(((byte)(169)))));
            this.btnImpresiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresiones.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpresiones.Location = new System.Drawing.Point(34, 219);
            this.btnImpresiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImpresiones.Name = "btnImpresiones";
            this.btnImpresiones.Size = new System.Drawing.Size(233, 45);
            this.btnImpresiones.TabIndex = 24;
            this.btnImpresiones.Text = "Impresiones";
            this.btnImpresiones.UseVisualStyleBackColor = false;
            this.btnImpresiones.Click += new System.EventHandler(this.btnImpresiones_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlPresentacionDatosRegistrados);
            this.panel1.Controls.Add(this.lblDolaresDelRegistro);
            this.panel1.Controls.Add(this.lblSubtotal);
            this.panel1.Controls.Add(this.lblRegistroTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblCantidadProductos);
            this.panel1.Controls.Add(this.lblPrecioRegistro);
            this.panel1.Controls.Add(this.lblNombreProductoRegistro);
            this.panel1.Controls.Add(this.lblProductosAgregados);
            this.panel1.Location = new System.Drawing.Point(629, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 286);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.CambiarColorPaneles_Paint);
            // 
            // pnlPresentacionDatosRegistrados
            // 
            this.pnlPresentacionDatosRegistrados.AutoScroll = true;
            this.pnlPresentacionDatosRegistrados.Controls.Add(this.lblRegistroSubtotal);
            this.pnlPresentacionDatosRegistrados.Controls.Add(this.lblRegistroProductos);
            this.pnlPresentacionDatosRegistrados.Controls.Add(this.lblRegistroPrecios);
            this.pnlPresentacionDatosRegistrados.Controls.Add(this.lblRegistroCantidad);
            this.pnlPresentacionDatosRegistrados.Location = new System.Drawing.Point(19, 79);
            this.pnlPresentacionDatosRegistrados.Name = "pnlPresentacionDatosRegistrados";
            this.pnlPresentacionDatosRegistrados.Size = new System.Drawing.Size(418, 172);
            this.pnlPresentacionDatosRegistrados.TabIndex = 40;
            // 
            // lblRegistroSubtotal
            // 
            this.lblRegistroSubtotal.AutoSize = true;
            this.lblRegistroSubtotal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroSubtotal.Location = new System.Drawing.Point(344, 9);
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
            this.lblRegistroPrecios.Location = new System.Drawing.Point(194, 9);
            this.lblRegistroPrecios.Name = "lblRegistroPrecios";
            this.lblRegistroPrecios.Size = new System.Drawing.Size(37, 20);
            this.lblRegistroPrecios.TabIndex = 30;
            this.lblRegistroPrecios.Text = "lbl1";
            // 
            // lblRegistroCantidad
            // 
            this.lblRegistroCantidad.AutoSize = true;
            this.lblRegistroCantidad.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroCantidad.Location = new System.Drawing.Point(275, 9);
            this.lblRegistroCantidad.Name = "lblRegistroCantidad";
            this.lblRegistroCantidad.Size = new System.Drawing.Size(37, 20);
            this.lblRegistroCantidad.TabIndex = 34;
            this.lblRegistroCantidad.Text = "lbl1";
            // 
            // lblDolaresDelRegistro
            // 
            this.lblDolaresDelRegistro.AutoSize = true;
            this.lblDolaresDelRegistro.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolaresDelRegistro.Location = new System.Drawing.Point(363, 254);
            this.lblDolaresDelRegistro.Name = "lblDolaresDelRegistro";
            this.lblDolaresDelRegistro.Size = new System.Drawing.Size(64, 20);
            this.lblDolaresDelRegistro.TabIndex = 39;
            this.lblDolaresDelRegistro.Text = "Dólares";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(363, 56);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(53, 20);
            this.lblSubtotal.TabIndex = 37;
            this.lblSubtotal.Text = "Sub. T.";
            // 
            // lblRegistroTotal
            // 
            this.lblRegistroTotal.AutoSize = true;
            this.lblRegistroTotal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroTotal.Location = new System.Drawing.Point(282, 254);
            this.lblRegistroTotal.Name = "lblRegistroTotal";
            this.lblRegistroTotal.Size = new System.Drawing.Size(37, 20);
            this.lblRegistroTotal.TabIndex = 36;
            this.lblRegistroTotal.Text = "lbl1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(213, 254);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 35;
            this.lblTotal.Text = "Total:";
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.AutoSize = true;
            this.lblCantidadProductos.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProductos.Location = new System.Drawing.Point(294, 56);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(45, 20);
            this.lblCantidadProductos.TabIndex = 33;
            this.lblCantidadProductos.Text = "Cant.";
            // 
            // lblPrecioRegistro
            // 
            this.lblPrecioRegistro.AutoSize = true;
            this.lblPrecioRegistro.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioRegistro.Location = new System.Drawing.Point(213, 56);
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
            this.lblNombreProductoRegistro.Size = new System.Drawing.Size(75, 20);
            this.lblNombreProductoRegistro.TabIndex = 31;
            this.lblNombreProductoRegistro.Text = "Nombres";
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
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.AllowUserToAddRows = false;
            this.dgvMostrarDatos.AllowUserToDeleteRows = false;
            this.dgvMostrarDatos.AllowUserToResizeColumns = false;
            this.dgvMostrarDatos.AllowUserToResizeRows = false;
            this.dgvMostrarDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(243)))));
            this.dgvMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(34, 302);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.RowHeadersWidth = 51;
            this.dgvMostrarDatos.RowTemplate.Height = 24;
            this.dgvMostrarDatos.Size = new System.Drawing.Size(589, 286);
            this.dgvMostrarDatos.TabIndex = 26;
            this.dgvMostrarDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarDatos_CellClick);
            this.dgvMostrarDatos.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarDatos_CellMouseLeave);
            this.dgvMostrarDatos.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMostrarDatos_CellMouseMove);
            // 
            // btnEliminarVentaErronea
            // 
            this.btnEliminarVentaErronea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(209)))), ((int)(((byte)(167)))));
            this.btnEliminarVentaErronea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarVentaErronea.FlatAppearance.BorderSize = 0;
            this.btnEliminarVentaErronea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarVentaErronea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVentaErronea.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVentaErronea.Location = new System.Drawing.Point(34, 599);
            this.btnEliminarVentaErronea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarVentaErronea.Name = "btnEliminarVentaErronea";
            this.btnEliminarVentaErronea.Size = new System.Drawing.Size(242, 57);
            this.btnEliminarVentaErronea.TabIndex = 27;
            this.btnEliminarVentaErronea.Text = "Eliminar Venta Erronea";
            this.btnEliminarVentaErronea.UseVisualStyleBackColor = false;
            this.btnEliminarVentaErronea.Click += new System.EventHandler(this.btnEliminarVentaErronea_Click);
            // 
            // btnRegistrarVentaProductos
            // 
            this.btnRegistrarVentaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(209)))), ((int)(((byte)(167)))));
            this.btnRegistrarVentaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarVentaProductos.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVentaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVentaProductos.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVentaProductos.Location = new System.Drawing.Point(682, 599);
            this.btnRegistrarVentaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarVentaProductos.Name = "btnRegistrarVentaProductos";
            this.btnRegistrarVentaProductos.Size = new System.Drawing.Size(180, 57);
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
            this.btnQuitarUltimoAgregado.Location = new System.Drawing.Point(889, 599);
            this.btnQuitarUltimoAgregado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarUltimoAgregado.Name = "btnQuitarUltimoAgregado";
            this.btnQuitarUltimoAgregado.Size = new System.Drawing.Size(180, 57);
            this.btnQuitarUltimoAgregado.TabIndex = 28;
            this.btnQuitarUltimoAgregado.Text = "Quitar Último Producto Agregado";
            this.btnQuitarUltimoAgregado.UseVisualStyleBackColor = false;
            this.btnQuitarUltimoAgregado.Click += new System.EventHandler(this.btnQuitarUltimoAgregado_Click);
            // 
            // FrmRegistrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1103, 676);
            this.Controls.Add(this.btnQuitarUltimoAgregado);
            this.Controls.Add(this.btnRegistrarVentaProductos);
            this.Controls.Add(this.btnEliminarVentaErronea);
            this.Controls.Add(this.dgvMostrarDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImpresiones);
            this.Controls.Add(this.btnConfeccion);
            this.Controls.Add(this.btnHeladeria);
            this.Controls.Add(this.btnPapeleria);
            this.Controls.Add(this.pnlVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistrarVentas";
            this.Text = "FrmRegistrarVentas";
            this.pnlVenta.ResumeLayout(false);
            this.pnlVenta.PerformLayout();
            this.btgTipoServicio.ResumeLayout(false);
            this.btgTipoServicio.PerformLayout();
            this.btgTamanio.ResumeLayout(false);
            this.btgTamanio.PerformLayout();
            this.btgTipoTinta.ResumeLayout(false);
            this.btgTipoTinta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPresentacionDatosRegistrados.ResumeLayout(false);
            this.pnlPresentacionDatosRegistrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVenta;
        private System.Windows.Forms.Label lblIdentificadorNombre;
        private System.Windows.Forms.Label lblIdentificadorTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.RadioButton rbtGrande;
        private System.Windows.Forms.RadioButton rbtPequenio;
        private System.Windows.Forms.Label lblVentaTipo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnPapeleria;
        private System.Windows.Forms.Button btnHeladeria;
        private System.Windows.Forms.Button btnConfeccion;
        private System.Windows.Forms.Button btnImpresiones;
        private System.Windows.Forms.RadioButton rbtCaja;
        private System.Windows.Forms.Panel btgTamanio;
        private System.Windows.Forms.Panel btgTipoTinta;
        private System.Windows.Forms.RadioButton rbtBlancoNegro;
        private System.Windows.Forms.RadioButton rbtColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel btgTipoServicio;
        private System.Windows.Forms.RadioButton rbtCopia;
        private System.Windows.Forms.RadioButton rbtImpresion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.Button btnEliminarVentaErronea;
        private System.Windows.Forms.Button btnRegistrarVentaProductos;
        private System.Windows.Forms.Label lblImpresionPrecioProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblProductosAgregados;
        private System.Windows.Forms.Button btnQuitarUltimoAgregado;
        private System.Windows.Forms.Label lblRegistroPrecios;
        private System.Windows.Forms.Label lblRegistroProductos;
        private System.Windows.Forms.RadioButton rbtCopiaCedula;
        private System.Windows.Forms.RadioButton rbtChocoBanana;
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
    }
}