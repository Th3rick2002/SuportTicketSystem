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
            FormAdmin_AgentButton = new Button();
            FormAdmin_TicketsButton = new Button();
            principalPictureBox = new PictureBox();
            Homebutton = new Button();
            FormAdmin_ClientButton = new Button();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)principalPictureBox).BeginInit();
            SuspendLayout();
            // 
            // FormAdmin_AgentButton
            // 
            FormAdmin_AgentButton.BackColor = Color.FromArgb(235, 239, 242);
            FormAdmin_AgentButton.ForeColor = Color.Black;
            FormAdmin_AgentButton.Location = new Point(19, 272);
            FormAdmin_AgentButton.Margin = new Padding(3, 2, 3, 2);
            FormAdmin_AgentButton.Name = "FormAdmin_AgentButton";
            FormAdmin_AgentButton.Size = new Size(180, 43);
            FormAdmin_AgentButton.TabIndex = 10;
            FormAdmin_AgentButton.Text = "Agentes";
            FormAdmin_AgentButton.UseVisualStyleBackColor = false;
            FormAdmin_AgentButton.Click += FormAdmin_AgentButton_Click;
            // 
            // FormAdmin_TicketsButton
            // 
            FormAdmin_TicketsButton.BackColor = Color.FromArgb(235, 239, 242);
            FormAdmin_TicketsButton.ForeColor = Color.Black;
            FormAdmin_TicketsButton.Location = new Point(19, 350);
            FormAdmin_TicketsButton.Margin = new Padding(3, 2, 3, 2);
            FormAdmin_TicketsButton.Name = "FormAdmin_TicketsButton";
            FormAdmin_TicketsButton.Size = new Size(180, 43);
            FormAdmin_TicketsButton.TabIndex = 11;
            FormAdmin_TicketsButton.Text = "Tickets";
            FormAdmin_TicketsButton.UseVisualStyleBackColor = false;
            FormAdmin_TicketsButton.Click += FormAdmin_TicketsButton_Click;
            // 
            // principalPictureBox
            // 
            principalPictureBox.BackColor = Color.LightGreen;
            principalPictureBox.Image = (Image)resources.GetObject("principalPictureBox.Image");
            principalPictureBox.Location = new Point(218, -1);
            principalPictureBox.Margin = new Padding(3, 2, 3, 2);
            principalPictureBox.Name = "principalPictureBox";
            principalPictureBox.Size = new Size(987, 583);
            principalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            principalPictureBox.TabIndex = 1;
            principalPictureBox.TabStop = false;
            // 
            // Homebutton
            // 
            Homebutton.BackColor = Color.FromArgb(235, 239, 242);
            Homebutton.ForeColor = Color.Black;
            Homebutton.Location = new Point(19, 123);
            Homebutton.Margin = new Padding(3, 2, 3, 2);
            Homebutton.Name = "Homebutton";
            Homebutton.Size = new Size(180, 43);
            Homebutton.TabIndex = 0;
            Homebutton.Text = "Inicio";
            Homebutton.UseVisualStyleBackColor = false;
            Homebutton.Click += Homebutton_Click;
            // 
            // FormAdmin_ClientButton
            // 
            FormAdmin_ClientButton.BackColor = Color.FromArgb(235, 239, 242);
            FormAdmin_ClientButton.ForeColor = Color.Black;
            FormAdmin_ClientButton.Location = new Point(19, 191);
            FormAdmin_ClientButton.Margin = new Padding(3, 2, 3, 2);
            FormAdmin_ClientButton.Name = "FormAdmin_ClientButton";
            FormAdmin_ClientButton.Size = new Size(180, 43);
            FormAdmin_ClientButton.TabIndex = 9;
            FormAdmin_ClientButton.Text = "Clientes";
            FormAdmin_ClientButton.UseVisualStyleBackColor = false;
            FormAdmin_ClientButton.Click += FormAdmin_ClientButton_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(235, 239, 242);
            buttonExit.ForeColor = Color.Black;
            buttonExit.Location = new Point(19, 508);
            buttonExit.Margin = new Padding(3, 2, 3, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(180, 43);
            buttonExit.TabIndex = 13;
            buttonExit.Text = "Cerrar sesión";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1206, 583);
            Controls.Add(buttonExit);
            Controls.Add(Homebutton);
            Controls.Add(FormAdmin_TicketsButton);
            Controls.Add(FormAdmin_AgentButton);
            Controls.Add(FormAdmin_ClientButton);
            Controls.Add(principalPictureBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardAdmin";
            Text = "DashboardAgent";
            ((System.ComponentModel.ISupportInitialize)principalPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button FormAdmin_AgentButton;
        private Button FormAdmin_TicketsButton;
        private PictureBox principalPictureBox;
        private Button Homebutton;
        private Button FormAdmin_ClientButton;
        private Button buttonExit;
    }
}