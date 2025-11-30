namespace ProyectoPanaderia
{
    partial class frmMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdmin));
            btnProductos = new Button();
            btnAuditorias = new Button();
            btnReportes = new Button();
            btnVentas = new Button();
            Crud_Empleados = new Button();
            lblEmpleado = new Label();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(215, 237, 197);
            btnProductos.Font = new Font("Baskerville Old Face", 15.75F);
            btnProductos.Location = new Point(453, 316);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(244, 54);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "CRUD PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnAuditorias
            // 
            btnAuditorias.BackColor = Color.FromArgb(215, 237, 197);
            btnAuditorias.Font = new Font("Baskerville Old Face", 15.75F);
            btnAuditorias.Location = new Point(701, 151);
            btnAuditorias.Name = "btnAuditorias";
            btnAuditorias.Size = new Size(244, 54);
            btnAuditorias.TabIndex = 5;
            btnAuditorias.Text = "AUDITORIAS";
            btnAuditorias.UseVisualStyleBackColor = false;
            btnAuditorias.Click += btnAuditorias_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(215, 237, 197);
            btnReportes.Font = new Font("Baskerville Old Face", 15.75F);
            btnReportes.Location = new Point(701, 467);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(244, 54);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "REPORTES";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnDetallesdeorden_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(215, 237, 197);
            btnVentas.Font = new Font("Baskerville Old Face", 15.75F);
            btnVentas.Location = new Point(171, 467);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(244, 54);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "VENTAS";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // Crud_Empleados
            // 
            Crud_Empleados.BackColor = Color.FromArgb(215, 237, 197);
            Crud_Empleados.Font = new Font("Baskerville Old Face", 15.75F);
            Crud_Empleados.Location = new Point(171, 151);
            Crud_Empleados.Name = "Crud_Empleados";
            Crud_Empleados.Size = new Size(244, 54);
            Crud_Empleados.TabIndex = 8;
            Crud_Empleados.Text = "CRUD EMPLEADOS";
            Crud_Empleados.UseVisualStyleBackColor = false;
            Crud_Empleados.Click += Crud_Empleados_Click;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.BackColor = Color.Transparent;
            lblEmpleado.Font = new Font("Baskerville Old Face", 15.75F);
            lblEmpleado.Location = new Point(101, 52);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(104, 24);
            lblEmpleado.TabIndex = 9;
            lblEmpleado.Text = "Bievenido: ";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Brown;
            btnCerrarSesion.Font = new Font("Baskerville Old Face", 15.75F);
            btnCerrarSesion.ForeColor = SystemColors.ButtonHighlight;
            btnCerrarSesion.Location = new Point(938, 44);
            btnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(160, 40);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // frmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1188, 616);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblEmpleado);
            Controls.Add(Crud_Empleados);
            Controls.Add(btnVentas);
            Controls.Add(btnAuditorias);
            Controls.Add(btnReportes);
            Controls.Add(btnProductos);
            DoubleBuffered = true;
            Name = "frmMenuAdmin";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnProductos;
        private Button btnAuditorias;
        private Button btnReportes;
        private Button btnVentas;
        private Button Crud_Empleados;
        private Label lblEmpleado;
        private Button btnCerrarSesion;
    }
}