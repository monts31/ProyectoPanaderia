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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            btnGuardar = new Button();
            grbProducto = new GroupBox();
            cboEstado = new ComboBox();
            label7 = new Label();
            btnImagen = new Button();
            pcbProducto = new PictureBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            txtIdProducto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblEmpleados = new Label();
            btnRegresar = new Button();
            grbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbProducto).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Maroon;
            btnGuardar.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(946, 565);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 41);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grbProducto
            // 
            grbProducto.BackColor = Color.FromArgb(198, 219, 230);
            grbProducto.Controls.Add(cboEstado);
            grbProducto.Controls.Add(label7);
            grbProducto.Controls.Add(btnImagen);
            grbProducto.Controls.Add(pcbProducto);
            grbProducto.Controls.Add(txtStock);
            grbProducto.Controls.Add(txtPrecio);
            grbProducto.Controls.Add(txtDescripcion);
            grbProducto.Controls.Add(txtNombre);
            grbProducto.Controls.Add(txtIdProducto);
            grbProducto.Controls.Add(label5);
            grbProducto.Controls.Add(label4);
            grbProducto.Controls.Add(label6);
            grbProducto.Controls.Add(label3);
            grbProducto.Controls.Add(label2);
            grbProducto.Controls.Add(label1);
            grbProducto.Location = new Point(163, 110);
            grbProducto.Margin = new Padding(3, 2, 3, 2);
            grbProducto.Name = "grbProducto";
            grbProducto.Padding = new Padding(3, 2, 3, 2);
            grbProducto.Size = new Size(824, 441);
            grbProducto.TabIndex = 9;
            grbProducto.TabStop = false;
            grbProducto.Text = "Producto";
            grbProducto.Enter += grbProducto_Enter;
            // 
            // cboEstado
            // 
            cboEstado.Enabled = false;
            cboEstado.FlatStyle = FlatStyle.Flat;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activo", "Descontinuado" });
            cboEstado.Location = new Point(461, 128);
            cboEstado.Margin = new Padding(3, 2, 3, 2);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(133, 23);
            cboEstado.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(410, 128);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 13;
            label7.Text = "Estado:";
            // 
            // btnImagen
            // 
            btnImagen.Location = new Point(598, 187);
            btnImagen.Margin = new Padding(3, 2, 3, 2);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(118, 22);
            btnImagen.TabIndex = 12;
            btnImagen.Text = "Cargar imagen ";
            btnImagen.UseVisualStyleBackColor = true;
            btnImagen.Click += btnImagen_Click;
            // 
            // pcbProducto
            // 
            pcbProducto.BackColor = Color.Transparent;
            pcbProducto.BackgroundImageLayout = ImageLayout.Zoom;
            pcbProducto.BorderStyle = BorderStyle.FixedSingle;
            pcbProducto.Location = new Point(454, 186);
            pcbProducto.Margin = new Padding(3, 2, 3, 2);
            pcbProducto.Name = "pcbProducto";
            pcbProducto.Size = new Size(139, 132);
            pcbProducto.TabIndex = 11;
            pcbProducto.TabStop = false;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(457, 72);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(167, 30);
            txtStock.TabIndex = 10;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(461, 32);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(167, 30);
            txtPrecio.TabIndex = 9;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(98, 112);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(240, 98);
            txtDescripcion.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 68);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 30);
            txtNombre.TabIndex = 7;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Enabled = false;
            txtIdProducto.Location = new Point(107, 31);
            txtIdProducto.Margin = new Padding(3, 2, 3, 2);
            txtIdProducto.Multiline = true;
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(64, 26);
            txtIdProducto.TabIndex = 6;
            txtIdProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 74);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 34);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 189);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 5;
            label6.Text = "Foto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 114);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 72);
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
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Id producto:";
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.BackColor = Color.Transparent;
            lblEmpleados.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmpleados.ForeColor = Color.Black;
            lblEmpleados.Location = new Point(117, 43);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(94, 24);
            lblEmpleados.TabIndex = 8;
            lblEmpleados.Text = "Productos";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(194, 236, 191);
            btnRegresar.Location = new Point(24, 32);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(66, 35);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "<---";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 617);
            Controls.Add(btnGuardar);
            Controls.Add(grbProducto);
            Controls.Add(lblEmpleados);
            Controls.Add(btnRegresar);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProductos";
            Text = "frmProductos";
            grbProducto.ResumeLayout(false);
            grbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private GroupBox grbProducto;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private TextBox txtIdProducto;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblEmpleados;
        private Button btnRegresar;
        private Button btnImagen;
        private PictureBox pcbProducto;
        private Label label7;
        private ComboBox cboEstado;
    }
}