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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            btnSave = new Button();
            textBoxName = new TextBox();
            textBoxFirstname = new TextBox();
            labelName = new Label();
            labelFirstName = new Label();
            labelGmail = new Label();
            textBoxGmail = new TextBox();
            labelPasword = new Label();
            textBoxPasword = new TextBox();
            labelVerifyPassword = new Label();
            textBoxVerifyPassword = new TextBox();
            btnExit = new Button();
            textBox1 = new TextBox();
            labelRegisterNewTicket = new Label();
            groupBoxRegister = new GroupBox();
            pictureBoxRegister = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBoxRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Aquamarine;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(207, 405);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 43);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(17, 46);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(350, 27);
            textBoxName.TabIndex = 6;
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Location = new Point(17, 115);
            textBoxFirstname.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(350, 27);
            textBoxFirstname.TabIndex = 12;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.MediumPurple;
            labelName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelName.ForeColor = SystemColors.ButtonHighlight;
            labelName.Location = new Point(17, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(80, 23);
            labelName.TabIndex = 13;
            labelName.Text = "Nombres";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.MediumPurple;
            labelFirstName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelFirstName.ForeColor = SystemColors.ButtonHighlight;
            labelFirstName.Location = new Point(17, 88);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(77, 23);
            labelFirstName.TabIndex = 14;
            labelFirstName.Text = "apellidos";
            // 
            // labelGmail
            // 
            labelGmail.AutoSize = true;
            labelGmail.BackColor = Color.MediumPurple;
            labelGmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelGmail.ForeColor = SystemColors.ButtonHighlight;
            labelGmail.Location = new Point(17, 163);
            labelGmail.Name = "labelGmail";
            labelGmail.Size = new Size(59, 23);
            labelGmail.TabIndex = 16;
            labelGmail.Text = "correo";
            // 
            // textBoxGmail
            // 
            textBoxGmail.Location = new Point(17, 190);
            textBoxGmail.Margin = new Padding(3, 4, 3, 4);
            textBoxGmail.Name = "textBoxGmail";
            textBoxGmail.Size = new Size(350, 27);
            textBoxGmail.TabIndex = 15;
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.BackColor = Color.MediumPurple;
            labelPasword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPasword.ForeColor = SystemColors.ButtonHighlight;
            labelPasword.Location = new Point(17, 235);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(97, 23);
            labelPasword.TabIndex = 18;
            labelPasword.Text = "Contraseña";
            // 
            // textBoxPasword
            // 
            textBoxPasword.Location = new Point(17, 262);
            textBoxPasword.Margin = new Padding(3, 4, 3, 4);
            textBoxPasword.Name = "textBoxPasword";
            textBoxPasword.Size = new Size(350, 27);
            textBoxPasword.TabIndex = 17;
            // 
            // labelVerifyPassword
            // 
            labelVerifyPassword.AutoSize = true;
            labelVerifyPassword.BackColor = Color.MediumPurple;
            labelVerifyPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelVerifyPassword.ForeColor = SystemColors.ButtonHighlight;
            labelVerifyPassword.Location = new Point(17, 323);
            labelVerifyPassword.Name = "labelVerifyPassword";
            labelVerifyPassword.Size = new Size(160, 23);
            labelVerifyPassword.TabIndex = 20;
            labelVerifyPassword.Text = "Verficar Contraseña";
            // 
            // textBoxVerifyPassword
            // 
            textBoxVerifyPassword.Location = new Point(17, 350);
            textBoxVerifyPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxVerifyPassword.Name = "textBoxVerifyPassword";
            textBoxVerifyPassword.Size = new Size(350, 27);
            textBoxVerifyPassword.TabIndex = 19;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Yellow;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(17, 405);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(149, 43);
            btnExit.TabIndex = 21;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MediumPurple;
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(914, 69);
            textBox1.TabIndex = 22;
            // 
            // labelRegisterNewTicket
            // 
            labelRegisterNewTicket.AutoSize = true;
            labelRegisterNewTicket.BackColor = Color.MediumPurple;
            labelRegisterNewTicket.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegisterNewTicket.ForeColor = SystemColors.ButtonFace;
            labelRegisterNewTicket.Location = new Point(12, 9);
            labelRegisterNewTicket.Name = "labelRegisterNewTicket";
            labelRegisterNewTicket.Size = new Size(598, 47);
            labelRegisterNewTicket.TabIndex = 23;
            labelRegisterNewTicket.Text = "Registro de Nuevo Cliente";
            // 
            // groupBoxRegister
            // 
            groupBoxRegister.BackColor = Color.MediumPurple;
            groupBoxRegister.Controls.Add(pictureBox1);
            groupBoxRegister.Controls.Add(pictureBox2);
            groupBoxRegister.Controls.Add(labelName);
            groupBoxRegister.Controls.Add(btnSave);
            groupBoxRegister.Controls.Add(labelFirstName);
            groupBoxRegister.Controls.Add(labelGmail);
            groupBoxRegister.Controls.Add(labelPasword);
            groupBoxRegister.Controls.Add(labelVerifyPassword);
            groupBoxRegister.Controls.Add(btnExit);
            groupBoxRegister.Controls.Add(textBoxName);
            groupBoxRegister.Controls.Add(textBoxVerifyPassword);
            groupBoxRegister.Controls.Add(textBoxFirstname);
            groupBoxRegister.Controls.Add(textBoxGmail);
            groupBoxRegister.Controls.Add(textBoxPasword);
            groupBoxRegister.Location = new Point(59, 97);
            groupBoxRegister.Name = "groupBoxRegister";
            groupBoxRegister.Size = new Size(382, 475);
            groupBoxRegister.TabIndex = 24;
            groupBoxRegister.TabStop = false;
            // 
            // pictureBoxRegister
            // 
            pictureBoxRegister.Image = (Image)resources.GetObject("pictureBoxRegister.Image");
            pictureBoxRegister.Location = new Point(501, 157);
            pictureBoxRegister.Name = "pictureBoxRegister";
            pictureBoxRegister.Size = new Size(375, 346);
            pictureBoxRegister.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRegister.TabIndex = 25;
            pictureBoxRegister.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Yellow;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 410);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(219, 410);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBoxRegister);
            Controls.Add(groupBoxRegister);
            Controls.Add(labelRegisterNewTicket);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "registerForm";
            Text = "registerForm";
            groupBoxRegister.ResumeLayout(false);
            groupBoxRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox textBoxName;
        private TextBox textBoxFirstname;
        private Label labelName;
        private Label labelFirstName;
        private Label labelGmail;
        private TextBox textBoxGmail;
        private Label labelPasword;
        private TextBox textBoxPasword;
        private Label labelVerifyPassword;
        private TextBox textBoxVerifyPassword;
        private Button btnExit;
        private TextBox textBox1;
        private Label labelRegisterNewTicket;
        private GroupBox groupBoxRegister;
        private PictureBox pictureBoxRegister;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}