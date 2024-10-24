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
            labelPasword = new Label();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAccess
            // 
            buttonAccess.BackColor = Color.LightSteelBlue;
            buttonAccess.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonAccess.Location = new Point(182, 288);
            buttonAccess.Name = "buttonAccess";
            buttonAccess.Size = new Size(104, 25);
            buttonAccess.TabIndex = 3;
            buttonAccess.Text = "acceder";
            buttonAccess.UseVisualStyleBackColor = false;
            buttonAccess.Click += buttonAccess_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.LightSteelBlue;
            btnUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUser.Location = new Point(182, 332);
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
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.BackColor = Color.Transparent;
            groupBoxLogin.Controls.Add(labelPasword);
            groupBoxLogin.Controls.Add(btnUser);
            groupBoxLogin.Controls.Add(labelMail);
            groupBoxLogin.Controls.Add(buttonAccess);
            groupBoxLogin.Controls.Add(textBoxMail);
            groupBoxLogin.Controls.Add(textBoxPasword);
            groupBoxLogin.Location = new Point(165, 11);
            groupBoxLogin.Margin = new Padding(3, 2, 3, 2);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Padding = new Padding(3, 2, 3, 2);
            groupBoxLogin.Size = new Size(458, 394);
            groupBoxLogin.TabIndex = 20;
            groupBoxLogin.TabStop = false;
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
            BackColor = Color.MintCream;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxLogin);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "LoginForm";
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
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
    }
}