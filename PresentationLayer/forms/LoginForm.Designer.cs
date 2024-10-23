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
            labelStartOfSection = new Label();
            buttonAccess = new Button();
            btnUser = new Button();
            labelMail = new Label();
            textBoxMail = new TextBox();
            labelPasword = new Label();
            textBoxPasword = new TextBox();
            SuspendLayout();
            // 
            // labelStartOfSection
            // 
            labelStartOfSection.AutoSize = true;
            labelStartOfSection.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStartOfSection.Location = new Point(347, 52);
            labelStartOfSection.Name = "labelStartOfSection";
            labelStartOfSection.Size = new Size(244, 37);
            labelStartOfSection.TabIndex = 0;
            labelStartOfSection.Text = "INICIO DE SESION";
            // 
            // buttonAccess
            // 
            buttonAccess.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonAccess.Location = new Point(395, 321);
            buttonAccess.Margin = new Padding(3, 4, 3, 4);
            buttonAccess.Name = "buttonAccess";
            buttonAccess.Size = new Size(119, 33);
            buttonAccess.TabIndex = 3;
            buttonAccess.Text = "acceder";
            buttonAccess.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUser.Location = new Point(395, 363);
            btnUser.Margin = new Padding(3, 4, 3, 4);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(119, 33);
            btnUser.TabIndex = 4;
            btnUser.Text = "crear usuario";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelMail.Location = new Point(296, 147);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(51, 23);
            labelMail.TabIndex = 16;
            labelMail.Text = "Email";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(296, 171);
            textBoxMail.Margin = new Padding(3, 4, 3, 4);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(350, 27);
            textBoxMail.TabIndex = 15;
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPasword.Location = new Point(296, 232);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(97, 23);
            labelPasword.TabIndex = 18;
            labelPasword.Text = "Contraseña";
            // 
            // textBoxPasword
            // 
            textBoxPasword.Location = new Point(296, 256);
            textBoxPasword.Margin = new Padding(3, 4, 3, 4);
            textBoxPasword.Name = "textBoxPasword";
            textBoxPasword.Size = new Size(350, 27);
            textBoxPasword.TabIndex = 17;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(labelPasword);
            Controls.Add(textBoxPasword);
            Controls.Add(labelMail);
            Controls.Add(textBoxMail);
            Controls.Add(btnUser);
            Controls.Add(buttonAccess);
            Controls.Add(labelStartOfSection);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStartOfSection;
        private Button buttonAccess;
        private Button btnUser;
        private Label labelMail;
        private TextBox textBoxMail;
        private Label labelPasword;
        private TextBox textBoxPasword;
    }
}