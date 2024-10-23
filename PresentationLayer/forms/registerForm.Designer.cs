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
            btnSave = new Button();
            textBoxName = new TextBox();
            labelRegisterNewTicket = new Label();
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
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(289, 502);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(281, 132);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(350, 27);
            textBoxName.TabIndex = 6;
            // 
            // labelRegisterNewTicket
            // 
            labelRegisterNewTicket.AutoSize = true;
            labelRegisterNewTicket.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegisterNewTicket.Location = new Point(307, 37);
            labelRegisterNewTicket.Name = "labelRegisterNewTicket";
            labelRegisterNewTicket.Size = new Size(352, 37);
            labelRegisterNewTicket.TabIndex = 5;
            labelRegisterNewTicket.Text = "Registro de Nuevo Cliente";
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Location = new Point(281, 201);
            textBoxFirstname.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(350, 27);
            textBoxFirstname.TabIndex = 12;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelName.Location = new Point(281, 108);
            labelName.Name = "labelName";
            labelName.Size = new Size(80, 23);
            labelName.TabIndex = 13;
            labelName.Text = "Nombres";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelFirstName.Location = new Point(281, 177);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(77, 23);
            labelFirstName.TabIndex = 14;
            labelFirstName.Text = "apellidos";
            // 
            // labelGmail
            // 
            labelGmail.AutoSize = true;
            labelGmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelGmail.Location = new Point(281, 252);
            labelGmail.Name = "labelGmail";
            labelGmail.Size = new Size(59, 23);
            labelGmail.TabIndex = 16;
            labelGmail.Text = "correo";
            // 
            // textBoxGmail
            // 
            textBoxGmail.Location = new Point(281, 276);
            textBoxGmail.Margin = new Padding(3, 4, 3, 4);
            textBoxGmail.Name = "textBoxGmail";
            textBoxGmail.Size = new Size(350, 27);
            textBoxGmail.TabIndex = 15;
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPasword.Location = new Point(281, 324);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(97, 23);
            labelPasword.TabIndex = 18;
            labelPasword.Text = "Contraseña";
            // 
            // textBoxPasword
            // 
            textBoxPasword.Location = new Point(281, 348);
            textBoxPasword.Margin = new Padding(3, 4, 3, 4);
            textBoxPasword.Name = "textBoxPasword";
            textBoxPasword.Size = new Size(350, 27);
            textBoxPasword.TabIndex = 17;
            // 
            // labelVerifyPassword
            // 
            labelVerifyPassword.AutoSize = true;
            labelVerifyPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelVerifyPassword.Location = new Point(281, 412);
            labelVerifyPassword.Name = "labelVerifyPassword";
            labelVerifyPassword.Size = new Size(160, 23);
            labelVerifyPassword.TabIndex = 20;
            labelVerifyPassword.Text = "Verficar Contraseña";
            // 
            // textBoxVerifyPassword
            // 
            textBoxVerifyPassword.Location = new Point(281, 436);
            textBoxVerifyPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxVerifyPassword.Name = "textBoxVerifyPassword";
            textBoxVerifyPassword.Size = new Size(350, 27);
            textBoxVerifyPassword.TabIndex = 19;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(486, 502);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 30);
            btnExit.TabIndex = 21;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnExit);
            Controls.Add(labelVerifyPassword);
            Controls.Add(textBoxVerifyPassword);
            Controls.Add(labelPasword);
            Controls.Add(textBoxPasword);
            Controls.Add(labelGmail);
            Controls.Add(textBoxGmail);
            Controls.Add(labelFirstName);
            Controls.Add(labelName);
            Controls.Add(textBoxFirstname);
            Controls.Add(btnSave);
            Controls.Add(textBoxName);
            Controls.Add(labelRegisterNewTicket);
            Margin = new Padding(3, 4, 3, 4);
            Name = "registerForm";
            Text = "registerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox textBoxName;
        private Label labelRegisterNewTicket;
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
    }
}