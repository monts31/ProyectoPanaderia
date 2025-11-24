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
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(544, 213);
            button5.Name = "button5";
            button5.Size = new Size(215, 37);
            button5.TabIndex = 7;
            button5.Text = "Detalles de orden";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(286, 213);
            button4.Name = "button4";
            button4.Size = new Size(215, 37);
            button4.TabIndex = 6;
            button4.Text = "Productos";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(34, 213);
            button1.Name = "button1";
            button1.Size = new Size(215, 37);
            button1.TabIndex = 5;
            button1.Text = "Ventas";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmMenuEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Name = "frmMenuEmpleados";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button1;
    }
}