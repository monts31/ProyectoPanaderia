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
            btnProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.Location = new Point(310, 176);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(215, 37);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "CRUD Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnAuditorias
            // 
            btnAuditorias.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAuditorias.Location = new Point(559, 91);
            btnAuditorias.Name = "btnAuditorias";
            btnAuditorias.Size = new Size(215, 37);
            btnAuditorias.TabIndex = 5;
            btnAuditorias.Text = "Auditorias";
            btnAuditorias.UseVisualStyleBackColor = true;
            btnAuditorias.Click += btnAuditorias_Click;
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(559, 281);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(215, 37);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnDetallesdeorden_Click;
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.Location = new Point(80, 281);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(215, 37);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // Crud_Empleados
            // 
            Crud_Empleados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Crud_Empleados.Location = new Point(88, 91);
            Crud_Empleados.Name = "Crud_Empleados";
            Crud_Empleados.Size = new Size(215, 37);
            Crud_Empleados.TabIndex = 8;
            Crud_Empleados.Text = "CRUD Empleados";
            Crud_Empleados.UseVisualStyleBackColor = true;
            Crud_Empleados.Click += Crud_Empleados_Click;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(43, 19);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(65, 15);
            lblEmpleado.TabIndex = 9;
            lblEmpleado.Text = "Bievenido: ";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(659, 9);
            btnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(130, 22);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // frmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblEmpleado);
            Controls.Add(Crud_Empleados);
            Controls.Add(btnVentas);
            Controls.Add(btnAuditorias);
            Controls.Add(btnReportes);
            Controls.Add(btnProductos);
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