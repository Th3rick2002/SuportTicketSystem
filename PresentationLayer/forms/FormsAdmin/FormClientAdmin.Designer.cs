namespace PresentationLayer.forms.FormsAdmin
{
    partial class FormClientAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientAdmin));
            dataGridViewAgents = new DataGridView();
            pictureBox1 = new PictureBox();
            btnAdd = new Button();
            textBoxCustomer = new TextBox();
            textBoxCouster = new TextBox();
            label1 = new Label();
            btnUpdate = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAgents
            // 
            dataGridViewAgents.BackgroundColor = Color.FromArgb(235, 239, 242);
            dataGridViewAgents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgents.GridColor = Color.Black;
            dataGridViewAgents.Location = new Point(12, 89);
            dataGridViewAgents.Name = "dataGridViewAgents";
            dataGridViewAgents.RowHeadersWidth = 51;
            dataGridViewAgents.Size = new Size(779, 447);
            dataGridViewAgents.TabIndex = 48;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(207, 206, 242);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(819, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(235, 239, 242);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(819, 175);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 37);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "Agregar ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.BackColor = Color.FromArgb(207, 206, 242);
            textBoxCustomer.BorderStyle = BorderStyle.None;
            textBoxCustomer.Dock = DockStyle.Right;
            textBoxCustomer.Location = new Point(797, 0);
            textBoxCustomer.Multiline = true;
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.Size = new Size(191, 548);
            textBoxCustomer.TabIndex = 51;
            // 
            // textBoxCouster
            // 
            textBoxCouster.BackColor = Color.FromArgb(207, 206, 242);
            textBoxCouster.BorderStyle = BorderStyle.None;
            textBoxCouster.Dock = DockStyle.Top;
            textBoxCouster.Location = new Point(0, 0);
            textBoxCouster.Multiline = true;
            textBoxCouster.Name = "textBoxCouster";
            textBoxCouster.Size = new Size(797, 83);
            textBoxCouster.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(207, 206, 242);
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(377, 39);
            label1.TabIndex = 52;
            label1.Text = "PANEL DE CLIENTE  ";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(235, 239, 242);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(819, 263);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(141, 35);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Actualizar ";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(235, 239, 242);
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(819, 345);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(141, 35);
            button3.TabIndex = 49;
            button3.Text = "Eliminar ";
            button3.UseVisualStyleBackColor = false;
            // 
            // FormClientAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            ClientSize = new Size(988, 548);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewAgents);
            Controls.Add(textBoxCouster);
            Controls.Add(textBoxCustomer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormClientAdmin";
            Text = "FormClientAdmin";
            Load += FormClientAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgents).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAgents;
        private PictureBox pictureBox1;
        private Button btnAdd;
        private TextBox textBoxCustomer;
        private TextBox textBoxCouster;
        private Label label1;
        private Button btnUpdate;
        private Button button3;
    }
}