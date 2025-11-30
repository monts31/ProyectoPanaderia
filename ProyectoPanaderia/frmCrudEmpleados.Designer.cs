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
            dgvEmpleados.Location = new Point(197, 90);
            dgvEmpleados.Margin = new Padding(3, 2, 3, 2);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(870, 418);
            dgvEmpleados.TabIndex = 0;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(226, 253, 208);
            btnRegresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(30, 16);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(54, 41);
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
            lblCrudEmpleados.Location = new Point(112, 25);
            lblCrudEmpleados.Name = "lblCrudEmpleados";
            lblCrudEmpleados.Size = new Size(218, 22);
            lblCrudEmpleados.TabIndex = 2;
            lblCrudEmpleados.Text = "CRUD DE EMPLEADOS";
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(226, 253, 208);
            btnInsertar.Font = new Font("Baskerville Old Face", 15.75F);
            btnInsertar.Location = new Point(255, 551);
            btnInsertar.Margin = new Padding(3, 2, 3, 2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(174, 31);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(226, 253, 208);
            btnModificar.Font = new Font("Baskerville Old Face", 15.75F);
            btnModificar.Location = new Point(559, 551);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(174, 31);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(226, 253, 208);
            btnEliminar.Font = new Font("Baskerville Old Face", 15.75F);
            btnEliminar.Location = new Point(858, 551);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(174, 31);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmCrudEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 617);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(lblCrudEmpleados);
            Controls.Add(btnRegresar);
            Controls.Add(dgvEmpleados);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
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