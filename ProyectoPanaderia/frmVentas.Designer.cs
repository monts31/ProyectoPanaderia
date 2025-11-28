namespace ProyectoPanaderia
{
    partial class frmVentas
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
            dataGridView1 = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewImageColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            btnRegresar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdProducto, nombre, precio, cantidad, total, Accion });
            dataGridView1.Location = new Point(356, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(505, 127);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // IdProducto
            // 
            IdProducto.FillWeight = 105.989853F;
            IdProducto.HeaderText = "Id producto";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            // 
            // nombre
            // 
            nombre.FillWeight = 105.989853F;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            // 
            // precio
            // 
            precio.FillWeight = 105.989853F;
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            // 
            // cantidad
            // 
            cantidad.FillWeight = 105.989853F;
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            // 
            // total
            // 
            total.FillWeight = 105.989853F;
            total.HeaderText = "Subtotal";
            total.MinimumWidth = 6;
            total.Name = "total";
            // 
            // Accion
            // 
            Accion.FillWeight = 70.05076F;
            Accion.HeaderText = "Accion";
            Accion.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Accion.MinimumWidth = 6;
            Accion.Name = "Accion";
            Accion.Resizable = DataGridViewTriState.False;
            Accion.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(41, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(231, 340);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(486, 232);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 41);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(668, 232);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(107, 41);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar venta";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(6, 2);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 31);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "<---";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 450);
            Controls.Add(label1);
            Controls.Add(btnRegresar);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Button btnRegresar;
        private Label label1;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn total;
        private DataGridViewImageColumn Accion;
    }
}