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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            lblCrudProductos = new Label();
            btnRegresar = new Button();
            dgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(336, 482);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 41);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(188, 482);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 41);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modifical";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(39, 482);
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
            lblCrudProductos.Location = new Point(84, 12);
            lblCrudProductos.Name = "lblCrudProductos";
            lblCrudProductos.Size = new Size(140, 20);
            lblCrudProductos.TabIndex = 8;
            lblCrudProductos.Text = "CRUD de productos";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(46, 41);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "<---";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(39, 79);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(909, 365);
            dgvProductos.TabIndex = 6;
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
    }
}