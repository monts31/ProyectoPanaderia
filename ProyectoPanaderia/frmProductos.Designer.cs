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
            label7 = new Label();
            txtEstado = new TextBox();
            grbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbProducto).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(845, 626);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 41);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grbProducto
            // 
            grbProducto.Controls.Add(txtEstado);
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
            grbProducto.Location = new Point(38, 72);
            grbProducto.Name = "grbProducto";
            grbProducto.Size = new Size(907, 529);
            grbProducto.TabIndex = 9;
            grbProducto.TabStop = false;
            grbProducto.Text = "Producto";
            // 
            // btnImagen
            // 
            btnImagen.Location = new Point(684, 249);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(135, 29);
            btnImagen.TabIndex = 12;
            btnImagen.Text = "Cargar imagen ";
            btnImagen.UseVisualStyleBackColor = true;
            btnImagen.Click += btnImagen_Click;
            // 
            // pcbProducto
            // 
            pcbProducto.Location = new Point(519, 248);
            pcbProducto.Name = "pcbProducto";
            pcbProducto.Size = new Size(157, 158);
            pcbProducto.TabIndex = 11;
            pcbProducto.TabStop = false;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(522, 96);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(190, 38);
            txtStock.TabIndex = 10;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(527, 42);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(190, 38);
            txtPrecio.TabIndex = 9;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(112, 149);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(274, 129);
            txtDescripcion.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 90);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(294, 38);
            txtNombre.TabIndex = 7;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Enabled = false;
            txtIdProducto.Location = new Point(122, 41);
            txtIdProducto.Multiline = true;
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(72, 33);
            txtIdProducto.TabIndex = 6;
            txtIdProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 99);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 45);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 252);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(468, 170);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 13;
            label7.Text = "Estado:";
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Location = new Point(524, 167);
            txtEstado.Multiline = true;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(190, 38);
            txtEstado.TabIndex = 14;
            txtEstado.Text = "Activo";
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 688);
            Controls.Add(btnGuardar);
            Controls.Add(grbProducto);
            Controls.Add(lblEmpleados);
            Controls.Add(btnRegresar);
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
        private TextBox txtEstado;
        private Label label7;
    }
}