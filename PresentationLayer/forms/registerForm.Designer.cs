namespace PresentationLayer.forms
{
    partial class registerForm
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(337, 367);
            button1.Name = "button1";
            button1.Size = new Size(104, 25);
            button1.TabIndex = 8;
            button1.Text = "acceder";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 23);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 28);
            label1.Name = "label1";
            label1.Size = new Size(269, 30);
            label1.TabIndex = 5;
            label1.Text = "Registro de Nuevo Cliente";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(246, 151);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(307, 23);
            textBox5.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 81);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 13;
            label2.Text = "primer nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 133);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 14;
            label3.Text = "apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 189);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 16;
            label4.Text = "correo";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(246, 207);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(307, 23);
            textBox6.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 243);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 18;
            label5.Text = "Contraseña";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(246, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(307, 23);
            textBox4.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 309);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 20;
            label6.Text = "Verficar Contraseña";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(246, 327);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(307, 23);
            textBox7.TabIndex = 19;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox7);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "registerForm";
            Text = "registerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox7;
    }
}