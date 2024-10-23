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
            labelStartOfSection = new Label();
            buttonAccess = new Button();
            btnUser = new Button();
            labelMail = new Label();
            textBoxMail = new TextBox();
            labelPasword = new Label();
            textBoxPasword = new TextBox();
            groupBoxLogin = new GroupBox();
            pictureBoxLogin = new PictureBox();
            groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // labelStartOfSection
            // 
            labelStartOfSection.AutoSize = true;
            labelStartOfSection.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStartOfSection.ForeColor = SystemColors.ActiveBorder;
            labelStartOfSection.Location = new Point(102, 17);
            labelStartOfSection.Name = "labelStartOfSection";
            labelStartOfSection.Size = new Size(244, 37);
            labelStartOfSection.TabIndex = 0;
            labelStartOfSection.Text = "INICIO DE SESION";
            // 
            // buttonAccess
            // 
            buttonAccess.BackColor = Color.LightSteelBlue;
            buttonAccess.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonAccess.Location = new Point(150, 290);
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
            btnUser.BackColor = Color.LightSteelBlue;
            btnUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUser.Location = new Point(150, 354);
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
            labelMail.ForeColor = SystemColors.ActiveBorder;
            labelMail.Location = new Point(51, 112);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(51, 23);
            labelMail.TabIndex = 16;
            labelMail.Text = "Email";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(51, 145);
            textBoxMail.Margin = new Padding(3, 4, 3, 4);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(350, 27);
            textBoxMail.TabIndex = 15;
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPasword.ForeColor = SystemColors.ActiveBorder;
            labelPasword.Location = new Point(51, 206);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(97, 23);
            labelPasword.TabIndex = 18;
            labelPasword.Text = "Contraseña";
            // 
            // textBoxPasword
            // 
            textBoxPasword.Location = new Point(51, 230);
            textBoxPasword.Margin = new Padding(3, 4, 3, 4);
            textBoxPasword.Name = "textBoxPasword";
            textBoxPasword.Size = new Size(350, 27);
            textBoxPasword.TabIndex = 17;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.BackColor = Color.MediumPurple;
            groupBoxLogin.Controls.Add(btnUser);
            groupBoxLogin.Controls.Add(labelPasword);
            groupBoxLogin.Controls.Add(labelStartOfSection);
            groupBoxLogin.Controls.Add(textBoxPasword);
            groupBoxLogin.Controls.Add(buttonAccess);
            groupBoxLogin.Controls.Add(labelMail);
            groupBoxLogin.Controls.Add(textBoxMail);
            groupBoxLogin.Location = new Point(234, 160);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(435, 417);
            groupBoxLogin.TabIndex = 19;
            groupBoxLogin.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = (Image)resources.GetObject("pictureBoxLogin.Image");
            pictureBoxLogin.Location = new Point(372, 23);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(148, 117);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogin.TabIndex = 20;
            pictureBoxLogin.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBoxLogin);
            Controls.Add(groupBoxLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelStartOfSection;
        private Button buttonAccess;
        private Button btnUser;
        private Label labelMail;
        private TextBox textBoxMail;
        private Label labelPasword;
        private TextBox textBoxPasword;
        private GroupBox groupBoxLogin;
        private PictureBox pictureBoxLogin;
    }
}