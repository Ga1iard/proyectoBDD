namespace negocioPapeleria
{
    partial class FrmResumenVentas
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
            this.pnlNumeroProductos = new System.Windows.Forms.Panel();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblNumeroProductos = new System.Windows.Forms.Label();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.btnGenerarDocumento = new System.Windows.Forms.Button();
            this.lblIngresosFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtAnio = new System.Windows.Forms.RadioButton();
            this.rbtMes = new System.Windows.Forms.RadioButton();
            this.rbtDia = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFitros = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.dgvMostrarDatos = new System.Windows.Forms.DataGridView();
            this.pnlNumeroProductos.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNumeroProductos
            // 
            this.pnlNumeroProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(217)))));
            this.pnlNumeroProductos.Controls.Add(this.lblIngresos);
            this.pnlNumeroProductos.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNumeroProductos.Location = new System.Drawing.Point(828, 67);
            this.pnlNumeroProductos.Name = "pnlNumeroProductos";
            this.pnlNumeroProductos.Size = new System.Drawing.Size(210, 43);
            this.pnlNumeroProductos.TabIndex = 47;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.Location = new System.Drawing.Point(37, 13);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(89, 20);
            this.lblIngresos.TabIndex = 43;
            this.lblIngresos.Text = "lblIngresos";
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
            // pnlFecha
            // 
            this.pnlFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(217)))));
            this.pnlFecha.Controls.Add(this.lblNumeroProductos);
            this.pnlFecha.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFecha.Location = new System.Drawing.Point(574, 67);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(210, 43);
            this.pnlFecha.TabIndex = 46;
            // 
            // btnGenerarDocumento
            // 
            this.btnGenerarDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(209)))), ((int)(((byte)(167)))));
            this.btnGenerarDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarDocumento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(83)))), ((int)(((byte)(66)))));
            this.btnGenerarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarDocumento.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.btnGenerarDocumento.Location = new System.Drawing.Point(27, 32);
            this.btnGenerarDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarDocumento.Name = "btnGenerarDocumento";
            this.btnGenerarDocumento.Size = new System.Drawing.Size(274, 45);
            this.btnGenerarDocumento.TabIndex = 45;
            this.btnGenerarDocumento.Text = "Generar Documento";
            this.btnGenerarDocumento.UseVisualStyleBackColor = false;
            this.btnGenerarDocumento.Click += new System.EventHandler(this.btnGenerarDocumento_Click);
            // 
            // lblIngresosFecha
            // 
            this.lblIngresosFecha.AutoSize = true;
            this.lblIngresosFecha.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresosFecha.Location = new System.Drawing.Point(824, 44);
            this.lblIngresosFecha.Name = "lblIngresosFecha";
            this.lblIngresosFecha.Size = new System.Drawing.Size(99, 20);
            this.lblIngresosFecha.TabIndex = 44;
            this.lblIngresosFecha.Text = "Ingresos el ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 27);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ventas Realizadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Número de Ventas";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbtAnio);
            this.panel2.Controls.Add(this.rbtMes);
            this.panel2.Controls.Add(this.rbtDia);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.lblFechaVenta);
            this.panel2.Controls.Add(this.lblTipoProducto);
            this.panel2.Controls.Add(this.lblCategoriaProducto);
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.btnLimpiarFitros);
            this.panel2.Controls.Add(this.btnMostrarTodo);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.cmbCategoria);
            this.panel2.Controls.Add(this.dgvMostrarDatos);
            this.panel2.Location = new System.Drawing.Point(27, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 492);
            this.panel2.TabIndex = 41;
            // 
            // rbtAnio
            // 
            this.rbtAnio.AutoSize = true;
            this.rbtAnio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtAnio.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAnio.Location = new System.Drawing.Point(533, 118);
            this.rbtAnio.Name = "rbtAnio";
            this.rbtAnio.Size = new System.Drawing.Size(59, 24);
            this.rbtAnio.TabIndex = 42;
            this.rbtAnio.TabStop = true;
            this.rbtAnio.Text = "Año";
            this.rbtAnio.UseVisualStyleBackColor = true;
            this.rbtAnio.CheckedChanged += new System.EventHandler(this.btgFiltrarSegun_CheckedChanged);
            // 
            // rbtMes
            // 
            this.rbtMes.AutoSize = true;
            this.rbtMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtMes.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMes.Location = new System.Drawing.Point(533, 82);
            this.rbtMes.Name = "rbtMes";
            this.rbtMes.Size = new System.Drawing.Size(59, 24);
            this.rbtMes.TabIndex = 41;
            this.rbtMes.TabStop = true;
            this.rbtMes.Text = "Mes";
            this.rbtMes.UseVisualStyleBackColor = true;
            this.rbtMes.CheckedChanged += new System.EventHandler(this.btgFiltrarSegun_CheckedChanged);
            // 
            // rbtDia
            // 
            this.rbtDia.AutoSize = true;
            this.rbtDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtDia.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDia.Location = new System.Drawing.Point(533, 49);
            this.rbtDia.Name = "rbtDia";
            this.rbtDia.Size = new System.Drawing.Size(54, 24);
            this.rbtDia.TabIndex = 40;
            this.rbtDia.TabStop = true;
            this.rbtDia.Text = "Día";
            this.rbtDia.UseVisualStyleBackColor = true;
            this.rbtDia.CheckedChanged += new System.EventHandler(this.btgFiltrarSegun_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Filtrar según";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(704, 49);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(325, 27);
            this.dtpFecha.TabIndex = 38;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(700, 15);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(115, 20);
            this.lblFechaVenta.TabIndex = 37;
            this.lblFechaVenta.Text = "Fecha de venta";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(11, 70);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(42, 20);
            this.lblTipoProducto.TabIndex = 36;
            this.lblTipoProducto.Text = "Tipo";
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProducto.Location = new System.Drawing.Point(11, 15);
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(78, 20);
            this.lblCategoriaProducto.TabIndex = 35;
            this.lblCategoriaProducto.Text = "Categoría";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(104, 70);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(370, 28);
            this.cmbTipo.TabIndex = 34;
            // 
            // btnLimpiarFitros
            // 
            this.btnLimpiarFitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiarFitros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarFitros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiarFitros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFitros.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFitros.Location = new System.Drawing.Point(874, 102);
            this.btnLimpiarFitros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarFitros.Name = "btnLimpiarFitros";
            this.btnLimpiarFitros.Size = new System.Drawing.Size(155, 45);
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
            this.btnMostrarTodo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodo.Location = new System.Drawing.Point(15, 112);
            this.btnMostrarTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(459, 36);
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
            this.btnFiltrar.Location = new System.Drawing.Point(693, 102);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(155, 45);
            this.btnFiltrar.TabIndex = 31;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(104, 15);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(370, 28);
            this.cmbCategoria.TabIndex = 30;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.AllowUserToAddRows = false;
            this.dgvMostrarDatos.AllowUserToResizeColumns = false;
            this.dgvMostrarDatos.AllowUserToResizeRows = false;
            this.dgvMostrarDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(243)))));
            this.dgvMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(15, 169);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.RowHeadersWidth = 51;
            this.dgvMostrarDatos.RowTemplate.Height = 24;
            this.dgvMostrarDatos.Size = new System.Drawing.Size(1014, 305);
            this.dgvMostrarDatos.TabIndex = 0;
            // 
            // FrmResumenVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1103, 676);
            this.Controls.Add(this.pnlNumeroProductos);
            this.Controls.Add(this.pnlFecha);
            this.Controls.Add(this.btnGenerarDocumento);
            this.Controls.Add(this.lblIngresosFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmResumenVentas";
            this.Text = "FrmResumenVentas";
            this.pnlNumeroProductos.ResumeLayout(false);
            this.pnlNumeroProductos.PerformLayout();
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNumeroProductos;
        private System.Windows.Forms.Label lblNumeroProductos;
        private System.Windows.Forms.Panel pnlFecha;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Button btnGenerarDocumento;
        private System.Windows.Forms.Label lblIngresosFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblCategoriaProducto;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnLimpiarFitros;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtAnio;
        private System.Windows.Forms.RadioButton rbtMes;
        private System.Windows.Forms.RadioButton rbtDia;
    }
}