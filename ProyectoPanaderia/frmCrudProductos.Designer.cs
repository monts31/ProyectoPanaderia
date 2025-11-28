namespace ProyectoPanaderia
{
    partial class frmCrudProductos
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
            components = new System.ComponentModel.Container();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            lblCrudProductos = new Label();
            btnRegresar = new Button();
            dgvProductos = new DataGridView();
            idProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fotoDataGridViewImageColumn = new DataGridViewImageColumn();
            clsProductosBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clsProductosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(336, 483);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 41);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(187, 483);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 41);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(39, 483);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 41);
            btnInsertar.TabIndex = 9;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblCrudProductos
            // 
            lblCrudProductos.AutoSize = true;
            lblCrudProductos.Location = new Point(85, 12);
            lblCrudProductos.Name = "lblCrudProductos";
            lblCrudProductos.Size = new Size(140, 20);
            lblCrudProductos.TabIndex = 8;
            lblCrudProductos.Text = "CRUD de productos";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(3, 3);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(46, 41);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "<---";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { idProductoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn, fotoDataGridViewImageColumn });
            dgvProductos.DataSource = clsProductosBindingSource;
            dgvProductos.Location = new Point(39, 79);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(909, 365);
            dgvProductos.TabIndex = 6;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            idProductoDataGridViewTextBoxColumn.DataPropertyName = "id_Producto";
            idProductoDataGridViewTextBoxColumn.HeaderText = "id_Producto";
            idProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            idProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            precioDataGridViewTextBoxColumn.HeaderText = "precio";
            precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            stockDataGridViewTextBoxColumn.HeaderText = "stock";
            stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // fotoDataGridViewImageColumn
            // 
            fotoDataGridViewImageColumn.DataPropertyName = "foto";
            fotoDataGridViewImageColumn.HeaderText = "foto";
            fotoDataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            fotoDataGridViewImageColumn.MinimumWidth = 6;
            fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            fotoDataGridViewImageColumn.Width = 125;
            // 
            // clsProductosBindingSource
            // 
            clsProductosBindingSource.DataSource = typeof(POJO.clsProductos);
            // 
            // frmCrudProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 556);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(lblCrudProductos);
            Controls.Add(btnRegresar);
            Controls.Add(dgvProductos);
            Name = "frmCrudProductos";
            Text = "frmCrudProductos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)clsProductosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnInsertar;
        private Label lblCrudProductos;
        private Button btnRegresar;
        private DataGridView dgvProductos;
        private BindingSource clsProductosBindingSource;
        private DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewImageColumn fotoDataGridViewImageColumn;
    }
}