namespace ProyectoPanaderia
{
    partial class frmCrudEmpleados
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
            dgvEmpleados = new DataGridView();
            btnRegresar = new Button();
            lblCrudEmpleados = new Label();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(40, 81);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(909, 365);
            dgvEmpleados.TabIndex = 0;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(4, 4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(46, 41);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "<---";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblCrudEmpleados
            // 
            lblCrudEmpleados.AutoSize = true;
            lblCrudEmpleados.Location = new Point(85, 14);
            lblCrudEmpleados.Name = "lblCrudEmpleados";
            lblCrudEmpleados.Size = new Size(147, 20);
            lblCrudEmpleados.TabIndex = 2;
            lblCrudEmpleados.Text = "CRUD de empleados";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(40, 484);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 41);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(189, 484);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 41);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(337, 484);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 41);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmCrudEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 607);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(lblCrudEmpleados);
            Controls.Add(btnRegresar);
            Controls.Add(dgvEmpleados);
            Name = "frmCrudEmpleados";
            Text = "frmCrudEmpleados";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button btnRegresar;
        private Label lblCrudEmpleados;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}