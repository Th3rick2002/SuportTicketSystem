namespace PresentationLayer.forms.FormAgent
{
    partial class DashboardAgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAgent));
            button5 = new Button();
            AdminButton = new Button();
            button3 = new Button();
            button6 = new Button();
            button7 = new Button();
            principalPictureBox = new PictureBox();
            button4 = new Button();
            Homebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)principalPictureBox).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(-1, 492);
            button5.Name = "button5";
            button5.Size = new Size(251, 57);
            button5.TabIndex = 6;
            button5.Text = "Registro";
            button5.UseVisualStyleBackColor = true;
            // 
            // AdminButton
            // 
            AdminButton.Location = new Point(-1, 240);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(251, 57);
            AdminButton.TabIndex = 8;
            AdminButton.Text = "Admin";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Click += AdminButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(-1, 303);
            button3.Name = "button3";
            button3.Size = new Size(251, 57);
            button3.TabIndex = 9;
            button3.Text = "Clientes";
            button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(-1, 366);
            button6.Name = "button6";
            button6.Size = new Size(251, 57);
            button6.TabIndex = 10;
            button6.Text = "Agentes";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(-1, 429);
            button7.Name = "button7";
            button7.Size = new Size(251, 57);
            button7.TabIndex = 11;
            button7.Text = "Tickets";
            button7.UseVisualStyleBackColor = true;
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
            // button4
            // 
            button4.Location = new Point(-1, 555);
            button4.Name = "button4";
            button4.Size = new Size(251, 57);
            button4.TabIndex = 12;
            button4.Text = "Edición";
            button4.UseVisualStyleBackColor = true;
            // 
            // Homebutton
            // 
            Homebutton.BackColor = Color.White;
            Homebutton.Location = new Point(-1, 177);
            Homebutton.Name = "Homebutton";
            Homebutton.Size = new Size(251, 57);
            Homebutton.TabIndex = 0;
            Homebutton.Text = "Inicio";
            Homebutton.UseVisualStyleBackColor = false;
            Homebutton.Click += Homebutton_Click;
            // 
            // DashboardAgent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(117, 134, 148);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 777);
            Controls.Add(Homebutton);
            Controls.Add(button4);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(AdminButton);
            Controls.Add(button5);
            Controls.Add(principalPictureBox);
            Name = "DashboardAgent";
            Text = "DashboardAgent";
            ((System.ComponentModel.ISupportInitialize)principalPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private Button AdminButton;
        private Button button3;
        private Button button6;
        private Button button7;
        private PictureBox principalPictureBox;
        private Button button4;
        private Button Homebutton;
    }
}