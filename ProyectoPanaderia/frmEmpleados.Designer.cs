namespace ProyectoPanaderia
{
    partial class frmEmpleados
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
            lblEmpleados = new Label();
            grbDatosEmpleado = new GroupBox();
            grbDatosUsuario = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnGuardar = new Button();
            txtIdEmpleado = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtHoras = new TextBox();
            txtSueldo = new TextBox();
            cboRol = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnRegresar = new Button();
            grbDatosEmpleado.SuspendLayout();
            grbDatosUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Location = new Point(86, 10);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(87, 20);
            lblEmpleados.TabIndex = 3;
            lblEmpleados.Text = "Empleados ";
            lblEmpleados.Click += this.lblEmpleados_Click;
            // 
            // grbDatosEmpleado
            // 
            grbDatosEmpleado.Controls.Add(cboRol);
            grbDatosEmpleado.Controls.Add(txtSueldo);
            grbDatosEmpleado.Controls.Add(txtHoras);
            grbDatosEmpleado.Controls.Add(txtTelefono);
            grbDatosEmpleado.Controls.Add(txtNombre);
            grbDatosEmpleado.Controls.Add(txtIdEmpleado);
            grbDatosEmpleado.Controls.Add(label5);
            grbDatosEmpleado.Controls.Add(label4);
            grbDatosEmpleado.Controls.Add(label6);
            grbDatosEmpleado.Controls.Add(label3);
            grbDatosEmpleado.Controls.Add(label2);
            grbDatosEmpleado.Controls.Add(label1);
            grbDatosEmpleado.Location = new Point(35, 68);
            grbDatosEmpleado.Name = "grbDatosEmpleado";
            grbDatosEmpleado.Size = new Size(422, 347);
            grbDatosEmpleado.TabIndex = 4;
            grbDatosEmpleado.TabStop = false;
            grbDatosEmpleado.Text = "Datos del empleado";
            grbDatosEmpleado.Enter += this.grbDatosEmpleado_Enter;
            // 
            // grbDatosUsuario
            // 
            grbDatosUsuario.Controls.Add(textBox3);
            grbDatosUsuario.Controls.Add(textBox2);
            grbDatosUsuario.Controls.Add(textBox1);
            grbDatosUsuario.Controls.Add(label9);
            grbDatosUsuario.Controls.Add(label8);
            grbDatosUsuario.Controls.Add(label7);
            grbDatosUsuario.Location = new Point(500, 68);
            grbDatosUsuario.Name = "grbDatosUsuario";
            grbDatosUsuario.Size = new Size(456, 347);
            grbDatosUsuario.TabIndex = 5;
            grbDatosUsuario.TabStop = false;
            grbDatosUsuario.Text = "Datos de usuario";
            grbDatosUsuario.Enter += this.grbDatosUsuario_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 44);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Id empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 96);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 137);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 189);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Horas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 243);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "Sueldo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 290);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 5;
            label6.Text = "Rol:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 44);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 6;
            label7.Text = "Usuario:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 96);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 7;
            label8.Text = "Contraseña:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 158);
            label9.Name = "label9";
            label9.Size = new Size(154, 20);
            label9.TabIndex = 8;
            label9.Text = "Confirmar contraseña:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(856, 440);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 41);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            // txtNombre
            // 
            txtNombre.AcceptsTab = true;
            txtNombre.Location = new Point(122, 93);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(294, 38);
            txtNombre.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.AcceptsTab = true;
            txtTelefono.Location = new Point(122, 137);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(190, 38);
            txtTelefono.TabIndex = 8;
            // 
            // txtHoras
            // 
            txtHoras.AcceptsTab = true;
            txtHoras.Location = new Point(122, 189);
            txtHoras.Multiline = true;
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(190, 38);
            txtHoras.TabIndex = 9;
            // 
            // txtSueldo
            // 
            txtSueldo.AcceptsTab = true;
            txtSueldo.Location = new Point(122, 240);
            txtSueldo.Multiline = true;
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(190, 38);
            txtSueldo.TabIndex = 10;
            // 
            // cboRol
            // 
            cboRol.FlatStyle = FlatStyle.System;
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(122, 287);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(190, 28);
            cboRol.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.AcceptsTab = true;
            textBox1.Location = new Point(95, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 38);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.AcceptsTab = true;
            textBox2.Location = new Point(119, 93);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 38);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.AcceptsTab = true;
            textBox3.Location = new Point(187, 155);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 38);
            textBox3.TabIndex = 14;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(7, 6);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(46, 41);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "<---";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click_1;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 527);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(grbDatosUsuario);
            Controls.Add(grbDatosEmpleado);
            Controls.Add(lblEmpleados);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            grbDatosEmpleado.ResumeLayout(false);
            grbDatosEmpleado.PerformLayout();
            grbDatosUsuario.ResumeLayout(false);
            grbDatosUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEmpleados;
        private GroupBox grbDatosEmpleado;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grbDatosUsuario;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private TextBox txtIdEmpleado;
        private Label label9;
        private Label label8;
        private Button btnGuardar;
        private ComboBox cboRol;
        private TextBox txtSueldo;
        private TextBox txtHoras;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnRegresar;
    }
}