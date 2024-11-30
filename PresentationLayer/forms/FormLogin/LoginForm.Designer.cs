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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            buttonAccess = new Button();
            btnUser = new Button();
            labelMail = new Label();
            textBoxMail = new TextBox();
            textBoxPasword = new TextBox();
            groupBoxLogin = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelPasword = new Label();
            groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonAccess
            // 
            buttonAccess.BackColor = Color.FromArgb(235, 239, 242);
            buttonAccess.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonAccess.Location = new Point(105, 315);
            buttonAccess.Name = "buttonAccess";
            buttonAccess.Size = new Size(104, 25);
            buttonAccess.TabIndex = 3;
            buttonAccess.Text = "acceder";
            buttonAccess.UseVisualStyleBackColor = false;
            buttonAccess.Click += buttonAccess_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(235, 239, 242);
            btnUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUser.Location = new Point(264, 315);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(104, 25);
            btnUser.TabIndex = 4;
            btnUser.Text = "crear usuario";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelMail.ForeColor = SystemColors.ActiveCaptionText;
            labelMail.Location = new Point(105, 158);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(43, 19);
            labelMail.TabIndex = 16;
            labelMail.Text = "Email";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(105, 180);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(275, 23);
            textBoxMail.TabIndex = 15;
            // 
            // textBoxPasword
            // 
            textBoxPasword.Location = new Point(105, 243);
            textBoxPasword.Name = "textBoxPasword";
            textBoxPasword.Size = new Size(275, 23);
            textBoxPasword.TabIndex = 17;
            textBoxPasword.UseSystemPasswordChar = true;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.BackColor = Color.FromArgb(207, 206, 242);
            groupBoxLogin.Controls.Add(pictureBox3);
            groupBoxLogin.Controls.Add(pictureBox2);
            groupBoxLogin.Controls.Add(pictureBox1);
            groupBoxLogin.Controls.Add(labelPasword);
            groupBoxLogin.Controls.Add(btnUser);
            groupBoxLogin.Controls.Add(labelMail);
            groupBoxLogin.Controls.Add(buttonAccess);
            groupBoxLogin.Controls.Add(textBoxMail);
            groupBoxLogin.Controls.Add(textBoxPasword);
            groupBoxLogin.Location = new Point(165, 31);
            groupBoxLogin.Margin = new Padding(3, 2, 3, 2);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Padding = new Padding(3, 2, 3, 2);
            groupBoxLogin.Size = new Size(458, 374);
            groupBoxLogin.TabIndex = 20;
            groupBoxLogin.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(74, 180);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(74, 243);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(169, 38);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPasword.ForeColor = SystemColors.ActiveCaptionText;
            labelPasword.Location = new Point(105, 221);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(79, 19);
            labelPasword.TabIndex = 18;
            labelPasword.Text = "Contraseña";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(824, 450);
            Controls.Add(groupBoxLogin);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "LoginForm";
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonAccess;
        private Button btnUser;
        private Label labelMail;
        private TextBox textBoxMail;
        private TextBox textBoxPasword;
        private GroupBox groupBoxLogin;
        private Label labelPasword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}