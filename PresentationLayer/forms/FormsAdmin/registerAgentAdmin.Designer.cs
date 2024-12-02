namespace PresentationLayer.forms.FormsAdmin
{
    partial class registerAgentAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerAgentAdmin));
            labelRegisterNewAgent = new Label();
            textBox1Agent = new TextBox();
            labelNameAgent = new Label();
            labelFirstNameAgent = new Label();
            labelGmailAgent = new Label();
            labelPaswordAgent = new Label();
            labelVerifyPasswordAgent = new Label();
            textBoxNameAgent = new TextBox();
            textBoxVerifyPasswordAgent = new TextBox();
            textBoxLastNameAgent = new TextBox();
            textBoxEmailAgent = new TextBox();
            textBoxPaswordAgent = new TextBox();
            groupBoxRegisterAgent = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnExitAgent = new Button();
            btnSaveAgent = new Button();
            pictureBoxRegisterAgent = new PictureBox();
            groupBoxRegisterAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRegisterAgent).BeginInit();
            SuspendLayout();
            // 
            // labelRegisterNewAgent
            // 
            labelRegisterNewAgent.AutoSize = true;
            labelRegisterNewAgent.BackColor = Color.FromArgb(207, 206, 242);
            labelRegisterNewAgent.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegisterNewAgent.ForeColor = SystemColors.ActiveCaptionText;
            labelRegisterNewAgent.Location = new Point(11, 9);
            labelRegisterNewAgent.Name = "labelRegisterNewAgent";
            labelRegisterNewAgent.Size = new Size(511, 46);
            labelRegisterNewAgent.TabIndex = 27;
            labelRegisterNewAgent.Text = "Registro de Nuevo Agente";
            labelRegisterNewAgent.Click += labelRegisterNewAgent_Click;
            // 
            // textBox1Agent
            // 
            textBox1Agent.BackColor = Color.FromArgb(207, 206, 242);
            textBox1Agent.Dock = DockStyle.Top;
            textBox1Agent.Location = new Point(0, 0);
            textBox1Agent.Multiline = true;
            textBox1Agent.Name = "textBox1Agent";
            textBox1Agent.Size = new Size(914, 69);
            textBox1Agent.TabIndex = 26;
            // 
            // labelNameAgent
            // 
            labelNameAgent.AutoSize = true;
            labelNameAgent.BackColor = Color.FromArgb(207, 206, 242);
            labelNameAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelNameAgent.ForeColor = SystemColors.ActiveCaptionText;
            labelNameAgent.Location = new Point(17, 19);
            labelNameAgent.Name = "labelNameAgent";
            labelNameAgent.Size = new Size(80, 23);
            labelNameAgent.TabIndex = 13;
            labelNameAgent.Text = "Nombres";
            // 
            // labelFirstNameAgent
            // 
            labelFirstNameAgent.AutoSize = true;
            labelFirstNameAgent.BackColor = Color.FromArgb(207, 206, 242);
            labelFirstNameAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelFirstNameAgent.ForeColor = SystemColors.ActiveCaptionText;
            labelFirstNameAgent.Location = new Point(17, 88);
            labelFirstNameAgent.Name = "labelFirstNameAgent";
            labelFirstNameAgent.Size = new Size(77, 23);
            labelFirstNameAgent.TabIndex = 14;
            labelFirstNameAgent.Text = "apellidos";
            // 
            // labelGmailAgent
            // 
            labelGmailAgent.AutoSize = true;
            labelGmailAgent.BackColor = Color.FromArgb(207, 206, 242);
            labelGmailAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelGmailAgent.ForeColor = SystemColors.ActiveCaptionText;
            labelGmailAgent.Location = new Point(17, 163);
            labelGmailAgent.Name = "labelGmailAgent";
            labelGmailAgent.Size = new Size(59, 23);
            labelGmailAgent.TabIndex = 16;
            labelGmailAgent.Text = "correo";
            // 
            // labelPaswordAgent
            // 
            labelPaswordAgent.AutoSize = true;
            labelPaswordAgent.BackColor = Color.FromArgb(207, 206, 242);
            labelPaswordAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPaswordAgent.ForeColor = SystemColors.ActiveCaptionText;
            labelPaswordAgent.Location = new Point(17, 235);
            labelPaswordAgent.Name = "labelPaswordAgent";
            labelPaswordAgent.Size = new Size(97, 23);
            labelPaswordAgent.TabIndex = 18;
            labelPaswordAgent.Text = "Contraseña";
            // 
            // labelVerifyPasswordAgent
            // 
            labelVerifyPasswordAgent.AutoSize = true;
            labelVerifyPasswordAgent.BackColor = Color.FromArgb(207, 206, 242);
            labelVerifyPasswordAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelVerifyPasswordAgent.ForeColor = SystemColors.ActiveCaptionText;
            labelVerifyPasswordAgent.Location = new Point(17, 323);
            labelVerifyPasswordAgent.Name = "labelVerifyPasswordAgent";
            labelVerifyPasswordAgent.Size = new Size(160, 23);
            labelVerifyPasswordAgent.TabIndex = 20;
            labelVerifyPasswordAgent.Text = "Verficar Contraseña";
            // 
            // textBoxNameAgent
            // 
            textBoxNameAgent.Location = new Point(17, 45);
            textBoxNameAgent.Margin = new Padding(3, 4, 3, 4);
            textBoxNameAgent.Name = "textBoxNameAgent";
            textBoxNameAgent.Size = new Size(350, 27);
            textBoxNameAgent.TabIndex = 6;
            // 
            // textBoxVerifyPasswordAgent
            // 
            textBoxVerifyPasswordAgent.Location = new Point(17, 349);
            textBoxVerifyPasswordAgent.Margin = new Padding(3, 4, 3, 4);
            textBoxVerifyPasswordAgent.Name = "textBoxVerifyPasswordAgent";
            textBoxVerifyPasswordAgent.Size = new Size(350, 27);
            textBoxVerifyPasswordAgent.TabIndex = 19;
            textBoxVerifyPasswordAgent.UseSystemPasswordChar = true;
            // 
            // textBoxLastNameAgent
            // 
            textBoxLastNameAgent.Location = new Point(17, 115);
            textBoxLastNameAgent.Margin = new Padding(3, 4, 3, 4);
            textBoxLastNameAgent.Name = "textBoxLastNameAgent";
            textBoxLastNameAgent.Size = new Size(350, 27);
            textBoxLastNameAgent.TabIndex = 12;
            // 
            // textBoxEmailAgent
            // 
            textBoxEmailAgent.Location = new Point(17, 189);
            textBoxEmailAgent.Margin = new Padding(3, 4, 3, 4);
            textBoxEmailAgent.Name = "textBoxEmailAgent";
            textBoxEmailAgent.Size = new Size(350, 27);
            textBoxEmailAgent.TabIndex = 15;
            // 
            // textBoxPaswordAgent
            // 
            textBoxPaswordAgent.Location = new Point(17, 261);
            textBoxPaswordAgent.Margin = new Padding(3, 4, 3, 4);
            textBoxPaswordAgent.Name = "textBoxPaswordAgent";
            textBoxPaswordAgent.Size = new Size(350, 27);
            textBoxPaswordAgent.TabIndex = 17;
            textBoxPaswordAgent.UseSystemPasswordChar = true;
            // 
            // groupBoxRegisterAgent
            // 
            groupBoxRegisterAgent.BackColor = Color.FromArgb(207, 206, 242);
            groupBoxRegisterAgent.Controls.Add(pictureBox1);
            groupBoxRegisterAgent.Controls.Add(labelNameAgent);
            groupBoxRegisterAgent.Controls.Add(labelFirstNameAgent);
            groupBoxRegisterAgent.Controls.Add(pictureBox2);
            groupBoxRegisterAgent.Controls.Add(labelGmailAgent);
            groupBoxRegisterAgent.Controls.Add(labelPaswordAgent);
            groupBoxRegisterAgent.Controls.Add(btnExitAgent);
            groupBoxRegisterAgent.Controls.Add(labelVerifyPasswordAgent);
            groupBoxRegisterAgent.Controls.Add(btnSaveAgent);
            groupBoxRegisterAgent.Controls.Add(textBoxNameAgent);
            groupBoxRegisterAgent.Controls.Add(textBoxVerifyPasswordAgent);
            groupBoxRegisterAgent.Controls.Add(textBoxLastNameAgent);
            groupBoxRegisterAgent.Controls.Add(textBoxEmailAgent);
            groupBoxRegisterAgent.Controls.Add(textBoxPaswordAgent);
            groupBoxRegisterAgent.Location = new Point(59, 97);
            groupBoxRegisterAgent.Name = "groupBoxRegisterAgent";
            groupBoxRegisterAgent.Size = new Size(382, 475);
            groupBoxRegisterAgent.TabIndex = 28;
            groupBoxRegisterAgent.TabStop = false;
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
            // btnExitAgent
            // 
            btnExitAgent.BackColor = Color.FromArgb(235, 239, 242);
            btnExitAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExitAgent.Location = new Point(203, 408);
            btnExitAgent.Margin = new Padding(3, 4, 3, 4);
            btnExitAgent.Name = "btnExitAgent";
            btnExitAgent.Size = new Size(149, 43);
            btnExitAgent.TabIndex = 21;
            btnExitAgent.Text = "Salir";
            btnExitAgent.UseVisualStyleBackColor = false;
            // 
            // btnSaveAgent
            // 
            btnSaveAgent.BackColor = Color.FromArgb(235, 239, 242);
            btnSaveAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSaveAgent.Location = new Point(17, 408);
            btnSaveAgent.Margin = new Padding(3, 4, 3, 4);
            btnSaveAgent.Name = "btnSaveAgent";
            btnSaveAgent.Size = new Size(151, 43);
            btnSaveAgent.TabIndex = 8;
            btnSaveAgent.Text = "Guardar";
            btnSaveAgent.UseVisualStyleBackColor = false;
            btnSaveAgent.Click += btnSaveAgent_Click;
            // 
            // pictureBoxRegisterAgent
            // 
            pictureBoxRegisterAgent.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxRegisterAgent.Image = (Image)resources.GetObject("pictureBoxRegisterAgent.Image");
            pictureBoxRegisterAgent.Location = new Point(501, 157);
            pictureBoxRegisterAgent.Name = "pictureBoxRegisterAgent";
            pictureBoxRegisterAgent.Size = new Size(375, 345);
            pictureBoxRegisterAgent.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRegisterAgent.TabIndex = 29;
            pictureBoxRegisterAgent.TabStop = false;
            // 
            // registerAgentAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            ClientSize = new Size(914, 600);
            Controls.Add(labelRegisterNewAgent);
            Controls.Add(textBox1Agent);
            Controls.Add(groupBoxRegisterAgent);
            Controls.Add(pictureBoxRegisterAgent);
            Name = "registerAgentAdmin";
            Text = "registerAgentAdmin";
            groupBoxRegisterAgent.ResumeLayout(false);
            groupBoxRegisterAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRegisterAgent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegisterNewAgent;
        private TextBox textBox1Agent;
        private Label labelNameAgent;
        private Label labelFirstNameAgent;
        private Label labelGmailAgent;
        private Label labelPaswordAgent;
        private Label labelVerifyPasswordAgent;
        private TextBox textBoxNameAgent;
        private TextBox textBoxVerifyPasswordAgent;
        private TextBox textBoxLastNameAgent;
        private TextBox textBoxEmailAgent;
        private TextBox textBoxPaswordAgent;
        private GroupBox groupBoxRegisterAgent;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnExitAgent;
        private Button btnSaveAgent;
        private PictureBox pictureBoxRegisterAgent;
    }
}