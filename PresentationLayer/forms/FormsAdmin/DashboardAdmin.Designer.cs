namespace PresentationLayer.forms.FormAgent
{
    partial class DashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            button5 = new Button();
            AdminButton = new Button();
            FormAdmin_AgentButton = new Button();
            FormAdmin_TicketsButton = new Button();
            principalPictureBox = new PictureBox();
            buttonTag = new Button();
            Homebutton = new Button();
            FormAdmin_ClientButton = new Button();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)principalPictureBox).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(235, 239, 242);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(22, 479);
            button5.Name = "button5";
            button5.Size = new Size(206, 57);
            button5.TabIndex = 6;
            button5.Text = "Registro";
            button5.UseVisualStyleBackColor = false;
            // 
            // AdminButton
            // 
            AdminButton.BackColor = Color.FromArgb(235, 239, 242);
            AdminButton.ForeColor = Color.Black;
            AdminButton.Location = new Point(22, 227);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(206, 57);
            AdminButton.TabIndex = 8;
            AdminButton.Text = "Admin";
            AdminButton.UseVisualStyleBackColor = false;
            AdminButton.Click += AdminButton_Click;
            // 
            // FormAdmin_AgentButton
            // 
            FormAdmin_AgentButton.BackColor = Color.FromArgb(235, 239, 242);
            FormAdmin_AgentButton.ForeColor = Color.Black;
            FormAdmin_AgentButton.Location = new Point(22, 353);
            FormAdmin_AgentButton.Name = "FormAdmin_AgentButton";
            FormAdmin_AgentButton.Size = new Size(206, 57);
            FormAdmin_AgentButton.TabIndex = 10;
            FormAdmin_AgentButton.Text = "Agentes";
            FormAdmin_AgentButton.UseVisualStyleBackColor = false;
            FormAdmin_AgentButton.Click += FormAdmin_AgentButton_Click;
            // 
            // FormAdmin_TicketsButton
            // 
            FormAdmin_TicketsButton.BackColor = Color.FromArgb(235, 239, 242);
            FormAdmin_TicketsButton.ForeColor = Color.Black;
            FormAdmin_TicketsButton.Location = new Point(22, 416);
            FormAdmin_TicketsButton.Name = "FormAdmin_TicketsButton";
            FormAdmin_TicketsButton.Size = new Size(206, 57);
            FormAdmin_TicketsButton.TabIndex = 11;
            FormAdmin_TicketsButton.Text = "Tickets";
            FormAdmin_TicketsButton.UseVisualStyleBackColor = false;
            FormAdmin_TicketsButton.Click += FormAdmin_TicketsButton_Click;
            // 
            // principalPictureBox
            // 
            principalPictureBox.BackColor = Color.LightGreen;
            principalPictureBox.Image = (Image)resources.GetObject("principalPictureBox.Image");
            principalPictureBox.Location = new Point(249, -1);
            principalPictureBox.Name = "principalPictureBox";
            principalPictureBox.Size = new Size(1128, 777);
            principalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            principalPictureBox.TabIndex = 1;
            principalPictureBox.TabStop = false;
            // 
            // buttonTag
            // 
            buttonTag.BackColor = Color.FromArgb(235, 239, 242);
            buttonTag.ForeColor = Color.Black;
            buttonTag.Location = new Point(22, 542);
            buttonTag.Name = "buttonTag";
            buttonTag.Size = new Size(206, 57);
            buttonTag.TabIndex = 12;
            buttonTag.Text = "Categorias/Etiquetas";
            buttonTag.UseVisualStyleBackColor = false;
            // 
            // Homebutton
            // 
            Homebutton.BackColor = Color.FromArgb(235, 239, 242);
            Homebutton.ForeColor = Color.Black;
            Homebutton.Location = new Point(22, 164);
            Homebutton.Name = "Homebutton";
            Homebutton.Size = new Size(206, 57);
            Homebutton.TabIndex = 0;
            Homebutton.Text = "Inicio";
            Homebutton.UseVisualStyleBackColor = false;
            Homebutton.Click += Homebutton_Click;
            // 
            // FormAdmin_ClientButton
            // 
            FormAdmin_ClientButton.BackColor = Color.FromArgb(235, 239, 242);
            FormAdmin_ClientButton.ForeColor = Color.Black;
            FormAdmin_ClientButton.Location = new Point(22, 290);
            FormAdmin_ClientButton.Name = "FormAdmin_ClientButton";
            FormAdmin_ClientButton.Size = new Size(206, 57);
            FormAdmin_ClientButton.TabIndex = 9;
            FormAdmin_ClientButton.Text = "Clientes";
            FormAdmin_ClientButton.UseVisualStyleBackColor = false;
            FormAdmin_ClientButton.Click += FormAdmin_ClientButton_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(235, 239, 242);
            buttonExit.ForeColor = Color.Black;
            buttonExit.Location = new Point(22, 678);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(206, 57);
            buttonExit.TabIndex = 13;
            buttonExit.Text = "Cerrar sesión";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 777);
            Controls.Add(buttonExit);
            Controls.Add(Homebutton);
            Controls.Add(buttonTag);
            Controls.Add(FormAdmin_TicketsButton);
            Controls.Add(FormAdmin_AgentButton);
            Controls.Add(FormAdmin_ClientButton);
            Controls.Add(AdminButton);
            Controls.Add(button5);
            Controls.Add(principalPictureBox);
            Name = "DashboardAdmin";
            Text = "DashboardAgent";
            ((System.ComponentModel.ISupportInitialize)principalPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private Button AdminButton;
        private Button FormAdmin_AgentButton;
        private Button FormAdmin_TicketsButton;
        private PictureBox principalPictureBox;
        private Button buttonTag;
        private Button Homebutton;
        private Button FormAdmin_ClientButton;
        private Button buttonExit;
    }
}