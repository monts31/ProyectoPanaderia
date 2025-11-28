namespace ProyectoPanaderia
{
    partial class frmReporteFecha
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
            label1 = new Label();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btnGenerar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 42);
            label1.Name = "label1";
            label1.Size = new Size(204, 15);
            label1.TabIndex = 0;
            label1.Text = "Elija las fechas para generar el reporte";
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(146, 108);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(200, 23);
            dtpInicio.TabIndex = 1;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(146, 178);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 23);
            dtpFin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 111);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 178);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha fin:";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(150, 240);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(103, 39);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "Generar reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // frmReporteFecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 337);
            Controls.Add(btnGenerar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpFin);
            Controls.Add(dtpInicio);
            Controls.Add(label1);
            Name = "frmReporteFecha";
            Text = "frmReporteFecha";
            Load += frmReporteFecha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Label label2;
        private Label label3;
        private Button btnGenerar;
    }
}