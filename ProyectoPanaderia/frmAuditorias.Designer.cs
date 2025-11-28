namespace ProyectoPanaderia
{
    partial class frmAuditorias
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
            btnRegresar = new Button();
            btnReporte = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(725, 296);
            dataGridView1.TabIndex = 0;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(4, 2);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 31);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "<---";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(603, 392);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(127, 36);
            btnReporte.TabIndex = 9;
            btnReporte.Text = "Generar reporte";
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += button1_Click;
            // 
            // frmAuditorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReporte);
            Controls.Add(btnRegresar);
            Controls.Add(dataGridView1);
            Name = "frmAuditorias";
            Text = "frmAuditorias";
            Load += frmAuditorias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnRegresar;
        private Button btnReporte;
    }
}