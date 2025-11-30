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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuEmpleados));
            btnDetallesdeorden = new Button();
            btnProductos = new Button();
            btnVentas = new Button();
            btnCerrarSesion = new Button();
            lblEmpleado = new Label();
            SuspendLayout();
            // 
            // btnDetallesdeorden
            // 
            btnDetallesdeorden.BackColor = Color.FromArgb(214, 249, 185);
            btnDetallesdeorden.Font = new Font("Baskerville Old Face", 15.75F);
            btnDetallesdeorden.Location = new Point(745, 280);
            btnDetallesdeorden.Name = "btnDetallesdeorden";
            btnDetallesdeorden.Size = new Size(246, 54);
            btnDetallesdeorden.TabIndex = 7;
            btnDetallesdeorden.Text = "DETALLES DE ORDEN";
            btnDetallesdeorden.UseVisualStyleBackColor = false;
            btnDetallesdeorden.Click += btnDetallesdeorden_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(214, 249, 185);
            btnProductos.Font = new Font("Baskerville Old Face", 15.75F);
            btnProductos.Location = new Point(451, 280);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(246, 54);
            btnProductos.TabIndex = 6;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(214, 249, 185);
            btnVentas.Font = new Font("Baskerville Old Face", 15.75F);
            btnVentas.Location = new Point(147, 280);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(246, 54);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "VENTAS";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += button1_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Maroon;
            btnCerrarSesion.Font = new Font("Baskerville Old Face", 15.75F);
            btnCerrarSesion.ForeColor = SystemColors.ButtonHighlight;
            btnCerrarSesion.Location = new Point(910, 68);
            btnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(186, 42);
            btnCerrarSesion.TabIndex = 12;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.BackColor = Color.Transparent;
            lblEmpleado.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmpleado.Location = new Point(83, 75);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(121, 27);
            lblEmpleado.TabIndex = 11;
            lblEmpleado.Text = "Bievenido: ";
            // 
            // frmMenuEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 617);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblEmpleado);
            Controls.Add(btnDetallesdeorden);
            Controls.Add(btnProductos);
            Controls.Add(btnVentas);
            DoubleBuffered = true;
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