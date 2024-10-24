namespace PresentationLayer.forms
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            btnExit = new Button();
            btnAdd = new Button();
            dataGridViewClient = new DataGridView();
            lblClient = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.ForestGreen;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = Color.Lavender;
            btnExit.Location = new Point(1064, 409);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(161, 47);
            btnExit.TabIndex = 39;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.GhostWhite;
            btnAdd.Location = new Point(1064, 308);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 49);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridViewClient
            // 
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.Location = new Point(72, 97);
            dataGridViewClient.Margin = new Padding(4, 5, 4, 5);
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.RowHeadersWidth = 51;
            dataGridViewClient.Size = new Size(860, 638);
            dataGridViewClient.TabIndex = 37;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = Color.ForestGreen;
            lblClient.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClient.ForeColor = Color.GhostWhite;
            lblClient.Location = new Point(13, 22);
            lblClient.Margin = new Padding(4, 0, 4, 0);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(313, 38);
            lblClient.TabIndex = 29;
            lblClient.Text = "Panel De Cliente";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.ForestGreen;
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1320, 89);
            textBox1.TabIndex = 40;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkSlateGray;
            textBox2.Dock = DockStyle.Right;
            textBox2.Location = new Point(998, 89);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 660);
            textBox2.TabIndex = 41;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSlateGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1064, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 749);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(lblClient);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewClient);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormClient";
            Text = "RequestForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExit;
        private Button btnAdd;
        private DataGridView dataGridViewClient;
        private Label lblClient;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
    }
}