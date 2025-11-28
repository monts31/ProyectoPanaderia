namespace ProyectoPanaderia
{
    partial class frmMenuEmpleados
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
            btnDetallesdeorden = new Button();
            btnProductos = new Button();
            btnVentas = new Button();
            btnCerrarSesion = new Button();
            lblEmpleado = new Label();
            SuspendLayout();
            // 
            // btnDetallesdeorden
            // 
            btnDetallesdeorden.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetallesdeorden.Location = new Point(622, 284);
            btnDetallesdeorden.Margin = new Padding(3, 4, 3, 4);
            btnDetallesdeorden.Name = "btnDetallesdeorden";
            btnDetallesdeorden.Size = new Size(246, 49);
            btnDetallesdeorden.TabIndex = 7;
            btnDetallesdeorden.Text = "Detalles de orden";
            btnDetallesdeorden.UseVisualStyleBackColor = true;
            btnDetallesdeorden.Click += btnDetallesdeorden_Click;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.Location = new Point(327, 284);
            btnProductos.Margin = new Padding(3, 4, 3, 4);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(246, 49);
            btnProductos.TabIndex = 6;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.Location = new Point(39, 284);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(246, 49);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += button1_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(743, 20);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(149, 29);
            btnCerrarSesion.TabIndex = 12;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(39, 33);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(82, 20);
            lblEmpleado.TabIndex = 11;
            lblEmpleado.Text = "Bievenido: ";
            // 
            // frmMenuEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblEmpleado);
            Controls.Add(btnDetallesdeorden);
            Controls.Add(btnProductos);
            Controls.Add(btnVentas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMenuEmpleados";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDetallesdeorden;
        private Button btnProductos;
        private Button btnVentas;
        private Button btnCerrarSesion;
        private Label lblEmpleado;
    }
}