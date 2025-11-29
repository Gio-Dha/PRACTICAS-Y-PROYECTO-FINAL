namespace Lluvia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            botonComenzar = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // botonComenzar
            // 
            botonComenzar.BackColor = Color.Red;
            botonComenzar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonComenzar.ForeColor = Color.White;
            botonComenzar.Location = new Point(200, 159);
            botonComenzar.Name = "botonComenzar";
            botonComenzar.Size = new Size(118, 43);
            botonComenzar.TabIndex = 0;
            botonComenzar.Text = "Comenzar";
            botonComenzar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(233, 239);
            button2.Name = "button2";
            button2.Size = new Size(123, 32);
            button2.TabIndex = 1;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(38, 73);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 2;
            label1.Text = "Estado de Sensor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(220, 15);
            label2.Name = "label2";
            label2.Size = new Size(353, 37);
            label2.TabIndex = 3;
            label2.Text = "Sensor Lluvia FC-37 O YL-83";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(541, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 204);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(902, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(botonComenzar);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonComenzar;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
