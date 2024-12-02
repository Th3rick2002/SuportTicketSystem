namespace PresentationLayer.forms.FormsAdmin
{
    partial class updateClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateClientForm));
            pictureBoxRegister = new PictureBox();
            groupBoxRegister = new GroupBox();
            pictureBox1 = new PictureBox();
            labelName = new Label();
            labelFirstName = new Label();
            pictureBox2 = new PictureBox();
            labelGmail = new Label();
            labelPasword = new Label();
            btnExit = new Button();
            labelVerifyPassword = new Label();
            btnSave = new Button();
            textBoxName = new TextBox();
            textBoxVerifyPassword = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPasword = new TextBox();
            labelRegisterNewTicket = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRegister).BeginInit();
            groupBoxRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxRegister
            // 
            pictureBoxRegister.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxRegister.Image = (Image)resources.GetObject("pictureBoxRegister.Image");
            pictureBoxRegister.Location = new Point(439, 170);
            pictureBoxRegister.Margin = new Padding(3, 2, 3, 2);
            pictureBoxRegister.Name = "pictureBoxRegister";
            pictureBoxRegister.Size = new Size(329, 260);
            pictureBoxRegister.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRegister.TabIndex = 33;
            pictureBoxRegister.TabStop = false;
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
            groupBoxRegister.Location = new Point(53, 125);
            groupBoxRegister.Margin = new Padding(3, 2, 3, 2);
            groupBoxRegister.Name = "groupBoxRegister";
            groupBoxRegister.Padding = new Padding(3, 2, 3, 2);
            groupBoxRegister.Size = new Size(334, 356);
            groupBoxRegister.TabIndex = 32;
            groupBoxRegister.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(235, 239, 242);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(189, 310);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.FromArgb(207, 206, 242);
            labelName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelName.ForeColor = SystemColors.ActiveCaptionText;
            labelName.Location = new Point(15, 12);
            labelName.Name = "labelName";
            labelName.Size = new Size(66, 19);
            labelName.TabIndex = 13;
            labelName.Text = "Nombres";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.FromArgb(207, 206, 242);
            labelFirstName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelFirstName.ForeColor = SystemColors.ActiveCaptionText;
            labelFirstName.Location = new Point(15, 64);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(65, 19);
            labelFirstName.TabIndex = 14;
            labelFirstName.Text = "apellidos";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(235, 239, 242);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 310);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // labelGmail
            // 
            labelGmail.AutoSize = true;
            labelGmail.BackColor = Color.FromArgb(207, 206, 242);
            labelGmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelGmail.ForeColor = SystemColors.ActiveCaptionText;
            labelGmail.Location = new Point(15, 120);
            labelGmail.Name = "labelGmail";
            labelGmail.Size = new Size(49, 19);
            labelGmail.TabIndex = 16;
            labelGmail.Text = "correo";
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.BackColor = Color.FromArgb(207, 206, 242);
            labelPasword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPasword.ForeColor = SystemColors.ActiveCaptionText;
            labelPasword.Location = new Point(15, 174);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(79, 19);
            labelPasword.TabIndex = 18;
            labelPasword.Text = "Contraseña";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(235, 239, 242);
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(178, 306);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(130, 32);
            btnExit.TabIndex = 21;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // labelVerifyPassword
            // 
            labelVerifyPassword.AutoSize = true;
            labelVerifyPassword.BackColor = Color.FromArgb(207, 206, 242);
            labelVerifyPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelVerifyPassword.ForeColor = SystemColors.ActiveCaptionText;
            labelVerifyPassword.Location = new Point(15, 240);
            labelVerifyPassword.Name = "labelVerifyPassword";
            labelVerifyPassword.Size = new Size(131, 19);
            labelVerifyPassword.TabIndex = 20;
            labelVerifyPassword.Text = "Verficar Contraseña";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(235, 239, 242);
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(15, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 32);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(15, 34);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(307, 23);
            textBoxName.TabIndex = 6;
            // 
            // textBoxVerifyPassword
            // 
            textBoxVerifyPassword.Location = new Point(15, 262);
            textBoxVerifyPassword.Name = "textBoxVerifyPassword";
            textBoxVerifyPassword.Size = new Size(307, 23);
            textBoxVerifyPassword.TabIndex = 19;
            textBoxVerifyPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(15, 86);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(307, 23);
            textBoxLastName.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(15, 142);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(307, 23);
            textBoxEmail.TabIndex = 15;
            // 
            // textBoxPasword
            // 
            textBoxPasword.Location = new Point(15, 196);
            textBoxPasword.Name = "textBoxPasword";
            textBoxPasword.Size = new Size(307, 23);
            textBoxPasword.TabIndex = 17;
            textBoxPasword.UseSystemPasswordChar = true;
            // 
            // labelRegisterNewTicket
            // 
            labelRegisterNewTicket.AutoSize = true;
            labelRegisterNewTicket.BackColor = Color.FromArgb(207, 206, 242);
            labelRegisterNewTicket.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegisterNewTicket.ForeColor = SystemColors.ActiveCaptionText;
            labelRegisterNewTicket.Location = new Point(11, 59);
            labelRegisterNewTicket.Name = "labelRegisterNewTicket";
            labelRegisterNewTicket.Size = new Size(382, 37);
            labelRegisterNewTicket.TabIndex = 31;
            labelRegisterNewTicket.Text = "Actualización de Cliente";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(207, 206, 242);
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(823, 53);
            textBox1.TabIndex = 30;
            // 
            // updateClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            ClientSize = new Size(823, 544);
            Controls.Add(pictureBoxRegister);
            Controls.Add(groupBoxRegister);
            Controls.Add(labelRegisterNewTicket);
            Controls.Add(textBox1);
            Name = "updateClientForm";
            Text = "updateClientForm";
            Load += updateClientForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxRegister).EndInit();
            groupBoxRegister.ResumeLayout(false);
            groupBoxRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxRegister;
        private GroupBox groupBoxRegister;
        private PictureBox pictureBox1;
        private Label labelName;
        private Label labelFirstName;
        private PictureBox pictureBox2;
        private Label labelGmail;
        private Label labelPasword;
        private Button btnExit;
        private Label labelVerifyPassword;
        private Button btnSave;
        private TextBox textBoxName;
        private TextBox textBoxVerifyPassword;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxPasword;
        private Label labelRegisterNewTicket;
        private TextBox textBox1;
    }
}