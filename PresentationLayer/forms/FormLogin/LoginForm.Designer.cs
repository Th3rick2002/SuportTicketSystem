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
            pictureBox1 = new PictureBox();
            labelPasword = new Label();
            groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonAccess
            // 
            buttonAccess.BackColor = Color.FromArgb(235, 239, 242);
            buttonAccess.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonAccess.Location = new Point(120, 420);
            buttonAccess.Margin = new Padding(3, 4, 3, 4);
            buttonAccess.Name = "buttonAccess";
            buttonAccess.Size = new Size(119, 33);
            buttonAccess.TabIndex = 3;
            buttonAccess.Text = "acceder";
            buttonAccess.UseVisualStyleBackColor = false;
            buttonAccess.Click += buttonAccess_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(235, 239, 242);
            btnUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUser.Location = new Point(302, 420);
            btnUser.Margin = new Padding(3, 4, 3, 4);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(119, 33);
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
            labelMail.Location = new Point(120, 211);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(51, 23);
            labelMail.TabIndex = 16;
            labelMail.Text = "Email";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(120, 240);
            textBoxMail.Margin = new Padding(3, 4, 3, 4);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(314, 27);
            textBoxMail.TabIndex = 15;
            // 
            // textBoxPasword
            // 
            textBoxPasword.Location = new Point(120, 324);
            textBoxPasword.Margin = new Padding(3, 4, 3, 4);
            textBoxPasword.Name = "textBoxPasword";
            textBoxPasword.Size = new Size(314, 27);
            textBoxPasword.TabIndex = 17;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.BackColor = Color.FromArgb(207, 206, 242);
            groupBoxLogin.Controls.Add(pictureBox1);
            groupBoxLogin.Controls.Add(labelPasword);
            groupBoxLogin.Controls.Add(btnUser);
            groupBoxLogin.Controls.Add(labelMail);
            groupBoxLogin.Controls.Add(buttonAccess);
            groupBoxLogin.Controls.Add(textBoxMail);
            groupBoxLogin.Controls.Add(textBoxPasword);
            groupBoxLogin.Location = new Point(189, 41);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(523, 499);
            groupBoxLogin.TabIndex = 20;
            groupBoxLogin.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(192, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPasword.ForeColor = SystemColors.ActiveCaptionText;
            labelPasword.Location = new Point(120, 295);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(97, 23);
            labelPasword.TabIndex = 18;
            labelPasword.Text = "Contraseña";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 600);
            Controls.Add(groupBoxLogin);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
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
    }
}