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
            labelAgent = new Label();
            labelIdTicket = new Label();
            texIdLabel = new Label();
            textBox2 = new TextBox();
            LabelNombre = new Label();
            labelNombreTicket = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnExit = new Button();
            btnFinish = new Button();
            btnStart = new Button();
            dataGridViewAdmin = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmin).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkSlateGray;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(875, 248);
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
            pictureBox2.Location = new Point(877, 327);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.salvado;
            pictureBox1.Location = new Point(876, 417);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // labelAgent
            // 
            labelAgent.AutoSize = true;
            labelAgent.BackColor = Color.ForestGreen;
            labelAgent.Font = new Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAgent.ForeColor = Color.MintCream;
            labelAgent.Location = new Point(31, 16);
            labelAgent.Name = "labelAgent";
            labelAgent.Size = new Size(528, 44);
            labelAgent.TabIndex = 40;
            labelAgent.Text = "Panel de Administracion";
            // 
            // labelIdTicket
            // 
            labelIdTicket.AutoSize = true;
            labelIdTicket.BackColor = Color.DarkSlateGray;
            labelIdTicket.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelIdTicket.ForeColor = Color.MintCream;
            labelIdTicket.Location = new Point(942, 105);
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
            texIdLabel.Location = new Point(875, 105);
            texIdLabel.Name = "texIdLabel";
            texIdLabel.Size = new Size(36, 23);
            texIdLabel.TabIndex = 45;
            texIdLabel.Text = "ID :";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkSlateGray;
            textBox2.Location = new Point(830, 93);
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
            LabelNombre.Location = new Point(859, 181);
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
            labelNombreTicket.Location = new Point(947, 181);
            labelNombreTicket.Name = "labelNombreTicket";
            labelNombreTicket.Size = new Size(55, 23);
            labelNombreTicket.TabIndex = 48;
            labelNombreTicket.Text = "label3";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkSlateGray;
            textBox3.Location = new Point(830, 168);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(280, 47);
            textBox3.TabIndex = 51;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.ForestGreen;
            textBox4.Dock = DockStyle.Top;
            textBox4.Location = new Point(0, 0);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(1110, 87);
            textBox4.TabIndex = 52;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkSlateGray;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = Color.MintCream;
            btnExit.Location = new Point(830, 316);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(280, 57);
            btnExit.TabIndex = 46;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.DarkSlateGray;
            btnFinish.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnFinish.ForeColor = Color.MintCream;
            btnFinish.Location = new Point(830, 233);
            btnFinish.Margin = new Padding(3, 4, 3, 4);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(280, 59);
            btnFinish.TabIndex = 43;
            btnFinish.Text = "Finalizar";
            btnFinish.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DarkSlateGray;
            btnStart.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnStart.ForeColor = Color.MintCream;
            btnStart.Location = new Point(830, 407);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(280, 59);
            btnStart.TabIndex = 42;
            btnStart.Text = "Empezar";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // dataGridViewAdmin
            // 
            dataGridViewAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdmin.Location = new Point(42, 124);
            dataGridViewAdmin.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAdmin.Name = "dataGridViewAdmin";
            dataGridViewAdmin.RowHeadersWidth = 51;
            dataGridViewAdmin.Size = new Size(688, 452);
            dataGridViewAdmin.TabIndex = 41;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SeaGreen;
            textBox1.Location = new Point(830, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 735);
            textBox1.TabIndex = 49;
            // 
            // FormAdministrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 730);
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
            Controls.Add(dataGridViewAdmin);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdministrator";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labelAgent;
        private Label labelIdTicket;
        private Label texIdLabel;
        private TextBox textBox2;
        private Label LabelNombre;
        private Label labelNombreTicket;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnExit;
        private Button btnFinish;
        private Button btnStart;
        private DataGridView dataGridViewAdmin;
        private TextBox textBox1;
    }
}