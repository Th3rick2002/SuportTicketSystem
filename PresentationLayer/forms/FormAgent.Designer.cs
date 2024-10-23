namespace PresentationLayer.forms
{
    partial class FormAgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgent));
            btnFinish = new Button();
            btnStart = new Button();
            dataGridViewAgent = new DataGridView();
            label2 = new Label();
            labelAgent = new Label();
            labelIdTicket = new Label();
            texIdLabel = new Label();
            btnExit = new Button();
            LabelNombre = new Label();
            labelNombreTicket = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.DarkSlateGray;
            btnFinish.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnFinish.ForeColor = Color.MintCream;
            btnFinish.Location = new Point(775, 301);
            btnFinish.Margin = new Padding(3, 4, 3, 4);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(266, 58);
            btnFinish.TabIndex = 27;
            btnFinish.Text = "Finalizar";
            btnFinish.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DarkSlateGray;
            btnStart.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnStart.ForeColor = Color.MintCream;
            btnStart.Location = new Point(775, 461);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(266, 59);
            btnStart.TabIndex = 26;
            btnStart.Text = "Empezar";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // dataGridViewAgent
            // 
            dataGridViewAgent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgent.Location = new Point(42, 123);
            dataGridViewAgent.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAgent.Name = "dataGridViewAgent";
            dataGridViewAgent.RowHeadersWidth = 51;
            dataGridViewAgent.Size = new Size(688, 452);
            dataGridViewAgent.TabIndex = 25;
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
            // labelAgent
            // 
            labelAgent.AutoSize = true;
            labelAgent.BackColor = Color.ForestGreen;
            labelAgent.Font = new Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAgent.ForeColor = Color.MintCream;
            labelAgent.Location = new Point(31, 15);
            labelAgent.Name = "labelAgent";
            labelAgent.Size = new Size(349, 44);
            labelAgent.TabIndex = 14;
            labelAgent.Text = "Panel de Agente";
            // 
            // labelIdTicket
            // 
            labelIdTicket.AutoSize = true;
            labelIdTicket.BackColor = Color.DarkSlateGray;
            labelIdTicket.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelIdTicket.ForeColor = Color.MintCream;
            labelIdTicket.Location = new Point(887, 164);
            labelIdTicket.Name = "labelIdTicket";
            labelIdTicket.Size = new Size(55, 23);
            labelIdTicket.TabIndex = 28;
            labelIdTicket.Text = "label3";
            // 
            // texIdLabel
            // 
            texIdLabel.AutoSize = true;
            texIdLabel.BackColor = Color.DarkSlateGray;
            texIdLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            texIdLabel.ForeColor = Color.MintCream;
            texIdLabel.Location = new Point(834, 164);
            texIdLabel.Name = "texIdLabel";
            texIdLabel.Size = new Size(36, 23);
            texIdLabel.TabIndex = 29;
            texIdLabel.Text = "ID :";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkSlateGray;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = Color.MintCream;
            btnExit.Location = new Point(778, 381);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(266, 57);
            btnExit.TabIndex = 30;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.BackColor = Color.DarkSlateGray;
            LabelNombre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            LabelNombre.ForeColor = Color.MintCream;
            LabelNombre.Location = new Point(799, 240);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(82, 23);
            LabelNombre.TabIndex = 31;
            LabelNombre.Text = "Nombre :";
            // 
            // labelNombreTicket
            // 
            labelNombreTicket.AutoSize = true;
            labelNombreTicket.BackColor = Color.DarkSlateGray;
            labelNombreTicket.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelNombreTicket.ForeColor = Color.MintCream;
            labelNombreTicket.Location = new Point(887, 240);
            labelNombreTicket.Name = "labelNombreTicket";
            labelNombreTicket.Size = new Size(55, 23);
            labelNombreTicket.TabIndex = 32;
            labelNombreTicket.Text = "label3";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkSlateGray;
            textBox1.Location = new Point(775, 30);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 570);
            textBox1.TabIndex = 33;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkSlateGray;
            textBox2.Location = new Point(778, 152);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 47);
            textBox2.TabIndex = 34;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkSlateGray;
            textBox3.Location = new Point(775, 228);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(263, 47);
            textBox3.TabIndex = 35;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.ForestGreen;
            textBox4.Dock = DockStyle.Top;
            textBox4.Location = new Point(0, 0);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(1041, 87);
            textBox4.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.salvado;
            pictureBox1.Location = new Point(812, 471);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(812, 392);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(812, 316);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(834, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(145, 108);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            // 
            // FormAgent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 600);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelAgent);
            Controls.Add(labelIdTicket);
            Controls.Add(texIdLabel);
            Controls.Add(textBox2);
            Controls.Add(LabelNombre);
            Controls.Add(labelNombreTicket);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(btnExit);
            Controls.Add(btnFinish);
            Controls.Add(btnStart);
            Controls.Add(dataGridViewAgent);
            Controls.Add(label2);
            Controls.Add(textBox1);
            ForeColor = Color.Cyan;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAgent";
            Text = "AgentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFinish;
        private Button btnStart;
        private DataGridView dataGridViewAgent;
        private Label label2;
        private Label labelAgent;
        private Label labelIdTicket;
        private Label texIdLabel;
        private Button btnExit;
        private Label LabelNombre;
        private Label labelNombreTicket;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}