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
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFitros = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
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
            this.label2.Location = new System.Drawing.Point(779, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Número de Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 27);
            this.label3.TabIndex = 36;
            this.label3.Text = "Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(779, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Fecha";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pnlFecha);
            this.panel2.Controls.Add(this.pnlNumeroProductos);
            this.panel2.Controls.Add(this.lblTipoProducto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblCategoriaProducto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.btnLimpiarFitros);
            this.panel2.Controls.Add(this.btnMostrarTodo);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.cmbCategoria);
            this.panel2.Controls.Add(this.dgvMostrarDatos);
            this.panel2.Location = new System.Drawing.Point(26, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 540);
            this.panel2.TabIndex = 34;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(39, 90);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(42, 20);
            this.lblTipoProducto.TabIndex = 36;
            this.lblTipoProducto.Text = "Tipo";
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProducto.Location = new System.Drawing.Point(39, 30);
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(78, 20);
            this.lblCategoriaProducto.TabIndex = 35;
            this.lblCategoriaProducto.Text = "Categoría";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(132, 87);
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
            this.btnLimpiarFitros.Location = new System.Drawing.Point(524, 117);
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
            this.btnMostrarTodo.Location = new System.Drawing.Point(43, 138);
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
            this.btnFiltrar.Location = new System.Drawing.Point(524, 45);
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
            this.cmbCategoria.Location = new System.Drawing.Point(132, 26);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(352, 28);
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
            this.dgvMostrarDatos.Location = new System.Drawing.Point(15, 205);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.RowHeadersWidth = 51;
            this.dgvMostrarDatos.RowTemplate.Height = 24;
            this.dgvMostrarDatos.Size = new System.Drawing.Size(1014, 318);
            this.dgvMostrarDatos.TabIndex = 0;
            // 
            // pnlFecha
            // 
            this.pnlFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(217)))));
            this.pnlFecha.Controls.Add(this.lblFecha);
            this.pnlFecha.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFecha.Location = new System.Drawing.Point(783, 47);
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
            this.pnlNumeroProductos.Location = new System.Drawing.Point(783, 140);
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
            this.btnGenerarDocumento.Location = new System.Drawing.Point(801, 36);
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
            this.Controls.Add(this.btnGenerarDocumento);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.Panel pnlFecha;
        private System.Windows.Forms.Panel pnlNumeroProductos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumeroProductos;
        private System.Windows.Forms.Button btnGenerarDocumento;
    }
}