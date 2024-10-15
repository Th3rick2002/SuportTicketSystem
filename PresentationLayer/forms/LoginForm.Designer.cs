namespace PresentationLayer.forms
{
    partial class LoginForm
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
            button1 = new Button();
            btnUser = new Button();
            label3 = new Label();
            textBox5 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 39);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESION";
            // 
            // button1
            // 
            button1.Location = new Point(346, 241);
            button1.Name = "button1";
            button1.Size = new Size(104, 25);
            button1.TabIndex = 3;
            button1.Text = "acceder";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(346, 272);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(104, 25);
            btnUser.TabIndex = 4;
            btnUser.Text = "crear usuario";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 110);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 16;
            label3.Text = "Email";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(259, 128);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(307, 23);
            textBox5.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 174);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 18;
            label2.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 23);
            textBox1.TabIndex = 17;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(btnUser);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnUser;
        private Label label3;
        private TextBox textBox5;
        private Label label2;
        private TextBox textBox1;
    }
}