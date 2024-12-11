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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            btnSave = new Button();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            labelName = new Label();
            labelFirstName = new Label();
            labelGmail = new Label();
            textBoxEmail = new TextBox();
            labelPasword = new Label();
            textBoxPasword = new TextBox();
            labelVerifyPassword = new Label();
            textBoxVerifyPassword = new TextBox();
            btnExit = new Button();
            textBox1 = new TextBox();
            labelRegisterNewTicket = new Label();
            groupBoxRegister = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBoxRegister = new PictureBox();
            errorProviderRegisterClient = new ErrorProvider(components);
            groupBoxRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRegister).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderRegisterClient).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(235, 239, 242);
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(17, 408);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 43);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(9, 45);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(350, 27);
            textBoxName.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(9, 115);
            textBoxLastName.Margin = new Padding(3, 4, 3, 4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(350, 27);
            textBoxLastName.TabIndex = 12;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.FromArgb(207, 206, 242);
            labelName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelName.ForeColor = SystemColors.ActiveCaptionText;
            labelName.Location = new Point(9, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(80, 23);
            labelName.TabIndex = 13;
            labelName.Text = "Nombres";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.FromArgb(207, 206, 242);
            labelFirstName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelFirstName.ForeColor = SystemColors.ActiveCaptionText;
            labelFirstName.Location = new Point(9, 88);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(77, 23);
            labelFirstName.TabIndex = 14;
            labelFirstName.Text = "apellidos";
            // 
            // labelGmail
            // 
            labelGmail.AutoSize = true;
            labelGmail.BackColor = Color.FromArgb(207, 206, 242);
            labelGmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelGmail.ForeColor = SystemColors.ActiveCaptionText;
            labelGmail.Location = new Point(9, 163);
            labelGmail.Name = "labelGmail";
            labelGmail.Size = new Size(59, 23);
            labelGmail.TabIndex = 16;
            labelGmail.Text = "correo";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(9, 189);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(350, 27);
            textBoxEmail.TabIndex = 15;
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.BackColor = Color.FromArgb(207, 206, 242);
            labelPasword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPasword.ForeColor = SystemColors.ActiveCaptionText;
            labelPasword.Location = new Point(9, 235);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(97, 23);
            labelPasword.TabIndex = 18;
            labelPasword.Text = "Contraseña";
            // 
            // textBoxPasword
            // 
            textBoxPasword.Location = new Point(9, 261);
            textBoxPasword.Margin = new Padding(3, 4, 3, 4);
            textBoxPasword.Name = "textBoxPasword";
            textBoxPasword.Size = new Size(350, 27);
            textBoxPasword.TabIndex = 17;
            textBoxPasword.UseSystemPasswordChar = true;
            // 
            // labelVerifyPassword
            // 
            labelVerifyPassword.AutoSize = true;
            labelVerifyPassword.BackColor = Color.FromArgb(207, 206, 242);
            labelVerifyPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelVerifyPassword.ForeColor = SystemColors.ActiveCaptionText;
            labelVerifyPassword.Location = new Point(9, 323);
            labelVerifyPassword.Name = "labelVerifyPassword";
            labelVerifyPassword.Size = new Size(160, 23);
            labelVerifyPassword.TabIndex = 20;
            labelVerifyPassword.Text = "Verficar Contraseña";
            // 
            // textBoxVerifyPassword
            // 
            textBoxVerifyPassword.Location = new Point(9, 349);
            textBoxVerifyPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxVerifyPassword.Name = "textBoxVerifyPassword";
            textBoxVerifyPassword.Size = new Size(350, 27);
            textBoxVerifyPassword.TabIndex = 19;
            textBoxVerifyPassword.UseSystemPasswordChar = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(235, 239, 242);
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(203, 408);
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
            textBox1.BackColor = Color.FromArgb(207, 206, 242);
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
            labelRegisterNewTicket.BackColor = Color.FromArgb(207, 206, 242);
            labelRegisterNewTicket.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegisterNewTicket.ForeColor = SystemColors.ActiveCaptionText;
            labelRegisterNewTicket.Location = new Point(11, 9);
            labelRegisterNewTicket.Name = "labelRegisterNewTicket";
            labelRegisterNewTicket.Size = new Size(510, 46);
            labelRegisterNewTicket.TabIndex = 23;
            labelRegisterNewTicket.Text = "Registro de Nuevo Cliente";
            // 
            // groupBoxRegister
            // 
            groupBoxRegister.BackColor = Color.FromArgb(207, 206, 242);
            groupBoxRegister.Controls.Add(pictureBox1);
            groupBoxRegister.Controls.Add(labelName);
            groupBoxRegister.Controls.Add(labelFirstName);
            groupBoxRegister.Controls.Add(pictureBox2);
            groupBoxRegister.Controls.Add(labelGmail);
            groupBoxRegister.Controls.Add(labelPasword);
            groupBoxRegister.Controls.Add(btnExit);
            groupBoxRegister.Controls.Add(labelVerifyPassword);
            groupBoxRegister.Controls.Add(btnSave);
            groupBoxRegister.Controls.Add(textBoxName);
            groupBoxRegister.Controls.Add(textBoxVerifyPassword);
            groupBoxRegister.Controls.Add(textBoxLastName);
            groupBoxRegister.Controls.Add(textBoxEmail);
            groupBoxRegister.Controls.Add(textBoxPasword);
            groupBoxRegister.Location = new Point(59, 97);
            groupBoxRegister.Name = "groupBoxRegister";
            groupBoxRegister.Size = new Size(407, 475);
            groupBoxRegister.TabIndex = 24;
            groupBoxRegister.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(235, 239, 242);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(216, 413);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(235, 239, 242);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 413);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBoxRegister
            // 
            pictureBoxRegister.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxRegister.Image = (Image)resources.GetObject("pictureBoxRegister.Image");
            pictureBoxRegister.Location = new Point(501, 157);
            pictureBoxRegister.Name = "pictureBoxRegister";
            pictureBoxRegister.Size = new Size(375, 345);
            pictureBoxRegister.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRegister.TabIndex = 25;
            pictureBoxRegister.TabStop = false;
            // 
            // errorProviderRegisterClient
            // 
            errorProviderRegisterClient.ContainerControl = this;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRegister).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderRegisterClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private Label labelName;
        private Label labelFirstName;
        private Label labelGmail;
        private TextBox textBoxEmail;
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
        private ErrorProvider errorProviderRegisterClient;
    }
}