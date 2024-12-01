namespace PresentationLayer.forms
{
    partial class AgentPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentPanelForm));
            label2 = new Label();
            labelText = new Label();
            StartTicket = new Button();
            FinalizeTicket = new Button();
            btnExit = new Button();
            textBox1 = new TextBox();
            PanelAgenttextBox = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridViewTickets = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-31, 157);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 15;
            label2.Text = "Id";
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.BackColor = Color.FromArgb(207, 206, 242);
            labelText.Font = new Font("Berlin Sans FB", 26.25F, FontStyle.Bold);
            labelText.Location = new Point(43, 24);
            labelText.Name = "labelText";
            labelText.Size = new Size(426, 56);
            labelText.TabIndex = 26;
            labelText.Text = "PANEL DE AGENTE";
            // 
            // StartTicket
            // 
            StartTicket.BackColor = Color.FromArgb(235, 239, 242);
            StartTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartTicket.Location = new Point(1048, 174);
            StartTicket.Margin = new Padding(3, 4, 3, 4);
            StartTicket.Name = "StartTicket";
            StartTicket.Size = new Size(150, 59);
            StartTicket.TabIndex = 27;
            StartTicket.Text = "Empezar";
            StartTicket.UseVisualStyleBackColor = false;
            StartTicket.Click += StartTicket_Click;
            // 
            // FinalizeTicket
            // 
            FinalizeTicket.BackColor = Color.FromArgb(235, 239, 242);
            FinalizeTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FinalizeTicket.Location = new Point(1048, 308);
            FinalizeTicket.Margin = new Padding(3, 4, 3, 11);
            FinalizeTicket.Name = "FinalizeTicket";
            FinalizeTicket.Size = new Size(150, 59);
            FinalizeTicket.TabIndex = 28;
            FinalizeTicket.Text = "Finalizar";
            FinalizeTicket.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(235, 239, 242);
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1048, 439);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 59);
            btnExit.TabIndex = 29;
            btnExit.Text = "Cerrar sesión";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(207, 206, 242);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1023, 102);
            textBox1.TabIndex = 30;
            // 
            // PanelAgenttextBox
            // 
            PanelAgenttextBox.BackColor = Color.FromArgb(207, 206, 242);
            PanelAgenttextBox.BorderStyle = BorderStyle.None;
            PanelAgenttextBox.Dock = DockStyle.Right;
            PanelAgenttextBox.Location = new Point(1023, 0);
            PanelAgenttextBox.Multiline = true;
            PanelAgenttextBox.Name = "PanelAgenttextBox";
            PanelAgenttextBox.Size = new Size(187, 697);
            PanelAgenttextBox.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(207, 206, 242);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1048, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewTickets
            // 
            dataGridViewTickets.BackgroundColor = Color.FromArgb(207, 206, 242);
            dataGridViewTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTickets.Location = new Point(59, 122);
            dataGridViewTickets.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.RowHeadersWidth = 51;
            dataGridViewTickets.Size = new Size(929, 562);
            dataGridViewTickets.TabIndex = 44;
            // 
            // AgentPanelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1210, 697);
            Controls.Add(dataGridViewTickets);
            Controls.Add(pictureBox1);
            Controls.Add(StartTicket);
            Controls.Add(btnExit);
            Controls.Add(FinalizeTicket);
            Controls.Add(labelText);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(PanelAgenttextBox);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgentPanelForm";
            Text = "AgentForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label labelText;
        private Button StartTicket;
        private Button FinalizeTicket;
        private Button btnExit;
        private TextBox textBox1;
        private TextBox PanelAgenttextBox;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewTickets;
    }
}