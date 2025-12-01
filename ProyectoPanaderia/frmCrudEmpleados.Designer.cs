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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrudEmpleados));
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
            dgvEmpleados.BackgroundColor = Color.FromArgb(218, 251, 213);
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(242, 126);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(1123, 557);
            dgvEmpleados.TabIndex = 0;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(226, 253, 208);
            btnRegresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(34, 21);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(62, 55);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "<---";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblCrudEmpleados
            // 
            lblCrudEmpleados.AutoSize = true;
            lblCrudEmpleados.BackColor = Color.Transparent;
            lblCrudEmpleados.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCrudEmpleados.Location = new Point(141, 33);
            lblCrudEmpleados.Name = "lblCrudEmpleados";
            lblCrudEmpleados.Size = new Size(274, 27);
            lblCrudEmpleados.TabIndex = 2;
            lblCrudEmpleados.Text = "CRUD DE EMPLEADOS";
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(226, 253, 208);
            btnInsertar.Font = new Font("Baskerville Old Face", 15.75F);
            btnInsertar.Location = new Point(324, 735);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(199, 41);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(226, 253, 208);
            btnModificar.Font = new Font("Baskerville Old Face", 15.75F);
            btnModificar.Location = new Point(712, 735);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(199, 41);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(226, 253, 208);
            btnEliminar.Font = new Font("Baskerville Old Face", 15.75F);
            btnEliminar.Location = new Point(1077, 735);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(199, 41);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmCrudEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1477, 823);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(lblCrudEmpleados);
            Controls.Add(btnRegresar);
            Controls.Add(dgvEmpleados);
            DoubleBuffered = true;
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