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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            lblEmpleados = new Label();
            grbDatosEmpleado = new GroupBox();
            cboEstado = new ComboBox();
            label11 = new Label();
            txtCorreo = new TextBox();
            label10 = new Label();
            cboRol = new ComboBox();
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
            grbDatosUsuario = new GroupBox();
            btnVer2 = new Button();
            btnVer = new Button();
            txtCofirmarContra = new TextBox();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnGuardar = new Button();
            btnRegresar = new Button();
            grbDatosEmpleado.SuspendLayout();
            grbDatosUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.BackColor = Color.Transparent;
            lblEmpleados.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmpleados.Location = new Point(91, 20);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(108, 24);
            lblEmpleados.TabIndex = 3;
            lblEmpleados.Text = "Empleados ";
            // 
            // grbDatosEmpleado
            // 
            grbDatosEmpleado.Controls.Add(cboEstado);
            grbDatosEmpleado.Controls.Add(label11);
            grbDatosEmpleado.Controls.Add(txtCorreo);
            grbDatosEmpleado.Controls.Add(label10);
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
            grbDatosEmpleado.Location = new Point(119, 112);
            grbDatosEmpleado.Margin = new Padding(3, 2, 3, 2);
            grbDatosEmpleado.Name = "grbDatosEmpleado";
            grbDatosEmpleado.Padding = new Padding(3, 2, 3, 2);
            grbDatosEmpleado.Size = new Size(369, 353);
            grbDatosEmpleado.TabIndex = 4;
            grbDatosEmpleado.TabStop = false;
            grbDatosEmpleado.Text = "Datos del empleado";
            // 
            // cboEstado
            // 
            cboEstado.FlatStyle = FlatStyle.System;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activo", "Baja" });
            cboEstado.Location = new Point(107, 298);
            cboEstado.Margin = new Padding(3, 2, 3, 2);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(167, 23);
            cboEstado.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(52, 300);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 14;
            label11.Text = "Estado:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(107, 223);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(167, 30);
            txtCorreo.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 225);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 12;
            label10.Text = "Correo:";
            // 
            // cboRol
            // 
            cboRol.FlatStyle = FlatStyle.System;
            cboRol.FormattingEnabled = true;
            cboRol.Items.AddRange(new object[] { "Administrador", "Empleado" });
            cboRol.Location = new Point(107, 263);
            cboRol.Margin = new Padding(3, 2, 3, 2);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(167, 23);
            cboRol.TabIndex = 11;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(107, 180);
            txtSueldo.Margin = new Padding(3, 2, 3, 2);
            txtSueldo.Multiline = true;
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(167, 30);
            txtSueldo.TabIndex = 10;
            txtSueldo.KeyPress += txtSueldo_KeyPress;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(107, 142);
            txtHoras.Margin = new Padding(3, 2, 3, 2);
            txtHoras.Multiline = true;
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(167, 30);
            txtHoras.TabIndex = 9;
            txtHoras.KeyPress += txtTelefono_KeyPress_1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(107, 103);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(167, 30);
            txtTelefono.TabIndex = 8;
            txtTelefono.KeyPress += txtTelefono_KeyPress_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 70);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 30);
            txtNombre.TabIndex = 7;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Enabled = false;
            txtIdEmpleado.Location = new Point(107, 31);
            txtIdEmpleado.Margin = new Padding(3, 2, 3, 2);
            txtIdEmpleado.Multiline = true;
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(64, 26);
            txtIdEmpleado.TabIndex = 6;
            txtIdEmpleado.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 182);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 4;
            label5.Text = "Sueldo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 142);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Horas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 266);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 5;
            label6.Text = "Rol:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 103);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 72);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 33);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Id empleado:";
            // 
            // grbDatosUsuario
            // 
            grbDatosUsuario.Controls.Add(btnVer2);
            grbDatosUsuario.Controls.Add(btnVer);
            grbDatosUsuario.Controls.Add(txtCofirmarContra);
            grbDatosUsuario.Controls.Add(txtContraseña);
            grbDatosUsuario.Controls.Add(txtUsuario);
            grbDatosUsuario.Controls.Add(label9);
            grbDatosUsuario.Controls.Add(label8);
            grbDatosUsuario.Controls.Add(label7);
            grbDatosUsuario.Location = new Point(649, 154);
            grbDatosUsuario.Margin = new Padding(3, 2, 3, 2);
            grbDatosUsuario.Name = "grbDatosUsuario";
            grbDatosUsuario.Padding = new Padding(3, 2, 3, 2);
            grbDatosUsuario.Size = new Size(413, 260);
            grbDatosUsuario.TabIndex = 5;
            grbDatosUsuario.TabStop = false;
            grbDatosUsuario.Text = "Datos de usuario";
            // 
            // btnVer2
            // 
            btnVer2.Location = new Point(368, 118);
            btnVer2.Margin = new Padding(3, 2, 3, 2);
            btnVer2.Name = "btnVer2";
            btnVer2.Size = new Size(39, 22);
            btnVer2.TabIndex = 16;
            btnVer2.UseVisualStyleBackColor = true;
            btnVer2.Click += btnVer2_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(367, 72);
            btnVer.Margin = new Padding(3, 2, 3, 2);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(39, 22);
            btnVer.TabIndex = 15;
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click_1;
            // 
            // txtCofirmarContra
            // 
            txtCofirmarContra.Location = new Point(150, 116);
            txtCofirmarContra.Margin = new Padding(3, 2, 3, 2);
            txtCofirmarContra.Multiline = true;
            txtCofirmarContra.Name = "txtCofirmarContra";
            txtCofirmarContra.PasswordChar = '*';
            txtCofirmarContra.Size = new Size(207, 30);
            txtCofirmarContra.TabIndex = 14;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(96, 70);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(258, 30);
            txtContraseña.TabIndex = 13;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(83, 27);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(258, 30);
            txtUsuario.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 118);
            label9.Name = "label9";
            label9.Size = new Size(125, 15);
            label9.TabIndex = 8;
            label9.Text = "Confirmar contraseña:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 72);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 7;
            label8.Text = "Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 33);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 6;
            label7.Text = "Usuario:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Maroon;
            btnGuardar.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(945, 566);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(164, 31);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(192, 255, 192);
            btnRegresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(12, 11);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(51, 33);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "<---";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click_1;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 617);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(grbDatosUsuario);
            Controls.Add(grbDatosEmpleado);
            Controls.Add(lblEmpleados);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txtHoras;
        private TextBox txtCofirmarContra;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Button btnRegresar;
        private ComboBox cboEstado;
        private Label label11;
        private TextBox txtCorreo;
        private Label label10;
        private TextBox txtSueldo;
        private Label label5;
        private Button btnVer;
        private Button btnVer2;
    }
}