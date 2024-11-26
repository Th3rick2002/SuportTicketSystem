namespace PresentationLayer.forms
{
    partial class FormAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrator));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelIdTicket = new Label();
            texIdLabel = new Label();
            textBox2 = new TextBox();
            LabelNombre = new Label();
            labelNombreTicket = new Label();
            textBox3 = new TextBox();
            btnExit = new Button();
            btnFinish = new Button();
            btnStart = new Button();
            dataGridViewAdmin = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            labelAgent = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmin).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkSlateGray;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(48, 231);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 55;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkSlateGray;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 310);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.salvado;
            pictureBox1.Location = new Point(49, 400);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelIdTicket
            // 
            labelIdTicket.AutoSize = true;
            labelIdTicket.BackColor = Color.DarkSlateGray;
            labelIdTicket.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelIdTicket.ForeColor = Color.MintCream;
            labelIdTicket.Location = new Point(115, 80);
            labelIdTicket.Name = "labelIdTicket";
            labelIdTicket.Size = new Size(55, 23);
            labelIdTicket.TabIndex = 44;
            labelIdTicket.Text = "label3";
            // 
            // texIdLabel
            // 
            texIdLabel.AutoSize = true;
            texIdLabel.BackColor = Color.DarkSlateGray;
            texIdLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            texIdLabel.ForeColor = Color.MintCream;
            texIdLabel.Location = new Point(48, 80);
            texIdLabel.Name = "texIdLabel";
            texIdLabel.Size = new Size(36, 23);
            texIdLabel.TabIndex = 45;
            texIdLabel.Text = "ID :";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkSlateGray;
            textBox2.Location = new Point(3, 68);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 47);
            textBox2.TabIndex = 50;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.BackColor = Color.DarkSlateGray;
            LabelNombre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            LabelNombre.ForeColor = Color.MintCream;
            LabelNombre.Location = new Point(32, 164);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(82, 23);
            LabelNombre.TabIndex = 47;
            LabelNombre.Text = "Nombre :";
            // 
            // labelNombreTicket
            // 
            labelNombreTicket.AutoSize = true;
            labelNombreTicket.BackColor = Color.DarkSlateGray;
            labelNombreTicket.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelNombreTicket.ForeColor = Color.MintCream;
            labelNombreTicket.Location = new Point(120, 164);
            labelNombreTicket.Name = "labelNombreTicket";
            labelNombreTicket.Size = new Size(55, 23);
            labelNombreTicket.TabIndex = 48;
            labelNombreTicket.Text = "label3";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkSlateGray;
            textBox3.Location = new Point(3, 151);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(280, 47);
            textBox3.TabIndex = 51;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkSlateGray;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = Color.MintCream;
            btnExit.Location = new Point(0, 299);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(283, 57);
            btnExit.TabIndex = 46;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.DarkSlateGray;
            btnFinish.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnFinish.ForeColor = Color.MintCream;
            btnFinish.Location = new Point(0, 216);
            btnFinish.Margin = new Padding(3, 4, 3, 4);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(283, 59);
            btnFinish.TabIndex = 43;
            btnFinish.Text = "Finalizar";
            btnFinish.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DarkSlateGray;
            btnStart.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnStart.ForeColor = Color.MintCream;
            btnStart.Location = new Point(0, 390);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(283, 59);
            btnStart.TabIndex = 42;
            btnStart.Text = "Empezar";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // dataGridViewAdmin
            // 
            dataGridViewAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdmin.Location = new Point(42, 143);
            dataGridViewAdmin.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAdmin.Name = "dataGridViewAdmin";
            dataGridViewAdmin.RowHeadersWidth = 51;
            dataGridViewAdmin.Size = new Size(688, 452);
            dataGridViewAdmin.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(117, 134, 148);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1158, 125);
            panel1.TabIndex = 56;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(117, 134, 148);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(btnFinish);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(labelIdTicket);
            panel2.Controls.Add(labelNombreTicket);
            panel2.Controls.Add(texIdLabel);
            panel2.Controls.Add(LabelNombre);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(btnStart);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(849, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 664);
            panel2.TabIndex = 57;
            // 
            // labelAgent
            // 
            labelAgent.AutoSize = true;
            labelAgent.BackColor = Color.FromArgb(117, 134, 148);
            labelAgent.Font = new Font("Arial", 24F, FontStyle.Bold | FontStyle.Italic);
            labelAgent.ForeColor = Color.MintCream;
            labelAgent.Location = new Point(31, 16);
            labelAgent.Name = "labelAgent";
            labelAgent.Size = new Size(478, 46);
            labelAgent.TabIndex = 40;
            labelAgent.Text = "Panel de Administracion";
            // 
            // FormAdministrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 109, 130);
            ClientSize = new Size(1129, 730);
            Controls.Add(labelAgent);
            Controls.Add(dataGridViewAdmin);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdministrator";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmin).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labelIdTicket;
        private Label texIdLabel;
        private TextBox textBox2;
        private Label LabelNombre;
        private Label labelNombreTicket;
        private TextBox textBox3;
        private Button btnExit;
        private Button btnFinish;
        private Button btnStart;
        private DataGridView dataGridViewAdmin;
        private Panel panel1;
        private Panel panel2;
        private Label labelAgent;
    }
}