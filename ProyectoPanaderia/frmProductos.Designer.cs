namespace ProyectoPanaderia
{
    partial class frmProductos
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
            btnGuardar = new Button();
            grbProducto = new GroupBox();
            txtSueldo = new TextBox();
            txtHoras = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            txtIdEmpleado = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblEmpleados = new Label();
            btnRegresar = new Button();
            grbProducto.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(458, 547);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 41);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grbProducto
            // 
            grbProducto.Controls.Add(txtSueldo);
            grbProducto.Controls.Add(txtHoras);
            grbProducto.Controls.Add(txtTelefono);
            grbProducto.Controls.Add(txtNombre);
            grbProducto.Controls.Add(txtIdEmpleado);
            grbProducto.Controls.Add(label5);
            grbProducto.Controls.Add(label4);
            grbProducto.Controls.Add(label6);
            grbProducto.Controls.Add(label3);
            grbProducto.Controls.Add(label2);
            grbProducto.Controls.Add(label1);
            grbProducto.Location = new Point(38, 72);
            grbProducto.Name = "grbProducto";
            grbProducto.Size = new Size(520, 449);
            grbProducto.TabIndex = 9;
            grbProducto.TabStop = false;
            grbProducto.Text = "Producto";
            // 
            // txtSueldo
            // 
            txtSueldo.AcceptsTab = true;
            txtSueldo.Location = new Point(77, 345);
            txtSueldo.Multiline = true;
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(190, 38);
            txtSueldo.TabIndex = 10;
            // 
            // txtHoras
            // 
            txtHoras.AcceptsTab = true;
            txtHoras.Location = new Point(82, 291);
            txtHoras.Multiline = true;
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(190, 38);
            txtHoras.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.AcceptsTab = true;
            txtTelefono.Location = new Point(112, 149);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(274, 129);
            txtTelefono.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.AcceptsTab = true;
            txtNombre.Location = new Point(92, 90);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(294, 38);
            txtNombre.TabIndex = 7;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Enabled = false;
            txtIdEmpleado.Location = new Point(122, 41);
            txtIdEmpleado.Multiline = true;
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(72, 33);
            txtIdEmpleado.TabIndex = 6;
            txtIdEmpleado.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 348);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 294);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 397);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 5;
            label6.Text = "Foto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 152);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 96);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 44);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Id producto:";
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Location = new Point(89, 14);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(75, 20);
            lblEmpleados.TabIndex = 8;
            lblEmpleados.Text = "Productos";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(7, 4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(46, 41);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "<---";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 623);
            Controls.Add(btnGuardar);
            Controls.Add(grbProducto);
            Controls.Add(lblEmpleados);
            Controls.Add(btnRegresar);
            Name = "frmProductos";
            Text = "frmProductos";
            grbProducto.ResumeLayout(false);
            grbProducto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private GroupBox grbProducto;
        private TextBox txtSueldo;
        private TextBox txtHoras;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private TextBox txtIdEmpleado;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblEmpleados;
        private Button btnRegresar;
    }
}