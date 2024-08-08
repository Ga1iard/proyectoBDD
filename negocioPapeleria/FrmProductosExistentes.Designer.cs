namespace negocioPapeleria
{
    partial class FrmProductosExistentes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPrecioMayor = new System.Windows.Forms.Label();
            this.txtPrecioMayor = new System.Windows.Forms.TextBox();
            this.rbtRangoPrecio = new System.Windows.Forms.RadioButton();
            this.rbtPrecioEspecífico = new System.Windows.Forms.RadioButton();
            this.lblOpcionPrecio = new System.Windows.Forms.Label();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFitros = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dgvMostrarDatos = new System.Windows.Forms.DataGridView();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlNumeroProductos = new System.Windows.Forms.Panel();
            this.lblNumeroProductos = new System.Windows.Forms.Label();
            this.btnGenerarDocumento = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            this.pnlFecha.SuspendLayout();
            this.pnlNumeroProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(823, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Número de Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 27);
            this.label3.TabIndex = 36;
            this.label3.Text = "Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Fecha";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPrecio);
            this.panel2.Controls.Add(this.lblPrecioMayor);
            this.panel2.Controls.Add(this.txtPrecioMayor);
            this.panel2.Controls.Add(this.rbtRangoPrecio);
            this.panel2.Controls.Add(this.rbtPrecioEspecífico);
            this.panel2.Controls.Add(this.lblOpcionPrecio);
            this.panel2.Controls.Add(this.lblTipoProducto);
            this.panel2.Controls.Add(this.lblCategoriaProducto);
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.btnLimpiarFitros);
            this.panel2.Controls.Add(this.btnMostrarTodo);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.cmbCategoria);
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Controls.Add(this.dgvMostrarDatos);
            this.panel2.Location = new System.Drawing.Point(26, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 492);
            this.panel2.TabIndex = 34;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(515, 114);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 20);
            this.lblPrecio.TabIndex = 42;
            this.lblPrecio.Text = "Precio";
            // 
            // lblPrecioMayor
            // 
            this.lblPrecioMayor.AutoSize = true;
            this.lblPrecioMayor.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMayor.Location = new System.Drawing.Point(515, 156);
            this.lblPrecioMayor.Name = "lblPrecioMayor";
            this.lblPrecioMayor.Size = new System.Drawing.Size(50, 20);
            this.lblPrecioMayor.TabIndex = 41;
            this.lblPrecioMayor.Text = "Hasta";
            // 
            // txtPrecioMayor
            // 
            this.txtPrecioMayor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioMayor.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioMayor.Location = new System.Drawing.Point(636, 156);
            this.txtPrecioMayor.Name = "txtPrecioMayor";
            this.txtPrecioMayor.Size = new System.Drawing.Size(167, 27);
            this.txtPrecioMayor.TabIndex = 40;
            // 
            // rbtRangoPrecio
            // 
            this.rbtRangoPrecio.AutoSize = true;
            this.rbtRangoPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtRangoPrecio.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtRangoPrecio.Location = new System.Drawing.Point(662, 61);
            this.rbtRangoPrecio.Name = "rbtRangoPrecio";
            this.rbtRangoPrecio.Size = new System.Drawing.Size(153, 24);
            this.rbtRangoPrecio.TabIndex = 39;
            this.rbtRangoPrecio.TabStop = true;
            this.rbtRangoPrecio.Text = "Rango de precios";
            this.rbtRangoPrecio.UseVisualStyleBackColor = true;
            this.rbtRangoPrecio.CheckedChanged += new System.EventHandler(this.btgFiltroPrecio_CheckedChanged);
            // 
            // rbtPrecioEspecífico
            // 
            this.rbtPrecioEspecífico.AutoSize = true;
            this.rbtPrecioEspecífico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtPrecioEspecífico.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPrecioEspecífico.Location = new System.Drawing.Point(491, 61);
            this.rbtPrecioEspecífico.Name = "rbtPrecioEspecífico";
            this.rbtPrecioEspecífico.Size = new System.Drawing.Size(153, 24);
            this.rbtPrecioEspecífico.TabIndex = 38;
            this.rbtPrecioEspecífico.TabStop = true;
            this.rbtPrecioEspecífico.Text = "Precio específico";
            this.rbtPrecioEspecífico.UseVisualStyleBackColor = true;
            this.rbtPrecioEspecífico.CheckedChanged += new System.EventHandler(this.btgFiltroPrecio_CheckedChanged);
            // 
            // lblOpcionPrecio
            // 
            this.lblOpcionPrecio.AutoSize = true;
            this.lblOpcionPrecio.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionPrecio.Location = new System.Drawing.Point(487, 30);
            this.lblOpcionPrecio.Name = "lblOpcionPrecio";
            this.lblOpcionPrecio.Size = new System.Drawing.Size(146, 20);
            this.lblOpcionPrecio.TabIndex = 37;
            this.lblOpcionPrecio.Text = "Filtrado por precio";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(11, 90);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(42, 20);
            this.lblTipoProducto.TabIndex = 36;
            this.lblTipoProducto.Text = "Tipo";
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProducto.Location = new System.Drawing.Point(11, 30);
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(78, 20);
            this.lblCategoriaProducto.TabIndex = 35;
            this.lblCategoriaProducto.Text = "Categoría";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(104, 87);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(352, 28);
            this.cmbTipo.TabIndex = 34;
            // 
            // btnLimpiarFitros
            // 
            this.btnLimpiarFitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiarFitros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarFitros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiarFitros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFitros.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFitros.Location = new System.Drawing.Point(846, 117);
            this.btnLimpiarFitros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarFitros.Name = "btnLimpiarFitros";
            this.btnLimpiarFitros.Size = new System.Drawing.Size(183, 45);
            this.btnLimpiarFitros.TabIndex = 33;
            this.btnLimpiarFitros.Text = "Limpiar Filtros";
            this.btnLimpiarFitros.UseVisualStyleBackColor = false;
            this.btnLimpiarFitros.Click += new System.EventHandler(this.btnLimpiarFitros_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(209)))), ((int)(((byte)(167)))));
            this.btnMostrarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(83)))), ((int)(((byte)(66)))));
            this.btnMostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodo.Location = new System.Drawing.Point(15, 138);
            this.btnMostrarTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(441, 45);
            this.btnMostrarTodo.TabIndex = 32;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = false;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(172)))), ((int)(((byte)(169)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(846, 40);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(183, 45);
            this.btnFiltrar.TabIndex = 31;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(104, 26);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(352, 28);
            this.cmbCategoria.TabIndex = 30;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(636, 107);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(167, 27);
            this.txtPrecio.TabIndex = 22;
            // 
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.AllowUserToAddRows = false;
            this.dgvMostrarDatos.AllowUserToResizeColumns = false;
            this.dgvMostrarDatos.AllowUserToResizeRows = false;
            this.dgvMostrarDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(243)))));
            this.dgvMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(15, 201);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.RowHeadersWidth = 51;
            this.dgvMostrarDatos.RowTemplate.Height = 24;
            this.dgvMostrarDatos.Size = new System.Drawing.Size(1014, 273);
            this.dgvMostrarDatos.TabIndex = 0;
            // 
            // pnlFecha
            // 
            this.pnlFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(217)))));
            this.pnlFecha.Controls.Add(this.lblFecha);
            this.pnlFecha.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFecha.Location = new System.Drawing.Point(573, 65);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(210, 43);
            this.pnlFecha.TabIndex = 39;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(52, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 20);
            this.lblFecha.TabIndex = 43;
            this.lblFecha.Text = "lblFecha";
            // 
            // pnlNumeroProductos
            // 
            this.pnlNumeroProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(217)))));
            this.pnlNumeroProductos.Controls.Add(this.lblNumeroProductos);
            this.pnlNumeroProductos.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNumeroProductos.Location = new System.Drawing.Point(827, 65);
            this.pnlNumeroProductos.Name = "pnlNumeroProductos";
            this.pnlNumeroProductos.Size = new System.Drawing.Size(210, 43);
            this.pnlNumeroProductos.TabIndex = 40;
            // 
            // lblNumeroProductos
            // 
            this.lblNumeroProductos.AutoSize = true;
            this.lblNumeroProductos.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroProductos.Location = new System.Drawing.Point(82, 13);
            this.lblNumeroProductos.Name = "lblNumeroProductos";
            this.lblNumeroProductos.Size = new System.Drawing.Size(50, 20);
            this.lblNumeroProductos.TabIndex = 44;
            this.lblNumeroProductos.Text = "lblNP";
            // 
            // btnGenerarDocumento
            // 
            this.btnGenerarDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(209)))), ((int)(((byte)(167)))));
            this.btnGenerarDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarDocumento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(83)))), ((int)(((byte)(66)))));
            this.btnGenerarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarDocumento.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarDocumento.Location = new System.Drawing.Point(26, 30);
            this.btnGenerarDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarDocumento.Name = "btnGenerarDocumento";
            this.btnGenerarDocumento.Size = new System.Drawing.Size(274, 45);
            this.btnGenerarDocumento.TabIndex = 38;
            this.btnGenerarDocumento.Text = "Generar Documento";
            this.btnGenerarDocumento.UseVisualStyleBackColor = false;
            this.btnGenerarDocumento.Click += new System.EventHandler(this.btnGenerarDocumento_Click);
            // 
            // FrmProductosExistentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1103, 676);
            this.Controls.Add(this.pnlNumeroProductos);
            this.Controls.Add(this.pnlFecha);
            this.Controls.Add(this.btnGenerarDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProductosExistentes";
            this.Text = "FrmProductosExistentes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).EndInit();
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            this.pnlNumeroProductos.ResumeLayout(false);
            this.pnlNumeroProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblCategoriaProducto;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnLimpiarFitros;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.Panel pnlFecha;
        private System.Windows.Forms.Panel pnlNumeroProductos;
        private System.Windows.Forms.Label lblOpcionPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPrecioMayor;
        private System.Windows.Forms.TextBox txtPrecioMayor;
        private System.Windows.Forms.RadioButton rbtRangoPrecio;
        private System.Windows.Forms.RadioButton rbtPrecioEspecífico;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumeroProductos;
        private System.Windows.Forms.Button btnGenerarDocumento;
    }
}