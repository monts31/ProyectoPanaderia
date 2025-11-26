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
            SuspendLayout();
            // 
            // btnDetallesdeorden
            // 
            btnDetallesdeorden.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetallesdeorden.Location = new Point(544, 213);
            btnDetallesdeorden.Name = "btnDetallesdeorden";
            btnDetallesdeorden.Size = new Size(215, 37);
            btnDetallesdeorden.TabIndex = 7;
            btnDetallesdeorden.Text = "Detalles de orden";
            btnDetallesdeorden.UseVisualStyleBackColor = true;
            btnDetallesdeorden.Click += btnDetallesdeorden_Click;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.Location = new Point(286, 213);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(215, 37);
            btnProductos.TabIndex = 6;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.Location = new Point(34, 213);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(215, 37);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += button1_Click;
            // 
            // frmMenuEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDetallesdeorden);
            Controls.Add(btnProductos);
            Controls.Add(btnVentas);
            Name = "frmMenuEmpleados";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDetallesdeorden;
        private Button btnProductos;
        private Button btnVentas;
    }
}