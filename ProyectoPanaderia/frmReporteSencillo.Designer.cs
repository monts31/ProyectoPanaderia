namespace ProyectoPanaderia
{
    partial class frmReporteSencillo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl1 = new TabControl();
            tpComparativo = new TabPage();
            btnGenerar = new Button();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            label1 = new Label();
            dtpMes2 = new DateTimePicker();
            dtpMes1 = new DateTimePicker();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tpFechas = new TabPage();
            btnFechas = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            dtpFin = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            btnRegresar = new Button();
            tabControl1.SuspendLayout();
            tpComparativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tpFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpComparativo);
            tabControl1.Controls.Add(tpFechas);
            tabControl1.Location = new Point(33, 53);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(867, 619);
            tabControl1.TabIndex = 0;
            // 
            // tpComparativo
            // 
            tpComparativo.Controls.Add(btnGenerar);
            tpComparativo.Controls.Add(checkedListBox1);
            tpComparativo.Controls.Add(label2);
            tpComparativo.Controls.Add(label1);
            tpComparativo.Controls.Add(dtpMes2);
            tpComparativo.Controls.Add(dtpMes1);
            tpComparativo.Controls.Add(chart1);
            tpComparativo.Location = new Point(4, 29);
            tpComparativo.Margin = new Padding(3, 4, 3, 4);
            tpComparativo.Name = "tpComparativo";
            tpComparativo.Padding = new Padding(3, 4, 3, 4);
            tpComparativo.Size = new Size(859, 586);
            tpComparativo.TabIndex = 0;
            tpComparativo.Text = "Reporte comparativo";
            tpComparativo.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(670, 533);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(133, 31);
            btnGenerar.TabIndex = 6;
            btnGenerar.Text = "Generar reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(665, 71);
            checkedListBox1.Margin = new Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(137, 114);
            checkedListBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 79);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "Mes fin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 79);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 3;
            label1.Text = "Mes inicio:";
            // 
            // dtpMes2
            // 
            dtpMes2.CustomFormat = "MMMM yyy";
            dtpMes2.Format = DateTimePickerFormat.Custom;
            dtpMes2.Location = new Point(413, 71);
            dtpMes2.Margin = new Padding(3, 4, 3, 4);
            dtpMes2.Name = "dtpMes2";
            dtpMes2.Size = new Size(159, 27);
            dtpMes2.TabIndex = 2;
            // 
            // dtpMes1
            // 
            dtpMes1.CustomFormat = "MMMM yyyy";
            dtpMes1.Format = DateTimePickerFormat.Custom;
            dtpMes1.Location = new Point(129, 71);
            dtpMes1.Margin = new Padding(3, 4, 3, 4);
            dtpMes1.Name = "dtpMes1";
            dtpMes1.Size = new Size(153, 27);
            dtpMes1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(39, 204);
            chart1.Margin = new Padding(3, 4, 3, 4);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(731, 309);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // tpFechas
            // 
            tpFechas.Controls.Add(btnFechas);
            tpFechas.Controls.Add(dataGridView1);
            tpFechas.Controls.Add(label4);
            tpFechas.Controls.Add(label3);
            tpFechas.Controls.Add(dtpFin);
            tpFechas.Controls.Add(dtpInicio);
            tpFechas.Location = new Point(4, 29);
            tpFechas.Margin = new Padding(3, 4, 3, 4);
            tpFechas.Name = "tpFechas";
            tpFechas.Padding = new Padding(3, 4, 3, 4);
            tpFechas.Size = new Size(859, 586);
            tpFechas.TabIndex = 1;
            tpFechas.Text = "Reporte por fechas";
            tpFechas.UseVisualStyleBackColor = true;
            // 
            // btnFechas
            // 
            btnFechas.Location = new Point(669, 463);
            btnFechas.Margin = new Padding(3, 4, 3, 4);
            btnFechas.Name = "btnFechas";
            btnFechas.Size = new Size(123, 55);
            btnFechas.TabIndex = 5;
            btnFechas.Text = "Generar reporte";
            btnFechas.UseVisualStyleBackColor = true;
            btnFechas.Click += btnFechas_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(118, 185);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(571, 227);
            dataGridView1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 96);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha fin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 95);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha inicio:";
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(539, 88);
            dtpFin.Margin = new Padding(3, 4, 3, 4);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(228, 27);
            dtpFin.TabIndex = 1;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(163, 91);
            dtpInicio.Margin = new Padding(3, 4, 3, 4);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(228, 27);
            dtpInicio.TabIndex = 0;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(0, 1);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(46, 41);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "<---";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // frmReporteSencillo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 695);
            Controls.Add(btnRegresar);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmReporteSencillo";
            Text = "frmReporteSencillo";
            Load += frmReporteSencillo_Load;
            tabControl1.ResumeLayout(false);
            tpComparativo.ResumeLayout(false);
            tpComparativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            tpFechas.ResumeLayout(false);
            tpFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpComparativo;
        private TabPage tpFechas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
        private DateTimePicker dtpMes2;
        private DateTimePicker dtpMes1;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Button btnGenerar;
        private Button btnFechas;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpInicio;
        private Button btnRegresar;
    }
}