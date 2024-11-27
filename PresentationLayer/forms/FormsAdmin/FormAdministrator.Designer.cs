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
            dataGridViewAdmin = new DataGridView();
            panel1 = new Panel();
            labelAgent = new Label();
            textBox2 = new TextBox();
            btnUpdate = new Button();
            LabelNombre = new Label();
            btnAdd = new Button();
            texIdLabel = new Label();
            pictureBox1 = new PictureBox();
            labelIdAdmin = new Label();
            btnDelete = new Button();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAdmin
            // 
            dataGridViewAdmin.BackgroundColor = Color.FromArgb(235, 239, 242);
            dataGridViewAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdmin.Location = new Point(57, 188);
            dataGridViewAdmin.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAdmin.Name = "dataGridViewAdmin";
            dataGridViewAdmin.RowHeadersWidth = 51;
            dataGridViewAdmin.Size = new Size(765, 497);
            dataGridViewAdmin.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(207, 206, 242);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1158, 97);
            panel1.TabIndex = 56;
            // 
            // labelAgent
            // 
            labelAgent.AutoSize = true;
            labelAgent.BackColor = Color.FromArgb(207, 206, 242);
            labelAgent.Font = new Font("Arial", 24F, FontStyle.Bold | FontStyle.Italic);
            labelAgent.ForeColor = Color.Black;
            labelAgent.Location = new Point(31, 16);
            labelAgent.Name = "labelAgent";
            labelAgent.Size = new Size(478, 46);
            labelAgent.TabIndex = 40;
            labelAgent.Text = "Panel de Administracion";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(235, 239, 242);
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(33, 68);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 47);
            textBox2.TabIndex = 50;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(235, 239, 242);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(30, 238);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(210, 59);
            btnUpdate.TabIndex = 42;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.BackColor = Color.DarkSlateGray;
            LabelNombre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            LabelNombre.ForeColor = Color.MintCream;
            LabelNombre.Location = new Point(33, 542);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(0, 23);
            LabelNombre.TabIndex = 47;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(235, 239, 242);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(30, 137);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(210, 57);
            btnAdd.TabIndex = 46;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // texIdLabel
            // 
            texIdLabel.AutoSize = true;
            texIdLabel.BackColor = Color.FromArgb(235, 239, 242);
            texIdLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            texIdLabel.ForeColor = Color.Black;
            texIdLabel.Location = new Point(48, 80);
            texIdLabel.Name = "texIdLabel";
            texIdLabel.Size = new Size(36, 23);
            texIdLabel.TabIndex = 45;
            texIdLabel.Text = "ID :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(235, 239, 242);
            pictureBox1.Image = Properties.Resources.salvado;
            pictureBox1.Location = new Point(48, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelIdAdmin
            // 
            labelIdAdmin.AutoSize = true;
            labelIdAdmin.BackColor = Color.DarkSlateGray;
            labelIdAdmin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelIdAdmin.ForeColor = Color.MintCream;
            labelIdAdmin.Location = new Point(115, 80);
            labelIdAdmin.Name = "labelIdAdmin";
            labelIdAdmin.Size = new Size(0, 23);
            labelIdAdmin.TabIndex = 44;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(235, 239, 242);
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(33, 326);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(213, 59);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(235, 239, 242);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(51, 341);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 55;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(207, 206, 242);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(labelIdAdmin);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(texIdLabel);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(LabelNombre);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(textBox2);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(870, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 685);
            panel2.TabIndex = 57;
            panel2.Paint += panel2_Paint;
            // 
            // FormAdministrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            ClientSize = new Size(1129, 730);
            Controls.Add(labelAgent);
            Controls.Add(dataGridViewAdmin);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdministrator";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label6;
        private DataGridView dataGridViewAdmin;
        private Panel panel1;
        private Label labelAgent;
        private TextBox textBox2;
        private Button btnUpdate;
        private Label LabelNombre;
        private Button btnAdd;
        private Label texIdLabel;
        private PictureBox pictureBox1;
        private Label labelIdAdmin;
        private Button btnDelete;
        private PictureBox pictureBox3;
        private Panel panel2;
    }
}